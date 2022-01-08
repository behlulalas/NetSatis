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

namespace NetSatis.BackOffice.Cari
{
    public partial class FrmCariHareket : DevExpress.XtraEditors.XtraForm
    {
        private CariDAL cariDAL = new CariDAL();
        private NetSatisContext context = new NetSatisContext();
        private int _cariId;
        public FrmCariHareket(int cariId)
        {
            InitializeComponent();
            _cariId = cariId;
            var cariEntity = cariDAL.GetByFilter(context, c => c.Id == cariId);
            lblBaslik.Text = cariEntity.CariKodu + " - " + cariEntity.CariAdi + " Hareketleri";
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Guncelle()
        {
            gridcontCariHareket.DataSource = cariDAL.CariFisAyrinti(context, _cariId);
            gridcontBakiye.DataSource = cariDAL.CariGenelToplam(context, _cariId);
            gridcontFisToplam.DataSource = cariDAL.CariFisGenelToplam(context, _cariId);
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridCariHareket.OptionsView.ShowAutoFilterRow)
            {
                gridCariHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridCariHareket.OptionsView.ShowAutoFilterRow = true;

            }
        }

        private void FrmCariHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }
    }
}