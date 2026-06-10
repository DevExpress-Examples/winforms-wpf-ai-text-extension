Imports Azure.AI.OpenAI
Imports DevExpress.AIIntegration
Imports Microsoft.Extensions.AI

Namespace WinForms_AI_Extensions

    Friend Module Program

        ''' <summary>
        '''  The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            ' To customize application configuration such as set high DPI settings or default font,
            ' see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize()
            Call RegisterDevExpressAI()
            'Application.Run(new MemoEditForm());
            Application.Run(New RichEditForm())
        End Sub

        Private Sub RegisterDevExpressAI()
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
    End Module
End Namespace
