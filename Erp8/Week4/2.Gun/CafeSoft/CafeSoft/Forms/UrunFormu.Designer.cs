namespace CafeSoft.Forms
{
    partial class UrunFormu
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
            components = new System.ComponentModel.Container();
            pbAvatar = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbUrunKategori = new ComboBox();
            txtUrunAd = new TextBox();
            txtUrunFiyat = new TextBox();
            lstUrunler = new ListBox();
            btnKaydet = new Button();
            btnGuncelle = new Button();
            dosyaAc = new OpenFileDialog();
            cmsSil = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).BeginInit();
            cmsSil.SuspendLayout();
            SuspendLayout();
            // 
            // pbAvatar
            // 
            pbAvatar.Location = new Point(113, 12);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(147, 125);
            pbAvatar.TabIndex = 0;
            pbAvatar.TabStop = false;
            pbAvatar.Click += pbAvatar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 158);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 1;
            label1.Text = "Ürün Kategorisi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 193);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Ürün Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 226);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 1;
            label3.Text = "Ürün Fiyatı:";
            // 
            // cmbUrunKategori
            // 
            cmbUrunKategori.FormattingEnabled = true;
            cmbUrunKategori.Location = new Point(146, 155);
            cmbUrunKategori.Name = "cmbUrunKategori";
            cmbUrunKategori.Size = new Size(151, 28);
            cmbUrunKategori.TabIndex = 2;
            // 
            // txtUrunAd
            // 
            txtUrunAd.Location = new Point(146, 187);
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.Size = new Size(151, 27);
            txtUrunAd.TabIndex = 3;
            // 
            // txtUrunFiyat
            // 
            txtUrunFiyat.Location = new Point(146, 218);
            txtUrunFiyat.Name = "txtUrunFiyat";
            txtUrunFiyat.Size = new Size(151, 27);
            txtUrunFiyat.TabIndex = 3;
            // 
            // lstUrunler
            // 
            lstUrunler.ContextMenuStrip = cmsSil;
            lstUrunler.FormattingEnabled = true;
            lstUrunler.ItemHeight = 20;
            lstUrunler.Location = new Point(316, 12);
            lstUrunler.Name = "lstUrunler";
            lstUrunler.Size = new Size(212, 284);
            lstUrunler.TabIndex = 4;
            lstUrunler.SelectedIndexChanged += lstUrunler_SelectedIndexChanged;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(18, 262);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(141, 34);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(169, 262);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(141, 34);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // dosyaAc
            // 
            dosyaAc.FileName = "openFileDialog1";
            // 
            // cmsSil
            // 
            cmsSil.ImageScalingSize = new Size(20, 20);
            cmsSil.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem });
            cmsSil.Name = "cmsSil";
            cmsSil.Size = new Size(93, 28);
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(92, 24);
            silToolStripMenuItem.Text = "sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // UrunFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 316);
            Controls.Add(btnGuncelle);
            Controls.Add(btnKaydet);
            Controls.Add(lstUrunler);
            Controls.Add(txtUrunFiyat);
            Controls.Add(txtUrunAd);
            Controls.Add(cmbUrunKategori);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbAvatar);
            Name = "UrunFormu";
            Text = "UrunFormu";
            Load += UrunFormu_Load;
            ((System.ComponentModel.ISupportInitialize)pbAvatar).EndInit();
            cmsSil.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbAvatar;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbUrunKategori;
        private TextBox txtUrunAd;
        private TextBox txtUrunFiyat;
        private ListBox lstUrunler;
        private Button btnKaydet;
        private Button btnGuncelle;
        private OpenFileDialog dosyaAc;
        private ContextMenuStrip cmsSil;
        private ToolStripMenuItem silToolStripMenuItem;
    }
}