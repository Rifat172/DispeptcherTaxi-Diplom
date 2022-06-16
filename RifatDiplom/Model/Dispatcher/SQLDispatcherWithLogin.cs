using System;
using System.Data;
using System.Data.SqlClient;

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
        /// <summary>
        /// Выборка нужного диспетчера
        /// </summary>
        /// <param name="Id">Id конкретного диспетчера</param>
        /// <returns></returns>
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
        /// <summary>
        /// Выборка из всех диспетчеров
        /// </summary>
        /// <returns></returns>
        public DataTable SELECTDispatcher()
        {
            //Запрос в котором отображается фио как одна строка. Поиск ведется только для пользователей с правами 'user'
            SqlCommand command = new SqlCommand("SET CONCAT_NULL_YIELDS_NULL OFF; SELECT Id, FirstName +' ' + LastName + ' ' + Patronymic as FIO, * FROM DispatcherTableData WHERE Status = 'User'; SET CONCAT_NULL_YIELDS_NULL ON;", sqlConnection);
            DispatcherAd = new SqlDataAdapter(command);
            DispatcherDS = new DataSet();
            DispatcherAd.Fill(DispatcherDS);
            return DispatcherDS.Tables[0];
        }
        public DataTable SELECTLogin(int Id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM LoginTable WHERE Id = @Id", sqlConnection);
            command.Parameters.Add("@Id", SqlDbType.Int);
            command.Parameters["@Id"].Value = Id;

            LoginAd = new SqlDataAdapter(command);
            LoginDS = new DataSet();
            LoginAd.Fill(LoginDS);
            return LoginDS.Tables[0];
        }
        public DataTable SELECTLogin(string Login, string Password)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM LoginTable WHERE Login = @Login AND Password = @Password", sqlConnection);
            command.Parameters.Add("@Login", SqlDbType.NVarChar, 25);
            command.Parameters["@Login"].Value = Login;

            command.Parameters.Add("@Password", SqlDbType.NVarChar, 25);
            command.Parameters["@Password"].Value = Password;

            LoginAd = new SqlDataAdapter(command);
            LoginDS = new DataSet();
            LoginAd.Fill(LoginDS);
            return LoginDS.Tables[0];
        }
        public int UPDATELogin(string Login, string Password, int Id)
        {
            int state = 0;

            SqlCommand update = new SqlCommand("UPDATE LoginTable SET Login = @Login, Password = @Password WHERE Id = @Id", sqlConnection);

            update.Parameters.Add("Login", SqlDbType.NVarChar, 25);
            update.Parameters["Login"].Value = Login;
            update.Parameters.Add("Password", SqlDbType.NVarChar, 25);
            update.Parameters["Password"].Value = Password;
            update.Parameters.Add("Id", SqlDbType.Int);
            update.Parameters["Id"].Value = Id;

            state = update.ExecuteNonQuery();

            return state;
        }
        public int INSERTDispatcher(string FirstName, string LastName, string Patronymic, string Email, string PhoneNumber, string OfficeStreet, string Status, string Login, string Password)
        {
            int state = 0;

            string command = "INSERT INTO DispatcherTableData ([FirstName],[LastName],[Patronymic],[Email],[PhoneNumber],[OfficeStreet],[Status]) VALUES(@FirstName,  @LastName,  @Patronymic,  @Email, @PhoneNumber, @OfficeStreet, @Status); INSERT INTO LoginTable([Login],[Password]) VALUES(@Login, @Password);";
            SqlCommand insert = new SqlCommand(command, sqlConnection);

            insert.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50);
            insert.Parameters["@FirstName"].Value = FirstName;

            insert.Parameters.Add("@LastName", SqlDbType.NVarChar, 50);
            insert.Parameters["@LastName"].Value = LastName;

            insert.Parameters.Add("@Patronymic", SqlDbType.NVarChar, 50);
            if (!String.IsNullOrWhiteSpace(Patronymic))
            {
                insert.Parameters["@Patronymic"].Value = Patronymic;
            }
            else
            {
                insert.Parameters["@Patronymic"].Value = DBNull.Value;
            }

            insert.Parameters.Add("@Email", SqlDbType.NVarChar, 50);
            insert.Parameters["@Email"].Value = Email;

            insert.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar, 50);
            insert.Parameters["@PhoneNumber"].Value = PhoneNumber;

            insert.Parameters.Add("@OfficeStreet", SqlDbType.NVarChar, 50);
            insert.Parameters["@OfficeStreet"].Value = OfficeStreet;

            insert.Parameters.Add("@Status", SqlDbType.NVarChar, 50);
            insert.Parameters["@Status"].Value = Status;

            insert.Parameters.Add("@Login", SqlDbType.NVarChar, 50);
            insert.Parameters["@Login"].Value = Login;

            insert.Parameters.Add("@Password", SqlDbType.NVarChar, 50);
            insert.Parameters["@Password"].Value = Password;

            state = insert.ExecuteNonQuery();

            return state;
        }

        public void CloseSqlConn()
        {
            sqlConnection.Close();
        }
    }
}
