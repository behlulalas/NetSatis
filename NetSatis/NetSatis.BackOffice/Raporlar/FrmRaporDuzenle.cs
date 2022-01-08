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
using DevExpress.XtraReports.UI;

namespace NetSatis.BackOffice.Raporlar
{
    public partial class FrmRaporDuzenle : DevExpress.XtraEditors.XtraForm
    {
        public FrmRaporDuzenle(XtraReport rapor=null)
        {
            InitializeComponent();
            if (rapor!=null)
            {
                reportDesigner1.OpenReport(rapor);
            }
        }
    }
}