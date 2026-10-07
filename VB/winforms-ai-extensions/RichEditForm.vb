Imports DevExpress.XtraBars.Ribbon
Imports System.IO

Namespace WinForms_AI_Extensions
    Partial Public Class RichEditForm
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
            Dim ribbon As RibbonControl = richEditControl1.CreateRibbon()
            Me.Controls.Add(ribbon)
            Dim documentPath As String = Path.Combine(System.Windows.Forms.Application.StartupPath, "WindowsForms.docx")
            richEditControl1.LoadDocument(documentPath)
        End Sub
    End Class
End Namespace
