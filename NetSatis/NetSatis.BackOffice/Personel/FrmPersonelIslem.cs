using NetSatis.BackOffice.Tanim;
using NetSatis.Entities.Context;
using NetSatis.Entities.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Personel
{
    public partial class FrmPersonelIslem : Form
    {
        private Entities.Tables.Personel _entity;
        private PersonelDAL personelDAL = new PersonelDAL();
        private NetSatisContext context = new NetSatisContext();
        public bool saved = false;
        public FrmPersonelIslem(Entities.Tables.Personel entity)
        {
            InitializeComponent();
            _entity = entity;
            toggleDurumu.DataBindings.Add("EditValue", _entity, "Calisiyor",true, DataSourceUpdateMode.OnPropertyChanged);
            txtUnvan.DataBindings.Add("Text", _entity, "Unvani", false, DataSourceUpdateMode.OnPropertyChanged);
            txtPersonelKodu.DataBindings.Add("Text", _entity, "PersonelKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtPersonelAdi.DataBindings.Add("Text", _entity, "PersonelAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtTCKimlikNo.DataBindings.Add("Text", _entity, "TcKimlikNo", false, DataSourceUpdateMode.OnPropertyChanged);
            dateGiris.DataBindings.Add("EditValue", _entity, "IseGirisTarihi", true, DataSourceUpdateMode.OnPropertyChanged);
            dateCikis.DataBindings.Add("EditValue", _entity, "IstenCikisTarihi", true, DataSourceUpdateMode.OnPropertyChanged);
            txtVergiDairesi.DataBindings.Add("Text", _entity, "VergiDairesi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtVergiNo.DataBindings.Add("Text", _entity, "VergiNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCepTelefonu.DataBindings.Add("Text", _entity, "CepTelefonu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSabitTelefon.DataBindings.Add("Text", _entity, "Telefon", false, DataSourceUpdateMode.OnPropertyChanged);
            txtfax.DataBindings.Add("Text", _entity, "Fax", false, DataSourceUpdateMode.OnPropertyChanged);
            txtEmail.DataBindings.Add("Text", _entity, "Email", false, DataSourceUpdateMode.OnPropertyChanged);
            txtWeb.DataBindings.Add("Text", _entity, "Web", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIl.DataBindings.Add("Text", _entity, "Il", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIlce.DataBindings.Add("Text", _entity, "Ilce", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSemt.DataBindings.Add("Text", _entity, "Semt", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdres.DataBindings.Add("Text", _entity, "Adres", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbAylikMaas.DataBindings.Add("EditValue", _entity, "AylikMaas", true, DataSourceUpdateMode.OnPropertyChanged,0,"C2");
            cmbPrimOrani.DataBindings.Add("EditValue", _entity, "PrimOrani", true, DataSourceUpdateMode.OnPropertyChanged, 0, "'%'0");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (personelDAL.AddOrUpdate(context, _entity))
            {
                personelDAL.Save(context);
                saved = true;
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUnvan_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim frm = new FrmTanim(FrmTanim.TanimTuru.PersonelUnvan);
                    frm.ShowDialog();
                    if (frm.secildi)
                        txtUnvan.Text = frm._entity.Tanimi;
                    break;
                case 1:
                    txtUnvan.Text = null;
                    break;
            }
        }
    }
}
