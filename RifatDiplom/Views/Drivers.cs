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
    public partial class Drivers : Form
    {
        SQLDriverWithStatus sqlDriver = null;
        public Drivers(SQLDriverWithStatus sql)
        {
            InitializeComponent();
            sqlDriver = sql;
        }

        private void Drivers_Load(object sender, EventArgs e)
        {
            dgvDriver.AutoGenerateColumns = false;

            cbStatus.DisplayMember = "Status";
            cbStatus.ValueMember = "Id";
            cbStatus.DataSource = sqlDriver.StatusDS.Tables[0];

            dgvDriver.DataSource = sqlDriver.DriverDS.Tables[0];
        }
    }
}
