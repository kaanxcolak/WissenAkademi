namespace InterfaceOrnek2
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
            radioBtnKare = new RadioButton();
            radioBtnDikdortgen = new RadioButton();
            grpIslemler = new GroupBox();
            lblSekilAdi = new Label();
            lblKenar1 = new Label();
            lblKenar2 = new Label();
            txtSekilAdi = new TextBox();
            txtKenar1 = new TextBox();
            txtKenar2 = new TextBox();
            btnAlanHesapla = new Button();
            btnCevreHesapla = new Button();
            grpIslemler.SuspendLayout();
            SuspendLayout();
            // 
            // radioBtnKare
            // 
            radioBtnKare.AutoSize = true;
            radioBtnKare.Location = new Point(81, 12);
            radioBtnKare.Name = "radioBtnKare";
            radioBtnKare.Size = new Size(66, 24);
            radioBtnKare.TabIndex = 0;
            radioBtnKare.TabStop = true;
            radioBtnKare.Text = "KARE";
            radioBtnKare.UseVisualStyleBackColor = true;
            // 
            // radioBtnDikdortgen
            // 
            radioBtnDikdortgen.AutoSize = true;
            radioBtnDikdortgen.Location = new Point(186, 12);
            radioBtnDikdortgen.Name = "radioBtnDikdortgen";
            radioBtnDikdortgen.Size = new Size(120, 24);
            radioBtnDikdortgen.TabIndex = 0;
            radioBtnDikdortgen.TabStop = true;
            radioBtnDikdortgen.Text = "DİKDÖRTGEN";
            radioBtnDikdortgen.UseVisualStyleBackColor = true;
            // 
            // grpIslemler
            // 
            grpIslemler.Controls.Add(btnCevreHesapla);
            grpIslemler.Controls.Add(btnAlanHesapla);
            grpIslemler.Controls.Add(txtKenar2);
            grpIslemler.Controls.Add(txtKenar1);
            grpIslemler.Controls.Add(txtSekilAdi);
            grpIslemler.Controls.Add(lblKenar2);
            grpIslemler.Controls.Add(lblKenar1);
            grpIslemler.Controls.Add(lblSekilAdi);
            grpIslemler.Location = new Point(12, 42);
            grpIslemler.Name = "grpIslemler";
            grpIslemler.Size = new Size(383, 297);
            grpIslemler.TabIndex = 1;
            grpIslemler.TabStop = false;
            grpIslemler.Text = "İŞLEM BİLGİLERİ";
            // 
            // lblSekilAdi
            // 
            lblSekilAdi.AutoSize = true;
            lblSekilAdi.Location = new Point(25, 37);
            lblSekilAdi.Name = "lblSekilAdi";
            lblSekilAdi.Size = new Size(88, 20);
            lblSekilAdi.TabIndex = 0;
            lblSekilAdi.Text = "ŞEKLİN ADI:";
            // 
            // lblKenar1
            // 
            lblKenar1.AutoSize = true;
            lblKenar1.Location = new Point(25, 64);
            lblKenar1.Name = "lblKenar1";
            lblKenar1.Size = new Size(56, 20);
            lblKenar1.TabIndex = 1;
            lblKenar1.Text = "KENAR";
            // 
            // lblKenar2
            // 
            lblKenar2.AutoSize = true;
            lblKenar2.Location = new Point(25, 98);
            lblKenar2.Name = "lblKenar2";
            lblKenar2.Size = new Size(56, 20);
            lblKenar2.TabIndex = 1;
            lblKenar2.Text = "KENAR";
            lblKenar2.Click += label3_Click;
            // 
            // txtSekilAdi
            // 
            txtSekilAdi.Location = new Point(122, 30);
            txtSekilAdi.Name = "txtSekilAdi";
            txtSekilAdi.Size = new Size(172, 27);
            txtSekilAdi.TabIndex = 2;
            // 
            // txtKenar1
            // 
            txtKenar1.Location = new Point(122, 61);
            txtKenar1.Name = "txtKenar1";
            txtKenar1.Size = new Size(172, 27);
            txtKenar1.TabIndex = 2;
            // 
            // txtKenar2
            // 
            txtKenar2.Location = new Point(122, 94);
            txtKenar2.Name = "txtKenar2";
            txtKenar2.Size = new Size(172, 27);
            txtKenar2.TabIndex = 2;
            // 
            // btnAlanHesapla
            // 
            btnAlanHesapla.Location = new Point(25, 127);
            btnAlanHesapla.Name = "btnAlanHesapla";
            btnAlanHesapla.Size = new Size(225, 29);
            btnAlanHesapla.TabIndex = 3;
            btnAlanHesapla.Text = "ALAN HESAPLA";
            btnAlanHesapla.UseVisualStyleBackColor = true;
            // 
            // btnCevreHesapla
            // 
            btnCevreHesapla.Location = new Point(25, 162);
            btnCevreHesapla.Name = "btnCevreHesapla";
            btnCevreHesapla.Size = new Size(225, 29);
            btnCevreHesapla.TabIndex = 3;
            btnCevreHesapla.Text = "ÇEVRE HESAPLA";
            btnCevreHesapla.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 411);
            Controls.Add(grpIslemler);
            Controls.Add(radioBtnDikdortgen);
            Controls.Add(radioBtnKare);
            Name = "Form1";
            Text = "Form1";
            grpIslemler.ResumeLayout(false);
            grpIslemler.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioBtnKare;
        private RadioButton radioBtnDikdortgen;
        private GroupBox grpIslemler;
        private Button btnCevreHesapla;
        private Button btnAlanHesapla;
        private TextBox txtKenar2;
        private TextBox txtKenar1;
        private TextBox txtSekilAdi;
        private Label lblKenar2;
        private Label lblKenar1;
        private Label lblSekilAdi;
    }
}