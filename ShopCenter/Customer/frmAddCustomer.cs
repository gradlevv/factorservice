using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using ShopCenter.Modal;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace ShopCenter.Customer
{
    public partial class frmAddCustomer : RadForm
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        Modal.Db_ShopOrderEntities Mydb = new Modal.Db_ShopOrderEntities();
        public int IdCustomer = 0;

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            if (IdCustomer != 0)
            {
                btnAdd.Text = "ویرایش";
                var Query = (from C in Mydb.tbl_Customer where C.CustomerID == IdCustomer select C).First();
                txtName.Text = Query.Name;
                txtFamily.Text = Query.Family;
                txtMobile.Text = Query.Mobile;
                txtAddress.Text = Query.Adress;
                txtDesc.Text = Query.Note;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbl_Customer Cs = new tbl_Customer();
            if (IdCustomer == 0)
            {
                if (txtName.Text.Trim() == "" || txtFamily.Text.Trim() == "" || txtMobile.Text.Trim() == "" || txtAddress.Text.Trim() == "" || txtDesc.Text.Trim() == "")
                {
                    RadMessageBox.SetThemeName("Windows8");
                    RadMessageBox.Show("لطفا تمام مقادیر خواسته شده را تکمیل نمایید", "خطا", MessageBoxButtons.OK, RadMessageIcon.Error);
                    return;
                }

                Mydb.tbl_Customer.Add(new tbl_Customer()
                {
                    Name = txtName.Text.Trim(),
                    Family = txtFamily.Text.Trim(),
                    Fullname = txtName.Text.Trim() + " " + txtFamily.Text.Trim(),
                    Mobile = txtMobile.Text.Trim(),
                    Adress = txtAddress.Text.Trim(),
                    Note = txtDesc.Text.Trim()

                });
                Mydb.SaveChanges();
                DialogResult = DialogResult.OK;

            }

            else
            {

                var QEdit = (from C in Mydb.tbl_Customer where C.CustomerID == IdCustomer select C).First();
                QEdit.Name = txtName.Text.Trim();
                QEdit.Family = txtFamily.Text.Trim();
                QEdit.Mobile = txtMobile.Text.Trim();
                QEdit.Adress = txtAddress.Text.Trim();
                QEdit.Note = txtDesc.Text.Trim();
                if (txtName.Text.Trim() == "" || txtFamily.Text.Trim() == "" || txtMobile.Text.Trim() == "" || txtAddress.Text.Trim() == "" || txtDesc.Text.Trim() == "")
                {
                    RadMessageBox.SetThemeName("Windows8");
                    RadMessageBox.Show("لطفا تمام مقادیر خواسته شده را تکمیل نمایید", "خطا", MessageBoxButtons.OK, RadMessageIcon.Error);
                    return;
                }
                Mydb.SaveChanges();
                DialogResult = DialogResult.OK;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


    }
}
