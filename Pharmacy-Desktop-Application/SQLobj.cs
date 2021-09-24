using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Pharmacy_Desktop_Application
{

    public class SQLobj
    {
        private SQLClient dbCon;
        private SQLobj() {
            dbCon = SQLClient.Instance();
            dbCon.Server = "b9dvbijn75tkdncjfyrz-mysql.services.clever-cloud.com";
            dbCon.DatabaseName = "b9dvbijn75tkdncjfyrz";
            dbCon.UserName = "u0i6ltdrb6uf51r7";
            dbCon.Password = "mzQvJahUv8VsirEBKhHk";
        }

        private static SQLobj _instance = null;
        public static SQLobj Instance()
        {
            if (_instance == null)
                _instance = new SQLobj();
            return _instance;
        }
        public void TestConnection() {
            try
            {
                if (dbCon.IsConnect())
                {
                    //suppose col0 and col1 are defined as VARCHAR in the DB
                    string query = "SELECT * FROM PHPProducts";
                    var cmd = new MySqlCommand(query, dbCon.Connection);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string someStringFromColumnZero = reader.GetString(0);
                        string someStringFromColumnOne = reader.GetString(1);
                        Console.WriteLine(someStringFromColumnZero + "," + someStringFromColumnOne);
                    }
                    dbCon.Close();
                }
            }
            catch { }
        }        

        public void QueryDB(string query)
        {
            if (dbCon.IsConnect())
            {
                //suppose col0 and col1 are defined as VARCHAR in the DB
                var cmd = new MySqlCommand(query, dbCon.Connection);
                try
                {
                    var reader = cmd.ExecuteReader();
                    try
                    {
                        while (reader.Read())
                        {
                        }
                    }
                    finally
                    {
                        // Always call Close when done reading.
                        reader.Close();
                    }
                }
                catch { Console.WriteLine("QUERY FAILED"); }
                
             
                dbCon.Close();
            }
        }
    }
}
