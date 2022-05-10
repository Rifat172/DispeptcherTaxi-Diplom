using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RifatDiplom.Model.Driver
{
    public class SQLDriverWithStatus
    {
        private SqlConnection sqlConnection = null;

        public SQLDriverWithStatus()
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
        public DataTable SELECTDriver()
        {
            return GETDataSetUsingSqlDataAdapter("SELECT * FROM Drivers").Tables[0];
        }
        public DataTable SELECTStatus()
        {
            return GETDataSetUsingSqlDataAdapter("SELECT * FROM DriverStatus").Tables[0];
        }
        private DataSet GETDataSetUsingSqlDataAdapter(string command)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command, sqlConnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet;
        }
    }
}
