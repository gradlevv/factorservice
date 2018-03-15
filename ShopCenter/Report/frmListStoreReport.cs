using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace ShopCenter.Report
{
    public partial class frmListStoreReport : RadForm
    {
        public frmListStoreReport()
        {
            InitializeComponent();
        }

        Modal.Db_ShopOrderEntities Mydb = new Modal.Db_ShopOrderEntities();
        DataTable dt;
        string Start,End;
        
     
        private void frmListStoreReport_Load(object sender, EventArgs e)
        {
            cmbDay1.SelectedIndex = 1;
            cmbDay2.SelectedIndex = 1;
            cmbMounth1.SelectedIndex = 1;
            cmbMounth2.SelectedIndex = 1;

            txtYear1.Text = DateTime.Now.Year.ToString();
            txtYear2.Text = DateTime.Now.Year.ToString();

            dgvPStor.DataSource = Mydb.tbl_Store.Select(c=>new {c.tbl_Product.ProductName, c.Count, c.Date }).ToList();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Start = cmbMounth1.Text + "/" + cmbDay1.Text + "/" + txtYear1.Text.Trim();
            End = cmbMounth2.Text + "/" + cmbDay2.Text + "/" + txtYear2.Text.Trim();
            DateTime StartDAy = Convert.ToDateTime(Start);
            DateTime EndDay = Convert.ToDateTime(End);

            var QSearchDate = Mydb.tbl_Store.Where(c => c.Date >= StartDAy && c.Date <= EndDay).Any();
            if (QSearchDate)
            {

                dt = new DataTable();
                dt.Columns.Add("ProductName");
                dt.Columns.Add("Count");
                dt.Columns.Add("Date");

                foreach (var row in dgvPStor.Rows)
                {
                    dt.Rows.Add(row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value);
                }
                stiReport1.RegData("dt", dt);
                stiReport1.Show();
            }
            else
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("مقداری برای نمایش وجود ندارد","پیغام سیستم",MessageBoxButtons.OK,RadMessageIcon.Info);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            Start = cmbMounth1.Text + "/" + cmbDay1.Text + "/" + txtYear1.Text.Trim();
            End = cmbMounth2.Text + "/" + cmbDay2.Text + "/" + txtYear2.Text.Trim();

            if (int.Parse(cmbMounth1.Text) > int.Parse(cmbMounth2.Text))
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("بازه جستجو اشتباه است", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
            if (int.Parse(cmbMounth1.Text)==int.Parse(cmbMounth2.Text) && int.Parse(cmbDay1.Text)> int.Parse(cmbDay2.Text))
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("بازه جستجو اشتباه است", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
            
            DateTime StartDAy = Convert.ToDateTime(Start);
            DateTime EndDay = Convert.ToDateTime(End);

            var QSearchDate = Mydb.tbl_Store.Where(c => c.Date >= StartDAy && c.Date <= EndDay).Select(c => new {c.tbl_Product.ProductName,c.Count,c.Date }).ToList();
            dgvPStor.DataSource = QSearchDate;
            btnPrint.Enabled = true;
        }

    }
}
