namespace AkbilYonetimiUI
{
    partial class FrmAyarlar
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
            label2 = new Label();
            label3 = new Label();
            btnGuncelle = new Button();
            label4 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtSifre = new TextBox();
            dtpDogumTarihi = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 34);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 67);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 0;
            label2.Text = "İsim:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 102);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 0;
            label3.Text = "Soyisim:";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(63, 144);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(652, 47);
            btnGuncelle.TabIndex = 1;
            btnGuncelle.Text = "BİLGİLERİ GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(404, 37);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 0;
            label4.Text = "D.Tarihi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(392, 105);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 0;
            label5.Text = "Yeni Şifre:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(132, 31);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(242, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(132, 64);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(242, 27);
            txtAd.TabIndex = 2;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(132, 98);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(242, 27);
            txtSoyad.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(463, 102);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(252, 27);
            txtSifre.TabIndex = 2;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(463, 34);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(250, 27);
            dtpDogumTarihi.TabIndex = 3;
            // 
            // FrmAyarlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 325);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(txtSoyad);
            Controls.Add(txtSifre);
            Controls.Add(txtAd);
            Controls.Add(txtEmail);
            Controls.Add(btnGuncelle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "FrmAyarlar";
            Text = "FrmAyarlar";
            Load += FrmAyarlar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnGuncelle;
        private Label label4;
        private Label label5;
        private TextBox txtEmail;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtSifre;
        private DateTimePicker dtpDogumTarihi;
    }
}