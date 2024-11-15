using Azure.AI.OpenAI;
using DevExpress.AIIntegration;
using DevExpress.Xpf.Core;
using System.Configuration;
using System.Data;
using System.Windows;

namespace WPF_AI_Extensions
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// 

    public partial class App : System.Windows.Application
    {
        //Modify the following lines to obtain and pass your personal Azure OpenAI credentails to the Register* method.
        string AzureOpenAIEndpoint { get { return Environment.GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT"); } }
        string AzureOpenAIKey { get { return Environment.GetEnvironmentVariable("AZURE_OPENAI_APIKEY"); } }
        string DeploymentName { get { return Environment.GetEnvironmentVariable("AZURE_OPENAI_DEPLOYMENTNAME"); } }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ApplicationThemeHelper.ApplicationThemeName = "Office2019Colorful";


            ///To register Ollama
            //OllamaChatClient ollamaChatClient = new OllamaChatClient("http://localhost:11434/api/chat", "llama3.1");

            AzureOpenAIClient azureOpenAIClient = new AzureOpenAIClient(new Uri(AzureOpenAIEndpoint),
                   new System.ClientModel.ApiKeyCredential(AzureOpenAIKey));
            AIExtensionsContainerDesktop.Default.RegisterChatClient(azureOpenAIClient.AsChatClient(DeploymentName));
        }
    }
}
