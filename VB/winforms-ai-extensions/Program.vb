Imports Azure.AI.OpenAI
Imports DevExpress.AIIntegration

Namespace WinForms_AI_Extensions
	Friend Module Program
		'Modify the following lines to obtain and pass your personal Azure OpenAI credentails to the Register* method.
		Private ReadOnly Property AzureOpenAIEndpoint() As String
			Get
				Return Environment.GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT")
			End Get
		End Property
		Private ReadOnly Property AzureOpenAIKey() As String
			Get
				Return Environment.GetEnvironmentVariable("AZURE_OPENAI_APIKEY")
			End Get
		End Property
		Private ReadOnly Property DeploymentName() As String
			Get
				Return Environment.GetEnvironmentVariable("AZURE_OPENAI_DEPLOYMENTNAME")
			End Get
		End Property

		''' <summary>
		'''  The main entry point for the application.
		''' </summary>
		<STAThread>
		Sub Main()
			' To customize application configuration such as set high DPI settings or default font,
			' see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize()

			RegisterDevExpressAI()

			'Application.Run(new MemoEditForm());
			Application.Run(New RichEditForm())
		End Sub

		Private Sub RegisterDevExpressAI()
			AIExtensionsContainerDesktop.Default.RegisterChatClientOpenAIService(New AzureOpenAIClient(New Uri(AzureOpenAIEndpoint), New System.ClientModel.ApiKeyCredential(AzureOpenAIKey)), DeploymentName)
		End Sub
	End Module
End Namespace