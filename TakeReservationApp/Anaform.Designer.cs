namespace TakeReservationApp
{
    partial class Anaform
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
            randevuOlusturToolStripMenuItem = new ToolStripMenuItem();
            randevularToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { randevuOlusturToolStripMenuItem, randevularToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(544, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // randevuOlusturToolStripMenuItem
            // 
            randevuOlusturToolStripMenuItem.Name = "randevuOlusturToolStripMenuItem";
            randevuOlusturToolStripMenuItem.Size = new Size(107, 20);
            randevuOlusturToolStripMenuItem.Text = "Randevu Olustur";
            randevuOlusturToolStripMenuItem.Click += randevuOlusturToolStripMenuItem_Click;
            // 
            // randevularToolStripMenuItem
            // 
            randevularToolStripMenuItem.Name = "randevularToolStripMenuItem";
            randevularToolStripMenuItem.Size = new Size(78, 20);
            randevularToolStripMenuItem.Text = "Randevular";
            randevularToolStripMenuItem.Click += randevularToolStripMenuItem_Click_1;
            // 
            // Anaform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 485);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Anaform";
            Text = "Anaform";
            Load += Anaform_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem randevuOlusturToolStripMenuItem;
        private ToolStripMenuItem randevularToolStripMenuItem;
    }
}