Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports System
Imports System.Data
Imports System.Linq
Imports System.Windows.Forms

Namespace GridViewFooter
	Partial Public Class MovableFooterForm
		Inherits DevExpress.XtraEditors.XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim ce As CheckEdit = TryCast(sender, CheckEdit)
			If ce.Checked Then
				gridViewFooterOnTop1.OptionsView.FooterLocation = FooterPosition.Top
			Else
				gridViewFooterOnTop1.OptionsView.FooterLocation = FooterPosition.Bottom
			End If
		End Sub

		Private Function FillTable() As DataTable
			Dim _customersTable As New DataTable()
			Dim col As DataColumn
			Dim row As DataRow

			_customersTable.TableName = "Customers"

			col = New DataColumn()
			col.ColumnName = "Customer"
			col.DataType = System.Type.GetType("System.String")
			_customersTable.Columns.Add(col)

			col = New DataColumn()
			col.ColumnName = "Purchase Price"
			col.DataType = System.Type.GetType("System.Double")
			_customersTable.Columns.Add(col)

			row = _customersTable.NewRow()
			row("Customer") = "John"
			row("Purchase Price") = 120
			_customersTable.Rows.Add(row)

			row = _customersTable.NewRow()
			row("Customer") = "Jane"
			row("Purchase Price") = 350
			_customersTable.Rows.Add(row)

			row = _customersTable.NewRow()
			row("Customer") = "Jack"
			row("Purchase Price") = 71
			_customersTable.Rows.Add(row)

			For i As Integer = 0 To 99
				row = _customersTable.NewRow()
				row("Customer") = "Jack"
				row("Purchase Price") = 71
				_customersTable.Rows.Add(row)
			Next i
			Return _customersTable
		End Function

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			gridControlFooterOnTop1.DataSource = FillTable()

			Dim gc As GridColumn = gridViewFooterOnTop1.Columns("Purchase Price")
			gc.SummaryItem.FieldName = "Purchase Price"
			gc.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum

            AddHandler checkEdit1.CheckedChanged, AddressOf checkEdit1_CheckedChanged
        End Sub
	End Class
End Namespace