namespace PAR_P_Studio
{
    partial class LargeImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LargeImage));
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawingPanel.Location = new System.Drawing.Point(0, 0);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(505, 385);
            this.DrawingPanel.TabIndex = 0;
            this.DrawingPanel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DrawingPanel_Scroll);
            this.DrawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPanel_Paint);
            this.DrawingPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseClick);
            this.DrawingPanel.Resize += new System.EventHandler(this.DrawingPanel_Resize);
            // 
            // LargeImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 385);
            this.Controls.Add(this.DrawingPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LargeImage";
            this.Text = "Кнопки мыши - изменить масштаб";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.LargeImage_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DrawingPanel;
    }
}