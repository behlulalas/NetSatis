using NetSatis.Entities.Context;
using NetSatis.Entities.Repository;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.DataAccess
{
    public class PersonelDAL : EntityRepositoryBase<NetSatisContext, Personel, PersonelValidator>
    {
        public object GetPersonelList(NetSatisContext context)
        {
            var result = context.Personeller.GroupJoin(context.Fisler, c => c.Id, c => c.PlasiyerId, (personel, fis) => new
            {
                personel.Id,
                personel.Calisiyor,
                personel.PersonelKodu,
                personel.PersonelAdi,
                personel.Unvani,
                personel.TcKimlikNo,
                personel.IseGirisTarihi,
                personel.IstenCikisTarihi,
                personel.VergiDairesi,
                personel.VergiNo,
                personel.CepTelefonu,
                personel.Telefon,
                personel.Fax,
                personel.Il,
                personel.Ilce,
                personel.Semt,
                personel.Adres,
                personel.EMail,
                personel.Web,
                personel.AylikMaas,
                personel.PrimOrani,
                personel.Aciklama,
                ToplamSatis = fis.Where(c => c.FisTuru == "Perakende Satış Faturası").Sum(c => c.ToplamTutar) ?? 0,
                PrimTutari = (fis.Where(c => c.FisTuru == "Perakende Satış Faturası").Sum(c => c.ToplamTutar) ?? 0) / 100 * personel.PrimOrani,
            }).ToList();
            return result;
        }
        public object GetPersonelListbyDate(NetSatisContext context, int ay, int yil)
        {
            var result = context.Personeller.GroupJoin(context.Fisler, c => c.Id, c => c.PlasiyerId, (personel, fis) => new
            {
                personel.Id,
                personel.Calisiyor,
                personel.PersonelKodu,
                personel.PersonelAdi,
                personel.Unvani,
                personel.TcKimlikNo,
                personel.IseGirisTarihi,
                personel.IstenCikisTarihi,
                personel.VergiDairesi,
                personel.VergiNo,
                personel.CepTelefonu,
                personel.Telefon,
                personel.Fax,
                personel.Il,
                personel.Ilce,
                personel.Semt,
                personel.Adres,
                personel.EMail,
                personel.Web,
                personel.AylikMaas,
                personel.PrimOrani,
                personel.Aciklama,
                ToplamSatis = fis.Where(c => c.FisTuru == "Perakende Satış Faturası" && c.Tarih.Value.Month == ay && c.Tarih.Value.Year == yil).Sum(c => c.ToplamTutar) ?? 0,
                PrimTutari = (fis.Where(c => c.FisTuru == "Perakende Satış Faturası" && c.Tarih.Value.Month == ay && c.Tarih.Value.Year == yil).Sum(c => c.ToplamTutar) ?? 0) / 100 * personel.PrimOrani,
            }).ToList();
            return result;
        }
        public object PersonelFisToplam(NetSatisContext context, int plasiyerId)
        {
            var result = (from c in context.Fisler.Where(c => c.PlasiyerId == plasiyerId)
                          group c by new { c.FisTuru } into grp
                          select new
                          {
                              Bilgi = grp.Key.FisTuru,
                              KayitSayisi = grp.Count(),
                              ToplamTutar = grp.Sum(c => c.ToplamTutar),
                          }).ToList();
            return result;
        }
    }
}
