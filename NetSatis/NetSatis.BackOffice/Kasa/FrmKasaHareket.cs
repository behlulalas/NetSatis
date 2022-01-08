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

namespace NetSatis.BackOffice.Kasa
{
    public partial class FrmKasaHareket : DevExpress.XtraEditors.XtraForm
    {
        private KasaDAL kasaDAL = new KasaDAL();
        private KasaHareketDAL kasaHareketDAL = new KasaHareketDAL();
        private NetSatisContext context = new NetSatisContext();
        private int _kasaId;
        public FrmKasaHareket(int kasaId)
        {
            InitializeComponent();
            _kasaId = kasaId;
            var kasaEntity = kasaDAL.GetByFilter(context, c => c.Id == kasaId);
            lblBaslik.Text = kasaEntity.KasaKodu + " - " + kasaEntity.KasaAdi + " Hareketleri";
        }
        public void Guncelle()
        {
            context = new NetSatisContext();
            gridcontKasaHareket.DataSource = kasaHareketDAL.GetAll(context,c=>c.KasaId==_kasaId);
            gridcontOdemeTuruToplam.DataSource = kasaDAL.OdemeTuruToplamListele(context, _kasaId);
            gridcontGenelToplam.DataSource = kasaDAL.KasaGenelToplam(context, _kasaId);
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