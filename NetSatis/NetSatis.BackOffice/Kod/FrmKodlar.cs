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
using System.Data.Entity;
using DevExpress.XtraGrid;
using DevExpress.DataProcessing;
using NetSatis.Entities.Tools;

namespace NetSatis.BackOffice.Kod
{
    public partial class FrmKodlar : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        KodDAL kodDAL = new KodDAL();
        private Entities.Tables.Kod _entity;
        private string _tablo;
        ExportTool exportTool;
        public FrmKodlar(string tablo)
        {
            InitializeComponent();
            exportTool = new ExportTool(this, gridTanimlar, dropExport);
            _tablo = tablo;
            context.Kodlar.Where(c => c.Tablo == _tablo).Load();
            gridcontTanimlar.DataSource = context.Kodlar.Local.ToBindingList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            context.Kodlar.Local.ForEach(c => c.Tablo = _tablo);
           context.SaveChanges();
            this.Close();
        }

        private void gridTanimlar_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (gridTanimlar.FocusedRowHandle != GridControl.NewItemRowHandle)
            {
                e.Cancel = true;
            }
        }

        private void gridTanimlar_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            Entities.Tables.Kod row = (Entities.Tables.Kod)e.Row;
            if (context.Kodlar.Local.Any(c => c.OnEki == row.OnEki))
            {
                MessageBox.Show("Aynı ön eki ile kod kaydedilemez");
                gridTanimlar.CancelUpdateCurrentRow();
            }
        }

        private void repositorySil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridTanimlar.DeleteSelectedRows();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}