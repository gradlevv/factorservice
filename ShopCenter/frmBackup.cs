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
    public partial class frmBackup : RadForm
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            SaveFileDialog Sv = new SaveFileDialog();
            Sv.Title = "Saving...";
            Sv.Filter="BAK files (*.bak)|*.bak";
            if (Sv.ShowDialog() == DialogResult.OK)
                txtPath.Text = Sv.FileName;
            
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (txtPath.Text.Trim() == "")
                return;
            if (Methods.Backup(txtPath.Text.Trim()))
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("پشتیبان گیری با موفقیت انجام شد", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Info);
                txtPath.Clear();
            }
            else
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("خطا در پشتیبان گیری", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
