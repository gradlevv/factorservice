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

namespace ShopCenter
{
    public partial class frmSetting : RadForm
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        Modal.Db_ShopOrderEntities Mydb = new Modal.Db_ShopOrderEntities();

        private void frmSetting_Load(object sender, EventArgs e)
        {
            var QUser = Mydb.tbl_User.Select(c => new { c.UserName }).FirstOrDefault();
            txtUsername.Text = QUser.UserName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == "" || txtNewpass.Text.Trim() == "")
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("لطفا تمام مقادیر خواسته شده را وارد نمایید", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
            var UpdatePassword = Mydb.tbl_User.Where(c => c.Password == txtPassword.Text.Trim()).FirstOrDefault();
            if (UpdatePassword != null)
            {
                UpdatePassword.Password = txtNewpass.Text.Trim();
                Mydb.SaveChanges();
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("کلمه عبور با موفقیت تغییر یافت", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Info);
                txtNewpass.Clear();
                txtPassword.Clear();
            }
            else
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("کلمه عبور اشتباه است", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
                txtNewpass.Clear();
                txtPassword.Clear();
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


    }
}
