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

        private DataSet OrderDS = null;
        private DataSet StatusDS = null;

        public SQLOrderWithStatus()
        {
            sqlConnection = new SqlConnection(RifatDiplom.Properties.Settings.Default.OrderConn);
        }

        public int OpenSQLConn()
        {
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
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(OrderAd);
            return OrderAd.Update(OrderDS, OrderDS.Tables[0].TableName);
        }

        public void CloseSqlConn()
        {
            sqlConnection.Close();
        }
    }
}
