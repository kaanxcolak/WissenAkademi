namespace AkbilYonetimiUI
{
    partial class FrmGiris
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
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtSifre = new TextBox();
            checkBoxHatirla = new CheckBox();
            btnKayitOl = new Button();
            btnGirisYap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 13);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 64);
            label2.Name = "label2";
            label2.Size = new Size(55, 28);
            label2.TabIndex = 0;
            label2.Text = "Şifre:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(89, 7);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(237, 34);
            txtEmail.TabIndex = 1;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSifre.Location = new Point(89, 61);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(237, 34);
            txtSifre.TabIndex = 1;
            txtSifre.KeyPress += txtSifre_KeyPress;
            // 
            // checkBoxHatirla
            // 
            checkBoxHatirla.AutoSize = true;
            checkBoxHatirla.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxHatirla.Location = new Point(89, 101);
            checkBoxHatirla.Name = "checkBoxHatirla";
            checkBoxHatirla.Size = new Size(134, 32);
            checkBoxHatirla.TabIndex = 2;
            checkBoxHatirla.Text = "Beni Hatırla";
            checkBoxHatirla.UseVisualStyleBackColor = true;
            checkBoxHatirla.CheckedChanged += checkBoxHatirla_CheckedChanged;
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.White;
            btnKayitOl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKayitOl.Location = new Point(13, 195);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(313, 50);
            btnKayitOl.TabIndex = 3;
            btnKayitOl.Text = "KAYIT OL";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.White;
            btnGirisYap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGirisYap.Location = new Point(12, 139);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(314, 50);
            btnGirisYap.TabIndex = 3;
            btnGirisYap.Text = "GİRİŞ YAP";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // FrmGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.galata_kulesi;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(717, 342);
            Controls.Add(btnGirisYap);
            Controls.Add(btnKayitOl);
            Controls.Add(checkBoxHatirla);
            Controls.Add(txtSifre);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmGiris";
            Text = "HOŞGELDİNİZ...";
            Load += FrmGiris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtSifre;
        private CheckBox checkBoxHatirla;
        private Button btnKayitOl;
        private Button btnGirisYap;
    }
}