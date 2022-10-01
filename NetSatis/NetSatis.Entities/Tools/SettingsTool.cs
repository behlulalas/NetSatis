using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSatis.Entities.Tools
{
    public static class SettingsTool
    {
        static FileIniDataParser parser = new FileIniDataParser();
        static IniData data;
        static string dosyaAdi = "Settings.ini";

        static SettingsTool()
        {
            if (System.IO.File.Exists(Application.StartupPath + "\\" + dosyaAdi))
            {
                data = parser.ReadFile(dosyaAdi);
            }
            else
            {
                using (System.IO.File.Create(Application.StartupPath + "\\" + dosyaAdi))
                {

                }
                data = parser.ReadFile(dosyaAdi);
            }
        }
        public enum Ayarlar
        {
            SmsAyarlari_KullanıcıAdı,
            SmsAyarlari_Parola,
            SatisAyarlari_VarsayilanDepo,
            SatisAyarlari_VarsayilanKasa,
            SatisAyarlari_FaturaYazdirmaAyari,
            SatisAyarlari_FaturaYazici,
            SatisAyarlari_BilgiFisiYazdirmaAyari,
            SatisAyarlari_BilgiFisiYazici,
            SatisAyarlari_FisKodu,
            YedeklemeAyarlari_YedeklemeKonumu,
            GenelAyarlar_GuncellemeKontrol,
            DatabaseAyarlari_BaglantiCumlesi,
            DatabaseAyarlari_GecerliDB,
            DatabaseAyarlari_ServerName,
            FirmaAyarlari_FirmaAdi,
        }
        public static void AyarDegistir(Ayarlar ayar, string value)
        {
            string[] gelenAyar = ayar.ToString().Split(Convert.ToChar("_"));
            if (data != null)
            {
                if (data.Sections.Count(c => c.SectionName == gelenAyar[0]) == 0)
                {
                    data.Sections.AddSection(gelenAyar[0]);
                    data[gelenAyar[0]].AddKey(gelenAyar[1]);
                }
                else
                {
                    data[gelenAyar[0]].AddKey(gelenAyar[1]);
                }
                data[gelenAyar[0]][gelenAyar[1]] = value;
            }
        }
        public static string AyarOku(Ayarlar ayar)
        {
            string[] gelenAyar = ayar.ToString().Split(Convert.ToChar("_"));
            return data[gelenAyar[0]][gelenAyar[1]];
        }
        public static void Save()
        {
            parser.WriteFile(dosyaAdi, data);
        }
    }
}
