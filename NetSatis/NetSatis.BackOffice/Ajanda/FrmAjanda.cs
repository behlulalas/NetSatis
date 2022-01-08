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
using DevExpress.XtraScheduler;
using NetSatis.Entities.Context;
using System.Data.Entity;

namespace NetSatis.BackOffice.Ajanda
{
    public partial class FrmAjanda : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        public FrmAjanda()
        {
            InitializeComponent();
        }

        private void FrmAjanda_FormClosing(object sender, FormClosingEventArgs e)
        {
            context.SaveChanges();
        }

        private void FrmAjanda_Load(object sender, EventArgs e)
        {
            context.EFAppointments.Load();
            context.EFResources.Load();
            schedulerControl1.DataStorage.Appointments.DataSource = context.EFAppointments.Local;
            schedulerControl1.DataStorage.Resources.DataSource = context.EFResources.Local;
        }
    }
}