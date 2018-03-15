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

namespace ShopCenter.Store
{
    public partial class frmProductStor : RadForm
    {
        public frmProductStor()
        {
            InitializeComponent();
        }

        Modal.Db_ShopOrderEntities Mydb = new Modal.Db_ShopOrderEntities();

        private void frmProductStor_Load(object sender, EventArgs e)
        {
            dgvPStor.DataSource = (from S in Mydb.tbl_Store orderby S.Date descending select new {Proname=S.tbl_Product.ProductName,S.Count,S.Date }).ToList();
        }
    }
}
