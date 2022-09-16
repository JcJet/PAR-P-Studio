namespace PAR_P_Studio
{
    partial class LayoutForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LayoutForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.ShakeTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1289, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox
            // 
            this.toolStripTextBox.Enabled = false;
            this.toolStripTextBox.Name = "toolStripTextBox";
            this.toolStripTextBox.Size = new System.Drawing.Size(665, 27);
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawingPanel.Location = new System.Drawing.Point(0, 31);
            this.DrawingPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(1289, 577);
            this.DrawingPanel.TabIndex = 1;
            this.DrawingPanel.Click += new System.EventHandler(this.DrawingPanel_Click);
            this.DrawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPanel_Paint);
            this.DrawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseDown);
            // 
            // ShakeTimer
            // 
            this.ShakeTimer.Tick += new System.EventHandler(this.ShakeTimer_Tick);
            // 
            // LayoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 608);
            this.Controls.Add(this.DrawingPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "LayoutForm";
            this.Text = "Расклад";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LayoutForm_FormClosing);
            this.Shown += new System.EventHandler(this.LayoutForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.Timer ShakeTimer;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox;
    }
}