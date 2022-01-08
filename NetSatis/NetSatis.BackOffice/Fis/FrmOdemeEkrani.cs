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
using NetSatis.BackOffice.Kasa;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Tools;
using NetSatis.Entities.Context;

namespace NetSatis.BackOffice.Fis
{
    public partial class FrmOdemeEkrani : DevExpress.XtraEditors.XtraForm
    {
        public KasaHareket entity;
        NetSatisContext context = new NetSatisContext();
        string kasaAdi = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanKasa);
        decimal? _odenmesiGereken;
        private Entities.Tables.Kasa _kasabilgi;
        private Entities.Tables.OdemeTuru _odemeTuruBilgi;
        public FrmOdemeEkrani(int odemeTuruId, decimal? odenmesiGereken = null)
        {
            InitializeComponent();
            int kasaId = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanKasa));
            _kasabilgi = context.Kasalar.SingleOrDefault(c => c.Id == kasaId);
            _odemeTuruBilgi = context.OdemeTurleri.SingleOrDefault(c => c.Id == odemeTuruId);
            txtOdemeTuru.Text = _odemeTuruBilgi.OdemeTuruAdi;
            txtKasaKodu.Text = _kasabilgi.KasaKodu;
            txtKasaAdi.Text = _kasabilgi.KasaAdi;
            if (odenmesiGereken != null)
            {
                _odenmesiGereken = odenmesiGereken.Value;
            }
            else
            {
                txtTutar.Properties.Buttons[1].Visible = false;
            }
        }

        private void btnKasaSec_Click(object sender, EventArgs e)
        {
            FrmKasaSec frm = new FrmKasaSec();
            frm.ShowDialog();
            if (frm.secildi)
            {
                _kasabilgi = context.Kasalar.SingleOrDefault(c => c.Id == frm.entity.Id);
                txtKasaKodu.Text = frm.entity.KasaKodu;
                txtKasaAdi.Text = frm.entity.KasaAdi;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string message = null;
            int hata = 0;
            if (txtKasaKodu.Text == "")
            {
                message += "Kasa Kodu Bilgisi boş geçilemez." + System.Environment.NewLine;
                hata++;
            }
            if (txtTutar.Value <= 0)
            {
                message += "Ödeme Tutarı 0 dan büyük olmalıdır." + System.Environment.NewLine;
                hata++;
            }
            if (txtTutar.Value > _odenmesiGereken && _odenmesiGereken != null)
            {
                message += "Ödeme Tutarı ödenmesi gereken tutardan dan büyük olamaz." + System.Environment.NewLine;
                hata++;
            }
            if (hata != 0)
            {
                MessageBox.Show(message, "Hata Listesi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            entity = new KasaHareket();
            entity.OdemeTuruId = _odemeTuruBilgi.Id;
            entity.KasaId = _kasabilgi.Id;
            entity.Tutar = txtTutar.Value;
            entity.Tarih = DateTime.Now;
            entity.Aciklama = txtAciklama.Text;
            this.Close();

        }

        private void txtTutar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                txtTutar.Value = _odenmesiGereken.Value;
            }
        }
    }
}