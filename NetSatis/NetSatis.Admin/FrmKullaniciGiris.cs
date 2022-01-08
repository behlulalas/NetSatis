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
using NetSatis.Entities.DataAccess;
using NetSatis.Entities.Tools;
using System.Data.SqlClient;
using NetSatis.Entities.Tools.LoadingTool;
using NetSatis.Entities.Tables;

namespace NetSatis.Admin
{
    public partial class FrmKullaniciGiris : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context;
        KullaniciDAL kullaniciDAL = new KullaniciDAL();
        private bool girisBasarili = false;
        List<string> dbList;
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        public string AktifDatabase = "";
        public string GecerliDB = "";
        public FrmKullaniciGiris()
        {
            InitializeComponent();
            builder.ConnectionString = SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_BaglantiCumlesi);
            builder.InitialCatalog = "master";
            if (!ConnectionTool.CheckConnection(builder.ConnectionString))
            {
                FrmBaglantiAyarlari frm = new FrmBaglantiAyarlari();
                frm.ShowDialog();
                if (frm.kaydedildi)
                {
                    builder.ConnectionString = SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_BaglantiCumlesi);
                    context = new NetSatisContext(builder.ConnectionString);
                    DbListele();
                    DbOlustur();
                }
            }
            else
            {
                context = new NetSatisContext(builder.ConnectionString);
                DbListele();
                DbOlustur();
            }
            //cmbDbList.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_GecerliDB);
            cmbDbList.Text = DateTime.Now.Year.ToString();
        }
        private void DbListele()
        {
            dbList = context.Database.SqlQuery<string>("Select name from master.dbo.sysdatabases where name like 'NetSatis%'").ToList();
            foreach (var item in dbList)
            {
                cmbDbList.Properties.Items.Add(item.Replace("NetSatis", ""));
            }
        }
        private void DbOlustur()
        {
            if (dbList.Count == 0)
            {
                FrmDonem frm = new FrmDonem();
                frm.ShowDialog();
                if (!String.IsNullOrEmpty(frm.donem))
                {
                    builder.InitialCatalog = "NetSatis" + frm.donem;
                    SettingsTool.AyarDegistir(SettingsTool.Ayarlar.DatabaseAyarlari_BaglantiCumlesi, builder.ConnectionString);
                    context = new NetSatisContext();
                    LoadingTool tool = new LoadingTool(this);
                    tool.AnimasyonBaslat();
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
                    DbListele();
                }
            }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (cmbDbList.Properties.Items.Count == 0 || String.IsNullOrEmpty(cmbDbList.Text))
            {
                MessageBox.Show("Seçili bir database bulunamadı.");
                return;
            }
            else
            {
                builder.InitialCatalog = "NetSatis" + cmbDbList.Text;
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.DatabaseAyarlari_BaglantiCumlesi, builder.ConnectionString);
                context = new NetSatisContext();
                AktifDatabase = builder.InitialCatalog;
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.DatabaseAyarlari_GecerliDB, cmbDbList.Text);
                SettingsTool.Save();

            }
            if (context.Kullanicilar.Any(c => c.KullaniciAdi == txtKullanici.Text && c.Parola == txtParola.Text))
            {
                girisBasarili = true;
                RoleTool.kullaniciEntity = context.Kullanicilar.SingleOrDefault(c => c.KullaniciAdi == txtKullanici.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ve ya Parola hatalı.");
                txtKullanici.Text = null;
                txtParola.Text = null;
            }
        }
        private void FrmKullaniciGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!girisBasarili)
            {
                Application.Exit();
            }
        }

        private void btnParolaUnuttum_Click(object sender, EventArgs e)
        {
            if (txtKullanici.Text != null)
            {
                if (context.Kullanicilar.Any(c => c.KullaniciAdi == txtKullanici.Text))
                {
                    FrmParolaHatırlat frm = new FrmParolaHatırlat(txtKullanici.Text);
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void txtParola_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGiris.Focus();
            }
        }
    }
}