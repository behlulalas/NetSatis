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

namespace NetSatis.BackOffice.Stok
{
    public partial class FrmStok : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        StokDAL stokDAL = new StokDAL();
        private int secilen;
        ExportTool exportTool;
        public FrmStok()
        {
            InitializeComponent();
            RoleTool.RolleriYukle(this);
            exportTool = new ExportTool(this, gridStoklar, dropExport);

        }

        private void FrmStok_Load(object sender, EventArgs e)
        {
            GetAll();
        }
        public void GetAll()
        {
            gridcontStoklar.DataSource = stokDAL.GetAllJoin(context);
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
                secilen = (int)gridStoklar.GetFocusedRowCellValue(colId);
                stokDAL.Delete(context, c => c.Id == secilen);
                stokDAL.Save(context);
                GetAll();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmStokIslem frm = new FrmStokIslem(new Entities.Tables.Stok());
            frm.ShowDialog();
            if (frm.saved)
            {
                GetAll();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = (int)gridStoklar.GetFocusedRowCellValue(colId);
            FrmStokIslem frm = new FrmStokIslem(stokDAL.GetByFilter(context, c => c.Id == secilen));
            frm.ShowDialog();
            if (frm.saved)
            {
                GetAll();
            }
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            secilen = (int)gridStoklar.GetFocusedRowCellValue(colId);
            Entities.Tables.Stok stokEntity = new Entities.Tables.Stok();
            stokEntity = stokDAL.GetByFilter(context, c => c.Id == secilen);
            FrmStokIslem frm = new FrmStokIslem(stokEntity,true);
            frm.ShowDialog();
            if (frm.saved)
            {
                GetAll();
            }
        }

        private void btnStokHareket_Click(object sender, EventArgs e)
        {
            secilen = (int)gridStoklar.GetFocusedRowCellValue(colId);
            FrmStokHareket frm = new FrmStokHareket(secilen);
            frm.ShowDialog();
        }
    }
}