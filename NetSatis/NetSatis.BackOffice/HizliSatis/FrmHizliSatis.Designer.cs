namespace NetSatis.BackOffice.HizliSatis
{
    partial class FrmHizliSatis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHizliSatis));
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.grpGrupEkle = new DevExpress.XtraEditors.GroupControl();
            this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeniEkle = new DevExpress.XtraEditors.SimpleButton();
            this.grpUrunBilgi = new DevExpress.XtraEditors.GroupControl();
            this.btnSil2 = new DevExpress.XtraEditors.SimpleButton();
            this.colUrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridcontGrupEkle = new DevExpress.XtraGrid.GridControl();
            this.gridGrupEkle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridUrunEkle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridcontUrunEkle = new DevExpress.XtraGrid.GridControl();
            this.txtGrupAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.grpGrupBilgi = new DevExpress.XtraEditors.GroupControl();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpGrupEkle)).BeginInit();
            this.grpGrupEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpUrunBilgi)).BeginInit();
            this.grpUrunBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontGrupEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGrupEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontUrunEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpGrupBilgi)).BeginInit();
            this.grpGrupBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.ImageOptions.ImageIndex = 4;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(382, 25);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(93, 46);
            this.btnKapat.TabIndex = 9;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add.png");
            this.ımageList1.Images.SetKeyName(1, "delete.png");
            this.ımageList1.Images.SetKeyName(2, "floppy_disk.png");
            this.ımageList1.Images.SetKeyName(3, "floppy_disk_delete.png");
            this.ımageList1.Images.SetKeyName(4, "folder_out.png");
            this.ımageList1.Images.SetKeyName(5, "pencil.png");
            this.ımageList1.Images.SetKeyName(6, "checkbox.png");
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.ImageIndex = 0;
            this.btnEkle.ImageOptions.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(12, 27);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(93, 46);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // grpGrupEkle
            // 
            this.grpGrupEkle.Controls.Add(this.btnVazgec);
            this.grpGrupEkle.Controls.Add(this.btnKaydet);
            this.grpGrupEkle.Controls.Add(this.btnSil);
            this.grpGrupEkle.Controls.Add(this.btnYeniEkle);
            this.grpGrupEkle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpGrupEkle.Location = new System.Drawing.Point(0, 393);
            this.grpGrupEkle.Name = "grpGrupEkle";
            this.grpGrupEkle.Size = new System.Drawing.Size(425, 76);
            this.grpGrupEkle.TabIndex = 6;
            this.grpGrupEkle.Text = "Grup İşlemleri";
            // 
            // btnVazgec
            // 
            this.btnVazgec.Enabled = false;
            this.btnVazgec.ImageOptions.ImageIndex = 3;
            this.btnVazgec.ImageOptions.ImageList = this.ımageList1;
            this.btnVazgec.Location = new System.Drawing.Point(310, 27);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(93, 46);
            this.btnVazgec.TabIndex = 7;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.ImageOptions.ImageIndex = 2;
            this.btnKaydet.ImageOptions.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(211, 27);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(93, 46);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.ImageIndex = 1;
            this.btnSil.ImageOptions.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(111, 27);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(93, 46);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnYeniEkle
            // 
            this.btnYeniEkle.ImageOptions.ImageIndex = 0;
            this.btnYeniEkle.ImageOptions.ImageList = this.ımageList1;
            this.btnYeniEkle.Location = new System.Drawing.Point(12, 27);
            this.btnYeniEkle.Name = "btnYeniEkle";
            this.btnYeniEkle.Size = new System.Drawing.Size(93, 46);
            this.btnYeniEkle.TabIndex = 3;
            this.btnYeniEkle.Text = "Yeni";
            this.btnYeniEkle.Click += new System.EventHandler(this.btnYeniEkle_Click);
            // 
            // grpUrunBilgi
            // 
            this.grpUrunBilgi.Controls.Add(this.btnKapat);
            this.grpUrunBilgi.Controls.Add(this.btnSil2);
            this.grpUrunBilgi.Controls.Add(this.btnEkle);
            this.grpUrunBilgi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpUrunBilgi.Location = new System.Drawing.Point(0, 393);
            this.grpUrunBilgi.Name = "grpUrunBilgi";
            this.grpUrunBilgi.Size = new System.Drawing.Size(475, 76);
            this.grpUrunBilgi.TabIndex = 7;
            this.grpUrunBilgi.Text = "Ürün İşlemleri";
            // 
            // btnSil2
            // 
            this.btnSil2.ImageOptions.ImageIndex = 1;
            this.btnSil2.ImageOptions.ImageList = this.ımageList1;
            this.btnSil2.Location = new System.Drawing.Point(111, 27);
            this.btnSil2.Name = "btnSil2";
            this.btnSil2.Size = new System.Drawing.Size(93, 46);
            this.btnSil2.TabIndex = 5;
            this.btnSil2.Text = "Sil";
            this.btnSil2.Click += new System.EventHandler(this.btnSil2_Click);
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.Caption = "Ürün Adı";
            this.colUrunAdi.FieldName = "UrunAdi";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.OptionsColumn.AllowEdit = false;
            this.colUrunAdi.OptionsColumn.ShowInCustomizationForm = false;
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 1;
            // 
            // colBarkod
            // 
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.OptionsColumn.AllowEdit = false;
            this.colBarkod.OptionsColumn.ShowInCustomizationForm = false;
            this.colBarkod.Visible = true;
            this.colBarkod.VisibleIndex = 0;
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.Name = "colId1";
            this.colId1.OptionsColumn.AllowEdit = false;
            this.colId1.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // gridcontGrupEkle
            // 
            this.gridcontGrupEkle.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridcontGrupEkle.Location = new System.Drawing.Point(0, 101);
            this.gridcontGrupEkle.MainView = this.gridGrupEkle;
            this.gridcontGrupEkle.Name = "gridcontGrupEkle";
            this.gridcontGrupEkle.Size = new System.Drawing.Size(425, 292);
            this.gridcontGrupEkle.TabIndex = 0;
            this.gridcontGrupEkle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridGrupEkle});
            // 
            // gridGrupEkle
            // 
            this.gridGrupEkle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colGrupAdi,
            this.colAciklama});
            this.gridGrupEkle.GridControl = this.gridcontGrupEkle;
            this.gridGrupEkle.Name = "gridGrupEkle";
            this.gridGrupEkle.OptionsView.ShowGroupPanel = false;
            this.gridGrupEkle.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridGrupEkle_FocusedRowChanged);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colGrupAdi
            // 
            this.colGrupAdi.Caption = "Grup Adı";
            this.colGrupAdi.FieldName = "GrupAdi";
            this.colGrupAdi.Name = "colGrupAdi";
            this.colGrupAdi.OptionsColumn.AllowEdit = false;
            this.colGrupAdi.Visible = true;
            this.colGrupAdi.VisibleIndex = 1;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 2;
            // 
            // gridUrunEkle
            // 
            this.gridUrunEkle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId1,
            this.colBarkod,
            this.colUrunAdi});
            this.gridUrunEkle.GridControl = this.gridcontUrunEkle;
            this.gridUrunEkle.Name = "gridUrunEkle";
            this.gridUrunEkle.OptionsSelection.MultiSelect = true;
            this.gridUrunEkle.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridUrunEkle.OptionsView.ShowGroupPanel = false;
            // 
            // gridcontUrunEkle
            // 
            this.gridcontUrunEkle.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridcontUrunEkle.Location = new System.Drawing.Point(0, 0);
            this.gridcontUrunEkle.MainView = this.gridUrunEkle;
            this.gridcontUrunEkle.Name = "gridcontUrunEkle";
            this.gridcontUrunEkle.Size = new System.Drawing.Size(475, 393);
            this.gridcontUrunEkle.TabIndex = 8;
            this.gridcontUrunEkle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridUrunEkle});
            // 
            // txtGrupAdi
            // 
            this.txtGrupAdi.Location = new System.Drawing.Point(101, 28);
            this.txtGrupAdi.Name = "txtGrupAdi";
            this.txtGrupAdi.Size = new System.Drawing.Size(306, 20);
            this.txtGrupAdi.TabIndex = 10;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.labelControl7.Appearance.Options.UseBorderColor = true;
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl7.Location = new System.Drawing.Point(0, 26);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(95, 22);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "Grup Adı :";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.labelControl11.Appearance.Options.UseBorderColor = true;
            this.labelControl11.Appearance.Options.UseTextOptions = true;
            this.labelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl11.Location = new System.Drawing.Point(0, 55);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(95, 41);
            this.labelControl11.TabIndex = 9;
            this.labelControl11.Text = "Açıklama:";
            // 
            // grpGrupBilgi
            // 
            this.grpGrupBilgi.Controls.Add(this.txtAciklama);
            this.grpGrupBilgi.Controls.Add(this.txtGrupAdi);
            this.grpGrupBilgi.Controls.Add(this.labelControl7);
            this.grpGrupBilgi.Controls.Add(this.labelControl11);
            this.grpGrupBilgi.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpGrupBilgi.Enabled = false;
            this.grpGrupBilgi.Location = new System.Drawing.Point(0, 0);
            this.grpGrupBilgi.Name = "grpGrupBilgi";
            this.grpGrupBilgi.Size = new System.Drawing.Size(425, 101);
            this.grpGrupBilgi.TabIndex = 7;
            this.grpGrupBilgi.Text = "Grup Bilgileri";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(101, 54);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(306, 42);
            this.txtAciklama.TabIndex = 11;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 52);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpGrupEkle);
            this.splitContainer1.Panel1.Controls.Add(this.gridcontGrupEkle);
            this.splitContainer1.Panel1.Controls.Add(this.grpGrupBilgi);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridcontUrunEkle);
            this.splitContainer1.Panel2.Controls.Add(this.grpUrunBilgi);
            this.splitContainer1.Size = new System.Drawing.Size(904, 469);
            this.splitContainer1.SplitterDistance = 425;
            this.splitContainer1.TabIndex = 4;
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
            this.lblBaslik.Size = new System.Drawing.Size(904, 52);
            this.lblBaslik.TabIndex = 3;
            this.lblBaslik.Text = "Hızlı Satış İşlemleri";
            // 
            // FrmHizliSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 521);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHizliSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hızlı Satış";
            ((System.ComponentModel.ISupportInitialize)(this.grpGrupEkle)).EndInit();
            this.grpGrupEkle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpUrunBilgi)).EndInit();
            this.grpUrunBilgi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridcontGrupEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGrupEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontUrunEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpGrupBilgi)).EndInit();
            this.grpGrupBilgi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.GroupControl grpGrupEkle;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnYeniEkle;
        private DevExpress.XtraEditors.GroupControl grpUrunBilgi;
        private DevExpress.XtraEditors.SimpleButton btnSil2;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.GridControl gridcontGrupEkle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridGrupEkle;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Views.Grid.GridView gridUrunEkle;
        private DevExpress.XtraGrid.GridControl gridcontUrunEkle;
        private DevExpress.XtraEditors.TextEdit txtGrupAdi;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.GroupControl grpGrupBilgi;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
    }
}