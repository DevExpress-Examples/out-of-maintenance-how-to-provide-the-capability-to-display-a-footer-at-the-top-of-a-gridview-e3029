Imports Microsoft.VisualBasic
Imports DevExpress.Utils.Serializing
Imports DevExpress.XtraGrid.Views.Grid
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq

Namespace GridViewFooter
	Friend Class GridViewFooterOnTop
		Inherits GridView
		Public Sub New()
			Me.New(Nothing)
		End Sub
		Public Sub New(ByVal grid As DevExpress.XtraGrid.GridControl)
			MyBase.New(grid)
		End Sub

		Private Sub UpdateVScrollHeight()
			If OptionsView.ShowFooter AndAlso OptionsView.FooterLocation = FooterPosition.Top Then
				Dim r As Rectangle = ScrollInfo.VScrollSuggestedBounds
				r.Height = ViewInfo.ViewRects.Client.Height - ViewInfo.HScrollPresenceCorrection()
				ScrollInfo.VScrollSuggestedBounds = r
			End If
		End Sub

		Protected Overrides Function CreateOptionsView() As DevExpress.XtraGrid.Views.Base.ColumnViewOptionsView
			Return New GridFooterOnTopOptionsView()
		End Function

		Protected Overrides Sub UpdateScrollBars()
			MyBase.UpdateScrollBars()
			UpdateVScrollHeight()
		End Sub

		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return "GridViewFooterOnTop"
			End Get
		End Property

		<Description("Provides access to the View's display options."), Category("Options"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), XtraSerializableProperty(XtraSerializationVisibility.Content, XtraSerializationFlags.DefaultValue), XtraSerializablePropertyId(LayoutIdOptionsView)> _
		Public Shadows ReadOnly Property OptionsView() As GridFooterOnTopOptionsView
			Get
				Return TryCast(MyBase.OptionsView, GridFooterOnTopOptionsView)
			End Get
		End Property
		Public Shadows ReadOnly Property ViewInfo() As GridViewInfoFooterOnTop
			Get
				Return TryCast(MyBase.ViewInfo, GridViewInfoFooterOnTop)
			End Get
		End Property
	End Class
End Namespace
