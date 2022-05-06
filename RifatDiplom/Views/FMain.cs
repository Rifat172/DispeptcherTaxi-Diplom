using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RifatDiplom.Model;

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

        private void button1_Click(object sender, EventArgs e)
        {
            NewOrderClass order = new NewOrderClass();
            DataTable ReadDrivers = UniversalGetTable("select Id, NIckName FROM Drivers where Id_Status = 1", DriversAdapter, DriversSet, "Id_NickName");
            Form Order = new FAddOrder(order, ReadDrivers, new DelegateShowData(AddDataToTable));
            Order.ShowDialog();
        }

        public void AddDataToTable(NewOrderClass order)
        {
            SqlCommand sql = new SqlCommand("INSERT INTO Orders (PointA, PointB, Price, Id_Status, Id_Drivers) " + "VALUES (@PointA, @PointB, @Price, @Id_Status, @Id_Drivers)", OrdersConnection);
            OrdersConnection.Open();

            sql.Parameters.Add("@PointA", SqlDbType.NVarChar, 50);
            sql.Parameters["@PointA"].Value = order.PointA;
            sql.Parameters.Add("@PointB", SqlDbType.NVarChar, 50);
            sql.Parameters["@PointB"].Value = order.PointB;

            SqlParameter param = sql.Parameters.Add("@Price", SqlDbType.Decimal, 0, "Price");
            param.Precision = 10;
            param.Scale = 2;
            param.Value = order.Price;

            sql.Parameters.Add("@Id_Status", SqlDbType.Int);
            sql.Parameters["@Id_Status"].Value = 1;
            sql.Parameters.Add("@Id_Drivers", SqlDbType.Int);
            sql.Parameters["@Id_Drivers"].Value = order.IdDrivers;

            sql.ExecuteNonQuery();
            //InsertData(sql, OrdersAdapter, OdersSet, "Orders");


            OrdersConnection.Close();
            
            LoadOrders();
        }

        #endregion

        #region DriversLoad
        SqlConnection DriversConnection;
        SqlDataAdapter DriversAdapter;
        SqlDataAdapter StatusAdapter;
        DataSet DriversSet;
        DataSet StatusSet;
        SqlCommandBuilder cmd;
        #endregion
        #region OrdersLoad
        SqlConnection OrdersConnection;
        SqlDataAdapter OrdersAdapter;
        SqlDataAdapter OrderStatusAdapter;
        DataSet OdersSet;
        DataSet StatusOrderSet;
        SqlCommandBuilder orderCmd;
        #endregion

        string OrderConnectionString = Properties.Settings.Default.OrderConnect;

        private void Init_Drivers()
        {
            DriversConnection = new SqlConnection(OrderConnectionString);
            DriversConnection.Open();

            DriversAdapter = new SqlDataAdapter();
            StatusAdapter = new SqlDataAdapter();

            DriversSet = new DataSet();
            StatusSet = new DataSet();

            cmd = new SqlCommandBuilder(DriversAdapter);
        }

        private void Init_Orders()
        {
            OrdersConnection = new SqlConnection(OrderConnectionString);
            OrdersConnection.Open();

            OrdersAdapter = new SqlDataAdapter();
            OrderStatusAdapter = new SqlDataAdapter();

            OdersSet = new DataSet();
            StatusOrderSet = new DataSet();

            orderCmd = new SqlCommandBuilder(OrdersAdapter);
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            Init_Drivers();
            Init_Orders();

            LoadDrivers();
            LoadOrders();

            DriversConnection.Close();
            OrdersConnection.Close();
        }

        private void LoadOrders()
        {
            dgvOrders.DataSource = null;
            dgvOrders.Rows.Clear();

            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvOrders.DataSource = GetOrders();

            dgvOrders.Columns["cFrom"].DataPropertyName = "PointA"     ;
            dgvOrders.Columns["cTo"].DataPropertyName = "PointB"       ;
            dgvOrders.Columns["cPrice"].DataPropertyName = "Price"     ;
            dgvOrders.Columns["cStatus"].DataPropertyName = "Id_Status";
            dgvOrders.Columns["cDriver"].DataPropertyName = "NickName" ;

            var cbStatus = (DataGridViewComboBoxColumn)dgvOrders.Columns["cStatus"];

            cbStatus.DisplayMember = "Status";
            cbStatus.ValueMember = "Id";
            cbStatus.DataSource = GetOrderStatus();
        }

        private object GetOrderStatus()
        {
            return UniversalGetTable("SELECT Id, Status FROM Status", OrderStatusAdapter, StatusOrderSet, "Status");
        }

        private object GetOrders()
        {
            return UniversalGetTable("select O.Id, O.PointA, O.PointB, O.Price,OS.Status, D.NickName, O.Id_Drivers, O.Id_Status from Drivers as D left join Orders as O on O.Id_Drivers = D.Id inner join OrderStatus as OS on O.Id_Status = OS.Id", OrdersAdapter, OdersSet, "Orders");
        }

        private void LoadDrivers()
        {
            dgvDriver.AutoGenerateColumns = false;
            dgvDriver.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvDriver.DataSource = GetDrivers();

            dgvDriver.Columns["dNickName"].DataPropertyName = "NickName";
            dgvDriver.Columns["dCar"].DataPropertyName = "Car";
            dgvDriver.Columns["dPevenue"].DataPropertyName = "Pevenue";
            dgvDriver.Columns["cbStatus"].DataPropertyName = "Id_Status";

            var cbStatus = (DataGridViewComboBoxColumn)dgvDriver.Columns["cbStatus"];

            cbStatus.DisplayMember = "Status";
            cbStatus.ValueMember = "Id";
            cbStatus.DataSource = GetStatus();
        }
        private DataTable GetDrivers()
        {
            return UniversalGetTable("SELECT * FROM Drivers", DriversAdapter, DriversSet, "Drivers");
            //return Drivers("SELECT D.Id, D.NickName, D.Car, D.Pevenue, D.Id_Status, S.Id as StatusId, S.Status FROM Status AS S LEFT JOIN Drivers AS D ON D.Id_Status = S.Id", DriversSet , "Drivers");
        }
        private DataTable GetStatus()
        {
            return UniversalGetTable("SELECT Id, Status FROM Status", StatusAdapter, StatusSet, "Status");
        }
        /// <summary>
        /// Подключение к базе данных
        /// </summary>
        /// <param name="sqlCommand">sql команда-запрос к базе данных</param>
        /// <returns type="DataTable">возращает таблицу DataTable</returns>
        private DataTable UniversalGetTable(string sqlCommand, SqlDataAdapter adapter, DataSet ds, string TName)
        {
            SqlCommand command = new SqlCommand(sqlCommand, DriversConnection);

            adapter.SelectCommand = command;

            adapter.Fill(ds, TName);
            ds.Tables[TName].Locale = System.Globalization.CultureInfo.InvariantCulture;

            return ds.Tables[TName];
        }
        private void InsertData(SqlCommand sqlCommand, SqlDataAdapter adapter, DataSet ds, string tableName)
        {
            adapter.InsertCommand = sqlCommand;
            adapter.Update(ds, tableName);
        }
        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DriversAdapter.Update(DriversSet, "Drivers");
        }
    }
}
