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

namespace RifatDiplom.Views
{
    public partial class FEditDispatcherData : Form
    {
        //SQLDispatcherWithLogin sqlDispatcher = null;
        //DataRowView SelectedUser = null;
        //DataRow SelectedLogin = null;
        int SelectedId = 0;
        public FEditDispatcherData(int Id)
        {
            InitializeComponent();
            SelectedId = Id;
            LoadData();
        }

        private void LoadData()
        {
            SQLDispatcherWithLogin sqlDispatcher = new SQLDispatcherWithLogin();

            if (sqlDispatcher.OpenSQLConn() == 1)
            {
                var SelectedDispatcherTable = sqlDispatcher.SELECTDispatcher(SelectedId);
                var SelectedLoginTable = sqlDispatcher.SELECTLogin(SelectedId);

                var SelectedDispatcherRow = SelectedDispatcherTable.Rows[0];
                //var SelectedLoginRow = SelectedLoginTable.Rows[0];

                FirstName.Text = SelectedDispatcherRow["FirstName"].ToString();
                LastName.Text = SelectedDispatcherRow["LastName"].ToString();
                Patronymic.Text = SelectedDispatcherRow["Patronymic"].ToString();

                //Login.Text = SelectedLogin["Login"].ToString();
                //Password.Text = SelectedLogin["Password"].ToString();
                Login.DataBindings.Add("Text", SelectedLoginTable, "Login");
                Password.DataBindings.Add("Text", SelectedLoginTable, "Password");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SQLDispatcherWithLogin sqlDispatcher = new SQLDispatcherWithLogin();
            if (sqlDispatcher.OpenSQLConn() == 1)
            {
                var state = sqlDispatcher.UPDATELogin(Login.Text, Password.Text, SelectedId);
                if (state == 0)
                {
                    MessageBox.Show("Данные не были изменены", "Предупреждение");
                }
                else
                {
                    MessageBox.Show("Данные сохранены", "Успешно");
                }
            }
            sqlDispatcher.CloseSqlConn();
        }
    }
}
