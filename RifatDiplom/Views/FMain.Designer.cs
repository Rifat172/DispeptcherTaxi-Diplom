
namespace RifatDiplom
{
    partial class FMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.фаилToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListDrivers = new System.Windows.Forms.ToolStripMenuItem();
            this.ListOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользовательToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.профильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.addUser = new System.Windows.Forms.ToolStripMenuItem();
            this.addDriver = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.addOrderBtn = new System.Windows.Forms.Button();
            this.dgvDriver = new System.Windows.Forms.DataGridView();
            this.dNickName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPevenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.UpdateDriverBtn = new System.Windows.Forms.Button();
            this.UpdateOrderBtn = new System.Windows.Forms.Button();
            this.CreateData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cDriver = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фаилToolStripMenuItem,
            this.пользовательToolStripMenuItem1,
            this.AdminPanel,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1424, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // фаилToolStripMenuItem
            // 
            this.фаилToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListDrivers,
            this.ListOrder,
            this.выйтиToolStripMenuItem});
            this.фаилToolStripMenuItem.Name = "фаилToolStripMenuItem";
            this.фаилToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.фаилToolStripMenuItem.Text = "Фаил";
            // 
            // ListDrivers
            // 
            this.ListDrivers.Checked = true;
            this.ListDrivers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ListDrivers.Name = "ListDrivers";
            this.ListDrivers.Size = new System.Drawing.Size(219, 26);
            this.ListDrivers.Text = "Список водителей";
            this.ListDrivers.Click += new System.EventHandler(this.ListDrivers_Click);
            // 
            // ListOrder
            // 
            this.ListOrder.Checked = true;
            this.ListOrder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ListOrder.Name = "ListOrder";
            this.ListOrder.Size = new System.Drawing.Size(219, 26);
            this.ListOrder.Text = "Список заказов";
            this.ListOrder.Click += new System.EventHandler(this.ListOrder_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.выйтиToolStripMenuItem.Text = "Выход";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // пользовательToolStripMenuItem1
            // 
            this.пользовательToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.профильToolStripMenuItem,
            this.выйтиToolStripMenuItem2});
            this.пользовательToolStripMenuItem1.Name = "пользовательToolStripMenuItem1";
            this.пользовательToolStripMenuItem1.Size = new System.Drawing.Size(121, 24);
            this.пользовательToolStripMenuItem1.Text = "Пользователь";
            // 
            // профильToolStripMenuItem
            // 
            this.профильToolStripMenuItem.Name = "профильToolStripMenuItem";
            this.профильToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.профильToolStripMenuItem.Text = "Профиль";
            this.профильToolStripMenuItem.Click += new System.EventHandler(this.профильToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem2
            // 
            this.выйтиToolStripMenuItem2.Name = "выйтиToolStripMenuItem2";
            this.выйтиToolStripMenuItem2.Size = new System.Drawing.Size(156, 26);
            this.выйтиToolStripMenuItem2.Text = "Выйти";
            this.выйтиToolStripMenuItem2.Click += new System.EventHandler(this.выйтиToolStripMenuItem2_Click);
            // 
            // AdminPanel
            // 
            this.AdminPanel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUser,
            this.addDriver});
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(170, 24);
            this.AdminPanel.Text = "Администрирование";
            // 
            // addUser
            // 
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(259, 26);
            this.addUser.Text = "Добавить пользователя";
            this.addUser.Visible = false;
            this.addUser.Click += new System.EventHandler(this.добавитьПользователяToolStripMenuItem_Click);
            // 
            // addDriver
            // 
            this.addDriver.BackColor = System.Drawing.Color.Ivory;
            this.addDriver.Name = "addDriver";
            this.addDriver.Size = new System.Drawing.Size(259, 26);
            this.addDriver.Text = "Добавить водителя";
            this.addDriver.Click += new System.EventHandler(this.addDriver_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1424, 681);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Gold;
            this.splitContainer1.Panel1.Controls.Add(this.dgvOrders);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel1MinSize = 250;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDriver);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer1.Panel2MinSize = 250;
            this.splitContainer1.Size = new System.Drawing.Size(1416, 638);
            this.splitContainer1.SplitterDistance = 778;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CreateData,
            this.CreateTime,
            this.cFrom,
            this.cTo,
            this.cPrice,
            this.cStatus,
            this.cDriver});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrders.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvOrders.GridColor = System.Drawing.Color.Black;
            this.dgvOrders.Location = new System.Drawing.Point(0, 37);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.Size = new System.Drawing.Size(778, 601);
            this.dgvOrders.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.addOrderBtn, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(778, 37);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список заказов";
            // 
            // addOrderBtn
            // 
            this.addOrderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addOrderBtn.BackColor = System.Drawing.Color.White;
            this.addOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addOrderBtn.Location = new System.Drawing.Point(626, 4);
            this.addOrderBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addOrderBtn.Name = "addOrderBtn";
            this.addOrderBtn.Size = new System.Drawing.Size(148, 28);
            this.addOrderBtn.TabIndex = 1;
            this.addOrderBtn.Text = "Добавить заказ";
            this.addOrderBtn.UseVisualStyleBackColor = false;
            this.addOrderBtn.Click += new System.EventHandler(this.addOrderBtn_Click);
            // 
            // dgvDriver
            // 
            this.dgvDriver.AllowUserToAddRows = false;
            this.dgvDriver.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDriver.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDriver.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriver.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dNickName,
            this.dCar,
            this.dPevenue,
            this.cbStatus});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDriver.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDriver.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvDriver.GridColor = System.Drawing.Color.Black;
            this.dgvDriver.Location = new System.Drawing.Point(0, 37);
            this.dgvDriver.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDriver.MultiSelect = false;
            this.dgvDriver.Name = "dgvDriver";
            this.dgvDriver.RowHeadersWidth = 51;
            this.dgvDriver.Size = new System.Drawing.Size(633, 601);
            this.dgvDriver.TabIndex = 5;
            // 
            // dNickName
            // 
            this.dNickName.DataPropertyName = "NickName";
            this.dNickName.HeaderText = "Позывной";
            this.dNickName.MinimumWidth = 6;
            this.dNickName.Name = "dNickName";
            this.dNickName.ReadOnly = true;
            // 
            // dCar
            // 
            this.dCar.DataPropertyName = "Car";
            this.dCar.HeaderText = "Машина";
            this.dCar.MinimumWidth = 6;
            this.dCar.Name = "dCar";
            this.dCar.ReadOnly = true;
            // 
            // dPevenue
            // 
            this.dPevenue.DataPropertyName = "Pevenue";
            this.dPevenue.HeaderText = "Выручка";
            this.dPevenue.MinimumWidth = 6;
            this.dPevenue.Name = "dPevenue";
            this.dPevenue.ReadOnly = true;
            // 
            // cbStatus
            // 
            this.cbStatus.DataPropertyName = "Id_Status";
            dataGridViewCellStyle4.NullValue = null;
            this.cbStatus.DefaultCellStyle = dataGridViewCellStyle4;
            this.cbStatus.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.cbStatus.HeaderText = "Статус";
            this.cbStatus.MinimumWidth = 6;
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Orange;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(633, 37);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Список водителей";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Cornsilk;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.UpdateDriverBtn, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.UpdateOrderBtn, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 648);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1418, 31);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // UpdateDriverBtn
            // 
            this.UpdateDriverBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.UpdateDriverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateDriverBtn.Location = new System.Drawing.Point(1160, 2);
            this.UpdateDriverBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateDriverBtn.Name = "UpdateDriverBtn";
            this.UpdateDriverBtn.Size = new System.Drawing.Size(255, 27);
            this.UpdateDriverBtn.TabIndex = 0;
            this.UpdateDriverBtn.Text = "Сохранить статус водителя";
            this.UpdateDriverBtn.UseVisualStyleBackColor = true;
            this.UpdateDriverBtn.Click += new System.EventHandler(this.UpdateDriverBtn_Click);
            // 
            // UpdateOrderBtn
            // 
            this.UpdateOrderBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.UpdateOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateOrderBtn.Location = new System.Drawing.Point(3, 2);
            this.UpdateOrderBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateOrderBtn.Name = "UpdateOrderBtn";
            this.UpdateOrderBtn.Size = new System.Drawing.Size(255, 27);
            this.UpdateOrderBtn.TabIndex = 1;
            this.UpdateOrderBtn.Text = "Сохранить статус заказа";
            this.UpdateOrderBtn.UseVisualStyleBackColor = true;
            this.UpdateOrderBtn.Click += new System.EventHandler(this.UpdateOrderBtn_Click);
            // 
            // CreateData
            // 
            this.CreateData.DataPropertyName = "DateCreate";
            this.CreateData.HeaderText = "Дата создания";
            this.CreateData.MinimumWidth = 6;
            this.CreateData.Name = "CreateData";
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "TimeCreate";
            this.CreateTime.HeaderText = "Время создания";
            this.CreateTime.MinimumWidth = 6;
            this.CreateTime.Name = "CreateTime";
            // 
            // cFrom
            // 
            this.cFrom.DataPropertyName = "PointA";
            this.cFrom.HeaderText = "Откуда";
            this.cFrom.MinimumWidth = 6;
            this.cFrom.Name = "cFrom";
            // 
            // cTo
            // 
            this.cTo.DataPropertyName = "PointB";
            this.cTo.HeaderText = "Куда";
            this.cTo.MinimumWidth = 6;
            this.cTo.Name = "cTo";
            // 
            // cPrice
            // 
            this.cPrice.DataPropertyName = "Price";
            this.cPrice.HeaderText = "Стоимость";
            this.cPrice.MinimumWidth = 6;
            this.cPrice.Name = "cPrice";
            // 
            // cStatus
            // 
            this.cStatus.DataPropertyName = "Id_OrderStatus";
            this.cStatus.HeaderText = "Статус";
            this.cStatus.MinimumWidth = 6;
            this.cStatus.Name = "cStatus";
            this.cStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cDriver
            // 
            this.cDriver.DataPropertyName = "Id_Driver";
            this.cDriver.HeaderText = "Водитель";
            this.cDriver.MinimumWidth = 6;
            this.cDriver.Name = "cDriver";
            this.cDriver.ReadOnly = true;
            this.cDriver.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cDriver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1424, 709);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FMain";
            this.Text = "Диспетчерская";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMain_FormClosing);
            this.Load += new System.EventHandler(this.FMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem фаилToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListDrivers;
        private System.Windows.Forms.ToolStripMenuItem ListOrder;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdminPanel;
        private System.Windows.Forms.ToolStripMenuItem addUser;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDriver;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addOrderBtn;
        private System.Windows.Forms.DataGridView dgvDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNickName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPevenue;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button UpdateDriverBtn;
        private System.Windows.Forms.Button UpdateOrderBtn;
        private System.Windows.Forms.ToolStripMenuItem пользовательToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem профильToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateData;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrice;
        private System.Windows.Forms.DataGridViewComboBoxColumn cStatus;
        private System.Windows.Forms.DataGridViewComboBoxColumn cDriver;
    }
}