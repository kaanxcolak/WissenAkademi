namespace Kronometre
{
    partial class Form1
    {
        /// <sum
        /// 
        
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
            lblEkran = new Label();
            btnBaslatDurdur = new Button();
            btnSifirla = new Button();
            tmr1 = new System.Windows.Forms.Timer(components);
            pbKalanSure = new ProgressBar();
            cbGeriSayim = new CheckBox();
            gbKontrol = new GroupBox();
            cmbSaniye = new ComboBox();
            cmbDakika = new ComboBox();
            cmbSaat = new ComboBox();
            gbKontrol.SuspendLayout();
            SuspendLayout();
            // 
            // lblEkran
            // 
            lblEkran.AutoSize = true;
            lblEkran.Font = new Font("Consolas", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblEkran.Location = new Point(33, 175);
            lblEkran.Margin = new Padding(4, 0, 4, 0);
            lblEkran.Name = "lblEkran";
            lblEkran.Size = new Size(159, 36);
            lblEkran.TabIndex = 0;
            lblEkran.Text = "00:00:000";
            // 
            // btnBaslatDurdur
            // 
            btnBaslatDurdur.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBaslatDurdur.Location = new Point(241, 168);
            btnBaslatDurdur.Margin = new Padding(4);
            btnBaslatDurdur.Name = "btnBaslatDurdur";
            btnBaslatDurdur.Size = new Size(122, 50);
            btnBaslatDurdur.TabIndex = 1;
            btnBaslatDurdur.Text = "Başlat";
            btnBaslatDurdur.UseVisualStyleBackColor = true;
            btnBaslatDurdur.Click += btnBaslatDurdur_Click;
            // 
            // btnSifirla
            // 
            btnSifirla.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSifirla.Location = new Point(382, 168);
            btnSifirla.Margin = new Padding(4);
            btnSifirla.Name = "btnSifirla";
            btnSifirla.Size = new Size(132, 50);
            btnSifirla.TabIndex = 2;
            btnSifirla.Text = "Sıfırla";
            btnSifirla.UseVisualStyleBackColor = true;
            btnSifirla.Click += btnSifirla_Click;
            // 
            // tmr1
            // 
            tmr1.Tick += tmr1_Tick;
            // 
            // pbKalanSure
            // 
            pbKalanSure.Location = new Point(33, 237);
            pbKalanSure.Name = "pbKalanSure";
            pbKalanSure.Size = new Size(488, 43);
            pbKalanSure.Style = ProgressBarStyle.Continuous;
            pbKalanSure.TabIndex = 3;
            pbKalanSure.Click += progressBar1_Click;
            // 
            // cbGeriSayim
            // 
            cbGeriSayim.AutoSize = true;
            cbGeriSayim.Location = new Point(9, 12);
            cbGeriSayim.Name = "cbGeriSayim";
            cbGeriSayim.RightToLeft = RightToLeft.Yes;
            cbGeriSayim.Size = new Size(147, 22);
            cbGeriSayim.TabIndex = 4;
            cbGeriSayim.Text = "Geri Sayım Modu";
            cbGeriSayim.UseVisualStyleBackColor = true;
            cbGeriSayim.CheckedChanged += cbGeriSayim_CheckedChanged;
            // 
            // gbKontrol
            // 
            gbKontrol.Controls.Add(cmbSaniye);
            gbKontrol.Controls.Add(cmbDakika);
            gbKontrol.Controls.Add(cmbSaat);
            gbKontrol.Location = new Point(224, 0);
            gbKontrol.Name = "gbKontrol";
            gbKontrol.Size = new Size(297, 134);
            gbKontrol.TabIndex = 5;
            gbKontrol.TabStop = false;
            gbKontrol.Text = "Geri Sayım Kontrolleri";
            gbKontrol.Visible = false;
            // 
            // cmbSaniye
            // 
            cmbSaniye.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSaniye.FormattingEnabled = true;
            cmbSaniye.Location = new Point(210, 28);
            cmbSaniye.Name = "cmbSaniye";
            cmbSaniye.Size = new Size(80, 26);
            cmbSaniye.TabIndex = 2;
            // 
            // cmbDakika
            // 
            cmbDakika.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDakika.FormattingEnabled = true;
            cmbDakika.Location = new Point(105, 28);
            cmbDakika.Name = "cmbDakika";
            cmbDakika.Size = new Size(80, 26);
            cmbDakika.TabIndex = 1;
            // 
            // cmbSaat
            // 
            cmbSaat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSaat.FormattingEnabled = true;
            cmbSaat.Location = new Point(0, 28);
            cmbSaat.Name = "cmbSaat";
            cmbSaat.Size = new Size(80, 26);
            cmbSaat.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 350);
            Controls.Add(gbKontrol);
            Controls.Add(cbGeriSayim);
            Controls.Add(pbKalanSure);
            Controls.Add(btnSifirla);
            Controls.Add(btnBaslatDurdur);
            Controls.Add(lblEkran);
            Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbKontrol.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEkran;
        private Button btnBaslatDurdur;
        private Button btnSifirla;
        private System.Windows.Forms.Timer tmr1;
        private ProgressBar pbKalanSure;
        private CheckBox cbGeriSayim;
        private GroupBox gbKontrol;
        private ComboBox cmbSaniye;
        private ComboBox cmbDakika;
        private ComboBox cmbSaat;
    }
}