namespace WfaGiris
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnGiris = new Button();
            cbFalan = new CheckBox();
            dtpDogumTarihi = new DateTimePicker();
            lstKisiler = new ListBox();
            pbProfilFoto = new PictureBox();
            lblKullaniciAdi = new Label();
            txtKullaniciAdi = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbProfilFoto).BeginInit();
            SuspendLayout();
            // 
            // btnGiris
            // 
            btnGiris.BackColor = SystemColors.MenuHighlight;
            btnGiris.Font = new Font("Snap ITC", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnGiris.Location = new Point(3, 2);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(152, 70);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = false;
            
            // 
            // cbFalan
            // 
            cbFalan.AutoSize = true;
            cbFalan.Location = new Point(3, 78);
            cbFalan.Name = "cbFalan";
            cbFalan.Size = new Size(65, 24);
            cbFalan.TabIndex = 3;
            cbFalan.Text = "Falan";
            cbFalan.UseVisualStyleBackColor = true;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(3, 117);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(250, 27);
            dtpDogumTarihi.TabIndex = 2;
            // 
            // lstKisiler
            // 
            lstKisiler.FormattingEnabled = true;
            lstKisiler.ItemHeight = 20;
            lstKisiler.Location = new Point(3, 160);
            lstKisiler.Name = "lstKisiler";
            lstKisiler.Size = new Size(150, 104);
            lstKisiler.TabIndex = 1;
            // 
            // pbProfilFoto
            // 
            pbProfilFoto.Image = (Image)resources.GetObject("pbProfilFoto.Image");
            pbProfilFoto.Location = new Point(3, 279);
            pbProfilFoto.Name = "pbProfilFoto";
            pbProfilFoto.Size = new Size(191, 192);
            pbProfilFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProfilFoto.TabIndex = 4;
            pbProfilFoto.TabStop = false;
            pbProfilFoto.Click += pictureBox1_Click;
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(174, 7);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(92, 20);
            lblKullaniciAdi.TabIndex = 5;
            lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(272, 4);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(125, 27);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 496);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(pbProfilFoto);
            Controls.Add(lstKisiler);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(cbFalan);
            Controls.Add(btnGiris);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbProfilFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGiris;
        private CheckBox cbFalan;
        private DateTimePicker dtpDogumTarihi;
        private ListBox lstKisiler;
        private PictureBox pbProfilFoto;
        private Label lblKullaniciAdi;
        private TextBox txtKullaniciAdi;
    }
}