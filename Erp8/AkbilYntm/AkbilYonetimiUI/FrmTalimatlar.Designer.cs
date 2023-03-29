namespace AkbilYonetimiUI
{
    partial class FrmTalimatlar
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
            menuStrip1 = new MenuStrip();
            anaMenuToolStripMenuItem = new ToolStripMenuItem();
            cikisYapToolStripMenuItem = new ToolStripMenuItem();
            cmbBoxAkbiller = new ComboBox();
            label1 = new Label();
            btnTalimatKaydet = new Button();
            txtYuklenecekTutar = new TextBox();
            label2 = new Label();
            lblBekleyenTalimat = new Label();
            checkBoxTumunuGoster = new CheckBox();
            dataGridViewTalimatlar = new DataGridView();
            timerBekleyenTalimat = new System.Windows.Forms.Timer(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            talimatiYükleToolStripMenuItem = new ToolStripMenuItem();
            talimatiIptalEtToolStripMenuItem = new ToolStripMenuItem();
            groupBoxYukleme = new GroupBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTalimatlar).BeginInit();
            contextMenuStrip1.SuspendLayout();
            groupBoxYukleme.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { anaMenuToolStripMenuItem, cikisYapToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1134, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // anaMenuToolStripMenuItem
            // 
            anaMenuToolStripMenuItem.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            anaMenuToolStripMenuItem.Name = "anaMenuToolStripMenuItem";
            anaMenuToolStripMenuItem.Size = new Size(113, 29);
            anaMenuToolStripMenuItem.Text = "Ana Menü";
            anaMenuToolStripMenuItem.Click += anaMenuToolStripMenuItem_Click;
            // 
            // cikisYapToolStripMenuItem
            // 
            cikisYapToolStripMenuItem.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cikisYapToolStripMenuItem.Name = "cikisYapToolStripMenuItem";
            cikisYapToolStripMenuItem.Size = new Size(100, 29);
            cikisYapToolStripMenuItem.Text = "Çıkış Yap";
            cikisYapToolStripMenuItem.Click += cikisYapToolStripMenuItem_Click;
            // 
            // cmbBoxAkbiller
            // 
            cmbBoxAkbiller.FormattingEnabled = true;
            cmbBoxAkbiller.Location = new Point(49, 60);
            cmbBoxAkbiller.Name = "cmbBoxAkbiller";
            cmbBoxAkbiller.Size = new Size(636, 33);
            cmbBoxAkbiller.TabIndex = 1;
            cmbBoxAkbiller.SelectedIndexChanged += cmbBoxAkbiller_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 38);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 2;
            label1.Text = "Yüklenecek Tutar:";
            // 
            // btnTalimatKaydet
            // 
            btnTalimatKaydet.Location = new Point(463, 31);
            btnTalimatKaydet.Name = "btnTalimatKaydet";
            btnTalimatKaydet.Size = new Size(170, 39);
            btnTalimatKaydet.TabIndex = 3;
            btnTalimatKaydet.Text = "TALİMATI KAYDET";
            btnTalimatKaydet.UseVisualStyleBackColor = true;
            btnTalimatKaydet.Click += btnTalimatKaydet_Click;
            // 
            // txtYuklenecekTutar
            // 
            txtYuklenecekTutar.Location = new Point(168, 35);
            txtYuklenecekTutar.Name = "txtYuklenecekTutar";
            txtYuklenecekTutar.Size = new Size(280, 32);
            txtYuklenecekTutar.TabIndex = 4;
            txtYuklenecekTutar.TextChanged += txtYuklenecekTutar_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(691, 60);
            label2.Name = "label2";
            label2.Size = new Size(215, 35);
            label2.TabIndex = 2;
            label2.Text = "Bekleyen Talimat";
            // 
            // lblBekleyenTalimat
            // 
            lblBekleyenTalimat.AutoSize = true;
            lblBekleyenTalimat.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblBekleyenTalimat.ForeColor = Color.Red;
            lblBekleyenTalimat.Location = new Point(771, 123);
            lblBekleyenTalimat.Name = "lblBekleyenTalimat";
            lblBekleyenTalimat.Size = new Size(40, 46);
            lblBekleyenTalimat.TabIndex = 2;
            lblBekleyenTalimat.Text = "0";
            // 
            // checkBoxTumunuGoster
            // 
            checkBoxTumunuGoster.AutoSize = true;
            checkBoxTumunuGoster.Location = new Point(49, 190);
            checkBoxTumunuGoster.Name = "checkBoxTumunuGoster";
            checkBoxTumunuGoster.Size = new Size(164, 29);
            checkBoxTumunuGoster.TabIndex = 5;
            checkBoxTumunuGoster.Text = "Tümünü Göster";
            checkBoxTumunuGoster.UseVisualStyleBackColor = true;
            checkBoxTumunuGoster.CheckedChanged += checkBoxTumunuGoster_CheckedChanged;
            // 
            // dataGridViewTalimatlar
            // 
            dataGridViewTalimatlar.AllowUserToAddRows = false;
            dataGridViewTalimatlar.AllowUserToDeleteRows = false;
            dataGridViewTalimatlar.AllowUserToOrderColumns = true;
            dataGridViewTalimatlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTalimatlar.Location = new Point(49, 238);
            dataGridViewTalimatlar.Name = "dataGridViewTalimatlar";
            dataGridViewTalimatlar.ReadOnly = true;
            dataGridViewTalimatlar.RowHeadersWidth = 51;
            dataGridViewTalimatlar.RowTemplate.Height = 29;
            dataGridViewTalimatlar.Size = new Size(1054, 192);
            dataGridViewTalimatlar.TabIndex = 6;
            // 
            // timerBekleyenTalimat
            // 
            timerBekleyenTalimat.Tick += timerBekleyenTalimat_Tick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { talimatiYükleToolStripMenuItem, talimatiIptalEtToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(215, 84);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // talimatiYükleToolStripMenuItem
            // 
            talimatiYükleToolStripMenuItem.Image = Properties.Resources.png_transparent_checkbox_computer_icons_green_tick_mark_text_trademark_logo;
            talimatiYükleToolStripMenuItem.Name = "talimatiYükleToolStripMenuItem";
            talimatiYükleToolStripMenuItem.Size = new Size(214, 26);
            talimatiYükleToolStripMenuItem.Text = "Talimatı Yükle";
            // 
            // talimatiIptalEtToolStripMenuItem
            // 
            talimatiIptalEtToolStripMenuItem.Image = Properties.Resources.png_transparent_wrong_incorrect_delete_abort_cancel_remove_red_small_mark_negative;
            talimatiIptalEtToolStripMenuItem.Name = "talimatiIptalEtToolStripMenuItem";
            talimatiIptalEtToolStripMenuItem.Size = new Size(214, 26);
            talimatiIptalEtToolStripMenuItem.Text = "Talimatı İptal Et";
            talimatiIptalEtToolStripMenuItem.Click += talimatiIptalEtToolStripMenuItem_Click;
            // 
            // groupBoxYukleme
            // 
            groupBoxYukleme.Controls.Add(label1);
            groupBoxYukleme.Controls.Add(txtYuklenecekTutar);
            groupBoxYukleme.Controls.Add(btnTalimatKaydet);
            groupBoxYukleme.Location = new Point(49, 99);
            groupBoxYukleme.Name = "groupBoxYukleme";
            groupBoxYukleme.Size = new Size(661, 85);
            groupBoxYukleme.TabIndex = 7;
            groupBoxYukleme.TabStop = false;
            // 
            // FrmTalimatlar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 546);
            Controls.Add(groupBoxYukleme);
            Controls.Add(dataGridViewTalimatlar);
            Controls.Add(checkBoxTumunuGoster);
            Controls.Add(lblBekleyenTalimat);
            Controls.Add(label2);
            Controls.Add(cmbBoxAkbiller);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "FrmTalimatlar";
            Text = "FrmTalimatlar";
            Load += FrmTalimatlar_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTalimatlar).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            groupBoxYukleme.ResumeLayout(false);
            groupBoxYukleme.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem anaMenuToolStripMenuItem;
        private ToolStripMenuItem cikisYapToolStripMenuItem;
        private ComboBox cmbBoxAkbiller;
        private Label label1;
        private Button btnTalimatKaydet;
        private TextBox txtYuklenecekTutar;
        private Label label2;
        private Label lblBekleyenTalimat;
        private CheckBox checkBoxTumunuGoster;
        private DataGridView dataGridViewTalimatlar;
        private System.Windows.Forms.Timer timerBekleyenTalimat;
        private ContextMenuStrip contextMenuStrip1;
        private GroupBox groupBoxYukleme;
        private ToolStripMenuItem talimatiYükleToolStripMenuItem;
        private ToolStripMenuItem talimatiIptalEtToolStripMenuItem;
    }
}