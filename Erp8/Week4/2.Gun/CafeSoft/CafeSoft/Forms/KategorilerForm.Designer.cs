﻿namespace CafeSoft.Forms
{
    partial class KategorilerForm
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
            txtKategoriAd = new TextBox();
            btnGuncelle = new Button();
            btnKaydet = new Button();
            lstKategori = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 15);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Kategori Adı: ";
            // 
            // txtKategoriAd
            // 
            txtKategoriAd.Location = new Point(111, 12);
            txtKategoriAd.Name = "txtKategoriAd";
            txtKategoriAd.Size = new Size(174, 27);
            txtKategoriAd.TabIndex = 1;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(201, 45);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(84, 66);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(111, 45);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(84, 66);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lstKategori
            // 
            lstKategori.FormattingEnabled = true;
            lstKategori.ItemHeight = 20;
            lstKategori.Location = new Point(304, 12);
            lstKategori.Name = "lstKategori";
            lstKategori.Size = new Size(239, 244);
            lstKategori.TabIndex = 3;
            // 
            // KategorilerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 290);
            Controls.Add(lstKategori);
            Controls.Add(btnKaydet);
            Controls.Add(btnGuncelle);
            Controls.Add(txtKategoriAd);
            Controls.Add(label1);
            Name = "KategorilerForm";
            Text = "KategorilerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKategoriAd;
        private Button btnGuncelle;
        private Button btnKaydet;
        private ListBox lstKategori;
    }
}