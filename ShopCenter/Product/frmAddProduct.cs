using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace ShopCenter.Product
{
    public partial class frmAddProduct : RadForm
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }

        Modal.Db_ShopOrderEntities Mydb = new Modal.Db_ShopOrderEntities();
        public int Proid = 0;

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            if (Proid != 0)
            {
                var Product = (from P in Mydb.tbl_Product where P.ProductID == Proid select P).First();
                txtProductname.Text = Product.ProductName;
                txtBarcode.Text = Product.Barcode.ToString();
                txtCount.Text = Product.Count.ToString();
                txtPrice.Text = Product.Price.ToString();
                txtNote.Text = Product.Note;
            }
        }


        private void btnBarcode_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int Random = rnd.Next(1, 999999);
            txtBarcode.Text = Random.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Proid == 0)
            {
                if (txtBarcode.Text.Trim() == "" || txtProductname.Text.Trim() == "" || txtCount.Text.Trim() == "" || txtPrice.Text.Trim() == "" || txtNote.Text.Trim() == "")
                {
                    RadMessageBox.SetThemeName("Windows8");
                    RadMessageBox.Show("لطفا تمام مقادیر خواسته شده را وارد نمایید", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
                    return;
                }
                Mydb.tbl_Product.Add(new ShopCenter.Modal.tbl_Product()
                {
                    Barcode = int.Parse(txtBarcode.Text.Trim()),
                    ProductName = txtProductname.Text.Trim(),
                    Count = int.Parse(txtCount.Text.Trim()),
                    Price = int.Parse(txtPrice.Text.Trim()),
                    Note = txtNote.Text.Trim()
                });

                Mydb.SaveChanges();
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("عملیات با موفقیت انجام شد", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Info);
                DialogResult = DialogResult.OK;
            }
            else
            {
                var Product = (from P in Mydb.tbl_Product where P.ProductID == Proid select P).First();
                Product.ProductName = txtProductname.Text;
                Product.Barcode = int.Parse(txtBarcode.Text.Trim());
                Product.Count = int.Parse(txtCount.Text.Trim());
                Product.Price = int.Parse(txtPrice.Text.Trim());
                Product.Note = txtNote.Text;
                if (txtBarcode.Text.Trim() == "" || txtProductname.Text.Trim() == "" || txtCount.Text.Trim() == "" || txtPrice.Text.Trim() == "" || txtNote.Text.Trim() == "")
                {
                    RadMessageBox.SetThemeName("Windows8");
                    RadMessageBox.Show("لطفا تمام مقادیر خواسته شده را وارد نمایید", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
                    return;
                }
                Mydb.SaveChanges();
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("عملیات با موفقیت انجام شد", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Info);
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


    }
}
