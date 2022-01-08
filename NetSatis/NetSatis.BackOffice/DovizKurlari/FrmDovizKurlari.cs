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
using System.Xml.Linq;
using NetSatis.Entities.Tables.OtherTables;
using System.Net;
using System.IO;
using System.Net.NetworkInformation;
using NetSatis.Entities.Tools;

namespace NetSatis.BackOffice.DovizKurlari
{
    public partial class FrmDovizKurlari : DevExpress.XtraEditors.XtraForm
    {
        public FrmDovizKurlari()
        {
            InitializeComponent();
            FileInfo info = new FileInfo(Application.StartupPath + "\\Kurlar.xml");
            lblUyari.Text = "Son Güncelleme Tarihi: " + info.LastWriteTime.ToString();
        }
        private bool checkConnection()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void Guncelle(bool indir = true)
        {
            if (indir)
            {
                if (checkConnection())
                {
                    using (WebClient kurindir = new WebClient())
                    {
                        kurindir.DownloadFile("https://tcmb.gov.tr/kurlar/today.xml", Application.StartupPath + "\\Kurlar.xml");
                    }
                    lblUyari.Text = "Son Güncelleme Tarihi: " + DateTime.Now;
                }
                else
                {
                    MessageBox.Show("İnternet bağlantınızı kontrol edin. !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            ExchangeTool exchangeTool = new ExchangeTool();

            gridControl1.DataSource = exchangeTool.DovizKuruCek();
        }

        private void FrmDovizKurlari_Load(object sender, EventArgs e)
        {
            Guncelle(false);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }
    }
}