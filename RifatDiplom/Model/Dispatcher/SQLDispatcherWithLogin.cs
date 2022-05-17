using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RifatDiplom.Model.Dispatcher
{
    public class SQLDispatcherWithLogin
    {
        private SqlConnection sqlConnection = null;

        private SqlDataAdapter DispatcherAd = null;
        private SqlDataAdapter LoginAd = null;

        private DataSet _DispatcherDS = null;
        private DataSet _LoginDS = null;

        public DataSet DispatcherDS { get => _DispatcherDS; set => _DispatcherDS = value; }
        public DataSet LoginDS { get => _LoginDS; set => _LoginDS = value; }

        public SQLDispatcherWithLogin()
        {
            sqlConnection = new SqlConnection(RifatDiplom.Properties.Settings.Default.DispatcherConn);
        }

        public int OpenSQLConn()
        {
            if (sqlConnection.State != ConnectionState.Open)
                sqlConnection.Open();

            if (sqlConnection.State == ConnectionState.Open)
                return 1;
            else
                return 0;
        }

        public DataTable SELECTDispatcher(int Id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM DispatcherTableData WHERE Id = @Id", sqlConnection);

            command.Parameters.Add("@Id", SqlDbType.Int);
            command.Parameters["@Id"].Value = Id;

            DispatcherAd = new SqlDataAdapter(command);
            DispatcherDS = new DataSet();
            DispatcherAd.Fill(DispatcherDS);
            return DispatcherDS.Tables[0];
        }
        public DataTable SELECTLogin(string Login, string Password)
        {
            SqlCommand command = new SqlCommand ("SELECT * FROM LoginTable WHERE Login = @Login AND Password = @Password", sqlConnection);
            command.Parameters.Add("@Login", SqlDbType.NVarChar, 25);
            command.Parameters["@Login"].Value = Login;

            command.Parameters.Add("@Password", SqlDbType.NVarChar, 25);
            command.Parameters["@Password"].Value = Password;

            LoginAd = new SqlDataAdapter(command);
            LoginDS = new DataSet();
            LoginAd.Fill(LoginDS);
            return LoginDS.Tables[0];
        }
        //public int UPDATEOrder()
        //{
        //    int state = 0;

        //    SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(OrderAd);
        //    state = OrderAd.Update(OrderDS, OrderDS.Tables[0].TableName);

        //    return state;
        //}
        //public int INSERTOrder(string PointA, string PointB, int Price, int Id_OrderStatus, int id_Driver, string date, string time)
        //{
        //    int state = 0;

        //    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(OrderAd);

        //    OrderAd.InsertCommand = new SqlCommand("INSERT INTO [Orders] " +
        //        "([PointA], [PointB], [Price], [Id_OrderStatus], [id_Driver], [TimeCreate], [DateCreate]) VALUES " +
        //        "(@PointA,  @PointB,  @Price,  @Id_OrderStatus,  @id_Driver,  @TimeCreate, @DateCreate)", sqlConnection);

        //    OrderAd.InsertCommand.Parameters.Add("@PointA", SqlDbType.NVarChar, 50);
        //    OrderAd.InsertCommand.Parameters["@PointA"].Value = PointA;

        //    OrderAd.InsertCommand.Parameters.Add("@PointB", SqlDbType.NVarChar, 50);
        //    OrderAd.InsertCommand.Parameters["@PointB"].Value = PointB;

        //    OrderAd.InsertCommand.Parameters.Add("@Price", SqlDbType.Int);
        //    OrderAd.InsertCommand.Parameters["@Price"].Value = Price;

        //    OrderAd.InsertCommand.Parameters.Add("@Id_OrderStatus", SqlDbType.Int);
        //    OrderAd.InsertCommand.Parameters["@Id_OrderStatus"].Value = Id_OrderStatus;

        //    OrderAd.InsertCommand.Parameters.Add("@Id_Driver", SqlDbType.Int);

        //    if (id_Driver == 0)
        //        OrderAd.InsertCommand.Parameters["@id_Driver"].Value = DBNull.Value;
        //    else
        //        OrderAd.InsertCommand.Parameters["@id_Driver"].Value = (int)id_Driver;

        //    OrderAd.InsertCommand.Parameters.Add("@TimeCreate", SqlDbType.Time);
        //    OrderAd.InsertCommand.Parameters["@TimeCreate"].Value = time;

        //    OrderAd.InsertCommand.Parameters.Add("@DateCreate", SqlDbType.Date);
        //    OrderAd.InsertCommand.Parameters["@DateCreate"].Value = date;

        //    state = OrderAd.Update(OrderDS, OrderDS.Tables[0].TableName);

        //    return state;
        //}

        public void CloseSqlConn()
        {
            sqlConnection.Close();
        }
    }
}
