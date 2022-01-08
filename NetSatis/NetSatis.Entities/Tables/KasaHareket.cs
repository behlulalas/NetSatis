using NetSatis.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Tables
{
    public class KasaHareket : IEntity
    {
        public int Id { get; set; }
        public string FisKodu { get; set; }
        public string Hareket { get; set; }
        public int KasaId { get; set; }
        public int OdemeTuruId { get; set; }
        public int? CariId { get; set; }
        public DateTime? Tarih { get; set; }
        public decimal? Tutar { get; set; }
        public string Aciklama { get; set; }
        public virtual Kasa Kasa { get; set; }
        public virtual OdemeTuru OdemeTuru { get; set; }
        public virtual Cari Cari { get; set; }
    }
}
