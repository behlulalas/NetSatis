using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
using NetSatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Tools
{
    public static class RoleTool
    {
        public static Kullanici kullaniciEntity;

        public static void RolleriYukle(XtraForm form)
        {
            NetSatisContext context = new NetSatisContext();
            foreach (var item in context.KullaniciRolleri.Where(c =>c.KullaniciAdi==kullaniciEntity.KullaniciAdi && c.FormAdi == form.Name && c.Yetki == false).ToList())
            {
                var bulunan = form.Controls.Find(item.KontrolAdi, true).FirstOrDefault();
                if (bulunan!=null)
                {
                    bulunan.Enabled = false;
                }
            }
        }

        public static void RolleriYukle(RibbonControl form)
        {
            NetSatisContext context = new NetSatisContext();
            foreach (var item in context.KullaniciRolleri.Where(c => c.KullaniciAdi == kullaniciEntity.KullaniciAdi && c.FormAdi == "FrmAnaMenu" && c.Yetki == false).ToList())
            {
                form.Items.Where(c => c.Name == item.KontrolAdi).SingleOrDefault().Enabled = false;
            }
        }
    }
}
