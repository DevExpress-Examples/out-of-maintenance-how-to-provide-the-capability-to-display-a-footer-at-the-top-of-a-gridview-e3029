Imports Microsoft.VisualBasic
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System
Imports System.Drawing
Imports System.Linq

Namespace GridViewFooter
	Friend Class GridViewInfoFooterOnTop
		Inherits GridViewInfo
		Public Sub New(ByVal gridView As GridView)
			MyBase.New(gridView)
		End Sub

		Public Overrides Sub CalcRects(ByVal bounds As System.Drawing.Rectangle, ByVal partital As Boolean)
			Dim gv As GridViewFooterOnTop = TryCast(View, GridViewFooterOnTop)
			Dim r As Rectangle = Rectangle.Empty
			ViewRects.Bounds = bounds
			ViewRects.Scroll = CalcScrollRect()
			ViewRects.Client = CalcClientRect()
			FilterPanel.Bounds = Rectangle.Empty
			If (Not partital) Then
				CalcRectsConstants()
			End If
			If gv.OptionsView.ShowIndicator Then
				ViewRects.IndicatorWidth = Math.Max(View.IndicatorWidth, ViewRects.MinIndicatorWidth)
			End If
			Dim minTop As Integer = ViewRects.Client.Top
			Dim maxBottom As Integer = ViewRects.Client.Bottom
			If gv.OptionsView.ShowViewCaption Then
				r = ViewRects.Client
				r.Y = minTop
				r.Height = CalcViewCaptionHeight(ViewRects.Client)
				ViewRects.ViewCaption = r
				minTop = ViewRects.ViewCaption.Bottom
			End If
			minTop = UpdateFindControlVisibility(New Rectangle(ViewRects.Client.X, minTop, ViewRects.Client.Width, maxBottom - minTop), True).Y
			If gv.OptionsView.ShowGroupPanel Then
				r = ViewRects.Client
				r.Y = minTop
				r.Height = CalcGroupPanelHeight()
				ViewRects.GroupPanel = r
				minTop = ViewRects.GroupPanel.Bottom
			End If
			minTop = CalcRectsColumnPanel(minTop)
			If gv.IsShowFilterPanel Then
				r = ViewRects.Client
				Dim fPanel As Integer = GetFilterPanelHeight()
				r.Y = maxBottom - fPanel - HScrollPresenceCorrection()
				r.Height = fPanel
				If gv.OptionsView.FooterLocation <> FooterPosition.Top Then
					If VScrollBarPresence = ScrollBarPresence.Visible Then
						r.Width += VScrollSize
					End If
				End If
				FilterPanel.Bounds = r
				maxBottom = r.Top
			End If
			If gv.OptionsView.ShowFooter Then
				r = ViewRects.Client
				r.Height = GetFooterPanelHeight()

				If gv.OptionsView.FooterLocation = FooterPosition.Top Then
					maxBottom -= HScrollPresenceCorrection()
					r.Y = minTop
					ViewRects.Footer = r
					minTop = ViewRects.Footer.Bottom
				Else
					r.Y = maxBottom - r.Height
					If (Not gv.IsShowFilterPanel) Then
						r.Y -= HScrollPresenceCorrection()
					End If
					r.Width = ViewRects.Bounds.Width
					ViewRects.Footer = r
					maxBottom = r.Top
				End If
			End If
			r = ViewRects.Client
			r.Y = minTop
			r.Height = maxBottom - minTop
			ViewRects.Rows = r
		End Sub

		Public Function HScrollPresenceCorrection() As Integer
			If HScrollBarPresence = ScrollBarPresence.Visible Then
				Return HScrollSize
			End If
			Return 0
		End Function
	End Class
End Namespace
