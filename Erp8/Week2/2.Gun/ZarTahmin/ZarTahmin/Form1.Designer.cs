namespace ZarTahmin
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
            btnBaslat = new Button();
            label1 = new Label();
            txtGirilenSayi = new TextBox();
            lstTahminler = new ListBox();
            zar1 = new Label();
            zar2 = new Label();
            SuspendLayout();
            // 
            // btnBaslat
            // 
            btnBaslat.Location = new Point(194, 137);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(94, 29);
            btnBaslat.TabIndex = 0;
            btnBaslat.Text = "Başlat";
            btnBaslat.UseVisualStyleBackColor = true;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 49);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 1;
            label1.Text = "Girilen sayı:";
            // 
            // txtGirilenSayi
            // 
            txtGirilenSayi.Location = new Point(177, 42);
            txtGirilenSayi.Name = "txtGirilenSayi";
            txtGirilenSayi.Size = new Size(125, 27);
            txtGirilenSayi.TabIndex = 2;
            // 
            // lstTahminler
            // 
            lstTahminler.FormattingEnabled = true;
            lstTahminler.ItemHeight = 20;
            lstTahminler.Location = new Point(349, 42);
            lstTahminler.Name = "lstTahminler";
            lstTahminler.Size = new Size(193, 164);
            lstTahminler.TabIndex = 3;
            // 
            // zar1
            // 
            zar1.AutoSize = true;
            zar1.Location = new Point(194, 101);
            zar1.Name = "zar1";
            zar1.Size = new Size(37, 20);
            zar1.TabIndex = 4;
            zar1.Text = "zar1";
            // 
            // zar2
            // 
            zar2.AutoSize = true;
            zar2.Location = new Point(252, 101);
            zar2.Name = "zar2";
            zar2.Size = new Size(37, 20);
            zar2.TabIndex = 5;
            zar2.Text = "zar2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(zar2);
            Controls.Add(zar1);
            Controls.Add(lstTahminler);
            Controls.Add(txtGirilenSayi);
            Controls.Add(label1);
            Controls.Add(btnBaslat);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBaslat;
        private Label label1;
        private TextBox txtGirilenSayi;
        private ListBox lstTahminler;
        private Label zar1;
        private Label zar2;
    }
}