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
    public partial class frmLogin : RadForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        Modal.Db_ShopOrderEntities Mydb = new Modal.Db_ShopOrderEntities();
        

        private void frmLogin_Load(object sender, EventArgs e)
        {

            var RegisterAdmin = (from R in Mydb.tbl_Register select R.Reg ).Single();
            if (RegisterAdmin== false)
            {
                new frmFLogin().ShowDialog();
            }

            new Loading().ShowDialog();
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var QLogin =(from U in Mydb.tbl_User where U.UserName== txtUsername.Text.Trim() && U.Password==txtPassword.Text.Trim() select U ).Any();

            if(txtUsername.Text.Trim()=="" || txtPassword.Text.Trim()=="")
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("لطفا تمام مقادیر خواسته شده را وارد نمایید","خطا",MessageBoxButtons.OK,RadMessageIcon.Error);
                return ;
                
            }
            if (QLogin)
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("ورود با موفقیت انجام شد", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Info);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("نام کاربری یا کلمه عبور اشتباه است", "خطا", MessageBoxButtons.OK, RadMessageIcon.Error);
                return ;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
