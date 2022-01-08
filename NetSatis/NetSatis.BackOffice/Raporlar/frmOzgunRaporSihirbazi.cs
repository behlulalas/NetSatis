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
using DevExpress.DashboardCommon;

namespace NetSatis.BackOffice.Raporlar
{
    public partial class frmOzgunRaporSihirbazi : DevExpress.XtraEditors.XtraForm
    {
        public frmOzgunRaporSihirbazi(List<object> veriListesi = null)
        {
            InitializeComponent();
            if (veriListesi != null)
            {
                foreach (var item in veriListesi)
                {
                    DashboardObjectDataSource dataSource = new DashboardObjectDataSource();
                    dataSource.DataSource = item;
                    dataSource.Fill();
                    dashboardDesigner1.Dashboard.DataSources.Add(dataSource);
                }
            }
        }
    }
}