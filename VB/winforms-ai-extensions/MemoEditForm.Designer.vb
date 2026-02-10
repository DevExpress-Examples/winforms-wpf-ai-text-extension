Namespace WinForms_AI_Extensions

    Partial Class MemoEditForm

        ''' <summary>
        '''  Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        '''  Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        '''  Required method for Designer support - do not modify
        '''  the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim languageInfo1 As DevExpress.AIIntegration.Desktop.LanguageInfo = New DevExpress.AIIntegration.Desktop.LanguageInfo()
            Dim languageInfo2 As DevExpress.AIIntegration.Desktop.LanguageInfo = New DevExpress.AIIntegration.Desktop.LanguageInfo()
            Dim languageInfo3 As DevExpress.AIIntegration.Desktop.LanguageInfo = New DevExpress.AIIntegration.Desktop.LanguageInfo()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WinForms_AI_Extensions.MemoEditForm))
            Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
            Me.behaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
            CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.behaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' memoEdit1
            ' 
            languageInfo1.Culture = New System.Globalization.CultureInfo("pt")
            languageInfo2.Culture = New System.Globalization.CultureInfo("es")
            languageInfo3.Culture = New System.Globalization.CultureInfo("de")
            Me.behaviorManager1.SetBehaviors(Me.memoEdit1, New DevExpress.Utils.Behaviors.Behavior() {DevExpress.AIIntegration.WinForms.ExpandBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.MemoEditExpandBehaviorSource)), DevExpress.AIIntegration.WinForms.ShortenBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.MemoEditShortenBehaviorSource)), DevExpress.AIIntegration.WinForms.SummarizeBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.MemoEditSummarizeBehaviorSource), DevExpress.AIIntegration.SummarizationMode.Abstractive), DevExpress.AIIntegration.WinForms.ExplainBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.MemoEditExplainBehaviorSource)), DevExpress.AIIntegration.WinForms.ChangeToneBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.MemoEditChangeToneBehaviorSource)), DevExpress.AIIntegration.WinForms.ProofreadBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.MemoEditProofreadBehaviorSource)), DevExpress.AIIntegration.WinForms.ChangeStyleBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.MemoEditChangeStyleBehaviorSource)), DevExpress.AIIntegration.WinForms.TranslateBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.MemoEditTranslateBehaviorSource), New DevExpress.AIIntegration.Desktop.LanguageInfo() {languageInfo1, languageInfo2, languageInfo3}), DevExpress.AIIntegration.WinForms.CustomRequestBehavior.Create(GetType(DevExpress.AIIntegration.WinForms.MemoEditCustomRequestBehaviorSource))})
            Me.memoEdit1.Dock = DockStyle.Fill
            Me.memoEdit1.EditValue = resources.GetString("memoEdit1.EditValue")
            Me.memoEdit1.Location = New Point(0, 0)
            Me.memoEdit1.Margin = New Padding(2, 2, 2, 2)
            Me.memoEdit1.Name = "memoEdit1"
            Me.memoEdit1.Size = New Size(951, 496)
            Me.memoEdit1.TabIndex = 0
            ' 
            ' MemoEditForm
            ' 
            AutoScaleDimensions = New SizeF(9F, 19F)
            AutoScaleMode = AutoScaleMode.Font
            ClientSize = New Size(951, 496)
            Controls.Add(Me.memoEdit1)
            Margin = New Padding(2, 2, 2, 2)
            Name = "MemoEditForm"
            Me.Text = "Form1"
            CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.behaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
        End Sub

#End Region
        Private memoEdit1 As DevExpress.XtraEditors.MemoEdit

        Private behaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    End Class
End Namespace
