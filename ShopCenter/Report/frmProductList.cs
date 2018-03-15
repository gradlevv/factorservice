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
    public partial class frmProductList : RadForm
    {
        public frmProductList()
        {
            InitializeComponent();
        }

        Modal.Db_ShopOrderEntities MyDb = new Modal.Db_ShopOrderEntities();
        DataTable Dt;

        private void frmProductList_Load(object sender, EventArgs e)
        {
            dgvPStor.DataSource = MyDb.tbl_Product.Select(c => new { c.ProductID, c.ProductName, c.Barcode, c.Count, c.Price, c.Note }).ToList();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Dt = new DataTable();
            Dt.Columns.Add("ProductName");
            Dt.Columns.Add("Barcode");
            Dt.Columns.Add("Count");
            Dt.Columns.Add("Price");
            Dt.Columns.Add("Note");

            foreach (var row in dgvPStor.Rows)
            {
                Dt.Rows.Add(row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value,row.Cells[5].Value);
            }

            stiReport1.RegData("dt",Dt);
            stiReport1.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
