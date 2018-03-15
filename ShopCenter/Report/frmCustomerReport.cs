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
    public partial class frmCustomerReport : RadForm
    {
        public frmCustomerReport()
        {
            InitializeComponent();
        }

        Modal.Db_ShopOrderEntities Mydb =new Modal.Db_ShopOrderEntities();
        DataTable dt;

        private void frmCustomerReport_Load(object sender, EventArgs e)
        {
            dgvCustomerList.DataSource = Mydb.tbl_Customer.ToList();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("CustomerID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Family");
            dt.Columns.Add("Fullname");
            dt.Columns.Add("Mobile");
            dt.Columns.Add("Adress");
            dt.Columns.Add("Note");
            foreach (var row in dgvCustomerList.Rows)
            {
                dt.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value, row.Cells[5].Value);
            }
            stiReport1.RegData("dt", dt);
            stiReport1.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


    }
}
