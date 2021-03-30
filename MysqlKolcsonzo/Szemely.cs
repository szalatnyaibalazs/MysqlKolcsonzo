using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysqlKolcsonzo
{
    class Szemely
    {
        public int Id { get; set; }
        public string Nev { get; set; }
        public string Levelezesicim { get; set; }
        public string SzemelyAdat => $"{Nev},{Levelezesicim}";
    }
}
