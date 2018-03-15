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
    public partial class frmProduct : RadForm
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        Modal.Db_ShopOrderEntities Mydb = new Modal.Db_ShopOrderEntities();

        private void frmProduct_Load(object sender, EventArgs e)
        {
            dgvProduct.DataSource = (from P in Mydb.tbl_Product select P).ToList();
        }

        private void commandBarButton1_Click(object sender, EventArgs e)
        {
            if (new frmAddProduct().ShowDialog() == DialogResult.OK)
                frmProduct_Load(null, null);
        }

        private void commandBarButton2_Click(object sender, EventArgs e)
        {
            if (dgvProduct.CurrentRow == null)
                return;
            if (dgvProduct.CurrentRow != null)
            {
                int ProID = (int)dgvProduct.CurrentRow.Cells[0].Value;

                if (new frmAddProduct() { Proid = ProID }.ShowDialog() == DialogResult.OK)
                    frmProduct_Load(null, null);
            }
        }

        private void commandBarButton3_Click(object sender, EventArgs e)
        {
            if (dgvProduct.CurrentRow == null)
                   return;
            if (dgvProduct.CurrentRow != null)
            {
                  int ProID = (int)dgvProduct.CurrentRow.Cells[0].Value;
                  RadMessageBox.SetThemeName("Windows8");
                  DialogResult dr = RadMessageBox.Show("آیا میخاهید مقدار انتخاب شده را حذف نمایید؟", "پیغام سیستم", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                  if (dr == DialogResult.Yes)
                  {
                      var QSearchProduct = Mydb.tbl_OrderDeatail.Where(c => c.ProductID == ProID).Any();
                      if (QSearchProduct)
                      {
                          RadMessageBox.SetThemeName("Windows8");
                          RadMessageBox.Show("برای حذف کالا ابتدا باید لیست سفارشاتی که کالا در آنها قرار دارد حذف شوند !", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Question);
                          return;
                      }
                      else
                      {
                          var delete = (from P in Mydb.tbl_Product where P.ProductID == ProID select P).First();
                          Mydb.tbl_Product.Remove(delete);
                          Mydb.SaveChanges();
                          frmProduct_Load(null, null);
                      }
                  }
            }
        }

        private void commandBarButton4_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
