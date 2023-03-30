namespace AkbilYonetimiUI
{
    partial class FrmKayitOl
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
            label4 = new Label();
            label5 = new Label();
            txtIsim = new TextBox();
            txtSoyisim = new TextBox();
            txtEmail = new TextBox();
            txtSifre = new TextBox();
            btnKayitOl = new Button();
            btnGirisYap = new Button();
            dtpDogumTarihi = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 17);
            label1.Name = "label1";
            label1.Size = new Size(51, 28);
            label1.TabIndex = 11;
            label1.Text = "İsim:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 54);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 10;
            label2.Text = "Soyisim:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 91);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 9;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 128);
            label4.Name = "label4";
            label4.Size = new Size(55, 28);
            label4.TabIndex = 8;
            label4.Text = "Şifre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(25, 165);
            label5.Name = "label5";
            label5.Size = new Size(85, 28);
            label5.TabIndex = 7;
            label5.Text = "D. Tarihi:";
            // 
            // txtIsim
            // 
            txtIsim.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIsim.Location = new Point(115, 17);
            txtIsim.Name = "txtIsim";
            txtIsim.Size = new Size(218, 34);
            txtIsim.TabIndex = 0;
            // 
            // txtSoyisim
            // 
            txtSoyisim.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoyisim.Location = new Point(115, 54);
            txtSoyisim.Name = "txtSoyisim";
            txtSoyisim.Size = new Size(218, 34);
            txtSoyisim.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(115, 91);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(218, 34);
            txtEmail.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSifre.Location = new Point(115, 128);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(218, 34);
            txtSifre.TabIndex = 3;
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.Snow;
            btnKayitOl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKayitOl.Location = new Point(25, 210);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(308, 49);
            btnKayitOl.TabIndex = 5;
            btnKayitOl.Text = "KAYIT OL";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.Snow;
            btnGirisYap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGirisYap.Location = new Point(25, 265);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(308, 49);
            btnGirisYap.TabIndex = 6;
            btnGirisYap.Text = "GİRİŞ YAP";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(115, 165);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(218, 27);
            dtpDogumTarihi.TabIndex = 4;
            // 
            // FrmKayitOl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 419);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(btnGirisYap);
            Controls.Add(btnKayitOl);
            Controls.Add(txtSifre);
            Controls.Add(txtEmail);
            Controls.Add(txtSoyisim);
            Controls.Add(txtIsim);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmKayitOl";
            Text = "Kayıt Ol Formu";
            FormClosed += FrmKayitOl_FormClosed;
            Load += FrmKayitOl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtIsim;
        private TextBox txtSoyisim;
        private TextBox txtEmail;
        private TextBox txtSifre;
        private Button btnKayitOl;
        private Button btnGirisYap;
        private DateTimePicker dtpDogumTarihi;
    }
}