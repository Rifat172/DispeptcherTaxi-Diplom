using System;
using System.Windows.Forms;
using RifatDiplom.Model.Driver;

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

        #region закрытие приложения
        private void FMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

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

        private void FMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvDriver.AutoGenerateColumns = false;

            SQLDriverWithStatus sqlDriver = new SQLDriverWithStatus();
            if (sqlDriver.OpenSQLConn()==1)
            {
                cbStatus.DisplayMember = "Status";
                cbStatus.ValueMember = "Id";
                cbStatus.DataSource = sqlDriver.SELECTStatus();

                dgvDriver.DataSource = sqlDriver.SELECTDriver();
            }
        }
    }
}
