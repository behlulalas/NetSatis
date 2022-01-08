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

namespace NetSatis.BackOffice.Kasa
{
    public partial class FrmKasa : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        KasaDAL kasaDAL = new KasaDAL();
        private int? secilen=null;
        public FrmKasa()
        {
            InitializeComponent();

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GetAll()
        {
            gridcontKasalar.DataSource = kasaDAL.KasaListele(context);
        }
        private void FrmKasa_Load(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
            GetAll();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;

        }

        private void btnFiltreKapat_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
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

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmKasaIslem frm = new FrmKasaIslem(new Entities.Tables.Kasa());
            frm.ShowDialog();
            if (frm.saved)
            {
                GetAll();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = (int)layoutView1.GetFocusedRowCellValue(colId);
            FrmKasaIslem frm = new FrmKasaIslem(kasaDAL.GetByFilter(context, c => c.Id == secilen));
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
                secilen = (int)layoutView1.GetFocusedRowCellValue(colId);
                kasaDAL.Delete(context, c => c.Id == secilen);
                kasaDAL.Save(context);
                GetAll();
            }
        }

        private void btnKasaHareket_Click(object sender, EventArgs e)
        {
            secilen = (int)layoutView1.GetFocusedRowCellValue(colId);
            string kasaAdi = layoutView1.GetFocusedRowCellValue(colKasaAdi).ToString();
            FrmKasaHareket frm = new FrmKasaHareket((int)secilen);
            frm.ShowDialog();
        }
    }
}