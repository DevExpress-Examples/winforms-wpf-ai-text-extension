Imports Azure.AI.OpenAI
Imports DevExpress.AIIntegration
Imports DevExpress.Xpf.Core
Imports Microsoft.Extensions.AI
Imports System
Imports System.Windows

Namespace WPF_AI_Extensions
    Partial Public Class App
        Inherits Application

        Protected Overrides Sub OnStartup(e As StartupEventArgs)
            MyBase.OnStartup(e)

            ApplicationThemeHelper.ApplicationThemeName = "Office2019Colorful"

            Dim azureOpenAIEndpoint = Environment.GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT")
            If String.IsNullOrEmpty(azureOpenAIEndpoint) Then
                azureOpenAIEndpoint = "https://api.devexpress.com/demo-openai"
            End If

            Dim azureOpenAIKey = Environment.GetEnvironmentVariable("AZURE_OPENAI_APIKEY")
            If String.IsNullOrEmpty(azureOpenAIKey) Then
                azureOpenAIKey = "DEMO"
            End If

            Dim deploymentName = Environment.GetEnvironmentVariable("AZURE_OPENAI_DEPLOYMENTNAME")
            If String.IsNullOrEmpty(deploymentName) Then
                deploymentName = "demo"
            End If

            Dim azureOpenAIClient As IChatClient = New AzureOpenAIClient(New Uri(azureOpenAIEndpoint),
                                                                          New System.ClientModel.ApiKeyCredential(azureOpenAIKey)).
                                                                          GetChatClient(deploymentName).
                                                                          AsIChatClient()
            AIExtensionsContainerDesktop.[Default].RegisterChatClient(azureOpenAIClient)
        End Sub
    End Class
End Namespace
