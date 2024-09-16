Option Infer On

Imports Azure.AI.OpenAI
Imports DevExpress.AIIntegration
Imports DevExpress.AIIntegration.Extensions
Imports DevExpress.AIIntegration.Localization
Imports DevExpress.Data
Imports System.Globalization


Namespace Runtime_AI_Extensions
	Friend Class Program
		Shared Sub Main(ByVal args() As String)
			Console.OutputEncoding = System.Text.Encoding.UTF8

			'Enable sending large texts to Ollama
			'AsyncDownloadPolicy.ConfigureHttpClient += AsyncDownloadPolicy_ConfigureHttpClient;

			'Enable localization
			'AIIntegrationLocalizer.Active = new CustomAILocalizer();

			Dim s As New SampleAITextModifier()
			s.ChangeDefaults()
			Console.WriteLine(s.GetTranslation("William Shakespeare is a great famous British writer", "Spanish").Result)
			Console.WriteLine()
			Console.WriteLine("William Shakespeare about Elon Musk:" & Environment.NewLine)
			Console.WriteLine(s.GetShakespeareText("Elon Reeve Musk FRS (born June 28, 1971) is a businessman and investor known for his key roles in space company SpaceX and automotive company Tesla, Inc..").Result)
			Console.WriteLine()
			Console.WriteLine("Mark Twain about Elon Musk:" & Environment.NewLine)
			Console.WriteLine(s.GetMarkTwainText("Elon Reeve Musk FRS (born June 28, 1971) is a businessman and investor known for his key roles in space company SpaceX and automotive company Tesla, Inc..").Result)
			Console.WriteLine("Press any key to exit...")
			Console.ReadKey()
		End Sub

		Private Shared Sub AsyncDownloadPolicy_ConfigureHttpClient(ByVal sender As Object, ByVal e As AsyncDownloadPolicy.ConfigureHttpClientEventArgs)
			Dim fullTypeName? As String = e?.ValueType.FullName
			If fullTypeName.Contains("Ollama") Then
				e.Client.Timeout = TimeSpan.FromMinutes(15)
			End If
		End Sub

		Public Class SampleAITextModifier
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

			Private defaultAIContainer As AIExtensionsContainerDefault
			Public Sub New()
				defaultAIContainer = New AIExtensionsContainerDefault()
				'defaultAIContainer.RegisterChatClientOllamaAIService("http://localhost:11434/api/chat", "llama3.1");
				defaultAIContainer.RegisterChatClientOpenAIService(New AzureOpenAIClient(New Uri(AzureOpenAIEndpoint), New System.ClientModel.ApiKeyCredential(AzureOpenAIKey)), DeploymentName)
			End Sub

			Public Sub ChangeDefaults()
				AIIntegration.ChatTemperatureDefault = 0.9F
			End Sub

			Public Async Function GetTranslation(ByVal textToTranslate As String, ByVal language As String) As Task(Of String)
				Dim result As TextResponse = Await defaultAIContainer.TranslateAsync(New TranslateRequest(textToTranslate, language))
				If result.IsCompleted Then
					Return result.Response
				End If
				If Not result.IsRestrictedOrFailed Then
					Dim translatedText As String = result.Response
					Do While result.IsContinuationRequired
						Await result.ContinueAsync()
						translatedText &= result.Response
					Loop
					Return translatedText
				End If
				' Something unexpected happens
				Select Case result.Status
					Case ResponseStatus.MaxTokenLimitExceeded, ResponseStatus.InputSizeLimitExceeded
						Return "The text you're trying to send within a request is too long and exceeds the limit."
					Case ResponseStatus.ContentFiltered
						Return "Potentially harmful content was detected in your request."
					Case ResponseStatus.Error
						Return "An error occurred while processing the request."
				End Select
				Throw New NotSupportedException()
			End Function

			' How to replace the default extension
			Public Async Function GetShakespeareText(ByVal textToModify As String) As Task(Of String)
				defaultAIContainer.Register(Of RewriteStyleRequest, WilliamShakespeareStyleExtension)()
				Dim res As String = Await defaultAIContainer.RewriteStyleAsync(New RewriteStyleRequest(textToModify, WritingStyle.Formal))
				Return res
			End Function

			'How to register and call your own extension
			Public Async Function GetMarkTwainText(ByVal textToModify As String) As Task(Of String)
				Dim localContainer = New AIExtensionsContainerLocal(defaultAIContainer)
				localContainer.Register(Of AuthoredStyleRequest, AuthoredStyleExtension)()

				Dim extension As AuthoredStyleExtension = localContainer.CreateAuthoredStyleExtension()
				Dim request = New AuthoredStyleRequest("Mark Twain", textToModify)

				'Here you can set up the Temperature variable that will be used to execute this request
				request.Options.Temperature = 0.9F
				Dim result As String = Await extension.ExecuteAsync(request, CancellationToken.None)
				Return result
			End Function
		End Class
	End Class
	#Region "How to modify the default extension"
	Public Class WilliamShakespeareStyleExtension
		Inherits RewriteStyleExtension

		Public Sub New(ByVal serviceProvider As IServiceProvider)
			MyBase.New(serviceProvider)
		End Sub
		Protected Overrides Function GetSystemPrompt(ByVal request As RewriteStyleRequest) As String
			Return "Rewrite this text in the William Shakespeare style."
		End Function
	End Class
	#End Region
	#Region "implement your own extension"
	Public Class AuthoredStyleExtension
		Inherits ChangeTextExtension(Of AuthoredStyleRequest)

		Public Sub New(ByVal serviceProvider As IServiceProvider)
			MyBase.New(serviceProvider)
		End Sub
		Protected Overrides Function GetSystemPrompt(ByVal request As AuthoredStyleRequest) As String
			Return $"Rewrite this text in the {request.Author} style"
		End Function
	End Class
	' Custom text processing request
	Public Class AuthoredStyleRequest
		Inherits TextRequest

		Public Sub New(ByVal Author As String, ByVal Text As String)
			MyBase.New(Text)
			Me.Author = Author
		End Sub
		Public ReadOnly Property Author() As String
			Get
			init
			End Get
		End Property

	' This is a class that contains some useful extension methods
	Public NotInheritable Class CustomAIIntegration

		Private Sub New()
		End Sub

		<System.Runtime.CompilerServices.Extension> _
		Public Shared Function CreateAuthoredStyleExtension(ByVal container As IAIExtensionsContainer) As AuthoredStyleExtension
			Return CType(container.GetExtension(GetType(AuthoredStyleRequest)), AuthoredStyleExtension)
		End Function
	End Class
	#End Region
	#Region "how to localize prompts"
	Public Class CustomAILocalizer
		Inherits AIIntegrationLocalizer

		Public Overrides Function GetLocalizedString(ByVal id As AIIntegrationStringId) As String
			Select Case id
				Case AIIntegrationStringId.TranslateSystemPrompt
					Return GetTranslateLocalizedPrompt(CultureInfo.CurrentUICulture.Name)
				' Add cases for other prompts as needed
				Case Else
					Return MyBase.GetLocalizedString(id)
			End Select
		End Function

		Private Function GetTranslateLocalizedPrompt(ByVal cultureName As String) As String
			' Implement logic to return the localized prompt based on the user's culture
			If cultureName.StartsWith("es") Then
				Return "Traducir este texto a {0} idioma."
			Else
				Return "Translate this text to {0} language."
			End If
		End Function
	End Class
	#End Region
	End Class
