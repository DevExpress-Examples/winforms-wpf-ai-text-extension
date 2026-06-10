Imports Azure.AI.OpenAI
Imports DevExpress.AIIntegration
Imports DevExpress.Xpf.Core
Imports Microsoft.Extensions.AI
Imports System.Windows.Media.Media3D

Namespace WPF_AI_Extensions

    ''' <summary>
    ''' Interaction logic for App.xaml
    ''' </summary>
    ''' 
    Public Partial Class App
        Inherits System.Windows.Application

        Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
            MyBase.OnStartup(e)
            ApplicationThemeHelper.ApplicationThemeName = "Office2019Colorful"
            ''' To register Ollama
            'OllamaChatClient ollamaChatClient = new OllamaChatClient("http://localhost:11434/", "llama3.1");

            'Modify the following lines to obtain and pass your personal Azure OpenAI credentails to the Register* method.
            Dim azureOpenAIEndpoint As String = Environment.GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT")
            If String.IsNullOrEmpty(azureOpenAIEndpoint) Then azureOpenAIEndpoint = "https://api.devexpress.com/demo-openai" 'DevExpress demo proxy-server
            Dim azureOpenAIKey As String = Environment.GetEnvironmentVariable("AZURE_OPENAI_APIKEY")
            If String.IsNullOrEmpty(azureOpenAIKey) Then azureOpenAIKey = "DEMO" 'Demo key
            Dim deploymentName As String = Environment.GetEnvironmentVariable("AZURE_OPENAI_DEPLOYMENTNAME")
            If String.IsNullOrEmpty(deploymentName) Then deploymentName = "demo" 'DevExpress demo deployment

            Dim azureOpenAIClient As IChatClient = New AzureOpenAIClient(New Uri(azureOpenAIEndpoint), New System.ClientModel.ApiKeyCredential(azureOpenAIKey)).GetChatClient(deploymentName).AsIChatClient()
            AIExtensionsContainerDesktop.Default.RegisterChatClient(azureOpenAIClient)
        End Sub
    End Class
End Namespace
