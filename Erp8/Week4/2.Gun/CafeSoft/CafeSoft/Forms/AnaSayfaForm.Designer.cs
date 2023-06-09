﻿namespace CafeSoft.Forms
{
    partial class AnaSayfaForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            flpKatlar = new FlowLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            flpMasalar = new FlowLayoutPanel();
            flpKategoriler = new FlowLayoutPanel();
            flpUrunler = new FlowLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            flpLabels = new FlowLayoutPanel();
            flpNuds = new FlowLayoutPanel();
            flpToplamFiyat = new FlowLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            label1 = new Label();
            lblToplam = new Label();
            btnGunlukRapor = new Button();
            btnHesapAl = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.9211826F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.07882F));
            tableLayoutPanel1.Controls.Add(flpKatlar, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(1349, 728);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flpKatlar
            // 
            flpKatlar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpKatlar.Dock = DockStyle.Fill;
            flpKatlar.FlowDirection = FlowDirection.TopDown;
            flpKatlar.Location = new Point(3, 4);
            flpKatlar.Margin = new Padding(3, 4, 3, 4);
            flpKatlar.Name = "flpKatlar";
            flpKatlar.Size = new Size(289, 720);
            flpKatlar.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.3694267F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.6305733F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(298, 4);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.Size = new Size(1048, 720);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel3.Controls.Add(flpMasalar, 0, 0);
            tableLayoutPanel3.Controls.Add(flpKategoriler, 0, 1);
            tableLayoutPanel3.Controls.Add(flpUrunler, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 4);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 63F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 37F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 235F));
            tableLayoutPanel3.Size = new Size(584, 712);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // flpMasalar
            // 
            flpMasalar.Dock = DockStyle.Fill;
            flpMasalar.Location = new Point(3, 4);
            flpMasalar.Margin = new Padding(3, 4, 3, 4);
            flpMasalar.Name = "flpMasalar";
            flpMasalar.Size = new Size(578, 292);
            flpMasalar.TabIndex = 0;
            // 
            // flpKategoriler
            // 
            flpKategoriler.Dock = DockStyle.Fill;
            flpKategoriler.Location = new Point(3, 304);
            flpKategoriler.Margin = new Padding(3, 4, 3, 4);
            flpKategoriler.Name = "flpKategoriler";
            flpKategoriler.Size = new Size(578, 168);
            flpKategoriler.TabIndex = 1;
            // 
            // flpUrunler
            // 
            flpUrunler.Dock = DockStyle.Fill;
            flpUrunler.Location = new Point(3, 480);
            flpUrunler.Margin = new Padding(3, 4, 3, 4);
            flpUrunler.Name = "flpUrunler";
            flpUrunler.Size = new Size(578, 228);
            flpUrunler.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(593, 4);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(452, 712);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 104F));
            tableLayoutPanel5.Controls.Add(flpLabels, 0, 0);
            tableLayoutPanel5.Controls.Add(flpNuds, 1, 0);
            tableLayoutPanel5.Controls.Add(flpToplamFiyat, 2, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 4);
            tableLayoutPanel5.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 299F));
            tableLayoutPanel5.Size = new Size(446, 348);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // flpLabels
            // 
            flpLabels.Dock = DockStyle.Fill;
            flpLabels.FlowDirection = FlowDirection.TopDown;
            flpLabels.Location = new Point(3, 3);
            flpLabels.Name = "flpLabels";
            flpLabels.Size = new Size(165, 342);
            flpLabels.TabIndex = 0;
            flpLabels.Paint += flpLabels_Paint;
            // 
            // flpNuds
            // 
            flpNuds.Dock = DockStyle.Fill;
            flpNuds.FlowDirection = FlowDirection.TopDown;
            flpNuds.Location = new Point(174, 3);
            flpNuds.Name = "flpNuds";
            flpNuds.Size = new Size(165, 342);
            flpNuds.TabIndex = 1;
            // 
            // flpToplamFiyat
            // 
            flpToplamFiyat.Dock = DockStyle.Fill;
            flpToplamFiyat.Location = new Point(345, 3);
            flpToplamFiyat.Name = "flpToplamFiyat";
            flpToplamFiyat.Size = new Size(98, 342);
            flpToplamFiyat.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.3493958F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.6506042F));
            tableLayoutPanel6.Controls.Add(label1, 0, 0);
            tableLayoutPanel6.Controls.Add(lblToplam, 1, 0);
            tableLayoutPanel6.Controls.Add(btnGunlukRapor, 0, 1);
            tableLayoutPanel6.Controls.Add(btnHesapAl, 1, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 360);
            tableLayoutPanel6.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 14.0468225F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 85.95318F));
            tableLayoutPanel6.Size = new Size(446, 348);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(160, 24);
            label1.TabIndex = 1;
            label1.Text = "Toplam:";
            // 
            // lblToplam
            // 
            lblToplam.AutoSize = true;
            lblToplam.Dock = DockStyle.Top;
            lblToplam.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplam.Location = new Point(169, 0);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(274, 24);
            lblToplam.TabIndex = 2;
            lblToplam.Text = "0";
            // 
            // btnGunlukRapor
            // 
            btnGunlukRapor.Location = new Point(3, 51);
            btnGunlukRapor.Name = "btnGunlukRapor";
            btnGunlukRapor.Size = new Size(117, 48);
            btnGunlukRapor.TabIndex = 3;
            btnGunlukRapor.Text = "Günlük Rapor";
            btnGunlukRapor.UseVisualStyleBackColor = true;
            btnGunlukRapor.Click += btnGunlukRapor_Click;
            // 
            // btnHesapAl
            // 
            btnHesapAl.Location = new Point(169, 51);
            btnHesapAl.Name = "btnHesapAl";
            btnHesapAl.Size = new Size(114, 48);
            btnHesapAl.TabIndex = 4;
            btnHesapAl.Text = "Hesap Al";
            btnHesapAl.UseVisualStyleBackColor = true;
            btnHesapAl.Click += btnHesapAl_Click;
            // 
            // AnaSayfaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 728);
            Controls.Add(tableLayoutPanel1);
            Name = "AnaSayfaForm";
            Text = "AnaSayfaForm";
            Load += AnaSayfaForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flpKatlar;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private FlowLayoutPanel flpMasalar;
        private FlowLayoutPanel flpKategoriler;
        private FlowLayoutPanel flpUrunler;
        private Label label1;
        private Label lblToplam;
        private Button btnGunlukRapor;
        private Button btnHesapAl;
        private FlowLayoutPanel flpLabels;
        private FlowLayoutPanel flpNuds;
        private FlowLayoutPanel flpToplamFiyat;
    }
}