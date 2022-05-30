using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RifatDiplom.Model.Driver;

namespace RifatDiplom.Views
{
    public partial class FAddDriver : Form
    {
        SQLDriverWithStatus sqlDrivers = null;
        public FAddDriver(SQLDriverWithStatus _Driver)
        {
            InitializeComponent();
            sqlDrivers = _Driver;
        }

        private bool CheckValidData()
        {
            if (!String.IsNullOrWhiteSpace(FirstName.Text) && !string.IsNullOrWhiteSpace(SecondName.Text) && !string.IsNullOrWhiteSpace(NickName.Text) && !string.IsNullOrWhiteSpace(Car.Text) && !string.IsNullOrWhiteSpace(PhoneNumber.Text) && CBStatus.SelectedIndex != -1)
            {
                WarningL.Visible = false;
                return true;
            }
            WarningL.Visible = true;
            return false;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (CheckValidData())
            {
                DataRow newrow = sqlDrivers.DriverDS.Tables[0].NewRow();
                sqlDrivers.DriverDS.Tables[0].Rows.Add(newrow);

                if (sqlDrivers.INSERTDriver(FirstName.Text, SecondName.Text, ThirdName.Text, NickName.Text, Car.Text, 0, (CBStatus.SelectedIndex + 1), PhoneNumber.Text) == 1)
                {
                    MessageBox.Show("Данные добавлены", "Успешно");
                }
                else
                {
                    MessageBox.Show("Данные не добавлены", "Предупреждение");
                }
                this.Hide();
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
