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

namespace NetSatis.BackOffice.Personel
{
    public partial class FrmPersonelHareket : DevExpress.XtraEditors.XtraForm
    {
        private PersonelDAL personelDAL = new PersonelDAL();
        private FisDAL fisDAL = new FisDAL();
        private NetSatisContext context = new NetSatisContext();
        private int _personelId;
        public FrmPersonelHareket(int personelId)
        {
            InitializeComponent();
            _personelId = personelId;
            var personelEntity = personelDAL.GetByFilter(context, c => c.Id == personelId);
            lblBaslik.Text = personelEntity.PersonelKodu + " - " + personelEntity.PersonelAdi + " Hareketleri";
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Guncelle()
        {
            gridcontPersonelHareket.DataSource = fisDAL.GetAll(context, c=>c.PlasiyerId==_personelId);
            gridcontFisToplam.DataSource = personelDAL.PersonelFisToplam(context, _personelId);
            //gridcontEkstre.DataSource = personelDAL.CariGenelToplam(context, _personelKodu);
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridPersonelHareket.OptionsView.ShowAutoFilterRow)
            {
                gridPersonelHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridPersonelHareket.OptionsView.ShowAutoFilterRow = true;

            }
        }

        private void FrmCariHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }
    }
}