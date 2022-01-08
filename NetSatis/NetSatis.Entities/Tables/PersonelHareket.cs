using NetSatis.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Tables
{
    public class PersonelHareket : IEntity
    {
        public int Id { get; set; }
        public string FisKodu { get; set; }
        public string Unvani { get; set; }
        public string PersonelKodu { get; set; }
        public string PersonelAdi { get; set; }
        public string TcKimlikNo { get; set; }
        public DateTime Donemi { get; set; }
        public decimal PrimOrani { get; set; }
        public decimal ToplamSatis { get; set; }
        public decimal AylikMaasi { get; set; }
        public string Aciklama { get; set; }
    }
}
