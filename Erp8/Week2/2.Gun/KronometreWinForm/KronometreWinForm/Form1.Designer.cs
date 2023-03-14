namespace KronometreWinForm
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
            btnStart = new Button();
            btnStop = new Button();
            btnReset = new Button();
            lblSaat = new Label();
            lblDakika = new Label();
            lblSaniye = new Label();
            lblSalise = new Label();
            lstZamanlar = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Green;
            btnStart.ForeColor = SystemColors.Control;
            btnStart.Location = new Point(49, 111);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(86, 31);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.Red;
            btnStop.ForeColor = SystemColors.Control;
            btnStop.Location = new Point(142, 111);
            btnStop.Margin = new Padding(3, 4, 3, 4);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(86, 31);
            btnStop.TabIndex = 1;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.DeepSkyBlue;
            btnReset.ForeColor = SystemColors.Control;
            btnReset.Location = new Point(234, 111);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(86, 31);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // lblSaat
            // 
            lblSaat.AutoSize = true;
            lblSaat.Location = new Point(90, 67);
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new Size(0, 20);
            lblSaat.TabIndex = 3;
            // 
            // lblDakika
            // 
            lblDakika.AutoSize = true;
            lblDakika.Location = new Point(142, 67);
            lblDakika.Name = "lblDakika";
            lblDakika.Size = new Size(0, 20);
            lblDakika.TabIndex = 4;
            // 
            // lblSaniye
            // 
            lblSaniye.AutoSize = true;
            lblSaniye.Location = new Point(193, 67);
            lblSaniye.Name = "lblSaniye";
            lblSaniye.Size = new Size(0, 20);
            lblSaniye.TabIndex = 5;
            // 
            // lblSalise
            // 
            lblSalise.AutoSize = true;
            lblSalise.Location = new Point(254, 67);
            lblSalise.Name = "lblSalise";
            lblSalise.Size = new Size(0, 20);
            lblSalise.TabIndex = 6;
            // 
            // lstZamanlar
            // 
            lstZamanlar.FormattingEnabled = true;
            lstZamanlar.ItemHeight = 20;
            lstZamanlar.Location = new Point(327, 16);
            lstZamanlar.Margin = new Padding(3, 4, 3, 4);
            lstZamanlar.Name = "lstZamanlar";
            lstZamanlar.Size = new Size(189, 124);
            lstZamanlar.TabIndex = 7;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 31);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 11;
            label1.Text = "Salise";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 31);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 10;
            label2.Text = "Saniye";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 31);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 9;
            label3.Text = "Dakika";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 31);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 8;
            label4.Text = "Saat";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(573, 249);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(lstZamanlar);
            Controls.Add(lblSalise);
            Controls.Add(lblSaniye);
            Controls.Add(lblDakika);
            Controls.Add(lblSaat);
            Controls.Add(btnReset);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Kronometre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private Button btnReset;
        private Label lblSaat;
        private Label lblDakika;
        private Label lblSaniye;
        private Label lblSalise;
        private ListBox lstZamanlar;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}