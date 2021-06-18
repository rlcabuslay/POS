using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class checkout : Form
    {
        public checkout(DataTable dt, string total, string cash)
        {
            InitializeComponent();
            orderTableCheckout.DataSource = dt;
            cashCheckout.Text = cash;
            totalCheckout.Text = total;
            double change = Convert.ToDouble(cash) - Convert.ToDouble(total);
            changeCheckout.Text = change.ToString("F");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
