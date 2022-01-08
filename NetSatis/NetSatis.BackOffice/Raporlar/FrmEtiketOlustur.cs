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
using DevExpress.XtraReports.UI;
using NetSatis.Entities.Context;
using DevExpress.XtraPrinting;
using NetSatis.BackOffice.Stok;
using DevExpress.XtraWizard;

namespace NetSatis.BackOffice.Raporlar
{
    public partial class FrmEtiketOlustur : DevExpress.XtraEditors.XtraForm
    {
        private XtraReport rapor = new XtraReport();
        NetSatisContext context = new NetSatisContext();
        List<Entities.Tables.Stok> stokEntity = new List<Entities.Tables.Stok>();

        public FrmEtiketOlustur()
        {
            InitializeComponent();
            gridcontStoklar.DataSource = stokEntity;
        }

        private int mmToPixel(int mm)
        {
            return Convert.ToInt32(mm*3.779527559);
        }

        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            rapor.DataSource = stokEntity;
            rapor.PageHeight = mmToPixel((int)calcDikey.Value);
            rapor.PageWidth = mmToPixel((int)calcYatay.Value);
            rapor.Margins.Top = mmToPixel((int)calcUst.Value);
            rapor.Margins.Bottom = mmToPixel((int)calcAlt.Value);
            rapor.Margins.Right = mmToPixel((int)calcSag.Value);
            rapor.Margins.Left = mmToPixel((int)calcSol.Value);
            rapor.RollPaper = checkRulo.Checked;
            DetailBand detail = new DetailBand();
            detail.MultiColumn.Layout = ColumnLayout.AcrossThenDown;
            detail.MultiColumn.Mode = MultiColumnMode.UseColumnWidth;
            detail.MultiColumn.ColumnWidth = mmToPixel((int)calcUzunluk.Value);
            detail.Height = mmToPixel((int)calcGenislik.Value);
            detail.MultiColumn.ColumnSpacing = mmToPixel((int)calcAraBosluk.Value);
            rapor.Bands.Add(detail);
            FrmRaporDuzenle frm = new FrmRaporDuzenle(rapor);
            frm.Show();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmStokSec frm = new FrmStokSec(true);
            frm.ShowDialog();
            if (frm.secildi)
            {
                foreach (var item in frm.secilen)
                {
                    stokEntity.Add(item);
                }
            }
            gridStoklar.RefreshData();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            gridStoklar.DeleteSelectedRows();
            gridStoklar.RefreshData();
        }

        private void wizardControl1_SelectedPageChanging(object sender, DevExpress.XtraWizard.WizardPageChangingEventArgs e)
        {
            if (e.Page==completionWizardPage1 && e.Direction==Direction.Forward && gridStoklar.RowCount==0)
            {
                MessageBox.Show("Listeye hiçbir ürün eklenmedi.");
                e.Cancel = true;
            }
        }
    }
}