using System;
using System.Windows.Forms;
using RifatDiplom.Model.Driver;
using RifatDiplom.Model.Order;

namespace RifatDiplom
{
    public partial class FMain : Form
    {
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
        public FMain(bool isAdmin)
        {
            InitializeComponent();
            addUser.Visible = isAdmin;
            DisableLists += DisabledSplit;
            EnableLists += EnabledSplit;
        }

        

        private void выйтиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form SignIn = new FSignIn();
            SignIn.Show();
            this.Hide();
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
        private void LoadData()
        {
            dgvDriver.AutoGenerateColumns = false;
            dgvOrders.AutoGenerateColumns = false;

            sqlDriver = new SQLDriverWithStatus();
            sqlOrder = new SQLOrderWithStatus();

            if (sqlDriver.OpenSQLConn() == 1)
            {
                cbStatus.DisplayMember = "Status";
                cbStatus.ValueMember = "Id";
                cbStatus.DataSource = sqlDriver.SELECTStatus();

                dgvDriver.DataSource = sqlDriver.SELECTDriver();
            }

            if(sqlOrder.OpenSQLConn() == 1)
            {
                cStatus.DisplayMember = "Status";
                cStatus.ValueMember = "Id";
                cStatus.DataSource = sqlOrder.SELECTStatus();

                cDriver.DisplayMember = "NickName";
                cDriver.ValueMember = "Id";
                cDriver.DataSource = dgvDriver.DataSource;

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

        private void addOrderBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
