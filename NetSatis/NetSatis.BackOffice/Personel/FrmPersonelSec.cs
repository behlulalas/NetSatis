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

namespace NetSatis.BackOffice.Personel
{
    public partial class FrmPersonelSec : DevExpress.XtraEditors.XtraForm
    {
        PersonelDAL personelDAL = new PersonelDAL();
        NetSatisContext context = new NetSatisContext();
        public List<Entities.Tables.PersonelHareket> secilen = new List<Entities.Tables.PersonelHareket>();
        public bool secildi = false;
        private DateTime _donem;
        public FrmPersonelSec(DateTime donem,bool cokluSecim = false)
        {
            InitializeComponent();
            _donem = donem;
            if (cokluSecim)
            {
                lblUyari.Visible = true;
                gridPersoneller.OptionsSelection.MultiSelect = true;
            }
            gridcontPersoneller.DataSource = personelDAL.GetPersonelListbyDate(context,donem.Month,donem.Year);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridPersoneller.GetSelectedRows().Count() != 0)
            {
                foreach (var row in gridPersoneller.GetSelectedRows())
                {
                    string personelKodu = gridPersoneller.GetRowCellValue(row, colPersonelKodu).ToString();
                    secilen.Add(new Entities.Tables.PersonelHareket
                    {
                        PersonelKodu = gridPersoneller.GetRowCellValue(row, colPersonelKodu).ToString(),
                        PersonelAdi = gridPersoneller.GetRowCellValue(row, colPersonelAdi).ToString(),
                        TcKimlikNo = gridPersoneller.GetRowCellValue(row, colTcKimlikNo).ToString(),
                        Unvani = gridPersoneller.GetRowCellValue(row, colUnvani).ToString(),
                        Donemi = _donem,
                        AylikMaasi=Convert.ToDecimal(gridPersoneller.GetRowCellValue(row, colAylikMaas).ToString()),
                        PrimOrani=Convert.ToDecimal(gridPersoneller.GetRowCellValue(row, colPrimOrani).ToString()),
                        ToplamSatis=Convert.ToDecimal(gridPersoneller.GetRowCellValue(row, colToplamSatis).ToString())
                    });
                }
                secildi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seçilen cari bulunamadı.");
            }
        }
    }
}