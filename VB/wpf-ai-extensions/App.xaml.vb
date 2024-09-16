Imports Azure.AI.OpenAI
Imports DevExpress.AIIntegration
Imports DevExpress.Xpf.Core
Imports System.Configuration
Imports System.Data
Imports System.Windows

Namespace WPF_AI_Extensions
	''' <summary>
	''' Interaction logic for App.xaml
	''' </summary>
	''' 

	Partial Public Class App
		Inherits System.Windows.Application

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

		Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
			MyBase.OnStartup(e)

			ApplicationThemeHelper.ApplicationThemeName = "Office2019Colorful"

			AIExtensionsContainerDesktop.Default.RegisterChatClientOpenAIService(New AzureOpenAIClient(New Uri(AzureOpenAIEndpoint), New System.ClientModel.ApiKeyCredential(AzureOpenAIKey)), DeploymentName)
		End Sub
	End Class
End Namespace
