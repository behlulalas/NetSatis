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

namespace NetSatis.BackOffice.Fis
{
    public partial class FrmSeriNoGir : DevExpress.XtraEditors.XtraForm
    {
        public string veriSeriNo;
        public bool locked=true;
        public FrmSeriNoGir(string veri)
        {
            InitializeComponent();
            if (veri != null)
            {
                string[] veriListesi = veri.Split(new[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in veriListesi)
                {
                    listSeriNo.Items.Add(item);
                }

            }

        }
        void KayitAc()
        {
            btnEkle.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = true;
            btnVazgec.Enabled = true;
            grpBilgi.Enabled = true;
            txtSeriNo.Focus();
        }
        void KayitKapat()
        {
            btnEkle.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            btnVazgec.Enabled = false;
            grpBilgi.Enabled = false;
            txtSeriNo.Text = null;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            KayitAc();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            listSeriNo.Items.Remove(listSeriNo.SelectedItem);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            listSeriNo.Items.Add(txtSeriNo.Text);
            KayitKapat();

        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            KayitKapat();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSeriNoGir_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listSeriNo.ItemCount!=0)
            {
                foreach (var item in listSeriNo.Items)
                {
                    veriSeriNo += item + System.Environment.NewLine;
                }
            }
        }

        private void FrmSeriNoGir_Load(object sender, EventArgs e)
        {
            if (locked)
            {
                grpMenu.Enabled = false;
            }
        }
    }
}