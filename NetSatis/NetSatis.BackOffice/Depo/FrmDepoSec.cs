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

namespace NetSatis.BackOffice.Depo
{
    public partial class FrmDepoSec : DevExpress.XtraEditors.XtraForm
    {
        DepoDAL depoDAL = new DepoDAL();
        NetSatisContext context = new NetSatisContext();
        public Entities.Tables.Depo entity = new Entities.Tables.Depo();
        private int _stokId;
        public bool secildi = false;
        public FrmDepoSec(int stokId)
        {
            InitializeComponent();
            _stokId = stokId;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDepoSec_Load(object sender, EventArgs e)
        {
            gridcontDepolar.DataSource = depoDAL.DepoBazindaStokListele(context, _stokId);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridDepolar.SelectedRowsCount != 0)
            {
                string depoKodu = gridDepolar.GetFocusedRowCellValue(colDepoKodu).ToString();
                entity = context.Depolar.SingleOrDefault(c => c.DepoKodu == depoKodu);
                secildi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seçilen depo bulunamadı.");
            }
        }
    }
}