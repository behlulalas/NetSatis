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
using System.Printing;

namespace NetSatis.BackOffice.Ayarlar
{
    public partial class FrmAyarlar : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        DepoDAL depoDAL = new DepoDAL();
        KasaDAL kasaDAL = new KasaDAL();
        public FrmAyarlar()
        {
            InitializeComponent();
            cmbBilgiFisiYazici.Properties.Items.AddRange(YaziciListesi());
            cmbFaturaYazici.Properties.Items.AddRange(YaziciListesi());
            lookUpDepo.Properties.DataSource = depoDAL.GetAll(context);
            lookUpKasa.Properties.DataSource = kasaDAL.GetAll(context);
            lookUpDepo.EditValue = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanDepo);
            lookUpKasa.EditValue = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanKasa);
            cmbFaturaAyari.SelectedIndex = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_FaturaYazdirmaAyari));
            cmbFaturaYazici.Text =SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_FaturaYazici);
            cmbBilgiFisiAyari.SelectedIndex = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazdirmaAyari));
            cmbBilgiFisiYazici.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazici);
            toggleGuncelleme.IsOn = Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.GenelAyarlar_GuncellemeKontrol));
            txtFisKodu.Value=Convert.ToDecimal(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_FisKodu));
            txtFirmaAdi.Text=SettingsTool.AyarOku(SettingsTool.Ayarlar.FirmaAyarlari_FirmaAdi);
        }
        private List<string> YaziciListesi()
        {
            return new LocalPrintServer().GetPrintQueues().Select(c => c.Name).ToList();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_FisKodu, txtFisKodu.Value.ToString());
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.FirmaAyarlari_FirmaAdi, txtFirmaAdi.Text);
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanDepo, lookUpDepo.EditValue.ToString());
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanKasa, lookUpKasa.EditValue.ToString());
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_FaturaYazdirmaAyari, cmbFaturaAyari.SelectedIndex.ToString());
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_FaturaYazici, cmbFaturaYazici.Text);
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazdirmaAyari, cmbBilgiFisiAyari.SelectedIndex.ToString());
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazici, cmbBilgiFisiYazici.Text);
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.GenelAyarlar_GuncellemeKontrol, toggleGuncelleme.IsOn.ToString());
            SettingsTool.Save();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}