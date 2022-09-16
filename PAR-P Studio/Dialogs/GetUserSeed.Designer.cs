namespace PAR_P_Studio.Dialogs
{
    partial class GetUserSeed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetUserSeed));
            this.MousePanel = new System.Windows.Forms.Panel();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // MousePanel
            // 
            this.MousePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MousePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MousePanel.Location = new System.Drawing.Point(0, 0);
            this.MousePanel.Name = "MousePanel";
            this.MousePanel.Size = new System.Drawing.Size(416, 250);
            this.MousePanel.TabIndex = 0;
            this.MousePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MousePanel_Paint);
            this.MousePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MousePanel_MouseDown);
            this.MousePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MousePanel_MouseMove);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(0, 256);
            this.ProgressBar.Maximum = 1000;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(416, 20);
            this.ProgressBar.TabIndex = 1;
            // 
            // GetUserSeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 277);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.MousePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GetUserSeed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GetUserSeed";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MousePanel;
        private System.Windows.Forms.ProgressBar ProgressBar;
    }
}