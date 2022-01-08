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

namespace NetSatis.BackOffice.Depo
{
    public partial class FrmDepo : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        DepoDAL depoDAL = new DepoDAL();
        private int secilen;
        ExportTool exportTool;

        public FrmDepo()
        {
            InitializeComponent();
            exportTool = new ExportTool(this, gridDepolar, dropExport);
        }
        public void GetAll()
        {
            gridcontDepolar.DataSource = depoDAL.GetAll(context);
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

        private void FrmDepo_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context = new NetSatisContext();
                secilen =(int)gridDepolar.GetFocusedRowCellValue(colId);
                depoDAL.Delete(context, c => c.Id == secilen);
                depoDAL.Save(context);
                GetAll();
            }
        }

        private void btnDepoHareket_Click(object sender, EventArgs e)
        {
            secilen = (int)gridDepolar.GetFocusedRowCellValue(colId);
            FrmDepoHareket frm = new FrmDepoHareket(secilen);
            frm.ShowDialog();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = (int)gridDepolar.GetFocusedRowCellValue(colId);
            FrmDepoIslem frm = new FrmDepoIslem(depoDAL.GetByFilter(context, c => c.Id == secilen));
            frm.ShowDialog();
            if (frm.saved)
            {
                GetAll();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmDepoIslem frm = new FrmDepoIslem(new Entities.Tables.Depo());
            frm.ShowDialog();
            if (frm.saved)
            {
                GetAll();
            }
        }
    }
}