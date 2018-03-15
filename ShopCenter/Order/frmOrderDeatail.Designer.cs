namespace ShopCenter.Order
{
    partial class frmOrderDeatail
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.dgvDeatail = new Telerik.WinControls.UI.RadGridView();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtPriceAll = new Telerik.WinControls.UI.RadTextBox();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeatail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeatail.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDeatail
            // 
            this.dgvDeatail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDeatail.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dgvDeatail.Location = new System.Drawing.Point(0, 61);
            // 
            // 
            // 
            this.dgvDeatail.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "ProductName";
            gridViewTextBoxColumn1.HeaderText = "نام کالا";
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn1.Width = 126;
            gridViewTextBoxColumn2.FieldName = "Count";
            gridViewTextBoxColumn2.HeaderText = "تعداد کالا";
            gridViewTextBoxColumn2.Name = "column2";
            gridViewTextBoxColumn2.Width = 126;
            gridViewTextBoxColumn3.FieldName = "Price";
            gridViewTextBoxColumn3.HeaderText = "قیمت کالا";
            gridViewTextBoxColumn3.Name = "column3";
            gridViewTextBoxColumn3.Width = 126;
            gridViewTextBoxColumn4.FieldName = "PriceAll";
            gridViewTextBoxColumn4.HeaderText = "جمع کل";
            gridViewTextBoxColumn4.Name = "column4";
            gridViewTextBoxColumn4.Width = 125;
            this.dgvDeatail.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.dgvDeatail.MasterTemplate.EnableGrouping = false;
            this.dgvDeatail.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgvDeatail.Name = "dgvDeatail";
            this.dgvDeatail.ReadOnly = true;
            this.dgvDeatail.Size = new System.Drawing.Size(521, 352);
            this.dgvDeatail.TabIndex = 0;
            this.dgvDeatail.Text = "radGridView1";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel1.Location = new System.Drawing.Point(427, 14);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(82, 17);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "جمع کل فاکتور :";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPriceAll
            // 
            this.txtPriceAll.Enabled = false;
            this.txtPriceAll.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtPriceAll.Location = new System.Drawing.Point(279, 12);
            this.txtPriceAll.Name = "txtPriceAll";
            this.txtPriceAll.Size = new System.Drawing.Size(142, 19);
            this.txtPriceAll.TabIndex = 2;
            // 
            // frmOrderDeatail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 413);
            this.Controls.Add(this.txtPriceAll);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.dgvDeatail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrderDeatail";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جزییات فاکتور";
            this.ThemeName = "Windows8";
            this.Load += new System.EventHandler(this.frmOrderDeatail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeatail.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeatail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgvDeatail;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtPriceAll;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
    }
}