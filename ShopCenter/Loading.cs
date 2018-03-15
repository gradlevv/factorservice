using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopCenter
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // string Msg = "به نرم افزار مدیریت فروشگاه خوش آمدید"+"نسخه 1.0.0";
           // int Step = 0;
           // label1.Text = Msg.Substring(0, Step);
            progressBarX1.PerformStep();
            progressBarX1.Increment(2);
            if (progressBarX1.Value == progressBarX1.Maximum)
            {
                timer1.Stop();
                this.Close();
            }
        }
    }
}
