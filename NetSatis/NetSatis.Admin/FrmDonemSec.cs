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

namespace NetSatis.Admin
{
    public partial class FrmDonemSec : DevExpress.XtraEditors.XtraForm
    {
        public string secilenDonem;
        public FrmDonemSec()
        {
            InitializeComponent();
            DonemListele();
        }
        private void DonemListele()
        {
            List<string> dbList;
            NetSatisContext context = new NetSatisContext();
            dbList = context.Database.SqlQuery<string>("Select name from master.dbo.sysdatabases where name like 'NetSatis%'").ToList();
            foreach (var item in dbList)
            {
                CheckButton button = new CheckButton
                {
                    Name = item,
                    Text = item.Replace("NetSatis", ""),
                    GroupIndex = 1,
                    ImageList = ımageList1,
                    ImageIndex = 0,
                    ImageToTextAlignment = ImageAlignToText.TopCenter,
                    Height = 100,
                    Width = 100,
                };
                button.Click += SecilenButon;
                flowLayoutPanel1.Controls.Add(button);
            }
        }

        private void SecilenButon(object sender, EventArgs e)
        {
            CheckButton button = (CheckButton)sender;
            secilenDonem = "NetSatis" + button.Text;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(secilenDonem))
            {
                MessageBox.Show("Lütfen bir dönem seçiniz");
            }
            else
            {
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}