Imports System.Windows

Namespace WPF_AI_Extensions
    Partial Public Class RichEditWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            richEditControl.LoadDocument("WPF.docx")
        End Sub
    End Class
End Namespace
