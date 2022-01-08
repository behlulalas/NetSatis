using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NetSatis.Update
{
    public partial class FrmGuncelleme : DevExpress.XtraEditors.XtraForm
    {
        WebClient indir = new WebClient();
        public static bool isRunning(string ProgramAdi)
        {
            return Process.GetProcessesByName(ProgramAdi).Length > 0;
        }
        public FrmGuncelleme()
        {
            InitializeComponent();
            if (isRunning("NetSatis.BackOffice"))
            {
                if (MessageBox.Show("Güncellemeden önce açık olan uygulamanızın kapatılması gerekiyor onaylıyor musunuz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (var item in Process.GetProcessesByName("NetSatis.BackOffice"))
                    {
                        item.CloseMainWindow();
                        item.Kill();
                    }
                }
            }
        }

        private void btnIndir_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Application.StartupPath + "\\temp"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\temp");
            }
            indir.DownloadProgressChanged += (DownloadProgressChangedEventHandler)indirmeDurumu;
            indir.DownloadFileCompleted += (AsyncCompletedEventHandler)indirmeBitti;
            indir.DownloadFileAsync(new Uri("https://kozaapp.000webhostapp.com/downloads/Update.zip"),Application.StartupPath+"\\temp\\Update.zip");
        }

        private void indirmeBitti(object sender, AsyncCompletedEventArgs e)
        {
            ZipFile.ExtractToDirectory(Application.StartupPath + "\\temp\\Update.zip", Application.StartupPath + "\\temp");
            XElement Dosyalar = XElement.Load(Application.StartupPath + "\\temp\\Liste.xml");
            foreach (var veriler in Dosyalar.Elements().ToList())
            {
                if (File.Exists(Application.StartupPath + veriler.Element("YuklenecegiKonum").Value))
                {
                    File.Delete(Application.StartupPath + veriler.Element("YuklenecegiKonum").Value);
                }
                File.Copy(Application.StartupPath + "\\temp\\" + veriler.Element("DosyaAdi").Value, Application.StartupPath+ veriler.Element("YuklenecegiKonum").Value);
               
            }
            Directory.Delete(Application.StartupPath + "\\temp", true);
            MessageBox.Show("Güncelleme Tamamlandı.");
            this.Close();
        }

        public void indirmeDurumu(object sender,DownloadProgressChangedEventArgs e)
        {
            progressUpdate.Properties.Maximum = (int)e.TotalBytesToReceive;
            progressUpdate.Text = e.BytesReceived.ToString();
            lblIndirilen.Text = $"{(Convert.ToDecimal(e.BytesReceived)/1024/1024).ToString("N2")} MB\\{(Convert.ToDecimal(e.TotalBytesToReceive)/1024/1024).ToString("N2")} MB";
        }
    }
}
