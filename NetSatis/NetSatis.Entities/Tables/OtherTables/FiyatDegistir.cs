using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Tables.OtherTables
{
    public class FiyatDegistir
    {
        public string FiyatTuru { get; set; }
        public string KolonAdi { get; set; }
        public bool Degistir { get; set; }
        public string DegisimTuru { get; set; }
        public string DegisimYonu { get; set; }
        public decimal Degeri { get; set; }
    }
}
