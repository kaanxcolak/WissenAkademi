namespace AracTakipUygulaması
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
            label1 = new Label();
            label2 = new Label();
            txtMarka = new TextBox();
            txtModel = new TextBox();
            txtYakitTipi = new TextBox();
            txtSase = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtMotorHacmi = new TextBox();
            txtVitesTipi = new TextBox();
            pbAvatar = new PictureBox();
            btnEkle = new Button();
            txtAra = new TextBox();
            lstAraclar = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            düzenleToolStripMenuItem = new ToolStripMenuItem();
            silToolStripMenuItem = new ToolStripMenuItem();
            txtModelYili = new TextBox();
            label8 = new Label();
            dosyaAc = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            dosyaİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            araçListesiToolStripMenuItem = new ToolStripMenuItem();
            dışarıAktarToolStripMenuItem = new ToolStripMenuItem();
            içeriAktarToolStripMenuItem = new ToolStripMenuItem();
            dosyaKaydet = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).BeginInit();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 31);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Marka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 58);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "Model";
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(131, 28);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(100, 23);
            txtMarka.TabIndex = 2;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(131, 56);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(100, 23);
            txtModel.TabIndex = 3;
            // 
            // txtYakitTipi
            // 
            txtYakitTipi.Location = new Point(131, 140);
            txtYakitTipi.Name = "txtYakitTipi";
            txtYakitTipi.Size = new Size(100, 23);
            txtYakitTipi.TabIndex = 7;
            // 
            // txtSase
            // 
            txtSase.Location = new Point(131, 112);
            txtSase.Name = "txtSase";
            txtSase.Size = new Size(100, 23);
            txtSase.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 142);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 5;
            label3.Text = "Yakıt Tipi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 115);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 4;
            label4.Text = "Şase No";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 259);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 10;
            label5.Text = "Araç Fotoğraf";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 199);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 9;
            label6.Text = "Motor Hacmi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(71, 170);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 8;
            label7.Text = "Vites Tipi";
            // 
            // txtMotorHacmi
            // 
            txtMotorHacmi.Location = new Point(131, 196);
            txtMotorHacmi.Name = "txtMotorHacmi";
            txtMotorHacmi.Size = new Size(100, 23);
            txtMotorHacmi.TabIndex = 12;
            // 
            // txtVitesTipi
            // 
            txtVitesTipi.Location = new Point(131, 167);
            txtVitesTipi.Name = "txtVitesTipi";
            txtVitesTipi.Size = new Size(100, 23);
            txtVitesTipi.TabIndex = 11;
            // 
            // pbAvatar
            // 
            pbAvatar.Location = new Point(131, 241);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(100, 50);
            pbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAvatar.TabIndex = 13;
            pbAvatar.TabStop = false;
            pbAvatar.Click += pbAvatar_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(131, 308);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(100, 64);
            btnEkle.TabIndex = 14;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtAra
            // 
            txtAra.Location = new Point(251, 28);
            txtAra.Name = "txtAra";
            txtAra.PlaceholderText = "Ara";
            txtAra.Size = new Size(294, 23);
            txtAra.TabIndex = 15;
            txtAra.KeyUp += txtAra_KeyUp;
            // 
            // lstAraclar
            // 
            lstAraclar.ContextMenuStrip = contextMenuStrip1;
            lstAraclar.FormattingEnabled = true;
            lstAraclar.ItemHeight = 15;
            lstAraclar.Location = new Point(251, 54);
            lstAraclar.Name = "lstAraclar";
            lstAraclar.Size = new Size(294, 319);
            lstAraclar.TabIndex = 17;
            lstAraclar.SelectedIndexChanged += lstAraclar_SelectedIndexChanged;
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
            silToolStripMenuItem.Size = new Size(85, 22);
            silToolStripMenuItem.Text = "sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // txtModelYili
            // 
            txtModelYili.Location = new Point(131, 83);
            txtModelYili.Name = "txtModelYili";
            txtModelYili.Size = new Size(100, 23);
            txtModelYili.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(65, 86);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 18;
            label8.Text = "Model Yılı";
            // 
            // dosyaAc
            // 
            dosyaAc.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dosyaİşlemleriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(616, 24);
            menuStrip1.TabIndex = 20;
            menuStrip1.Text = "menuStrip1";
            // 
            // dosyaİşlemleriToolStripMenuItem
            // 
            dosyaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { araçListesiToolStripMenuItem });
            dosyaİşlemleriToolStripMenuItem.Name = "dosyaİşlemleriToolStripMenuItem";
            dosyaİşlemleriToolStripMenuItem.Size = new Size(98, 20);
            dosyaİşlemleriToolStripMenuItem.Text = "Dosya İşlemleri";
            // 
            // araçListesiToolStripMenuItem
            // 
            araçListesiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dışarıAktarToolStripMenuItem, içeriAktarToolStripMenuItem });
            araçListesiToolStripMenuItem.Name = "araçListesiToolStripMenuItem";
            araçListesiToolStripMenuItem.Size = new Size(133, 22);
            araçListesiToolStripMenuItem.Text = "Araç Listesi";
            // 
            // dışarıAktarToolStripMenuItem
            // 
            dışarıAktarToolStripMenuItem.Name = "dışarıAktarToolStripMenuItem";
            dışarıAktarToolStripMenuItem.Size = new Size(134, 22);
            dışarıAktarToolStripMenuItem.Text = "Dışarı Aktar";
            dışarıAktarToolStripMenuItem.Click += dışarıAktarToolStripMenuItem_Click;
            // 
            // içeriAktarToolStripMenuItem
            // 
            içeriAktarToolStripMenuItem.Name = "içeriAktarToolStripMenuItem";
            içeriAktarToolStripMenuItem.Size = new Size(134, 22);
            içeriAktarToolStripMenuItem.Text = "İçeri Aktar";
            içeriAktarToolStripMenuItem.Click += içeriAktarToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 383);
            Controls.Add(txtModelYili);
            Controls.Add(label8);
            Controls.Add(lstAraclar);
            Controls.Add(txtAra);
            Controls.Add(btnEkle);
            Controls.Add(pbAvatar);
            Controls.Add(txtMotorHacmi);
            Controls.Add(txtVitesTipi);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtYakitTipi);
            Controls.Add(txtSase);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtModel);
            Controls.Add(txtMarka);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Araç Takip Uygulaması";
            ((System.ComponentModel.ISupportInitialize)pbAvatar).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMarka;
        private TextBox txtModel;
        private TextBox txtYakitTipi;
        private TextBox txtSase;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtMotorHacmi;
        private TextBox txtVitesTipi;
        private PictureBox pbAvatar;
        private Button btnEkle;
        private TextBox txtModelAra;
        private TextBox txtAra;
        private ListBox lstAraclar;
        private TextBox txtModelYili;
        private Label label8;
        private OpenFileDialog dosyaAc;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaİşlemleriToolStripMenuItem;
        private ToolStripMenuItem araçListesiToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem düzenleToolStripMenuItem;
        private ToolStripMenuItem silToolStripMenuItem;
        private SaveFileDialog dosyaKaydet;
        private ToolStripMenuItem dışarıAktarToolStripMenuItem;
        private ToolStripMenuItem içeriAktarToolStripMenuItem;
    }
}