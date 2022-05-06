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

namespace RifatDiplom
{
    public partial class FSignIn : Form
    {
        bool IsAdmin = false;
        public FSignIn()
        {
            InitializeComponent();
        }

        private void bsubmit_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\projects\RifatDiplom\RifatDiplom\Data\DispatcherData.mdf;Integrated Security=True"))
            {
                string sql = "SELECT * FROM LoginTable WHERE Login = @uL AND Password = @uP";
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
                            if(!dataReader.HasRows)
                            {
                                label2.Visible = true;
                                return;
                            }
                            dataTable.Load(dataReader);
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
            IsAdmin = dataTable.Rows[0].ItemArray[3].ToString() == "adm" ? true : false;
            Form enter = new FMain(IsAdmin);
            enter.Show();
            this.Hide();
        }
    }
}