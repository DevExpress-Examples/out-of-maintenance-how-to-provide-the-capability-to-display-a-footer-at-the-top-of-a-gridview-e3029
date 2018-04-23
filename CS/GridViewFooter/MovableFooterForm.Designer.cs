// Developer Express Code Central Example:
// How to provide the capability to display a footer at the top of a GridView
// 
// The current example illustrates how to customize the default GridView, so that
// it can display a footer at the top of a view.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E3029

namespace GridViewFooter
{
    partial class MovableFooterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControlFooterOnTop1 = new GridViewFooter.GridControlFooterOnTop();
            this.gridViewFooterOnTop1 = new GridViewFooter.GridViewFooterOnTop();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFooterOnTop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFooterOnTop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlFooterOnTop1
            // 
            this.gridControlFooterOnTop1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControlFooterOnTop1.Location = new System.Drawing.Point(0, 0);
            this.gridControlFooterOnTop1.MainView = this.gridViewFooterOnTop1;
            this.gridControlFooterOnTop1.Name = "gridControlFooterOnTop1";
            this.gridControlFooterOnTop1.Size = new System.Drawing.Size(276, 224);
            this.gridControlFooterOnTop1.TabIndex = 0;
            this.gridControlFooterOnTop1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFooterOnTop1});
            // 
            // gridViewFooterOnTop1
            // 
            this.gridViewFooterOnTop1.GridControl = this.gridControlFooterOnTop1;
            this.gridViewFooterOnTop1.Name = "gridViewFooterOnTop1";
            this.gridViewFooterOnTop1.OptionsView.FooterLocation = GridViewFooter.FooterPosition.Bottom;
            this.gridViewFooterOnTop1.OptionsView.ShowFooter = true;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(298, 12);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Footer on top";
            this.checkEdit1.Size = new System.Drawing.Size(98, 19);
            this.checkEdit1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 224);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.gridControlFooterOnTop1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFooterOnTop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFooterOnTop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GridControlFooterOnTop gridControlFooterOnTop1;
        private GridViewFooterOnTop gridViewFooterOnTop1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;

    }
}

