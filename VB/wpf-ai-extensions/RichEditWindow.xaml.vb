Imports System.Linq
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Shapes

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
