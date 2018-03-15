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

namespace ShopCenter.Report
{
    public partial class frmFactorReport : RadForm
    {
        public frmFactorReport()
        {
            InitializeComponent();
        }

        Modal.Db_ShopOrderEntities MyDb = new Modal.Db_ShopOrderEntities();


        private void frmFactorReport_Load(object sender, EventArgs e)
        {
            dgvOrder.DataSource = MyDb.tbl_Order.OrderByDescending(c => c.Date).Select(c => new { c.OrderID,c.tbl_Customer.Fullname,c.Date }).ToList();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dgvOrder.CurrentRow == null)
                btnShow.Enabled = false;
            if (dgvOrder.CurrentRow != null)
            {
                int OrderID = int.Parse(dgvOrder.CurrentRow.Cells[0].Value.ToString());
                new frmFactorReportDetail(){OrderId= OrderID }.ShowDialog();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
