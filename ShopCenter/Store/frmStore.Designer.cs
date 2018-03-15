namespace ShopCenter.Store
{
    partial class frmStore
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.dgvStore = new Telerik.WinControls.UI.RadGridView();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnProductIn = new System.Windows.Forms.Button();
            this.btnNewStor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStore
            // 
            this.dgvStore.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvStore.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dgvStore.Location = new System.Drawing.Point(0, 89);
            // 
            // 
            // 
            this.dgvStore.MasterTemplate.AllowAddNewRow = false;
            this.dgvStore.MasterTemplate.AllowColumnReorder = false;
            this.dgvStore.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "ProductID";
            gridViewTextBoxColumn1.HeaderText = "ProductID";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn2.FieldName = "ProductName";
            gridViewTextBoxColumn2.HeaderText = "نام محصول";
            gridViewTextBoxColumn2.Name = "column2";
            gridViewTextBoxColumn2.Width = 302;
            gridViewTextBoxColumn3.FieldName = "Count";
            gridViewTextBoxColumn3.HeaderText = "تعداد";
            gridViewTextBoxColumn3.Name = "column3";
            gridViewTextBoxColumn3.Width = 301;
            this.dgvStore.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.dgvStore.MasterTemplate.EnableGrouping = false;
            this.dgvStore.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgvStore.Name = "dgvStore";
            this.dgvStore.ReadOnly = true;
            this.dgvStore.Size = new System.Drawing.Size(623, 355);
            this.dgvStore.TabIndex = 0;
            this.dgvStore.Text = "radGridView1";
            this.dgvStore.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgvStore_CellClick);
            this.dgvStore.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgvStore_CellDoubleClick);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.btnCancel);
            this.radGroupBox1.Controls.Add(this.btnProductIn);
            this.radGroupBox1.Controls.Add(this.btnNewStor);
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(599, 64);
            this.radGroupBox1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnCancel.Image = global::ShopCenter.Properties.Resources.Back2;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(33, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 37);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "بازگشت";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnProductIn
            // 
            this.btnProductIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductIn.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnProductIn.Image = global::ShopCenter.Properties.Resources.Chart;
            this.btnProductIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductIn.Location = new System.Drawing.Point(228, 13);
            this.btnProductIn.Name = "btnProductIn";
            this.btnProductIn.Size = new System.Drawing.Size(111, 37);
            this.btnProductIn.TabIndex = 1;
            this.btnProductIn.Text = " کالای ورودی";
            this.btnProductIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductIn.UseVisualStyleBackColor = true;
            this.btnProductIn.Click += new System.EventHandler(this.btnProductIn_Click);
            // 
            // btnNewStor
            // 
            this.btnNewStor.Enabled = false;
            this.btnNewStor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewStor.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnNewStor.Image = global::ShopCenter.Properties.Resources.Add;
            this.btnNewStor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewStor.Location = new System.Drawing.Point(460, 13);
            this.btnNewStor.Name = "btnNewStor";
            this.btnNewStor.Size = new System.Drawing.Size(96, 38);
            this.btnNewStor.TabIndex = 0;
            this.btnNewStor.Text = "ورود کالا";
            this.btnNewStor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewStor.UseVisualStyleBackColor = true;
            this.btnNewStor.Click += new System.EventHandler(this.btnNewStor_Click);
            // 
            // frmStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 444);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.dgvStore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStore";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت انبار";
            this.ThemeName = "Windows8";
            this.Load += new System.EventHandler(this.frmStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgvStore;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnProductIn;
        private System.Windows.Forms.Button btnNewStor;
    }
}