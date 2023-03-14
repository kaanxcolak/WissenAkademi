namespace CafeSoft.Forms
{
    partial class KatlarForm
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
            txtKatIsmi = new TextBox();
            txtMasaSayisi = new TextBox();
            btnKaydet = new Button();
            btnGuncelle = new Button();
            lstKatlarimiz = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 15);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Kat İsmi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 48);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 0;
            label2.Text = "Masa Sayısı";
            // 
            // txtKatIsmi
            // 
            txtKatIsmi.Location = new Point(86, 12);
            txtKatIsmi.Name = "txtKatIsmi";
            txtKatIsmi.Size = new Size(151, 23);
            txtKatIsmi.TabIndex = 1;
            // 
            // txtMasaSayisi
            // 
            txtMasaSayisi.Location = new Point(86, 45);
            txtMasaSayisi.Name = "txtMasaSayisi";
            txtMasaSayisi.Size = new Size(151, 23);
            txtMasaSayisi.TabIndex = 1;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(85, 74);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(73, 62);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(164, 74);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(73, 62);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // lstKatlarimiz
            // 
            lstKatlarimiz.FormattingEnabled = true;
            lstKatlarimiz.ItemHeight = 15;
            lstKatlarimiz.Location = new Point(255, 12);
            lstKatlarimiz.Name = "lstKatlarimiz";
            lstKatlarimiz.Size = new Size(175, 184);
            lstKatlarimiz.TabIndex = 3;
            // 
            // KatlarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 237);
            Controls.Add(lstKatlarimiz);
            Controls.Add(btnGuncelle);
            Controls.Add(btnKaydet);
            Controls.Add(txtMasaSayisi);
            Controls.Add(txtKatIsmi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "KatlarForm";
            Text = "KatlarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtKatIsmi;
        private TextBox txtMasaSayisi;
        private Button btnKaydet;
        private Button btnGuncelle;
        private ListBox lstKatlarimiz;
    }
}