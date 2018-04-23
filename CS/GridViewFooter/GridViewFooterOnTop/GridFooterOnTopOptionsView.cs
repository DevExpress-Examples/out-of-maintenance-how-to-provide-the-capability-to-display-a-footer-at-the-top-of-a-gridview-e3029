using DevExpress.Utils.Controls;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Linq;

namespace GridViewFooter
{
    public enum FooterPosition { Top, Bottom };

    class GridFooterOnTopOptionsView : GridOptionsView
    {
        FooterPosition footerPosition;

        public GridFooterOnTopOptionsView()
            : base()
        { this.footerPosition = FooterPosition.Bottom; }

        public override void Assign(DevExpress.Utils.Controls.BaseOptions options)
        {
            BeginUpdate();
            try
            {
                base.Assign(options);
                GridFooterOnTopOptionsView opt = options as GridFooterOnTopOptionsView;
                if(opt == null) return;
                this.footerPosition = opt.footerPosition;
            }
            finally
            {
                EndUpdate();
            }
        }

        public virtual FooterPosition FooterLocation {
            get { return footerPosition; }
            set {
                FooterPosition prevValue = FooterLocation;
                footerPosition = value;
                OnChanged(new BaseOptionChangedEventArgs("FooterLocation", prevValue, ShowFooter));
            }
        }
    }
}
