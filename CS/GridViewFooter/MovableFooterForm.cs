using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GridViewFooter
{
    public partial class MovableFooterForm : DevExpress.XtraEditors.XtraForm
    {
        public MovableFooterForm()
        {
            InitializeComponent();
        }

        void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit ce = sender as CheckEdit;
            if(ce.Checked)
                gridViewFooterOnTop1.OptionsView.FooterLocation = FooterPosition.Top;
            else
                gridViewFooterOnTop1.OptionsView.FooterLocation = FooterPosition.Bottom;
        }

        DataTable FillTable()
        {
            DataTable _customersTable = new DataTable();
            DataColumn col;
            DataRow row;

            _customersTable.TableName = "Customers";

            col = new DataColumn();
            col.ColumnName = "Customer";
            col.DataType = System.Type.GetType("System.String");
            _customersTable.Columns.Add(col);

            col = new DataColumn();
            col.ColumnName = "Purchase Price";
            col.DataType = System.Type.GetType("System.Double");
            _customersTable.Columns.Add(col);

            row = _customersTable.NewRow();
            row["Customer"] = "John";
            row["Purchase Price"] = 120;
            _customersTable.Rows.Add(row);

            row = _customersTable.NewRow();
            row["Customer"] = "Jane";
            row["Purchase Price"] = 350;
            _customersTable.Rows.Add(row);

            row = _customersTable.NewRow();
            row["Customer"] = "Jack";
            row["Purchase Price"] = 71;
            _customersTable.Rows.Add(row);

            for(int i = 0; i < 100; i++)
            {
                row = _customersTable.NewRow();
                row["Customer"] = "Jack";
                row["Purchase Price"] = 71;
                _customersTable.Rows.Add(row);
            }
            return _customersTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridControlFooterOnTop1.DataSource = FillTable();

            GridColumn gc = gridViewFooterOnTop1.Columns["Purchase Price"];
            gc.SummaryItem.FieldName = "Purchase Price";
            gc.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;

            checkEdit1.CheckedChanged += new EventHandler(checkEdit1_CheckedChanged);
        }
    }
}