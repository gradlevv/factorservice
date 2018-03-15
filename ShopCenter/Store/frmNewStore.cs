using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopCenter.Modal;
using Telerik.WinControls.UI;
using Telerik.WinControls;



namespace ShopCenter.Store
{
    public partial class frmNewStore : RadForm
    {
        public frmNewStore()
        {
            InitializeComponent();
        }

        Modal.Db_ShopOrderEntities Mydb = new Modal.Db_ShopOrderEntities();
        public int Productid = 0;

        private void frmNewStore_Load(object sender, EventArgs e)
        {
            if (Productid != 0)
            {
                var Product = (from P in Mydb.tbl_Product where P.ProductID == Productid select P).First();
                lblCount.Text =Product.Count.ToString();
                lblProductname.Text = Product.ProductName;
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (txtCount.Text.Trim() == "")
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("لطفا تعداد کالای ورودی را مشخص نمایید", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
            int mojudi = int.Parse(lblCount.Text);
            var Product = (from P in Mydb.tbl_Product where P.ProductID == Productid select P).First();
            Product.Count = int.Parse(txtCount.Text.Trim()) + mojudi;
            Mydb.SaveChanges();

            tbl_Store stor = new tbl_Store()
            {
                Count = int.Parse(txtCount.Text.Trim()),
                ProductID = Productid,
                Date = DateTime.Now

            };

            Mydb.tbl_Store.Add(stor);
            Mydb.SaveChanges();
            txtCount.Clear();
            RadMessageBox.SetThemeName("Windows8");
            RadMessageBox.Show("کالا با موفقیت به انبار اضافه شد", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Info);
            frmNewStore_Load(null, null);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}
