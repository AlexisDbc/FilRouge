using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace TP3
{
    class ManagementBDD
    {
        private string uid;
        private string pwd;
        MySql.Data.MySqlClient.MySqlConnection conn;
        public ManagementBDD (string uid, string pwd)
        {
            this.uid = uid;
            this.pwd = pwd;
        }
        public MySqlConnection connection()
        {
            string myConnectionString;
            
            //Gerer les info de connexion ici (paramètre string private)
            myConnectionString = "server="+ConfigurationManager.AppSettings["server"]+";uid="+uid+";" +
                "pwd="+pwd+";database="+ConfigurationManager.AppSettings["database"]+";";
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            try
            {  
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            { conn = null; }
            return conn;
        }
        public MySqlDataReader read(string request)
        {
            MySqlCommand com = new MySqlCommand(request, connection());
            MySqlDataReader dr = com.ExecuteReader();
            return dr;
        }
        public void close()
        {
            if (null != conn)
            {
                conn.Close();
            }
        }
    }
}
