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
using System.Data.Entity;
using NetSatis.Entities.Tools;

namespace NetSatis.BackOffice.StokHareketleri
{
    public partial class FrmStokHareketleri : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        StokHareketDAL stokHareketDAL = new StokHareketDAL();
        ExportTool exportTool;
        public FrmStokHareketleri()
        {
            InitializeComponent();
            exportTool = new ExportTool(this, gridStokHareket, dropExport);

        }

        private void GetAll()
        {
            context = new NetSatisContext();
            gridcontStokHareket.DataSource= stokHareketDAL.GetAll(context);
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

        private void repoSeriNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string veri = Convert.ToString(gridStokHareket.GetFocusedRowCellValue(colSeriNo));
            FrmSeriNoGir frm = new FrmSeriNoGir(veri);
            frm.locked = true;
            frm.ShowDialog();
        }

        private void btnDetayGor_Click(object sender, EventArgs e)
        {
            FrmFisIslem frm = new FrmFisIslem(gridStokHareket.GetFocusedRowCellValue(colFisKodu).ToString());
            frm.ShowDialog();
        }
    }
}