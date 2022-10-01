namespace NetSatis.BackOffice.Fis
{
    partial class FrmFis
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFis));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnFiltre = new DevExpress.XtraEditors.SimpleButton();
            this.imgMenu = new System.Windows.Forms.ImageList(this.components);
            this.btnFiltreIptal = new DevExpress.XtraEditors.SimpleButton();
            this.btnFiltreKapat = new DevExpress.XtraEditors.SimpleButton();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.gridcontFisler = new DevExpress.XtraGrid.GridControl();
            this.gridFisler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBelgeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlasiyerKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlasiyerAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskontoOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskontoTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.dropExport = new DevExpress.XtraEditors.DropDownButton();
            this.btnEkle = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barFaturalar = new DevExpress.XtraBars.BarSubItem();
            this.barAlisFisi = new DevExpress.XtraBars.BarButtonItem();
            this.barSatisFisi = new DevExpress.XtraBars.BarButtonItem();
            this.barToptanSatis = new DevExpress.XtraBars.BarButtonItem();
            this.barIadeFaturalari = new DevExpress.XtraBars.BarSubItem();
            this.barAlisIade = new DevExpress.XtraBars.BarButtonItem();
            this.barSatisIade = new DevExpress.XtraBars.BarButtonItem();
            this.barKasaFisleri = new DevExpress.XtraBars.BarSubItem();
            this.barOdemeFisi = new DevExpress.XtraBars.BarButtonItem();
            this.barTahsilatFisi = new DevExpress.XtraBars.BarButtonItem();
            this.barCariDevir = new DevExpress.XtraBars.BarButtonItem();
            this.barStokFisleri = new DevExpress.XtraBars.BarSubItem();
            this.barSayimFazlasi = new DevExpress.XtraBars.BarButtonItem();
            this.barSayimEksigi = new DevExpress.XtraBars.BarButtonItem();
            this.barStokDevir = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnFaturalandir = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontFisler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFisler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 52);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.btnFiltre);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnFiltreIptal);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnFiltreKapat);
            this.splitContainerControl1.Panel1.Controls.Add(this.filterControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridcontFisler);
            this.splitContainerControl1.Panel2.Controls.Add(this.grpMenu);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1142, 519);
            this.splitContainerControl1.SplitterPosition = 192;
            this.splitContainerControl1.TabIndex = 4;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // btnFiltre
            // 
            this.btnFiltre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltre.ImageOptions.ImageIndex = 1;
            this.btnFiltre.ImageOptions.ImageList = this.imgMenu;
            this.btnFiltre.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnFiltre.Location = new System.Drawing.Point(987, 105);
            this.btnFiltre.Name = "btnFiltre";
            this.btnFiltre.Size = new System.Drawing.Size(44, 46);
            this.btnFiltre.TabIndex = 0;
            this.btnFiltre.Click += new System.EventHandler(this.btnFiltre_Click);
            // 
            // imgMenu
            // 
            this.imgMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMenu.ImageStream")));
            this.imgMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMenu.Images.SetKeyName(0, "folder_out.png");
            this.imgMenu.Images.SetKeyName(1, "funnel.png");
            this.imgMenu.Images.SetKeyName(2, "funnel_delete.png");
            this.imgMenu.Images.SetKeyName(3, "refresh.png");
            this.imgMenu.Images.SetKeyName(4, "replace2.png");
            this.imgMenu.Images.SetKeyName(5, "view.png");
            this.imgMenu.Images.SetKeyName(6, "note_add.png");
            this.imgMenu.Images.SetKeyName(7, "note_delete.png");
            this.imgMenu.Images.SetKeyName(8, "note_edit.png");
            // 
            // btnFiltreIptal
            // 
            this.btnFiltreIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltreIptal.ImageOptions.ImageIndex = 2;
            this.btnFiltreIptal.ImageOptions.ImageList = this.imgMenu;
            this.btnFiltreIptal.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnFiltreIptal.Location = new System.Drawing.Point(1037, 105);
            this.btnFiltreIptal.Name = "btnFiltreIptal";
            this.btnFiltreIptal.Size = new System.Drawing.Size(44, 46);
            this.btnFiltreIptal.TabIndex = 0;
            this.btnFiltreIptal.Click += new System.EventHandler(this.btnFiltreIptal_Click);
            // 
            // btnFiltreKapat
            // 
            this.btnFiltreKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltreKapat.ImageOptions.ImageIndex = 0;
            this.btnFiltreKapat.ImageOptions.ImageList = this.imgMenu;
            this.btnFiltreKapat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnFiltreKapat.Location = new System.Drawing.Point(1086, 105);
            this.btnFiltreKapat.Name = "btnFiltreKapat";
            this.btnFiltreKapat.Size = new System.Drawing.Size(44, 46);
            this.btnFiltreKapat.TabIndex = 0;
            this.btnFiltreKapat.Click += new System.EventHandler(this.btnFiltreKapat_Click);
            // 
            // filterControl1
            // 
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterControl1.Location = new System.Drawing.Point(0, 0);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.Size = new System.Drawing.Size(1142, 192);
            this.filterControl1.SortFilterColumns = false;
            this.filterControl1.TabIndex = 0;
            this.filterControl1.Text = "filterControl1";
            // 
            // gridcontFisler
            // 
            this.gridcontFisler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridcontFisler.Location = new System.Drawing.Point(0, 0);
            this.gridcontFisler.MainView = this.gridFisler;
            this.gridcontFisler.Name = "gridcontFisler";
            this.gridcontFisler.Size = new System.Drawing.Size(1142, 246);
            this.gridcontFisler.TabIndex = 4;
            this.gridcontFisler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridFisler});
            // 
            // gridFisler
            // 
            this.gridFisler.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFisKodu,
            this.colFisTuru,
            this.colCariKodu,
            this.colCariAdi,
            this.colBelgeNo,
            this.colTarih,
            this.colSaat,
            this.colPlasiyerKodu,
            this.colPlasiyerAdi,
            this.colIskontoOrani,
            this.colIskontoTutar,
            this.colToplamTutar,
            this.colAciklama});
            this.gridFisler.CustomizationFormBounds = new System.Drawing.Rectangle(1034, 265, 260, 232);
            this.gridFisler.GridControl = this.gridcontFisler;
            this.gridFisler.Name = "gridFisler";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colFisKodu
            // 
            this.colFisKodu.Caption = "Fiş Kodu";
            this.colFisKodu.FieldName = "FisKodu";
            this.colFisKodu.Name = "colFisKodu";
            this.colFisKodu.OptionsColumn.AllowEdit = false;
            this.colFisKodu.Visible = true;
            this.colFisKodu.VisibleIndex = 0;
            this.colFisKodu.Width = 51;
            // 
            // colFisTuru
            // 
            this.colFisTuru.Caption = "Fiş Türü";
            this.colFisTuru.FieldName = "FisTuru";
            this.colFisTuru.Name = "colFisTuru";
            this.colFisTuru.OptionsColumn.AllowEdit = false;
            this.colFisTuru.Visible = true;
            this.colFisTuru.VisibleIndex = 1;
            this.colFisTuru.Width = 154;
            // 
            // colCariKodu
            // 
            this.colCariKodu.Caption = "Cari Kodu";
            this.colCariKodu.FieldName = "Cari.CariKodu";
            this.colCariKodu.Name = "colCariKodu";
            this.colCariKodu.OptionsColumn.AllowEdit = false;
            this.colCariKodu.Visible = true;
            this.colCariKodu.VisibleIndex = 2;
            this.colCariKodu.Width = 71;
            // 
            // colCariAdi
            // 
            this.colCariAdi.Caption = "Cari Adı";
            this.colCariAdi.FieldName = "Cari.CariAdi";
            this.colCariAdi.Name = "colCariAdi";
            this.colCariAdi.OptionsColumn.AllowEdit = false;
            this.colCariAdi.Visible = true;
            this.colCariAdi.VisibleIndex = 3;
            this.colCariAdi.Width = 71;
            // 
            // colBelgeNo
            // 
            this.colBelgeNo.Caption = "Belge No";
            this.colBelgeNo.FieldName = "BelgeNo";
            this.colBelgeNo.Name = "colBelgeNo";
            this.colBelgeNo.OptionsColumn.AllowEdit = false;
            this.colBelgeNo.Visible = true;
            this.colBelgeNo.VisibleIndex = 4;
            this.colBelgeNo.Width = 61;
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Tarih";
            this.colTarih.DisplayFormat.FormatString = "d";
            this.colTarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 5;
            this.colTarih.Width = 76;
            // 
            // colSaat
            // 
            this.colSaat.Caption = "Saat";
            this.colSaat.DisplayFormat.FormatString = "t";
            this.colSaat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSaat.FieldName = "Tarih";
            this.colSaat.Name = "colSaat";
            this.colSaat.OptionsColumn.AllowEdit = false;
            this.colSaat.Visible = true;
            this.colSaat.VisibleIndex = 6;
            this.colSaat.Width = 47;
            // 
            // colPlasiyerKodu
            // 
            this.colPlasiyerKodu.Caption = "Plasiyer Kodu";
            this.colPlasiyerKodu.FieldName = "Personel.PersonelKodu";
            this.colPlasiyerKodu.Name = "colPlasiyerKodu";
            this.colPlasiyerKodu.OptionsColumn.AllowEdit = false;
            // 
            // colPlasiyerAdi
            // 
            this.colPlasiyerAdi.Caption = "Plasiyer Adı";
            this.colPlasiyerAdi.FieldName = "Personel.PersonelAdi";
            this.colPlasiyerAdi.Name = "colPlasiyerAdi";
            this.colPlasiyerAdi.OptionsColumn.AllowEdit = false;
            this.colPlasiyerAdi.Visible = true;
            this.colPlasiyerAdi.VisibleIndex = 7;
            this.colPlasiyerAdi.Width = 71;
            // 
            // colIskontoOrani
            // 
            this.colIskontoOrani.Caption = "İskonto Oranı (%)";
            this.colIskontoOrani.DisplayFormat.FormatString = "\'%\'0";
            this.colIskontoOrani.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIskontoOrani.FieldName = "IskontoOrani";
            this.colIskontoOrani.Name = "colIskontoOrani";
            this.colIskontoOrani.OptionsColumn.AllowEdit = false;
            this.colIskontoOrani.Visible = true;
            this.colIskontoOrani.VisibleIndex = 9;
            this.colIskontoOrani.Width = 57;
            // 
            // colIskontoTutar
            // 
            this.colIskontoTutar.Caption = "İskonto Tutar";
            this.colIskontoTutar.DisplayFormat.FormatString = "C2";
            this.colIskontoTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIskontoTutar.FieldName = "IskontoTutar";
            this.colIskontoTutar.Name = "colIskontoTutar";
            this.colIskontoTutar.OptionsColumn.AllowEdit = false;
            this.colIskontoTutar.Visible = true;
            this.colIskontoTutar.VisibleIndex = 10;
            this.colIskontoTutar.Width = 87;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.Caption = "Toplam Tutar";
            this.colToplamTutar.DisplayFormat.FormatString = "C2";
            this.colToplamTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colToplamTutar.FieldName = "ToplamTutar";
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.OptionsColumn.AllowEdit = false;
            this.colToplamTutar.Visible = true;
            this.colToplamTutar.VisibleIndex = 11;
            this.colToplamTutar.Width = 206;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 8;
            this.colAciklama.Width = 172;
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.dropExport);
            this.grpMenu.Controls.Add(this.btnEkle);
            this.grpMenu.Controls.Add(this.btnFaturalandir);
            this.grpMenu.Controls.Add(this.btnAra);
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Controls.Add(this.btnGuncelle);
            this.grpMenu.Controls.Add(this.btnSil);
            this.grpMenu.Controls.Add(this.btnDuzenle);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 246);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1142, 76);
            this.grpMenu.TabIndex = 1;
            this.grpMenu.Text = "Menu";
            // 
            // dropExport
            // 
            this.dropExport.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show;
            this.dropExport.Location = new System.Drawing.Point(896, 21);
            this.dropExport.Name = "dropExport";
            this.dropExport.Size = new System.Drawing.Size(135, 40);
            this.dropExport.TabIndex = 4;
            this.dropExport.Text = "Dışa Aktar";
            // 
            // btnEkle
            // 
            this.btnEkle.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show;
            this.btnEkle.DropDownControl = this.popupMenu1;
            this.btnEkle.ImageOptions.ImageIndex = 6;
            this.btnEkle.ImageOptions.ImageList = this.imgMenu;
            this.btnEkle.Location = new System.Drawing.Point(12, 23);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(93, 46);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barFaturalar, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barIadeFaturalari),
            new DevExpress.XtraBars.LinkPersistInfo(this.barKasaFisleri),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStokFisleri)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barFaturalar
            // 
            this.barFaturalar.Caption = "Faturalar";
            this.barFaturalar.Id = 17;
            this.barFaturalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barFaturalar.ImageOptions.Image")));
            this.barFaturalar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barAlisFisi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSatisFisi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barToptanSatis)});
            this.barFaturalar.Name = "barFaturalar";
            // 
            // barAlisFisi
            // 
            this.barAlisFisi.Caption = "Alış Faturası";
            this.barAlisFisi.Id = 0;
            this.barAlisFisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barAlisFisi.ImageOptions.Image")));
            this.barAlisFisi.Name = "barAlisFisi";
            this.barAlisFisi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_ItemClick);
            // 
            // barSatisFisi
            // 
            this.barSatisFisi.Caption = "Perakende Satış Faturası";
            this.barSatisFisi.Id = 1;
            this.barSatisFisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSatisFisi.ImageOptions.Image")));
            this.barSatisFisi.Name = "barSatisFisi";
            this.barSatisFisi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_ItemClick);
            // 
            // barToptanSatis
            // 
            this.barToptanSatis.Caption = "Toptan Satış Faturası";
            this.barToptanSatis.Id = 2;
            this.barToptanSatis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barToptanSatis.ImageOptions.Image")));
            this.barToptanSatis.Name = "barToptanSatis";
            this.barToptanSatis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_ItemClick);
            // 
            // barIadeFaturalari
            // 
            this.barIadeFaturalari.Caption = "İade Faturaları";
            this.barIadeFaturalari.Id = 18;
            this.barIadeFaturalari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barIadeFaturalari.ImageOptions.Image")));
            this.barIadeFaturalari.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barAlisIade),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSatisIade)});
            this.barIadeFaturalari.Name = "barIadeFaturalari";
            // 
            // barAlisIade
            // 
            this.barAlisIade.Caption = "Alış İade Faturası";
            this.barAlisIade.Id = 3;
            this.barAlisIade.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barAlisIade.ImageOptions.Image")));
            this.barAlisIade.Name = "barAlisIade";
            this.barAlisIade.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_ItemClick);
            // 
            // barSatisIade
            // 
            this.barSatisIade.Caption = "Satış İade Faturası";
            this.barSatisIade.Id = 4;
            this.barSatisIade.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSatisIade.ImageOptions.Image")));
            this.barSatisIade.Name = "barSatisIade";
            this.barSatisIade.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_ItemClick);
            // 
            // barKasaFisleri
            // 
            this.barKasaFisleri.Caption = "Kasa Fişleri";
            this.barKasaFisleri.Id = 19;
            this.barKasaFisleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barKasaFisleri.ImageOptions.Image")));
            this.barKasaFisleri.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barOdemeFisi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barTahsilatFisi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCariDevir)});
            this.barKasaFisleri.Name = "barKasaFisleri";
            // 
            // barOdemeFisi
            // 
            this.barOdemeFisi.Caption = "Ödeme Fişi";
            this.barOdemeFisi.Id = 6;
            this.barOdemeFisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barOdemeFisi.ImageOptions.Image")));
            this.barOdemeFisi.Name = "barOdemeFisi";
            this.barOdemeFisi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_ItemClick);
            // 
            // barTahsilatFisi
            // 
            this.barTahsilatFisi.Caption = "Tahsilat Fişi";
            this.barTahsilatFisi.Id = 5;
            this.barTahsilatFisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barTahsilatFisi.ImageOptions.Image")));
            this.barTahsilatFisi.Name = "barTahsilatFisi";
            this.barTahsilatFisi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_ItemClick);
            // 
            // barCariDevir
            // 
            this.barCariDevir.Caption = "Cari Devir Fişi";
            this.barCariDevir.Id = 7;
            this.barCariDevir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barCariDevir.ImageOptions.Image")));
            this.barCariDevir.Name = "barCariDevir";
            this.barCariDevir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_ItemClick);
            // 
            // barStokFisleri
            // 
            this.barStokFisleri.Caption = "Stok Fişleri";
            this.barStokFisleri.Id = 20;
            this.barStokFisleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barStokFisleri.ImageOptions.Image")));
            this.barStokFisleri.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSayimFazlasi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSayimEksigi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStokDevir)});
            this.barStokFisleri.Name = "barStokFisleri";
            // 
            // barSayimFazlasi
            // 
            this.barSayimFazlasi.Caption = "Sayım Fazlası Fişi";
            this.barSayimFazlasi.Id = 8;
            this.barSayimFazlasi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSayimFazlasi.ImageOptions.Image")));
            this.barSayimFazlasi.Name = "barSayimFazlasi";
            this.barSayimFazlasi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_ItemClick);
            // 
            // barSayimEksigi
            // 
            this.barSayimEksigi.Caption = "Sayım Eksiği Fişi";
            this.barSayimEksigi.Id = 9;
            this.barSayimEksigi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSayimEksigi.ImageOptions.Image")));
            this.barSayimEksigi.Name = "barSayimEksigi";
            this.barSayimEksigi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_ItemClick);
            // 
            // barStokDevir
            // 
            this.barStokDevir.Caption = "Stok Devir Fişi";
            this.barStokDevir.Id = 10;
            this.barStokDevir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barStokDevir.ImageOptions.Image")));
            this.barStokDevir.Name = "barStokDevir";
            this.barStokDevir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FisIslem_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barAlisFisi,
            this.barSatisFisi,
            this.barToptanSatis,
            this.barAlisIade,
            this.barSatisIade,
            this.barTahsilatFisi,
            this.barOdemeFisi,
            this.barCariDevir,
            this.barSayimFazlasi,
            this.barSayimEksigi,
            this.barStokDevir,
            this.barFaturalar,
            this.barIadeFaturalari,
            this.barKasaFisleri,
            this.barStokFisleri});
            this.barManager1.MaxItemId = 21;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1142, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 571);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1142, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 571);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1142, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 571);
            // 
            // btnFaturalandir
            // 
            this.btnFaturalandir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFaturalandir.ImageOptions.Image")));
            this.btnFaturalandir.ImageOptions.ImageIndex = 5;
            this.btnFaturalandir.Location = new System.Drawing.Point(507, 23);
            this.btnFaturalandir.Name = "btnFaturalandir";
            this.btnFaturalandir.Size = new System.Drawing.Size(104, 46);
            this.btnFaturalandir.TabIndex = 0;
            this.btnFaturalandir.Text = "Faturalandır";
            this.btnFaturalandir.Click += new System.EventHandler(this.btnFaturalandir_Click);
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.ImageIndex = 5;
            this.btnAra.ImageOptions.ImageList = this.imgMenu;
            this.btnAra.Location = new System.Drawing.Point(408, 23);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(93, 46);
            this.btnAra.TabIndex = 0;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 0;
            this.btnKapat.ImageOptions.ImageList = this.imgMenu;
            this.btnKapat.Location = new System.Drawing.Point(1037, 18);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(93, 46);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.ImageIndex = 3;
            this.btnGuncelle.ImageOptions.ImageList = this.imgMenu;
            this.btnGuncelle.Location = new System.Drawing.Point(309, 23);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(93, 46);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.ImageIndex = 7;
            this.btnSil.ImageOptions.ImageList = this.imgMenu;
            this.btnSil.Location = new System.Drawing.Point(210, 23);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(93, 46);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.ImageOptions.ImageIndex = 8;
            this.btnDuzenle.ImageOptions.ImageList = this.imgMenu;
            this.btnDuzenle.Location = new System.Drawing.Point(111, 23);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(93, 46);
            this.btnDuzenle.TabIndex = 0;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("lblBaslik.Appearance.Image")));
            this.lblBaslik.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseImage = true;
            this.lblBaslik.Appearance.Options.UseImageAlign = true;
            this.lblBaslik.Appearance.Options.UseTextOptions = true;
            this.lblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBaslik.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(1142, 52);
            this.lblBaslik.TabIndex = 3;
            this.lblBaslik.Text = "Fiş Ve Faturalar";
            // 
            // FrmFis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 571);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmFis";
            this.Text = "Fiş Ve Faturalar";
            this.Load += new System.EventHandler(this.FrmFis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridcontFisler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFisler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton btnFiltre;
        private System.Windows.Forms.ImageList imgMenu;
        private DevExpress.XtraEditors.SimpleButton btnFiltreIptal;
        private DevExpress.XtraEditors.SimpleButton btnFiltreKapat;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraGrid.GridControl gridcontFisler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridFisler;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colFisTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colCariKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colCariAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBelgeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colPlasiyerKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colPlasiyerAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colIskontoOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colIskontoTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraEditors.DropDownButton btnEkle;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barAlisFisi;
        private DevExpress.XtraBars.BarButtonItem barSatisFisi;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barToptanSatis;
        private DevExpress.XtraBars.BarButtonItem barAlisIade;
        private DevExpress.XtraBars.BarButtonItem barSatisIade;
        private DevExpress.XtraBars.BarButtonItem barTahsilatFisi;
        private DevExpress.XtraBars.BarButtonItem barOdemeFisi;
        private DevExpress.XtraBars.BarButtonItem barCariDevir;
        private DevExpress.XtraBars.BarButtonItem barSayimFazlasi;
        private DevExpress.XtraBars.BarButtonItem barSayimEksigi;
        private DevExpress.XtraBars.BarButtonItem barStokDevir;
        private DevExpress.XtraBars.BarSubItem barFaturalar;
        private DevExpress.XtraBars.BarSubItem barIadeFaturalari;
        private DevExpress.XtraBars.BarSubItem barKasaFisleri;
        private DevExpress.XtraBars.BarSubItem barStokFisleri;
        private DevExpress.XtraEditors.SimpleButton btnFaturalandir;
        private DevExpress.XtraEditors.DropDownButton dropExport;
    }
}