﻿namespace AkbilYonetimiUI
{
    partial class FrmAkbiller
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
            menuStrip1 = new MenuStrip();
            anaSayfaToolStripMenuItem = new ToolStripMenuItem();
            çIKIŞYAPToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            btnKaydet = new Button();
            cmbBoxAkbilTipleri = new ComboBox();
            maskedTextBoxAkbilNo = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridViewAkbiller = new DataGridView();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAkbiller).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { anaSayfaToolStripMenuItem, çIKIŞYAPToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(622, 36);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // anaSayfaToolStripMenuItem
            // 
            anaSayfaToolStripMenuItem.Name = "anaSayfaToolStripMenuItem";
            anaSayfaToolStripMenuItem.Size = new Size(128, 32);
            anaSayfaToolStripMenuItem.Text = "ANASAYFA";
            // 
            // çIKIŞYAPToolStripMenuItem
            // 
            çIKIŞYAPToolStripMenuItem.Name = "çIKIŞYAPToolStripMenuItem";
            çIKIŞYAPToolStripMenuItem.Size = new Size(116, 32);
            çIKIŞYAPToolStripMenuItem.Text = "ÇIKIŞ YAP";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(cmbBoxAkbilTipleri);
            groupBox1.Controls.Add(maskedTextBoxAkbilNo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(36, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(536, 152);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = SystemColors.Control;
            btnKaydet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.Location = new Point(379, 24);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(111, 98);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "YENİ AKBİL KAYDET";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // cmbBoxAkbilTipleri
            // 
            cmbBoxAkbilTipleri.FormattingEnabled = true;
            cmbBoxAkbilTipleri.Items.AddRange(new object[] { "Öğrenci Akbili", "Tam Akbili", "Anne Kartı", "65+ Kartı", "Öğretmen Kart" });
            cmbBoxAkbilTipleri.Location = new Point(93, 74);
            cmbBoxAkbilTipleri.Name = "cmbBoxAkbilTipleri";
            cmbBoxAkbilTipleri.Size = new Size(268, 28);
            cmbBoxAkbilTipleri.TabIndex = 2;
            // 
            // maskedTextBoxAkbilNo
            // 
            maskedTextBoxAkbilNo.Location = new Point(93, 41);
            maskedTextBoxAkbilNo.Mask = "0000000000000000";
            maskedTextBoxAkbilNo.Name = "maskedTextBoxAkbilNo";
            maskedTextBoxAkbilNo.Size = new Size(268, 27);
            maskedTextBoxAkbilNo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 0;
            label2.Text = "Akbil Tipi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Akbil No:";
            // 
            // dataGridViewAkbiller
            // 
            dataGridViewAkbiller.AllowUserToAddRows = false;
            dataGridViewAkbiller.AllowUserToDeleteRows = false;
            dataGridViewAkbiller.AllowUserToOrderColumns = true;
            dataGridViewAkbiller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAkbiller.Location = new Point(36, 223);
            dataGridViewAkbiller.Name = "dataGridViewAkbiller";
            dataGridViewAkbiller.ReadOnly = true;
            dataGridViewAkbiller.RowHeadersWidth = 51;
            dataGridViewAkbiller.RowTemplate.Height = 29;
            dataGridViewAkbiller.Size = new Size(536, 189);
            dataGridViewAkbiller.TabIndex = 4;
            // 
            // FrmAkbiller
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 448);
            Controls.Add(dataGridViewAkbiller);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmAkbiller";
            Text = "FrmAkbiller";
            Load += FrmAkbiller_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAkbiller).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem anaSayfaToolStripMenuItem;
        private ToolStripMenuItem çIKIŞYAPToolStripMenuItem;
        private GroupBox groupBox1;
        private Button btnKaydet;
        private ComboBox cmbBoxAkbilTipleri;
        private MaskedTextBox maskedTextBoxAkbilNo;
        private Label label2;
        private Label label1;
        private DataGridView dataGridViewAkbiller;
    }
}