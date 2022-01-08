using NetSatis.Entities.Tables.OtherTables;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NetSatis.Entities.Tools
{
    public class ExchangeTool
    {
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
        public List<DovizKuru> DovizKuruCek()
        {
            if (!File.Exists(Application.StartupPath + "\\Kurlar.xml"))
            {


                if (checkConnection())
                {
                    using (WebClient kurindir = new WebClient())
                    {
                        kurindir.DownloadFile("https://tcmb.gov.tr/kurlar/today.xml", Application.StartupPath + "\\Kurlar.xml");
                    }
                }
                else
                {
                    MessageBox.Show("İnternet bağlantınızı kontrol edin. !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            XElement kurlar = XElement.Load(Application.StartupPath + "\\Kurlar.xml");
            List<DovizKuru> listKurlar = new List<DovizKuru>();
            string ondalikKarakter = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator.ToString();
            foreach (var item in kurlar.Elements().Where(c => c.Attribute("CurrencyCode").Value != "XDR").ToList())
            {
                listKurlar.Add(new DovizKuru
                {
                    CurrencyCode = item.Attribute("CurrencyCode").Value,
                    Isim = item.Element("Isim").Value,
                    ForexBuying = Convert.ToDecimal(item.Element("ForexBuying").Value.Replace(".", ondalikKarakter)),
                    ForexSelling = Convert.ToDecimal(item.Element("ForexSelling").Value.Replace(".", ondalikKarakter)),
                    BanknoteBuying = item.Element("BanknoteBuying").Value == "" ? 0 : Convert.ToDecimal(item.Element("BanknoteBuying").Value.Replace(".", ondalikKarakter)),
                    BanknoteSelling = item.Element("BanknoteSelling").Value == "" ? 0 : Convert.ToDecimal(item.Element("BanknoteSelling").Value.Replace(".", ondalikKarakter)),
                });
            }
            return listKurlar;
        }
    }
}
