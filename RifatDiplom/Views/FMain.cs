using System;
using System.Windows.Forms;
using RifatDiplom.Model.Dispatcher;
using RifatDiplom.Model.Driver;
using RifatDiplom.Model.Order;
using RifatDiplom.Views;
using System.Data;

namespace RifatDiplom
{
    public partial class FMain : Form
    {
        int CurrentUserId = 0;
        #region Установка роли
        private void SETRule(int Id)
        {
            SQLDispatcherWithLogin _disp = new SQLDispatcherWithLogin();
            if (_disp.OpenSQLConn() == 1)
            {
                DataRow RowStatus = _disp.SELECTDispatcher(Id).Rows[0];
                if ((string)RowStatus["Status"] == "Admin")
                {
                    addUser.Visible = true;
                    removeDriver.Visible = true;
                }
                else
                {
                    addUser.Visible = false;
                    removeDriver.Visible = false;
                }
                _disp.CloseSqlConn();
            }
            _disp.CloseSqlConn();
        }
        #endregion
        #region Views
        public delegate void MyEventHandler();
        public event MyEventHandler DisableLists = delegate { };
        public event MyEventHandler EnableLists = delegate { };

        private bool _isBothListDisabled = false; //если false то оба списка не отключены    
        private bool IsBothListDisabled
        {
            get
            {
                return _isBothListDisabled;
            }
            set
            {
                _isBothListDisabled = value;
                if (_isBothListDisabled == true)
                {
                    DisableLists();
                }
                else
                {
                    EnableLists();
                }
            }
        }
        public FMain(int Id)
        {
            InitializeComponent();
            SETRule(Id);
            CurrentUserId = Id;
            DisableLists += DisabledSplit;
            EnableLists += EnabledSplit;
        }
        private void добавитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form signup = new FSignUp();
            signup.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение создано для дипломной работы, Мухамедьяновым Рифатом Гафурьяновичем", "О программе");
        }
        /// <summary>
        /// Проверяет если оба списка отключены то возвращает true
        /// </summary>
        /// <returns></returns>
        private bool checkBothList()
        {
            if (!ListDrivers.Checked && !ListOrder.Checked)
                return true;
            else
                return false;
        }
        private void DisabledSplit()
        {
            splitContainer1.Enabled = splitContainer1.Visible = false;
        }
        private void EnabledSplit()
        {
            splitContainer1.Enabled = splitContainer1.Visible = true;
        }

        private void ListDrivers_Click(object sender, EventArgs e)
        {
            if (ListDrivers.Checked)
            {
                splitContainer1.Panel2Collapsed = true;//скрыть список водителей
                splitContainer1.Panel2.Enabled = false;//выключить список водителей
                ListDrivers.Checked = false;
                IsBothListDisabled = checkBothList();
            }
            else
            {
                splitContainer1.Panel2.Enabled = true;
                splitContainer1.Panel2Collapsed = false;
                if (!splitContainer1.Panel1.Enabled)
                {
                    splitContainer1.Panel1Collapsed = true;
                }
                ListDrivers.Checked = true;
                IsBothListDisabled = false;
            }
        }

        private void ListOrder_Click(object sender, EventArgs e)
        {
            if (ListOrder.Checked)
            {
                splitContainer1.Panel1Collapsed = true;//скрыть список заказов
                splitContainer1.Panel1.Enabled = false;//выключить список заказов
                ListOrder.Checked = false;
                IsBothListDisabled = checkBothList();
            }
            else
            {
                splitContainer1.Panel1.Enabled = true;
                splitContainer1.Panel1Collapsed = false;
                if (!splitContainer1.Panel2.Enabled)
                {
                    splitContainer1.Panel2Collapsed = true;
                }
                ListOrder.Checked = true;
                IsBothListDisabled = false;
            }
        }
        private void выйтиToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form SignIn = new FSignIn();
            SignIn.Show();
            this.Hide();
        }
        private void профильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Profile = new FProfile(CurrentUserId);
            Profile.Show();
        }
        #endregion
        #region закрытие приложения
        private void FMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlDriver.CloseSqlConn();
            sqlOrder.CloseSqlConn();
            Application.Exit();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        SQLDriverWithStatus sqlDriver = null;
        SQLOrderWithStatus sqlOrder = null;

        private void FMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        #region загрузка и обновление данных
        private void LoadData()
        {
            dgvDriver.AutoGenerateColumns = false;
            dgvOrders.AutoGenerateColumns = false;

            sqlDriver = new SQLDriverWithStatus();
            sqlOrder = new SQLOrderWithStatus();

            LoadDriver(sqlDriver);
            LoadOrder(sqlOrder);
        }
        private void LoadDriver(SQLDriverWithStatus sqlDriver)
        {
            if (sqlDriver.OpenSQLConn() == 1)
            {
                cbStatus.DisplayMember = "Status";
                cbStatus.ValueMember = "Id";
                cbStatus.DataSource = sqlDriver.SELECTStatus();

                dgvDriver.DataSource = sqlDriver.SELECTDriver();
            }
        }
        private void LoadOrder(SQLOrderWithStatus sqlOrder)
        {
            if (sqlOrder.OpenSQLConn() == 1)
            {
                cStatus.DisplayMember = "Status";
                cStatus.ValueMember = "Id";
                cStatus.DataSource = sqlOrder.SELECTStatus();

                cDriver.DisplayMember = "NickName";
                cDriver.ValueMember = "Id";
                cDriver.DataSource = sqlDriver.DriverDS.Tables[0];

                dgvOrders.DataSource = sqlOrder.SELECTOrder();
            }
        }
        private void UpdateDriverBtn_Click(object sender, EventArgs e)
        {
            var state = sqlDriver.UPDATEDriver();
            if (state == 0)
            {
                MessageBox.Show("Данные не были изменены", "Предупреждение");
            }
            else
            {
                MessageBox.Show("Данные сохранены", "Успешно");
            }
        }

        private void UpdateOrderBtn_Click(object sender, EventArgs e)
        {
            var Changes = sqlOrder.OrderDS.Tables[0].GetChanges();
            if (Changes != null)
            {
                foreach (DataRow OrderRow in Changes.Rows)
                {
                    if ((int)OrderRow["Id_OrderStatus"] == 3)
                    {
                        if (OrderRow["Id_Driver"] == DBNull.Value)
                        {
                            MessageBox.Show($"Статус указан 'Завершено', но НЕ выбран водитель", "Ошибка");
                            OrderRow["Id_OrderStatus"] = 1;
                            sqlOrder.OrderDS.Merge(Changes);
                            LoadOrder(sqlOrder);
                            dgvOrders.Refresh();
                            return;
                        }
                        else
                        {
                            int Id_Driver = (int)OrderRow["Id_Driver"];
                            var DriverRow = sqlDriver.DriverDS.Tables[0].Select($"Id = {Id_Driver}");
                            foreach (DataRow Driver in DriverRow)
                            {
                                Driver["Pevenue"] = (int)Driver["Pevenue"] + (int)OrderRow["Price"];
                                Driver["Id_Status"] = 1;
                                sqlDriver.UPDATEDriver();
                            }
                        }
                    }
                    if ((int)OrderRow["Id_OrderStatus"] == 2)
                    {
                        if (OrderRow["Id_Driver"] == DBNull.Value)
                        {
                            MessageBox.Show($"Статус указан 'В пути', но НЕ выбран водитель", "Ошибка");
                            OrderRow["Id_OrderStatus"] = 1;
                            sqlOrder.OrderDS.Merge(Changes);
                            LoadOrder(sqlOrder);
                            dgvOrders.Refresh();
                            return;
                        }
                        else
                        {
                            int Id_Driver = (int)OrderRow["Id_Driver"];
                            var DriverRow = sqlDriver.DriverDS.Tables[0].Select($"Id = {Id_Driver}");
                            foreach (DataRow Driver in DriverRow)
                            {
                                Driver["Id_Status"] = 2;
                                sqlDriver.UPDATEDriver();
                            }
                        }
                    }
                }

            }

            var state = sqlOrder.UPDATEOrder();
            if (state == 0)
            {
                MessageBox.Show("Данные не были изменены", "Предупреждение");
            }
            else
            {
                MessageBox.Show("Данные сохранены", "Успешно");
            }
        }
        #endregion

        private void addOrderBtn_Click(object sender, EventArgs e)
        {
            Form FAdd = new FAddOrder(sqlDriver, sqlOrder);
            FAdd.ShowDialog();
            LoadOrder(sqlOrder);
            LoadDriver(sqlDriver);
            dgvOrders.Refresh();
            dgvDriver.Refresh();
        }

        private void addDriver_Click(object sender, EventArgs e)
        {
            Form driver = new FAddDriver(sqlDriver);
            driver.ShowDialog();
            LoadDriver(sqlDriver);
            LoadOrder(sqlOrder);
            dgvDriver.Refresh();
            dgvOrders.Refresh();
        }

        private void уволитьВодителяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form driver = new RemoveDriver(sqlDriver);
            driver.ShowDialog();
            LoadDriver(sqlDriver);
            dgvDriver.Refresh();
        }

        private void списокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form driver = new Drivers(sqlDriver);
            driver.Show();
        }
    }
}
