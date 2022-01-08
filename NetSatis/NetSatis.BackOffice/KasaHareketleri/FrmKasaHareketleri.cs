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
using NetSatis.BackOffice.Fis;
using NetSatis.Entities.Tools;

namespace NetSatis.BackOffice.KasaHareketleri
{
    public partial class FrmKasaHareketleri : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        KasaHareketDAL kasaHareketDAL = new KasaHareketDAL();
        ExportTool exportTool;
        public FrmKasaHareketleri()
        {
            InitializeComponent();
            exportTool = new ExportTool(this, gridKasaHareket, dropExport);

        }

        private void GetAll()
        {
            context = new NetSatisContext();
            gridcontKasaHareket.DataSource= kasaHareketDAL.GetAll(context);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnFiltreIptal_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void btnFiltre_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void btnFiltreKapat_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void FrmStokHareketleri_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            GetAll();
        }


        private void btnDetayGor_Click(object sender, EventArgs e)
        {
            FrmFisIslem frm = new FrmFisIslem(gridKasaHareket.GetFocusedRowCellValue(colFisKodu).ToString());
            frm.ShowDialog();
        }
    }
}