using DevExpress.XtraGrid;
using System;
using System.Linq;

namespace GridViewFooter
{
    class GridControlFooterOnTop : GridControl
    {

        protected override DevExpress.XtraGrid.Views.Base.BaseView CreateDefaultView()
        { return CreateView("GridViewFooterOnTop"); }
        protected override void RegisterAvailableViewsCore(DevExpress.XtraGrid.Registrator.InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new GridFooterOnTopViewInfoRegistrator());
        }
    }
}
