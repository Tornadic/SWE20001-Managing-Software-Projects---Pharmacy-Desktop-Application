using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Pharmacy_Desktop_Application
{
    public class SQLClient
    {
        private SQLClient()
        {
        }
        public string Server { get; set; }
        public string DatabaseName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public MySqlConnection Connection { get => _connection; }

        private MySqlConnection _connection;

        private static SQLClient _instance = null;
        public static SQLClient Instance()
        {
            if (_instance == null)
                _instance = new SQLClient();
            return _instance;
        }

        public bool IsConnect()
        {
            try
            {
                if (Connection == null)
                {
                    if (String.IsNullOrEmpty(DatabaseName))
                        return false;
                    string connstring = string.Format("Server={0}; database={1}; UID={2}; password={3}", Server, DatabaseName, UserName, Password);
                    _connection = new MySqlConnection(connstring);
                    _connection.Open();
                }

                return true;
            }
            catch { return false; };
        }

        public void Close()
        {
            Connection.Close();
            _connection = null;
        }
    }
}

