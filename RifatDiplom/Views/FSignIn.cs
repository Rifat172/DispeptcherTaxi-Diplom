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
    public partial class FSignIn : Form
    {
        object Status;
        bool IsAdmin = false;
        public FSignIn()
        {
            InitializeComponent();
        }
        private void bsubmit_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.DispatcherConn))
            {
                string sql = "SELECT L.Id, L.Login, L.Password, D.Status FROM LoginTable as L inner join DispatcherTableData as D ON L.Id = D.Id WHERE L.Login = @uL AND L.Password = @uP";
                using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    sqlCommand.Parameters.Add(new SqlParameter("@uL", SqlDbType.NVarChar, 25));
                    sqlCommand.Parameters["@uL"].Value = tbLogin.Text;
                    sqlCommand.Parameters.Add(new SqlParameter("@uP", SqlDbType.NVarChar, 25));
                    sqlCommand.Parameters["@uP"].Value = tbPassword.Text;

                    try
                    {
                        connection.Open();
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            if (!dataReader.HasRows)
                            {
                                label2.Visible = true;
                                return;
                            }
                            dataReader.Read();
                            Status = dataReader["Status"];
                            dataReader.Close();
                        }
                    }
                    catch (Exception ex)
                    { 
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        // Close connection.
                        connection.Close();
                    }
                }
            }
            IsAdmin = Status.ToString() == "admin" ? true : false;
            Form enter = new FMain(IsAdmin);
            enter.Show();
            this.Hide();
        }
    }
}