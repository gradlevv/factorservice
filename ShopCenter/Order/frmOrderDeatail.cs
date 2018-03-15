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


namespace ShopCenter.Order
{
    public partial class frmOrderDeatail : RadForm
    {
        public frmOrderDeatail()
        {
            InitializeComponent();
        }

        Modal.Db_ShopOrderEntities Mydb = new Modal.Db_ShopOrderEntities();
        public int Idorder = 0;

        private void frmOrderDeatail_Load(object sender, EventArgs e)
        {
            if (Idorder != 0)
            {
                var QOrderDeatail = (from O in Mydb.tbl_OrderDeatail where O.OrderID == Idorder select new {O.OrderID,O.tbl_Product.ProductName,O.Count,O.Price,O.PriceAll }).ToList();
                dgvDeatail.DataSource = QOrderDeatail;
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
    }
}
