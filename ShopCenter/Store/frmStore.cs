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
    public partial class frmStore : RadForm
    {
        public frmStore()
        {
            InitializeComponent();
        }

        Modal.Db_ShopOrderEntities Mydb = new Modal.Db_ShopOrderEntities();

        private void frmStore_Load(object sender, EventArgs e)
        {
            dgvStore.DataSource = Mydb.tbl_Product.ToList();
        }

        private void dgvStore_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (dgvStore.CurrentRow != null)
            {
                int ProID =(int)dgvStore.CurrentRow.Cells[0].Value;
                if (new frmNewStore() { Productid = ProID }.ShowDialog() == DialogResult.OK)
                    frmStore_Load(null, null);
            }
        }

        private void btnNewStor_Click(object sender, EventArgs e)
        {
            if (dgvStore.CurrentRow != null)
            {
                int ProID = (int)dgvStore.CurrentRow.Cells[0].Value;
                if (new frmNewStore() { Productid = ProID }.ShowDialog() == DialogResult.OK)
                    frmStore_Load(null, null);
            }
        }

        private void btnProductIn_Click(object sender, EventArgs e)
        {
            new Store.frmProductStor().ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void dgvStore_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (dgvStore.CurrentRow != null)
                btnNewStor.Enabled = true;
        }
    }
}
