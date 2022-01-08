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

namespace NetSatis.BackOffice.Tanim
{
    public partial class FrmTanim : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        TanimDAL tanimDAL = new TanimDAL();
        private TanimTuru _tanimTuru;
        public Entities.Tables.Tanim _entity;
        public bool secildi = false;
        public FrmTanim(TanimTuru tanimTuru)
        {
            InitializeComponent();
            _tanimTuru = tanimTuru;
        }

        public enum TanimTuru
        {
            CariGrubu,
            CariAltGrubu,
            CariOzelKod1,
            CariOzelKod2,
            CariOzelKod3,
            CariOzelKod4,
            StokBirim,
            StokGrubu,
            StokAltGrubu,
            Marka,
            Model,
            StokOzelKod1,
            StokOzelKod2,
            StokOzelKod3,
            StokOzelKod4,
            PersonelUnvan,

        }
        void KayitAc()
        {
            btnSec.Enabled = false;
            btnEkle.Enabled = false;
            btnDuzenle.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = true;
            btnVazgec.Enabled = true;
            navigationFrame1.SelectedPage = navigationPage1;
            txtTanim.DataBindings.Add("Text", _entity, "Tanimi");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
        }
        void KayitKapat()
        {
            btnSec.Enabled = true;
            btnEkle.Enabled = true;
            btnDuzenle.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            btnVazgec.Enabled = false;
            navigationFrame1.SelectedPage = navigationPage2;
            txtTanim.DataBindings.Clear();
            txtAciklama.DataBindings.Clear();
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            _entity = new Entities.Tables.Tanim();
            KayitAc();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int secilen = Convert.ToInt32(gridTanimlar.GetFocusedRowCellValue(colId));
            _entity = context.Tanimlar.Where(c => c.Id == secilen).SingleOrDefault();
            KayitAc();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context = new NetSatisContext();
                int secilen = Convert.ToInt32(gridTanimlar.GetFocusedRowCellValue(colId));
                tanimDAL.Delete(context, c => c.Id == secilen);
                tanimDAL.Save(context);
                GetAll();
            }
        }

        private void GetAll()
        {
           string turu=_tanimTuru.ToString();
            gridcontTanimlar.DataSource = tanimDAL.GetAll(context,c=> c.Turu== turu);
        }

        private void FrmTanim_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _entity.Turu = _tanimTuru.ToString();
            if (tanimDAL.AddOrUpdate(context, _entity))
            {
                tanimDAL.Save(context);
                KayitKapat();
                GetAll();
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            KayitKapat();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            int secilen = Convert.ToInt32(gridTanimlar.GetFocusedRowCellValue(colId));
            _entity = context.Tanimlar.Where(c => c.Id == secilen).SingleOrDefault();
            secildi = true;
            this.Close();
        }
    }
}