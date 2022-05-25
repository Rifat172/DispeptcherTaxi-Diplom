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
using RifatDiplom.Model.Dispatcher;

namespace RifatDiplom.Views
{
    public partial class FProfile : Form
    {
        int CurrentUserId = 0;
        bool FormChanged = false;
        public FProfile(int Id)
        {
            InitializeComponent();
            CurrentUserId = Id;
            LoadCurrentDistData();
        }

        private void LoadCurrentDistData()
        {
            SQLDispatcherWithLogin sqlDispatcher = new SQLDispatcherWithLogin();
            if (sqlDispatcher.OpenSQLConn() == 1)
            {
                try
                {
                    var cuurentDispTable = sqlDispatcher.SELECTDispatcher(CurrentUserId);
                    var currentDispRow = cuurentDispTable.Rows[0];
                    FirstName.Text = currentDispRow["FirstName"].ToString();
                    LastName.Text = currentDispRow["LastName"].ToString();
                    Patronymic.Text = currentDispRow["Patronymic"].ToString();
                    Email.Text = currentDispRow["Email"].ToString();
                    PhoneNumber.Text = currentDispRow["PhoneNumber"].ToString();
                    OfficeStreet.Text = currentDispRow["OfficeStreet"].ToString();
                    Status.Text = currentDispRow["Status"].ToString();

                    if (currentDispRow["Status"].ToString() == "admin")
                    {
                        ChangeForm();
                        LoadAllDispachers();
                    }
                    else
                    {
                        DefaultForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            sqlDispatcher.CloseSqlConn();
        }

        private void LoadAllDispachers()
        {
            SQLDispatcherWithLogin sqlDispatcher = new SQLDispatcherWithLogin();
            if (sqlDispatcher.OpenSQLConn() == 1)
            {
                CBSelectDispatcher.DataSource = sqlDispatcher.SELECTDispatcher();
                CBSelectDispatcher.DisplayMember = "FIO";
                CBSelectDispatcher.ValueMember = "Id";
            }
        }

        int HeightAdd = 90;
        private void ChangeForm()
        {
            this.Height += HeightAdd;
            EditPanel.Visible = true;
            FormChanged = true;
        }
        private void DefaultForm()
        {
            if (FormChanged)
            {
                FormChanged = false;
                this.Height -= HeightAdd;
                EditPanel.Visible = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataRowView SelectedUser = (DataRowView)CBSelectDispatcher.SelectedItem;
            int SelectedId = (int)SelectedUser["Id"];
            Form edit = new FEditDispatcherData(SelectedId);
            edit.ShowDialog();

        }
    }
}