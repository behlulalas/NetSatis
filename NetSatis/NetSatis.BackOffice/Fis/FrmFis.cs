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

namespace NetSatis.BackOffice.Fis
{
    public partial class FrmFis : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        FisDAL fisDAL = new FisDAL();
        KasaHareketDAL kasaHareketDAL = new KasaHareketDAL();
        StokHareketDAL stokHareketDAL = new StokHareketDAL();
        private string secilen;
        ExportTool exportTool;
        public FrmFis()
        {
            InitializeComponent();
            exportTool = new ExportTool(this, gridFisler, dropExport);

        }

        private void FrmFis_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void GetAll()
        {
            context = new NetSatisContext();
            gridcontFisler.DataSource = fisDAL.GetAll(context);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnFiltre_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void btnFiltreIptal_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void btnFiltreKapat_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Entities.Tables.Fis secilen = (Entities.Tables.Fis)gridFisler.GetFocusedRow();
            if (!string.IsNullOrEmpty(secilen.FisBaglantiKodu))
            {
                if (MessageBox.Show($"Bu fiş ile birlikte bağlantılı olan {secilen.FisBaglantiKodu} kodlu fiş de silinecek silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    context = new NetSatisContext();
                    fisDAL.Delete(context, c => c.FisKodu == secilen.FisBaglantiKodu);
                    fisDAL.Delete(context, c => c.FisKodu == secilen.FisKodu);
                    kasaHareketDAL.Delete(context, c => c.FisKodu == secilen.FisKodu);
                    stokHareketDAL.Delete(context, c => c.FisKodu == secilen.FisKodu);
                    fisDAL.Save(context);
                    GetAll();
                }
            }
            else
            {
                if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    context = new NetSatisContext();
                    fisDAL.Delete(context, c => c.FisKodu == secilen.FisKodu);
                    kasaHareketDAL.Delete(context, c => c.FisKodu == secilen.FisKodu);
                    stokHareketDAL.Delete(context, c => c.FisKodu == secilen.FisKodu);
                    fisDAL.Save(context);
                    GetAll();
                }
            }
           
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //FrmCariIslem frm = new FrmCariIslem(new Entities.Tables.Cari());
            //frm.ShowDialog();
            //if (frm.saved)
            //{
            //    GetAll();
            //}
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            Entities.Tables.Fis secilen = (Entities.Tables.Fis)gridFisler.GetFocusedRow();
            if (secilen.FisTuru == "Fiş Ödemesi")
            {
                FrmFisIslem frm = new FrmFisIslem(secilen.FisBaglantiKodu);
                frm.ShowDialog();
                if (frm.saved)
                {
                    GetAll();
                }
            }
            else
            {
                FrmFisIslem frm = new FrmFisIslem(secilen.FisKodu);
                frm.ShowDialog();
                if (frm.saved)
                {
                    GetAll();
                }
            }

            //secilen = gridFisler.GetFocusedRowCellValue(colFisKodu).ToString();

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FisIslem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFisIslem frm = new FrmFisIslem(null, e.Item.Caption);
            frm.ShowDialog();
            if (frm.saved)
            {
                GetAll();
            }
        }

        private void btnFaturalandir_Click(object sender, EventArgs e)
        {
            Entities.Tables.Fis secilen = (Entities.Tables.Fis)gridFisler.GetFocusedRow();
            if (!secilen.FisTuru.Contains("Sipariş Fişi"))
            {
                MessageBox.Show("Faturalandırmak istediğiniz fiş bir sipariş fişi değildir.");
            }
            else
            {
                FrmFisIslem frm = new FrmFisIslem(secilen.FisKodu,null,siparisFaturalandir:true);
                frm.ShowDialog();
            }
        }
    }
}