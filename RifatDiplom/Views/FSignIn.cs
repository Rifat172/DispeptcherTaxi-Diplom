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

        private bool CheckValidData()
        {
            if (!String.IsNullOrWhiteSpace(tbLogin.Text) && !string.IsNullOrWhiteSpace(tbPassword.Text) || tbLogin.Text.Length > 25 || tbPassword.Text.Length > 25)
            {
                WarningL.Visible = false;
                return true;
            }
            WarningL.Visible = true;
            return false;
        }
        private void bsubmit_Click(object sender, EventArgs e)
        {
            if (CheckValidData())
            {
                sqlDispatcher = new SQLDispatcherWithLogin();
                if (sqlDispatcher.OpenSQLConn() == 1)
                {
                    DataTable Login = sqlDispatcher.SELECTLogin(tbLogin.Text, tbPassword.Text);
                    if (Login.Rows.Count == 0)
                    {
                        WarningL.Visible = true;
                        return;
                    }
                    else
                    {
                        WarningL.Visible = false;
                        CurrentUserId = (int)Login.Rows[0]["Id"];
                    }
                }
                sqlDispatcher.CloseSqlConn();

                Form enter = new FMain(CurrentUserId);
                enter.Show();
                this.Hide();
            }
        }

        private void checkB_CheckedChanged(object sender, EventArgs e)
        {
            if (checkB.Checked)
                tbPassword.PasswordChar = '\0';
            else
                tbPassword.PasswordChar = '*';
        }
    }
}