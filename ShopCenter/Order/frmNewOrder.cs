using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopCenter.Modal;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using System.Globalization;


namespace ShopCenter.Order
{
    public partial class frmNewOrder : RadForm
    {
        public frmNewOrder()
        {
            InitializeComponent();
        }

        Modal.Db_ShopOrderEntities Mydb = new Modal.Db_ShopOrderEntities();
        PersianCalendar PC = new PersianCalendar();
        public  int IdOrder = 0;


        private void frmNewOrder_Load(object sender, EventArgs e)
        {
            if (IdOrder == 0)
            {
                
                txtDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
                cmbProduct.DataSource = Mydb.tbl_Product.ToList();
                cmbCustomer.DataSource = Mydb.tbl_Customer.ToList();
            }
            else
            {
                btnAdd.Text = "ویرایش";
                cmbProduct.DataSource = Mydb.tbl_Product.ToList();
                cmbCustomer.DataSource = Mydb.tbl_Customer.ToList();
                Edit();
            }

        }

        private void btnLoadProduct_Click_1(object sender, EventArgs e)
        {
            frmProductList list = new frmProductList();
            if (list.ShowDialog() == DialogResult.OK)
            {
                cmbProduct.SelectedValue = list.Productid;
                cmbProduct.Text = list.Productname;
            }
        }

        private void btnBarcode_Click_1(object sender, EventArgs e)
        {
            if (txtBarcode.Text.Trim() == "")
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("لطفا بارکد را وارد نمایید", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
            if (txtCount.Text.Trim() == "")
            {
                var ProductBarcode = int.Parse(txtBarcode.Text.Trim());
                var QSearchBarcode = (from P in Mydb.tbl_Product where P.Barcode == ProductBarcode select P).Any();
                if (QSearchBarcode == false)
                {
                    RadMessageBox.SetThemeName("Windows8");
                    RadMessageBox.Show("کالایی با این بارکد وجود ندارد", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
                    return;
                }
                else
                {
                    var Query = (from P in Mydb.tbl_Product where P.Barcode == ProductBarcode select P).FirstOrDefault();
                    dgvOrder.Rows.Add(Query.ProductID, Query.ProductName, 1, Query.Price);
                    SumOrderProduct();
                    SumAllOrder();
                    Kamkardan();
                    btnOk.Enabled = true;
                }
            }
            else
            {
                var ProductBarcode = int.Parse(txtBarcode.Text.Trim());
                var QSearchBarcode = (from P in Mydb.tbl_Product where P.Barcode == ProductBarcode select P).Any();
                if (QSearchBarcode == false)
                {
                    RadMessageBox.SetThemeName("Windows8");
                    RadMessageBox.Show("کالایی با این بارکد وجود ندارد", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
                    return;
                }
                else
                {
                    var Query = (from P in Mydb.tbl_Product where P.Barcode == ProductBarcode select P).First();
                    dgvOrder.Rows.Add(Query.ProductID, Query.ProductName, txtCount.Text.Trim(), Query.Price);
                    SumOrderProduct();
                    SumAllOrder();
                    Kamkardan();
                    btnOk.Enabled = true;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCount.Text.Trim() == "")
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("لطفا تعداد کالا را مشخص وارد نمایید", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
            if (CheckCount() == false)
            {
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("تعداد کالای وارد شده بیشتر از موجودی انبار میباشد", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
            int ProductID = (int)cmbProduct.SelectedValue;
            var Price = (from P in Mydb.tbl_Product where P.ProductID == ProductID select P.Price).FirstOrDefault();
            dgvOrder.Rows.Add(ProductID, cmbProduct.Text, txtCount.Text.Trim(), Price);
            SumOrderProduct();
            SumAllOrder();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (IdOrder == 0)
            {
                if (txtCount.Text.Trim() == "")
                    return;
                tbl_Order Order = new tbl_Order()
                {
                    CustomerID = int.Parse(cmbCustomer.SelectedValue.ToString()),
                    Date = DateTime.Now

                };
                Mydb.tbl_Order.Add(Order);
                Mydb.SaveChanges();

                foreach (var row in dgvOrder.Rows)
                {
                    Mydb.tbl_OrderDeatail.Add(new tbl_OrderDeatail()
                    {
                        OrderID = Order.OrderID,
                        ProductID = int.Parse(row.Cells[0].Value.ToString()),
                        Count = int.Parse(row.Cells[2].Value.ToString()),
                        Price = int.Parse(row.Cells[3].Value.ToString()),
                        PriceAll = int.Parse(row.Cells[4].Value.ToString())
                    });
                }

                Mydb.SaveChanges();
                Kamkardan();
                RadMessageBox.SetThemeName("Windows8");
                RadMessageBox.Show("فاکتور با موفقیت ثبت نهایی شد", "پیغام سیستم", MessageBoxButtons.OK, RadMessageIcon.Info);

                dgvOrder.Rows.Clear();
                dgvOrder.Refresh();
                DialogResult = DialogResult.OK;
            }
            else
            {
                (from u in Mydb.tbl_OrderDeatail where u.OrderID == IdOrder select u).ToList().ForEach(c => Mydb.tbl_OrderDeatail.Remove(c));
                foreach (var row in dgvOrder.Rows)
                {
                    Mydb.tbl_OrderDeatail.Add(new tbl_OrderDeatail()
                    {
                        OrderID = IdOrder,
                        ProductID = int.Parse(row.Cells[0].Value.ToString()),
                        Count = int.Parse(row.Cells[2].Value.ToString()),
                        Price = int.Parse(row.Cells[3].Value.ToString()),
                        PriceAll = int.Parse(row.Cells[4].Value.ToString())
                    });
                }
                Mydb.SaveChanges();
                Kamkardan();
                DialogResult = DialogResult.OK;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintFactor();
        }

        private void frmNewOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
            {
                foreach (var row in dgvOrder.Rows)
                {
                    int productId = int.Parse(row.Cells[0].Value.ToString());
                    int Mojod = (from u in Mydb.tbl_Product where u.ProductID == productId select u.Count).FirstOrDefault();
                    int OrderCount = int.Parse(row.Cells[2].Value.ToString());

                    var Update = (from u in Mydb.tbl_Product where u.ProductID == productId select u).FirstOrDefault();
                    Update.Count = Mojod + OrderCount;
                    Mydb.SaveChanges();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string ProductName = cmbProduct.Text;
            var QProductCount = Mydb.tbl_Product.Where(c => c.ProductName == ProductName).Select(c => new { c.Count }).FirstOrDefault();
            lblCount.Text = QProductCount.Count.ToString();
        }
        //--------------------------methodes--------------------------//
        //------------------------------------------------------------//
        private void SumOrderProduct()
        {
            try
            {
                foreach (var row in dgvOrder.Rows)
                {
                    int Count = int.Parse(row.Cells[2].Value.ToString());
                    int Price = int.Parse(row.Cells[3].Value.ToString());
                    row.Cells[4].Value = (Count * Price).ToString();
                }
            }
            catch
            {

            }
        }

        private void SumAllOrder()
        {
            try
            {
                float Sum = dgvOrder.Rows.Select(row => float.Parse(row.Cells[4].Value.ToString())).Aggregate<float, float>(0, (current, price) => current + price);
                txtPriceAll.Text = Sum.ToString();

            }
            catch
            {


            }
        }

        private void Kamkardan()
        {
            foreach (var row in dgvOrder.Rows)
            {
                int productId = int.Parse(row.Cells[0].Value.ToString());
                int Mojod = (from u in Mydb.tbl_Product where u.ProductID == productId select u.Count).FirstOrDefault();
                int OrderCount = int.Parse(row.Cells[2].Value.ToString());

                var Update = (from u in Mydb.tbl_Product where u.ProductID == productId select u).FirstOrDefault();
                Update.Count = Mojod - OrderCount;
                Mydb.SaveChanges();
            }

        }

        private void PrintFactor()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CustomerName");
            dt.Columns.Add("Date");
            dt.Columns.Add("ProductName");
            dt.Columns.Add("ProductCount");
            dt.Columns.Add("ProductPrice");
            dt.Columns.Add("ProductPriceAll");
            dt.Columns.Add("OrderAll");
            foreach (var row in dgvOrder.Rows)
            {
                dt.Rows.Add(cmbCustomer.Text, txtDate.Text, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value, txtPriceAll.Text.Trim());
            }
            stiReport1.RegData("dt", dt);
            stiReport1.Show();
        }

        private void Edit()
        {
            var edit = (from o in Mydb.tbl_OrderDeatail where o.OrderID == IdOrder select o).FirstOrDefault();
            cmbCustomer.SelectedValue = edit.tbl_Order.CustomerID;
            txtDate.Text = edit.tbl_Order.Date.ToString("yyyy/MM/dd");
            var od = (from o in Mydb.tbl_OrderDeatail where o.OrderID == IdOrder select o).ToList();
            foreach (var row in od)
            {
                dgvOrder.Rows.Add(row.ProductID, row.tbl_Product.ProductName, row.Count, row.Price, row.PriceAll);

            }
            SumAllOrder();
        }

        private bool CheckCount()
        {
            try
            {
                string ProductName = cmbProduct.Text;
                if (int.Parse(lblCount.Text) < int.Parse(txtCount.Text.Trim()))
                    return false;
                else
                    return true;
            }
            catch
            {
               return false;
            }
        }

    }
}
