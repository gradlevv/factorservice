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
    public partial class frmRestore : RadForm
    {
        public frmRestore()
        {
            InitializeComponent();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();
            OP.Title = "Open...";
            OP.Filter = "Bak Files (*.bak) |*.bak";
            if (OP.ShowDialog() == DialogResult.OK)
                txtPath.Text = OP.FileName;
            
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (txtPath.Text.Trim() == "")
                return;
            if (Methods.Backup(txtPath.Text.Trim()))
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("بازیابی با موفقیت انجام شد", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Info);
                txtPath.Clear();
            }
            else
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("خطا در بازیابی", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
