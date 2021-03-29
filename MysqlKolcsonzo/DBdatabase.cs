using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using MySql.Data.MySqlClient;

namespace MysqlKolcsonzo
{
    public class DBdatabase
    {
        private MySqlConnection mysqlKapcsolat;
        public MySqlConnection MySqlKapcsolat 
        {
            get { return mysqlKapcsolat; }
            set { mysqlKapcsolat = value; }
        }
        private string server;
        public string Server
        {
            get { return server; }
            set { server = value; }
        }
        private string database;
        public string Database
        {
            get { return database; }
            set { database = value; }
        }
        private string uid;
        public string Uid
        {
            get { return uid; }
            set { uid = value; }
        }

        public DBdatabase(string server, string database, string uid)
        {
            this.server = server;
            this.database = database;
            this.uid = uid;

            string kapcsolat = $"server={server};database={database};uid={uid};";
            mysqlKapcsolat = new MySqlConnection(kapcsolat);
        }
    }
}
