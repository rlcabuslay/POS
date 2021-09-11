using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace POS
{

    public partial class POS : Form
    {
        TableLayoutPanel activePanel;
        String currentInventory;
        String coffeeshopInventory;
        String carwashInventory;
        String history;
        String logs;
        DataTable dt_cashier = new DataTable();
        String PIN;
        String verifyPIN;
        bool clockedIn;

        private Timer _timer;
        private DateTime _startTime = DateTime.MinValue;
        private TimeSpan _currentElapsedTime = TimeSpan.Zero;
        private TimeSpan _totalElapsedTime = TimeSpan.Zero;

        List<DataGridViewRow> addedItems = new List<DataGridViewRow>();

        public POS()
        {
            InitializeComponent();
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("en-US");
            activePanel = menuPanel;
            currentInventory = "inventory_coffeeshop.csv";
            coffeeshopInventory = "inventory_coffeeshop.csv";
            carwashInventory = "inventory_carwash.csv";
            history = "history.csv";
            logs = "logs.csv";

            dt_cashier.Columns.Add("Qty");
            dt_cashier.Columns.Add("Class");
            dt_cashier.Columns.Add("Item");
            dt_cashier.Columns.Add("Price");
            dt_cashier.Columns.Add("Cost");
            cmbStoreOptionInventory.SelectedIndex = 0;
            cmbStoreOptionOrder.SelectedIndex = 0;
            cmbOptionHistory.SelectedIndex = 0;

            PIN = String.Empty;
            verifyPIN = "1111";
            clockedIn = false;

            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += new EventHandler(_timer_Tick);
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

        private void LoadDataHistory(string strFilePath)
        {
            DataTable dt_history = new DataTable();
            dt_history.Clear();
            string[] lines = System.IO.File.ReadAllLines(strFilePath);
            if (lines.Length > 0)
            {
                //Header
                string strfirstLine = lines[0];
                string[] headerLabels = strfirstLine.Split(',');
                foreach (string strheader in headerLabels)
                {
                    dt_history.Columns.Add(new DataColumn(strheader));
                }
                //Data
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] strData = lines[i].Split(',');
                    DataRow dr = dt_history.NewRow();
                    int columnIndex = 0;
                    foreach (string strheader in headerLabels)
                    {
                        dr[strheader] = strData[columnIndex++];
                    }
                    dt_history.Rows.Add(dr);
                }
            }
            if (dt_history.Rows.Count > 0)
            {
                historyTable.DataSource = dt_history;
            }

            cmbSearchTypeHistory.Items.Clear();
            string[] ColNameList = dt_history.Columns.OfType<DataColumn>().Select(x => x.ColumnName).ToArray();
            cmbSearchTypeHistory.Items.AddRange(ColNameList); // Adding Column Names in ComoBox List
            if (cmbSearchTypeHistory.Items.Count > 0)
                cmbSearchTypeHistory.SelectedIndex = 0;
        }



        private void inventory_table()
        {
            if (cmbStoreOptionInventory.Text == "Coffee Shop")
            {
                if (File.Exists(coffeeshopInventory))
                {
                    try
                    {
                        LoadData(coffeeshopInventory);
                    }
                    catch
                    {
                        DialogResult dr = MessageBox.Show("Please close inventory_coffeeshop.csv spreadsheet file.", "File is Open", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Put inventory_coffeeshop.csv in the same directory.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else if (cmbStoreOptionInventory.Text == "Car Wash")
            {
                if (File.Exists(carwashInventory))
                {
                    try
                    {
                        LoadData(carwashInventory);
                    }
                    catch
                    {
                        DialogResult dr = MessageBox.Show("Please close inventory_carwash.csv spreadsheet file.", "File is Open", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Put inventory_carwash.csv in the same directory.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void order_table()
        {
            if (cmbStoreOptionOrder.Text == "Coffee Shop")
            {
                if (File.Exists(coffeeshopInventory))
                {
                    try
                    {
                        LoadData(coffeeshopInventory);
                    }
                    catch
                    {
                        DialogResult dr = MessageBox.Show("Please close the spreadsheet file.", "File is Open", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Put inventory_coffeeshop.csv in the same directory.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else if (cmbStoreOptionOrder.Text == "Car Wash")
            {
                if (File.Exists(carwashInventory))
                {
                    try
                    {
                        LoadData(carwashInventory);
                    }
                    catch
                    {
                        DialogResult dr = MessageBox.Show("Please close the spreadsheet file.", "File is Open", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Put inventory_carwash.csv in the same directory.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void calculate_total()
        {
            decimal totalPrice = 0;
            decimal totalCost = 0;

            for (int i = 0; i < historyTable.Rows.Count; i++)
            {
                totalPrice += Convert.ToDecimal(historyTable.Rows[i].Cells["Item Price"].Value);
                totalCost += Convert.ToDecimal(historyTable.Rows[i].Cells["Item Cost"].Value);
            }

            priceTotal.Text = totalPrice.ToString("F");
            costTotal.Text = totalCost.ToString("F");
            netIncome.Text = (totalPrice - totalCost).ToString("F");
        }

        private void history_table()
        {
            if (cmbOptionHistory.Text == "Orders")
            {
                if (File.Exists(history))
                {
                    try
                    {
                        LoadDataHistory(history);

                        historyTable.Columns["ID"].Visible = false;
                        historyTable.Columns["Name"].Visible = false;
                        historyTable.Columns["Total Order"].Visible = false;

                        calculate_total();

                        filterDate.Enabled = true;
                    }
                    catch
                    {
                        DialogResult dr = MessageBox.Show("Please close the spreadsheet file.", "File is Open", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Put history.csv in the same directory.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else if (cmbOptionHistory.Text == "Logs")
            {
                if (File.Exists(logs))
                {
                    try
                    {
                        LoadDataHistory(logs);

                        filterDate.Enabled = false;
                    }
                    catch
                    {
                        DialogResult dr = MessageBox.Show("Please close the spreadsheet file.", "File is Open", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Put logs.csv in the same directory.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void generate_OrderID()
        {
            var id = Convert.ToBase64String(Guid.NewGuid().ToByteArray());

            order_id.Text = id;
        }

        private void order_button_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            activePanel = orderPanel;
            activePanel.Visible = true;

            order_table();

            if (cmbStoreOptionOrder.Text == "Coffee Shop")
            {
                menuTable.Columns["Ingredient"].Visible = false;
                menuTable.Columns["Amount"].Visible = false;
                menuTable.Columns["Qty"].Visible = false;
                menuTable.Columns["Cost"].Visible = false;
            }

            orderTable.DataSource = dt_cashier;

            orderTable.Columns["Cost"].Visible = false;

            generate_OrderID();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inventory_button_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            activePanel = inventoryPanel;
            activePanel.Visible = true;
            inventory_table();
        }

        private void backInventory_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            activePanel = menuPanel;
            activePanel.Visible = true;
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
            try
            {
                ((DataTable)inventoryTable.DataSource).DefaultView.RowFilter = string.Format("" + cmbSearchType.Text + " like '%{0}%'", search_inventory.Text.Trim().Replace("'", "''"));
            }
            catch
            {
                DialogResult dr = MessageBox.Show("Unable to search field.", "Searching Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void show_all_Click(object sender, EventArgs e)
        {
            inventory_table();
        }

        private void backOrder_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            activePanel = menuPanel;
            activePanel.Visible = true;
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
                string cost = Convert.ToString(selectedRow.Cells["Cost"].Value);
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
                    dt_cashier.Rows.Add(new Object[] { 1, classItem, item, price, cost });
                    double total = Convert.ToDouble(totalPrice.Text) + Convert.ToDouble(price);
                    totalPrice.Text = total.ToString("F");
                    addedItems.Add(selectedRow);
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
            order_table();

            if (cmbStoreOptionOrder.Text == "Coffee Shop")
            {
                menuTable.Columns["Ingredient"].Visible = false;
                menuTable.Columns["Amount"].Visible = false;
                menuTable.Columns["Qty"].Visible = false;
                menuTable.Columns["Cost"].Visible = false;
            }
        }

        private void searchButtonOrder_Click(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)menuTable.DataSource).DefaultView.RowFilter = string.Format("" + cmbSearchTypeOrder.Text + " like '%{0}%'", searchOrder.Text.Trim().Replace("'", "''"));
            }
            catch
            {
                DialogResult dr = MessageBox.Show("Unable to search field.", "Searching Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
                    generate_OrderID();
                    checkout confirm = new checkout(dt_cashier, totalPrice.Text, cashBox.Text, order_id.Text, menuTable, orderTable, coffeeshopInventory);
                    confirm.Show();
                }
            }
        }

        private void cashBox_TextChanged(object sender, EventArgs e)
        {
            double number;
            if (Double.TryParse(cashBox.Text, out number))
            {
                checkoutOrder.Enabled = true;
            }
        }

        private void history_button_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            activePanel = historyPanel;
            activePanel.Visible = true;

            history_table();
        }

        private void backHistory_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            activePanel = menuPanel;
            activePanel.Visible = true;
        }

        private void clock_button_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            activePanel = clockPanel;
            activePanel.Visible = true;
        }

        private void backClock_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            activePanel = menuPanel;
            activePanel.Visible = true;
        }

        private void one_Click(object sender, EventArgs e)
        {
            PIN += "1";
            PINText.Text += "*";
        }

        private void two_Click(object sender, EventArgs e)
        {
            PIN += "2";
            PINText.Text += "*";
        }

        private void three_Click(object sender, EventArgs e)
        {
            PIN += "3";
            PINText.Text += "*";
        }

        private void four_Click(object sender, EventArgs e)
        {
            PIN += "4";
            PINText.Text += "*";
        }

        private void five_Click(object sender, EventArgs e)
        {
            PIN += "5";
            PINText.Text += "*";
        }

        private void six_Click(object sender, EventArgs e)
        {
            PIN += "6";
            PINText.Text += "*";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            PIN += "7";
            PINText.Text += "*";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            PIN += "8";
            PINText.Text += "*";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            PIN += "9";
            PINText.Text += "*";
        }

        private void clearPIN_Click(object sender, EventArgs e)
        {
            PIN = String.Empty;
            PINText.Text = String.Empty;
        }

        private void clockInButton_Click(object sender, EventArgs e)
        {
            if (nameClockText.Text == String.Empty)
            {
                DialogResult dr = MessageBox.Show("Please enter your name.", "No Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (PIN != verifyPIN)
            {
                DialogResult dr = MessageBox.Show("The PIN entered is incorrect.", "Incorrect PIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _startTime = DateTime.Now;

                // Store the total elapsed time so far
                _totalElapsedTime = _currentElapsedTime;

                _timer.Start();

                clockOutButton.Enabled = true;
                clockInButton.Enabled = false;

                order_button.Enabled = true;
                history_button.Enabled = true;
                inventory_button.Enabled = true;

                nameClock.Text = nameClockText.Text;
                timeIn.Text = DateTime.Now.ToString();
                timeOut.Text = String.Empty;
                totalTime.Text = String.Empty;

                nameClockText.Text = String.Empty;
                PINText.Text = String.Empty;
                PIN = String.Empty;

                clockedIn = true;
            }
        }

        void _timer_Tick(object sender, EventArgs e)
        {
            // We do this to 'chop off' any stray milliseconds
            // resulting from the Timer's inherent inaccuracy,
            // with the bonus that the TimeSpan.ToString() method
            // will now show the correct HH:MM:SS format
            var timeSinceStartTime = DateTime.Now - _startTime;
            timeSinceStartTime = new TimeSpan(timeSinceStartTime.Hours,
                                              timeSinceStartTime.Minutes,
                                              timeSinceStartTime.Seconds);

            // The current elapsed time is the time since the start button
            // was clicked, plus the total time elapsed since the last reset
            _currentElapsedTime = timeSinceStartTime + _totalElapsedTime;

            // These are just two Label controls which display the current
            // elapsed time and total elapsed time
            clockTime.Text = timeSinceStartTime.ToString();
        }

        protected virtual bool isFileLocked(FileInfo file)
        {
            try
            {
                using (FileStream stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    stream.Close();
                }
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }

            //file is not locked
            return false;
        }

        void clock_out()
        {
            FileInfo logsFile = new FileInfo(logs);
            if (!isFileLocked(logsFile))
            {
                _timer.Stop();

                timeOut.Text = DateTime.Now.ToString();
                totalTime.Text = clockTime.Text;

                clockOutButton.Enabled = false;
                clockInButton.Enabled = true;

                order_button.Enabled = false;
                history_button.Enabled = false;
                inventory_button.Enabled = false;

                if (!File.Exists(logs))
                {
                    string logsHeader = "Name" + "," + "Time In" + "," + "Time Out" + "," + "Total Time" + Environment.NewLine;

                    File.WriteAllText(logs, logsHeader);
                }

                string logsDetails = nameClock.Text + "," + timeIn.Text + "," + timeOut.Text + "," + totalTime.Text + Environment.NewLine;
                File.AppendAllText(logs, logsDetails);

                clockedIn = false;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Please close the logs.csv spreadsheet file.", "Clock Out Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void clockOutButton_Click(object sender, EventArgs e)
        {
            clock_out();
        }

        private void loadStoreOrder_Click(object sender, EventArgs e)
        {
            order_table();

            if (cmbStoreOptionOrder.Text == "Coffee Shop")
            {
                menuTable.Columns["Ingredient"].Visible = false;
                menuTable.Columns["Amount"].Visible = false;
                menuTable.Columns["Qty"].Visible = false;
                menuTable.Columns["Cost"].Visible = false;
            }
        }

        private void loadStoreInventory_Click(object sender, EventArgs e)
        {
            inventory_table();
        }

        private void showAllHistory_Click(object sender, EventArgs e)
        {
            history_table();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (clockedIn)
                {
                    FileInfo logsFile = new FileInfo(logs);
                    clock_out();
                    if (isFileLocked(logsFile))
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        Application.ExitThread();
                    }
                }
                else
                {
                    Application.ExitThread();
                }
            }
            else if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private DataTable convertToDataTable(DataGridView dgv)
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }

            return dt;
        }

        private void searchButtonHistory_Click(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)historyTable.DataSource).DefaultView.RowFilter = string.Format("" + cmbSearchTypeHistory.Text + " like '%{0}%'", searchHistory.Text.Trim().Replace("'", "''"));
                historyTable.DataSource = convertToDataTable(historyTable);
                calculate_total();
            }
            catch
            {
                DialogResult dr = MessageBox.Show("Unable to search field.", "Searching Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void loadHistory_Click(object sender, EventArgs e)
        {
            history_table();
        }

        private void filterDate_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtCloned = ((DataTable)historyTable.DataSource).Clone();
                dtCloned.Columns["Date"].DataType = typeof(DateTime);
                foreach (DataRow row in ((DataTable)historyTable.DataSource).Rows)
                {
                    dtCloned.ImportRow(row);
                }

                ((DataTable)historyTable.DataSource).DefaultView.RowFilter = string.Format("Date >= #{0:yyyy/MM/dd}# And Date <= #{1:yyyy/MM/dd}#", dateTimePicker1.Value, dateTimePicker2.Value);
                historyTable.DataSource = convertToDataTable(historyTable);
                calculate_total();
            }
            catch (Exception err)
            {
                DialogResult dr = MessageBox.Show("Unable to filter date.", "Filtering Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Console.WriteLine(err);
            }
        }
    }

    public static class DataGridViewExtensionMethods
    {

        /// <summary>
        /// Convert column Header text to a delimited string
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static string DelimitedHeaders(this DataGridView sender) =>
            string.Join(",", sender.Columns.OfType<DataGridViewColumn>()
                .Select(column => column.HeaderText).ToArray());

        /// <summary>
        /// Create a string array of data in the DataGridView, does not include header
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="delimiter">Delimiter which defaults to a comma</param>
        /// <returns>array comprised of rows/cell data without header</returns>
        public static string[] ToDelimited(this DataGridView sender, string delimiter = ",") =>
            (sender.Rows.Cast<DataGridViewRow>()
                .Where(row => !row.IsNewRow)
                .Select(row => new {
                    row,
                    rowItem = string.Join(delimiter,
                    Array.ConvertAll(row.Cells.Cast<DataGridViewCell>().ToArray(), c =>
                        ((c.Value == null) ? "" : c.Value.ToString())))
                })
                .Select(@t => @t.rowItem)).ToArray();

        /// <summary>
        ///  Create a string array of data in the DataGridView, includes header
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="delimiter">Delimiter which defaults to a comma</param>
        /// <returns>array comprised of rows/cell data with header</returns>
        public static string[] ToDelimitedWithHeaders(this DataGridView sender, string delimiter = ",")
        {
            var headers = sender.DelimitedHeaders();
            var data = sender.ToDelimited().ToList();
            data.Insert(0, headers);
            return data.ToArray();

        }
    }
}
