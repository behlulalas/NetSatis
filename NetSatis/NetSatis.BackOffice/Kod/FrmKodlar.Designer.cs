namespace NetSatis.BackOffice.Kod
{
    partial class FrmKodlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKodlar));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.gridTanimlar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOnEki = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSonDeger = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositorySil = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridcontTanimlar = new DevExpress.XtraGrid.GridControl();
            this.dropExport = new DevExpress.XtraEditors.DropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTanimlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorySil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontTanimlar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.ImageOptions.ImageIndex = 4;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(606, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(93, 46);
            this.btnKapat.TabIndex = 8;
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
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.ImageIndex = 2;
            this.btnKaydet.ImageOptions.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(507, 23);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(93, 46);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.dropExport);
            this.grpMenu.Controls.Add(this.btnKapat);
            this.grpMenu.Controls.Add(this.btnKaydet);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 373);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(707, 76);
            this.grpMenu.TabIndex = 8;
            this.grpMenu.Text = "Menu";
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
            this.lblBaslik.Size = new System.Drawing.Size(707, 52);
            this.lblBaslik.TabIndex = 7;
            this.lblBaslik.Text = "Kod Oluşturucu";
            // 
            // gridTanimlar
            // 
            this.gridTanimlar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colOnEki,
            this.colSonDeger,
            this.colSil});
            this.gridTanimlar.GridControl = this.gridcontTanimlar;
            this.gridTanimlar.Name = "gridTanimlar";
            this.gridTanimlar.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridTanimlar.OptionsView.ShowGroupPanel = false;
            this.gridTanimlar.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridTanimlar_ShowingEditor);
            this.gridTanimlar.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridTanimlar_ValidateRow);
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colOnEki
            // 
            this.colOnEki.Caption = "Ön Eki";
            this.colOnEki.FieldName = "OnEki";
            this.colOnEki.Name = "colOnEki";
            this.colOnEki.OptionsColumn.ShowInCustomizationForm = false;
            this.colOnEki.Visible = true;
            this.colOnEki.VisibleIndex = 0;
            this.colOnEki.Width = 229;
            // 
            // colSonDeger
            // 
            this.colSonDeger.Caption = "Son Değer";
            this.colSonDeger.FieldName = "SonDeger";
            this.colSonDeger.Name = "colSonDeger";
            this.colSonDeger.Visible = true;
            this.colSonDeger.VisibleIndex = 1;
            this.colSonDeger.Width = 423;
            // 
            // colSil
            // 
            this.colSil.Caption = "Sil";
            this.colSil.ColumnEdit = this.repositorySil;
            this.colSil.Name = "colSil";
            this.colSil.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colSil.Visible = true;
            this.colSil.VisibleIndex = 2;
            this.colSil.Width = 37;
            // 
            // repositorySil
            // 
            this.repositorySil.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repositorySil.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositorySil.Name = "repositorySil";
            this.repositorySil.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositorySil.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositorySil_ButtonClick);
            // 
            // gridcontTanimlar
            // 
            this.gridcontTanimlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridcontTanimlar.Location = new System.Drawing.Point(0, 52);
            this.gridcontTanimlar.MainView = this.gridTanimlar;
            this.gridcontTanimlar.Name = "gridcontTanimlar";
            this.gridcontTanimlar.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositorySil});
            this.gridcontTanimlar.Size = new System.Drawing.Size(707, 321);
            this.gridcontTanimlar.TabIndex = 9;
            this.gridcontTanimlar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridTanimlar});
            // 
            // dropExport
            // 
            this.dropExport.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show;
            this.dropExport.Location = new System.Drawing.Point(12, 26);
            this.dropExport.Name = "dropExport";
            this.dropExport.Size = new System.Drawing.Size(135, 40);
            this.dropExport.TabIndex = 9;
            this.dropExport.Text = "Dışa Aktar";
            // 
            // FrmKodlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 449);
            this.Controls.Add(this.gridcontTanimlar);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKodlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kodlar";
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTanimlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorySil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontTanimlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraGrid.Views.Grid.GridView gridTanimlar;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colOnEki;
        private DevExpress.XtraGrid.GridControl gridcontTanimlar;
        private DevExpress.XtraGrid.Columns.GridColumn colSonDeger;
        private DevExpress.XtraGrid.Columns.GridColumn colSil;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositorySil;
        private DevExpress.XtraEditors.DropDownButton dropExport;
    }
}