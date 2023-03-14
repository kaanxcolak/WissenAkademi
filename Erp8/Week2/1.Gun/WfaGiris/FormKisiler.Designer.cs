namespace WfaGiris
{
    partial class FormKisiler
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
            btnKaydet = new Button();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            lbl5 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtTckn = new TextBox();
            txtEmail = new TextBox();
            email = new Label();
            txtTelefon = new TextBox();
            dtpDogumTarihi = new DateTimePicker();
            lstKisiler = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            düzenleToolStripMenuItem = new ToolStripMenuItem();
            silToolStripMenuItem = new ToolStripMenuItem();
            txtAra = new TextBox();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(97, 178);
            btnKaydet.Margin = new Padding(3, 2, 3, 2);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(109, 50);
            btnKaydet.TabIndex = 7;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(67, 18);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(22, 15);
            lbl1.TabIndex = 1;
            lbl1.Text = "Ad";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(48, 46);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(39, 15);
            lbl2.TabIndex = 2;
            lbl2.Text = "Soyad";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(6, 74);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(78, 15);
            lbl3.TabIndex = 3;
            lbl3.Text = "Doğum Tarihi";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(52, 101);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(36, 15);
            lbl4.TabIndex = 4;
            lbl4.Text = "TCKN";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Location = new Point(41, 154);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(45, 15);
            lbl5.TabIndex = 5;
            lbl5.Text = "Telefon";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(97, 15);
            txtAd.Margin = new Padding(3, 2, 3, 2);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(110, 23);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(97, 43);
            txtSoyad.Margin = new Padding(3, 2, 3, 2);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(110, 23);
            txtSoyad.TabIndex = 1;
            // 
            // txtTckn
            // 
            txtTckn.Location = new Point(97, 98);
            txtTckn.Margin = new Padding(3, 2, 3, 2);
            txtTckn.Name = "txtTckn";
            txtTckn.Size = new Size(110, 23);
            txtTckn.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(97, 126);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(110, 23);
            txtEmail.TabIndex = 4;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(52, 129);
            email.Name = "email";
            email.Size = new Size(36, 15);
            email.TabIndex = 11;
            email.Text = "Email";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(97, 154);
            txtTelefon.Margin = new Padding(3, 2, 3, 2);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(110, 23);
            txtTelefon.TabIndex = 5;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;
            dtpDogumTarihi.Location = new Point(97, 70);
            dtpDogumTarihi.Margin = new Padding(3, 2, 3, 2);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(110, 23);
            dtpDogumTarihi.TabIndex = 2;
            // 
            // lstKisiler
            // 
            lstKisiler.BackColor = SystemColors.Window;
            lstKisiler.ContextMenuStrip = contextMenuStrip1;
            lstKisiler.FormattingEnabled = true;
            lstKisiler.ItemHeight = 15;
            lstKisiler.Location = new Point(212, 45);
            lstKisiler.Margin = new Padding(3, 2, 3, 2);
            lstKisiler.Name = "lstKisiler";
            lstKisiler.Size = new Size(182, 184);
            lstKisiler.TabIndex = 6;
            lstKisiler.SelectedIndexChanged += lstKisiler_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { düzenleToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(116, 26);
            // 
            // düzenleToolStripMenuItem
            // 
            düzenleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { silToolStripMenuItem });
            düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            düzenleToolStripMenuItem.Size = new Size(115, 22);
            düzenleToolStripMenuItem.Text = "düzenle";
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(180, 22);
            silToolStripMenuItem.Text = "sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // txtAra
            // 
            txtAra.ForeColor = Color.Tomato;
            txtAra.Location = new Point(212, 15);
            txtAra.Name = "txtAra";
            txtAra.PlaceholderText = "Ara";
            txtAra.Size = new Size(182, 23);
            txtAra.TabIndex = 12;
            txtAra.KeyUp += txtAra_KeyUp;
            // 
            // FormKisiler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 324);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormKisiler";
            Text = "FormKisiler";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKaydet;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lbl4;
        private Label lbl5;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtTckn;
        private TextBox txtEmail;
        private Label email;
        private TextBox txtTelefon;
        private DateTimePicker dtpDogumTarihi;
        private ListBox lstKisiler;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem düzenleToolStripMenuItem;
        private ToolStripMenuItem silToolStripMenuItem;
        private TextBox txtAra;
    }
}