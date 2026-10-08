Imports Azure.AI.OpenAI
Imports DevExpress.AIIntegration
Imports Microsoft.Extensions.AI
Imports System.Windows.Forms

Namespace WinForms_AI_Extensions
    Friend Module Program
        <STAThread>
        Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)

            RegisterDevExpressAI()

            'Application.Run(New MemoEditForm())
            Application.Run(New RichEditForm())
        End Sub

        Private Sub RegisterDevExpressAI()
            Dim azureOpenAIEndpoint As String = Environment.GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT")
            If String.IsNullOrEmpty(azureOpenAIEndpoint) Then
                azureOpenAIEndpoint = "https://api.devexpress.com/demo-openai"
            End If

            Dim azureOpenAIKey As String = Environment.GetEnvironmentVariable("AZURE_OPENAI_APIKEY")
            If String.IsNullOrEmpty(azureOpenAIKey) Then
                azureOpenAIKey = "DEMO"
            End If

            Dim deploymentName As String = Environment.GetEnvironmentVariable("AZURE_OPENAI_DEPLOYMENTNAME")
            If String.IsNullOrEmpty(deploymentName) Then
                deploymentName = "demo"
            End If

            Dim azureOpenAIClient As IChatClient = New AzureOpenAIClient(New Uri(azureOpenAIEndpoint),
                New System.ClientModel.ApiKeyCredential(azureOpenAIKey)).GetChatClient(deploymentName).AsIChatClient()
            AIExtensionsContainerDesktop.Default.RegisterChatClient(azureOpenAIClient)
        End Sub
    End Module
End Namespace
