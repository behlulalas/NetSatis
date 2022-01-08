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
using System.Data.Entity;
using NetSatis.BackOffice.Stok;

namespace NetSatis.BackOffice.HizliSatis
{
    public partial class FrmHizliSatis : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        HizliSatisGrupDAL hsgDAL = new HizliSatisGrupDAL();
        HizliSatisDAL hsDAL = new HizliSatisDAL();

        public FrmHizliSatis()
        {
            InitializeComponent();
            context.HizliSatisGruplari.Load();
            context.HizliSatislar.Load();
            gridcontGrupEkle.DataSource = context.HizliSatisGruplari.Local.ToBindingList();
            gridcontUrunEkle.DataSource = context.HizliSatislar.Local.ToBindingList();
        }

        private void GetAll()
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KayitAc()
        {
            grpGrupBilgi.Enabled = true;
            btnYeniEkle.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = true;
            btnVazgec.Enabled = true;
            gridcontUrunEkle.Enabled = false;
            btnEkle.Enabled = false;
            btnSil2.Enabled = false;
        }

        private void KayitKapat()
        {
            grpGrupBilgi.Enabled = false;
            btnYeniEkle.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            btnVazgec.Enabled = false;
            gridcontUrunEkle.Enabled = true;
            btnEkle.Enabled = true;
            btnSil2.Enabled = true;
        }

        private void gridGrupEkle_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gridUrunEkle.ActiveFilterString = $"GrupId='{gridGrupEkle.GetFocusedRowCellValue(colId)}'";
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            KayitAc();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            KayitKapat();
            hsgDAL.AddOrUpdate(context, new Entities.Tables.HizliSatisGrup { GrupAdi = txtGrupAdi.Text, Aciklama = txtAciklama.Text, });
            hsgDAL.Save(context);
            txtAciklama.Text = null;
            txtGrupAdi.Text = null;
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            KayitKapat();
            txtAciklama.Text = null;
            txtGrupAdi.Text = null;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan grup ile birlikte bu gruba ait ürünler de silinecektir. silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int grupId = (int)gridGrupEkle.GetFocusedRowCellValue(colId);
                hsDAL.Delete(context, c => c.GrupId == grupId);
                gridGrupEkle.DeleteSelectedRows();
                hsDAL.Save(context);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmStokSec form = new FrmStokSec(true);
            form.ShowDialog();

            if (form.secildi)
            {
                foreach (var item in form.secilen)
                {
                    if (context.HizliSatislar.Count(c=>c.Barkod==item.Barkod)==0)
                    {
                        hsDAL.AddOrUpdate(context, new Entities.Tables.HizliSatis
                        {
                            Barkod = item.Barkod,
                            UrunAdi = item.StokAdi,
                            GrupId = (int)gridGrupEkle.GetFocusedRowCellValue(colId)
                        });
                        hsDAL.Save(context);
                    }
                }
            }
        }

        private void btnSil2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridUrunEkle.DeleteSelectedRows();
                hsDAL.Save(context);
            }
        }
    }
}