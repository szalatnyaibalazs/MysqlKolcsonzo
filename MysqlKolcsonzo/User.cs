using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysqlKolcsonzo
{
    public class User
    {
        private string jelszo;
        public string Jelszo 
        {
            get { return jelszo; }
            set { jelszo = value; }
        }
        private string jogkor;
        public string Jogkor
        {
            get { return jogkor; }
            set { jogkor = value; }
        }
        private string nev;
        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }
        private string teljesNev;
        public string TeljesNev
        {
            get { return teljesNev; }
            set { teljesNev = value; }
        }

        public User( string jelszo,string jogkor, string nev,string teljesNev)
        {
            this.jelszo = jelszo;
            this.jogkor = jogkor;
            this.nev = nev;
            this.teljesNev = teljesNev;
        }
    }
}
