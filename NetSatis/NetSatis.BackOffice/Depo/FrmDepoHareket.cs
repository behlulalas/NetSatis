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

namespace NetSatis.BackOffice.Depo
{
    public partial class FrmDepoHareket : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        DepoDAL depoDAL = new DepoDAL();
        StokHareketDAL stokHareket = new StokHareketDAL();
        private int _depoId;

        public FrmDepoHareket(int depoId)
        {
            InitializeComponent();
            _depoId = depoId;
            var depoEntity = depoDAL.GetByFilter(context, c => c.Id == depoId);
            lblBaslik.Text = depoEntity.DepoKodu + " - " + depoEntity.DepoAdi + " Hareketleri";
        }

        private void FrmDepoHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }
        private void Guncelle()
        {
            context = new NetSatisContext();
            gridcontHareket.DataSource = stokHareket.GetAll(context, c => c.DepoId == _depoId);
            gridcontDepoStok.DataSource = stokHareket.DepoStokListele(context,_depoId);
            gridcontDepoIstatistik.DataSource = stokHareket.DepoIstatistikListele(context, _depoId);
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
            if (gridHareket.OptionsView.ShowAutoFilterRow)
            {
                gridHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridHareket.OptionsView.ShowAutoFilterRow = true;
            }
        }
    }
}