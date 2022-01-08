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
using System.Data.SqlClient;
using NetSatis.Entities.Tools;
using NetSatis.Entities.Context;
using NetSatis.Entities.Tables;
using System.Data.Entity;

namespace NetSatis.Admin
{
    public partial class FrmBaglantiAyarlari : DevExpress.XtraEditors.XtraForm
    {
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        public bool kaydedildi = false;
        public FrmBaglantiAyarlari()
        {
            InitializeComponent();
            CreateConnectionString();
        }

        private void CreateConnectionString()
        {
            builder.DataSource = txtServer.Text;
            builder.InitialCatalog = "master";
            if (chkWindows.Checked)
            {
                builder.IntegratedSecurity = true;
            }
            else
            {
                builder.UserID = txtKullaniciAdi.Text;
                builder.Password = txtParola.Text;
                builder.IntegratedSecurity = false;
            }
        }

        private void btnTestEt_Click(object sender, EventArgs e)
        {
            CreateConnectionString();
            builder.InitialCatalog = "master";
            if (ConnectionTool.CheckConnection(builder.ConnectionString))
            {
                MessageBox.Show("Bağlantı başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bağlantı başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkSqlServer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSqlServer.Checked)
            {
                txtKullaniciAdi.Enabled = true;
                txtParola.Enabled = true;
            }
            else
            {
                txtKullaniciAdi.Enabled = false;
                txtParola.Enabled = false;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            CreateConnectionString();
            builder.InitialCatalog = "master";
            if (ConnectionTool.CheckConnection(builder.ConnectionString))
            {

                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.DatabaseAyarlari_BaglantiCumlesi, builder.ConnectionString);
                SettingsTool.Save();

                kaydedildi = true;
                this.Close();

            }
            else
            {
                MessageBox.Show("Bağlantı başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmBaglantiAyarlari_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!kaydedildi)
            {
                MessageBox.Show("Bağlantı cümlesi oluşturulmadığı için program kapatılacak.");
                Application.Exit();
            }
        }
    }
}