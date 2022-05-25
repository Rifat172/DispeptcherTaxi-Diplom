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
        SQLDispatcherWithLogin sqlDispatcher = null;
        int CurrentUserId = 0;
        public FSignIn()
        {
            InitializeComponent();
        }
        private void bsubmit_Click(object sender, EventArgs e)
        {
            sqlDispatcher = new SQLDispatcherWithLogin();

            if (sqlDispatcher.OpenSQLConn() == 1)
            {
                DataTable Login = sqlDispatcher.SELECTLogin(tbLogin.Text, tbPassword.Text);
                if(Login.Rows.Count == 0)
                {
                    label2.Visible = true;
                    return;
                }
                else
                {
                    label2.Visible = false;
                    CurrentUserId = (int)Login.Rows[0]["Id"];
                }
            }
            sqlDispatcher.CloseSqlConn();

            Form enter = new FMain(CurrentUserId);
            enter.Show();
            this.Hide();
        }
    }
}