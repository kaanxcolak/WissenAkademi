﻿namespace InterfaceOrnek_Odeme
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
            grpBoxOdemeSekli = new GroupBox();
            checkBoxCuzdan = new CheckBox();
            checkBoxKrediKart = new CheckBox();
            checkBoxKapi = new CheckBox();
            grpBoxOdemeTutar = new GroupBox();
            lblTutar = new Label();
            label1 = new Label();
            groupBoxKrediKarti = new GroupBox();
            txtKartSahibi = new TextBox();
            button2 = new Button();
            btnKrediKartiOde = new Button();
            txtKartCVC = new TextBox();
            label6 = new Label();
            kartSonYil = new TextBox();
            kartSonAy = new NumericUpDown();
            label5 = new Label();
            maskedtxtKartNo = new MaskedTextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtKartNo = new TextBox();
            grpBoxOdemeSekli.SuspendLayout();
            grpBoxOdemeTutar.SuspendLayout();
            groupBoxKrediKarti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kartSonAy).BeginInit();
            SuspendLayout();
            // 
            // grpBoxOdemeSekli
            // 
            grpBoxOdemeSekli.Controls.Add(checkBoxCuzdan);
            grpBoxOdemeSekli.Controls.Add(checkBoxKrediKart);
            grpBoxOdemeSekli.Controls.Add(checkBoxKapi);
            grpBoxOdemeSekli.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpBoxOdemeSekli.Location = new Point(2, 77);
            grpBoxOdemeSekli.Margin = new Padding(5);
            grpBoxOdemeSekli.Name = "grpBoxOdemeSekli";
            grpBoxOdemeSekli.Padding = new Padding(5);
            grpBoxOdemeSekli.Size = new Size(245, 475);
            grpBoxOdemeSekli.TabIndex = 0;
            grpBoxOdemeSekli.TabStop = false;
            grpBoxOdemeSekli.Text = "Ödeme Şekli Seçiniz";
            // 
            // checkBoxCuzdan
            // 
            checkBoxCuzdan.AutoSize = true;
            checkBoxCuzdan.Location = new Point(20, 144);
            checkBoxCuzdan.Name = "checkBoxCuzdan";
            checkBoxCuzdan.Size = new Size(201, 32);
            checkBoxCuzdan.TabIndex = 2;
            checkBoxCuzdan.Text = "Cüzdandan Ödeme";
            checkBoxCuzdan.UseVisualStyleBackColor = true;
            // 
            // checkBoxKrediKart
            // 
            checkBoxKrediKart.AutoSize = true;
            checkBoxKrediKart.Location = new Point(20, 101);
            checkBoxKrediKart.Margin = new Padding(5);
            checkBoxKrediKart.Name = "checkBoxKrediKart";
            checkBoxKrediKart.Size = new Size(220, 32);
            checkBoxKrediKart.TabIndex = 1;
            checkBoxKrediKart.Text = "Kredi Kartı ile Ödeme";
            checkBoxKrediKart.UseVisualStyleBackColor = true;
            checkBoxKrediKart.CheckedChanged += checkBoxKrediKart_CheckedChanged;
            // 
            // checkBoxKapi
            // 
            checkBoxKapi.AutoSize = true;
            checkBoxKapi.Location = new Point(20, 54);
            checkBoxKapi.Margin = new Padding(5);
            checkBoxKapi.Name = "checkBoxKapi";
            checkBoxKapi.Size = new Size(164, 32);
            checkBoxKapi.TabIndex = 0;
            checkBoxKapi.Text = "Kapıda Ödeme";
            checkBoxKapi.UseVisualStyleBackColor = true;
            checkBoxKapi.CheckedChanged += checkBoxKapi_CheckedChanged;
            // 
            // grpBoxOdemeTutar
            // 
            grpBoxOdemeTutar.BackColor = SystemColors.ActiveCaption;
            grpBoxOdemeTutar.Controls.Add(lblTutar);
            grpBoxOdemeTutar.Controls.Add(label1);
            grpBoxOdemeTutar.Dock = DockStyle.Top;
            grpBoxOdemeTutar.Location = new Point(0, 0);
            grpBoxOdemeTutar.Name = "grpBoxOdemeTutar";
            grpBoxOdemeTutar.Size = new Size(1105, 79);
            grpBoxOdemeTutar.TabIndex = 1;
            grpBoxOdemeTutar.TabStop = false;
            // 
            // lblTutar
            // 
            lblTutar.AutoSize = true;
            lblTutar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTutar.Location = new Point(253, 25);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(78, 38);
            lblTutar.TabIndex = 1;
            lblTutar.Text = "0 lira";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 30);
            label1.Name = "label1";
            label1.Size = new Size(180, 31);
            label1.TabIndex = 0;
            label1.Text = "Ödenecek Tutar:";
            // 
            // groupBoxKrediKarti
            // 
            groupBoxKrediKarti.Controls.Add(txtKartNo);
            groupBoxKrediKarti.Controls.Add(txtKartSahibi);
            groupBoxKrediKarti.Controls.Add(button2);
            groupBoxKrediKarti.Controls.Add(btnKrediKartiOde);
            groupBoxKrediKarti.Controls.Add(txtKartCVC);
            groupBoxKrediKarti.Controls.Add(label6);
            groupBoxKrediKarti.Controls.Add(kartSonYil);
            groupBoxKrediKarti.Controls.Add(kartSonAy);
            groupBoxKrediKarti.Controls.Add(label5);
            groupBoxKrediKarti.Controls.Add(maskedtxtKartNo);
            groupBoxKrediKarti.Controls.Add(label4);
            groupBoxKrediKarti.Controls.Add(label3);
            groupBoxKrediKarti.Controls.Add(label2);
            groupBoxKrediKarti.Enabled = false;
            groupBoxKrediKarti.Location = new Point(255, 85);
            groupBoxKrediKarti.Name = "groupBoxKrediKarti";
            groupBoxKrediKarti.Size = new Size(838, 479);
            groupBoxKrediKarti.TabIndex = 2;
            groupBoxKrediKarti.TabStop = false;
            groupBoxKrediKarti.Text = "Kartınıza Ait Bilgileri Giriniz...";
            // 
            // txtKartSahibi
            // 
            txtKartSahibi.Location = new Point(150, 30);
            txtKartSahibi.Name = "txtKartSahibi";
            txtKartSahibi.Size = new Size(433, 38);
            txtKartSahibi.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(221, 187);
            button2.Name = "button2";
            button2.Size = new Size(50, 38);
            button2.TabIndex = 11;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnKrediKartiOde
            // 
            btnKrediKartiOde.Location = new Point(599, 30);
            btnKrediKartiOde.Name = "btnKrediKartiOde";
            btnKrediKartiOde.Size = new Size(116, 314);
            btnKrediKartiOde.TabIndex = 10;
            btnKrediKartiOde.Text = "Ödeme Yap";
            btnKrediKartiOde.UseVisualStyleBackColor = true;
            // 
            // txtKartCVC
            // 
            txtKartCVC.Location = new Point(90, 187);
            txtKartCVC.Name = "txtKartCVC";
            txtKartCVC.Size = new Size(125, 38);
            txtKartCVC.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 194);
            label6.Name = "label6";
            label6.Size = new Size(60, 31);
            label6.TabIndex = 8;
            label6.Text = "CVC:";
            // 
            // kartSonYil
            // 
            kartSonYil.Location = new Point(511, 137);
            kartSonYil.Name = "kartSonYil";
            kartSonYil.Size = new Size(72, 38);
            kartSonYil.TabIndex = 7;
            // 
            // kartSonAy
            // 
            kartSonAy.Location = new Point(207, 130);
            kartSonAy.Margin = new Padding(5);
            kartSonAy.Name = "kartSonAy";
            kartSonAy.Size = new Size(92, 38);
            kartSonAy.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(316, 144);
            label5.Name = "label5";
            label5.Size = new Size(189, 31);
            label5.TabIndex = 4;
            label5.Text = "Son Kullanım Yılı:";
            // 
            // maskedtxtKartNo
            // 
            maskedtxtKartNo.Location = new Point(28, 306);
            maskedtxtKartNo.Mask = "0000 0000 0000 0000";
            maskedtxtKartNo.Name = "maskedtxtKartNo";
            maskedtxtKartNo.Size = new Size(433, 38);
            maskedtxtKartNo.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 137);
            label4.Name = "label4";
            label4.Size = new Size(184, 31);
            label4.TabIndex = 2;
            label4.Text = "Son Kullanım Ay:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 84);
            label3.Name = "label3";
            label3.Size = new Size(96, 31);
            label3.TabIndex = 1;
            label3.Text = "Kart No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 37);
            label2.Name = "label2";
            label2.Size = new Size(129, 31);
            label2.TabIndex = 0;
            label2.Text = "Kart Sahibi:";
            // 
            // txtKartNo
            // 
            txtKartNo.Location = new Point(150, 77);
            txtKartNo.Name = "txtKartNo";
            txtKartNo.Size = new Size(433, 38);
            txtKartNo.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 741);
            Controls.Add(groupBoxKrediKarti);
            Controls.Add(grpBoxOdemeTutar);
            Controls.Add(grpBoxOdemeSekli);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpBoxOdemeSekli.ResumeLayout(false);
            grpBoxOdemeSekli.PerformLayout();
            grpBoxOdemeTutar.ResumeLayout(false);
            grpBoxOdemeTutar.PerformLayout();
            groupBoxKrediKarti.ResumeLayout(false);
            groupBoxKrediKarti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kartSonAy).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxOdemeSekli;
        private CheckBox checkBoxCuzdan;
        private CheckBox checkBoxKrediKart;
        private CheckBox checkBoxKapi;
        private GroupBox grpBoxOdemeTutar;
        private Label lblTutar;
        private Label label1;
        private GroupBox groupBoxKrediKarti;
        private TextBox txtKartSahibi;
        private Button button2;
        private Button btnKrediKartiOde;
        private TextBox txtKartCVC;
        private Label label6;
        private TextBox kartSonYil;
        private NumericUpDown kartSonAy;
        private Label label5;
        private MaskedTextBox maskedtxtKartNo;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtKartNo;
    }
}