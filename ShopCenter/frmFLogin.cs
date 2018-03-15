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
    public partial class frmFLogin : RadForm
    {
        public frmFLogin()
        {
            InitializeComponent();
        }

        Modal.Db_ShopOrderEntities Mydb = new Modal.Db_ShopOrderEntities();
        public int EditAdmin = 0;

        private void frmFLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "" || txtCPassword.Text.Trim() == "")
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("لطفا تمام مقادیر خواسته شده را وارد نمایید", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
            if (txtPassword.Text.Trim() != txtCPassword.Text.Trim())
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("فیلدهای کلمه عبور با هم برابر نیستند", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
            else
            {
                var QAddAdmin = Mydb.tbl_User.Add(new Modal.tbl_User()
                {
                    UserName = txtUsername.Text.Trim(),
                    Password = txtPassword.Text.Trim()
                });
                Mydb.SaveChanges();
                new Methods().UpdateRegister();
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("مدیر با موفقیت اضافه شد", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Info);

                Application.Restart();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
