using NetSatis.BackOffice.Tanim;
using NetSatis.Entities.Context;
using NetSatis.Entities.DataAccess;
using NetSatis.Entities.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Stok
{
    public partial class FrmStokIslem : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Tables.Stok _entity;
        private StokDAL stokDAL = new StokDAL();
        private NetSatisContext context = new NetSatisContext();
        public bool saved = false;
        CodeTool kodOlustur;
        public FrmStokIslem(Entities.Tables.Stok entity, bool kopyala = false)
        {
            InitializeComponent();
            kodOlustur = new CodeTool(this, CodeTool.Table.Stok);
            kodOlustur.BarButonOlustur();
            if (kopyala)
            {
                _entity = new Entities.Tables.Stok();
                _entity.Id = -1;
                _entity.StokKodu = "";
                _entity.Durumu = entity.Durumu;
                _entity.Barkod = entity.Barkod;
                _entity.BarkodTuru = entity.BarkodTuru;
                _entity.StokAdi = entity.StokAdi;
                _entity.Birimi = entity.Birimi;
                _entity.UreticiKodu = entity.UreticiKodu;
                _entity.GarantiSuresi = entity.GarantiSuresi;
                _entity.MinStokMiktari = entity.MinStokMiktari;
                _entity.MaxStokMiktari = entity.MaxStokMiktari;
                _entity.Aciklama = entity.Aciklama;
                _entity.StokGrubu = entity.StokGrubu;
                _entity.StokAltGrubu = entity.StokAltGrubu;
                _entity.Marka = entity.Marka;
                _entity.Modeli = entity.Modeli;
                _entity.OzelKod1 = entity.OzelKod1;
                _entity.OzelKod2 = entity.OzelKod2;
                _entity.OzelKod3 = entity.OzelKod3;
                _entity.OzelKod4 = entity.OzelKod4;
                _entity.AlisKdv = entity.AlisKdv;
                _entity.SatisKdv = entity.SatisKdv;
                _entity.AlisFiyati1 = entity.AlisFiyati1;
                _entity.AlisFiyati2 = entity.AlisFiyati2;
                _entity.AlisFiyati3 = entity.AlisFiyati3;
                _entity.SatisFiyati1 = entity.SatisFiyati1;
                _entity.SatisFiyati2 = entity.SatisFiyati2;
                _entity.SatisFiyati3 = entity.SatisFiyati3;
            }
            else
            {
                _entity = entity;
            }
            toggleDurumu.DataBindings.Add("EditValue", _entity, "Durumu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtKod.DataBindings.Add("Text", _entity, "StokKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBarkod.DataBindings.Add("Text", _entity, "Barkod", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbBarkodTuru.DataBindings.Add("Text", _entity, "BarkodTuru", false, DataSourceUpdateMode.OnPropertyChanged);
            txtStokAdi.DataBindings.Add("Text", _entity, "StokAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            btnBirim.DataBindings.Add("Text", _entity, "Birimi");
            txtUreticiKodu.DataBindings.Add("Text", _entity, "UreticiKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtGarantiSuresi.DataBindings.Add("Text", _entity, "GarantiSuresi", false, DataSourceUpdateMode.OnPropertyChanged);
            calcMaxStokMiktari.DataBindings.Add("EditValue", _entity, "MaxStokMiktari", true, DataSourceUpdateMode.OnPropertyChanged);
            calcMinStokMiktari.DataBindings.Add("EditValue", _entity, "MinStokMiktari", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            btnStokGrubu.DataBindings.Add("Text", _entity, "StokGrubu", false, DataSourceUpdateMode.OnPropertyChanged);
            btnStokAltGrubu.DataBindings.Add("Text", _entity, "StokAltGrubu", false, DataSourceUpdateMode.OnPropertyChanged);
            btnMarka.DataBindings.Add("Text", _entity, "Marka", false, DataSourceUpdateMode.OnPropertyChanged);
            btnModel.DataBindings.Add("Text", _entity, "Modeli", false, DataSourceUpdateMode.OnPropertyChanged);
            btnOzelKod1.DataBindings.Add("Text", _entity, "OzelKod1", false, DataSourceUpdateMode.OnPropertyChanged);
            btnOzelKod2.DataBindings.Add("Text", _entity, "OzelKod2", false, DataSourceUpdateMode.OnPropertyChanged);
            btnOzelKod3.DataBindings.Add("Text", _entity, "OzelKod3", false, DataSourceUpdateMode.OnPropertyChanged);
            btnOzelKod4.DataBindings.Add("Text", _entity, "OzelKod4", false, DataSourceUpdateMode.OnPropertyChanged);
            calcAlisKDV.DataBindings.Add("EditValue", _entity, "AlisKdv", true, DataSourceUpdateMode.OnPropertyChanged, 0, "'%'0");
            calcSatisKDV.DataBindings.Add("EditValue", _entity, "SatisKdv", true, DataSourceUpdateMode.OnPropertyChanged, 0, "'%'0");
            calcAlisFiyati1.DataBindings.Add("EditValue", _entity, "AlisFiyati1", true, DataSourceUpdateMode.OnPropertyChanged, 0, "C2");
            calcAlisFiyati2.DataBindings.Add("EditValue", _entity, "AlisFiyati2", true, DataSourceUpdateMode.OnPropertyChanged, 0, "C2");
            calcAlisFiyati3.DataBindings.Add("EditValue", _entity, "AlisFiyati3", true, DataSourceUpdateMode.OnPropertyChanged, 0, "C2");
            calcSatisFiyati1.DataBindings.Add("EditValue", _entity, "SatisFiyati1", true, DataSourceUpdateMode.OnPropertyChanged, 0, "C2");
            calcSatisFiyati2.DataBindings.Add("EditValue", _entity, "SatisFiyati2", true, DataSourceUpdateMode.OnPropertyChanged, 0, "C2");
            calcSatisFiyati3.DataBindings.Add("EditValue", _entity, "SatisFiyati3", true, DataSourceUpdateMode.OnPropertyChanged, 0, "C2");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (stokDAL.AddOrUpdate(context, _entity))
            {
                kodOlustur.KodArttirma();
                stokDAL.Save(context);
                saved = true;
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStokIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnOzelKod1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim frm = new FrmTanim(FrmTanim.TanimTuru.StokOzelKod1);
                    frm.ShowDialog();
                    if (frm.secildi)
                        btnOzelKod1.Text = frm._entity.Tanimi;
                    break;
                case 1:
                    btnOzelKod1.Text = null;
                    break;
            }
        }

        private void btnOzelKod2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim frm = new FrmTanim(FrmTanim.TanimTuru.StokOzelKod2);
                    frm.ShowDialog();
                    if (frm.secildi)
                        btnOzelKod2.Text = frm._entity.Tanimi;
                    break;
                case 1:
                    btnOzelKod2.Text = null;
                    break;
            }
        }

        private void btnOzelKod3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim frm = new FrmTanim(FrmTanim.TanimTuru.StokOzelKod3);
                    frm.ShowDialog();
                    if (frm.secildi)
                        btnOzelKod3.Text = frm._entity.Tanimi;
                    break;
                case 1:
                    btnOzelKod3.Text = null;
                    break;
            }
        }

        private void btnOzelKod4_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim frm = new FrmTanim(FrmTanim.TanimTuru.StokOzelKod4);
                    frm.ShowDialog();
                    if (frm.secildi)
                        btnOzelKod4.Text = frm._entity.Tanimi;
                    break;
                case 1:
                    btnOzelKod4.Text = null;
                    break;
            }
        }

        private void btnStokGrubu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim frm = new FrmTanim(FrmTanim.TanimTuru.StokGrubu);
                    frm.ShowDialog();
                    if (frm.secildi)
                        btnStokGrubu.Text = frm._entity.Tanimi;
                    break;
                case 1:
                    btnStokGrubu.Text = null;
                    break;
            }
        }

        private void btnMarka_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim frm = new FrmTanim(FrmTanim.TanimTuru.Marka);
                    frm.ShowDialog();
                    if (frm.secildi)
                        btnMarka.Text = frm._entity.Tanimi;
                    break;
                case 1:
                    btnMarka.Text = null;
                    break;
            }
        }

        private void btnStokAltGrubu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim frm = new FrmTanim(FrmTanim.TanimTuru.StokAltGrubu);
                    frm.ShowDialog();
                    if (frm.secildi)
                        btnStokAltGrubu.Text = frm._entity.Tanimi;
                    break;
                case 1:
                    btnStokAltGrubu.Text = null;
                    break;
            }
        }

        private void btnModel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim frm = new FrmTanim(FrmTanim.TanimTuru.Model);
                    frm.ShowDialog();
                    if (frm.secildi)
                        btnModel.Text = frm._entity.Tanimi;
                    break;
                case 1:
                    btnModel.Text = null;
                    break;
            }
        }

        private void btnBirim_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanim frm = new FrmTanim(FrmTanim.TanimTuru.StokBirim);
                    frm.ShowDialog();
                    if (frm.secildi)
                        btnBirim.Text = frm._entity.Tanimi;
                    break;
                case 1:
                    btnBirim.Text = null;
                    break;
            }
        }
    }
}
