using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace ShopCenter
{
    class Methods
    {
        Modal.Db_ShopOrderEntities Mydb = new Modal.Db_ShopOrderEntities();

        static SqlCommand Cmd = new SqlCommand();
        static SqlConnection Con = new SqlConnection();

        private static void Connect()
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                    Con.Open();
            }
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.ToString());
            }
        }

        private static void DC()
        {
            try
            {
                if (Con.State == ConnectionState.Open)
                    Con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private static void MakeConnection()
        {
            try
            {
                Con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Db_ShopOrder.mdf;integrated security=True;connect timeout=30;";
                Cmd.Connection = Con;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        public static bool Backup(string Path)
        {
            try
            {
                Cmd.CommandText = @"USE MASTER BACKUP DATABASE [" + Application.StartupPath + @"\Db_ShopOrder.mdf] TO DISK = '" + Path + "' WITH NOFORMAT, NOINIT, NAME = 'Db_ShopOrder-Full Database Backup', SKIP, NOREWIND, NOUNLOAD, STATS = 10";
                MakeConnection();
                Connect();
                Cmd.ExecuteNonQuery();
                DC();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public static bool Restore(string Path)
        {
            try
            {
                Cmd.CommandText = "ALTER DATABASE [" + Application.StartupPath + @"\Db_ShopOrder.mdf] SET SINGLE_USER WITH ROLLBACK IMMEDIATE" + " USE master " + "RESTORE DATABASE [" + Application.StartupPath + @"\Db_ShopOrder.mdf] FROM DISK ='" + Path + "'WITH REPLACE ";
                MakeConnection();
                Connect();
                Cmd.ExecuteNonQuery();
                DC();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public void UpdateRegister()
        {
            try
            {
                var QUpdate = (from R in Mydb.tbl_Register select R).First();
                QUpdate.Reg = true;
                Mydb.SaveChanges();

            }
            catch 
            {
                MessageBox.Show("eror - update register");
                
            }
        }

        public static String MiladiToShamsi(DateTime dt)
        {
            StringBuilder sb = new StringBuilder();
            PersianCalendar pc = new PersianCalendar();
            sb.Append(pc.GetYear(dt).ToString("0000"));
            sb.Append("/");
            sb.Append(pc.GetMonth(dt).ToString("00"));
            sb.Append("/");
            sb.Append(pc.GetDayOfMonth(dt).ToString("00"));
            return sb.ToString();

        }
    }
}
