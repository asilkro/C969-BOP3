using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Silkroski_C969.Models
{
    public class DbConnection
    {
        
        #region Properties / Fields

        public MySqlConnection Connection => _connection; // Getter-only property keeps connection safe, lambda for ease of reading
        private MySqlConnection _connection;

        public bool IsConnected => _isConnected;
        private bool _isConnected;

        private const string _server = "localhost";
        private const string _userName = "test";
        private const string _password = "test";
        private const string _schema = "client_schedule";

        private const string _connectionString = "userid=" + _userName + ";" + "password=" + _password + ";" +
                                                 "database=" + _schema + ";" + "server=" + _server + ";" +
                                                 "allowbatch=True;"; // Replaces MySQLConnectionStringBuilder

        public string ConnectionString => _connectionString; // Getter-only property keeps connection safe, lambda for ease of reading

        #endregion


        #region Constructors

        public DbConnection()
        {

        }

        #endregion


        #region Methods

        public string BuildMySqlConnectionString(string userID, string password) //TODO: Can probably remove
        {
            MySqlConnectionStringBuilder connectionStringBuilder = new MySqlConnectionStringBuilder();
            connectionStringBuilder.UserID = userID;
            connectionStringBuilder.Password = password;
            connectionStringBuilder.Database = "client_schedule";
            connectionStringBuilder.Server = "localhost";
            connectionStringBuilder.AllowBatch = true; // allows sending multiple commands in one query -> CustomerForm queries may not work without this

            MessageBox.Show(connectionStringBuilder.ConnectionString, "this is your string format");
            return connectionStringBuilder.ConnectionString;
        }

        public void Connect(string userID, string password)
        {
            if (_connection != null && _connection.State != ConnectionState.Closed)
            {
                MessageBox.Show("Not connecting, returning early");
                return;
            } 
           
            // this.userid = userID;
            // this.password = password;
            // string connectionString = BuildMySqlConnectionString(userID, password);
           string connectionString = _connectionString;
            _connection = new MySqlConnection(connectionString);
            _connection.Open();
            _isConnected = true;

        }

        #endregion
    }
}
