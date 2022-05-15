﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace RifatDiplom.Model.Driver
{
    public class SQLDriverWithStatus
    {
        private SqlConnection sqlConnection = null;

        private SqlDataAdapter DriverAd = null;
        private SqlDataAdapter StatusAd = null;

        private DataSet DriverDS = null;
        private DataSet StatusDS = null;

        public SQLDriverWithStatus()
        {
            sqlConnection = new SqlConnection(RifatDiplom.Properties.Settings.Default.OrderConn);
        }

        public int OpenSQLConn()
        {
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
                return 1;
            else
                return 0;
        }
        public DataTable SELECTDriver()
        {
            string command = "SELECT * FROM Drivers";
            DriverAd = new SqlDataAdapter(command, sqlConnection);
            DriverDS = new DataSet();
            DriverAd.Fill(DriverDS);
            return DriverDS.Tables[0];
        }
        public DataTable SELECTStatus()
        {
            string command = "SELECT * FROM DriverStatus";
            StatusAd = new SqlDataAdapter(command, sqlConnection);
            StatusDS = new DataSet();
            StatusAd.Fill(StatusDS);
            return StatusDS.Tables[0];
        }
        public int UPDATEDriver()
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(DriverAd);
            return DriverAd.Update(DriverDS, DriverDS.Tables[0].TableName);
        }

        public void CloseSqlConn()
        {
            sqlConnection.Close();
        }
    }
}