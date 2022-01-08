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

namespace NetSatis.BackOffice.Stok
{
    public partial class FrmStokSec : DevExpress.XtraEditors.XtraForm
    {
        StokDAL stokDAL = new StokDAL();
        NetSatisContext context = new NetSatisContext();
        public List<Entities.Tables.Stok> secilen = new List<Entities.Tables.Stok>();
        public bool secildi=false;
        public FrmStokSec(bool cokluSecim=false)
        {
            InitializeComponent();
            if (cokluSecim)
            {
                lblUyari.Visible = true;
                gridStoklar.OptionsSelection.MultiSelect = true;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStokSec_Load(object sender, EventArgs e)
        {
            gridcontStoklar.DataSource = stokDAL.GetAllJoin(context);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridStoklar.GetSelectedRows().Count()!=0)
            {
                foreach (var row in gridStoklar.GetSelectedRows())
                {
                    string stokKodu = gridStoklar.GetRowCellValue(row, colStokKodu).ToString();
                    secilen.Add(context.Stoklar.SingleOrDefault(c => c.StokKodu == stokKodu));
                }
                secildi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seçilen bir ürün bulunamadı.");
            }

        }
    }
}