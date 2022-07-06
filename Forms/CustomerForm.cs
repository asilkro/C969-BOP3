using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Silkroski_C969.DB;

namespace Silkroski_C969.Forms
{
    public partial class CustomerForm : Form
    {
        private MainScreen mainScreen;

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CxCancelBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelled, no changes made.", "CANCELLED");
            new MainScreen();
            this.Close();
        }

        private void CxSaveButton_Click(object sender, EventArgs e)
        {
            //TODO: Implement validation, save
            bool validated = ValidCxData();

            if (validated == true)
            {
                string CxName = this.CxNameTB.Text;
                string CxAddress1 = this.CxAddress1TB.Text;
                string CxAddress2 = this.CxAddress2TB.Text;
                string CxCity = this.CxCityTB.Text;
                string CxPostal = this.CxPostalTB.Text;
                string CxCountry = this.CxCountryTB.Text;
                string CreatedBy = "Database Management App";
                DateTime CreatedDateTime = DateTime.Now;
                string UpdatedBy = "Database Management App";
                DateTime UpdatedDateTime = DateTime.Now;

                int CxCountryID = 0;
                string CxCountryID_CMD = $"SELECT COUNTRYID FROM COUNTRY WHERE COUNTRY = '{CxCountry}";

                int CxCityID = 0;
                string CxCityID_CMD =
                    $"INSERT INTO CITY(CITY, COUNTRYID, CREATEDDATE, CREATEDBY, LASTUPDATE, LASTUPDATEDBY)" +
                    $"VALUES ('{CxCity}', '{CxCountryID}', '{CreatedDateTime}', '{CreatedBy}', '{UpdatedDateTime}', '{UpdatedBy}')";

                //Have to save
                string CxCommand = $"INSERT INTO "; // TODO: FINISH -> see scratch.txt 

                using (MySqlConnection conn = new MySqlConnection())
                {
                    conn.ConnectionString =
                        "Server=localhost;Database=client_schedule;User Id=test;Password=test;AllowBatch=true;";
                }
            }
            else
            {
                MessageBox.Show("Data error detected, please check your input.", "Data error detected");
            }
        }

        private bool ValidCxData()
        {
            bool isValid = true;
            var textBoxesToCheck = Controls.OfType<TextBox>().ToArray();
            foreach (var textBox in textBoxesToCheck)
            {
                if (textBox.Text.Length == 0)
                {
                    textBox.BackColor = Color.Crimson; // Red 
                    isValid = false;
                    break;
                }
            }

            if (isValid != true)
            {
                MessageBox.Show("Unable to save. Please check your data and retry.",
                    "Data validation error");
                return false;
            }

            return true;
        }
    }
}
