namespace AkbilYonetimiUI
{
    partial class FrmAnasayfa
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
            btnAkbil = new Button();
            btnTalimat = new Button();
            btnAyarlar = new Button();
            SuspendLayout();
            // 
            // btnAkbil
            // 
            btnAkbil.BackColor = SystemColors.ActiveCaption;
            btnAkbil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAkbil.ForeColor = Color.White;
            btnAkbil.Location = new Point(97, 12);
            btnAkbil.Name = "btnAkbil";
            btnAkbil.Size = new Size(133, 88);
            btnAkbil.TabIndex = 0;
            btnAkbil.Text = "AKBİL İŞLEMLERİ";
            btnAkbil.UseVisualStyleBackColor = false;
            btnAkbil.Click += btnAkbil_Click;
            // 
            // btnTalimat
            // 
            btnTalimat.BackColor = SystemColors.ActiveCaption;
            btnTalimat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTalimat.ForeColor = Color.White;
            btnTalimat.Location = new Point(97, 116);
            btnTalimat.Name = "btnTalimat";
            btnTalimat.Size = new Size(133, 88);
            btnTalimat.TabIndex = 0;
            btnTalimat.Text = "TALİMAT İŞLEMLERİ";
            btnTalimat.UseVisualStyleBackColor = false;
            // 
            // btnAyarlar
            // 
            btnAyarlar.BackColor = SystemColors.ActiveCaption;
            btnAyarlar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAyarlar.ForeColor = Color.White;
            btnAyarlar.Location = new Point(97, 220);
            btnAyarlar.Name = "btnAyarlar";
            btnAyarlar.Size = new Size(133, 88);
            btnAyarlar.TabIndex = 0;
            btnAyarlar.Text = "AYARLAR";
            btnAyarlar.UseVisualStyleBackColor = false;
            btnAyarlar.Click += btnAyarlar_Click;
            // 
            // FrmAnasayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 335);
            Controls.Add(btnAyarlar);
            Controls.Add(btnTalimat);
            Controls.Add(btnAkbil);
            Name = "FrmAnasayfa";
            Text = "FrmAnasayfa";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAkbil;
        private Button btnTalimat;
        private Button btnAyarlar;
    }
}