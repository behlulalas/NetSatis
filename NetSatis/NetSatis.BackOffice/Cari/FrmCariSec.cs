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

namespace NetSatis.BackOffice.Cari
{
    public partial class FrmCariSec : DevExpress.XtraEditors.XtraForm
    {
        CariDAL cariDAL = new CariDAL();
        NetSatisContext context = new NetSatisContext();
        public List<Entities.Tables.Cari> secilen = new List<Entities.Tables.Cari>();
        public bool secildi = false;
        public FrmCariSec(bool cokluSecim = false)
        {
            InitializeComponent();
            if (cokluSecim)
            {
                lblUyari.Visible = true;
                gridCariler.OptionsSelection.MultiSelect = true;
            }
            gridcontCariler.DataSource = cariDAL.GetCariler(context);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridCariler.GetSelectedRows().Count() != 0)
            {
                foreach (var row in gridCariler.GetSelectedRows())
                {
                    string cariKodu = gridCariler.GetRowCellValue(row, colCariKodu).ToString();
                    secilen.Add(context.Cariler.SingleOrDefault(c => c.CariKodu == cariKodu));
                }
                secildi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seçilen cari bulunamadı.");
            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}