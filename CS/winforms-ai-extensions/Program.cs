using Azure.AI.OpenAI;
using DevExpress.AIIntegration;
using Microsoft.Extensions.AI;

namespace WinForms_AI_Extensions
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            RegisterDevExpressAI();

            //Application.Run(new MemoEditForm());
            Application.Run(new RichEditForm());
        }

        private static void RegisterDevExpressAI()
        {
            ///To register Ollama
            //OllamaChatClient ollamaChatClient = new OllamaChatClient("http://localhost:11434/", "llama3.1");

            //Modify the following lines to obtain and pass your personal Azure OpenAI credentails to the Register* method.
            string azureOpenAIEndpoint = Environment.GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT");
            if (string.IsNullOrEmpty(azureOpenAIEndpoint))
                azureOpenAIEndpoint = "https://api.devexpress.com/demo-openai";//DevExpress demo proxy-server
            string azureOpenAIKey = Environment.GetEnvironmentVariable("AZURE_OPENAI_APIKEY");
            if (string.IsNullOrEmpty(azureOpenAIKey))
                azureOpenAIKey = "DEMO";//Demo key
            string deploymentName = Environment.GetEnvironmentVariable("AZURE_OPENAI_DEPLOYMENTNAME");
            if (string.IsNullOrEmpty(deploymentName))
                deploymentName = "demo";//DevExpress demo deployment

            IChatClient azureOpenAIClient = new AzureOpenAIClient(new Uri(azureOpenAIEndpoint),
                   new System.ClientModel.ApiKeyCredential(azureOpenAIKey)).GetChatClient(deploymentName).AsIChatClient();
            AIExtensionsContainerDesktop.Default.RegisterChatClient(azureOpenAIClient);
        }
    }
}
