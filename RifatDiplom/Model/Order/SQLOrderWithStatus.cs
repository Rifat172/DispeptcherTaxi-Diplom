using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RifatDiplom.Model.Order
{
    public class SQLOrderWithStatus
    {
        private SqlConnection sqlConnection = null;

        private SqlDataAdapter OrderAd = null;
        private SqlDataAdapter StatusAd = null;

        private DataSet _OrderDS = null;
        private DataSet _StatusDS = null;

        public DataSet OrderDS { get => _OrderDS; set => _OrderDS = value; }
        public DataSet StatusDS { get => _StatusDS; set => _StatusDS = value; }

        public SQLOrderWithStatus()
        {
            sqlConnection = new SqlConnection(RifatDiplom.Properties.Settings.Default.OrderConn);
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

        public DataTable SELECTOrder()
        {
            string command = "SELECT * FROM Orders";
            OrderAd = new SqlDataAdapter(command, sqlConnection);
            OrderDS = new DataSet();
            OrderAd.Fill(OrderDS);
            return OrderDS.Tables[0];
        }
        public DataTable SELECTStatus()
        {
            string command = "SELECT * FROM OrderStatus";
            StatusAd = new SqlDataAdapter(command, sqlConnection);
            StatusDS = new DataSet();
            StatusAd.Fill(StatusDS);
            return StatusDS.Tables[0];
        }
        public int UPDATEOrder()
        {
            int state = 0;

            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(OrderAd);
            state = OrderAd.Update(OrderDS, OrderDS.Tables[0].TableName);

            return state;
        }
        public int INSERTOrder(string PointA, string PointB, int Price, int Id_OrderStatus, int id_Driver, string date, string time)
        {
            int state = 0;

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(OrderAd);

            OrderAd.InsertCommand = new SqlCommand("INSERT INTO [Orders] " +
                "([PointA], [PointB], [Price], [Id_OrderStatus], [id_Driver], [TimeCreate], [DateCreate]) VALUES " +
                "(@PointA,  @PointB,  @Price,  @Id_OrderStatus,  @id_Driver,  @TimeCreate, @DateCreate)", sqlConnection);

            OrderAd.InsertCommand.Parameters.Add("@PointA", SqlDbType.NVarChar, 50);
            OrderAd.InsertCommand.Parameters["@PointA"].Value = PointA;

            OrderAd.InsertCommand.Parameters.Add("@PointB", SqlDbType.NVarChar, 50);
            OrderAd.InsertCommand.Parameters["@PointB"].Value = PointB;

            OrderAd.InsertCommand.Parameters.Add("@Price", SqlDbType.Int);
            OrderAd.InsertCommand.Parameters["@Price"].Value = Price;

            OrderAd.InsertCommand.Parameters.Add("@Id_OrderStatus", SqlDbType.Int);
            OrderAd.InsertCommand.Parameters["@Id_OrderStatus"].Value = Id_OrderStatus;

            OrderAd.InsertCommand.Parameters.Add("@Id_Driver", SqlDbType.Int);

            if (id_Driver == 0)
                OrderAd.InsertCommand.Parameters["@id_Driver"].Value = DBNull.Value;
            else
                OrderAd.InsertCommand.Parameters["@id_Driver"].Value = (int)id_Driver;

            OrderAd.InsertCommand.Parameters.Add("@TimeCreate", SqlDbType.Time);
            OrderAd.InsertCommand.Parameters["@TimeCreate"].Value = time;

            OrderAd.InsertCommand.Parameters.Add("@DateCreate", SqlDbType.Date);
            OrderAd.InsertCommand.Parameters["@DateCreate"].Value = date;

            state = OrderAd.Update(OrderDS, OrderDS.Tables[0].TableName);

            return state;
        }

        public void CloseSqlConn()
        {
            sqlConnection.Close();
        }
    }
}
