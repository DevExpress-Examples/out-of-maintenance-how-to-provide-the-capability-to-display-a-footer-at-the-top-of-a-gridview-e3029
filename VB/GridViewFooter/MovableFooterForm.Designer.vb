' Developer Express Code Central Example:
' How to provide the capability to display a footer at the top of a GridView
' 
' The current example illustrates how to customize the default GridView, so that
' it can display a footer at the top of a view.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3029


Imports Microsoft.VisualBasic
Imports System
Namespace GridViewFooter
	Partial Public Class MovableFooterForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControlFooterOnTop1 = New GridViewFooter.GridControlFooterOnTop()
			Me.gridViewFooterOnTop1 = New GridViewFooter.GridViewFooterOnTop()
			Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.gridControlFooterOnTop1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridViewFooterOnTop1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControlFooterOnTop1
			' 
			Me.gridControlFooterOnTop1.Dock = System.Windows.Forms.DockStyle.Left
			Me.gridControlFooterOnTop1.Location = New System.Drawing.Point(0, 0)
			Me.gridControlFooterOnTop1.MainView = Me.gridViewFooterOnTop1
			Me.gridControlFooterOnTop1.Name = "gridControlFooterOnTop1"
			Me.gridControlFooterOnTop1.Size = New System.Drawing.Size(276, 224)
			Me.gridControlFooterOnTop1.TabIndex = 0
			Me.gridControlFooterOnTop1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridViewFooterOnTop1})
			' 
			' gridViewFooterOnTop1
			' 
			Me.gridViewFooterOnTop1.GridControl = Me.gridControlFooterOnTop1
			Me.gridViewFooterOnTop1.Name = "gridViewFooterOnTop1"
			Me.gridViewFooterOnTop1.OptionsView.FooterLocation = GridViewFooter.FooterPosition.Bottom
			Me.gridViewFooterOnTop1.OptionsView.ShowFooter = True
			' 
			' checkEdit1
			' 
			Me.checkEdit1.Location = New System.Drawing.Point(298, 12)
			Me.checkEdit1.Name = "checkEdit1"
			Me.checkEdit1.Properties.Caption = "Footer on top"
			Me.checkEdit1.Size = New System.Drawing.Size(98, 19)
			Me.checkEdit1.TabIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(396, 224)
			Me.Controls.Add(Me.checkEdit1)
			Me.Controls.Add(Me.gridControlFooterOnTop1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControlFooterOnTop1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridViewFooterOnTop1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControlFooterOnTop1 As GridControlFooterOnTop
		Private gridViewFooterOnTop1 As GridViewFooterOnTop
		Private checkEdit1 As DevExpress.XtraEditors.CheckEdit

	End Class
End Namespace

