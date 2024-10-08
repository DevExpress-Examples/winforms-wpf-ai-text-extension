<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/858218353/24.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1253691)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Integrate DevExpress AI-Powered Text Extensions into Console, WinForms, and WPF Apps

This example registers an Azure OpenAI service and uses AI APIs within a .NET 8 console application and adds AI-powered text processing features to the following DevExpress UI components:

* [WinForms MemoEdit](https://www.devexpress.com/products/net/controls/winforms/editors/)
* [WinForms RichEdit](https://www.devexpress.com/products/net/controls/winforms/rich_editor/)
* [WPF TextEdit](https://www.devexpress.com/products/net/controls/wpf/editors/)
* [WPF RichEditControl](https://www.devexpress.com/products/net/controls/wpf/rich_editor/)

>[!Note]
> DevExpress does not provide a REST API or include built-in LLMs/SLMs. To use AI services, you need an active Azure/OpenAI subscription to obtain the necessary REST API endpoint, key, and model deployment name. This information must be added at application startup to register AI clients and enable DevExpress AI-powered features in your application.

## Implementation Details

Install DevExpress AI-related NuGet packages

1. DevExpress.AIIntegration.WinForms / DevExpress.AIIntegration.WPF

2. DevExpress.AIIntegration.Azure.OpenAI

### Register AI Services

The following code in the `Program.cs` file registers an Azure AI service in the application:

```cs
// Modify the following lines to obtain and pass your personal Azure OpenAI credentials to the `Register~` method.
static string AzureOpenAIEndpoint { get { return Environment.GetEnvironmentVariable("AZURE_OPENAI_ENDPOINT"); } }
static string AzureOpenAIKey { get { return Environment.GetEnvironmentVariable("AZURE_OPENAI_APIKEY"); } }
static string DeploymentName { get { return Environment.GetEnvironmentVariable("AZURE_OPENAI_DEPLOYMENTNAME"); } }

...
AIExtensionsContainerDesktop.Default.RegisterChatClientOpenAIService(
    new AzureOpenAIClient(
        new Uri(AzureOpenAIEndpoint),
        new System.ClientModel.ApiKeyCredential(AzureOpenAIKey)),
    DeploymentName);
// To use offline models powered by Ollama, use the RegisterChatClientOllamaAIService("http://localhost:11434/api/chat", "llama3.1"); method
```

### WinForms

Use the [BehaviorManager](https://docs.devexpress.com/WindowsForms/DevExpress.Utils.Behaviors.BehaviorManager) component to activate AI-powered text transform extensions for DevExpress WinForms UI controls.

Drop the `BehaviorManager` component from the Toolbox onto a Form. Open the behavior manager's smart tag menu and click "Edit Behaviors" to edit behaviors. In the **Behavior Collection Editor**, create desired AI-powered text processing behaviors, attach them to corresponding UI controls, and configure behavior settings (for example, the Temperature):

![devexpress ai integration collection editor](./media/image.png)

Run the application. Select text in the `MemoEdit` or `RichTextEdit` control and invoke the context menu. The context menu will display an "AI Text Transform" submenu with AI-driven commands.

Click the desired command. AI will process the command and generate an answer. The AI-generated answer is displayed within a dialog. You can insert the answer directly into a document or text field with a single click. You can insert AI answers above/below the cursor, replace all content or selected text, or copy the answer to the clipboard.

### WPF

To introduce AI-powered capabilities in DevExpress WPF UI controls, add the following namespaces to a Window:

```xaml
xmlns:dxmvvm="http://schemas.devexpress.com/winfx/2008/xaml/mvvm"
xmlns:wpf="clr-namespace:DevExpress.AIIntegration.Wpf;assembly=DevExpress.AIIntegration.Wpf.v24.2"
xmlns:desktop="clr-namespace:DevExpress.AIIntegration.Desktop;assembly=DevExpress.AIIntegration.Desktop.v24.2"
```
The following code snippet attaches AI-powered text processing behaviors to a DevExpress Text Editor:

```xaml
<dxe:TextEdit TextWrapping="Wrap">
    <dxmvvm:Interaction.Behaviors>
        <wpf:SummarizeBehavior/>
        <wpf:ExplainBehavior/>
        <wpf:ShortenBehavior/>
        <wpf:ExpandBehavior />
        <wpf:ToneStyleBehavior />
        <wpf:ProofreadBehavior/>
        <wpf:RewriteStyleBehavior/>
        <wpf:CustomRequestBehavior/>
        <wpf:TranslateBehavior>
            <desktop:LanguageInfo Culture="de-DE"/>
            <desktop:LanguageInfo Culture="es-ES"/>
            <desktop:LanguageInfo Culture="pt-BR"/>
        </wpf:TranslateBehavior>
    </dxmvvm:Interaction.Behaviors>
</dxe:TextEdit>
```

## Files to Review

- Console App: [Program.cs](./CS/console-ai-extension/Program.cs)
- WinForms App:
    - [Program.cs](./CS/winforms-ai-extensions/Program.cs) (VB: [Program.vb](./VB/winforms-ai-extensions/Program.vb)
    - [RichEditForm.Designer.cs](./CS/winforms-ai-extensions/RichEditForm.Designer.cs) (VB: [RichEditForm.Designer.vb](./VB/winforms-ai-extensions/RichEditForm.Designer.vb)
    - [MemoEditForm.Designer.cs](./CS/winforms-ai-extensions/MemoEditForm.Designer.cs) (VB: [MemoEditForm.Designer.vb](./VB/winforms-ai-extensions/MemoEditForm.Designer.vb))
- WPF App:
    - [App.xaml.cs](./CS/wpf-ai-extensions/App.xaml.cs) (VB: [App.xaml.vb](./VB/wpf-ai-extensions/App.xaml.vb))
    - [MainWindow.xaml](./CS/wpf-ai-extensions/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/wpf-ai-extensions/MainWindow.xaml))
    - [RichEditWindow.xaml](./CS/wpf-ai-extensions/RichEditWindow.xaml) (VB: [RichEditWindow.xaml](./VB/wpf-ai-extensions/RichEditWindow.xaml))


## Related Examples

- [Rich Text Editor and HTML Editor for Blazor - How to integrate AI-powered extensions](https://github.com/DevExpress-Examples/blazor-ai-integration-to-text-editors)
- [AI Chat for Blazor - How to add DxAIChat component in Blazor, MAUI, WPF, and WinForms applications](https://github.com/DevExpress-Examples/devexpress-ai-chat-samples)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-wpf-ai-text-extension&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-wpf-ai-text-extension&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
