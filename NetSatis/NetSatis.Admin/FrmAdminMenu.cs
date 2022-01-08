using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
using System.Data.SqlClient;
using NetSatis.Entities.Tools;
using NetSatis.Entities.Tools.LoadingTool;
using NetSatis.Entities.Tables;

namespace NetSatis.Admin
{
    public partial class FrmAdminMenu : DevExpress.XtraEditors.XtraForm
    {
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        public FrmAdminMenu()
        {
            InitializeComponent();
            FrmKullaniciGiris frm = new FrmKullaniciGiris();
            frm.ShowDialog();
        }

        private void btnKullanicilar_Click(object sender, EventArgs e)
        {
            FrmKullanicilar frm = new FrmKullanicilar();
            frm.ShowDialog();
        }

        private void btnDevirSihirbazi_Click(object sender, EventArgs e)
        {
            FrmDevir frm = new FrmDevir();
            frm.ShowDialog();
        }

        private void btnDonemOlustur_Click(object sender, EventArgs e)
        {
            LoadingTool tool = new LoadingTool(this);
            FrmDonem frm = new FrmDonem();
            frm.ShowDialog();
            if (!String.IsNullOrEmpty(frm.donem))
            {
                builder.ConnectionString = SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_BaglantiCumlesi);
                builder.InitialCatalog = "NetSatis" + frm.donem;
                NetSatisContext context = new NetSatisContext(builder.ConnectionString,true);
                tool.AnimasyonBaslat();
                context.Database.CreateIfNotExists();
                if (!context.Kullanicilar.Any(c => c.KullaniciAdi == "admin"))
                {
                    context.Kullanicilar.Add(new Kullanici
                    {
                        KullaniciAdi = "admin",
                        Parola = "1"
                    });
                    context.SaveChanges();
                }
                if (!context.Kasalar.Any(c => c.KasaAdi == "MERKEZ KASA"))
                {
                    context.Kasalar.Add(new Kasa
                    {
                        KasaAdi = "MERKEZ KASA",
                        KasaKodu = "KS0000000001",

                    });
                    context.SaveChanges();
                }
                if (!context.OdemeTurleri.Any(c => c.OdemeTuruAdi == "NAKİT"))
                {
                    context.OdemeTurleri.Add(new OdemeTuru
                    {
                        OdemeTuruAdi = "NAKİT",
                        OdemeTuruKodu = "OT0000000001"
                    });
                    context.SaveChanges();
                }
                if (!context.Depolar.Any(c => c.DepoAdi == "MERKEZ DEPO"))
                {
                    context.Depolar.Add(new Depo
                    {
                        DepoAdi = "MERKEZ DEPO",
                        DepoKodu = "DP0000000001",
                    });
                    context.SaveChanges();
                }
                if (!context.Kodlar.Any(c => c.OnEki == ""))
                {
                    context.Kodlar.Add(new Kod
                    {
                        OnEki = "FO",
                        SonDeger = 1,
                        Tablo = "Fis"
                    });
                    context.SaveChanges();
                }
                if (!context.Kodlar.Any(c => c.OnEki == ""))
                {
                    context.Kodlar.Add(new Kod
                    {
                        OnEki = "SF",
                        SonDeger = 1,
                        Tablo = "Fis"
                    });
                    context.SaveChanges();
                }
                if (!context.Kodlar.Any(c => c.OnEki == ""))
                {
                    context.Kodlar.Add(new Kod
                    {
                        OnEki = "DK",
                        SonDeger = 2,
                        Tablo = "Depo"
                    });
                    context.SaveChanges();
                }
                if (!context.Kodlar.Any(c => c.OnEki == ""))
                {
                    context.Kodlar.Add(new Kod
                    {
                        OnEki = "SK",
                        SonDeger = 1,
                        Tablo = "Stok"
                    });
                    context.SaveChanges();
                }
                if (!context.Kodlar.Any(c => c.OnEki == ""))
                {
                    context.Kodlar.Add(new Kod
                    {
                        OnEki = "CK",
                        SonDeger = 1,
                        Tablo = "Cari"
                    });
                    context.SaveChanges();
                }
                if (!context.Kodlar.Any(c => c.OnEki == ""))
                {
                    context.Kodlar.Add(new Kod
                    {
                        OnEki = "OT",
                        SonDeger = 2,
                        Tablo = "OdemeTuru"
                    });
                    context.SaveChanges();
                }
                if (!context.Kodlar.Any(c => c.OnEki == ""))
                {
                    context.Kodlar.Add(new Kod
                    {
                        OnEki = "KS",
                        SonDeger = 2,
                        Tablo = "Kasa"
                    });
                    context.SaveChanges();
                }
                tool.AnimasyonBitir();
            }
        }
    }
}