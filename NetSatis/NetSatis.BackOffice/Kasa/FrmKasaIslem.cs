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
using NetSatis.Entities.Tools;

namespace NetSatis.BackOffice.Kasa
{
    public partial class FrmKasaIslem : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Tables.Kasa _entity;
        private KasaDAL kasaDAL = new KasaDAL();
        private NetSatisContext context = new NetSatisContext();
        public bool saved = false;
        public FrmKasaIslem(Entities.Tables.Kasa entity)
        {
            InitializeComponent();
            _entity = entity;
            txtKod.DataBindings.Add("Text", _entity, "KasaKodu");
            txtKasaAdi.DataBindings.Add("Text", _entity, "KasaAdi");
            txtYetkiliAdi.DataBindings.Add("Text", _entity, "YetkiliAdi");
            txtYetkiliKodu.DataBindings.Add("Text", _entity, "YetkiliKodu");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
        }

        private void FrmKasaIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (kasaDAL.AddOrUpdate(context, _entity))
            {
                kasaDAL.Save(context);
                saved = true;
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}