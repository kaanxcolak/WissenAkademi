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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txtKatIsmi = new TextBox();
            txtMasaSayisi = new TextBox();
            btnKaydet = new Button();
            btnGuncelle = new Button();
            lstKatlarimiz = new ListBox();
            cmsSilIslemi = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            cmsSilIslemi.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 20);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Kat İsmi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 64);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 0;
            label2.Text = "Masa Sayısı";
            // 
            // txtKatIsmi
            // 
            txtKatIsmi.Location = new Point(98, 16);
            txtKatIsmi.Margin = new Padding(3, 4, 3, 4);
            txtKatIsmi.Name = "txtKatIsmi";
            txtKatIsmi.Size = new Size(172, 27);
            txtKatIsmi.TabIndex = 1;
            // 
            // txtMasaSayisi
            // 
            txtMasaSayisi.Location = new Point(98, 60);
            txtMasaSayisi.Margin = new Padding(3, 4, 3, 4);
            txtMasaSayisi.Name = "txtMasaSayisi";
            txtMasaSayisi.Size = new Size(172, 27);
            txtMasaSayisi.TabIndex = 1;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(97, 99);
            btnKaydet.Margin = new Padding(3, 4, 3, 4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(83, 83);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(187, 99);
            btnGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(83, 83);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // lstKatlarimiz
            // 
            lstKatlarimiz.FormattingEnabled = true;
            lstKatlarimiz.ItemHeight = 20;
            lstKatlarimiz.Location = new Point(291, 16);
            lstKatlarimiz.Margin = new Padding(3, 4, 3, 4);
            lstKatlarimiz.Name = "lstKatlarimiz";
            lstKatlarimiz.Size = new Size(199, 244);
            lstKatlarimiz.TabIndex = 3;
            lstKatlarimiz.SelectedIndexChanged += lstKatlarimiz_SelectedIndexChanged;
            // 
            // cmsSilIslemi
            // 
            cmsSilIslemi.ImageScalingSize = new Size(20, 20);
            cmsSilIslemi.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem });
            cmsSilIslemi.Name = "cmsSilIslemi";
            cmsSilIslemi.Size = new Size(211, 56);
            cmsSilIslemi.Opening += cmsSilIslemi_Opening;
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(210, 24);
            silToolStripMenuItem.Text = "Sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // KatlarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 316);
            Controls.Add(lstKatlarimiz);
            Controls.Add(btnGuncelle);
            Controls.Add(btnKaydet);
            Controls.Add(txtMasaSayisi);
            Controls.Add(txtKatIsmi);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "KatlarForm";
            Text = "KatlarForm";
            Load += KatlarForm_Load;
            cmsSilIslemi.ResumeLayout(false);
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
        private ContextMenuStrip cmsSilIslemi;
        private ToolStripMenuItem silToolStripMenuItem;
    }
}