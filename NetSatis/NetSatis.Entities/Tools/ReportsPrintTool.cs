using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Tools
{
    public class ReportsPrintTool
    {
        public enum Belge
        {
            BilgiFisi,
            Fatura,
            Diger
        }
        public void RaporYazdir(XtraReport rapor,Belge belge)
        {
            ReportPrintTool raporYazdir = new ReportPrintTool(rapor);
            string yaziciAdi = "";
            int ayar = 0;
            switch (belge)
            {   
                case Belge.BilgiFisi:
                    rapor.RequestParameters = false;
                    rapor.Parameters["FirmaAdi"].Value = SettingsTool.AyarOku(SettingsTool.Ayarlar.FirmaAyarlari_FirmaAdi);
                    ayar = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazdirmaAyari));
                    yaziciAdi = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazici);
                    raporYazdir.AutoShowParametersPanel = false;
                    break;
                case Belge.Fatura:
                    ayar= Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_FaturaYazdirmaAyari));
                    yaziciAdi = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_FaturaYazici);
                    break;
            }
            switch (ayar)
            {
                case 0:
                    raporYazdir.Print(yaziciAdi);
                    break;
                case 1:
                    raporYazdir.PrintDialog();
                    break;
                case 2:
                    raporYazdir.ShowPreviewDialog();
                    break;
            }
        }
    }
}
