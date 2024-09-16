using Azure.AI.OpenAI;
using DevExpress.AIIntegration;

namespace WinForms_AI_Extensions
{
    internal static class Program { 
        //Modify the following lines to obtain and pass your personal Azure OpenAI credentails to the Register* method.
        static string AzureOpenAIEndpoint { get { return Environment.GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT"); } }
        static string AzureOpenAIKey { get { return Environment.GetEnvironmentVariable("AZURE_OPENAI_APIKEY"); } }
        static string DeploymentName { get { return Environment.GetEnvironmentVariable("AZURE_OPENAI_DEPLOYMENTNAME"); } }

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
            AIExtensionsContainerDesktop.Default.RegisterChatClientOpenAIService(
                new AzureOpenAIClient(
                    new Uri(AzureOpenAIEndpoint),
                    new System.ClientModel.ApiKeyCredential(AzureOpenAIKey)),
                DeploymentName);
        }
    }
}