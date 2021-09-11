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
        DataGridView orderTable;
        DataGridView menuTable;
        string coffeeshopInventory;

        public checkout(DataTable dt, string total, string cash, string order_id, DataGridView mt, DataGridView ot, string ci)
        {
            InitializeComponent();
            orderCheckout = dt;
            orderTableCheckout.DataSource = dt;
            orderTableCheckout.Columns["Cost"].Visible = false;
            cashCheckout.Text = cash;
            totalCheckout.Text = total;
            orderTable = ot;
            menuTable = mt;
            coffeeshopInventory = ci;

            double change = Convert.ToDouble(cash) - Convert.ToDouble(total);
            changeCheckout.Text = change.ToString("F");
            this.order_id = order_id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void decreaseQuantity()
        {
            foreach (DataGridViewRow rowOrder in orderTable.Rows)
            {
                foreach (DataGridViewRow rowMenu in menuTable.Rows)
                {
                    if (rowOrder.Cells["Class"].Value.ToString() == rowMenu.Cells["Class"].Value.ToString() && rowOrder.Cells["Item"].Value.ToString() == rowMenu.Cells["Item"].Value.ToString() && rowOrder.Cells["Price"].Value.ToString() == rowMenu.Cells["Price"].Value.ToString())
                    {
                        rowMenu.Cells["Qty"].Value = Convert.ToInt32(rowMenu.Cells["Qty"].Value) - Convert.ToInt32(rowOrder.Cells["Qty"].Value);
                    }
                }
            }

            File.WriteAllLines(coffeeshopInventory, menuTable.ToDelimitedWithHeaders().ToList());
        }

        private void confirm_checkout_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(history))
                {
                    string orderHeader = "ID" + "," + "Name" + "," + "Date" + "," + "Class" + "," + "Item" + "," + "Qty" + "," + "Item Price" + "," + "Total Order" + "," + "Item Cost" + Environment.NewLine;

                    File.WriteAllText(history, orderHeader);
                }

                foreach (DataRow row in orderCheckout.Rows)
                {
                    string orderDetails = this.order_id + "," + customerName.Text + "," + DateTime.Now.ToString("MM/dd/yyyy h:mm tt") + "," + row["Class"].ToString() + "," + row["Item"].ToString() + "," + row["Qty"].ToString() + "," + (Convert.ToDecimal(row["Qty"]) * Convert.ToDecimal(row["Price"])).ToString() + "," + totalCheckout.Text + "," + (Convert.ToDecimal(row["Qty"]) * Convert.ToDecimal(row["Cost"])).ToString() + Environment.NewLine;
                    File.AppendAllText(history, orderDetails);
                }

                decreaseQuantity();

                this.Close();
            }
            catch
            {
                DialogResult dr = MessageBox.Show("Please close history.csv spreadsheet file.", "File is Open", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
