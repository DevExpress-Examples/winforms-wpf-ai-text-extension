Imports System.Drawing
Imports System.Windows.Forms

Namespace WinForms_AI_Extensions
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class RichEditForm
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Private components As System.ComponentModel.IContainer

        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            components = New System.ComponentModel.Container()
            Dim languageInfo1 As New DevExpress.AIIntegration.WinForms.LanguageInfo()
            Dim languageInfo2 As New DevExpress.AIIntegration.WinForms.LanguageInfo()
            Dim languageInfo3 As New DevExpress.AIIntegration.WinForms.LanguageInfo()
            richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
            behaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(components)
            CType(behaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' richEditControl1
            ' 
            languageInfo1.Culture = New Global.System.Globalization.CultureInfo("pt")
            languageInfo2.Culture = New Global.System.Globalization.CultureInfo("es")
            languageInfo3.Culture = New Global.System.Globalization.CultureInfo("de")
            behaviorManager1.SetBehaviors(richEditControl1, New DevExpress.Utils.Behaviors.Behavior() {
                DevExpress.AIIntegration.WinForms.ExpandBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.RichEditExpandBehaviorSource)),
                DevExpress.AIIntegration.WinForms.ShortenBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.RichEditShortenBehaviorSource)),
                DevExpress.AIIntegration.WinForms.SummarizeBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.RichEditSummarizeBehaviorSource), DevExpress.AIIntegration.SummarizationMode.Abstractive),
                DevExpress.AIIntegration.WinForms.ExplainBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.RichEditExplainBehaviorSource)),
                DevExpress.AIIntegration.WinForms.ChangeToneBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.RichEditChangeToneBehaviorSource)),
                DevExpress.AIIntegration.WinForms.ProofreadBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.RichEditProofreadBehaviorSource)),
                DevExpress.AIIntegration.WinForms.ChangeStyleBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.RichEditChangeStyleBehaviorSource)),
                DevExpress.AIIntegration.WinForms.TranslateBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.RichEditTranslateBehaviorSource), New DevExpress.AIIntegration.WinForms.LanguageInfo() {languageInfo1, languageInfo2, languageInfo3}),
                DevExpress.AIIntegration.WinForms.CustomRequestBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.RichEditCustomRequestBehaviorSource)),
                DevExpress.AIIntegration.WinForms.GenerateImageDescriptionBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.RichEditGenerateDescriptionBehaviorSource))})
            richEditControl1.Dock = DockStyle.Fill
            richEditControl1.Location = New Point(0, 0)
            richEditControl1.Margin = New Padding(2)
            richEditControl1.Name = "richEditControl1"
            richEditControl1.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText
            richEditControl1.Size = New Size(1421, 1235)
            richEditControl1.TabIndex = 0
            richEditControl1.Text = "Text"
            ' 
            ' RichEditForm
            ' 
            AutoScaleDimensions = New SizeF(9.0F, 19.0F)
            AutoScaleMode = AutoScaleMode.Font
            ClientSize = New Size(1421, 1235)
            Controls.Add(richEditControl1)
            Name = "RichEditForm"
            Text = "Form1"
            CType(behaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
        End Sub

        Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
        Private behaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    End Class
End Namespace
