Imports Microsoft.VisualBasic
Imports DevExpress.Utils.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports System
Imports System.Linq

Namespace GridViewFooter
	Public Enum FooterPosition
		Top
		Bottom
	End Enum

	Friend Class GridFooterOnTopOptionsView
		Inherits GridOptionsView
		Private footerPosition As FooterPosition

		Public Sub New()
			MyBase.New()
		Me.footerPosition = FooterPosition.Bottom
		End Sub

		Public Overrides Sub Assign(ByVal options As DevExpress.Utils.Controls.BaseOptions)
			BeginUpdate()
			Try
				MyBase.Assign(options)
				Dim opt As GridFooterOnTopOptionsView = TryCast(options, GridFooterOnTopOptionsView)
				If opt Is Nothing Then
					Return
				End If
				Me.footerPosition = opt.footerPosition
			Finally
				EndUpdate()
			End Try
		End Sub

		Public Overridable Property FooterLocation() As FooterPosition
			Get
				Return footerPosition
			End Get
			Set(ByVal value As FooterPosition)
				Dim prevValue As FooterPosition = FooterLocation
				footerPosition = value
				OnChanged(New BaseOptionChangedEventArgs("FooterLocation", prevValue, ShowFooter))
			End Set
		End Property
	End Class
End Namespace
