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

namespace NetSatis.BackOffice.Depo
{
    public partial class FrmDepoIslem : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Tables.Depo _entity;
        private DepoDAL depoDAL = new DepoDAL();
        private NetSatisContext context = new NetSatisContext();
        public bool saved = false;
        public FrmDepoIslem(Entities.Tables.Depo entity)
        {
            InitializeComponent();
            _entity = entity;
            txtKod.DataBindings.Add("Text", _entity, "DepoKodu");
            txtDepoAdi.DataBindings.Add("Text", _entity, "DepoAdi");
            txtYetkiliAdi.DataBindings.Add("Text", _entity, "YetkiliAdi");
            txtYetkiliKodu.DataBindings.Add("Text", _entity, "YetkiliKodu");
            txtTelefon.DataBindings.Add("Text", _entity, "Telefon", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIl.DataBindings.Add("Text", _entity, "Il", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIlce.DataBindings.Add("Text", _entity, "Ilce", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSemt.DataBindings.Add("Text", _entity, "Semt", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdres.DataBindings.Add("Text", _entity, "Adres", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
        }

        private void FrmKasaIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (depoDAL.AddOrUpdate(context, _entity))
            {
                depoDAL.Save(context);
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