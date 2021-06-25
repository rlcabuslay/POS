using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class checkout : Form
    {
        String history = "history.csv";
        string order_id;
        DataTable orderCheckout;

        public checkout(DataTable dt, string total, string cash, string order_id)
        {
            InitializeComponent();
            orderCheckout = dt;
            orderTableCheckout.DataSource = dt;
            cashCheckout.Text = cash;
            totalCheckout.Text = total;
            double change = Convert.ToDouble(cash) - Convert.ToDouble(total);
            changeCheckout.Text = change.ToString("F");
            this.order_id = order_id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirm_checkout_Click(object sender, EventArgs e)
        {
            if (!File.Exists(history))
            {
                string orderHeader = "ID" + "," + "Name" + "," + "Date" + "," + "Qty" + "," + "Class" + "," + "Item" + "," + "Item Price" + "," + "Total Price" + Environment.NewLine;

                File.WriteAllText(history, orderHeader);
            }

            foreach (DataRow row in orderCheckout.Rows)
            {
                string orderDetails = this.order_id + "," + customerName.Text + "," + DateTime.Now.ToString() + "," + row["Qty"].ToString() + ","  + row["Class"].ToString() + "," + row["Item"].ToString() + "," + row["Price"].ToString() + "," + totalCheckout.Text + Environment.NewLine;
                File.AppendAllText(history, orderDetails);
            }

            this.Close();

        }
    }
}
