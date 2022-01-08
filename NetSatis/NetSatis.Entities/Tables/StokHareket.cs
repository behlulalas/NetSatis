using NetSatis.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Tables
{
    public class StokHareket : IEntity
    {
        public StokHareket Clone()
        {
            StokHareket hareket = new StokHareket();
            hareket.FisKodu = FisKodu;
            hareket.Hareket = Hareket;
            hareket.StokId = StokId;
            hareket.Miktar = Miktar;
            hareket.Kdv = Kdv;
            hareket.BirimFiyati = BirimFiyati;
            hareket.IndirimOrani = IndirimOrani;
            hareket.DepoId = DepoId;
            hareket.SeriNo = SeriNo;
            hareket.Tarih = Tarih;
            hareket.Aciklama = Aciklama;
            hareket.Siparis = Siparis;
            return hareket;
        }
        public int Id { get; set; }
        public string FisKodu { get; set; }
        public string Hareket { get; set; }
        public int StokId { get; set; }
        public decimal? Miktar { get; set; }
        public int Kdv { get; set; }
        public decimal? BirimFiyati { get; set; }
        public decimal? IndirimOrani { get; set; }
        public int DepoId { get; set; }
        public string SeriNo { get; set; }
        public DateTime? Tarih { get; set; }
        public string Aciklama { get; set; }
        public bool Siparis { get; set; }
        public virtual Stok Stok { get; set; }
        public virtual Depo Depo { get; set; }
    }
}
