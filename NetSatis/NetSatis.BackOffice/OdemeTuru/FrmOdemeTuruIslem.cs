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

namespace NetSatis.BackOffice.OdemeTuru
{
    public partial class FrmOdemeTuruIslem : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Tables.OdemeTuru _entity;
        private OdemeTuruDAL odemeTuruDAL = new OdemeTuruDAL();
        private NetSatisContext context = new NetSatisContext();
        public bool saved = false;
        public FrmOdemeTuruIslem(Entities.Tables.OdemeTuru entity)
        {
            InitializeComponent();
            _entity = entity;
            txtKod.DataBindings.Add("Text", _entity, "OdemeTuruKodu");
            txtOdemeTuruAdi.DataBindings.Add("Text", _entity, "OdemeTuruAdi");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (odemeTuruDAL.AddOrUpdate(context, _entity))
            {
                odemeTuruDAL.Save(context);
                saved = true;
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmOdemeTuruIslem_Load(object sender, EventArgs e)
        {

        }
    }
}