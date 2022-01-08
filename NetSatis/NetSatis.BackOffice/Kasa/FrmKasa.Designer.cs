namespace NetSatis.BackOffice.Kasa
{
    partial class FrmKasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKasa));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnFiltre = new DevExpress.XtraEditors.SimpleButton();
            this.imgMenu = new System.Windows.Forms.ImageList(this.components);
            this.btnFiltreIptal = new DevExpress.XtraEditors.SimpleButton();
            this.btnFiltreKapat = new DevExpress.XtraEditors.SimpleButton();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.gridcontKasalar = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colId = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colId = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colKasaKodu = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colKasaKodu = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colKasaAdi = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colKasaAdi = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colYetkiliKodu = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colYetkiliKodu = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colYetkiliAdi = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colYetkiliAdi = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colAciklama = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colAciklama = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colKasaGiris = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colKasaGiris = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colKasaCikis = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colKasaCikis = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colBakiye = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colBakiye = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnKasaHareket = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontKasalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaKodu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colYetkiliKodu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colYetkiliAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colAciklama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaGiris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaCikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colBakiye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
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
            this.splitContainerControl1.Panel2.Controls.Add(this.gridcontKasalar);
            this.splitContainerControl1.Panel2.Controls.Add(this.grpMenu);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1142, 519);
            this.splitContainerControl1.SplitterPosition = 159;
            this.splitContainerControl1.TabIndex = 4;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // btnFiltre
            // 
            this.btnFiltre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltre.ImageOptions.ImageIndex = 0;
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
            this.imgMenu.Images.SetKeyName(0, "funnel.png");
            this.imgMenu.Images.SetKeyName(1, "funnel_delete.png");
            this.imgMenu.Images.SetKeyName(2, "KasaDuzenle.png");
            this.imgMenu.Images.SetKeyName(3, "KasaEkle.png");
            this.imgMenu.Images.SetKeyName(4, "KasaHareket.png");
            this.imgMenu.Images.SetKeyName(5, "KasaSil.png");
            this.imgMenu.Images.SetKeyName(6, "pencil.png");
            this.imgMenu.Images.SetKeyName(7, "refresh.png");
            this.imgMenu.Images.SetKeyName(8, "replace2.png");
            this.imgMenu.Images.SetKeyName(9, "view.png");
            this.imgMenu.Images.SetKeyName(10, "folder_out.png");
            // 
            // btnFiltreIptal
            // 
            this.btnFiltreIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltreIptal.ImageOptions.ImageIndex = 1;
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
            this.btnFiltreKapat.ImageOptions.ImageIndex = 10;
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
            this.filterControl1.Size = new System.Drawing.Size(1142, 159);
            this.filterControl1.SortFilterColumns = false;
            this.filterControl1.SourceControl = this.gridcontKasalar;
            this.filterControl1.TabIndex = 0;
            this.filterControl1.Text = "filterControl1";
            // 
            // gridcontKasalar
            // 
            this.gridcontKasalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridcontKasalar.Location = new System.Drawing.Point(0, 0);
            this.gridcontKasalar.MainView = this.layoutView1;
            this.gridcontKasalar.Name = "gridcontKasalar";
            this.gridcontKasalar.Size = new System.Drawing.Size(1142, 279);
            this.gridcontKasalar.TabIndex = 2;
            this.gridcontKasalar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // layoutView1
            // 
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colId,
            this.colKasaKodu,
            this.colKasaAdi,
            this.colYetkiliKodu,
            this.colYetkiliAdi,
            this.colAciklama,
            this.colKasaGiris,
            this.colKasaCikis,
            this.colBakiye});
            this.layoutView1.GridControl = this.gridcontKasalar;
            this.layoutView1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colId});
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.LayoutViewField = this.layoutViewField_colId;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // layoutViewField_colId
            // 
            this.layoutViewField_colId.EditorPreferredWidth = 137;
            this.layoutViewField_colId.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colId.Name = "layoutViewField_colId";
            this.layoutViewField_colId.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colId.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colKasaKodu
            // 
            this.colKasaKodu.Caption = "Kasa Kodu";
            this.colKasaKodu.FieldName = "KasaKodu";
            this.colKasaKodu.LayoutViewField = this.layoutViewField_colKasaKodu;
            this.colKasaKodu.Name = "colKasaKodu";
            this.colKasaKodu.OptionsColumn.AllowEdit = false;
            this.colKasaKodu.OptionsColumn.ShowInCustomizationForm = false;
            this.colKasaKodu.Width = 68;
            // 
            // layoutViewField_colKasaKodu
            // 
            this.layoutViewField_colKasaKodu.EditorPreferredWidth = 137;
            this.layoutViewField_colKasaKodu.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colKasaKodu.Name = "layoutViewField_colKasaKodu";
            this.layoutViewField_colKasaKodu.Size = new System.Drawing.Size(203, 48);
            this.layoutViewField_colKasaKodu.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colKasaAdi
            // 
            this.colKasaAdi.Caption = "Kasa Adı";
            this.colKasaAdi.FieldName = "KasaAdi";
            this.colKasaAdi.LayoutViewField = this.layoutViewField_colKasaAdi;
            this.colKasaAdi.Name = "colKasaAdi";
            this.colKasaAdi.OptionsColumn.AllowEdit = false;
            this.colKasaAdi.OptionsColumn.ShowInCustomizationForm = false;
            this.colKasaAdi.Width = 189;
            // 
            // layoutViewField_colKasaAdi
            // 
            this.layoutViewField_colKasaAdi.EditorPreferredWidth = 137;
            this.layoutViewField_colKasaAdi.Location = new System.Drawing.Point(0, 48);
            this.layoutViewField_colKasaAdi.Name = "layoutViewField_colKasaAdi";
            this.layoutViewField_colKasaAdi.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colKasaAdi.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colYetkiliKodu
            // 
            this.colYetkiliKodu.Caption = "Yetkili Kodu";
            this.colYetkiliKodu.FieldName = "YetkiliKodu";
            this.colYetkiliKodu.LayoutViewField = this.layoutViewField_colYetkiliKodu;
            this.colYetkiliKodu.Name = "colYetkiliKodu";
            this.colYetkiliKodu.OptionsColumn.AllowEdit = false;
            this.colYetkiliKodu.OptionsColumn.ShowInCustomizationForm = false;
            this.colYetkiliKodu.Width = 84;
            // 
            // layoutViewField_colYetkiliKodu
            // 
            this.layoutViewField_colYetkiliKodu.EditorPreferredWidth = 137;
            this.layoutViewField_colYetkiliKodu.Location = new System.Drawing.Point(0, 72);
            this.layoutViewField_colYetkiliKodu.Name = "layoutViewField_colYetkiliKodu";
            this.layoutViewField_colYetkiliKodu.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colYetkiliKodu.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colYetkiliAdi
            // 
            this.colYetkiliAdi.Caption = "Yetkili Adı";
            this.colYetkiliAdi.FieldName = "YetkiliAdi";
            this.colYetkiliAdi.LayoutViewField = this.layoutViewField_colYetkiliAdi;
            this.colYetkiliAdi.Name = "colYetkiliAdi";
            this.colYetkiliAdi.OptionsColumn.AllowEdit = false;
            this.colYetkiliAdi.OptionsColumn.ShowInCustomizationForm = false;
            this.colYetkiliAdi.Width = 190;
            // 
            // layoutViewField_colYetkiliAdi
            // 
            this.layoutViewField_colYetkiliAdi.EditorPreferredWidth = 137;
            this.layoutViewField_colYetkiliAdi.Location = new System.Drawing.Point(0, 96);
            this.layoutViewField_colYetkiliAdi.Name = "layoutViewField_colYetkiliAdi";
            this.layoutViewField_colYetkiliAdi.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colYetkiliAdi.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.LayoutViewField = this.layoutViewField_colAciklama;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.OptionsColumn.ShowInCustomizationForm = false;
            this.colAciklama.Width = 300;
            // 
            // layoutViewField_colAciklama
            // 
            this.layoutViewField_colAciklama.EditorPreferredWidth = 137;
            this.layoutViewField_colAciklama.Location = new System.Drawing.Point(0, 120);
            this.layoutViewField_colAciklama.Name = "layoutViewField_colAciklama";
            this.layoutViewField_colAciklama.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colAciklama.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colKasaGiris
            // 
            this.colKasaGiris.Caption = "Kasa Giriş";
            this.colKasaGiris.DisplayFormat.FormatString = "C2";
            this.colKasaGiris.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKasaGiris.FieldName = "KasaGiris";
            this.colKasaGiris.LayoutViewField = this.layoutViewField_colKasaGiris;
            this.colKasaGiris.Name = "colKasaGiris";
            this.colKasaGiris.Width = 96;
            // 
            // layoutViewField_colKasaGiris
            // 
            this.layoutViewField_colKasaGiris.EditorPreferredWidth = 137;
            this.layoutViewField_colKasaGiris.Location = new System.Drawing.Point(0, 144);
            this.layoutViewField_colKasaGiris.Name = "layoutViewField_colKasaGiris";
            this.layoutViewField_colKasaGiris.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colKasaGiris.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colKasaCikis
            // 
            this.colKasaCikis.Caption = "Kasa Çıkış";
            this.colKasaCikis.DisplayFormat.FormatString = "C2";
            this.colKasaCikis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKasaCikis.FieldName = "KasaCikis";
            this.colKasaCikis.LayoutViewField = this.layoutViewField_colKasaCikis;
            this.colKasaCikis.Name = "colKasaCikis";
            this.colKasaCikis.Width = 96;
            // 
            // layoutViewField_colKasaCikis
            // 
            this.layoutViewField_colKasaCikis.EditorPreferredWidth = 137;
            this.layoutViewField_colKasaCikis.Location = new System.Drawing.Point(0, 168);
            this.layoutViewField_colKasaCikis.Name = "layoutViewField_colKasaCikis";
            this.layoutViewField_colKasaCikis.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colKasaCikis.TextSize = new System.Drawing.Size(58, 13);
            // 
            // colBakiye
            // 
            this.colBakiye.Caption = "Bakiye";
            this.colBakiye.DisplayFormat.FormatString = "C2";
            this.colBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBakiye.FieldName = "Bakiye";
            this.colBakiye.LayoutViewField = this.layoutViewField_colBakiye;
            this.colBakiye.Name = "colBakiye";
            this.colBakiye.Width = 101;
            // 
            // layoutViewField_colBakiye
            // 
            this.layoutViewField_colBakiye.EditorPreferredWidth = 137;
            this.layoutViewField_colBakiye.Location = new System.Drawing.Point(0, 192);
            this.layoutViewField_colBakiye.Name = "layoutViewField_colBakiye";
            this.layoutViewField_colBakiye.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colBakiye.TextSize = new System.Drawing.Size(58, 13);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colKasaKodu,
            this.layoutViewField_colKasaAdi,
            this.layoutViewField_colYetkiliKodu,
            this.layoutViewField_colYetkiliAdi,
            this.layoutViewField_colAciklama,
            this.layoutViewField_colKasaGiris,
            this.layoutViewField_colKasaCikis,
            this.layoutViewField_colBakiye});
            this.layoutViewCard1.Name = "layoutViewCard1";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnAra);
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Controls.Add(this.btnKasaHareket);
            this.grpMenu.Controls.Add(this.btnGuncelle);
            this.grpMenu.Controls.Add(this.btnSil);
            this.grpMenu.Controls.Add(this.btnDuzenle);
            this.grpMenu.Controls.Add(this.btnEkle);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 279);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1142, 76);
            this.grpMenu.TabIndex = 1;
            this.grpMenu.Text = "Menu";
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.ImageIndex = 9;
            this.btnAra.ImageOptions.ImageList = this.imgMenu;
            this.btnAra.Location = new System.Drawing.Point(514, 23);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(93, 46);
            this.btnAra.TabIndex = 0;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 10;
            this.btnKapat.ImageOptions.ImageList = this.imgMenu;
            this.btnKapat.Location = new System.Drawing.Point(1037, 18);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(93, 46);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKasaHareket
            // 
            this.btnKasaHareket.ImageOptions.ImageIndex = 4;
            this.btnKasaHareket.ImageOptions.ImageList = this.imgMenu;
            this.btnKasaHareket.Location = new System.Drawing.Point(309, 25);
            this.btnKasaHareket.Name = "btnKasaHareket";
            this.btnKasaHareket.Size = new System.Drawing.Size(100, 46);
            this.btnKasaHareket.TabIndex = 0;
            this.btnKasaHareket.Text = "Kasa\r\nHareket";
            this.btnKasaHareket.Click += new System.EventHandler(this.btnKasaHareket_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.ImageIndex = 7;
            this.btnGuncelle.ImageOptions.ImageList = this.imgMenu;
            this.btnGuncelle.Location = new System.Drawing.Point(415, 25);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(93, 46);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.ImageIndex = 5;
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
            this.btnDuzenle.ImageOptions.ImageIndex = 2;
            this.btnDuzenle.ImageOptions.ImageList = this.imgMenu;
            this.btnDuzenle.Location = new System.Drawing.Point(111, 23);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(93, 46);
            this.btnDuzenle.TabIndex = 0;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.ImageIndex = 3;
            this.btnEkle.ImageOptions.ImageList = this.imgMenu;
            this.btnEkle.Location = new System.Drawing.Point(12, 23);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(93, 46);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
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
            this.lblBaslik.Text = "Kasalar";
            // 
            // FrmKasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 571);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.lblBaslik);
            this.Name = "FrmKasa";
            this.Text = "Kasalar";
            this.Load += new System.EventHandler(this.FrmKasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridcontKasalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaKodu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colYetkiliKodu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colYetkiliAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colAciklama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaGiris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colKasaCikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colBakiye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton btnFiltre;
        private System.Windows.Forms.ImageList imgMenu;
        private DevExpress.XtraEditors.SimpleButton btnFiltreIptal;
        private DevExpress.XtraEditors.SimpleButton btnFiltreKapat;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraGrid.GridControl gridcontKasalar;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKasaHareket;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colId;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colId;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colKasaKodu;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colKasaKodu;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colKasaAdi;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colKasaAdi;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colYetkiliKodu;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colYetkiliKodu;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colYetkiliAdi;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colYetkiliAdi;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colAciklama;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colAciklama;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colKasaGiris;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colKasaGiris;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colKasaCikis;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colKasaCikis;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colBakiye;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colBakiye;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}