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

namespace NetSatis.BackOffice.OdemeTuru
{
    public partial class FrmOdemeTuruHareket : DevExpress.XtraEditors.XtraForm
    {
        private OdemeTuruDAL odemeTuruDAL = new OdemeTuruDAL();
        private KasaHareketDAL kasaHareketDAL = new KasaHareketDAL();
        private NetSatisContext context = new NetSatisContext();
        private int _odemeTuruId;
        public FrmOdemeTuruHareket(int odemeTuruId)
        {
            InitializeComponent();
            _odemeTuruId = odemeTuruId;
            var odemeEntity = odemeTuruDAL.GetByFilter(context, c => c.Id == odemeTuruId);
            lblBaslik.Text = odemeEntity.OdemeTuruKodu + " - " + odemeEntity.OdemeTuruAdi + " Hareketleri";
        }
        public void Guncelle()
        {
            context = new NetSatisContext();
            gridcontKasaHareket.DataSource = kasaHareketDAL.GetAll(context, c => c.OdemeTuruId == _odemeTuruId);
            gridcontOdemeTuruToplam.DataSource = odemeTuruDAL.KasaToplamListele(context, _odemeTuruId);
            gridcontGenelToplam.DataSource = odemeTuruDAL.KasaGenelToplam(context, _odemeTuruId);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridKasaHareket.OptionsView.ShowAutoFilterRow)
            {
                gridKasaHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridKasaHareket.OptionsView.ShowAutoFilterRow = true;

            }
        }

        private void FrmKasaHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }
    }
}