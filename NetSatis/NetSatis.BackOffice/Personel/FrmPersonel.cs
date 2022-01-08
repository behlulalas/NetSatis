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

namespace NetSatis.BackOffice.Personel
{
    public partial class FrmPersonel : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        PersonelDAL personDAL = new PersonelDAL();
        private int secilen;
        ExportTool exportTool;
        public FrmPersonel()
        {
            InitializeComponent();
            exportTool = new ExportTool(this, gridPersoneller, dropExport);

        }

        public void GetAll()
        {
            gridcontPersoneller.DataSource = personDAL.GetPersonelList(context);
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
                secilen =(int) gridPersoneller.GetFocusedRowCellValue(colId);
                personDAL.Delete(context, c => c.Id == secilen);
                personDAL.Save(context);
                GetAll();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmPersonelIslem frm = new FrmPersonelIslem(new Entities.Tables.Personel());
            frm.ShowDialog();
            if (frm.saved)
            {
                GetAll();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = (int)gridPersoneller.GetFocusedRowCellValue(colId);
            FrmPersonelIslem frm = new FrmPersonelIslem(personDAL.GetByFilter(context, c => c.Id == secilen));
            frm.ShowDialog();
            if (frm.saved)
            {
                GetAll();
            }
        }
        private void btnCariHareket_Click(object sender, EventArgs e)
        {
            secilen = (int)gridPersoneller.GetFocusedRowCellValue(colId);
            string personelAdi = gridPersoneller.GetFocusedRowCellValue(colPersonelAdi).ToString();
            FrmPersonelHareket frm = new FrmPersonelHareket(secilen);
            frm.ShowDialog();
        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnHakedis_Click(object sender, EventArgs e)
        {
            FrmFisIslem frm = new FrmFisIslem(null, "Hakediş Fişi");
            frm.ShowDialog();
        }
    }
}