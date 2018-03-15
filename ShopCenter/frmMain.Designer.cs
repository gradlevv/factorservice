namespace ShopCenter
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.ribbonClientPanel1 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.btnCustomer = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup2 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement2 = new Telerik.WinControls.UI.RadButtonElement();
            this.btnProduct = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup3 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement3 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement4 = new Telerik.WinControls.UI.RadButtonElement();
            this.btnStore = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup10 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnOrders = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup11 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnExit = new Telerik.WinControls.UI.RadButtonElement();
            this.ribbonTab2 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup4 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnStorReport = new Telerik.WinControls.UI.RadButtonElement();
            this.btnStoreIn = new Telerik.WinControls.UI.RadButtonElement();
            this.btnStoreOutReport = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup5 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnCustomerReport = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup6 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement7 = new Telerik.WinControls.UI.RadButtonElement();
            this.btnFactors = new Telerik.WinControls.UI.RadButtonElement();
            this.ProductReprot = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnProductReportn = new Telerik.WinControls.UI.RadButtonElement();
            this.ribbonTab3 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup7 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnBackUp = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup8 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnRestore = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup9 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnSetting = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement11 = new Telerik.WinControls.UI.RadButtonElement();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.ribbonClientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // ribbonClientPanel1
            // 
            this.ribbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel1.Controls.Add(this.radRibbonBar1);
            this.ribbonClientPanel1.Location = new System.Drawing.Point(0, -1);
            this.ribbonClientPanel1.Name = "ribbonClientPanel1";
            this.ribbonClientPanel1.Size = new System.Drawing.Size(494, 422);
            // 
            // 
            // 
            this.ribbonClientPanel1.Style.Class = "RibbonClientPanel";
            this.ribbonClientPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonClientPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonClientPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonClientPanel1.TabIndex = 1;
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTab1,
            this.ribbonTab2,
            this.ribbonTab3});
            // 
            // 
            // 
            this.radRibbonBar1.ExitButton.Enabled = false;
            this.radRibbonBar1.ExitButton.Text = "Exit";
            this.radRibbonBar1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.MaximizeButton = false;
            this.radRibbonBar1.MinimizeButton = false;
            this.radRibbonBar1.Name = "radRibbonBar1";
            // 
            // 
            // 
            this.radRibbonBar1.OptionsButton.Enabled = false;
            this.radRibbonBar1.OptionsButton.Text = "Options";
            this.radRibbonBar1.QuickAccessToolBarItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement11});
            // 
            // 
            // 
            this.radRibbonBar1.RootElement.Enabled = true;
            this.radRibbonBar1.ShowExpandButton = false;
            this.radRibbonBar1.Size = new System.Drawing.Size(494, 162);
            this.radRibbonBar1.StartMenuRightColumnItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuSeparatorItem1});
            this.radRibbonBar1.TabIndex = 1;
            ((Telerik.WinControls.UI.RadQuickAccessToolBar)(this.radRibbonBar1.GetChildAt(0).GetChildAt(2))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadQuickAccessToolBar)(this.radRibbonBar1.GetChildAt(0).GetChildAt(2))).Enabled = true;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.AutoEllipsis = false;
            this.ribbonTab1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ribbonTab1.IsSelected = true;
            this.ribbonTab1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup1,
            this.radRibbonBarGroup2,
            this.radRibbonBarGroup3,
            this.radRibbonBarGroup10,
            this.radRibbonBarGroup11});
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "اطلاعات پایه";
            this.ribbonTab1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // radRibbonBarGroup1
            // 
            this.radRibbonBarGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement1,
            this.btnCustomer});
            this.radRibbonBarGroup1.Margin = new System.Windows.Forms.Padding(0);
            this.radRibbonBarGroup1.MaxSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup1.MinSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
            this.radRibbonBarGroup1.Text = "مشتریان";
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.Name = "radButtonElement1";
            this.radButtonElement1.Text = "";
            // 
            // btnCustomer
            // 
            this.btnCustomer.Image = global::ShopCenter.Properties.Resources.boss;
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Text = "";
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // radRibbonBarGroup2
            // 
            this.radRibbonBarGroup2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement2,
            this.btnProduct});
            this.radRibbonBarGroup2.Margin = new System.Windows.Forms.Padding(0);
            this.radRibbonBarGroup2.MaxSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup2.MinSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup2.Name = "radRibbonBarGroup2";
            this.radRibbonBarGroup2.Text = "کالاها";
            // 
            // radButtonElement2
            // 
            this.radButtonElement2.Name = "radButtonElement2";
            this.radButtonElement2.Text = "";
            // 
            // btnProduct
            // 
            this.btnProduct.Image = global::ShopCenter.Properties.Resources.shopping_bag;
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Text = "";
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // radRibbonBarGroup3
            // 
            this.radRibbonBarGroup3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement3,
            this.radButtonElement4,
            this.btnStore});
            this.radRibbonBarGroup3.Margin = new System.Windows.Forms.Padding(0);
            this.radRibbonBarGroup3.MaxSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup3.MinSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup3.Name = "radRibbonBarGroup3";
            this.radRibbonBarGroup3.Text = "انبار";
            // 
            // radButtonElement3
            // 
            this.radButtonElement3.Name = "radButtonElement3";
            this.radButtonElement3.Text = "";
            // 
            // radButtonElement4
            // 
            this.radButtonElement4.Name = "radButtonElement4";
            this.radButtonElement4.Text = "";
            // 
            // btnStore
            // 
            this.btnStore.Image = global::ShopCenter.Properties.Resources.trolley;
            this.btnStore.Name = "btnStore";
            this.btnStore.Text = "";
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // radRibbonBarGroup10
            // 
            this.radRibbonBarGroup10.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnOrders});
            this.radRibbonBarGroup10.Margin = new System.Windows.Forms.Padding(0);
            this.radRibbonBarGroup10.MaxSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup10.MinSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup10.Name = "radRibbonBarGroup10";
            this.radRibbonBarGroup10.Text = "سفارشات";
            // 
            // btnOrders
            // 
            this.btnOrders.Image = global::ShopCenter.Properties.Resources.order;
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Text = "";
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // radRibbonBarGroup11
            // 
            this.radRibbonBarGroup11.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnExit});
            this.radRibbonBarGroup11.Name = "radRibbonBarGroup11";
            this.radRibbonBarGroup11.Text = "خروج";
            // 
            // btnExit
            // 
            this.btnExit.Image = global::ShopCenter.Properties.Resources.Delete1;
            this.btnExit.Name = "btnExit";
            this.btnExit.Text = "";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.AutoEllipsis = false;
            this.ribbonTab2.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ribbonTab2.IsSelected = false;
            this.ribbonTab2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup4,
            this.radRibbonBarGroup5,
            this.radRibbonBarGroup6,
            this.ProductReprot});
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Text = "گزارشات";
            this.ribbonTab2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // radRibbonBarGroup4
            // 
            this.radRibbonBarGroup4.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnStorReport,
            this.btnStoreIn,
            this.btnStoreOutReport});
            this.radRibbonBarGroup4.Margin = new System.Windows.Forms.Padding(0);
            this.radRibbonBarGroup4.MaxSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup4.MinSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup4.Name = "radRibbonBarGroup4";
            this.radRibbonBarGroup4.Text = "انبار";
            // 
            // btnStorReport
            // 
            this.btnStorReport.Image = global::ShopCenter.Properties.Resources.search__1_;
            this.btnStorReport.Name = "btnStorReport";
            this.btnStorReport.Text = "";
            this.btnStorReport.Click += new System.EventHandler(this.btnStorReport_Click);
            // 
            // btnStoreIn
            // 
            this.btnStoreIn.Image = global::ShopCenter.Properties.Resources.package__1_;
            this.btnStoreIn.Name = "btnStoreIn";
            this.btnStoreIn.Text = "";
            this.btnStoreIn.Click += new System.EventHandler(this.btnStoreIn_Click);
            // 
            // btnStoreOutReport
            // 
            this.btnStoreOutReport.Image = global::ShopCenter.Properties.Resources.package;
            this.btnStoreOutReport.Name = "btnStoreOutReport";
            this.btnStoreOutReport.Text = "";
            this.btnStoreOutReport.Click += new System.EventHandler(this.btnStoreOutReport_Click);
            // 
            // radRibbonBarGroup5
            // 
            this.radRibbonBarGroup5.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnCustomerReport});
            this.radRibbonBarGroup5.Margin = new System.Windows.Forms.Padding(0);
            this.radRibbonBarGroup5.MaxSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup5.MinSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup5.Name = "radRibbonBarGroup5";
            this.radRibbonBarGroup5.Text = "مشتریان";
            // 
            // btnCustomerReport
            // 
            this.btnCustomerReport.Image = global::ShopCenter.Properties.Resources.loupe;
            this.btnCustomerReport.Name = "btnCustomerReport";
            this.btnCustomerReport.Text = "";
            this.btnCustomerReport.Click += new System.EventHandler(this.btnCustomerReport_Click);
            // 
            // radRibbonBarGroup6
            // 
            this.radRibbonBarGroup6.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement7,
            this.btnFactors});
            this.radRibbonBarGroup6.Margin = new System.Windows.Forms.Padding(0);
            this.radRibbonBarGroup6.MaxSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup6.MinSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup6.Name = "radRibbonBarGroup6";
            this.radRibbonBarGroup6.Text = "فاکتورها";
            // 
            // radButtonElement7
            // 
            this.radButtonElement7.Name = "radButtonElement7";
            this.radButtonElement7.Text = "";
            // 
            // btnFactors
            // 
            this.btnFactors.Image = global::ShopCenter.Properties.Resources.laptop;
            this.btnFactors.Name = "btnFactors";
            this.btnFactors.Text = "";
            this.btnFactors.Click += new System.EventHandler(this.btnFactors_Click);
            // 
            // ProductReprot
            // 
            this.ProductReprot.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnProductReportn});
            this.ProductReprot.Name = "ProductReprot";
            this.ProductReprot.Text = "کالاها";
            // 
            // btnProductReportn
            // 
            this.btnProductReportn.Image = global::ShopCenter.Properties.Resources.packing;
            this.btnProductReportn.Name = "btnProductReportn";
            this.btnProductReportn.Text = "";
            this.btnProductReportn.Click += new System.EventHandler(this.btnProductReportn_Click);
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.AutoEllipsis = false;
            this.ribbonTab3.AutoSize = true;
            this.ribbonTab3.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ribbonTab3.IsSelected = false;
            this.ribbonTab3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup7,
            this.radRibbonBarGroup8,
            this.radRibbonBarGroup9});
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Text = "تنظیمات";
            this.ribbonTab3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // radRibbonBarGroup7
            // 
            this.radRibbonBarGroup7.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnBackUp});
            this.radRibbonBarGroup7.Margin = new System.Windows.Forms.Padding(0);
            this.radRibbonBarGroup7.MaxSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup7.MinSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup7.Name = "radRibbonBarGroup7";
            this.radRibbonBarGroup7.Text = "پشتیبان گیری";
            // 
            // btnBackUp
            // 
            this.btnBackUp.Image = global::ShopCenter.Properties.Resources.database__2_;
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Text = "";
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // radRibbonBarGroup8
            // 
            this.radRibbonBarGroup8.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnRestore});
            this.radRibbonBarGroup8.Margin = new System.Windows.Forms.Padding(0);
            this.radRibbonBarGroup8.MaxSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup8.MinSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup8.Name = "radRibbonBarGroup8";
            this.radRibbonBarGroup8.Text = "بازیابی";
            // 
            // btnRestore
            // 
            this.btnRestore.Image = global::ShopCenter.Properties.Resources.database__1_;
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Text = "";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // radRibbonBarGroup9
            // 
            this.radRibbonBarGroup9.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnSetting});
            this.radRibbonBarGroup9.Margin = new System.Windows.Forms.Padding(0);
            this.radRibbonBarGroup9.MaxSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup9.MinSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup9.Name = "radRibbonBarGroup9";
            this.radRibbonBarGroup9.Text = "کاربران";
            // 
            // btnSetting
            // 
            this.btnSetting.Image = global::ShopCenter.Properties.Resources.settings__1_;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Text = "";
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // radButtonElement11
            // 
            this.radButtonElement11.Name = "radButtonElement11";
            this.radButtonElement11.StretchHorizontally = false;
            this.radButtonElement11.StretchVertically = false;
            this.radButtonElement11.Text = "سیستم مدیریت فروشگاه ";
            // 
            // radMenuSeparatorItem1
            // 
            this.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 420);
            this.Controls.Add(this.ribbonClientPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ThemeName = "Windows8";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ribbonClientPanel1.ResumeLayout(false);
            this.ribbonClientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel1;
        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
        private Telerik.WinControls.UI.RadButtonElement btnCustomer;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup2;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement2;
        private Telerik.WinControls.UI.RadButtonElement btnProduct;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup3;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement3;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement4;
        private Telerik.WinControls.UI.RadButtonElement btnStore;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup10;
        private Telerik.WinControls.UI.RadButtonElement btnOrders;
        private Telerik.WinControls.UI.RibbonTab ribbonTab2;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup4;
        private Telerik.WinControls.UI.RadButtonElement btnStorReport;
        private Telerik.WinControls.UI.RadButtonElement btnStoreIn;
        private Telerik.WinControls.UI.RadButtonElement btnStoreOutReport;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup5;
        private Telerik.WinControls.UI.RadButtonElement btnCustomerReport;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup6;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement7;
        private Telerik.WinControls.UI.RadButtonElement btnFactors;
        private Telerik.WinControls.UI.RibbonTab ribbonTab3;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup7;
        private Telerik.WinControls.UI.RadButtonElement btnBackUp;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup8;
        private Telerik.WinControls.UI.RadButtonElement btnRestore;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup9;
        private Telerik.WinControls.UI.RadButtonElement btnSetting;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement11;
        private Telerik.WinControls.UI.RadRibbonBarGroup ProductReprot;
        private Telerik.WinControls.UI.RadButtonElement btnProductReportn;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup11;
        private Telerik.WinControls.UI.RadButtonElement btnExit;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;

    }
}