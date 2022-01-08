using NetSatis.Entities.Context;
using NetSatis.Entities.Repository;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Tables.OtherTables;
using NetSatis.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.DataAccess
{
    public class KasaDAL : EntityRepositoryBase<NetSatisContext, Kasa, KasaValidator>
    {
        public object KasaListele(NetSatisContext context)
        {
            var result = context.Kasalar.GroupJoin(context.KasaHareketleri, c => c.Id, c => c.KasaId, (kasa, kasahareket) =>
                   new
                   {
                       kasa.Id,
                       kasa.KasaKodu,
                       kasa.KasaAdi,
                       kasa.YetkiliKodu,
                       kasa.YetkiliAdi,
                       kasa.Aciklama,
                       KasaGiris = (kasahareket.Where(c => c.Hareket == "Kasa Giriş" && c.KasaId == kasa.Id).Sum(c => c.Tutar) ?? 0),
                       KasaCikis = (kasahareket.Where(c => c.Hareket == "Kasa Çıkış" && c.KasaId == kasa.Id).Sum(c => c.Tutar) ?? 0),
                       Bakiye = (kasahareket.Where(c => c.Hareket == "Kasa Giriş" && c.KasaId == kasa.Id).Sum(c => c.Tutar) ?? 0) -
                       (kasahareket.Where(c => c.Hareket == "Kasa Çıkış" && c.KasaId == kasa.Id).Sum(c => c.Tutar) ?? 0)
                   }).ToList();
            return result;
        }
        public object OdemeTuruToplamListele(NetSatisContext context, int kasaId)
        {
            var result = (from c in context.KasaHareketleri.Where(c => c.KasaId == kasaId)
                          group c by new { c.OdemeTuru } into grp
                          select new
                          {
                              grp.Key.OdemeTuru.OdemeTuruAdi,
                              KasaGiris = (grp.Where(c => c.OdemeTuruId == grp.Key.OdemeTuru.Id && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0),
                              KasaCikis = (grp.Where(c => c.OdemeTuruId == grp.Key.OdemeTuru.Id && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0),
                              Bakiye = (grp.Where(c => c.OdemeTuruId == grp.Key.OdemeTuru.Id && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0)
                              - (grp.Where(c => c.OdemeTuruId == grp.Key.OdemeTuru.Id && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0)
                          }).ToList();
            return result;
        }
        public object KasaGenelToplam(NetSatisContext context, int kasaId)
        {
            decimal KasaGiris = context.KasaHareketleri.Where(c => c.KasaId == kasaId && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar)??0;
                int KasaGirisKayitSayisi= context.KasaHareketleri.Where(c => c.KasaId == kasaId && c.Hareket == "Kasa Giriş").Count();
            decimal KasaCikis = context.KasaHareketleri.Where(c => c.KasaId == kasaId && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0;
            int KasaCikisKayitSayisi = context.KasaHareketleri.Where(c => c.KasaId == kasaId && c.Hareket == "Kasa Çıkış").Count();


            List<GenelToplam> genelToplamlar = new List<GenelToplam>()
            {
                new GenelToplam
                {
                    Bilgi="Kasa Giriş",
                    KayitSayisi=KasaGirisKayitSayisi,
                    Tutar=KasaGiris,
                },
                new GenelToplam
                {
                    Bilgi="Kasa Çıkış",
                    KayitSayisi=KasaCikisKayitSayisi,
                    Tutar=KasaCikis,
                },
                new GenelToplam
                {
                    Bilgi="Bakiye",
                    KayitSayisi=KasaGirisKayitSayisi+KasaCikisKayitSayisi,
                    Tutar=KasaGiris-KasaCikis,
                }
            };
            return genelToplamlar;

        }
    }
}
