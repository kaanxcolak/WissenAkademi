namespace AracTakip
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
            yönetimToolStripMenuItem = new ToolStripMenuItem();
            markaToolStripMenuItem = new ToolStripMenuItem();
            modelToolStripMenuItem = new ToolStripMenuItem();
            aracToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { yönetimToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // yönetimToolStripMenuItem
            // 
            yönetimToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { markaToolStripMenuItem, modelToolStripMenuItem, aracToolStripMenuItem });
            yönetimToolStripMenuItem.Name = "yönetimToolStripMenuItem";
            yönetimToolStripMenuItem.Size = new Size(65, 24);
            yönetimToolStripMenuItem.Text = "Düzen";
            // 
            // markaToolStripMenuItem
            // 
            markaToolStripMenuItem.Name = "markaToolStripMenuItem";
            markaToolStripMenuItem.Size = new Size(224, 26);
            markaToolStripMenuItem.Text = "Marka";
            markaToolStripMenuItem.Click += markaToolStripMenuItem_Click;
            // 
            // modelToolStripMenuItem
            // 
            modelToolStripMenuItem.Name = "modelToolStripMenuItem";
            modelToolStripMenuItem.Size = new Size(224, 26);
            modelToolStripMenuItem.Text = "Model";
            modelToolStripMenuItem.Click += modelToolStripMenuItem_Click;
            // 
            // aracToolStripMenuItem
            // 
            aracToolStripMenuItem.Name = "aracToolStripMenuItem";
            aracToolStripMenuItem.Size = new Size(224, 26);
            aracToolStripMenuItem.Text = "Arac";
            aracToolStripMenuItem.Click += aracToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem yönetimToolStripMenuItem;
        private ToolStripMenuItem markaToolStripMenuItem;
        private ToolStripMenuItem modelToolStripMenuItem;
        private ToolStripMenuItem aracToolStripMenuItem;
    }
}