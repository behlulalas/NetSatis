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
using NetSatis.Reports.Stok;
using System.Reflection;
using DevExpress.XtraNavBar;
using DevExpress.XtraReports.UI;

namespace NetSatis.BackOffice.Raporlar
{
    public partial class frmRaporListesi : DevExpress.XtraEditors.XtraForm
    {
        XtraReport report;
        public frmRaporListesi()
        {
            InitializeComponent();
        }
        private void navBarLink_Clicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            filterControl1.FilterString = null;
            var buton = sender as NavBarItem;
            Type tip = Assembly.Load("NetSatis.Reports").GetTypes().SingleOrDefault(c=>c.Name==buton.Name.Replace("link",""));
            report =(XtraReport) Activator.CreateInstance(tip);
            txtRaporAdi.Text = e.Link.Caption;
            txtRaporGrubu.Text = e.Link.Group.Caption;
            txtAciklama.Text = buton.Tag.ToString()??"";
            filterControl1.SourceControl = report.DataSource;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRaporGoruntule_Click(object sender, EventArgs e)
        {
            FrmRaporGoruntule form = new FrmRaporGoruntule(report);
            report.FilterString = filterControl1.FilterString;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }
    }
}