using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using NetSatis.Entities.Context;
using NetSatis.Entities.DataAccess;
using NetSatis.Entities.Tables;
using DevExpress.DataAccess.ObjectBinding;

namespace NetSatis.Reports.FaturaVeFis
{
    public partial class rptFisBilgi : DevExpress.XtraReports.UI.XtraReport
    {
        public rptFisBilgi(string fisKodu)
        {
            InitializeComponent();
            NetSatisContext context = new NetSatisContext();
            StokHareketDAL stokHareketDAL = new StokHareketDAL();
            FisDAL fisDAL = new FisDAL();
            Fis fisBilgi = fisDAL.GetByFilter(context, c => c.FisKodu == fisKodu);
            ObjectDataSource stokDataSource = new ObjectDataSource { DataSource = stokHareketDAL.GetAll(context, c => c.FisKodu == fisKodu) };
            this.DataSource = stokDataSource;
            lblFisKodu.Text = "Fiş Kodu: "+fisBilgi.FisKodu;
            lblTarih.Text = "Tarih   : "+fisBilgi.Tarih.ToString();

            CalculatedField calcTutar = new CalculatedField();
            this.CalculatedFields.Add(calcTutar);
            calcTutar.Name = "Tutar";
            calcTutar.Expression = "[BirimFiyati]*[Miktar]";

            CalculatedField calcIndirimTutari = new CalculatedField();
            this.CalculatedFields.Add(calcIndirimTutari);
            calcIndirimTutari.Name = "IndirimTutari";
            calcIndirimTutari.Expression = "([BirimFiyati]*[Miktar])/100*[IndirimOrani]";

            CalculatedField calcKdvToplam = new CalculatedField();
            this.CalculatedFields.Add(calcKdvToplam);
            calcKdvToplam.Name = "KdvTutari";
            calcKdvToplam.Expression = "([BirimFiyati]*[Miktar]-[IndirimTutari])/100*[Kdv]";

            CalculatedField calcKdvsizToplam = new CalculatedField();
            this.CalculatedFields.Add(calcKdvsizToplam);
            calcKdvsizToplam.Name = "AraToplam";
            calcKdvsizToplam.Expression = "([BirimFiyati]*[Miktar])-[KdvTutari]-[IndirimTutari]";

            CalculatedField calcKdvliTutar = new CalculatedField();
            this.CalculatedFields.Add(calcKdvliTutar);
            calcKdvliTutar.Name = "KdvDahil";
            calcKdvliTutar.Expression = "([BirimFiyati]*[Miktar])-[IndirimTutari]";

            //colToplamTutar.DataBindings.Add("Text", null, "Tutar", "{0:C2}");

            XRSummary sumAraToplam = new XRSummary();
            sumAraToplam.Func = SummaryFunc.Sum;
            sumAraToplam.Running = SummaryRunning.Report;
            sumAraToplam.FormatString = "{0:C2}";

            XRSummary sumIndirimToplam = new XRSummary();
            sumIndirimToplam.Func = SummaryFunc.Sum;
            sumIndirimToplam.Running = SummaryRunning.Report;
            sumIndirimToplam.FormatString = "{0:C2}";

            XRSummary sumKdvToplam = new XRSummary();
            sumKdvToplam.Func = SummaryFunc.Sum;
            sumKdvToplam.Running = SummaryRunning.Report;
            sumKdvToplam.FormatString = "{0:C2}";

            XRSummary sumGenelToplam = new XRSummary();
            sumGenelToplam.Func = SummaryFunc.Sum;
            sumGenelToplam.Running = SummaryRunning.Report;
            sumGenelToplam.FormatString = "{0:C2}";

            lblAraToplam.DataBindings.Add("Text", null, "AraToplam");
            lblIndirimToplam.DataBindings.Add("Text", null, "IndirimTutari");
            lblKdvToplam.DataBindings.Add("Text", null, "KdvTutari");
            lblGenelToplam.DataBindings.Add("Text", null, "KdvDahil");

            lblAraToplam.Summary = sumAraToplam;
            lblIndirimToplam.Summary = sumIndirimToplam;
            lblKdvToplam.Summary = sumKdvToplam;
            lblGenelToplam.Summary = sumGenelToplam;
        }

    }
}
