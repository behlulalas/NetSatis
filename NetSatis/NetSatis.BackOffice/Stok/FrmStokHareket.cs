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
using NetSatis.Entities.DataAccess;
using NetSatis.Entities.Context;

namespace NetSatis.BackOffice.Stok
{
    public partial class FrmStokHareket : DevExpress.XtraEditors.XtraForm
    {
        StokHareketDAL stokHareket = new StokHareketDAL();
        StokDAL stokDAL = new StokDAL();
        NetSatisContext context = new NetSatisContext();
        private int _stokId;
        public FrmStokHareket(int stokId)
        {
            InitializeComponent();
            _stokId = stokId;
            var stokEntity = stokDAL.GetByFilter(context, c => c.Id == stokId);
            lblBaslik.Text = stokEntity.StokKodu+" - "+stokEntity.StokAdi + " Hareketleri";
        }

        private void FrmStokHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            context = new NetSatisContext();
            gridcontStokHareket.DataSource = stokHareket.GetAll(context, c => c.StokId == _stokId);
            gridcontGenelStok.DataSource = stokHareket.GetGenelStok(context, _stokId);
            gridcontDepoStok.DataSource = stokHareket.GetDepoStok(context, _stokId);
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridStokHareket.OptionsView.ShowAutoFilterRow)
            {
                gridStokHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridStokHareket.OptionsView.ShowAutoFilterRow = true;

            }
        }

    }
}