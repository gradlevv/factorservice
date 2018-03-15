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

namespace ShopCenter.Order
{
    public partial class frmOrder : RadForm
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        Modal.Db_ShopOrderEntities Mydb = new Modal.Db_ShopOrderEntities();
        

        private void commandBarButton1_Click(object sender, EventArgs e)
        {
            if (new frmNewOrder().ShowDialog() == DialogResult.OK)
            {
                frmOrder_Load(null, null);
            }
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            dgvOrder.DataSource = (from O in Mydb.tbl_Order
                                   orderby O.Date descending
                                   select new
                                   {
                                       O.OrderID,
                                       O.tbl_Customer.Fullname,
                                       O.Date
                                   }).ToList();
        }

        private void commandBarButton3_Click(object sender, EventArgs e)
        {
            if (dgvOrder.CurrentRow == null)
                return;
            if (dgvOrder.CurrentRow != null)
            {
                
                int OrderId = int.Parse(dgvOrder.CurrentRow.Cells[0].Value.ToString());
                RadMessageBox.SetThemeName("Windows8");
                DialogResult dr = RadMessageBox.Show("آیا میخاهید مقدار انتخاب شده را حذف نمایید ؟", "پیغام سیستم", MessageBoxButtons.YesNo, RadMessageIcon.Info);
                if (dr == DialogResult.Yes)
                {
                    (from U in Mydb.tbl_OrderDeatail where U.OrderID == OrderId select U).ToList().ForEach(c => Mydb.tbl_OrderDeatail.Remove(c));
                    var QDeleteOrder = Mydb.tbl_Order.Where(c => c.OrderID == OrderId).FirstOrDefault();
                    Mydb.tbl_Order.Remove(QDeleteOrder);
                    Mydb.SaveChanges();
                    frmOrder_Load(null, null);
                }
            }
        }

        private void commandBarButton2_Click(object sender, EventArgs e)
        {
            if (dgvOrder.CurrentRow == null)
                return;
            if (dgvOrder.CurrentRow != null)
            {
                int orderid = int.Parse(dgvOrder.CurrentRow.Cells[0].Value.ToString());
                if (new frmNewOrder() { IdOrder = orderid }.ShowDialog() == DialogResult.OK)
                    frmOrder_Load(null, null);
            }
        }

        private void dgvOrder_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int orderid = int.Parse(dgvOrder.CurrentRow.Cells[0].Value.ToString());
            if (new frmOrderDeatail() { Idorder = orderid }.ShowDialog() == DialogResult.OK)
                frmOrder_Load(null, null);
        }

        private void commandBarButton4_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
