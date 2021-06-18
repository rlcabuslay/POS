
namespace POS
{
    partial class POS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS));
            this.menuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.exit_button = new System.Windows.Forms.Button();
            this.history_button = new System.Windows.Forms.Button();
            this.inventory_button = new System.Windows.Forms.Button();
            this.clock_button = new System.Windows.Forms.Button();
            this.order_button = new System.Windows.Forms.Button();
            this.inventoryPanel = new System.Windows.Forms.TableLayoutPanel();
            this.inventoryTable = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.load_inventory = new System.Windows.Forms.Button();
            this.show_all = new System.Windows.Forms.Button();
            this.backInventory = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.search = new System.Windows.Forms.Button();
            this.search_inventory = new System.Windows.Forms.TextBox();
            this.cmbSearchType = new System.Windows.Forms.ComboBox();
            this.orderPanel = new System.Windows.Forms.TableLayoutPanel();
            this.menuTable = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.orderTable = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.totalPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.backOrder = new System.Windows.Forms.Button();
            this.clearOrder = new System.Windows.Forms.Button();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.delOrderButton = new System.Windows.Forms.Button();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.showAllOrder = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.searchButtonOrder = new System.Windows.Forms.Button();
            this.searchOrder = new System.Windows.Forms.TextBox();
            this.cmbSearchTypeOrder = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cashBox = new System.Windows.Forms.TextBox();
            this.checkoutOrder = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.inventoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTable)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.orderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuTable)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderTable)).BeginInit();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.ColumnCount = 1;
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuPanel.Controls.Add(this.exit_button, 0, 4);
            this.menuPanel.Controls.Add(this.history_button, 0, 1);
            this.menuPanel.Controls.Add(this.inventory_button, 0, 2);
            this.menuPanel.Controls.Add(this.clock_button, 0, 3);
            this.menuPanel.Controls.Add(this.order_button, 0, 0);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.RowCount = 5;
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.menuPanel.Size = new System.Drawing.Size(870, 450);
            this.menuPanel.TabIndex = 0;
            this.menuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // exit_button
            // 
            this.exit_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exit_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exit_button.Location = new System.Drawing.Point(335, 377);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(200, 55);
            this.exit_button.TabIndex = 13;
            this.exit_button.Text = "EXIT";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // history_button
            // 
            this.history_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.history_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.history_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.history_button.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.history_button.Location = new System.Drawing.Point(335, 107);
            this.history_button.Name = "history_button";
            this.history_button.Size = new System.Drawing.Size(200, 55);
            this.history_button.TabIndex = 10;
            this.history_button.Text = "HISTORY";
            this.history_button.UseVisualStyleBackColor = false;
            // 
            // inventory_button
            // 
            this.inventory_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inventory_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.inventory_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventory_button.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.inventory_button.Location = new System.Drawing.Point(335, 197);
            this.inventory_button.Name = "inventory_button";
            this.inventory_button.Size = new System.Drawing.Size(200, 55);
            this.inventory_button.TabIndex = 11;
            this.inventory_button.Text = "INVENTORY";
            this.inventory_button.UseVisualStyleBackColor = false;
            this.inventory_button.Click += new System.EventHandler(this.inventory_button_Click);
            // 
            // clock_button
            // 
            this.clock_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clock_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.clock_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clock_button.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clock_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clock_button.Location = new System.Drawing.Point(335, 287);
            this.clock_button.Name = "clock_button";
            this.clock_button.Size = new System.Drawing.Size(200, 55);
            this.clock_button.TabIndex = 12;
            this.clock_button.Text = "CLOCK";
            this.clock_button.UseVisualStyleBackColor = false;
            // 
            // order_button
            // 
            this.order_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.order_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.order_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.order_button.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.order_button.Location = new System.Drawing.Point(335, 17);
            this.order_button.Name = "order_button";
            this.order_button.Size = new System.Drawing.Size(200, 55);
            this.order_button.TabIndex = 9;
            this.order_button.Text = "ORDER";
            this.order_button.UseVisualStyleBackColor = false;
            this.order_button.Click += new System.EventHandler(this.order_button_Click);
            // 
            // inventoryPanel
            // 
            this.inventoryPanel.ColumnCount = 3;
            this.inventoryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.inventoryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.inventoryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.inventoryPanel.Controls.Add(this.inventoryTable, 1, 1);
            this.inventoryPanel.Controls.Add(this.tableLayoutPanel1, 2, 1);
            this.inventoryPanel.Controls.Add(this.backInventory, 0, 0);
            this.inventoryPanel.Controls.Add(this.comboBox1, 1, 2);
            this.inventoryPanel.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.inventoryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryPanel.Location = new System.Drawing.Point(0, 0);
            this.inventoryPanel.Name = "inventoryPanel";
            this.inventoryPanel.RowCount = 3;
            this.inventoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.inventoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.inventoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.inventoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.inventoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.inventoryPanel.Size = new System.Drawing.Size(870, 450);
            this.inventoryPanel.TabIndex = 1;
            this.inventoryPanel.Visible = false;
            this.inventoryPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.inventoryPanel_Paint);
            // 
            // inventoryTable
            // 
            this.inventoryTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryTable.Location = new System.Drawing.Point(133, 48);
            this.inventoryTable.Name = "inventoryTable";
            this.inventoryTable.RowHeadersVisible = false;
            this.inventoryTable.RowHeadersWidth = 51;
            this.inventoryTable.RowTemplate.Height = 24;
            this.inventoryTable.Size = new System.Drawing.Size(603, 354);
            this.inventoryTable.TabIndex = 5;
            this.inventoryTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.load_inventory, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.show_all, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(742, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(125, 354);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // load_inventory
            // 
            this.load_inventory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.load_inventory.Location = new System.Drawing.Point(3, 128);
            this.load_inventory.Name = "load_inventory";
            this.load_inventory.Size = new System.Drawing.Size(119, 45);
            this.load_inventory.TabIndex = 0;
            this.load_inventory.Text = "Load";
            this.load_inventory.UseVisualStyleBackColor = true;
            this.load_inventory.Click += new System.EventHandler(this.load_inventory_Click);
            // 
            // show_all
            // 
            this.show_all.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.show_all.Location = new System.Drawing.Point(3, 43);
            this.show_all.Name = "show_all";
            this.show_all.Size = new System.Drawing.Size(119, 42);
            this.show_all.TabIndex = 1;
            this.show_all.Text = "Show All";
            this.show_all.UseVisualStyleBackColor = true;
            this.show_all.Click += new System.EventHandler(this.show_all_Click);
            // 
            // backInventory
            // 
            this.backInventory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backInventory.BackgroundImage")));
            this.backInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backInventory.Location = new System.Drawing.Point(3, 3);
            this.backInventory.Name = "backInventory";
            this.backInventory.Size = new System.Drawing.Size(124, 39);
            this.backInventory.TabIndex = 1;
            this.backInventory.Text = "\r\n";
            this.backInventory.UseVisualStyleBackColor = true;
            this.backInventory.Click += new System.EventHandler(this.backInventory_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(184, 415);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(500, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.85106F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.14894F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel2.Controls.Add(this.search, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.search_inventory, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbSearchType, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(133, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(603, 39);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // search
            // 
            this.search.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.search.Location = new System.Drawing.Point(502, 13);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(98, 23);
            this.search.TabIndex = 1;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // search_inventory
            // 
            this.search_inventory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.search_inventory.Location = new System.Drawing.Point(207, 14);
            this.search_inventory.Name = "search_inventory";
            this.search_inventory.Size = new System.Drawing.Size(289, 22);
            this.search_inventory.TabIndex = 0;
            this.search_inventory.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbSearchType
            // 
            this.cmbSearchType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbSearchType.FormattingEnabled = true;
            this.cmbSearchType.Location = new System.Drawing.Point(3, 11);
            this.cmbSearchType.Name = "cmbSearchType";
            this.cmbSearchType.Size = new System.Drawing.Size(198, 24);
            this.cmbSearchType.TabIndex = 2;
            // 
            // orderPanel
            // 
            this.orderPanel.ColumnCount = 2;
            this.orderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.25F));
            this.orderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.75F));
            this.orderPanel.Controls.Add(this.menuTable, 1, 1);
            this.orderPanel.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.orderPanel.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.orderPanel.Controls.Add(this.tableLayoutPanel10, 0, 2);
            this.orderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderPanel.Location = new System.Drawing.Point(0, 0);
            this.orderPanel.Name = "orderPanel";
            this.orderPanel.RowCount = 3;
            this.orderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.66667F));
            this.orderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.11111F));
            this.orderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.orderPanel.Size = new System.Drawing.Size(870, 450);
            this.orderPanel.TabIndex = 2;
            this.orderPanel.Visible = false;
            // 
            // menuTable
            // 
            this.menuTable.AllowUserToAddRows = false;
            this.menuTable.AllowUserToDeleteRows = false;
            this.menuTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.menuTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuTable.Location = new System.Drawing.Point(474, 87);
            this.menuTable.Name = "menuTable";
            this.menuTable.RowHeadersWidth = 51;
            this.menuTable.RowTemplate.Height = 24;
            this.menuTable.Size = new System.Drawing.Size(393, 314);
            this.menuTable.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.17757F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.82243F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel8, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.showAllOrder, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.orderPanel.SetRowSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.60302F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.39699F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(465, 398);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.orderTable, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel9, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 85);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(380, 310);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // orderTable
            // 
            this.orderTable.AllowUserToAddRows = false;
            this.orderTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderTable.Location = new System.Drawing.Point(3, 3);
            this.orderTable.Name = "orderTable";
            this.orderTable.ReadOnly = true;
            this.orderTable.RowHeadersVisible = false;
            this.orderTable.RowHeadersWidth = 51;
            this.orderTable.RowTemplate.Height = 24;
            this.orderTable.Size = new System.Drawing.Size(374, 251);
            this.orderTable.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.93948F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.06052F));
            this.tableLayoutPanel9.Controls.Add(this.totalPrice, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 260);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(374, 47);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // totalPrice
            // 
            this.totalPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.totalPrice.AutoSize = true;
            this.totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.Location = new System.Drawing.Point(163, 7);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(71, 32);
            this.totalPrice.TabIndex = 1;
            this.totalPrice.Text = "0.00";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 233F));
            this.tableLayoutPanel7.Controls.Add(this.backOrder, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.clearOrder, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel11, 1, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.21053F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.78947F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(380, 76);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // backOrder
            // 
            this.backOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backOrder.BackgroundImage")));
            this.backOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backOrder.Location = new System.Drawing.Point(3, 3);
            this.backOrder.Name = "backOrder";
            this.backOrder.Size = new System.Drawing.Size(141, 39);
            this.backOrder.TabIndex = 2;
            this.backOrder.Text = "\r\n";
            this.backOrder.UseVisualStyleBackColor = true;
            this.backOrder.Click += new System.EventHandler(this.backOrder_Click);
            // 
            // clearOrder
            // 
            this.clearOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearOrder.Location = new System.Drawing.Point(3, 48);
            this.clearOrder.Name = "clearOrder";
            this.clearOrder.Size = new System.Drawing.Size(141, 25);
            this.clearOrder.TabIndex = 0;
            this.clearOrder.Text = "CLEAR";
            this.clearOrder.UseVisualStyleBackColor = true;
            this.clearOrder.Click += new System.EventHandler(this.clearOrder_Click);
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.40969F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.59031F));
            this.tableLayoutPanel11.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(150, 48);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(227, 25);
            this.tableLayoutPanel11.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "ORDER ID:";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.delOrderButton, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.addOrderButton, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.downButton, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.upButton, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(389, 85);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 4;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(73, 310);
            this.tableLayoutPanel8.TabIndex = 2;
            // 
            // delOrderButton
            // 
            this.delOrderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delOrderButton.Location = new System.Drawing.Point(3, 234);
            this.delOrderButton.Name = "delOrderButton";
            this.delOrderButton.Size = new System.Drawing.Size(67, 73);
            this.delOrderButton.TabIndex = 3;
            this.delOrderButton.Text = "DEL";
            this.delOrderButton.UseVisualStyleBackColor = true;
            this.delOrderButton.Click += new System.EventHandler(this.delOrderButton_Click);
            // 
            // addOrderButton
            // 
            this.addOrderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addOrderButton.Location = new System.Drawing.Point(3, 157);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(67, 71);
            this.addOrderButton.TabIndex = 2;
            this.addOrderButton.Text = "ADD";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // downButton
            // 
            this.downButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("downButton.BackgroundImage")));
            this.downButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.downButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downButton.Location = new System.Drawing.Point(3, 80);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(67, 71);
            this.downButton.TabIndex = 1;
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // upButton
            // 
            this.upButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("upButton.BackgroundImage")));
            this.upButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upButton.Location = new System.Drawing.Point(3, 3);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(67, 71);
            this.upButton.TabIndex = 0;
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // showAllOrder
            // 
            this.showAllOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.showAllOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllOrder.Location = new System.Drawing.Point(393, 32);
            this.showAllOrder.Name = "showAllOrder";
            this.showAllOrder.Size = new System.Drawing.Size(64, 47);
            this.showAllOrder.TabIndex = 3;
            this.showAllOrder.Text = "Show All";
            this.showAllOrder.UseVisualStyleBackColor = true;
            this.showAllOrder.Click += new System.EventHandler(this.showAllOrder_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.comboBox3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(474, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(393, 78);
            this.tableLayoutPanel5.TabIndex = 3;
            this.tableLayoutPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel5_Paint);
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(19, 7);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(354, 24);
            this.comboBox3.TabIndex = 6;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.85106F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.14894F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel6.Controls.Add(this.searchButtonOrder, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.searchOrder, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.cmbSearchTypeOrder, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 42);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(387, 33);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // searchButtonOrder
            // 
            this.searchButtonOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchButtonOrder.Location = new System.Drawing.Point(286, 7);
            this.searchButtonOrder.Name = "searchButtonOrder";
            this.searchButtonOrder.Size = new System.Drawing.Size(98, 23);
            this.searchButtonOrder.TabIndex = 1;
            this.searchButtonOrder.Text = "Search";
            this.searchButtonOrder.UseVisualStyleBackColor = true;
            this.searchButtonOrder.Click += new System.EventHandler(this.searchButtonOrder_Click);
            // 
            // searchOrder
            // 
            this.searchOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchOrder.Location = new System.Drawing.Point(119, 8);
            this.searchOrder.Name = "searchOrder";
            this.searchOrder.Size = new System.Drawing.Size(161, 22);
            this.searchOrder.TabIndex = 0;
            // 
            // cmbSearchTypeOrder
            // 
            this.cmbSearchTypeOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbSearchTypeOrder.FormattingEnabled = true;
            this.cmbSearchTypeOrder.Location = new System.Drawing.Point(3, 5);
            this.cmbSearchTypeOrder.Name = "cmbSearchTypeOrder";
            this.cmbSearchTypeOrder.Size = new System.Drawing.Size(110, 24);
            this.cmbSearchTypeOrder.TabIndex = 2;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 3;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.12704F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.87296F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel10.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.cashBox, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.checkoutOrder, 2, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 407);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(465, 40);
            this.tableLayoutPanel10.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "CASH:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cashBox
            // 
            this.cashBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cashBox.Location = new System.Drawing.Point(73, 9);
            this.cashBox.Name = "cashBox";
            this.cashBox.Size = new System.Drawing.Size(229, 22);
            this.cashBox.TabIndex = 3;
            this.cashBox.TextChanged += new System.EventHandler(this.cashBox_TextChanged);
            // 
            // checkoutOrder
            // 
            this.checkoutOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkoutOrder.Enabled = false;
            this.checkoutOrder.Location = new System.Drawing.Point(320, 4);
            this.checkoutOrder.Name = "checkoutOrder";
            this.checkoutOrder.Size = new System.Drawing.Size(130, 32);
            this.checkoutOrder.TabIndex = 1;
            this.checkoutOrder.Text = "CHECKOUT";
            this.checkoutOrder.UseVisualStyleBackColor = true;
            this.checkoutOrder.Click += new System.EventHandler(this.checkoutOrder_Click);
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.orderPanel);
            this.Controls.Add(this.inventoryPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "POS";
            this.Text = "POS";
            this.Load += new System.EventHandler(this.POS_Load);
            this.menuPanel.ResumeLayout(false);
            this.inventoryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTable)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.orderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuTable)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderTable)).EndInit();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel menuPanel;
        private System.Windows.Forms.Button order_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button history_button;
        private System.Windows.Forms.Button inventory_button;
        private System.Windows.Forms.Button clock_button;
        private System.Windows.Forms.TableLayoutPanel inventoryPanel;
        private System.Windows.Forms.Button backInventory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox search_inventory;
        private System.Windows.Forms.DataGridView inventoryTable;
        private System.Windows.Forms.Button load_inventory;
        private System.Windows.Forms.ComboBox cmbSearchType;
        private System.Windows.Forms.Button show_all;
        private System.Windows.Forms.TableLayoutPanel orderPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView orderTable;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button backOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button delOrderButton;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Button showAllOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Button clearOrder;
        private System.Windows.Forms.Button checkoutOrder;
        private System.Windows.Forms.DataGridView menuTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button searchButtonOrder;
        private System.Windows.Forms.TextBox searchOrder;
        private System.Windows.Forms.ComboBox cmbSearchTypeOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cashBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Label label3;
    }
}

