namespace NetSatis.Reports.FaturaVeFis
{
    partial class rptFisBilgi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptFisBilgi));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrRichText1 = new DevExpress.XtraReports.UI.XRRichText();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lblFisKodu = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTarih = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.lblAraToplam = new DevExpress.XtraReports.UI.XRLabel();
            this.lblKdvToplam = new DevExpress.XtraReports.UI.XRLabel();
            this.lblGenelToplam = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblIndirimToplam = new DevExpress.XtraReports.UI.XRLabel();
            this.FirmaAdi = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrRichText1});
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 160.42F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrRichText1
            // 
            this.xrRichText1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot;
            this.xrRichText1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrRichText1.Dpi = 254F;
            this.xrRichText1.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.xrRichText1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrRichText1.Name = "xrRichText1";
            this.xrRichText1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString");
            this.xrRichText1.SizeF = new System.Drawing.SizeF(454.3959F, 160.42F);
            this.xrRichText1.StylePriority.UseBorderDashStyle = false;
            this.xrRichText1.StylePriority.UseBorders = false;
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 16F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 146F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblFisKodu,
            this.xrLabel1,
            this.xrLabel2,
            this.lblTarih});
            this.ReportHeader.Dpi = 254F;
            this.ReportHeader.HeightF = 254F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lblFisKodu
            // 
            this.lblFisKodu.Dpi = 254F;
            this.lblFisKodu.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFisKodu.LocationFloat = new DevExpress.Utils.PointFloat(0F, 148.0609F);
            this.lblFisKodu.Multiline = true;
            this.lblFisKodu.Name = "lblFisKodu";
            this.lblFisKodu.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblFisKodu.SizeF = new System.Drawing.SizeF(454.3959F, 45.19083F);
            this.lblFisKodu.StylePriority.UseFont = false;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Dpi = 254F;
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[FirmaAdi]")});
            this.xrLabel1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 13.12331F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(454.3959F, 45.19085F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Adis-B";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Dpi = 254F;
            this.xrLabel2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 58.31415F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(454.3959F, 45.19084F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Mamuşa";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lblTarih
            // 
            this.lblTarih.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.lblTarih.Dpi = 254F;
            this.lblTarih.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTarih.LocationFloat = new DevExpress.Utils.PointFloat(0F, 193.2517F);
            this.lblTarih.Multiline = true;
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblTarih.SizeF = new System.Drawing.SizeF(454.3959F, 45.19083F);
            this.lblTarih.StylePriority.UseBorders = false;
            this.lblTarih.StylePriority.UseFont = false;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblAraToplam,
            this.lblKdvToplam,
            this.lblGenelToplam,
            this.xrLabel3,
            this.xrLabel4,
            this.xrLabel5,
            this.xrLabel6,
            this.lblIndirimToplam});
            this.ReportFooter.Dpi = 254F;
            this.ReportFooter.HeightF = 254F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // lblAraToplam
            // 
            this.lblAraToplam.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblAraToplam.Dpi = 254F;
            this.lblAraToplam.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.lblAraToplam.LocationFloat = new DevExpress.Utils.PointFloat(297.3332F, 0F);
            this.lblAraToplam.Multiline = true;
            this.lblAraToplam.Name = "lblAraToplam";
            this.lblAraToplam.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblAraToplam.SizeF = new System.Drawing.SizeF(157.0628F, 58.42F);
            this.lblAraToplam.StylePriority.UseBorders = false;
            this.lblAraToplam.StylePriority.UseFont = false;
            this.lblAraToplam.StylePriority.UseTextAlignment = false;
            this.lblAraToplam.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            // 
            // lblKdvToplam
            // 
            this.lblKdvToplam.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblKdvToplam.Dpi = 254F;
            this.lblKdvToplam.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.lblKdvToplam.LocationFloat = new DevExpress.Utils.PointFloat(297.3332F, 116.8399F);
            this.lblKdvToplam.Multiline = true;
            this.lblKdvToplam.Name = "lblKdvToplam";
            this.lblKdvToplam.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblKdvToplam.SizeF = new System.Drawing.SizeF(157.0628F, 58.42001F);
            this.lblKdvToplam.StylePriority.UseBorders = false;
            this.lblKdvToplam.StylePriority.UseFont = false;
            this.lblKdvToplam.StylePriority.UseTextAlignment = false;
            this.lblKdvToplam.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblGenelToplam.Dpi = 254F;
            this.lblGenelToplam.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.lblGenelToplam.LocationFloat = new DevExpress.Utils.PointFloat(297.3332F, 175.2599F);
            this.lblGenelToplam.Multiline = true;
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblGenelToplam.SizeF = new System.Drawing.SizeF(157.0628F, 58.41998F);
            this.lblGenelToplam.StylePriority.UseBorders = false;
            this.lblGenelToplam.StylePriority.UseFont = false;
            this.lblGenelToplam.StylePriority.UseTextAlignment = false;
            this.lblGenelToplam.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Dpi = 254F;
            this.xrLabel3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(2.645793F, 116.8399F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(294.6874F, 58.42001F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Kdv Toplam : ";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Dpi = 254F;
            this.xrLabel4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(2.645793F, 175.2599F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(294.6874F, 58.41998F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Genel Toplam : ";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Dpi = 254F;
            this.xrLabel5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(2.645793F, 0F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(294.6874F, 58.42F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Ara Toplam : ";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Dpi = 254F;
            this.xrLabel6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(2.645793F, 58.41996F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(294.6874F, 58.42F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "İndirim Toplam : ";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lblIndirimToplam
            // 
            this.lblIndirimToplam.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblIndirimToplam.Dpi = 254F;
            this.lblIndirimToplam.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.lblIndirimToplam.LocationFloat = new DevExpress.Utils.PointFloat(297.3332F, 58.41996F);
            this.lblIndirimToplam.Multiline = true;
            this.lblIndirimToplam.Name = "lblIndirimToplam";
            this.lblIndirimToplam.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblIndirimToplam.SizeF = new System.Drawing.SizeF(157.0628F, 58.42F);
            this.lblIndirimToplam.StylePriority.UseBorders = false;
            this.lblIndirimToplam.StylePriority.UseFont = false;
            this.lblIndirimToplam.StylePriority.UseTextAlignment = false;
            this.lblIndirimToplam.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            // 
            // FirmaAdi
            // 
            this.FirmaAdi.Description = "Firma Adı";
            this.FirmaAdi.Name = "FirmaAdi";
            // 
            // rptFisBilgi
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.ReportFooter});
            this.Dpi = 254F;
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 16, 146);
            this.PageHeight = 2794;
            this.PageWidth = 483;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.FirmaAdi});
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.RollPaper = true;
            this.ShowPrintMarginsWarning = false;
            this.SnapGridSize = 25F;
            this.Version = "18.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRRichText xrRichText1;
        private DevExpress.XtraReports.UI.XRLabel lblFisKodu;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel lblTarih;
        private DevExpress.XtraReports.UI.XRLabel lblAraToplam;
        private DevExpress.XtraReports.UI.XRLabel lblKdvToplam;
        private DevExpress.XtraReports.UI.XRLabel lblGenelToplam;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel lblIndirimToplam;
        private DevExpress.XtraReports.Parameters.Parameter FirmaAdi;
    }
}
