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

namespace NetSatis.Admin
{
    public partial class FrmKullaniciIslem : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Tables.Kullanici _entity;
        private KullaniciDAL kullaniciDAL = new KullaniciDAL();
        private NetSatisContext context = new NetSatisContext();
        public bool saved = false;
        private string parola, cevap;
        public FrmKullaniciIslem(Entities.Tables.Kullanici entity)
        {
            InitializeComponent();
            treeList1.ExpandAll();
            if (entity != null)
            {
                parola = entity.Parola;
                cevap = entity.Cevap;
                entity.Cevap = null;
                entity.Parola = null;
            }
            _entity = entity;
            txtKullaniciAdi.DataBindings.Add("Text", _entity, "KullaniciAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAd.DataBindings.Add("Text", _entity, "Adi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSoyad.DataBindings.Add("Text", _entity, "Soyadi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtGorev.DataBindings.Add("Text", _entity, "Gorevi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtParola.DataBindings.Add("Text", _entity, "Parola", false, DataSourceUpdateMode.OnPropertyChanged);
            txtHatirlatmaSorusu.DataBindings.Add("Text", _entity, "HatirlatmaSorusu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCevap.DataBindings.Add("Text", _entity, "Cevap", false, DataSourceUpdateMode.OnPropertyChanged);
            AyarYukle();
        }

        private void Kaydet()
        {
            for (int i = 0; i < treeList1.Nodes.Count; i++)
            {
                for (int j = 0; j < treeList1.Nodes[i].Nodes.Count; j++)
                {
                    if (context.KullaniciRolleri.Count(c => c.KullaniciAdi == txtKullaniciAdi.Text && c.RootId == i && c.ParentId == j) == 0)
                    {
                        context.KullaniciRolleri.Add(new Entities.Tables.KullaniciRol
                        {
                            KullaniciAdi = txtKullaniciAdi.Text,
                            FormAdi = treeList1.Nodes[i].GetDisplayText(treeListColumn2),
                            KontrolAdi = treeList1.Nodes[i].Nodes[j].GetDisplayText(treeListColumn2),
                            RootId = i,
                            ParentId = j,
                            Yetki = treeList1.Nodes[i].Nodes[j].Checked,
                        });
                    }
                    else
                    {
                        context.KullaniciRolleri.SingleOrDefault(c => c.KullaniciAdi == txtKullaniciAdi.Text && c.RootId == i && c.ParentId == j).Yetki = treeList1.Nodes[i].Nodes[j].Checked;
                    }
                }
            }
            context.SaveChanges();
        }

        private void AyarYukle()
        {
            if (!String.IsNullOrEmpty(_entity.KullaniciAdi))
            {
                foreach (var item in context.KullaniciRolleri.Where(c => c.KullaniciAdi == _entity.KullaniciAdi))
                {
                    treeList1.SetNodeCheckState(treeList1.Nodes[item.RootId].Nodes[item.ParentId], item.Yetki == true ? CheckState.Checked : CheckState.Unchecked, true);
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmKullaniciIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_entity.Parola))
            {
                txtParola.Text = parola;
                txtParolaTekrar.Text = parola;
            }
            if (string.IsNullOrEmpty(_entity.Cevap))
            {
                txtCevap.Text = cevap;
            }
            if (txtParola.Text != txtParolaTekrar.Text)
            {
                MessageBox.Show("Parolalar Eşleşmiyor...");
            }
            else
            {
              
                if (_entity.KayitTarihi == null)
                {
                    _entity.KayitTarihi = DateTime.Now;
                }
                if (kullaniciDAL.AddOrUpdate(context, _entity))
                {
                    Kaydet();
                    saved = true;
                    this.Close();
                }

            }

        }
    }
}