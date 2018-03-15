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
    public partial class frmProductList : RadForm
    {
        public frmProductList()
        {
            InitializeComponent();
        }

        Modal.Db_ShopOrderEntities Mydb = new Modal.Db_ShopOrderEntities();
        public int Productid { get; set; }
        public string Productname { get; set; }

        private void frmProductList_Load(object sender, EventArgs e)
        {
            dgvProductList.DataSource = Mydb.tbl_Product.ToList();
        }

        private void dgvProductList_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (dgvProductList.CurrentRow != null)
            {
                Productid =int.Parse(dgvProductList.CurrentRow.Cells[0].Value.ToString());
                Productname = dgvProductList.CurrentRow.Cells[1].Value.ToString();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
