using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
using NetSatis.Entities.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Tools
{
    public class CodeTool
    {
        BarManager manager = new BarManager();
        PopupMenu menu;
        XtraForm _form;
        NetSatisContext _context = new NetSatisContext();
        private Table _table;
        public enum Table
        {
            Cari, Stok, Fis, Kasa, Depo, Personel
        }
        public CodeTool(XtraForm form, Table table)
        {
            _form = form;
            _table = table;
            manager.Form = _form;
            menu = new PopupMenu(manager);
        }

        public void BarButonOlustur()
        {
            _context = new NetSatisContext();
            string tabloAdi = _table.ToString();
            foreach (var item in _context.Kodlar.Where(c => c.Tablo == tabloAdi).ToList())
            {
                BarButtonItem butonItem = new BarButtonItem
                {
                    Name = "btnKod" + item.SonDeger,
                    Tag = item.Id,
                    Caption = KodOlustur(item.OnEki, item.SonDeger),
                    ImageOptions = { Image = NetSatis.Entities.Properties.Resources.promo }
                };
                butonItem.ItemClick += Buton_Click;
                menu.AddItem(butonItem);
            }

            BarButtonItem yeniButonItem = new BarButtonItem
            {
                Name = "btnYeniKodEkle",
                Caption = "Yeni Kod Oluştur",
                ImageOptions = { Image = NetSatis.Entities.Properties.Resources.add }
            };
            yeniButonItem.ItemClick += YeniButon_Click;
            menu.AddItem(yeniButonItem).BeginGroup = true;

            BarButtonItem Guncelle = new BarButtonItem
            {
                Name = "btnGuncelle",
                Caption = "Güncelle",
                ImageOptions = { Image = NetSatis.Entities.Properties.Resources.refresh }
            };
            Guncelle.ItemClick += Guncelle_Click;
            menu.AddItem(Guncelle);

            DropDownButton button = (DropDownButton)_form.Controls.Find("btnKod", true).SingleOrDefault();
            button.MenuManager = manager;
            button.DropDownControl = menu;
        }

        public void Methoddeneme()
        {
            BarButonSil();
            BarButonOlustur();
        }
        private void Guncelle_Click(object sender, ItemClickEventArgs e)
        {
            BarButonSil();
            BarButonOlustur();
        }

        private void BarButonSil()
        {
            menu.ItemLinks.Clear();
        }

        private void YeniButon_Click(object sender, ItemClickEventArgs e)
        {
            Type tip = Assembly.Load("NetSatis.BackOffice").GetTypes().SingleOrDefault(c => c.Name == "FrmKodlar");
            XtraForm form = (XtraForm)Activator.CreateInstance(tip, _table.ToString());
            form.ShowDialog();
            BarButonSil();
            BarButonOlustur();
        }

        public void Buton_Click(object sender, ItemClickEventArgs e)
        {
            TextEdit text = (TextEdit)_form.Controls.Find("txtKod", true).SingleOrDefault();
            text.Text = e.Item.Caption;
        }

        public string KodOlustur(string onEki, int sonDeger)
        {
            int sifirSayisi = 12 - (onEki.Length + sonDeger.ToString().Length);
            string sifirDizisi = new string('0', sifirSayisi);
            return onEki + sifirDizisi + sonDeger;
        }
        public void KodForText(string tablo,string onEki)
        {
            _context = new NetSatisContext();
            TextEdit text = (TextEdit)_form.Controls.Find("txtKod", true).SingleOrDefault();
            text.Text =KodOlustur(onEki, _context.Kodlar.SingleOrDefault(c => c.Tablo ==tablo &&c.OnEki==onEki).SonDeger);
        }
        public string YeniFisOdemeKoduOlustur()
        {
            var kod = _context.Kodlar.SingleOrDefault(c => c.OnEki == "FO" && c.Tablo == "Fis");
            string onEki = kod.OnEki;
            string sonDeger = kod.SonDeger.ToString(); ;
            int sifirSayisi = 12 - (onEki.Length + sonDeger.ToString().Length);
            string sifirDizisi = new string('0', sifirSayisi);
            kod.SonDeger++;
            _context.SaveChanges();
            return onEki + sifirDizisi + sonDeger;
        }
        public void KodArttirma()
        {
            TextEdit text = (TextEdit)_form.Controls.Find("txtKod", true).SingleOrDefault();
            BarItemLink buton = menu.ItemLinks.SingleOrDefault(c => c.Caption == text.Text);
            if (buton != null)
            {
                int Id = (int)buton.Item.Tag;
                _context.Kodlar.SingleOrDefault(c => c.Id == Id).SonDeger++;
                _context.SaveChanges();
            }
        }

        //public string KodOlustur(string OnEki, string Kod)
        //{
        //    int OnEkiUzunluk = OnEki.Length;
        //    int KodUzunluk = Kod.Length;
        //    int KalanKarakter = 12 - (OnEkiUzunluk + KodUzunluk);
        //    string SifirDizisi = null;
        //    for (int i = 0; i < KalanKarakter; i++)
        //    {
        //        SifirDizisi += "0";
        //    }
        //    return OnEki + SifirDizisi + Kod;
        //}
        //public static void DBTemizle()
        //{
        //    Database.SetInitializer(new MigrateDatabaseToLatestVersion<NetSatisContext,Configuration>());
        //}
    }
}
