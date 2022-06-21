using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Silkroski_C969.Models;
using Silkroski_C969.DB;
using Silkroski_C969.Properties;
using Silkroski_C969;

namespace Silkroski_C969.Forms
{
    public partial class LoginScreen : Form
    {
        public string Language => _language; // Getter-only property keeps connection safe, lambda for ease of reading
        private string _language;

        private MySqlConnection connection = new MySqlConnection();
        
        #region Constructors
        public LoginScreen()
        {
            InitializeComponent();
            SetLanguage();
            TimeSaver();
        }

        public LoginScreen(MainScreen mainScreen)
        {
            InitializeComponent();
            SetLanguage();
            TimeSaver();
            mainScreen.Hide();
        }

        private void TimeSaver() //TODO: REMOVE THIS BEFORE SHIPPING
        {
            UserField.Text = "test";
            PasswordField.Text = "test";
        }

        #endregion

        #region Methods

        private void FieldsClear()
        {
            UserField.Text = null;
            PasswordField.Text = null;
        }

        public User UserToLogin() // TODO: Build out check
        {
            string userName = UserField.Text;
            string password = PasswordField.Text;
            User loginInfo = new User(userName, password, 1);

            return loginInfo;
        }

        public bool IsValidLogin()
        {
            // Setup
            string userName = UserField.Text;
            string password = PasswordField.Text;
            MySqlCommand queryLogin = new MySqlCommand("SELECT userName, password FROM user WHERE userName IS '%" +
                                                       userName + "AND password IS '%" + password);
            // Check against DB
            connection.Clone();
            if (queryLogin.ExecuteNonQuery() == 1)
            {
                using (StreamWriter writer = File.AppendText(Log.logpath))
                {
                    writer.WriteLine("User: " + userName + " logged in at: " + System.DateTime.UtcNow + " UTC.\n");
                    return true;
                }
            }
            else
            {
                using (StreamWriter writer = File.AppendText(Log.logpath))
                {
                    writer.WriteLine("User: " + userName + " failed to login at: " + System.DateTime.UtcNow + " UTC.\n");
                    return false;
                }
            }
            

        }

        #endregion


        #region Languages / Sprache //TODO: Add error messages in German

        private void SetLanguage()
        {
            switch (RegionInfo.CurrentRegion.EnglishName)
            {
                case "United States":
                    SetToEnglish();
                    _language = "US-EN";
                    break;

                case "Germany":
                    SetToGerman();
                    _language = "DE-DE";
                    break;

                default:
                    SetToEnglish();
                    break;

            }
        }

        public void SetToGerman()
        {
            UserIDLabel.Text = "Benutzer-ID";
            PasswordLabel.Text = "Passwort";
            LoginBtn.Text = "Anmelden";
            ClearBtn.Text = "Leeren";
            ExitBtn.Text = "Schließen";
        }

        public void SetToEnglish()
        {
            UserIDLabel.Text = "UserID";
            PasswordLabel.Text = "Password";
            LoginBtn.Text = "Login";
            ClearBtn.Text = "Clear";
            ExitBtn.Text = "Exit";
        }

        public void Fehlerbehandlung() // Generic message in German
        {
            //TODO: Error handling language in German
            MessageBox.Show("Bei Ihrer Anwendung ist ein Fehler aufgetreten.", "Fehlermeldung");
        }

        public void ErrorHandling() // Generic message in English
        {
            //TODO: Error handling language in English
            MessageBox.Show("Your application encountered an error.", "Error Message");
        }

        #endregion


        #region Events

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            UserToLogin();
            OnLoginButtonClick();
            this.Close();
        }

        private void ExitBtnClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            FieldsClear();
        }

        private void OnLoginButtonClick()
        {
            if (Language == "DE-DE" && UserField.Text.Length == 0)
            {
                MessageBox.Show("Bitte geben Sie einen Benutzernamen ein",
                    "Benutzername ist nicht vorhanden");
            }
            else if (Language == "DE-DE" && PasswordField.Text.Length == 0)
            {
                MessageBox.Show("Bitte Passwort eingeben",
                    "Leeres Passwortfeld");
            }
            else if (Language == "DE-DE")
            {
                try
                {
                    MainScreen.Instance.OnLoginSubmitted(UserField.Text, PasswordField.Text);
                    //TODO: log attempt and result
                    Log.LogMessage(UserField.Text, true);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Fehlerbehandlung(); //TODO: More useful error
                    Log.LogMessage(UserField.Text, false);
                    throw;
                }
            }
            else if (Language == "US-EN" && UserField.Text.Length == 0)
            {
                MessageBox.Show("Please enter a username",
                    "Username is not present");
            }
            else if (Language == "US-EN" && PasswordField.Text.Length == 0)
            {
                MessageBox.Show("Please enter a password",
                    "Empty password field");
            }
            else if (Language == "US-EN")
            {
                try
                {
                    MainScreen.Instance.OnLoginSubmitted(UserField.Text, PasswordField.Text);
                    //TODO: log attempt and result
                    Log.LogMessage(UserField.Text, true);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    ErrorHandling(); //TODO: More useful error
                    Log.LogMessage(UserField.Text, false);
                    throw;
                }
            }
            else // Reminder to check configuration
            {
                MessageBox.Show("Your current system configuration is not supported by this application.", "ERROR: Unsupported system configuration");
            }
        }

        #endregion

    }
}
