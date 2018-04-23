Imports Microsoft.VisualBasic
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Base.ViewInfo
Imports System
Imports System.Linq

Namespace GridViewFooter
	Friend Class GridFooterOnTopViewInfoRegistrator
		Inherits GridInfoRegistrator
		Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
			Return New GridViewFooterOnTop(grid)
		End Function
		Public Overrides Function CreateViewInfo(ByVal view As BaseView) As BaseViewInfo
			Return New GridViewInfoFooterOnTop(TryCast(view, GridViewFooterOnTop))
		End Function

		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return "GridViewFooterOnTop"
			End Get
		End Property
	End Class
End Namespace
