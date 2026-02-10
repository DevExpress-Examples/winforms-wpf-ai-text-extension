Imports DevExpress.XtraBars.Ribbon
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq

Namespace WinForms_AI_Extensions

    Public Partial Class RichEditForm
        Inherits RibbonForm

        Public Sub New()
            InitializeComponent()
            Dim ribbon As RibbonControl = richEditControl1.CreateRibbon()
            Me.Controls.Add(ribbon)
            richEditControl1.LoadDocument("WindowsForms.docx")
        End Sub
    End Class
End Namespace
