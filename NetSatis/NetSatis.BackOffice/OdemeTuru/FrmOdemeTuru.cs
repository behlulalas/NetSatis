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

namespace NetSatis.BackOffice.OdemeTuru
{
    public partial class FrmOdemeTuru : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        OdemeTuruDAL odemeturuDAL = new OdemeTuruDAL();
        private int secilen;
        public FrmOdemeTuru()
        {
            InitializeComponent();
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
        public void GetAll()
        {
            context = new NetSatisContext();
            gridcontOdemeler.DataSource = odemeturuDAL.OdemeTuruListele(context);

        }
        private void FrmOdemeTuru_Load(object sender, EventArgs e)
        {
            GetAll();
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
                secilen =(int) gridOdemeler.GetFocusedRowCellValue(colOdemeTuruKodu);
                odemeturuDAL.Delete(context, c => c.Id == secilen);
                odemeturuDAL.Save(context);
                GetAll();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmOdemeTuruIslem frm = new FrmOdemeTuruIslem(new Entities.Tables.OdemeTuru());
            frm.ShowDialog();
            if (frm.saved)
            {
                GetAll();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = (int)gridOdemeler.GetFocusedRowCellValue(colOdemeTuruKodu);
            FrmOdemeTuruIslem frm = new FrmOdemeTuruIslem(odemeturuDAL.GetByFilter(context, c => c.Id == secilen));
            frm.ShowDialog();
            if (frm.saved)
            {
                GetAll();
            }
        }

        private void btnOdemeHareket_Click(object sender, EventArgs e)
        {
            secilen = (int)gridOdemeler.GetFocusedRowCellValue(colId);
            string odemeTuruAdi = gridOdemeler.GetFocusedRowCellValue(colOdemeTuruAdi).ToString();
            FrmOdemeTuruHareket frm = new FrmOdemeTuruHareket(secilen);
            frm.ShowDialog();
        }
    }
}