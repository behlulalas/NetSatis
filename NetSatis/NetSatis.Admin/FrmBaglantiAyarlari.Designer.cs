namespace NetSatis.Admin
{
    partial class FrmBaglantiAyarlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaglantiAyarlari));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.chkWindows = new DevExpress.XtraEditors.CheckButton();
            this.chkSqlServer = new DevExpress.XtraEditors.CheckButton();
            this.txtServer = new DevExpress.XtraEditors.TextEdit();
            this.txtParola = new DevExpress.XtraEditors.TextEdit();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnTestEt = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(406, 52);
            this.lblBaslik.TabIndex = 5;
            this.lblBaslik.Text = "Bağlantı Ayarları";
            // 
            // chkWindows
            // 
            this.chkWindows.Checked = true;
            this.chkWindows.GroupIndex = 1;
            this.chkWindows.Location = new System.Drawing.Point(45, 58);
            this.chkWindows.Name = "chkWindows";
            this.chkWindows.Size = new System.Drawing.Size(110, 105);
            this.chkWindows.TabIndex = 6;
            this.chkWindows.Text = "Windows Auth";
            // 
            // chkSqlServer
            // 
            this.chkSqlServer.GroupIndex = 1;
            this.chkSqlServer.Location = new System.Drawing.Point(210, 58);
            this.chkSqlServer.Name = "chkSqlServer";
            this.chkSqlServer.Size = new System.Drawing.Size(110, 105);
            this.chkSqlServer.TabIndex = 6;
            this.chkSqlServer.TabStop = false;
            this.chkSqlServer.Text = "Sql Server Login";
            this.chkSqlServer.CheckedChanged += new System.EventHandler(this.chkSqlServer_CheckedChanged);
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(17, 171);
            this.txtServer.Name = "txtServer";
            this.txtServer.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtServer.Properties.ContextImageOptions.Image")));
            this.txtServer.Properties.NullValuePrompt = "Server Adı";
            this.txtServer.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtServer.Size = new System.Drawing.Size(373, 36);
            this.txtServer.TabIndex = 0;
            // 
            // txtParola
            // 
            this.txtParola.Enabled = false;
            this.txtParola.Location = new System.Drawing.Point(17, 256);
            this.txtParola.Name = "txtParola";
            this.txtParola.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtParola.Properties.ContextImageOptions.Image")));
            this.txtParola.Properties.NullValuePrompt = "Şifre";
            this.txtParola.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtParola.Size = new System.Drawing.Size(373, 36);
            this.txtParola.TabIndex = 3;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Enabled = false;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(17, 214);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtKullaniciAdi.Properties.ContextImageOptions.Image")));
            this.txtKullaniciAdi.Properties.NullValuePrompt = "Kullanıcı Adı";
            this.txtKullaniciAdi.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtKullaniciAdi.Size = new System.Drawing.Size(373, 36);
            this.txtKullaniciAdi.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(232, 310);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(120, 45);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnTestEt
            // 
            this.btnTestEt.Location = new System.Drawing.Point(36, 310);
            this.btnTestEt.Name = "btnTestEt";
            this.btnTestEt.Size = new System.Drawing.Size(120, 45);
            this.btnTestEt.TabIndex = 4;
            this.btnTestEt.Text = "Bağlantıyı Test Et";
            this.btnTestEt.Click += new System.EventHandler(this.btnTestEt_Click);
            // 
            // FrmBaglantiAyarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 362);
            this.Controls.Add(this.btnTestEt);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.chkSqlServer);
            this.Controls.Add(this.chkWindows);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBaglantiAyarlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bağlantı Ayarları";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBaglantiAyarlari_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.CheckButton chkWindows;
        private DevExpress.XtraEditors.CheckButton chkSqlServer;
        private DevExpress.XtraEditors.TextEdit txtServer;
        private DevExpress.XtraEditors.TextEdit txtParola;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnTestEt;
    }
}