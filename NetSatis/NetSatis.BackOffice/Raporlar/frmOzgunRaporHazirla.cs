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
using System.Reflection;

namespace NetSatis.BackOffice.Raporlar
{
    public partial class frmOzgunRaporHazirla : DevExpress.XtraEditors.XtraForm
    {
        List<object> veriListesi = new List<object>();
        NetSatisContext context = new NetSatisContext();
        public frmOzgunRaporHazirla()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHazirla_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBoxControl1.Items.Where(c => c.CheckState == CheckState.Checked).ToList())
            {
                Type tip = Assembly.Load("NetSatis.Entities").GetTypes().SingleOrDefault(c => c.Name == item.Value.ToString());
                object veri = Activator.CreateInstance(tip);
                MethodInfo info = tip.GetMethod(item.Tag.ToString());
                try
                {
                    veriListesi.Add(info.Invoke(veri, new object[] { context }));
                }
                catch (Exception)
                {

                    veriListesi.Add(info.Invoke(veri, new object[] { context,null }));
                }
                
            }
            frmOzgunRaporSihirbazi frm = new frmOzgunRaporSihirbazi(veriListesi);
            frm.Show();
        }
    }
}