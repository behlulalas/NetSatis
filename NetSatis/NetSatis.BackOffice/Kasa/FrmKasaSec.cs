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

namespace NetSatis.BackOffice.Kasa
{
    public partial class FrmKasaSec : DevExpress.XtraEditors.XtraForm
    {
        KasaDAL kasaDAL = new KasaDAL();
        NetSatisContext context = new NetSatisContext();
        public Entities.Tables.Kasa entity = new Entities.Tables.Kasa();
        public bool secildi = false;
        public FrmKasaSec()
        {
            InitializeComponent();
        }

        private void FrmKasaSec_Load(object sender, EventArgs e)
        {
            gridcontKasalar.DataSource = kasaDAL.KasaListele(context);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridKasalar.SelectedRowsCount != 0)
            {
                string kasaKodu = gridKasalar.GetFocusedRowCellValue(colKasaKodu).ToString();
                entity = context.Kasalar.SingleOrDefault(c => c.KasaKodu == kasaKodu);
                secildi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seçilen Kasa bulunamadı.");
            }
           
        }
    }
}