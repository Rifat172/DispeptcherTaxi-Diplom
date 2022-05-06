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

namespace RifatDiplom
{
    public partial class FAddOrder : Form
    {
        NewOrderClass NewOrder;
        DataTable ReadyDrivers;
        DelegateShowData DData;

        public FAddOrder(NewOrderClass _order, DataTable _ready, DelegateShowData data)
        {
            InitializeComponent();
            NewOrder = _order;
            ReadyDrivers = _ready;
            DData = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckValidDate())
            {
                NewOrder.PointA = tbFrom.Text;
                NewOrder.PointB = tbTo.Text;
                NewOrder.Price = GetPrice();
                NewOrder.IdDrivers = (int)cbDrivers.SelectedValue;
                DData(NewOrder);
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
            cbDrivers.DisplayMember = "NickName";
            cbDrivers.ValueMember = "Id";
            cbDrivers.DataSource = ReadyDrivers;
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
            if (String.IsNullOrWhiteSpace(tbFrom.Text) || String.IsNullOrWhiteSpace(tbTo.Text))
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
