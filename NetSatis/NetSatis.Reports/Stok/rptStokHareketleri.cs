using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using NetSatis.Entities.DataAccess;
using NetSatis.Entities.Context;
using DevExpress.DataAccess.ObjectBinding;

namespace NetSatis.Reports.Stok
{
    public partial class rptStokHareketleri : DevExpress.XtraReports.UI.XtraReport
    {
        
        public rptStokHareketleri()
        {
            InitializeComponent();
            NetSatisContext context = new NetSatisContext();
            StokHareketDAL stokHareketDAL = new StokHareketDAL();
            ObjectDataSource stokDataSource = new ObjectDataSource { DataSource = stokHareketDAL.GetAll(context) };
            this.DataSource = stokDataSource;
            colFisKodu.DataBindings.Add("Text", this.DataSource, "Fiskodu");
            colBirimi.DataBindings.Add("Text", this.DataSource, "Birimi");
            colKDV.DataBindings.Add("Text", this.DataSource, "Kdv","{0:'%'0}");
            colMiktar.DataBindings.Add("Text", this.DataSource, "Miktar");
            colBirimFiyati.DataBindings.Add("Text", this.DataSource, "BirimFiyati", "{0:C2}");
            colIndirimOrani.DataBindings.Add("Text", this.DataSource, "IndirimOrani", "{0:'%'0}");

            CalculatedField calcIndirimTutari = new CalculatedField();
            this.CalculatedFields.Add(calcIndirimTutari);
            calcIndirimTutari.Name = "IndirimTutari";
            calcIndirimTutari.Expression = "([BirimFiyati]*[Miktar])/100*[IndirimOrani]";

            CalculatedField calcTutar = new CalculatedField();
            this.CalculatedFields.Add(calcTutar);
            calcTutar.Name = "Tutar";
            calcTutar.Expression = "([BirimFiyati]*[Miktar])-[IndirimTutari]";

            colIndirimTutari.DataBindings.Add("Text", null, "IndirimTutari", "{0:C2}");
            colTutar.DataBindings.Add("Text", null, "Tutar", "{0:C2}");

            XRSummary sumIndirimTutari = new XRSummary();
            sumIndirimTutari.Func = SummaryFunc.Sum;
            sumIndirimTutari.Running = SummaryRunning.Group;
            sumIndirimTutari.FormatString = "{0:C2}";

            XRSummary sumToplamTutar = new XRSummary();
            sumToplamTutar.Func = SummaryFunc.Sum;
            sumToplamTutar.Running = SummaryRunning.Group;
            sumToplamTutar.FormatString = "{0:C2}";

            lblIndirimTutari.Summary = sumIndirimTutari;
            lblToplamTutar.Summary = sumToplamTutar;

            lblIndirimTutari.DataBindings.Add("Text", null, "IndirimTutari");
            lblToplamTutar.DataBindings.Add("Text", null, "Tutar");


        }
    }
}
