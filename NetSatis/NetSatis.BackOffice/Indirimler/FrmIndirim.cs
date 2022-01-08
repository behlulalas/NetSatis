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

namespace NetSatis.BackOffice.Indirimler
{
    public partial class FrmIndirim : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        IndirimDAL indirimDAL = new IndirimDAL();
        private string secilen;
        ExportTool exportTool;
        public FrmIndirim()
        {
            InitializeComponent();
            exportTool = new ExportTool(this, gridIndirimler, dropExport);

            GetAll();
        }

        private void GetAll()
        {
            context = new NetSatisContext();
            gridcontIndirimler.DataSource = indirimDAL.IndirimListele(context);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmIndirimIslem frm = new FrmIndirimIslem();
            frm.ShowDialog();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context = new NetSatisContext();
                secilen = gridIndirimler.GetFocusedRowCellValue(colStokKodu).ToString();
                indirimDAL.Delete(context, c => c.StokKodu == secilen);
                indirimDAL.Save(context);
                GetAll();
            }
        }

        private void btnPasifYap_Click(object sender, EventArgs e)
        {
            var secilenStokKodu = gridIndirimler.GetFocusedRowCellValue(colStokKodu).ToString();
            var result = indirimDAL.GetByFilter(context, c => c.StokKodu == secilenStokKodu);
            if (Convert.ToBoolean(gridIndirimler.GetFocusedRowCellValue(colDurumu)))
            {
                
                result.Durumu = false;
                btnPasifYap.Text = "Pasif Yap";
                gridIndirimler.SetFocusedRowCellValue(colDurumu, false);
                btnPasifYap.ImageIndex = 7;
                indirimDAL.Save(context);
            }
            else
            {
                result.Durumu = true;
                btnPasifYap.Text = "Aktif Yap";
                gridIndirimler.SetFocusedRowCellValue(colDurumu, true);
                btnPasifYap.ImageIndex = 6;
                indirimDAL.Save(context);
            }
        }

        private void gridIndirimler_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (Convert.ToBoolean(gridIndirimler.GetFocusedRowCellValue(colDurumu)))
            {
                btnPasifYap.Text = "Pasif Yap";
                btnPasifYap.ImageIndex = 7;
            }
            else
            {
                btnPasifYap.Text = "Aktif Yap";
                btnPasifYap.ImageIndex = 6;
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            gridIndirimler.OptionsView.ShowAutoFilterRow = true ? gridIndirimler.OptionsView.ShowAutoFilterRow == false : gridIndirimler.OptionsView.ShowAutoFilterRow == true;
        }
    }
}