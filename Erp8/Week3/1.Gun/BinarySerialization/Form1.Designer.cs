namespace BinarySerialization
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
            components = new System.ComponentModel.Container();
            txtAra = new TextBox();
            lstKisiler = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            düzenleToolStripMenuItem = new ToolStripMenuItem();
            silToolStripMenuItem = new ToolStripMenuItem();
            dtpDogumTarihi = new DateTimePicker();
            txtTelefon = new TextBox();
            email = new Label();
            txtEmail = new TextBox();
            txtTckn = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            lbl5 = new Label();
            lbl4 = new Label();
            lbl3 = new Label();
            lbl2 = new Label();
            lbl1 = new Label();
            btnKaydet = new Button();
            label1 = new Label();
            pbAvatar = new PictureBox();
            dosyaAc = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            dosyaİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            dışarıAktarToolStripMenuItem = new ToolStripMenuItem();
            içeriAktarToolStripMenuItem = new ToolStripMenuItem();
            dosyaKaydet = new SaveFileDialog();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtAra
            // 
            txtAra.ForeColor = Color.Tomato;
            txtAra.Location = new Point(227, 75);
            txtAra.Name = "txtAra";
            txtAra.PlaceholderText = "Ara";
            txtAra.Size = new Size(182, 27);
            txtAra.TabIndex = 27;
            txtAra.KeyUp += txtAra_KeyUp;
            // 
            // lstKisiler
            // 
            lstKisiler.BackColor = SystemColors.Window;
            lstKisiler.ContextMenuStrip = contextMenuStrip1;
            lstKisiler.FormattingEnabled = true;
            lstKisiler.ItemHeight = 20;
            lstKisiler.Location = new Point(229, 107);
            lstKisiler.Name = "lstKisiler";
            lstKisiler.Size = new Size(181, 304);
            lstKisiler.TabIndex = 24;
            lstKisiler.ContextMenuStripChanged += silToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { düzenleToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(131, 28);
            // 
            // düzenleToolStripMenuItem
            // 
            düzenleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { silToolStripMenuItem });
            düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            düzenleToolStripMenuItem.Size = new Size(130, 24);
            düzenleToolStripMenuItem.Text = "düzenle";
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(106, 26);
            silToolStripMenuItem.Text = "sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;
            dtpDogumTarihi.Location = new Point(113, 136);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(110, 27);
            dtpDogumTarihi.TabIndex = 16;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(113, 228);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(110, 27);
            txtTelefon.TabIndex = 22;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(61, 204);
            email.Name = "email";
            email.Size = new Size(46, 20);
            email.TabIndex = 26;
            email.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(113, 197);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(110, 27);
            txtEmail.TabIndex = 20;
            // 
            // txtTckn
            // 
            txtTckn.Location = new Point(113, 167);
            txtTckn.Name = "txtTckn";
            txtTckn.Size = new Size(110, 27);
            txtTckn.TabIndex = 18;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(113, 105);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(110, 27);
            txtSoyad.TabIndex = 14;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(113, 75);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(110, 27);
            txtAd.TabIndex = 13;
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Location = new Point(53, 231);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(58, 20);
            lbl5.TabIndex = 23;
            lbl5.Text = "Telefon";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(64, 170);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(45, 20);
            lbl4.TabIndex = 21;
            lbl4.Text = "TCKN";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(17, 143);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(98, 20);
            lbl3.TabIndex = 19;
            lbl3.Text = "Doğum Tarihi";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(64, 112);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(50, 20);
            lbl2.TabIndex = 17;
            lbl2.Text = "Soyad";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(83, 79);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(28, 20);
            lbl1.TabIndex = 15;
            lbl1.Text = "Ad";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(114, 360);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(109, 51);
            btnKaydet.TabIndex = 25;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 299);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 28;
            label1.Text = "Fotoğraf";
            // 
            // pbAvatar
            // 
            pbAvatar.Location = new Point(113, 259);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(110, 101);
            pbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAvatar.TabIndex = 29;
            pbAvatar.TabStop = false;
            pbAvatar.Click += pbAvatar_Click;
            // 
            // dosyaAc
            // 
            dosyaAc.FileName = "dosya";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dosyaİşlemleriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(626, 30);
            menuStrip1.TabIndex = 30;
            menuStrip1.Text = "menuStrip1";
            // 
            // dosyaİşlemleriToolStripMenuItem
            // 
            dosyaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            dosyaİşlemleriToolStripMenuItem.Name = "dosyaİşlemleriToolStripMenuItem";
            dosyaİşlemleriToolStripMenuItem.Size = new Size(124, 24);
            dosyaİşlemleriToolStripMenuItem.Text = "D&osya İşlemleri";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { dışarıAktarToolStripMenuItem, içeriAktarToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(224, 26);
            toolStripMenuItem1.Text = "X&ML";
            // 
            // dışarıAktarToolStripMenuItem
            // 
            dışarıAktarToolStripMenuItem.Name = "dışarıAktarToolStripMenuItem";
            dışarıAktarToolStripMenuItem.Size = new Size(169, 26);
            dışarıAktarToolStripMenuItem.Text = "Dışarı Akta&r";
            // 
            // içeriAktarToolStripMenuItem
            // 
            içeriAktarToolStripMenuItem.Name = "içeriAktarToolStripMenuItem";
            içeriAktarToolStripMenuItem.Size = new Size(169, 26);
            içeriAktarToolStripMenuItem.Text = "İçeri A&ktar";
            içeriAktarToolStripMenuItem.Click += içeriAktarToolStripMenuItem_Click;
            // 
            // dosyaKaydet
            // 
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 457);
            Controls.Add(menuStrip1);
            Controls.Add(pbAvatar);
            Controls.Add(label1);
            Controls.Add(txtAra);
            Controls.Add(lstKisiler);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(txtTelefon);
            Controls.Add(email);
            Controls.Add(txtEmail);
            Controls.Add(txtTckn);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(lbl5);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(btnKaydet);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAvatar).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAra;
        private ListBox lstKisiler;
        private DateTimePicker dtpDogumTarihi;
        private TextBox txtTelefon;
        private Label email;
        private TextBox txtEmail;
        private TextBox txtTckn;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label lbl5;
        private Label lbl4;
        private Label lbl3;
        private Label lbl2;
        private Label lbl1;
        private Button btnKaydet;
        private Label label1;
        private PictureBox pbAvatar;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem düzenleToolStripMenuItem;
        private ToolStripMenuItem silToolStripMenuItem;
        private OpenFileDialog dosyaAc;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaİşlemleriToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem dışarıAktarToolStripMenuItem;
        private ToolStripMenuItem içeriAktarToolStripMenuItem;
        private SaveFileDialog dosyaKaydet;
    }
}