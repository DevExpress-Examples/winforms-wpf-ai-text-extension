Imports System.Linq
Imports System.Windows.Controls
Imports System.Windows.Media.Imaging

Namespace WPF_AI_Extensions

    ''' <summary>
    ''' Interaction logic for RichEditWindow.xaml
    ''' </summary>
    Public Partial Class RichEditWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            richEditControl.LoadDocument("WPF.docx")
        End Sub
    End Class
End Namespace
