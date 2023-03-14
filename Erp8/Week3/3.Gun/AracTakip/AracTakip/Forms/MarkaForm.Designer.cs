namespace AracTakip.Forms
{
    partial class MarkaForm
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
            label1 = new Label();
            txtAd = new TextBox();
            pbResim = new PictureBox();
            lstListe = new ListBox();
            btnKaydet = new Button();
            btnGuncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)pbResim).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Marka Adı";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(83, 20);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(150, 23);
            txtAd.TabIndex = 1;
            // 
            // pbResim
            // 
            pbResim.Location = new Point(83, 49);
            pbResim.Name = "pbResim";
            pbResim.Size = new Size(150, 117);
            pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
            pbResim.TabIndex = 2;
            pbResim.TabStop = false;
            pbResim.Click += pbResim_Click;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 15;
            lstListe.Location = new Point(249, 20);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(186, 349);
            lstListe.TabIndex = 3;
            lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(83, 172);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(69, 43);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(158, 172);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 43);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // MarkaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 410);
            Controls.Add(btnGuncelle);
            Controls.Add(btnKaydet);
            Controls.Add(lstListe);
            Controls.Add(pbResim);
            Controls.Add(txtAd);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MarkaForm";
            Text = "MarkaForm";
            Load += MarkaForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbResim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAd;
        private PictureBox pbResim;
        private ListBox lstListe;
        private Button btnKaydet;
        private Button btnGuncelle;
    }
}