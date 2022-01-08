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
using NetSatis.Entities.Tables;
using NetSatis.Entities.Tools;
using NetSatis.Entities.DataAccess;
using NetSatis.Entities.Tables.OtherTables;
using System.Data.Entity;
using NetSatis.Entities.Tools.LoadingTool;
using DevExpress.XtraWizard;

namespace NetSatis.Admin
{
    public partial class FrmDevir : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext kaynakContext;
        SqlConnectionStringBuilder builderKaynak = new SqlConnectionStringBuilder();
        NetSatisContext hedefContext;
        SqlConnectionStringBuilder builderHedef = new SqlConnectionStringBuilder();
        List<string> dbList;
        CodeTool kodOlustur;
        LoadingTool yuklemeFormu;
        private string seciliKaynak, seciliHedef;
        public FrmDevir()
        {
            InitializeComponent();
            yuklemeFormu = new LoadingTool(this);
            kodOlustur = new CodeTool(this, CodeTool.Table.Fis);
            builderKaynak.DataSource = "(localdb)\v11.0";
            builderKaynak.InitialCatalog = "master";
            builderKaynak.IntegratedSecurity = true;
            kaynakContext = new NetSatisContext(builderKaynak.ConnectionString);
            dbList = kaynakContext.Database.SqlQuery<string>("Select name from master.dbo.sysdatabases where name like 'NetSatis%'").ToList();
            KaynakDbYukle();
            HedefDbYukle();
        }

        private void KaynakDbYukle()
        {
            foreach (var item in dbList)
            {
                CheckButton button = new CheckButton
                {
                    Name = item,
                    Text = item.Replace("NetSatis", ""),
                    GroupIndex = 1,
                    ImageList = ımageList1,
                    ImageIndex = 0,
                    ImageToTextAlignment = ImageAlignToText.TopCenter,
                    Height = 100,
                    Width = 100,
                };
                button.Click += KaynakSec;
                flowKaynak.Controls.Add(button);
            }

        }

        private void KaynakSec(object sender, EventArgs e)
        {
            CheckButton button = (CheckButton)sender;
            builderKaynak.DataSource = "(localdb)\v11.0";
            builderKaynak.InitialCatalog = "NetSatis" + button.Text;
            builderKaynak.IntegratedSecurity = true;
            seciliKaynak = button.Text;
            kaynakContext = new NetSatisContext(builderKaynak.ConnectionString);
        }

        private void HedefDbYukle()
        {
            SimpleButton yeniButon = new SimpleButton
            {
                Name = "YeniDonemEkle",
                Text = "Yeni Dönem Ekle",
                ImageList = ımageList1,
                ImageIndex = 1,
                ImageToTextAlignment = ImageAlignToText.TopCenter,
                Height = 100,
                Width = 100,
            };
            yeniButon.Click += YeniDonemSec;
            flowHedef.Controls.Add(yeniButon);
            foreach (var item in dbList)
            {
                CheckButton button = new CheckButton
                {
                    Name = item,
                    Text = item.Replace("NetSatis", ""),
                    GroupIndex = 2,
                    ImageList = ımageList1,
                    ImageIndex = 0,
                    ImageToTextAlignment = ImageAlignToText.TopCenter,
                    Height = 100,
                    Width = 100,
                };
                button.Click += HedefSec;
                flowHedef.Controls.Add(button);
            }

        }

        private void YeniDonemSec(object sender, EventArgs e)
        {
            SimpleButton buttonDonem = (SimpleButton)sender;
            FrmDonem frm = new FrmDonem();
            frm.ShowDialog();
            if (!String.IsNullOrEmpty(frm.donem))
            {
                yuklemeFormu.AnimasyonBaslat();

                if (!dbList.Contains("NetSatis" + frm.donem))
                {
                    dbList.Add("NetSatis" + frm.donem);
                    CheckButton button = new CheckButton
                    {
                        Name = "NetSatis" + frm.donem,
                        Text = frm.donem,
                        GroupIndex = 2,
                        ImageList = ımageList1,
                        ImageIndex = 0,
                        ImageToTextAlignment = ImageAlignToText.TopCenter,
                        Height = 100,
                        Width = 100,
                    };
                    button.Click += HedefSec;
                    flowHedef.Controls.Add(button);

                    builderHedef.DataSource = "(localdb)\v11.0";
                    builderHedef.InitialCatalog = "NetSatis" + button.Text;
                    builderHedef.IntegratedSecurity = true;
                    hedefContext = new NetSatisContext(builderHedef.ConnectionString);
                    hedefContext.Database.CreateIfNotExists();
                    if (!hedefContext.Kullanicilar.Any(c => c.KullaniciAdi == "admin"))
                    {
                        hedefContext.Kullanicilar.Add(new Kullanici
                        {
                            KullaniciAdi = "admin",
                            Parola = "1"
                        });
                        hedefContext.SaveChanges();
                    }
                    if (!hedefContext.Kasalar.Any(c => c.KasaAdi == "MERKEZ KASA"))
                    {
                        hedefContext.Kasalar.Add(new Kasa
                        {
                            KasaAdi = "MERKEZ KASA",
                            KasaKodu = "KS0000000001",
                        });
                        hedefContext.SaveChanges();
                    }
                    if (!hedefContext.OdemeTurleri.Any(c => c.OdemeTuruAdi == "NAKİT"))
                    {
                        hedefContext.OdemeTurleri.Add(new OdemeTuru
                        {
                            OdemeTuruAdi = "NAKİT",
                            OdemeTuruKodu = "OT0000000001"
                        });
                        hedefContext.SaveChanges();
                    }
                    if (!hedefContext.Depolar.Any(c => c.DepoAdi == "MERKEZ DEPO"))
                    {
                        hedefContext.Depolar.Add(new Depo
                        {
                            DepoAdi = "MERKEZ DEPO",
                            DepoKodu = "DP0000000001",
                        });
                        hedefContext.SaveChanges();
                    }
                    if (!hedefContext.Kodlar.Any(c => c.OnEki == ""))
                    {
                        hedefContext.Kodlar.Add(new Kod
                        {
                            OnEki = "FO",
                            SonDeger = 1,
                            Tablo = "Fis"
                        });
                        hedefContext.SaveChanges();
                    }
                    if (!hedefContext.Kodlar.Any(c => c.OnEki == ""))
                    {
                        hedefContext.Kodlar.Add(new Kod
                        {
                            OnEki = "SF",
                            SonDeger = 1,
                            Tablo = "Fis"
                        });
                        hedefContext.SaveChanges();
                    }
                    if (!hedefContext.Kodlar.Any(c => c.OnEki == ""))
                    {
                        hedefContext.Kodlar.Add(new Kod
                        {
                            OnEki = "DK",
                            SonDeger = 2,
                            Tablo = "Depo"
                        });
                        hedefContext.SaveChanges();
                    }
                    if (!hedefContext.Kodlar.Any(c => c.OnEki == ""))
                    {
                        hedefContext.Kodlar.Add(new Kod
                        {
                            OnEki = "SK",
                            SonDeger = 1,
                            Tablo = "Stok"
                        });
                        hedefContext.SaveChanges();
                    }
                    if (!hedefContext.Kodlar.Any(c => c.OnEki == ""))
                    {
                        hedefContext.Kodlar.Add(new Kod
                        {
                            OnEki = "CK",
                            SonDeger = 1,
                            Tablo = "Cari"
                        });
                        hedefContext.SaveChanges();
                    }
                    if (!hedefContext.Kodlar.Any(c => c.OnEki == ""))
                    {
                        hedefContext.Kodlar.Add(new Kod
                        {
                            OnEki = "OT",
                            SonDeger = 2,
                            Tablo = "OdemeTuru"
                        });
                        hedefContext.SaveChanges();
                    }
                    if (!hedefContext.Kodlar.Any(c => c.OnEki == ""))
                    {
                        hedefContext.Kodlar.Add(new Kod
                        {
                            OnEki = "KS",
                            SonDeger = 2,
                            Tablo = "Kasa"
                        });
                        hedefContext.SaveChanges();
                    }
                    yuklemeFormu.AnimasyonBitir();
                }
            }
        }

        private void HedefSec(object sender, EventArgs e)
        {
            CheckButton button = (CheckButton)sender;
            builderHedef.DataSource = "(localdb)\v11.0";
            builderHedef.InitialCatalog = "NetSatis" + button.Text;
            builderHedef.IntegratedSecurity = true;
            seciliHedef = button.Text;
            hedefContext = new NetSatisContext(builderHedef.ConnectionString);
        }

        private void toggleStokAktar_Toggled(object sender, EventArgs e)
        {
            if (toggleStokAktar.IsOn)
            {
                toggleStokHareketAktar.Enabled = true;
                toggleStokGirisCikisAktar.Enabled = true;
                toggleIndirimAktar.Enabled = true;
                toggleHizliSatisAktar.Enabled = true;
            }
            else
            {
                toggleStokHareketAktar.Enabled = false;
                toggleStokGirisCikisAktar.Enabled = false;
                toggleIndirimAktar.Enabled = false;
                toggleHizliSatisAktar.Enabled = false;
            }
        }

        private void toggleCariAktar_Toggled(object sender, EventArgs e)
        {
            if (toggleCariAktar.IsOn)
            {
                toggleCariBakiyeAktar.Enabled = true;
                toggleBorcVeAlacakAktar.Enabled = true;
            }
            else
            {
                toggleCariBakiyeAktar.Enabled = false;
                toggleBorcVeAlacakAktar.Enabled = false;
            }
        }

        private void togleKasaAktar_Toggled(object sender, EventArgs e)
        {
            if (toggleKasaAktar.IsOn)
            {
                lookUpKasa.Enabled = true;
            }
            else
            {
                lookUpKasa.Enabled = false;
            }
        }

        private void toggleDepoAktar_Toggled(object sender, EventArgs e)
        {
            if (toggleDepoAktar.IsOn)
            {
                lookUpDepo.Enabled = true;
            }
            else
            {
                lookUpDepo.Enabled = false;
            }
        }

        private void toggleOdemeTuruAktar_Toggled(object sender, EventArgs e)
        {
            if (toggleOdemeTuruAktar.IsOn)
            {
                lookUpOdemeTuru.Enabled = true;
            }
            else
            {
                lookUpOdemeTuru.Enabled = false;
            }
        }

        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            DevirYap();
        }

        private void DevirYap()
        {
            Kasa YeniKasa = new Kasa();
            Depo YeniDepo = new Depo();
            OdemeTuru YeniOdemeTuru = new OdemeTuru();
            //Kasa Aktarımı
            if (toggleKasaAktar.IsOn)
            {
                foreach (var item in kaynakContext.Kasalar.AsNoTracking().ToList())
                {
                    hedefContext.Kasalar.Add(item);
                }
            }
            else
            {
                YeniKasa.KasaKodu = "01";
                YeniKasa.KasaAdi = "Merkez Kasa";
                hedefContext.Kasalar.Add(YeniKasa);
            }

            //Depo Aktarımı
            if (toggleDepoAktar.IsOn)
            {
                foreach (var item in kaynakContext.Depolar.AsNoTracking().ToList())
                {
                    hedefContext.Depolar.Add(item);
                }
            }
            else
            {

                YeniDepo.DepoKodu = "01";
                YeniDepo.DepoAdi = "Merkez Depo";
                hedefContext.Depolar.Add(YeniDepo);
            }

            //Depo Aktarımı
            if (toggleOdemeTuruAktar.IsOn)
            {
                foreach (var item in kaynakContext.OdemeTurleri.AsNoTracking().ToList())
                {
                    hedefContext.OdemeTurleri.Add(item);
                }
            }
            else
            {

                YeniOdemeTuru.OdemeTuruKodu = "01";
                YeniOdemeTuru.OdemeTuruAdi = "Nakit";
                hedefContext.OdemeTurleri.Add(YeniOdemeTuru);
            }

            hedefContext.SaveChanges();
            //Tanım Aktarımı
            if (toggleTanimAktar.IsOn)
            {
                foreach (var item in kaynakContext.Tanimlar.AsNoTracking().ToList())
                {
                    hedefContext.Tanimlar.Add(item);
                }
            }

            //Kod Aktarımı
            if (toggleKodAktar.IsOn)
            {
                foreach (var item in kaynakContext.Kodlar.AsNoTracking().ToList())
                {
                    hedefContext.Kodlar.Add(item);
                }
            }

            //Ajanda Aktarımı
            if (toggleAjandaAktar.IsOn)
            {
                foreach (var item in kaynakContext.EFAppointments.AsNoTracking().ToList())
                {
                    hedefContext.EFAppointments.Add(item);
                }

                foreach (var item in kaynakContext.EFResources.AsNoTracking().ToList())
                {
                    hedefContext.EFResources.Add(item);
                }
            }

            //Kullanıcı Aktarımı
            if (toggleKullaniciAktar.IsOn)
            {
                foreach (var item in kaynakContext.Kullanicilar.AsNoTracking().ToList())
                {
                    hedefContext.Kullanicilar.Add(item);
                }

                foreach (var item in kaynakContext.KullaniciRolleri.AsNoTracking().ToList())
                {
                    hedefContext.KullaniciRolleri.Add(item);
                }
            }

            //Stok Aktarımı
            if (toggleStokAktar.IsOn)
            {
                StokDAL stokdal = new StokDAL();

                //İndirim Aktarımı
                if (toggleIndirimAktar.IsOn)
                {
                    foreach (var item in kaynakContext.Indirimler.AsNoTracking().ToList())
                    {
                        hedefContext.Indirimler.Add(item);
                    }
                }

                //Hızlı Satış Aktarımı
                if (toggleHizliSatisAktar.IsOn)
                {
                    foreach (var item in kaynakContext.HizliSatisGruplari.AsNoTracking().ToList())
                    {
                        hedefContext.HizliSatisGruplari.Add(item);
                    }

                    foreach (var item in kaynakContext.HizliSatislar.AsNoTracking().ToList())
                    {
                        hedefContext.HizliSatislar.Add(item);
                    }
                }

                foreach (var item in kaynakContext.Stoklar.AsNoTracking().ToList())
                {

                    hedefContext.Stoklar.Add(item);
                    if (toggleStokHareketAktar.IsOn && toggleStokGirisCikisAktar.IsOn)
                    {
                        StokBakiye bakiye = stokdal.StokBakiyesi(kaynakContext, item.Id);
                        if (bakiye.MevcutStok != 0)
                        {
                            Fis stokDevir = new Fis();
                            stokDevir.FisTuru = "Stok Devir Fişi";
                            stokDevir.FisKodu = kodOlustur.YeniFisOdemeKoduOlustur();
                            stokDevir.Tarih = DateTime.Now;
                            stokDevir.ToplamTutar = Math.Abs(bakiye.MevcutStok) * item.AlisFiyati1;
                            hedefContext.Fisler.Add(stokDevir);
                            StokHareket hareket = new StokHareket();
                            hareket.StokId = item.Id;
                            hareket.Hareket = bakiye.MevcutStok < 0 ? "Stok Çıkış" : "Stok Giriş";
                            hareket.Miktar = Math.Abs(bakiye.MevcutStok);
                            hareket.FisKodu = stokDevir.FisKodu;
                            hareket.BirimFiyati = item.AlisFiyati1;
                            hareket.Kdv = item.AlisKdv;
                            hareket.Tarih = DateTime.Now;
                            hareket.DepoId = toggleDepoAktar.IsOn ? Convert.ToInt32(lookUpDepo.EditValue) : YeniDepo.Id;
                            hedefContext.StokHareketleri.Add(hareket);
                        }
                    }
                    else
                    {
                        StokBakiye bakiye = stokdal.StokBakiyesi(kaynakContext, item.Id);
                        if (bakiye.MevcutStok != 0)
                        {
                            //Stok Giriş
                            Fis stokDevir = new Fis();
                            StokHareket hareketGiris = new StokHareket();


                            stokDevir.FisTuru = "Stok Devir Fişi";
                            stokDevir.FisKodu = kodOlustur.YeniFisOdemeKoduOlustur();
                            stokDevir.Tarih = DateTime.Now;
                            stokDevir.ToplamTutar = bakiye.StokGiris * item.AlisFiyati1;


                            hareketGiris.StokId = item.Id;
                            hareketGiris.Hareket = "Stok Giriş";
                            hareketGiris.Miktar = bakiye.StokGiris;
                            hareketGiris.FisKodu = stokDevir.FisKodu;
                            hareketGiris.BirimFiyati = item.AlisFiyati1;
                            hareketGiris.Kdv = item.AlisKdv;
                            hareketGiris.Tarih = DateTime.Now;
                            hareketGiris.DepoId =
                                toggleDepoAktar.IsOn ? Convert.ToInt32(lookUpDepo.EditValue) : YeniDepo.Id;
                            if (bakiye.StokGiris > 0)
                            {
                                hedefContext.Fisler.Add(stokDevir);
                                hedefContext.StokHareketleri.Add(hareketGiris);
                            }

                            //Stok Çıkış
                            if (bakiye.StokCikis > 0)
                            {
                                Fis stokCikisDevir = stokDevir.Clone();
                                stokCikisDevir.FisKodu = kodOlustur.YeniFisOdemeKoduOlustur();
                                stokCikisDevir.ToplamTutar = bakiye.StokCikis * item.AlisFiyati1;
                                hedefContext.Fisler.Add(stokCikisDevir);
                                StokHareket hareketCikis = hareketGiris.Clone();
                                hareketCikis.FisKodu = stokCikisDevir.FisKodu;
                                hareketCikis.Hareket = "Stok Çıkış";
                                hareketCikis.Miktar = bakiye.StokCikis;
                                hedefContext.StokHareketleri.Add(hareketCikis);
                            }


                        }
                    }
                }
            }

            //Cari Aktar
            if (toggleCariAktar.IsOn)
            {
                foreach (var item in kaynakContext.Cariler.AsNoTracking().ToList())
                {
                    hedefContext.Cariler.Add(item);
                    CariDAL cariDal = new CariDAL();
                    CariBakiye bakiye = cariDal.CariBakiyesi(kaynakContext, item.Id);
                    if (toggleCariBakiyeAktar.IsOn && toggleBorcVeAlacakAktar.IsOn)
                    {

                        if (bakiye.Bakiye != 0)
                        {
                            Fis cariDevir = new Fis();
                            cariDevir.CariId = item.Id;
                            cariDevir.FisTuru = "Cari Devir Fişi";
                            cariDevir.Tarih = DateTime.Now;
                            cariDevir.FisKodu = kodOlustur.YeniFisOdemeKoduOlustur();
                            cariDevir.ToplamTutar = Math.Abs(bakiye.Bakiye);
                            if (bakiye.Bakiye < 0)
                            {
                                cariDevir.Borc = Math.Abs(bakiye.Bakiye);
                                cariDevir.Alacak = null;
                                hedefContext.Fisler.Add(cariDevir);
                                KasaHareket kasaBorc = new KasaHareket();
                                kasaBorc.FisKodu = cariDevir.FisKodu;
                                kasaBorc.CariId = item.Id;
                                kasaBorc.Hareket = "Kasa Çıkış";
                                kasaBorc.KasaId = toggleKasaAktar.IsOn
                                    ? Convert.ToInt32(lookUpKasa.EditValue)
                                    : YeniKasa.Id;
                                kasaBorc.OdemeTuruId = toggleOdemeTuruAktar.IsOn
                                    ? Convert.ToInt32(lookUpOdemeTuru.EditValue)
                                    : YeniOdemeTuru.Id;
                                kasaBorc.Tarih = DateTime.Now;
                                kasaBorc.Tutar = Math.Abs(bakiye.Bakiye);
                                hedefContext.KasaHareketleri.Add(kasaBorc);
                            }
                            else
                            {
                                cariDevir.Alacak = Math.Abs(bakiye.Bakiye);
                                cariDevir.Borc = null;
                                hedefContext.Fisler.Add(cariDevir);
                                KasaHareket kasaAlacak = new KasaHareket();
                                kasaAlacak.FisKodu = cariDevir.FisKodu;
                                kasaAlacak.CariId = item.Id;
                                kasaAlacak.Hareket = "Kasa Giriş";
                                kasaAlacak.KasaId = toggleKasaAktar.IsOn
                                    ? Convert.ToInt32(lookUpKasa.EditValue)
                                    : YeniKasa.Id;
                                kasaAlacak.OdemeTuruId = toggleOdemeTuruAktar.IsOn
                                    ? Convert.ToInt32(lookUpOdemeTuru.EditValue)
                                    : YeniOdemeTuru.Id;
                                kasaAlacak.Tarih = DateTime.Now;
                                kasaAlacak.Tutar = Math.Abs(bakiye.Bakiye);
                                hedefContext.KasaHareketleri.Add(kasaAlacak);
                            }

                        }
                    }
                    else if (toggleCariBakiyeAktar.IsOn && !toggleBorcVeAlacakAktar.IsOn)
                    {
                        if (bakiye.Alacak != 0)
                        {
                            Fis alacakFis = new Fis();
                            alacakFis.CariId = item.Id;
                            alacakFis.FisTuru = "Cari Devir Fişi";
                            alacakFis.Tarih = DateTime.Now;
                            alacakFis.FisKodu = kodOlustur.YeniFisOdemeKoduOlustur();
                            alacakFis.Borc = null;
                            alacakFis.Alacak = bakiye.Alacak;
                            alacakFis.ToplamTutar = bakiye.Alacak;
                            hedefContext.Fisler.Add(alacakFis);

                            KasaHareket kasaAlacak = new KasaHareket();
                            kasaAlacak.FisKodu = alacakFis.FisKodu;
                            kasaAlacak.CariId = item.Id;
                            kasaAlacak.Hareket = "Kasa Giriş";
                            kasaAlacak.KasaId =
                                toggleKasaAktar.IsOn ? Convert.ToInt32(lookUpKasa.EditValue) : YeniKasa.Id;
                            kasaAlacak.OdemeTuruId = toggleOdemeTuruAktar.IsOn
                                ? Convert.ToInt32(lookUpOdemeTuru.EditValue)
                                : YeniOdemeTuru.Id;
                            kasaAlacak.Tarih = DateTime.Now;
                            kasaAlacak.Tutar = Math.Abs(bakiye.Alacak);
                            hedefContext.KasaHareketleri.Add(kasaAlacak);
                        }

                        if (bakiye.Borc != 0)
                        {
                            Fis borcFis = new Fis();
                            borcFis.CariId = item.Id;
                            borcFis.FisTuru = "Cari Devir Fişi";
                            borcFis.Tarih = DateTime.Now;
                            borcFis.FisKodu = kodOlustur.YeniFisOdemeKoduOlustur();
                            borcFis.Borc = bakiye.Borc;
                            borcFis.Alacak = null;
                            borcFis.ToplamTutar = bakiye.Alacak;
                            hedefContext.Fisler.Add(borcFis);

                            KasaHareket kasaBorc = new KasaHareket();
                            kasaBorc.FisKodu = borcFis.FisKodu;
                            kasaBorc.CariId = item.Id;
                            kasaBorc.Hareket = "Kasa Çıkış";
                            kasaBorc.KasaId =
                                toggleKasaAktar.IsOn ? Convert.ToInt32(lookUpKasa.EditValue) : YeniKasa.Id;
                            kasaBorc.OdemeTuruId = toggleOdemeTuruAktar.IsOn
                                ? Convert.ToInt32(lookUpOdemeTuru.EditValue)
                                : YeniOdemeTuru.Id;
                            kasaBorc.Tarih = DateTime.Now;
                            kasaBorc.Tutar = Math.Abs(bakiye.Alacak);
                            hedefContext.KasaHareketleri.Add(kasaBorc);
                        }
                    }
                }
            }

            if (togglePersonelAktar.IsOn)
            {
                foreach (var item in kaynakContext.Personeller.AsNoTracking().ToList())
                {
                    hedefContext.Personeller.Add(item);
                }
            }

            hedefContext.SaveChanges();
        }
        private void wizardControl1_SelectedPageChanging(object sender, DevExpress.XtraWizard.WizardPageChangingEventArgs e)
        {
            if (e.Page == wizardHedef && e.Direction == DevExpress.XtraWizard.Direction.Forward)
            {
                lookUpDepo.Properties.DataSource = kaynakContext.Depolar.ToList();
                lookUpKasa.Properties.DataSource = kaynakContext.Kasalar.ToList();
                lookUpOdemeTuru.Properties.DataSource = kaynakContext.OdemeTurleri.ToList();
            }

            if (e.Page == wizardHedef && e.Direction == Direction.Forward)
            {
                if (String.IsNullOrEmpty(seciliKaynak))
                {
                    MessageBox.Show("Lütfen bir kaynak veritabanı seçin.");
                    e.Cancel = true;
                }
            }
            if (e.Page == wizardAyar && e.Direction == Direction.Forward)
            {
                if (String.IsNullOrEmpty(seciliHedef))
                {
                    MessageBox.Show("Lütfen bir hedef veritabanı seçin.");
                    e.Cancel = true;
                }
            }
        }
    }
}