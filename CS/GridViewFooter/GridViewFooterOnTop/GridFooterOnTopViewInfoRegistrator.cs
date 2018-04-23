using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using System;
using System.Linq;

namespace GridViewFooter
{
    class GridFooterOnTopViewInfoRegistrator : GridInfoRegistrator
    {
        public override BaseView CreateView(GridControl grid)
        { return new GridViewFooterOnTop(grid); }
        public override BaseViewInfo CreateViewInfo(BaseView view)
        { return new GridViewInfoFooterOnTop(view as GridViewFooterOnTop); }

        public override string ViewName { get { return "GridViewFooterOnTop"; } }
    }
}
