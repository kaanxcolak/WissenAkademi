namespace InterfaceOrnek_Odeme
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
            checkBoxKapi = new CheckBox();
            checkBoxKrediKart = new CheckBox();
            checkBoxCüzdan = new CheckBox();
            grpBoxOdemeTutar = new GroupBox();
            label1 = new Label();
            lblTutar = new Label();
            grpBoxOdemeSekli.SuspendLayout();
            grpBoxOdemeTutar.SuspendLayout();
            SuspendLayout();
            // 
            // grpBoxOdemeSekli
            // 
            grpBoxOdemeSekli.Controls.Add(checkBoxCüzdan);
            grpBoxOdemeSekli.Controls.Add(checkBoxKrediKart);
            grpBoxOdemeSekli.Controls.Add(checkBoxKapi);
            grpBoxOdemeSekli.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpBoxOdemeSekli.Location = new Point(2, 77);
            grpBoxOdemeSekli.Margin = new Padding(5, 5, 5, 5);
            grpBoxOdemeSekli.Name = "grpBoxOdemeSekli";
            grpBoxOdemeSekli.Padding = new Padding(5, 5, 5, 5);
            grpBoxOdemeSekli.Size = new Size(315, 479);
            grpBoxOdemeSekli.TabIndex = 0;
            grpBoxOdemeSekli.TabStop = false;
            grpBoxOdemeSekli.Text = "Ödeme Şekli Seçiniz";
            // 
            // checkBoxKapi
            // 
            checkBoxKapi.AutoSize = true;
            checkBoxKapi.Location = new Point(20, 54);
            checkBoxKapi.Margin = new Padding(5, 5, 5, 5);
            checkBoxKapi.Name = "checkBoxKapi";
            checkBoxKapi.Size = new Size(164, 32);
            checkBoxKapi.TabIndex = 0;
            checkBoxKapi.Text = "Kapıda Ödeme";
            checkBoxKapi.UseVisualStyleBackColor = true;
            // 
            // checkBoxKrediKart
            // 
            checkBoxKrediKart.AutoSize = true;
            checkBoxKrediKart.Location = new Point(20, 101);
            checkBoxKrediKart.Margin = new Padding(5, 5, 5, 5);
            checkBoxKrediKart.Name = "checkBoxKrediKart";
            checkBoxKrediKart.Size = new Size(220, 32);
            checkBoxKrediKart.TabIndex = 1;
            checkBoxKrediKart.Text = "Kredi Kartı ile Ödeme";
            checkBoxKrediKart.UseVisualStyleBackColor = true;
            // 
            // checkBoxCüzdan
            // 
            checkBoxCüzdan.AutoSize = true;
            checkBoxCüzdan.Location = new Point(20, 144);
            checkBoxCüzdan.Name = "checkBoxCüzdan";
            checkBoxCüzdan.Size = new Size(201, 32);
            checkBoxCüzdan.TabIndex = 2;
            checkBoxCüzdan.Text = "Cüzdandan Ödeme";
            checkBoxCüzdan.UseVisualStyleBackColor = true;
            // 
            // grpBoxOdemeTutar
            // 
            grpBoxOdemeTutar.BackColor = SystemColors.ActiveCaption;
            grpBoxOdemeTutar.Controls.Add(lblTutar);
            grpBoxOdemeTutar.Controls.Add(label1);
            grpBoxOdemeTutar.Dock = DockStyle.Top;
            grpBoxOdemeTutar.Location = new Point(0, 0);
            grpBoxOdemeTutar.Name = "grpBoxOdemeTutar";
            grpBoxOdemeTutar.Size = new Size(707, 79);
            grpBoxOdemeTutar.TabIndex = 1;
            grpBoxOdemeTutar.TabStop = false;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 684);
            Controls.Add(grpBoxOdemeTutar);
            Controls.Add(grpBoxOdemeSekli);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form1";
            Text = "Form1";
            grpBoxOdemeSekli.ResumeLayout(false);
            grpBoxOdemeSekli.PerformLayout();
            grpBoxOdemeTutar.ResumeLayout(false);
            grpBoxOdemeTutar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxOdemeSekli;
        private CheckBox checkBoxCüzdan;
        private CheckBox checkBoxKrediKart;
        private CheckBox checkBoxKapi;
        private GroupBox grpBoxOdemeTutar;
        private Label lblTutar;
        private Label label1;
    }
}