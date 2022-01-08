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
using NetSatis.BackOffice.Stok;
using NetSatis.Entities.Tables;

namespace NetSatis.BackOffice.Indirimler
{
    public partial class FrmIndirimIslem : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        IndirimDAL indirimDAL = new IndirimDAL();


        public FrmIndirimIslem()
        {
            InitializeComponent();
            gridcontIndirimler.DataSource = context.Indirimler.Local.ToBindingList();
        }
        private Indirim StokEkle(Entities.Tables.Stok entity)
        {
            Indirim _entity = new Indirim();
            _entity.StokKodu = entity.StokKodu;
            _entity.Barkod = entity.Barkod;
            _entity.StokAdi = entity.StokAdi;
            return _entity;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmStokSec form = new FrmStokSec(true);
            form.ShowDialog();

            if (form.secildi)
            {
                foreach (var item in form.secilen)
                {
                    Indirim _entity = new Indirim();
                    _entity = StokEkle(item);
                    var count = context.Indirimler.Count(c => c.StokKodu == item.StokKodu);
                    if (count != 0)
                    {
                        if (MessageBox.Show("Bu ürüne ait bir indirim zaten var, İndirimi Güncellemek ister misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            var secilenId = context.Indirimler.SingleOrDefault(c => c.StokKodu == item.StokKodu);
                            _entity.Id = secilenId.Id;
                            indirimDAL.AddOrUpdate(context, _entity);
                        }
                    }
                    else
                    {
                        indirimDAL.AddOrUpdate(context, _entity);
                    }
                }
            }

        }

        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {

            foreach (var item in context.Indirimler.Local.ToList())
            {
                item.Durumu = true;
                item.Aciklama = txtAciklama.Text;
                if (btnSuresiz.Checked)
                {
                    item.IndirimTuru = "Süresiz";
                }
                else
                {
                    item.BaslangicTarihi = dateBaslangic.DateTime;
                    item.BitisTarihi = dateBitis.DateTime;
                    item.IndirimTuru = "Tarih Arasında";
                }
            }
            indirimDAL.Save(context);
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            var secilen = gridIndirimler.GetFocusedRowCellValue(colStokKodu).ToString();
            var result = indirimDAL.GetByFilter(context, c => c.StokKodu == secilen);
            context.Entry(result).State = EntityState.Detached;
        }
    }
}