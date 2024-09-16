Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace WinForms_AI_Extensions
	Partial Public Class RichEditForm
		Inherits DevExpress.XtraBars.Ribbon.RibbonForm

		Public Sub New()
			InitializeComponent()
			Dim ribbon As RibbonControl = richEditControl1.CreateRibbon()
			Me.Controls.Add(ribbon)
			richEditControl1.LoadDocument("WindowsForms.docx")
		End Sub
	End Class
End Namespace