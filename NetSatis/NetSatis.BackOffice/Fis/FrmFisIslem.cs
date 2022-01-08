using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
using NetSatis.Entities.DataAccess;
using System.Data.Entity;
using NetSatis.Entities.Tables;
using NetSatis.BackOffice.Stok;
using NetSatis.BackOffice.Cari;
using NetSatis.BackOffice.Depo;
using NetSatis.BackOffice.Kasa;
using NetSatis.Entities.Tables.OtherTables;
using NetSatis.Entities.Tools;
using NetSatis.BackOffice.Personel;

namespace NetSatis.BackOffice.Fis
{

    public partial class FrmFisIslem : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        FisDAL fisDal = new FisDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        PersonelHareketDAL personelHareketDal = new PersonelHareketDAL();
        CariDAL cariDal = new CariDAL();
        private int? _cariId;
        FisAyarlari ayarlar = new FisAyarlari();
        Entities.Tables.Fis _fisentity = new Entities.Tables.Fis();
        CariBakiye _entityBakiye = new CariBakiye();
        public bool saved = false;
        CodeTool kodOlustur;
        public FrmFisIslem(string fisKodu = null, string fisTuru = null, int? cariId = null, bool siparisFaturalandir = false)
        {
            InitializeComponent();

            kodOlustur = new CodeTool(this, CodeTool.Table.Fis);
            kodOlustur.BarButonOlustur();
            context.Stoklar.Load();
            context.Depolar.Load();
            context.Kasalar.Load();
            if (fisKodu != null)
            {
                _fisentity = context.Fisler.SingleOrDefault(c => c.FisKodu == fisKodu);
                if (siparisFaturalandir)
                {
                    _fisentity.FisTuru = "Perakende Satış Faturası";
                }
                context.StokHareketleri.Where(c => c.FisKodu == fisKodu).Load();
                if (String.IsNullOrEmpty(_fisentity.FisBaglantiKodu))
                {
                    context.KasaHareketleri.Where(c => c.FisKodu == fisKodu).Load();
                }
                else
                {
                    context.KasaHareketleri.Where(c => c.FisKodu == _fisentity.FisBaglantiKodu).Load();
                }
                context.PersonelHareketleri.Where(c => c.FisKodu == fisKodu).Load();
                toggleSwitch1.IsOn = context.KasaHareketleri.Count(c => c.FisKodu == fisKodu && c.Hareket == "Kasa Giriş") == 0;

                if (_fisentity.CariId != null)
                {
                    lblCariAdi.Text = _fisentity.Cari.CariAdi;
                    lblCariKodu.Text = _fisentity.Cari.CariKodu;
                    _entityBakiye = this.cariDal.CariBakiyesi(context, Convert.ToInt32(_fisentity.CariId));
                    lblAlacak.Text = _entityBakiye.Alacak.ToString("C2");
                    lblBorc.Text = _entityBakiye.Borc.ToString("C2");
                    lblBakiye.Text = _entityBakiye.Bakiye.ToString("C2");
                }
            }
            else
            {
                _fisentity.FisTuru = fisTuru;
                //_fisentity.Tarih = DateTime.Now;
            }

            txtKod.DataBindings.Add("Text", _fisentity, "FisKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtFisTuru.DataBindings.Add("Text", _fisentity, "FisTuru", false, DataSourceUpdateMode.OnPropertyChanged);
            dateTarih.DataBindings.Add("EditValue", _fisentity, "Tarih", true, DataSourceUpdateMode.OnPropertyChanged, DateTime.Now);
            txtBelgeNo.DataBindings.Add("Text", _fisentity, "BelgeNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _fisentity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);

            txtFaturaUnvani.DataBindings.Add("Text", _fisentity, "FaturaUnvani", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCepTelefonu.DataBindings.Add("Text", _fisentity, "Telefon", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIl.DataBindings.Add("Text", _fisentity, "Il", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIlce.DataBindings.Add("Text", _fisentity, "Ilce", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSemt.DataBindings.Add("Text", _fisentity, "Semt", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdres.DataBindings.Add("Text", _fisentity, "Adres", false, DataSourceUpdateMode.OnPropertyChanged);
            txtVergiDairesi.DataBindings.Add("Text", _fisentity, "VergiDairesi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtVergiNo.DataBindings.Add("Text", _fisentity, "VergiNo", false, DataSourceUpdateMode.OnPropertyChanged);


            cmbAy.Month = DateTime.Now.Month;
            for (int i = DateTime.Now.Year - 2; i <= DateTime.Now.Year + 2; i++)
            {
                cmbYil.Properties.Items.Add(i);
            }
            cmbYil.Text = DateTime.Now.Year.ToString();

            gridcontStokHareket.DataSource = context.StokHareketleri.Local.ToBindingList();
            gridcontKasaHareket.DataSource = context.KasaHareketleri.Local.ToBindingList();
            gridcontPersonelHareket.DataSource = context.PersonelHareketleri.Local.ToBindingList();
            FisAyar();
            Toplamlar();
            OdenenTutarGuncelle();
            ButonlariYukle();
        }
        private void ButonlariYukle()
        {
            foreach (var item in context.OdemeTurleri.ToList())
            {
                var buton = new SimpleButton
                {
                    Name = item.OdemeTuruKodu,
                    Tag = item.Id,
                    Text = item.OdemeTuruAdi,
                    Height = 42,
                    Width = 125
                };
                buton.Click += OdemeEkle_Click;
                flowOdemeTurleri.Controls.Add(buton);
            }


            var PersonelSecimIptal = new CheckButton
            {
                Name = "Yok",
                Text = "Yok",
                GroupIndex = 1,
                Height = 42,
                Width = 125,
                Checked = _fisentity.PlasiyerId == null
            };
            PersonelSecimIptal.Click += PersonelYukle_Click;
            flowPersonel.Controls.Add(PersonelSecimIptal);
            foreach (var item in context.Personeller.ToList())
            {
                var buton = new CheckButton
                {
                    Name = item.Id.ToString(),
                    Text = item.PersonelAdi,
                    GroupIndex = 1,
                    Height = 42,
                    Width = 125,
                    Checked = item.Id == _fisentity.PlasiyerId
                };

                buton.Click += PersonelYukle_Click;
                flowPersonel.Controls.Add(buton);
            }
        }
        private void PersonelYukle_Click(object sender, EventArgs e)
        {

            var buton = sender as CheckButton;
            if (buton.Name == "Yok")
            {
                _fisentity.PlasiyerId = null;
            }
            else
            {
                _fisentity.PlasiyerId = Convert.ToInt32(buton.Name);
            }


        }
        private void FisAyar()
        {

            switch (_fisentity.FisTuru)
            {
                case "Alış Faturası":
                    ayarlar.StokHareketi = "Stok Giriş";
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = true;
                    ayarlar.BakiyeTuru = "Alacak";
                    lblBaslik.Appearance.ImageIndex = 0;
                    navPersonelIslem.Dispose();
                    break;
                case "Perakende Satış Faturası":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = true;
                    ayarlar.BakiyeTuru = "Borç";
                    lblBaslik.Appearance.ImageIndex = 1;
                    navPersonelIslem.Dispose();
                    break;
                case "Toptan Satış Faturası":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = true;
                    ayarlar.BakiyeTuru = "Borç";
                    lblBaslik.Appearance.ImageIndex = 2;
                    navPersonelIslem.Dispose();
                    break;
                case "Alış İade Faturası":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = true;
                    ayarlar.BakiyeTuru = "Borç";
                    lblBaslik.Appearance.ImageIndex = 3;
                    navPersonelIslem.Dispose();
                    break;
                case "Satış İade Faturası":
                    ayarlar.StokHareketi = "Stok Giriş";
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    ayarlar.BakiyeTuru = "Alacak";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = true;
                    lblBaslik.Appearance.ImageIndex = 4;
                    navPersonelIslem.Dispose();
                    break;
                case "Sayım Fazlası Fişi":
                    ayarlar.StokHareketi = "Stok Giriş";
                    lblBaslik.Appearance.ImageIndex = 5;
                    ayarlar.OdemeEkrani = false;
                    ayarlar.SatisEkrani = true;
                    panelOdemeler.Visible = false;
                    navOdemeEkrani.Dispose();
                    navCariBilgi.Dispose();
                    navPersonelIslem.Dispose();
                    break;
                case "Sayım Eksiği Fişi":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    lblBaslik.Appearance.ImageIndex = 6;
                    ayarlar.OdemeEkrani = false;
                    ayarlar.SatisEkrani = true;
                    panelOdemeler.Visible = false;
                    navOdemeEkrani.Dispose();
                    navCariBilgi.Dispose();
                    navPersonelIslem.Dispose();
                    break;
                case "Stok Devir Fişi":
                    ayarlar.StokHareketi = "Stok Giriş";
                    lblBaslik.Appearance.ImageIndex = 7;
                    ayarlar.OdemeEkrani = false;
                    ayarlar.SatisEkrani = true;
                    panelOdemeler.Visible = false;
                    navOdemeEkrani.Dispose();
                    navCariBilgi.Dispose();
                    navPersonelIslem.Dispose();
                    break;

                case "Tahsilat Fişi":
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = false;
                    navSatisEkrani.Dispose();
                    ayarlar.BakiyeTuru = "Alacak";
                    navPersonelIslem.Dispose();
                    panelOdemeler.Visible = false;
                    panelIndirim.Visible = false;
                    panelKDV.Visible = false;
                    panelGenelToplam.Top = 20;
                    grpToplamlar.Height = 65;
                    navigationPane2.SelectedPage = navOdemeEkrani;
                    break;
                case "Ödeme Fişi":
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.BakiyeTuru = "Borç";
                    ayarlar.SatisEkrani = false;
                    navSatisEkrani.Dispose();
                    navPersonelIslem.Dispose();
                    panelOdemeler.Visible = false;
                    panelIndirim.Visible = false;
                    panelKDV.Visible = false;
                    panelGenelToplam.Top = 20;
                    grpToplamlar.Height = 65;
                    navigationPane2.SelectedPage = navOdemeEkrani;
                    break;

                case "Cari Devir Fişi":
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = false;
                    navSatisEkrani.Dispose();
                    navPersonelIslem.Dispose();
                    panelOdemeler.Visible = false;
                    panelIndirim.Visible = false;
                    panelKDV.Visible = false;
                    panelGenelToplam.Top = 20;
                    grpToplamlar.Height = 65;
                    panelCariDevir.Visible = true;
                    navigationPane2.SelectedPage = navOdemeEkrani;
                    //txtFisKodu.Width = 186;

                    break;

                case "Hakediş Fişi":
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = false;
                    navSatisEkrani.Dispose();
                    navCariBilgi.Dispose();
                    navPlasiyerBilgi.Dispose();
                    panelIndirim.Visible = false;
                    panelKDV.Visible = false;
                    navigationPane2.SelectedPage = navPersonelIslem;
                    break;
                case "Sipariş Fişi(Alınan)":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    lblBaslik.Appearance.ImageIndex = 8;
                    ayarlar.OdemeEkrani = false;
                    ayarlar.SatisEkrani = true;
                    panelOdemeler.Visible = false;
                    navOdemeEkrani.Dispose();
                    navPersonelIslem.Dispose();
                    break;
                case "Sipariş Fişi(Verilen)":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    lblBaslik.Appearance.ImageIndex = 9;
                    ayarlar.OdemeEkrani = false;
                    ayarlar.SatisEkrani = true;
                    panelOdemeler.Visible = false;
                    navOdemeEkrani.Dispose();
                    navPersonelIslem.Dispose();
                    break;
            }
        }
        private void OdemeEkle_Click(object sender, EventArgs e)
        {
            var buton = (sender as SimpleButton);
            if (ayarlar.SatisEkrani == false && txtFisTuru.Text != "Hakediş Fişi")
            {
                FrmOdemeEkrani form = new FrmOdemeEkrani(Convert.ToInt32(buton.Tag));
                form.ShowDialog();
                if (form.entity != null)
                {
                    kasaHareketDal.AddOrUpdate(context, form.entity);
                    OdenenTutarGuncelle();
                }
            }
            else
            {
                if (calcOdenmesiGereken.Value <= 0)
                {
                    MessageBox.Show("Ödenmesi gereken tutar zaten ödenmiş durumdadır.");
                }
                else
                {
                    if (txtFisTuru.Text != "Hakediş Fişi")
                    {
                        KasaHareket entityKasaHareket = new KasaHareket
                        {
                            OdemeTuruId = Convert.ToInt32(buton.Tag),
                            KasaId = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanKasa)),
                            Tarih = DateTime.Now,
                            Tutar = calcOdenmesiGereken.Value
                        };
                        kasaHareketDal.AddOrUpdate(context, entityKasaHareket);
                        OdenenTutarGuncelle();
                    }
                    else
                    {
                        for (int i = 0; i < gridPersonelHareket.RowCount; i++)
                        {
                            KasaHareket entityKasaHareket = new KasaHareket
                            {
                                //Burayı Kontrol Et. Sıkıntı Olacak.
                                CariId = _cariId,
                                OdemeTuruId = Convert.ToInt32(buton.Tag),
                                Tarih = DateTime.Now,
                                Tutar = Convert.ToDecimal(gridPersonelHareket.GetRowCellValue(i, colOdenecekTutar)),
                                Aciklama = $"{gridPersonelHareket.GetRowCellValue(i, colPersonelKodu).ToString()} - {gridPersonelHareket.GetRowCellValue(i, colPersonelAdi).ToString()} || Aylık Maaş : {Convert.ToDecimal(gridPersonelHareket.GetRowCellValue(i, colAylikMaasi)).ToString("C2")} || Prim Tutarı : {Convert.ToDecimal(gridPersonelHareket.GetRowCellValue(i, colPrimTutari)).ToString("C2")}"
                            };
                            kasaHareketDal.AddOrUpdate(context, entityKasaHareket);
                        }
                        OdenenTutarGuncelle();
                    }


                }
            }
        }
        private void OdenenTutarGuncelle()
        {
            gridKasaHareket.UpdateSummary();
            if (ayarlar.SatisEkrani || _fisentity.FisTuru == "Hakediş Fişi")
            {
                calcOdenenTutar.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
                calcOdenmesiGereken.Value = calcGenelToplam.Value - calcOdenenTutar.Value;
            }
            else
            {
                calcGenelToplam.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
            }

        }
        private StokHareket StokSec(Entities.Tables.Stok entity)
        {
            StokHareket stokHareket = new StokHareket();
            IndirimDAL indirimDal = new IndirimDAL();
            stokHareket.StokId = entity.Id;
            stokHareket.IndirimOrani = indirimDal.StokIndirimi(context, entity.StokKodu);
            stokHareket.DepoId = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanDepo));
            stokHareket.BirimFiyati = new[] { "Alış Faturası", "Alış İade Faturası" }.Contains(txtFisTuru.Text) ? entity.AlisFiyati1 : entity.SatisFiyati1;
            stokHareket.Miktar = calMiktar.Value;
            stokHareket.Tarih = DateTime.Now;
            stokHareket.Kdv = entity.SatisKdv;
            return stokHareket;
        }
        private void btnUrunBul_Click(object sender, EventArgs e)
        {
            FrmStokSec form = new FrmStokSec();
            form.ShowDialog();
            if (form.secildi)
            {
                stokHareketDal.AddOrUpdate(context, StokSec(form.secilen.First()));
                Toplamlar();
            }
        }
        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Entities.Tables.Stok entity; entity = context.Stoklar.Where(c => c.Barkod == txtBarkod.Text).SingleOrDefault();
                if (entity != null)
                {
                    stokHareketDal.AddOrUpdate(context, StokSec(entity));
                    Toplamlar();
                }
                else
                {
                    MessageBox.Show("Aradığınız barkod numarası ürünler arasında bulunamadı.");
                }
                txtBarkod.Text = null;
            }
        }
        private void btnCariTemizle_Click(object sender, EventArgs e)
        {
            _cariId = null;
            _fisentity.CariId = null;
            lblCariKodu.Text = null; lblCariAdi.Text = null;
            txtFaturaUnvani.Text = null;
            txtVergiDairesi.Text = null;
            txtVergiNo.Text = null;
            txtCepTelefonu.Text = null;
            txtIl.Text = null;
            txtIlce.Text = null;
            txtSemt.Text = null;
            txtAdres.Text = null;
            lblAlacak.Text = "Görüntülenemiyor";
            lblBorc.Text = "Görüntülenemiyor";
            lblBakiye.Text = "Görüntülenemiyor";
        }
        private void btnCariSec_Click(object sender, EventArgs e)
        {
            FrmCariSec form = new FrmCariSec();
            form.ShowDialog();
            if (form.secildi)
            {
                Entities.Tables.Cari entity = form.secilen.FirstOrDefault();
                _entityBakiye = this.cariDal.CariBakiyesi(context, entity.Id);
                _cariId = entity.Id;
                _fisentity.CariId = entity.Id;
                lblCariKodu.Text = entity.CariKodu;
                lblCariAdi.Text = entity.CariAdi;
                txtFaturaUnvani.Text = entity.FaturaUnvani;
                txtVergiDairesi.Text = entity.VergiDairesi;
                txtVergiNo.Text = entity.VergiNo;
                txtCepTelefonu.Text = entity.CepTelefonu;
                txtIl.Text = entity.Il;
                txtIlce.Text = entity.Ilce;
                txtSemt.Text = entity.Semt;
                txtAdres.Text = entity.Adres;
                lblAlacak.Text = _entityBakiye.Alacak.ToString("C2");
                lblBorc.Text = _entityBakiye.Borc.ToString("C2");
                lblBakiye.Text = _entityBakiye.Bakiye.ToString("C2");
            }
        }
        private void Toplamlar()
        {
            gridStokHareket.UpdateSummary();
            gridPersonelHareket.UpdateSummary(); calcIskontoTutar.Value = Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue) / 100 * calcIskontoOran.Value;
            if (_fisentity.FisTuru == "Hakediş Fişi")
            {
                calcGenelToplam.Value = Convert.ToDecimal(colOdenecekTutar.SummaryItem.SummaryValue);
            }
            else
            {
                calcGenelToplam.Value = Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue) - calcIskontoTutar.Value;
            }
            calcOdenmesiGereken.Value = calcGenelToplam.Value - calcOdenenTutar.Value;
            calcKDVToplam.Value = Convert.ToDecimal(colToplamKDV.SummaryItem.SummaryValue);
            calcIndirimToplam.Value = Convert.ToDecimal(colIndirimTutar.SummaryItem.SummaryValue);

        }
        private void gridStokHareket_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Toplamlar();
        }
        private void calcIskontoOran_Validated(object sender, EventArgs e)
        {
            Toplamlar();
        }
        private void repoDepoAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                FrmDepoSec form = new FrmDepoSec(Convert.ToInt32(gridStokHareket.GetFocusedRowCellValue(colStokId)));
                form.ShowDialog();
                if (form.secildi)
                {
                    gridStokHareket.SetFocusedRowCellValue(colDepoId, form.entity.Id);
                    context.ChangeTracker.DetectChanges();
                    gridStokHareket.RefreshRow(gridStokHareket.FocusedRowHandle);
                }
            }
        }
        private void repoBirimFiyat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string fiyatSecilen = gridStokHareket.GetFocusedRowCellValue(colStokKodu).ToString();
            Entities.Tables.Stok fiyatEntity = context.Stoklar.Where(c => c.StokKodu == fiyatSecilen).SingleOrDefault();
            barFiyat1.Tag = txtFisTuru.Text == "Alış Faturası" ? fiyatEntity.AlisFiyati1 ?? 0 : fiyatEntity.SatisFiyati1 ?? 0;
            barFiyat2.Tag = txtFisTuru.Text == "Alış Faturası"
                ? fiyatEntity.AlisFiyati2 ?? 0
                : fiyatEntity.SatisFiyati2 ?? 0;
            barFiyat3.Tag = txtFisTuru.Text == "Alış Faturası"
                ? fiyatEntity.AlisFiyati3 ?? 0
                : fiyatEntity.SatisFiyati3 ?? 0;
            barFiyat1.Caption = string.Format("{0:C2}", barFiyat1.Tag);
            barFiyat2.Caption = string.Format("{0:C2}", barFiyat2.Tag);
            barFiyat3.Caption = string.Format("{0:C2}", barFiyat3.Tag);

            radialFiyat.ShowPopup(MousePosition);


        }
        private void FiyatSec(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridStokHareket.SetFocusedRowCellValue(colBirimFiyati, Convert.ToDecimal(e.Item.Tag));
        }
        private void repoSeriNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string veri = Convert.ToString(gridStokHareket.GetFocusedRowCellValue(colSeriNo));
            FrmSeriNoGir form = new FrmSeriNoGir(veri);
            form.ShowDialog();
            gridStokHareket.SetFocusedRowCellValue(colSeriNo, form.veriSeriNo);
        }
        private void repoSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridStokHareket.DeleteSelectedRows();
                Toplamlar();
            }
        }
        private void repoKasaAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmKasaSec form = new FrmKasaSec();
            form.ShowDialog();
            if (form.secildi)
            {
                gridKasaHareket.SetFocusedRowCellValue(colKasaId, form.entity.Id);
                context.ChangeTracker.DetectChanges();
                gridKasaHareket.RefreshRow(gridKasaHareket.FocusedRowHandle);
            }
        }
        private void repoKHsil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridKasaHareket.DeleteSelectedRows();
                OdenenTutarGuncelle();
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (_fisentity.FisTuru == "Cari Devir Fişi")
            {
                if (toggleSwitch1.IsOn)
                {
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                }
                else
                {
                    ayarlar.KasaHareketi = "Kasa Giriş";
                }
            }


            string message = null;
            int hata = 0;
            if (gridStokHareket.RowCount == 0 && ayarlar.SatisEkrani == true)
            {
                message += "Satış Ekranında eklenmiş bir ürün bulunamadı." + System.Environment.NewLine;
                hata++;
            }
            if (_fisentity.CariId == null && ayarlar.SatisEkrani == false && txtFisTuru.Text != "Hakediş Fişi")
            {
                message += txtFisTuru.Text + " türünde cari seçimi zorunludur." + System.Environment.NewLine;
                hata++;
            }

            if (gridKasaHareket.RowCount == 0 && ayarlar.SatisEkrani == false && txtFisTuru.Text != "Hakediş Fişi")
            {
                message += "Herhangi bir ödeme bulunamadı." + System.Environment.NewLine;
                hata++;
            }
            if (txtKod.Text == "")
            {
                message += "Fiş Kodu alanı boş geçilemez." + System.Environment.NewLine;
                hata++;
            }
            if (calcOdenmesiGereken.Value != 0 && ayarlar.OdemeEkrani == true && String.IsNullOrEmpty(lblCariKodu.Text) && txtFisTuru.Text != "Hakediş Fişi")
            {
                message += "Ödenmesi gereken tutar ödenmemiş görünüyor. Ödenmeyen kısmı açık hesaba aktarabilmeniz için Cari seçmeniz gerekmektedir." + System.Environment.NewLine;
                hata++;

            }

            if (hata != 0)
            {
                MessageBox.Show(message);
                return;
            }

            if (calcOdenmesiGereken.Value != 0 && ayarlar.OdemeEkrani == true)
            {
                if (MessageBox.Show($"Ödemenin {calcOdenmesiGereken.Value.ToString("C2")} tutarındaki kısmı açık hesap bakiyesi olarak kaydedilecektir. Devam etmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    MessageBox.Show("İsteğiniz üzerine işlem iptal edildi.");
                    return;
                }
            }

            foreach (var stokVeri in context.StokHareketleri.Local.ToList())
            {
                stokVeri.Tarih = stokVeri.Tarih == null
                    ? Convert.ToDateTime(dateTarih.DateTime)
                    : Convert.ToDateTime(stokVeri.Tarih);
                stokVeri.FisKodu = txtKod.Text;
                stokVeri.Hareket = ayarlar.StokHareketi;
                stokVeri.Siparis = txtFisTuru.Text.Contains("Sipariş Fişi") ? stokVeri.Siparis = true : stokVeri.Siparis = false;
            }

            foreach (var itemHareket in context.PersonelHareketleri.Local.ToList())
            {
                itemHareket.FisKodu = txtKod.Text;
            }

            if (ayarlar.BakiyeTuru == "Borç")
            {
                _fisentity.Borc = calcGenelToplam.Value;
            }
            else if (ayarlar.BakiyeTuru == "Alacak")
            {
                _fisentity.Alacak = calcGenelToplam.Value;
            }

            _fisentity.ToplamTutar = calcGenelToplam.Value;
            _fisentity.IskontoOrani = calcIskontoOran.Value;
            _fisentity.IskontoTutar = calcIskontoTutar.Value;
            _fisentity.Tarih = _fisentity.Tarih ?? DateTime.Now;
            fisDal.AddOrUpdate(context, _fisentity);


            if (ayarlar.OdemeEkrani)
            {
                Entities.Tables.Fis fisOdeme = new Entities.Tables.Fis();
                if (String.IsNullOrEmpty(_fisentity.FisBaglantiKodu))
                {
                    fisOdeme = _fisentity.Clone();
                    fisOdeme.FisTuru = "Fiş Ödemesi";
                    fisOdeme.Id = -1;
                    fisOdeme.FisKodu = kodOlustur.YeniFisOdemeKoduOlustur();
                    fisOdeme.FisBaglantiKodu = _fisentity.FisKodu;
                }
                else
                {
                    fisOdeme = context.Fisler.SingleOrDefault(c => c.FisKodu == _fisentity.FisBaglantiKodu);
                }
                _fisentity.FisBaglantiKodu = fisOdeme.FisKodu;
                if (ayarlar.BakiyeTuru == "Borç")
                {
                    fisOdeme.Alacak = calcOdenenTutar.Value;
                    fisOdeme.Borc = null;
                }
                else if (ayarlar.BakiyeTuru == "Alacak")
                {
                    fisOdeme.Borc = calcOdenenTutar.Value;
                    fisOdeme.Alacak = null;

                }
                fisOdeme.ToplamTutar = calcOdenenTutar.Value;
                foreach (var kasaVeri in context.KasaHareketleri.Local.ToList())
                {
                    kasaVeri.Tarih = kasaVeri.Tarih == null
                        ? Convert.ToDateTime(dateTarih.DateTime)
                        : Convert.ToDateTime(kasaVeri.Tarih);
                    kasaVeri.FisKodu = fisOdeme.FisKodu;
                    kasaVeri.Hareket = ayarlar.KasaHareketi;
                    if (txtFisTuru.Text != "Hakediş Fişi")
                    {
                        kasaVeri.CariId = _cariId;
                    }

                }

                fisDal.AddOrUpdate(context, fisOdeme);

            }

            saved = true;
            kodOlustur.KodArttirma();
            context.SaveChanges();
            this.Close();


        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (gridStokHareket.RowCount != 0)
            {
                if (MessageBox.Show(
                        "Satış Ekranına eklenmiş ürünler var. Bu işlemi iptal edip formu kapatmak istediğinize emin misiniz?",
                        "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
        private void btnPersonelBul_Click(object sender, EventArgs e)
        {
            DateTime time = new DateTime(Convert.ToInt32(cmbYil.Text), cmbAy.Month, 1);
            FrmPersonelSec form = new FrmPersonelSec(time);
            form.ShowDialog();
            if (form.secildi)
            {
                foreach (var itemHareket in form.secilen.ToList())
                {
                    if (context.PersonelHareketleri.Local.Count(c => c.Donemi == time && c.PersonelKodu == itemHareket.PersonelKodu) == 0)
                    {
                        personelHareketDal.AddOrUpdate(context, itemHareket);
                    }
                }
                Toplamlar();
            }
        }
        private void dateTarih_Properties_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                dateTarih.DateTime = DateTime.Now;
            }
        }
    }
}