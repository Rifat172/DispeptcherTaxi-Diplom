using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace RifatDiplom.Model.Driver
{
    public class SQLDriverWithStatus
    {
        private SqlConnection sqlConnection = null;

        private SqlDataAdapter DriverAd = null;
        private SqlDataAdapter StatusAd = null;

        private DataSet _DriverDS = null;
        private DataSet _StatusDS = null;

        public DataSet DriverDS { get => _DriverDS; set => _DriverDS = value; }
        public DataSet StatusDS { get => _StatusDS; set => _StatusDS = value; }

        public SQLDriverWithStatus()
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
        public DataTable SELECTDriver()
        {
            string command = "SELECT * FROM Drivers";
            DriverAd = new SqlDataAdapter(command, sqlConnection);
            DriverDS = new DataSet();
            DriverAd.Fill(DriverDS);
            return DriverDS.Tables[0];
        }
        public DataTable SELECTStatus()
        {
            string command = "SELECT * FROM DriverStatus";
            StatusAd = new SqlDataAdapter(command, sqlConnection);
            StatusDS = new DataSet();
            StatusAd.Fill(StatusDS);
            return StatusDS.Tables[0];
        }
        public int UPDATEDriver()
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(DriverAd);
            return DriverAd.Update(DriverDS, DriverDS.Tables[0].TableName);
        }
        public int INSERTDriver(string FirstName, string SecondName, string ThirdName, string NickName, string Car, int Pevenue, int Id_Status, string PhoneNumber)
        {
            int state = 0;

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(DriverAd);

            DriverAd.InsertCommand = new SqlCommand("INSERT INTO [Drivers] " +
                "(FirstName, SecondName, ThirdName, NickName, Car, Pevenue, Id_Status, PhoneNumber) VALUES " +
                "(@FirstName, @SecondName, @ThirdName, @NickName, @Car, @Pevenue, @Id_Status, @PhoneNumber)", sqlConnection);

            DriverAd.InsertCommand.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50);
            DriverAd.InsertCommand.Parameters["@FirstName"].Value = FirstName;

            DriverAd.InsertCommand.Parameters.Add("@SecondName", SqlDbType.NVarChar, 50);
            DriverAd.InsertCommand.Parameters["@SecondName"].Value = SecondName;

            DriverAd.InsertCommand.Parameters.Add("@ThirdName", SqlDbType.NVarChar, 50);
            if (string.IsNullOrWhiteSpace(ThirdName))
                DriverAd.InsertCommand.Parameters["@ThirdName"].Value = DBNull.Value;
            else
                DriverAd.InsertCommand.Parameters["@ThirdName"].Value = ThirdName;

            DriverAd.InsertCommand.Parameters.Add("@NickName", SqlDbType.NVarChar, 50);
            DriverAd.InsertCommand.Parameters["@NickName"].Value = NickName;

            DriverAd.InsertCommand.Parameters.Add("@Car", SqlDbType.NVarChar, 50);
            DriverAd.InsertCommand.Parameters["@Car"].Value = Car;

            DriverAd.InsertCommand.Parameters.Add("@Pevenue", SqlDbType.Int);
            DriverAd.InsertCommand.Parameters["@Pevenue"].Value = Pevenue;

            DriverAd.InsertCommand.Parameters.Add("@Id_Status", SqlDbType.Int);
            DriverAd.InsertCommand.Parameters["@Id_Status"].Value = Id_Status;

            DriverAd.InsertCommand.Parameters.Add("@PhoneNumber", SqlDbType.VarChar, 25);
            DriverAd.InsertCommand.Parameters["@PhoneNumber"].Value = PhoneNumber;

            state = DriverAd.Update(DriverDS, DriverDS.Tables[0].TableName);

            return state;
        }

        public void CloseSqlConn()
        {
            sqlConnection.Close();
        }
    }
}