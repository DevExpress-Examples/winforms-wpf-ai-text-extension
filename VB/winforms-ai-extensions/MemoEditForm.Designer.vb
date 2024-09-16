Namespace WinForms_AI_Extensions
	Partial Public Class MemoEditForm
		''' <summary>
		'''  Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		'''  Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		'''  Required method for Designer support - do not modify
		'''  the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			components = New System.ComponentModel.Container()
			Dim languageInfo1 As New DevExpress.AIIntegration.Desktop.LanguageInfo()
			Dim languageInfo2 As New DevExpress.AIIntegration.Desktop.LanguageInfo()
			Dim languageInfo3 As New DevExpress.AIIntegration.Desktop.LanguageInfo()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MemoEditForm))
			memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
			behaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(components)
			DirectCast(memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(behaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			SuspendLayout()
			' 
			' memoEdit1
			' 
			languageInfo1.Culture = New System.Globalization.CultureInfo("es")
			languageInfo2.Culture = New System.Globalization.CultureInfo("de")
			languageInfo3.Culture = New System.Globalization.CultureInfo("pt")
			behaviorManager1.SetBehaviors(memoEdit1, New DevExpress.Utils.Behaviors.Behavior() { CType(DevExpress.Utils.Behaviors.Behavior.Create(GetType(DevExpress.AIIntegration.WinForms.ExpandBehavior), GetType(DevExpress.AIIntegration.WinForms.MemoEditExpandBehaviorSource), New Object() { Nothing }), DevExpress.AIIntegration.WinForms.ExpandBehavior), CType(DevExpress.Utils.Behaviors.Behavior.Create(GetType(DevExpress.AIIntegration.WinForms.ShortenBehavior), GetType(DevExpress.AIIntegration.WinForms.MemoEditShortenBehaviorSource), New Object() { Nothing }), DevExpress.AIIntegration.WinForms.ShortenBehavior), CType(DevExpress.Utils.Behaviors.Behavior.Create(GetType(DevExpress.AIIntegration.WinForms.ToneStyleBehavior), GetType(DevExpress.AIIntegration.WinForms.MemoEditToneStyleBehaviorSource), New Object() { Nothing }), DevExpress.AIIntegration.WinForms.ToneStyleBehavior), CType(DevExpress.Utils.Behaviors.Behavior.Create(GetType(DevExpress.AIIntegration.WinForms.ExplainBehavior), GetType(DevExpress.AIIntegration.WinForms.MemoEditExplainBehaviorSource), New Object() { Nothing }), DevExpress.AIIntegration.WinForms.ExplainBehavior), CType(DevExpress.Utils.Behaviors.Behavior.Create(GetType(DevExpress.AIIntegration.WinForms.ProofreadBehavior), GetType(DevExpress.AIIntegration.WinForms.MemoEditProofreadBehaviorSource), New Object() { Nothing }), DevExpress.AIIntegration.WinForms.ProofreadBehavior), CType(DevExpress.Utils.Behaviors.Behavior.Create(GetType(DevExpress.AIIntegration.WinForms.RewriteStyleBehavior), GetType(DevExpress.AIIntegration.WinForms.MemoEditRewriteStyleBehaviorSource), New Object() { Nothing }), DevExpress.AIIntegration.WinForms.RewriteStyleBehavior), CType(DevExpress.Utils.Behaviors.Behavior.Create(GetType(DevExpress.AIIntegration.WinForms.SummarizeBehavior), GetType(DevExpress.AIIntegration.WinForms.MemoEditSummarizeBehaviorSource), New Object() { DevExpress.AIIntegration.SummarizeBehaviorMode.Abstractive, Nothing }), DevExpress.AIIntegration.WinForms.SummarizeBehavior), CType(DevExpress.Utils.Behaviors.Behavior.Create(GetType(DevExpress.AIIntegration.WinForms.CustomRequestBehavior), GetType(DevExpress.AIIntegration.WinForms.MemoEditCustomRequestBehaviorSource), New Object() { Nothing }), DevExpress.AIIntegration.WinForms.CustomRequestBehavior), CType(DevExpress.Utils.Behaviors.Behavior.Create(GetType(DevExpress.AIIntegration.WinForms.TranslateBehavior), GetType(DevExpress.AIIntegration.WinForms.MemoEditTranslateBehaviorSource), New Object() { New DevExpress.AIIntegration.Desktop.LanguageInfo() { languageInfo1, languageInfo2, languageInfo3 }, Nothing }), DevExpress.AIIntegration.WinForms.TranslateBehavior) })
			memoEdit1.Dock = DockStyle.Fill
			memoEdit1.EditValue = resources.GetString("memoEdit1.EditValue")
			memoEdit1.Location = New Point(0, 0)
			memoEdit1.Margin = New Padding(3, 2, 3, 2)
			memoEdit1.Name = "memoEdit1"
			memoEdit1.Size = New Size(1268, 653)
			memoEdit1.TabIndex = 0
			' 
			' MemoEditForm
			' 
			AutoScaleDimensions = New SizeF(12F, 25F)
			AutoScaleMode = AutoScaleMode.Font
			ClientSize = New Size(1268, 653)
			Controls.Add(memoEdit1)
			Margin = New Padding(3, 2, 3, 2)
			Name = "MemoEditForm"
			Text = "Form1"
			DirectCast(memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(behaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
			ResumeLayout(False)
		End Sub

		#End Region

		Private memoEdit1 As DevExpress.XtraEditors.MemoEdit
		Private behaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
	End Class
End Namespace
