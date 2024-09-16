using Azure.AI.OpenAI;
using DevExpress.AIIntegration;
using DevExpress.AIIntegration.Extensions;
using DevExpress.AIIntegration.Localization;
using DevExpress.Data;
using System.Globalization;


namespace Runtime_AI_Extensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Enable sending large texts to Ollama
            //AsyncDownloadPolicy.ConfigureHttpClient += AsyncDownloadPolicy_ConfigureHttpClient;

            //Enable localization
            //AIIntegrationLocalizer.Active = new CustomAILocalizer();

            SampleAITextModifier s = new SampleAITextModifier();
            s.ChangeDefaults();
            Console.WriteLine(s.GetTranslation("William Shakespeare is a great famous British writer", "Spanish").Result);
            Console.WriteLine();
            Console.WriteLine("William Shakespeare about Elon Musk:" + Environment.NewLine);
            Console.WriteLine(s.GetShakespeareText("Elon Reeve Musk FRS (born June 28, 1971) is a businessman and investor known for his key roles in space company SpaceX and automotive company Tesla, Inc..").Result);
            Console.WriteLine();
            Console.WriteLine("Mark Twain about Elon Musk:" + Environment.NewLine);
            Console.WriteLine(s.GetMarkTwainText("Elon Reeve Musk FRS (born June 28, 1971) is a businessman and investor known for his key roles in space company SpaceX and automotive company Tesla, Inc..").Result);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static void AsyncDownloadPolicy_ConfigureHttpClient(object sender, AsyncDownloadPolicy.ConfigureHttpClientEventArgs e)
        {
            string? fullTypeName = e?.ValueType.FullName;
            if (fullTypeName.Contains("Ollama"))
            {
                e.Client.Timeout = TimeSpan.FromMinutes(15);
            }
        }

        public class SampleAITextModifier
        {
            //Modify the following lines to obtain and pass your personal Azure OpenAI credentails to the Register* method.
            string AzureOpenAIEndpoint { get { return Environment.GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT"); } }
            string AzureOpenAIKey { get { return Environment.GetEnvironmentVariable("AZURE_OPENAI_APIKEY"); } }
            string DeploymentName { get { return Environment.GetEnvironmentVariable("AZURE_OPENAI_DEPLOYMENTNAME"); } }

            AIExtensionsContainerDefault defaultAIContainer;
            public SampleAITextModifier()
            {
                defaultAIContainer = new AIExtensionsContainerDefault();
                //defaultAIContainer.RegisterChatClientOllamaAIService("http://localhost:11434/api/chat", "llama3.1");
                defaultAIContainer.RegisterChatClientOpenAIService(
                    new AzureOpenAIClient(new Uri(AzureOpenAIEndpoint),
                    new System.ClientModel.ApiKeyCredential(AzureOpenAIKey)),
                    DeploymentName
                );
            }

            public void ChangeDefaults()
            {
                AIIntegration.ChatTemperatureDefault = 0.9f;
            }

            public async Task<string> GetTranslation(string textToTranslate, string language)
            {
                TextResponse result = await defaultAIContainer.TranslateAsync(new TranslateRequest(textToTranslate, language));
                if (result.IsCompleted)
                    return result.Response;
                if (!result.IsRestrictedOrFailed)
                {
                    string translatedText = result.Response;
                    while (result.IsContinuationRequired)
                    {
                        await result.ContinueAsync();
                        translatedText += result.Response;
                    }
                    return translatedText;
                }
                // Something unexpected happens
                switch (result.Status)
                {
                    case ResponseStatus.MaxTokenLimitExceeded:
                    case ResponseStatus.InputSizeLimitExceeded:
                        return "The text you're trying to send within a request is too long and exceeds the limit.";
                    case ResponseStatus.ContentFiltered:
                        return "Potentially harmful content was detected in your request.";
                    case ResponseStatus.Error:
                        return "An error occurred while processing the request.";
                }
                throw new NotSupportedException();
            }

            // How to replace the default extension
            public async Task<string> GetShakespeareText(string textToModify)
            {
                defaultAIContainer.Register<RewriteStyleRequest, WilliamShakespeareStyleExtension>();
                string res = await defaultAIContainer.RewriteStyleAsync(new RewriteStyleRequest(textToModify, WritingStyle.Formal));
                return res;  
            }

            //How to register and call your own extension
            public async Task<string> GetMarkTwainText(string textToModify) {
                var localContainer = new AIExtensionsContainerLocal(defaultAIContainer);
                localContainer.Register<AuthoredStyleRequest, AuthoredStyleExtension>();

                AuthoredStyleExtension extension = localContainer.CreateAuthoredStyleExtension();
                var request = new AuthoredStyleRequest("Mark Twain", textToModify);

                //Here you can set up the Temperature variable that will be used to execute this request
                request.Options.Temperature = 0.9f;
                string result = await extension.ExecuteAsync(request, CancellationToken.None);
                return result;
            }
        }
    }
    #region How to modify the default extension
    public class WilliamShakespeareStyleExtension : RewriteStyleExtension
    {
        public WilliamShakespeareStyleExtension(IServiceProvider serviceProvider) : base(serviceProvider) { }
        protected override string GetSystemPrompt(RewriteStyleRequest request)
        {
            return "Rewrite this text in the William Shakespeare style.";
        }
    }
    #endregion
    #region implement your own extension
    public class AuthoredStyleExtension : ChangeTextExtension<AuthoredStyleRequest>
    {
        public AuthoredStyleExtension(IServiceProvider serviceProvider) : base(serviceProvider) { }
        protected override string GetSystemPrompt(AuthoredStyleRequest request)
        {
            return $"Rewrite this text in the {request.Author} style";
        }
    }
    // Custom text processing request
    public class AuthoredStyleRequest : TextRequest
    {
        public AuthoredStyleRequest(string Author, string Text) : base(Text)
        {
            this.Author = Author;
        }
        public string Author { get; init; }
    }

    // This is a class that contains some useful extension methods
    public static class CustomAIIntegration
    {
        public static AuthoredStyleExtension CreateAuthoredStyleExtension(this IAIExtensionsContainer container)
        {
            return (AuthoredStyleExtension)container.GetExtension(typeof(AuthoredStyleRequest));
        }
    }
    #endregion
    #region how to localize prompts
    public class CustomAILocalizer : AIIntegrationLocalizer
    {
        public override string GetLocalizedString(AIIntegrationStringId id)
        {
            switch (id)
            {
                case AIIntegrationStringId.TranslateSystemPrompt:
                    return GetTranslateLocalizedPrompt(CultureInfo.CurrentUICulture.Name);
                // Add cases for other prompts as needed
                default:
                    return base.GetLocalizedString(id);
            }
        }

        private string GetTranslateLocalizedPrompt(string cultureName)
        {
            // Implement logic to return the localized prompt based on the user's culture
            if (cultureName.StartsWith("es"))
            {
                return "Traducir este texto a {0} idioma.";
            }
            else
            {
                return "Translate this text to {0} language.";
            }
        }
    }
    #endregion
}
