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
using NetSatis.Entities.Tools;

namespace NetSatis.BackOffice.Sms
{
    public partial class FrmSms : DevExpress.XtraEditors.XtraForm
    {
        public FrmSms()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SettingsTool.AyarOku(SettingsTool.Ayarlar.SmsAyarlari_Parola));
        }
    }
}