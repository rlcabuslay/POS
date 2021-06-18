using System;
using System.Collections;
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
    public partial class POS : Form
    {
        TableLayoutPanel activePanel;
        String currentInventory;
        String history = "history.csv";
        DataTable dt_cashier = new DataTable();

        public POS()
        {
            InitializeComponent();
            activePanel = menuPanel;
            currentInventory = "inventory_coffeeshop.csv";
            dt_cashier.Columns.Add("Qty");
            dt_cashier.Columns.Add("Class");
            dt_cashier.Columns.Add("Item");
            dt_cashier.Columns.Add("Price");
        }
        private void LoadData(string strFilePath)
        {
            DataTable dt_inventory = new DataTable();
            DataTable dt_order = new DataTable();
            dt_inventory.Clear();
            dt_order.Clear();
            string[] lines = System.IO.File.ReadAllLines(strFilePath);
            if (lines.Length > 0)
            {
                //Header
                string strfirstLine = lines[0];
                string[] headerLabels = strfirstLine.Split(',');
                foreach (string strheader in headerLabels)
                {
                    dt_inventory.Columns.Add(new DataColumn(strheader));
                    dt_order.Columns.Add(new DataColumn(strheader));
                }
                //Data
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] strData = lines[i].Split(',');
                    DataRow dr = dt_inventory.NewRow();
                    DataRow dr_order = dt_order.NewRow();
                    int columnIndex = 0;
                    int columnIndex2 = 0;
                    foreach (string strheader in headerLabels)
                    {
                        dr[strheader] = strData[columnIndex++];
                        dr_order[strheader] = strData[columnIndex2++];
                    }
                    dt_inventory.Rows.Add(dr);
                    dt_order.Rows.Add(dr_order);
                }
            }
            if (dt_inventory.Rows.Count > 0)
            {
                inventoryTable.DataSource = dt_inventory;
            }

            ArrayList UniqueRecords = new ArrayList();
            ArrayList DuplicateRecords = new ArrayList();

            // Check if records is already added to UniqueRecords otherwise,
            // Add the records to DuplicateRecords
            foreach (DataRow dRow in dt_order.Rows)
            {
                if (UniqueRecords.Contains(dRow["Item"]))
                    DuplicateRecords.Add(dRow);
                else
                    UniqueRecords.Add(dRow["Item"]);
            }
            foreach (DataRow dRow in DuplicateRecords)
            {
                dt_order.Rows.Remove(dRow);
            }

            if (dt_order.Rows.Count > 0)
            {
                menuTable.DataSource = dt_order;
            }

            cmbSearchType.Items.Clear();
            string[] ColNameList = dt_inventory.Columns.OfType<DataColumn>().Select(x => x.ColumnName).ToArray();
            cmbSearchType.Items.AddRange(ColNameList); // Adding Column Names in ComoBox List
            if (cmbSearchType.Items.Count > 0)
                cmbSearchType.SelectedIndex = 0;

            cmbSearchTypeOrder.Items.Clear();
            string[] ColNameList2 = dt_order.Columns.OfType<DataColumn>().Select(x => x.ColumnName).ToArray();
            cmbSearchTypeOrder.Items.AddRange(ColNameList2); // Adding Column Names in ComoBox List
            if (cmbSearchTypeOrder.Items.Count > 0)
                cmbSearchTypeOrder.SelectedIndex = 0;
        }

        private void inventory_table()
        {
            LoadData(currentInventory);
        }

        private void order_button_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            activePanel = orderPanel;
            activePanel.Visible = true;

            LoadData(currentInventory);

            menuTable.Columns["Ingredient"].Visible = false;
            menuTable.Columns["Amount"].Visible = false;
            menuTable.Columns["Qty"].Visible = false;

            orderTable.DataSource = dt_cashier;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to close the POS?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //this refers to the form
            //closes the form if user said yes
            if (dr == DialogResult.Yes)
                this.Close();
        }

        private void POS_Load(object sender, EventArgs e)
        {

        }

        private void inventory_button_Click(object sender, EventArgs e)
        {
            
            activePanel.Visible = false;
            activePanel = inventoryPanel;
            activePanel.Visible = true;
            inventory_table();
        }

        private void inventoryPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backInventory_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            activePanel = menuPanel;
            activePanel.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void load_inventory_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.InitialDirectory = Environment.CurrentDirectory.ToString();
                open.Filter = "CSV Files (*.csv)|*.csv";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    currentInventory = open.FileName;
                    LoadData(currentInventory);
                }
            }

        }

        private void search_Click(object sender, EventArgs e)
        {
            ((DataTable)inventoryTable.DataSource).DefaultView.RowFilter = string.Format("" + cmbSearchType.Text + " like '%{0}%'", search_inventory.Text.Trim().Replace("'", "''"));
        }

        private void show_all_Click(object sender, EventArgs e)
        {
            LoadData(currentInventory);
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backOrder_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            activePanel = menuPanel;
            activePanel.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            if (menuTable.SelectedRows.Count == 1)
            {
                int selectedrowindex = menuTable.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = menuTable.Rows[selectedrowindex];
                string classItem = Convert.ToString(selectedRow.Cells["Class"].Value);
                string item = Convert.ToString(selectedRow.Cells["Item"].Value);
                string price = Convert.ToString(selectedRow.Cells["Price"].Value);
                bool exists = false;
                foreach (DataGridViewRow row in orderTable.Rows)
                {
                    if (row.Cells["Class"].Value.ToString() == classItem && row.Cells["Item"].Value.ToString() == item && row.Cells["Price"].Value.ToString() == price)
                    {
                        exists = true;
                    }
                }
                if (exists == false)
                {
                    dt_cashier.Rows.Add(new Object[] { 1, classItem, item, price });
                    double total = Convert.ToDouble(totalPrice.Text) + Convert.ToDouble(price);
                    totalPrice.Text = total.ToString("F");
                }
            }
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            if (orderTable.SelectedCells.Count == 1)
            {
                int selectedrowindex = orderTable.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = orderTable.Rows[selectedrowindex];
                string price = Convert.ToString(selectedRow.Cells["Price"].Value);
                selectedRow.Cells["Qty"].Value = Convert.ToInt32(selectedRow.Cells["Qty"].Value.ToString()) + 1;

                double total = Convert.ToDouble(totalPrice.Text) + Convert.ToDouble(price);
                totalPrice.Text = total.ToString("F");
            }
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            if (orderTable.SelectedCells.Count == 1)
            {
                int selectedrowindex = orderTable.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = orderTable.Rows[selectedrowindex];
                string price = Convert.ToString(selectedRow.Cells["Price"].Value);
                if (Convert.ToInt32(selectedRow.Cells["Qty"].Value.ToString()) > 1)
                {
                    selectedRow.Cells["Qty"].Value = Convert.ToInt32(selectedRow.Cells["Qty"].Value.ToString()) - 1;
                    double total = Convert.ToDouble(totalPrice.Text) - Convert.ToDouble(price);
                    totalPrice.Text = total.ToString("F");
                }
            }
        }

        private void delOrderButton_Click(object sender, EventArgs e)
        {
            if (orderTable.SelectedCells.Count == 1)
            {
                int selectedrowindex = orderTable.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = orderTable.Rows[selectedrowindex];
                string price = Convert.ToString(selectedRow.Cells["Price"].Value);
                string qty = Convert.ToString(selectedRow.Cells["Qty"].Value);
                orderTable.Rows.Remove(selectedRow);

                double total = Convert.ToDouble(totalPrice.Text) - (Convert.ToDouble(qty) * Convert.ToDouble(price));
                totalPrice.Text = total.ToString("F");
            }
        }

        private void clearOrder_Click(object sender, EventArgs e)
        {
            dt_cashier.Clear();
            totalPrice.Text = "0.00";
        }

        private void showAllOrder_Click(object sender, EventArgs e)
        {
            LoadData(currentInventory);
        }

        private void searchButtonOrder_Click(object sender, EventArgs e)
        {
            ((DataTable)menuTable.DataSource).DefaultView.RowFilter = string.Format("" + cmbSearchTypeOrder.Text + " like '%{0}%'", searchOrder.Text.Trim().Replace("'", "''"));
        }

        private void checkoutOrder_Click(object sender, EventArgs e)
        {
            double number;
            if (!Double.TryParse(cashBox.Text, out number))
            {
                DialogResult dr = MessageBox.Show("Please enter valid cash (numbers).", "Invalid Cash", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                double change = Convert.ToDouble(cashBox.Text) - Convert.ToDouble(totalPrice.Text);
                if(change < 0)
                {
                    DialogResult dr2 = MessageBox.Show("Insufficient cash.", "Invalid Cash", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    checkout confirm = new checkout(dt_cashier, totalPrice.Text, cashBox.Text);
                    confirm.Show();
                }
            }

            //string clientDetails = clientNameTextBox.Text + "," + mIDTextBox.Text + "," + billToTextBox.Text;
            /*            if (!File.Exists(history))
                        {
                            string clientHeader = "ID" + "," + "Date" + "," + "Item" + "," + "Total Price" + Environment.NewLine;

                            File.WriteAllText(history, clientHeader);
                        }*/

            //File.AppendAllText(history, clientDetails);
        }

        private void tableLayoutPanel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cashBox_TextChanged(object sender, EventArgs e)
        {
            double number;
            if (Double.TryParse(cashBox.Text, out number))
            {
                checkoutOrder.Enabled = true;
            }
        }
    }
}
