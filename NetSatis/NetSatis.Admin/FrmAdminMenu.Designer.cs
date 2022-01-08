namespace NetSatis.Admin
{
    partial class FrmAdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminMenu));
            this.btnKullanicilar = new DevExpress.XtraEditors.SimpleButton();
            this.btnDevirSihirbazi = new DevExpress.XtraEditors.SimpleButton();
            this.btnDonemOlustur = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btnKullanicilar
            // 
            this.btnKullanicilar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullanicilar.Appearance.Options.UseFont = true;
            this.btnKullanicilar.ImageOptions.ImageIndex = 1;
            this.btnKullanicilar.ImageOptions.ImageList = this.ımageList1;
            this.btnKullanicilar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnKullanicilar.Location = new System.Drawing.Point(9, 12);
            this.btnKullanicilar.Name = "btnKullanicilar";
            this.btnKullanicilar.Size = new System.Drawing.Size(185, 162);
            this.btnKullanicilar.TabIndex = 0;
            this.btnKullanicilar.Text = "Kullanıcılar";
            this.btnKullanicilar.Click += new System.EventHandler(this.btnKullanicilar_Click);
            // 
            // btnDevirSihirbazi
            // 
            this.btnDevirSihirbazi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDevirSihirbazi.Appearance.Options.UseFont = true;
            this.btnDevirSihirbazi.ImageOptions.ImageIndex = 2;
            this.btnDevirSihirbazi.ImageOptions.ImageList = this.ımageList1;
            this.btnDevirSihirbazi.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnDevirSihirbazi.Location = new System.Drawing.Point(391, 12);
            this.btnDevirSihirbazi.Name = "btnDevirSihirbazi";
            this.btnDevirSihirbazi.Size = new System.Drawing.Size(185, 162);
            this.btnDevirSihirbazi.TabIndex = 0;
            this.btnDevirSihirbazi.Text = "Devir Sihirbazı";
            this.btnDevirSihirbazi.Click += new System.EventHandler(this.btnDevirSihirbazi_Click);
            // 
            // btnDonemOlustur
            // 
            this.btnDonemOlustur.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDonemOlustur.Appearance.Options.UseFont = true;
            this.btnDonemOlustur.ImageOptions.ImageIndex = 0;
            this.btnDonemOlustur.ImageOptions.ImageList = this.ımageList1;
            this.btnDonemOlustur.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnDonemOlustur.Location = new System.Drawing.Point(200, 12);
            this.btnDonemOlustur.Name = "btnDonemOlustur";
            this.btnDonemOlustur.Size = new System.Drawing.Size(185, 162);
            this.btnDonemOlustur.TabIndex = 0;
            this.btnDonemOlustur.Text = "Dönem Oluştur";
            this.btnDonemOlustur.Click += new System.EventHandler(this.btnDonemOlustur_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add (1).png");
            this.ımageList1.Images.SetKeyName(1, "profile.png");
            this.ımageList1.Images.SetKeyName(2, "select.png");
            // 
            // FrmAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 182);
            this.Controls.Add(this.btnDonemOlustur);
            this.Controls.Add(this.btnDevirSihirbazi);
            this.Controls.Add(this.btnKullanicilar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Paneli";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnKullanicilar;
        private DevExpress.XtraEditors.SimpleButton btnDevirSihirbazi;
        private DevExpress.XtraEditors.SimpleButton btnDonemOlustur;
        private System.Windows.Forms.ImageList ımageList1;
    }
}