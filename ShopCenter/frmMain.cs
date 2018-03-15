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
    public partial class frmMain : RadForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (new frmLogin().ShowDialog() != DialogResult.OK)
                this.Close();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            new Customer.frmCustomer().ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            new Product.frmProduct().ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            new frmSetting().ShowDialog();
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            new frmBackup().ShowDialog();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            new frmRestore().ShowDialog();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            new Store.frmStore().ShowDialog();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            new Order.frmOrder().ShowDialog();
        }

        private void btnCustomerReport_Click(object sender, EventArgs e)
        {
            new Report.frmCustomerReport().ShowDialog();
        }

        private void btnFactors_Click(object sender, EventArgs e)
        {
            new Report.frmFactorReport().ShowDialog();
        }

        private void btnProductReportn_Click(object sender, EventArgs e)
        {
            new Report.frmProductList().ShowDialog();
        }

        private void btnStorReport_Click(object sender, EventArgs e)
        {
            new Report.frmProductList().ShowDialog();
        }

        private void btnStoreIn_Click(object sender, EventArgs e)
        {
            new Report.frmListStoreReport().ShowDialog();
        }

        private void btnStoreOutReport_Click(object sender, EventArgs e)
        {
            new Report.frmOutStoreReport().ShowDialog();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            new Product.frmAddProduct().ShowDialog();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
             RadMessageBox.SetThemeName("Windows8");
             DialogResult dr =RadMessageBox.Show("آیا میخاهید از نرم افزار خارج شوید؟","پیغام سیستم",MessageBoxButtons.YesNo,RadMessageIcon.Question);

             if (dr == DialogResult.Yes)
             {
                 Application.Exit();
             }
             else
             {
                 return;
             }
        }


    }
}
