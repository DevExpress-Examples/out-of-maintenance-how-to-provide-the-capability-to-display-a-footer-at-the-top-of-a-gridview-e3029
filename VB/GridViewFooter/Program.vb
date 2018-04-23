Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Windows.Forms

Namespace GridViewFooter
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New MovableFooterForm())
		End Sub
	End Class
End Namespace
