namespace NetSatis.BackOffice.FiyatDegistir
{
    partial class FrmFiyatDegistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFiyatDegistir));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.imgMenu = new System.Windows.Forms.ImageList(this.components);
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.gridcontStoklar = new DevExpress.XtraGrid.GridControl();
            this.gridStoklar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFiyatTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKolonAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDegistir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryDegistir = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            this.colDegisimTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryDegisimTuru = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colDegisimYonu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryDegisimYonu = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colDegeri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryDegisimMiktari = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontStoklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStoklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDegistir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDegisimTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDegisimYonu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDegisimMiktari)).BeginInit();
            this.SuspendLayout();
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
            this.lblBaslik.Size = new System.Drawing.Size(584, 52);
            this.lblBaslik.TabIndex = 4;
            this.lblBaslik.Text = "Toplu Fiyat Değiştir";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnKaydet);
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 386);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(584, 75);
            this.grpMenu.TabIndex = 9;
            this.grpMenu.Text = "Menu";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.ImageOptions.ImageIndex = 0;
            this.btnKaydet.ImageOptions.ImageList = this.imgMenu;
            this.btnKaydet.Location = new System.Drawing.Point(380, 24);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(93, 46);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // imgMenu
            // 
            this.imgMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMenu.ImageStream")));
            this.imgMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMenu.Images.SetKeyName(0, "floppy_disk.png");
            this.imgMenu.Images.SetKeyName(1, "folder_out.png");
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 1;
            this.btnKapat.ImageOptions.ImageList = this.imgMenu;
            this.btnKapat.Location = new System.Drawing.Point(479, 24);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(93, 46);
            this.btnKapat.TabIndex = 10;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // gridcontStoklar
            // 
            this.gridcontStoklar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridcontStoklar.Location = new System.Drawing.Point(0, 52);
            this.gridcontStoklar.MainView = this.gridStoklar;
            this.gridcontStoklar.Name = "gridcontStoklar";
            this.gridcontStoklar.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryDegistir,
            this.repositoryDegisimTuru,
            this.repositoryDegisimYonu,
            this.repositoryDegisimMiktari});
            this.gridcontStoklar.Size = new System.Drawing.Size(584, 334);
            this.gridcontStoklar.TabIndex = 10;
            this.gridcontStoklar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridStoklar});
            // 
            // gridStoklar
            // 
            this.gridStoklar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFiyatTuru,
            this.colKolonAdi,
            this.colDegistir,
            this.colDegisimTuru,
            this.colDegisimYonu,
            this.colDegeri});
            this.gridStoklar.CustomizationFormBounds = new System.Drawing.Rectangle(937, 491, 260, 232);
            this.gridStoklar.GridControl = this.gridcontStoklar;
            this.gridStoklar.Name = "gridStoklar";
            this.gridStoklar.OptionsView.ShowGroupPanel = false;
            // 
            // colFiyatTuru
            // 
            this.colFiyatTuru.Caption = "Fiyat Türü";
            this.colFiyatTuru.FieldName = "FiyatTuru";
            this.colFiyatTuru.Name = "colFiyatTuru";
            this.colFiyatTuru.OptionsColumn.AllowEdit = false;
            this.colFiyatTuru.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colFiyatTuru.Visible = true;
            this.colFiyatTuru.VisibleIndex = 0;
            // 
            // colKolonAdi
            // 
            this.colKolonAdi.Caption = "Kolon Adı";
            this.colKolonAdi.FieldName = "KolonAdi";
            this.colKolonAdi.Name = "colKolonAdi";
            this.colKolonAdi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colKolonAdi.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colDegistir
            // 
            this.colDegistir.Caption = "Fiyat Değiştirilecek mi?";
            this.colDegistir.ColumnEdit = this.repositoryDegistir;
            this.colDegistir.FieldName = "Degistir";
            this.colDegistir.Name = "colDegistir";
            this.colDegistir.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDegistir.Visible = true;
            this.colDegistir.VisibleIndex = 1;
            // 
            // repositoryDegistir
            // 
            this.repositoryDegistir.AutoHeight = false;
            this.repositoryDegistir.Name = "repositoryDegistir";
            this.repositoryDegistir.OffText = "Off";
            this.repositoryDegistir.OnText = "On";
            // 
            // colDegisimTuru
            // 
            this.colDegisimTuru.Caption = "Değişim Türü";
            this.colDegisimTuru.ColumnEdit = this.repositoryDegisimTuru;
            this.colDegisimTuru.FieldName = "DegisimTuru";
            this.colDegisimTuru.Name = "colDegisimTuru";
            this.colDegisimTuru.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDegisimTuru.Visible = true;
            this.colDegisimTuru.VisibleIndex = 2;
            // 
            // repositoryDegisimTuru
            // 
            this.repositoryDegisimTuru.AutoHeight = false;
            this.repositoryDegisimTuru.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryDegisimTuru.Items.AddRange(new object[] {
            "Yüzde",
            "Tutar"});
            this.repositoryDegisimTuru.Name = "repositoryDegisimTuru";
            this.repositoryDegisimTuru.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colDegisimYonu
            // 
            this.colDegisimYonu.Caption = "Değişim Yönü";
            this.colDegisimYonu.ColumnEdit = this.repositoryDegisimYonu;
            this.colDegisimYonu.FieldName = "DegisimYonu";
            this.colDegisimYonu.Name = "colDegisimYonu";
            this.colDegisimYonu.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDegisimYonu.Visible = true;
            this.colDegisimYonu.VisibleIndex = 3;
            // 
            // repositoryDegisimYonu
            // 
            this.repositoryDegisimYonu.AutoHeight = false;
            this.repositoryDegisimYonu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryDegisimYonu.Items.AddRange(new object[] {
            "Arttır",
            "Azalt"});
            this.repositoryDegisimYonu.Name = "repositoryDegisimYonu";
            this.repositoryDegisimYonu.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colDegeri
            // 
            this.colDegeri.Caption = "Değişim Miktarı";
            this.colDegeri.ColumnEdit = this.repositoryDegisimMiktari;
            this.colDegeri.FieldName = "Degeri";
            this.colDegeri.Name = "colDegeri";
            this.colDegeri.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDegeri.Visible = true;
            this.colDegeri.VisibleIndex = 4;
            // 
            // repositoryDegisimMiktari
            // 
            this.repositoryDegisimMiktari.AutoHeight = false;
            this.repositoryDegisimMiktari.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryDegisimMiktari.DisplayFormat.FormatString = "N2";
            this.repositoryDegisimMiktari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryDegisimMiktari.Name = "repositoryDegisimMiktari";
            // 
            // FrmFiyatDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.gridcontStoklar);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFiyatDegistir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toplu Fiyat Değiştir";
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridcontStoklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStoklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDegistir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDegisimTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDegisimYonu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryDegisimMiktari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private System.Windows.Forms.ImageList imgMenu;
        private DevExpress.XtraGrid.GridControl gridcontStoklar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridStoklar;
        private DevExpress.XtraGrid.Columns.GridColumn colFiyatTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colKolonAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colDegistir;
        private DevExpress.XtraGrid.Columns.GridColumn colDegisimTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colDegisimYonu;
        private DevExpress.XtraGrid.Columns.GridColumn colDegeri;
        private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch repositoryDegistir;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryDegisimTuru;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryDegisimYonu;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryDegisimMiktari;
    }
}