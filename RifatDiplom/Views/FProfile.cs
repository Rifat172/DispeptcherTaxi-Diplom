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

namespace RifatDiplom.Views
{
    public partial class FProfile : Form
    {
        int Id;
        public FProfile(int _Id)
        {
            InitializeComponent();
            Id = _Id;
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.DispatcherConn))
            {
                string sql = "SELECT * FROM DispatcherTableData WHERE Id = @Id";
                using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    sqlCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
                    sqlCommand.Parameters["@Id"].Value = Id;

                    try
                    {
                        connection.Open();
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            dataReader.Read();
                            FirstName.Text = dataReader["FirstName"].ToString();
                            LastName.Text = dataReader["LastName"].ToString();
                            Patronymic.Text = dataReader["Patronymic"].ToString();
                            Email.Text = dataReader["Email"].ToString();
                            PhoneNumber.Text = dataReader["PhoneNumber"].ToString();
                            OfficeStreet.Text = dataReader["OfficeStreet"].ToString();
                            Status.Text = dataReader["Status"].ToString();
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
        }
    }
}
