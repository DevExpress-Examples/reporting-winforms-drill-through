Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
' ...

Namespace DrillThroughReport
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			CType(New MasterReport(), MasterReport).ShowPreview()
		End Sub
	End Class
End Namespace