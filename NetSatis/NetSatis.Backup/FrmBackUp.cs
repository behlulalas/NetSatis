using NetSatis.Entities.Context;
using NetSatis.Entities.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NetSatis.Backup
{
    public partial class FrmBackUp : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        public FrmBackUp()
        {
            InitializeComponent();
            txtYedekKonum.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.YedeklemeAyarlari_YedeklemeKonumu);
        }

        private void btnYedekle_Click(object sender, EventArgs e)
        {
            string sqlCumle = $"USE NetSatis;BACKUP DATABASE NetSatis TO DISK='{txtYedekKonum.Text + "\\NetSatisYedek.bacpac"}'";
            context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction,sqlCumle);
            backgroundIndication();
        }

        private void txtYedekKonum_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FolderBrowserDialog form = new FolderBrowserDialog();
            if (form.ShowDialog()==DialogResult.OK)
            {
                txtYedekKonum.Text = form.SelectedPath;
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.YedeklemeAyarlari_YedeklemeKonumu, txtYedekKonum.Text);
                SettingsTool.Save();
            }
        }

        private void btnGeriYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Yedekleme Dosyası *.bacpac|*.bacpac";
            if (fileDialog.ShowDialog()==DialogResult.OK)
            {
                string sqlCumle = $"USE master;ALTER DATABASE NetSatis SET SINGLE_USER WITH ROLLBACK IMMEDIATE; ALTER DATABASE NetSatis SET READ_ONLY;RESTORE DATABASE NetSatis FROM DISK='{fileDialog.FileName}';ALTER DATABASE NetSatis SET MULTI_USER";
                context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sqlCumle);
                backgroundIndication();
            }
        }
        private void ChangeLabel()
        {
            for (int i = 0; i <= 100; i++)
            {
                SetLabelText(i);
                Thread.Sleep(5);

            }
        }
        private delegate void SetLabelTextDelegate(int number);
        private void SetLabelText(int number)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new SetLabelTextDelegate(SetLabelText), new object[] { number });
                return;
            }
            lblInfo.Text ="% "+ number.ToString()+" Başarıyla tamamlandı.";
        }
        void backgroundIndication()
        {
            progressBar1.Value = 0;
            lblInfo.Visible = true;
            Thread t = new Thread(new ThreadStart(ChangeLabel));
            t.Start();
            progressBar1.Visible = true;
            progressBar1.Value = 100;
        }
    }
}
