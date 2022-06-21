using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RifatDiplom.Model;
using RifatDiplom.Model.Driver;
using RifatDiplom.Model.Order;

namespace RifatDiplom
{
    public partial class FAddOrder : Form
    {
        SQLDriverWithStatus Driver = null;
        SQLOrderWithStatus Order = null;

        public FAddOrder(SQLDriverWithStatus _Driver, SQLOrderWithStatus _Order)
        {
            InitializeComponent();
            Driver = _Driver;
            Order = _Order;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckValidDate())
            {
                DataRow row = Order.OrderDS.Tables[0].NewRow();
                Order.OrderDS.Tables[0].Rows.Add(row);

                DataRow DriverRow = null;
                if ((DataRowView)cbDrivers.SelectedItem != null)
                    DriverRow = ((DataRowView)cbDrivers.SelectedItem).Row;
                DataRowView OrderStatus = (DataRowView)cbStatus.SelectedItem;

                int Id_Driver = 0;
                if (DriverRow != null)
                {
                    Id_Driver = (int)DriverRow["Id"];
                    if ((int)OrderStatus["Id"] == 2)
                    {
                        DriverRow["Id_Status"] = 2;
                        Driver.UPDATEDriver();
                    }
                }

                var state = Order.INSERTOrder(tbFrom.Text, tbTo.Text, GetPrice(), (cbStatus.SelectedIndex + 1), Id_Driver, DateTime.Now.ToString("d"), DateTime.Now.ToLongTimeString(), PhoneNumber.Text);
                Order.OrderDS.AcceptChanges();
                this.Close();
            }
        }

        private int GetPrice()
        {
            if (cbCity.Checked)
            {
                return 70;
            }
            if (cbArea.Checked)
            {
                return 160;
            }
            if (cbRegion.Checked)
            {
                return 570;
            }
            return -1;
        }

        private void FAddOrder_Load(object sender, EventArgs e)
        {
            DataView dvDriver = new DataView(Driver.DriverDS.Tables[0]);
            dvDriver.RowFilter = "Id_Status = 1";

            DataView dvStatus = new DataView(Order.StatusDS.Tables[0]);

            cbDrivers.DisplayMember = "NickName";
            cbDrivers.ValueMember = "Id";
            cbDrivers.DataSource = dvDriver;

            cbStatus.DisplayMember = "Status";
            cbStatus.ValueMember = "Id";
            if (dvDriver.Count > 0)
            {
                dvStatus.RowFilter = "Id = 1 OR Id = 2 OR Id = 4";
                cbStatus.DataSource = dvStatus;
            }
            else
            {
                dvStatus.RowFilter = "Id = 1 OR Id = 4";
                cbStatus.DataSource = dvStatus;
            }
        }

        private bool CheckValidDate()
        {
            bool Valid = false;
            if (cbCity.Checked == cbArea.Checked && cbArea.Checked == cbRegion.Checked)
            {
                LWarning.Visible = true;
                Valid = false;
            }
            else
            {
                LWarning.Visible = false;
                Valid = false;
            }
            if (String.IsNullOrWhiteSpace(tbFrom.Text) || String.IsNullOrWhiteSpace(tbTo.Text) || String.IsNullOrWhiteSpace(PhoneNumber.Text) || tbFrom.Text.Length > 50 || tbTo.Text.Length > 50 || PhoneNumber.Text.Length > 20)
            {
                LWarningPoint.Visible = true;
                Valid = false;
            }
            else
            {
                LWarningPoint.Visible = false;
                Valid = true;
            }
            return Valid;
        }
    }
}
