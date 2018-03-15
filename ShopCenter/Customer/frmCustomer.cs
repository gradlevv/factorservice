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

namespace ShopCenter.Customer
{
    public partial class frmCustomer : RadForm
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        Modal.Db_ShopOrderEntities Mydb = new Modal.Db_ShopOrderEntities();

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = (from c in Mydb.tbl_Customer select c).ToList();
        }

        private void commandBarButton1_Click(object sender, EventArgs e)
        {
            if (new frmAddCustomer().ShowDialog() == DialogResult.OK)
                frmCustomer_Load(null, null);

        }

        private void commandBarButton2_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.CurrentRow != null)
            {
                int CustomerId = int.Parse(dgvCustomer.CurrentRow.Cells[0].Value.ToString());
                if (new frmAddCustomer() { IdCustomer = CustomerId }.ShowDialog() == DialogResult.OK)
                    frmCustomer_Load(null, null);
            }
            else
                return;
        }

        private void commandBarButton3_Click(object sender, EventArgs e)
        {
            

            if(dgvCustomer.CurrentRow ==null)
                return ;
            if (dgvCustomer.CurrentRow != null)
            {
                int CustomerId = int.Parse(dgvCustomer.CurrentRow.Cells[0].Value.ToString());
                RadMessageBox.SetThemeName("Windows8");
                DialogResult dr =RadMessageBox.Show("آیا میخاهید مقدار انتخاب شده را حذف نمایید؟","پیغام سیستم",MessageBoxButtons.YesNo,RadMessageIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    //(from O in Mydb.tbl_Order where O.CustomerID == CustomerId select O).ToList().ForEach(c => Mydb.tbl_Order.Remove(c));
                    var QSearchcustomer = Mydb.tbl_Order.Where(c => c.CustomerID == CustomerId).Any();
                    if (QSearchcustomer)
                    {
                        RadMessageBox.SetThemeName("Windows8");
                        RadMessageBox.Show("برای حذف مشتری ابتدا لیست سفارشات مشتری را حذف نمایید!", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
                        return;
                    }
                    else
                    {
                        //var QDeletOrder = (from O in Mydb.tbl_Order where O.CustomerID == CustomerId select O).ToList();
                        //foreach (var item in QDeletOrder)
                        //{
                        //    if (item != null)
                        //        Mydb.tbl_Order.Remove(item);
                        //}
                        var QDeleteCustomer = (from C in Mydb.tbl_Customer where C.CustomerID == CustomerId select C).First();
                        Mydb.tbl_Customer.Remove(QDeleteCustomer);
                        Mydb.SaveChanges();
                        frmCustomer_Load(null, null);
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
