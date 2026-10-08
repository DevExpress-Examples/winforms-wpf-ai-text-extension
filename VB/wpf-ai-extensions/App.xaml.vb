Imports Azure.AI.OpenAI
Imports DevExpress.AIIntegration
Imports DevExpress.Xpf.Core
Imports Microsoft.Extensions.AI
Imports System
Imports System.Windows

Namespace WPF_AI_Extensions
    Partial Public Class App
        Inherits System.Windows.Application

        'Modify the following lines to obtain and pass your personal Azure OpenAI credentails to the Register* method.
        Private ReadOnly Property AzureOpenAIEndpoint As String
            Get
                Return Environment.GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT")
            End Get
        End Property

        Private ReadOnly Property AzureOpenAIKey As String
            Get
                Return Environment.GetEnvironmentVariable("AZURE_OPENAI_APIKEY")
            End Get
        End Property

        Private ReadOnly Property DeploymentName As String
            Get
                Return Environment.GetEnvironmentVariable("AZURE_OPENAI_DEPLOYMENTNAME")
            End Get
        End Property

        Protected Overrides Sub OnStartup(e As StartupEventArgs)
            MyBase.OnStartup(e)

            ApplicationThemeHelper.ApplicationThemeName = "Office2019Colorful"

            ''To register Ollama
            'Dim ollamaChatClient As New OllamaChatClient("http://localhost:11434/", "llama3.1")

            Dim azureOpenAIClient As IChatClient = New AzureOpenAIClient(New Uri(AzureOpenAIEndpoint),
                New System.ClientModel.ApiKeyCredential(AzureOpenAIKey)).GetChatClient(DeploymentName).AsIChatClient()
            AIExtensionsContainerDesktop.Default.RegisterChatClient(azureOpenAIClient)
        End Sub
    End Class
End Namespace
