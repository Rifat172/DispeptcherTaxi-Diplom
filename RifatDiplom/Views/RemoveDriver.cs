using RifatDiplom.Model.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RifatDiplom.Views
{
    public partial class RemoveDriver : Form
    {
        SQLDriverWithStatus sqlDriver = null;
        public RemoveDriver(SQLDriverWithStatus sql)
        {
            InitializeComponent();
            sqlDriver = sql;
        }

        private void RemoveDriver_Load(object sender, EventArgs e)
        {
            CBDriver.DataSource = sqlDriver.DriverDS.Tables[0];
            CBDriver.DisplayMember = "FIO";
            CBDriver.ValueMember = "Id";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataRowView SelectedUser = (DataRowView)CBDriver.SelectedItem;
            sqlDriver.DELETEDriver(SelectedUser);
        }
    }
}
