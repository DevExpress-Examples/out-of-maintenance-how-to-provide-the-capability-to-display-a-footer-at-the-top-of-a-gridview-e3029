using DevExpress.Utils.Serializing;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace GridViewFooter
{
    class GridViewFooterOnTop : GridView
    {
        public GridViewFooterOnTop() : this(null) { }
        public GridViewFooterOnTop(DevExpress.XtraGrid.GridControl grid) : base(grid) { }

        private void UpdateVScrollHeight()
        {
            if(OptionsView.ShowFooter && OptionsView.FooterLocation == FooterPosition.Top)
            {
                Rectangle r = ScrollInfo.VScrollSuggestedBounds;
                r.Height = ViewInfo.ViewRects.Client.Height - ViewInfo.HScrollPresenceCorrection();
                ScrollInfo.VScrollSuggestedBounds = r;
            }
        }

        protected override DevExpress.XtraGrid.Views.Base.ColumnViewOptionsView CreateOptionsView()
        { return new GridFooterOnTopOptionsView(); }

        protected override void UpdateScrollBars()
        {
            base.UpdateScrollBars();
            UpdateVScrollHeight();
        }

        protected override string ViewName { get { return "GridViewFooterOnTop"; } }

        [Description("Provides access to the View's display options."), Category("Options"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
        XtraSerializableProperty(XtraSerializationVisibility.Content, XtraSerializationFlags.DefaultValue),
        XtraSerializablePropertyId(LayoutIdOptionsView)]
        public new GridFooterOnTopOptionsView OptionsView { get { return base.OptionsView as GridFooterOnTopOptionsView; } }
        public new GridViewInfoFooterOnTop ViewInfo { get { return base.ViewInfo as GridViewInfoFooterOnTop; } }
    }
}
