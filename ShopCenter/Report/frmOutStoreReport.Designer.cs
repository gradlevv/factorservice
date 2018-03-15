namespace ShopCenter.Report
{
    partial class frmOutStoreReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOutStoreReport));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtYear2 = new Telerik.WinControls.UI.RadTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtYear1 = new Telerik.WinControls.UI.RadTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDay2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMounth2 = new System.Windows.Forms.ComboBox();
            this.cmbDay1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            this.dgvPStor = new Telerik.WinControls.UI.RadGridView();
            this.cmbMounth1 = new System.Windows.Forms.ComboBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPStor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPStor.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnSearch.Image = global::ShopCenter.Properties.Resources.Search;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(413, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 38);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnCancel.Image = global::ShopCenter.Properties.Resources.Back2;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(14, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 38);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "بازگشت";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtYear2
            // 
            this.txtYear2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtYear2.Location = new System.Drawing.Point(14, 15);
            this.txtYear2.MaxLength = 4;
            this.txtYear2.Name = "txtYear2";
            this.txtYear2.Size = new System.Drawing.Size(60, 19);
            this.txtYear2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label6.Location = new System.Drawing.Point(80, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "/";
            // 
            // btnPrint
            // 
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnPrint.Image = global::ShopCenter.Properties.Resources.Print;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(216, 10);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(82, 38);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtYear1
            // 
            this.txtYear1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtYear1.Location = new System.Drawing.Point(282, 15);
            this.txtYear1.MaxLength = 4;
            this.txtYear1.Name = "txtYear1";
            this.txtYear1.Size = new System.Drawing.Size(60, 19);
            this.txtYear1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label5.Location = new System.Drawing.Point(145, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label3.Location = new System.Drawing.Point(348, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "/";
            // 
            // cmbDay2
            // 
            this.cmbDay2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDay2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cmbDay2.FormattingEnabled = true;
            this.cmbDay2.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cmbDay2.Location = new System.Drawing.Point(97, 15);
            this.cmbDay2.Name = "cmbDay2";
            this.cmbDay2.Size = new System.Drawing.Size(42, 21);
            this.cmbDay2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label2.Location = new System.Drawing.Point(413, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "/";
            // 
            // cmbMounth2
            // 
            this.cmbMounth2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMounth2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cmbMounth2.FormattingEnabled = true;
            this.cmbMounth2.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbMounth2.Location = new System.Drawing.Point(164, 15);
            this.cmbMounth2.Name = "cmbMounth2";
            this.cmbMounth2.Size = new System.Drawing.Size(42, 21);
            this.cmbMounth2.TabIndex = 1;
            // 
            // cmbDay1
            // 
            this.cmbDay1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDay1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cmbDay1.FormattingEnabled = true;
            this.cmbDay1.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cmbDay1.Location = new System.Drawing.Point(365, 15);
            this.cmbDay1.Name = "cmbDay1";
            this.cmbDay1.Size = new System.Drawing.Size(42, 21);
            this.cmbDay1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label4.Location = new System.Drawing.Point(216, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "تا تاریخ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label1.Location = new System.Drawing.Point(480, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "از تاریخ :";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.btnSearch);
            this.radGroupBox1.Controls.Add(this.btnPrint);
            this.radGroupBox1.Controls.Add(this.btnCancel);
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 76);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(538, 63);
            this.radGroupBox1.TabIndex = 7;
            // 
            // stiReport1
            // 
            this.stiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport1.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport1.ReportAlias = "Report";
            this.stiReport1.ReportGuid = "59c0908bd36c41b2a11ac6b7c8fdc557";
            this.stiReport1.ReportName = "Report";
            this.stiReport1.ReportSource = resources.GetString("stiReport1.ReportSource");
            this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport1.UseProgressInThread = false;
            // 
            // dgvPStor
            // 
            this.dgvPStor.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dgvPStor.Location = new System.Drawing.Point(-2, 145);
            // 
            // 
            // 
            this.dgvPStor.MasterTemplate.AllowAddNewRow = false;
            this.dgvPStor.MasterTemplate.AllowColumnReorder = false;
            this.dgvPStor.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "ProductName";
            gridViewTextBoxColumn1.HeaderText = "نام کالا";
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn1.Width = 180;
            gridViewTextBoxColumn2.FieldName = "Count";
            gridViewTextBoxColumn2.HeaderText = "تعداد کالای خروجی";
            gridViewTextBoxColumn2.Name = "column2";
            gridViewTextBoxColumn2.Width = 180;
            gridViewTextBoxColumn3.FieldName = "Date";
            gridViewTextBoxColumn3.FormatString = "{00:yyyy/MM/dd}";
            gridViewTextBoxColumn3.HeaderText = "تاریخ";
            gridViewTextBoxColumn3.Name = "column3";
            gridViewTextBoxColumn3.Width = 180;
            this.dgvPStor.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.dgvPStor.MasterTemplate.EnableGrouping = false;
            this.dgvPStor.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgvPStor.Name = "dgvPStor";
            this.dgvPStor.ReadOnly = true;
            this.dgvPStor.Size = new System.Drawing.Size(559, 348);
            this.dgvPStor.TabIndex = 6;
            this.dgvPStor.Text = "radGridView1";
            // 
            // cmbMounth1
            // 
            this.cmbMounth1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMounth1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cmbMounth1.FormattingEnabled = true;
            this.cmbMounth1.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbMounth1.Location = new System.Drawing.Point(432, 15);
            this.cmbMounth1.Name = "cmbMounth1";
            this.cmbMounth1.Size = new System.Drawing.Size(42, 21);
            this.cmbMounth1.TabIndex = 1;
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.txtYear2);
            this.radGroupBox2.Controls.Add(this.label6);
            this.radGroupBox2.Controls.Add(this.txtYear1);
            this.radGroupBox2.Controls.Add(this.label5);
            this.radGroupBox2.Controls.Add(this.label3);
            this.radGroupBox2.Controls.Add(this.cmbDay2);
            this.radGroupBox2.Controls.Add(this.label2);
            this.radGroupBox2.Controls.Add(this.cmbMounth2);
            this.radGroupBox2.Controls.Add(this.cmbDay1);
            this.radGroupBox2.Controls.Add(this.cmbMounth1);
            this.radGroupBox2.Controls.Add(this.label4);
            this.radGroupBox2.Controls.Add(this.label1);
            this.radGroupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGroupBox2.HeaderText = "";
            this.radGroupBox2.Location = new System.Drawing.Point(10, 3);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(538, 56);
            this.radGroupBox2.TabIndex = 8;
            // 
            // frmOutStoreReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 489);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.dgvPStor);
            this.Controls.Add(this.radGroupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOutStoreReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش کالاهای خروجی";
            this.ThemeName = "Windows8";
            this.Load += new System.EventHandler(this.frmOutStoreReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtYear2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPStor.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPStor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private Telerik.WinControls.UI.RadTextBox txtYear2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrint;
        private Telerik.WinControls.UI.RadTextBox txtYear1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDay2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMounth2;
        private System.Windows.Forms.ComboBox cmbDay1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Stimulsoft.Report.StiReport stiReport1;
        private Telerik.WinControls.UI.RadGridView dgvPStor;
        private System.Windows.Forms.ComboBox cmbMounth1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
    }
}