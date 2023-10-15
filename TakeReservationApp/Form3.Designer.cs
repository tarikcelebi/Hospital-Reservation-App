namespace TakeReservationApp
{
    partial class Form3
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
            lstPatients = new ListBox();
            SuspendLayout();
            // 
            // lstPatients
            // 
            lstPatients.FormattingEnabled = true;
            lstPatients.ItemHeight = 15;
            lstPatients.Location = new Point(12, 12);
            lstPatients.Name = "lstPatients";
            lstPatients.Size = new Size(520, 319);
            lstPatients.TabIndex = 0;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(559, 388);
            Controls.Add(lstPatients);
            Name = "Form3";
            Text = "Randevular";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstPatients;
    }
}