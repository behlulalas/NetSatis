using NetSatis.Admin;
using NetSatis.BackOffice.Ajanda;
using NetSatis.BackOffice.AnaMenu;
using NetSatis.BackOffice.Ayarlar;
using NetSatis.BackOffice.Cari;
using NetSatis.BackOffice.Depo;
using NetSatis.BackOffice.DovizKurlari;
using NetSatis.BackOffice.FakeData;
using NetSatis.BackOffice.Fis;
using NetSatis.BackOffice.FiyatDegistir;
using NetSatis.BackOffice.HizliSatis;
using NetSatis.BackOffice.Indirimler;
using NetSatis.BackOffice.Kasa;
using NetSatis.BackOffice.KasaHareketleri;
using NetSatis.BackOffice.Kod;
using NetSatis.BackOffice.OdemeTuru;
using NetSatis.BackOffice.Personel;
using NetSatis.BackOffice.Raporlar;
using NetSatis.BackOffice.Sms;
using NetSatis.BackOffice.Stok;
using NetSatis.BackOffice.StokHareketleri;
using NetSatis.BackOffice.Tanim;
using NetSatis.Backup;
using NetSatis.Entities.Context;
using NetSatis.Entities.DataAccess;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Tools;
using NetSatis.Reports.FaturaVeFis;
using NetSatis.Reports.Stok;
using NetSatis.Update;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace NetSatis.BackOffice
{
    public partial class NetSatis : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public NetSatis()
        {
            InitializeComponent();

            FrmKullaniciGiris frm = new FrmKullaniciGiris();
            frm.ShowDialog();
            try
            {
                barKullaniciAdi.Caption = $"Giriş Yapan Kullanıcı : {RoleTool.kullaniciEntity.KullaniciAdi}";
                barDatabase.Caption = $"Aktif Dönem: {frm.AktifDatabase}";
            }
            catch (Exception)
            {
            }
            WebClient indir = new WebClient();

            string programVersion = Assembly.Load("NetSatis.BackOffice").GetName().Version.ToString();
            string guncelVersion = indir.DownloadString("http://kozaapp.000webhostapp.com/downloads/Version.txt");
            if (programVersion != guncelVersion)
            {
                if (Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.GenelAyarlar_GuncellemeKontrol)))
                {
                    if (MessageBox.Show("Uygulamanın yeni bir versiyonu bulundu güncellemek ister misiniz ? Yeni Versiyon: " + guncelVersion, "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Process.Start($"{Application.StartupPath}\\NetSatis.Update.exe");
                    }
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            FrmAnaMenuBilgi frmanamenubilgi = new FrmAnaMenuBilgi();
            frmanamenubilgi.MdiParent = this;
            frmanamenubilgi.Show();
            RoleTool.RolleriYukle(ribbonControl1);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmStok frmStok = new FrmStok();
            frmStok.MdiParent = this;
            frmStok.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCari frmcari = new FrmCari();
            frmcari.MdiParent = this;
            frmcari.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFis frmfis = new FrmFis();
            frmfis.MdiParent = this;
            frmfis.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmStokHareketleri frmstokHareketleri = new FrmStokHareketleri();
            frmstokHareketleri.MdiParent = this;
            frmstokHareketleri.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKasaHareketleri frmKasaHareketleri = new FrmKasaHareketleri();
            frmKasaHareketleri.MdiParent = this;
            frmKasaHareketleri.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPersonel frmPersonel = new FrmPersonel();
            frmPersonel.MdiParent = this;
            frmPersonel.Show();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDepo frmDepo = new FrmDepo();
            frmDepo.MdiParent = this;
            frmDepo.Show();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKasa frmKasa = new FrmKasa();
            frmKasa.MdiParent = this;
            frmKasa.Show();
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmOdemeTuru frmOdemeTuru = new FrmOdemeTuru();
            frmOdemeTuru.MdiParent = this;
            frmOdemeTuru.Show();
        }

        private void FisIslem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFisIslem frm = new FrmFisIslem(null, e.Item.Caption);
            frm.ShowDialog();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTopluFiyat frmTopluFiyat = new FrmTopluFiyat();
            frmTopluFiyat.MdiParent = this;
            frmTopluFiyat.Show();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmIndirim frmIndirim = new FrmIndirim();
            frmIndirim.MdiParent = this;
            frmIndirim.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start($"{Application.StartupPath}\\NetSatis.FrontOffice.exe");
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmHizliSatis frmHizliSatis = new FrmHizliSatis();
            frmHizliSatis.ShowDialog();
            //frmFaker frmFaker = new frmFaker();
            //frmFaker.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmRaporListesi frmRaporListesi = new frmRaporListesi();
            frmRaporListesi.MdiParent = this;
            frmRaporListesi.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmRaporDuzenle frmRaporDuzenle = new FrmRaporDuzenle();
            frmRaporDuzenle.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmEtiketOlustur frmEtiketOlustur = new FrmEtiketOlustur();
            frmEtiketOlustur.ShowDialog();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOzgunRaporHazirla frm = new frmOzgunRaporHazirla();
            frm.Show();
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAjanda frm = new FrmAjanda();
            frm.Show();
        }

        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDovizKurlari frm = new FrmDovizKurlari();
            frm.ShowDialog();
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSms frm = new FrmSms();
            frm.Show();
        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAyarlar frmAyarlar = new FrmAyarlar();
            frmAyarlar.ShowDialog();
        }

        private void barButtonItem34_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBackUp frm = new FrmBackUp();
            frm.ShowDialog();
        }

        private void barButtonItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WebClient indir = new WebClient();

            string programVersion = Assembly.Load("NetSatis.BackOffice").GetName().Version.ToString();
            string guncelVersion = indir.DownloadString("https://kozaapp.000webhostapp.com/downloads/Version.txt");
            if (programVersion != guncelVersion)
            {
                Process.Start($"{Application.StartupPath}\\NetSatis.Update.exe");
            }
            else
            {
                MessageBox.Show("Uygulamanız güncel.");
            }

        }

        private void barButtonItem37_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKodlar frm = new FrmKodlar("");
            frm.ShowDialog();
        }
    }
}
