namespace ZarTahminWinForm
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
            components = new System.ComponentModel.Container();
            btn1 = new Button();
            btn2 = new Button();
            lstSonuc = new ListBox();
            cmbSayilar = new ComboBox();
            btnDondur = new Button();
            tmr1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ActiveCaption;
            btn1.Enabled = false;
            btn1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.ForeColor = Color.IndianRed;
            btn1.Location = new Point(104, 67);
            btn1.Name = "btn1";
            btn1.Size = new Size(74, 82);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ActiveCaption;
            btn2.Enabled = false;
            btn2.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.ForeColor = Color.IndianRed;
            btn2.Location = new Point(184, 67);
            btn2.Name = "btn2";
            btn2.Size = new Size(74, 82);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            // 
            // lstSonuc
            // 
            lstSonuc.FormattingEnabled = true;
            lstSonuc.ItemHeight = 15;
            lstSonuc.Location = new Point(275, 12);
            lstSonuc.Name = "lstSonuc";
            lstSonuc.Size = new Size(173, 334);
            lstSonuc.TabIndex = 2;
            // 
            // cmbSayilar
            // 
            cmbSayilar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSayilar.FormattingEnabled = true;
            cmbSayilar.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            cmbSayilar.Location = new Point(104, 12);
            cmbSayilar.Name = "cmbSayilar";
            cmbSayilar.Size = new Size(74, 23);
            cmbSayilar.TabIndex = 3;
            // 
            // btnDondur
            // 
            btnDondur.ForeColor = Color.SeaGreen;
            btnDondur.Location = new Point(184, 12);
            btnDondur.Name = "btnDondur";
            btnDondur.Size = new Size(74, 23);
            btnDondur.TabIndex = 4;
            btnDondur.Text = "Zar At";
            btnDondur.UseVisualStyleBackColor = true;
            btnDondur.Click += btnDondur_Click;
            // 
            // tmr1
            // 
            tmr1.Interval = 400;
            tmr1.Tick += tmr1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 450);
            Controls.Add(btnDondur);
            Controls.Add(cmbSayilar);
            Controls.Add(lstSonuc);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private ListBox lstSonuc;
        private ComboBox cmbSayilar;
        private Button btnDondur;
        private System.Windows.Forms.Timer tmr1;
    }
}