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

namespace NetSatis.BackOffice.Cari
{
    public partial class FrmCari : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        CariDAL cariDAL = new CariDAL();
        private int secilen;
        ExportTool exportTool;
        public FrmCari()
        {
            InitializeComponent();
            exportTool = new ExportTool(this,gridCariler,dropExport);
            RoleTool.RolleriYukle(this);
        }

        public void GetAll()
        {
            gridcontCariler.DataSource = cariDAL.GetCariler(context);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context = new NetSatisContext();
                secilen = (int)gridCariler.GetFocusedRowCellValue(colId);
                cariDAL.Delete(context, c => c.Id == secilen);
                cariDAL.Save(context);
                GetAll();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmCariIslem frm = new FrmCariIslem(new Entities.Tables.Cari());
            frm.ShowDialog();
            if (frm.saved)
            {
                GetAll();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = (int)gridCariler.GetFocusedRowCellValue(colId); 
            FrmCariIslem frm = new FrmCariIslem(cariDAL.GetByFilter(context, c => c.Id == secilen));
            frm.ShowDialog();
            if (frm.saved)
            {
                GetAll();
            }
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            secilen = (int)gridCariler.GetFocusedRowCellValue(colId);
            Entities.Tables.Cari cariEntity = new Entities.Tables.Cari();
            cariEntity = cariDAL.GetByFilter(context, c => c.Id == secilen);
            FrmCariIslem frm = new FrmCariIslem(cariEntity,true);
            frm.ShowDialog();
            if (frm.saved)
            {
                GetAll();
            }
        }
        private void btnCariHareket_Click(object sender, EventArgs e)
        {
            secilen = (int)gridCariler.GetFocusedRowCellValue(colId);
            string cariAdi = gridCariler.GetFocusedRowCellValue(colCariAdi).ToString();
            FrmCariHareket frm = new FrmCariHareket(secilen);
            frm.ShowDialog();
        }

        private void FrmCari_Load(object sender, EventArgs e)
        {
            GetAll();
        }
    }
}