using Azure.AI.OpenAI;
using DevExpress.AIIntegration;
using DevExpress.Xpf.Core;
using Microsoft.Extensions.AI;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Media.Media3D;

namespace WPF_AI_Extensions
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// 

    public partial class App : System.Windows.Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ApplicationThemeHelper.ApplicationThemeName = "Office2019Colorful";


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
