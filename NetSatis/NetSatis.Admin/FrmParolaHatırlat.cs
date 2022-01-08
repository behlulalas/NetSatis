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
using NetSatis.Entities.Tables;
using NetSatis.Entities.DataAccess;

namespace NetSatis.Admin
{
    public partial class FrmParolaHatırlat : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        KullaniciDAL kullaniciDAL = new KullaniciDAL();
        Kullanici _entity;
        public FrmParolaHatırlat(string kullaniciAdi)
        {
            InitializeComponent();
            _entity = context.Kullanicilar.SingleOrDefault(c => c.KullaniciAdi == kullaniciAdi);
            txtHatirlatmaSorusu.Text = _entity.HatirlatmaSorusu;
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (_entity.Cevap==txtCevap.Text && txtParola.Text==txtParolaTekrar.Text)
            {
                _entity.Parola = txtParola.Text;
                kullaniciDAL.AddOrUpdate(context, _entity);
                kullaniciDAL.Save(context);
                MessageBox.Show("Yeni Parola başarıyla kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatıralatma sorusu cevabı yanlış veya Parolalar eşleşmiyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}