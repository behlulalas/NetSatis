using NetSatis.Entities.Context;
using NetSatis.Entities.Interfaces;
using NetSatis.Entities.Repository;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Tables.OtherTables;
using NetSatis.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.DataAccess
{
    public class IndirimDAL : EntityRepositoryBase<NetSatisContext, Indirim, IndirimValidator>
    {
        public object IndirimListele(NetSatisContext context)
        {
            var result = (from c in context.Indirimler select c).AsEnumerable().Select(c => new
            {
                c.Id,
                IndirimAktif = Aktif(c.IndirimTuru, Convert.ToDateTime(c.BitisTarihi), c.Durumu),
                c.Durumu,
                c.StokKodu,
                c.Barkod,
                c.StokAdi,
                c.IndirimTuru,
                c.BaslangicTarihi,
                c.BitisTarihi,
                c.IndirimOrani,
                c.Aciklama
            }
            ).ToList();
            return result;
        }
        public decimal StokIndirimi(NetSatisContext context, string stokKodu)
        {
            decimal sonuc = 0;
            var result = (from c in context.Indirimler.Where(c => c.StokKodu == stokKodu) select c).AsEnumerable().Select(c => new
            {
                IndirimAktif = Aktif(c.IndirimTuru, Convert.ToDateTime(c.BitisTarihi), c.Durumu),
                c.IndirimOrani,
            }
            ).SingleOrDefault();
            if (result!=null && result.IndirimAktif==true)
            {
                sonuc = result.IndirimOrani;
            }
            return sonuc;
        }
        bool Aktif(string IndirimTuru, DateTime BitisTarihi, bool Durum)
        {
            bool result = false;
            if (Durum)
            {
                if (IndirimTuru == "Süresiz")
                {
                    result = true;
                }
                else
                {
                    if (DateTime.Now <= BitisTarihi)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }
    }
}
