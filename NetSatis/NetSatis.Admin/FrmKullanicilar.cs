using NetSatis.Entities.Context;
using NetSatis.Entities.DataAccess;
using NetSatis.Entities.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetSatis.Admin
{
    public partial class FrmKullanicilar : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context;
        KullaniciDAL kullaniciDAL = new KullaniciDAL();
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        private string secilen;
        public FrmKullanicilar()
        {

            
            InitializeComponent();
            FrmDonemSec frm = new FrmDonemSec();
            frm.ShowDialog();
            builder.ConnectionString = SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_BaglantiCumlesi);
            if (!String.IsNullOrEmpty(frm.secilenDonem))
            {
                builder.InitialCatalog = frm.secilenDonem;
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.DatabaseAyarlari_BaglantiCumlesi, builder.ConnectionString);
                context = new NetSatisContext();
                GetAll();

            }
        }

        private void GetAll()
        {
            gridcontKullanicilar.DataSource = kullaniciDAL.GetAll(context);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmKullaniciIslem frm = new FrmKullaniciIslem(new Entities.Tables.Kullanici());
            frm.ShowDialog();
            if (frm.saved)
            {
                GetAll();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = gridKullanicilar.GetFocusedRowCellValue(colKullaniciAdi).ToString();
            FrmKullaniciIslem frm = new FrmKullaniciIslem(kullaniciDAL.GetByFilter(context, c => c.KullaniciAdi == secilen));
            frm.ShowDialog();
            if (frm.saved)
            {
                GetAll();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context = new NetSatisContext();
                secilen = gridKullanicilar.GetFocusedRowCellValue(colKullaniciAdi).ToString();
                kullaniciDAL.Delete(context, c => c.KullaniciAdi == secilen);
                kullaniciDAL.Save(context);
                GetAll();
            }
        }

        private void FrmKullanicilar_Load(object sender, EventArgs e)
        {
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            FrmDevir frmDevir = new FrmDevir();
            frmDevir.ShowDialog();
        }
    }
}
