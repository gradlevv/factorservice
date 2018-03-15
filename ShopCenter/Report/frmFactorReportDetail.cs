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
    public partial class frmFactorReportDetail : RadForm
    {
        public frmFactorReportDetail()
        {
            InitializeComponent();
        }

        Modal.Db_ShopOrderEntities MyDb = new Modal.Db_ShopOrderEntities();
        public int OrderId = 0;
        DataTable dt;

        private void frmFactorReportDetail_Load(object sender, EventArgs e)
        {
            if (OrderId != 0)
            {
                var QOrderDetail = MyDb.tbl_OrderDeatail.Where(c => c.OrderID == OrderId).Select(c => new { c.tbl_Product.ProductName, c.Count, c.Price, c.PriceAll }).ToList();
                var QCustomerFName=MyDb.tbl_OrderDeatail.Where(c => c.OrderID == OrderId).Select(c=> new {c.tbl_Order.tbl_Customer.Fullname}).FirstOrDefault();
                lblFullname.Text = QCustomerFName.Fullname;
                dgvDeatail.DataSource = QOrderDetail;
                SumAllOrder();
            }
        }

        private void SumAllOrder()
        {
            try
            {
                float Sum = dgvDeatail.Rows.Select(row => float.Parse(row.Cells[3].Value.ToString())).Aggregate<float, float>(0, (current, price) => current + price);
                txtPriceAll.Text = Sum.ToString();

            }
            catch
            {


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("ProductName");
            dt.Columns.Add("Count");
            dt.Columns.Add("Price");
            dt.Columns.Add("PriceAll");
            dt.Columns.Add("AllPrice");
            dt.Columns.Add("Fullname");

            foreach(var row in dgvDeatail.Rows)
            {
                dt.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, txtPriceAll.Text,lblFullname.Text);
            }
            stiReport1.RegData("dt",dt);
            stiReport1.Show();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
