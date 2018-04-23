Imports Microsoft.VisualBasic
Imports DevExpress.XtraGrid
Imports System
Imports System.Linq

Namespace GridViewFooter
	Friend Class GridControlFooterOnTop
		Inherits GridControl

		Protected Overrides Function CreateDefaultView() As DevExpress.XtraGrid.Views.Base.BaseView
			Return CreateView("GridViewFooterOnTop")
		End Function
		Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As DevExpress.XtraGrid.Registrator.InfoCollection)
			MyBase.RegisterAvailableViewsCore(collection)
			collection.Add(New GridFooterOnTopViewInfoRegistrator())
		End Sub
	End Class
End Namespace
