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
    public class OdemeTuruDAL : EntityRepositoryBase<NetSatisContext, OdemeTuru, OdemeTuruValidator>
    {
        public object OdemeTuruListele(NetSatisContext context)
        {
            var result = context.OdemeTurleri.GroupJoin(context.KasaHareketleri, c => c.Id, c => c.OdemeTuruId, (odemeturu, kasahareket) =>
                   new
                   {
                       odemeturu.Id,
                       odemeturu.OdemeTuruKodu,
                       odemeturu.OdemeTuruAdi,
                       odemeturu.Aciklama,
                       KasaGiris = (kasahareket.Where(c => c.Hareket == "Kasa Giriş" && c.OdemeTuruId == odemeturu.Id).Sum(c => c.Tutar) ?? 0),
                       KasaCikis = (kasahareket.Where(c => c.Hareket == "Kasa Çıkış" && c.OdemeTuruId == odemeturu.Id).Sum(c => c.Tutar) ?? 0),
                       Bakiye = (kasahareket.Where(c => c.Hareket == "Kasa Giriş" && c.OdemeTuruId == odemeturu.Id).Sum(c => c.Tutar) ?? 0) -
                       (kasahareket.Where(c => c.Hareket == "Kasa Çıkış" && c.OdemeTuruId == odemeturu.Id).Sum(c => c.Tutar) ?? 0)
                   }).ToList();
            return result;
        }
        public object KasaToplamListele(NetSatisContext context, int odemeTuruId)
        {
            var result = (from c in context.KasaHareketleri.Where(c => c.OdemeTuruId == odemeTuruId)
                          group c by new { c.Kasa} into grp
                          select new
                          {
                              grp.Key.Kasa.KasaKodu,
                              grp.Key.Kasa.KasaAdi,
                              KasaGiris = (grp.Where(c => c.KasaId == grp.Key.Kasa.Id && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0),
                              KasaCikis = (grp.Where(c => c.KasaId == grp.Key.Kasa.Id && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0),
                              Bakiye = (grp.Where(c => c.KasaId == grp.Key.Kasa.Id && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0)
                              - (grp.Where(c => c.KasaId == grp.Key.Kasa.Id && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0)

                          }).ToList();
            return result;
        }
        public object KasaGenelToplam(NetSatisContext context, int odemeTuruId)
        {
            decimal KasaGiris = context.KasaHareketleri.Where(c => c.OdemeTuruId == odemeTuruId && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0;
            int KasaGirisKayitSayisi = context.KasaHareketleri.Where(c => c.OdemeTuruId == odemeTuruId && c.Hareket == "Kasa Giriş").Count();
            decimal KasaCikis = context.KasaHareketleri.Where(c => c.OdemeTuruId == odemeTuruId && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0;
            int KasaCikisKayitSayisi = context.KasaHareketleri.Where(c => c.OdemeTuruId == odemeTuruId && c.Hareket == "Kasa Çıkış").Count();


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
