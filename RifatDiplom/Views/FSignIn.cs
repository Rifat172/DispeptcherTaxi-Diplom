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
using RifatDiplom.Model.Dispatcher;

namespace RifatDiplom
{
    public partial class FSignIn : Form
    {
        object Status;
        int Id;
        bool IsAdmin = false;

        SQLDispatcherWithLogin sqlDispatcher = null;
        public FSignIn()
        {
            InitializeComponent();
        }
        private void bsubmit_Click(object sender, EventArgs e)
        {
            sqlDispatcher = new SQLDispatcherWithLogin();

            if (sqlDispatcher.OpenSQLConn() == 1)
            {
                var Login = sqlDispatcher.SELECTLogin(tbLogin.Text, tbPassword.Text);
                if(Login.Rows.Count == 0)
                {
                    label2.Visible = true;
                }
                else
                {
                    label2.Visible = false;

                    DataRow Ldata = Login.Rows[0];
                    Id = (int)Ldata["Id"];
                    var Dispather = sqlDispatcher.SELECTDispatcher(Id);

                    DataRow Ldis = Dispather.Rows[0];
                    if ((string)Ldis["Status"] == "Admin")
                    {
                        IsAdmin = true;
                    }
                    else
                    {
                        IsAdmin = false;
                    }
                }
            }
            sqlDispatcher.CloseSqlConn();

            Form enter = new FMain(Id, IsAdmin);
            enter.Show();
            this.Hide();
        }
    }
}