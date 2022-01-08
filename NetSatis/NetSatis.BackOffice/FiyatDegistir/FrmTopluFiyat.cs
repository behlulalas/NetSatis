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
using NetSatis.BackOffice.Stok;
using NetSatis.Entities.Context;
using NetSatis.Entities.DataAccess;
using System.Data.Entity;

namespace NetSatis.BackOffice.FiyatDegistir
{
    public partial class FrmTopluFiyat : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        StokDAL stokDAL = new StokDAL();
        public FrmTopluFiyat()
        {
            InitializeComponent();
            GetAll();
        }
        private void GetAll()
        {
            gridcontStoklar.DataSource = context.Stoklar.Local.ToBindingList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmStokSec form = new FrmStokSec(true);
            form.ShowDialog();
            if (form.secildi)
            {
                foreach (var item in form.secilen)
                {
                    stokDAL.AddOrUpdate(context, item);
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            stokDAL.Save(context);
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            var secilen = gridStoklar.GetFocusedRowCellValue(colStokKodu).ToString();
            var result = stokDAL.GetByFilter(context, c => c.StokKodu == secilen);
            context.Entry(result).State = EntityState.Detached;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            gridStoklar.OptionsView.ShowAutoFilterRow = true ? gridStoklar.OptionsView.ShowAutoFilterRow == false : gridStoklar.OptionsView.ShowAutoFilterRow == true;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiyatDegistir_Click(object sender, EventArgs e)
        {
            if (gridStoklar.RowCount==0)
            {
                MessageBox.Show("Seçilen bir ürün Bulunamadı. !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmFiyatDegistir frm = new FrmFiyatDegistir();
            frm.ShowDialog();
            if (frm.secildi)
            {
                foreach (var item in frm.list)
                {
                    if (item.Degistir)
                    {
                        for (int i = 0; i < gridStoklar.RowCount; i++)
                        {
                            decimal kolonDeger = 0;
                            decimal degisen = 0;
                            kolonDeger = Convert.ToDecimal(gridStoklar.GetRowCellValue(i, item.KolonAdi));
                            if (item.DegisimTuru == "Yüzde")
                            {
                                degisen = item.DegisimYonu == "Arttır"
                                    ? kolonDeger + kolonDeger / 100 * item.Degeri
                                    : kolonDeger - kolonDeger / 100 * item.Degeri;
                            }
                            else
                            {
                                degisen = item.DegisimYonu == "Arttır"
                                    ? kolonDeger + item.Degeri
                                    : kolonDeger - item.Degeri;
                            }
                            gridStoklar.SetRowCellValue(i, item.KolonAdi,degisen);
                        }
                    }
                }
            }
        }
    }
}