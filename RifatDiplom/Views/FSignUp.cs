using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RifatDiplom.Model.Dispatcher;

namespace RifatDiplom
{
    public partial class FSignUp : Form
    {
        public FSignUp()
        {
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CBStatus.SelectedIndex.ToString());
            MessageBox.Show(CBStatus.SelectedItem.ToString());
            if (CheckValidData())
            {
                SQLDispatcherWithLogin sqlDispatcher = new SQLDispatcherWithLogin();
                if (sqlDispatcher.OpenSQLConn() == 1)
                {
                    sqlDispatcher.INSERTDispatcher(FirstName.Text, LastName.Text, Patronymic.Text, Email.Text, PhoneNumber.Text, OfficeStreet.Text, CBStatus.SelectedItem.ToString(), Login.Text, Password.Text);
                }
            }
        }

        private bool CheckValidData()
        {
            if (!String.IsNullOrWhiteSpace(FirstName.Text) && !string.IsNullOrWhiteSpace(LastName.Text) && !string.IsNullOrWhiteSpace(Email.Text) && !string.IsNullOrWhiteSpace(PhoneNumber.Text) && !string.IsNullOrWhiteSpace(OfficeStreet.Text) && !string.IsNullOrWhiteSpace(Login.Text) && !string.IsNullOrWhiteSpace(Password.Text) && CBStatus.SelectedIndex != -1)
            {
                WarningL.Visible = false;
                return true;
            }
            WarningL.Visible = true;
            return false;
        }

        private void FSignUp_Load(object sender, EventArgs e)
        {
            CBStatus.SelectedText = "";
        }
    }
}
