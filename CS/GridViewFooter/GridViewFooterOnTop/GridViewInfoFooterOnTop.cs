using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Drawing;
using System.Linq;

namespace GridViewFooter
{
    class GridViewInfoFooterOnTop : GridViewInfo
    {
        public GridViewInfoFooterOnTop(GridView gridView) : base(gridView) { }

        public override void CalcRects(System.Drawing.Rectangle bounds, bool partital)
        {
            GridViewFooterOnTop gv = View as GridViewFooterOnTop;
            Rectangle r = Rectangle.Empty;
            ViewRects.Bounds = bounds;
            ViewRects.Scroll = CalcScrollRect();
            ViewRects.Client = CalcClientRect();
            FilterPanel.Bounds = Rectangle.Empty;
            if(!partital)
            {
                CalcRectsConstants();
            }
            if(gv.OptionsView.ShowIndicator)
            {
                ViewRects.IndicatorWidth = Math.Max(View.IndicatorWidth, ViewRects.MinIndicatorWidth);
            }
            int minTop = ViewRects.Client.Top;
            int maxBottom = ViewRects.Client.Bottom;
            if(gv.OptionsView.ShowViewCaption)
            {
                r = ViewRects.Client;
                r.Y = minTop;
                r.Height = CalcViewCaptionHeight(ViewRects.Client);
                ViewRects.ViewCaption = r;
                minTop = ViewRects.ViewCaption.Bottom;
            }
            minTop = UpdateFindControlVisibility(new Rectangle(ViewRects.Client.X, minTop, ViewRects.Client.Width, maxBottom - minTop), true).Y;
            if(gv.OptionsView.ShowGroupPanel)
            {
                r = ViewRects.Client;
                r.Y = minTop;
                r.Height = CalcGroupPanelHeight();
                ViewRects.GroupPanel = r;
                minTop = ViewRects.GroupPanel.Bottom;
            }
            minTop = CalcRectsColumnPanel(minTop);
            if(gv.IsShowFilterPanel)
            {
                r = ViewRects.Client;
                int fPanel = GetFilterPanelHeight();
                r.Y = maxBottom - fPanel - HScrollPresenceCorrection();
                r.Height = fPanel;
                if(gv.OptionsView.FooterLocation != FooterPosition.Top)
                    if(VScrollBarPresence == ScrollBarPresence.Visible)
                        r.Width += VScrollSize;
                FilterPanel.Bounds = r;
                maxBottom = r.Top;
            }
            if(gv.OptionsView.ShowFooter)
            {
                r = ViewRects.Client;
                r.Height = GetFooterPanelHeight();

                if(gv.OptionsView.FooterLocation == FooterPosition.Top)
                {
                    maxBottom -= HScrollPresenceCorrection();
                    r.Y = minTop;
                    ViewRects.Footer = r;
                    minTop = ViewRects.Footer.Bottom;
                }
                else
                {
                    r.Y = maxBottom - r.Height;
                    if(!gv.IsShowFilterPanel)
                        r.Y -= HScrollPresenceCorrection();
                    r.Width = ViewRects.Bounds.Width;
                    ViewRects.Footer = r;
                    maxBottom = r.Top;
                }
            }
            r = ViewRects.Client;
            r.Y = minTop;
            r.Height = maxBottom - minTop;
            ViewRects.Rows = r;
        }

        public int HScrollPresenceCorrection()
        {
            if(HScrollBarPresence == ScrollBarPresence.Visible)
                return HScrollSize;
            return 0;
        }
    }
}
