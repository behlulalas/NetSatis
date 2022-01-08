using NetSatis.Entities.Context;
using NetSatis.Entities.DataAccess;
using NetSatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Tools
{
    public static class ConverterTool
    {
        private static StokHareket StoktoStokHareket(NetSatisContext context,Entities.Tables.Stok entity,decimal miktar)
        {
            IndirimDAL indirimDAL = new IndirimDAL();
            StokHareket stokHareket = new StokHareket();
            stokHareket.StokId = entity.Id;
            stokHareket.IndirimOrani = indirimDAL.StokIndirimi(context, entity.StokKodu);
            stokHareket.DepoId = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanDepo));
            //stokHareket.BirimFiyati = txtFisTuru.Text == "Alış Faturası" ? entity.AlisFiyati1 ?? 0 : entity.SatisFiyati1 ?? 0;
            stokHareket.Miktar = miktar;
            stokHareket.Tarih = DateTime.Now;
            stokHareket.Kdv = entity.SatisKdv;
            return stokHareket;
        }
        public static decimal StringToDecimal(string ifade, string ondalikAyrac)
        {
            string ondalikKarakter = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator.ToString();
            return Convert.ToDecimal(ifade.Replace(ondalikAyrac, ondalikKarakter));
        }
    }
}
