namespace CafeSoft
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
            menuStrip1 = new MenuStrip();
            anaSayfaToolStripMenuItem = new ToolStripMenuItem();
            düzenleToolStripMenuItem = new ToolStripMenuItem();
            katToolStripMenuItem = new ToolStripMenuItem();
            kategoriToolStripMenuItem = new ToolStripMenuItem();
            ürünToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { anaSayfaToolStripMenuItem, düzenleToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1013, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // anaSayfaToolStripMenuItem
            // 
            anaSayfaToolStripMenuItem.Name = "anaSayfaToolStripMenuItem";
            anaSayfaToolStripMenuItem.Size = new Size(85, 24);
            anaSayfaToolStripMenuItem.Text = "AnaSayfa";
            anaSayfaToolStripMenuItem.Click += anaSayfaToolStripMenuItem_Click;
            // 
            // düzenleToolStripMenuItem
            // 
            düzenleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { katToolStripMenuItem, kategoriToolStripMenuItem, ürünToolStripMenuItem });
            düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            düzenleToolStripMenuItem.Size = new Size(77, 24);
            düzenleToolStripMenuItem.Text = "Düzenle";
            // 
            // katToolStripMenuItem
            // 
            katToolStripMenuItem.Name = "katToolStripMenuItem";
            katToolStripMenuItem.Size = new Size(224, 26);
            katToolStripMenuItem.Text = "Kat ";
            katToolStripMenuItem.Click += katToolStripMenuItem_Click;
            // 
            // kategoriToolStripMenuItem
            // 
            kategoriToolStripMenuItem.Name = "kategoriToolStripMenuItem";
            kategoriToolStripMenuItem.Size = new Size(224, 26);
            kategoriToolStripMenuItem.Text = "Kategori";
            // 
            // ürünToolStripMenuItem
            // 
            ürünToolStripMenuItem.Name = "ürünToolStripMenuItem";
            ürünToolStripMenuItem.Size = new Size(224, 26);
            ürünToolStripMenuItem.Text = "Ürün";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 715);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem anaSayfaToolStripMenuItem;
        private ToolStripMenuItem düzenleToolStripMenuItem;
        private ToolStripMenuItem katToolStripMenuItem;
        private ToolStripMenuItem kategoriToolStripMenuItem;
        private ToolStripMenuItem ürünToolStripMenuItem;
    }
}