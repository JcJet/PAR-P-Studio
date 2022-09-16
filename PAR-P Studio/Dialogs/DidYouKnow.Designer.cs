namespace PAR_P_Studio.Dialogs
{
    partial class DidYouKnow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DidYouKnow));
            this.InfoPicture = new System.Windows.Forms.PictureBox();
            this.TipLabel = new System.Windows.Forms.Label();
            this.TipText = new System.Windows.Forms.TextBox();
            this.ShowAtStartupBox = new System.Windows.Forms.CheckBox();
            this.NextTipButton = new System.Windows.Forms.Button();
            this.TipNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InfoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoPicture
            // 
            this.InfoPicture.Image = global::PAR_P_Studio.Properties.Resources.info;
            this.InfoPicture.Location = new System.Drawing.Point(-2, 1);
            this.InfoPicture.Name = "InfoPicture";
            this.InfoPicture.Size = new System.Drawing.Size(114, 114);
            this.InfoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InfoPicture.TabIndex = 0;
            this.InfoPicture.TabStop = false;
            this.InfoPicture.Click += new System.EventHandler(this.InfoPicture_Click);
            // 
            // TipLabel
            // 
            this.TipLabel.AutoSize = true;
            this.TipLabel.Location = new System.Drawing.Point(115, 1);
            this.TipLabel.Name = "TipLabel";
            this.TipLabel.Size = new System.Drawing.Size(107, 13);
            this.TipLabel.TabIndex = 1;
            this.TipLabel.Text = "Знаете ли Вы, что...";
            // 
            // TipText
            // 
            this.TipText.Location = new System.Drawing.Point(118, 17);
            this.TipText.Multiline = true;
            this.TipText.Name = "TipText";
            this.TipText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TipText.Size = new System.Drawing.Size(283, 128);
            this.TipText.TabIndex = 2;
            // 
            // ShowAtStartupBox
            // 
            this.ShowAtStartupBox.AutoSize = true;
            this.ShowAtStartupBox.Location = new System.Drawing.Point(118, 152);
            this.ShowAtStartupBox.Name = "ShowAtStartupBox";
            this.ShowAtStartupBox.Size = new System.Drawing.Size(147, 17);
            this.ShowAtStartupBox.TabIndex = 3;
            this.ShowAtStartupBox.Text = "Показывать при старте";
            this.ShowAtStartupBox.UseVisualStyleBackColor = true;
            this.ShowAtStartupBox.CheckedChanged += new System.EventHandler(this.ShowAtStartupBox_CheckedChanged);
            // 
            // NextTipButton
            // 
            this.NextTipButton.Location = new System.Drawing.Point(288, 146);
            this.NextTipButton.Name = "NextTipButton";
            this.NextTipButton.Size = new System.Drawing.Size(113, 23);
            this.NextTipButton.TabIndex = 4;
            this.NextTipButton.Text = "Следующий совет";
            this.NextTipButton.UseVisualStyleBackColor = true;
            this.NextTipButton.Click += new System.EventHandler(this.NextTipButton_Click);
            // 
            // TipNumberLabel
            // 
            this.TipNumberLabel.AutoSize = true;
            this.TipNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TipNumberLabel.Location = new System.Drawing.Point(12, 128);
            this.TipNumberLabel.Name = "TipNumberLabel";
            this.TipNumberLabel.Size = new System.Drawing.Size(31, 17);
            this.TipNumberLabel.TabIndex = 5;
            this.TipNumberLabel.Text = "0/0";
            // 
            // DidYouKnow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 176);
            this.Controls.Add(this.TipNumberLabel);
            this.Controls.Add(this.NextTipButton);
            this.Controls.Add(this.ShowAtStartupBox);
            this.Controls.Add(this.TipText);
            this.Controls.Add(this.TipLabel);
            this.Controls.Add(this.InfoPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DidYouKnow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TipOfTheDay";
            this.Load += new System.EventHandler(this.DidYouKnow_Load);
            this.Shown += new System.EventHandler(this.DidYouKnow_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.InfoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox InfoPicture;
        private System.Windows.Forms.Label TipLabel;
        private System.Windows.Forms.TextBox TipText;
        private System.Windows.Forms.CheckBox ShowAtStartupBox;
        private System.Windows.Forms.Button NextTipButton;
        private System.Windows.Forms.Label TipNumberLabel;
    }
}