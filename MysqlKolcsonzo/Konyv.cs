using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysqlKolcsonzo
{
    class Konyv
    {
        public int Id { get; set; }
        public string Isbn { get; set; }
        public string Szerzo { get; set; }
        public string Cim { get; set; }
        public string KonyvAdat => $"{Isbn}, {Szerzo}: {Cim}";
    }
}
