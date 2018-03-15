namespace ShopCenter.Store
{
    partial class frmProductStor
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
            this.dgvPStor = new Telerik.WinControls.UI.RadGridView();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPStor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPStor.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPStor
            // 
            this.dgvPStor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPStor.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dgvPStor.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.dgvPStor.MasterTemplate.AllowAddNewRow = false;
            this.dgvPStor.MasterTemplate.AllowColumnReorder = false;
            this.dgvPStor.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "StoreID";
            gridViewTextBoxColumn1.HeaderText = "StoreID";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "column4";
            gridViewTextBoxColumn1.Width = 46;
            gridViewTextBoxColumn2.FieldName = "Proname";
            gridViewTextBoxColumn2.HeaderText = "نام کالا";
            gridViewTextBoxColumn2.Name = "column1";
            gridViewTextBoxColumn2.Width = 183;
            gridViewTextBoxColumn3.FieldName = "Count";
            gridViewTextBoxColumn3.HeaderText = "تعداد کالای ورودی";
            gridViewTextBoxColumn3.Name = "column2";
            gridViewTextBoxColumn3.Width = 183;
            gridViewTextBoxColumn4.FieldName = "Date";
            gridViewTextBoxColumn4.FormatString = "{00:yyyy/MM/dd}";
            gridViewTextBoxColumn4.HeaderText = "تاریخ";
            gridViewTextBoxColumn4.Name = "column3";
            gridViewTextBoxColumn4.Width = 182;
            this.dgvPStor.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.dgvPStor.MasterTemplate.EnableGrouping = false;
            this.dgvPStor.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgvPStor.Name = "dgvPStor";
            this.dgvPStor.ReadOnly = true;
            this.dgvPStor.Size = new System.Drawing.Size(567, 450);
            this.dgvPStor.TabIndex = 0;
            this.dgvPStor.Text = "radGridView1";
            // 
            // frmProductStor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.dgvPStor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductStor";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کالاهای ورودی به انبار";
            this.ThemeName = "Windows8";
            this.Load += new System.EventHandler(this.frmProductStor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPStor.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPStor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgvPStor;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
    }
}