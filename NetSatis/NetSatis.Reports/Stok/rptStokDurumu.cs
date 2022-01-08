using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using NetSatis.Entities.Context;
using NetSatis.Entities.DataAccess;
using DevExpress.DataAccess.ObjectBinding;

namespace NetSatis.Reports.Stok
{
    public partial class rptStokDurumu : DevExpress.XtraReports.UI.XtraReport
    {
        public rptStokDurumu()
        {
            InitializeComponent();
            NetSatisContext context = new NetSatisContext();
            StokDAL stokDAL = new StokDAL();

            ObjectDataSource stokDataSource = new ObjectDataSource { DataSource = stokDAL.GetAllJoin(context) };
            this.DataSource = stokDataSource;
            colStokKodu.DataBindings.Add("Text", this.DataSource, "StokKodu");
            colBarkod.DataBindings.Add("Text", this.DataSource, "Barkod");
            colStokAdi.DataBindings.Add("Text", this.DataSource, "StokAdi");
            colBirimi.DataBindings.Add("Text", this.DataSource, "Birimi");
            colStokGrubu.DataBindings.Add("Text", this.DataSource, "StokGrubu");
            colStokAltGrubu.DataBindings.Add("Text", this.DataSource, "StokAltGrubu");
            colSatisKdv.DataBindings.Add("Text", this.DataSource, "SatisKdv");
            colStokGiris.DataBindings.Add("Text", this.DataSource, "StokGiris");
            colStokCikis.DataBindings.Add("Text", this.DataSource, "StokCikis");
            colMevcutStok.DataBindings.Add("Text", this.DataSource, "MevcutStok");
          
                
        }

    }
}
