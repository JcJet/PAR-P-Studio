namespace PAR_P_Studio.Dialogs
{
    partial class MessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            this.MessageText = new System.Windows.Forms.TextBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MessageText
            // 
            this.MessageText.AcceptsReturn = true;
            this.MessageText.AcceptsTab = true;
            this.MessageText.Dock = System.Windows.Forms.DockStyle.Top;
            this.MessageText.Location = new System.Drawing.Point(0, 0);
            this.MessageText.Multiline = true;
            this.MessageText.Name = "MessageText";
            this.MessageText.ReadOnly = true;
            this.MessageText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MessageText.Size = new System.Drawing.Size(315, 232);
            this.MessageText.TabIndex = 1;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.Location = new System.Drawing.Point(118, 238);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "OK";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 267);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.MessageText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageForm";
            this.ShowInTaskbar = false;
            this.Text = "MessageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MessageText;
        private System.Windows.Forms.Button CloseBtn;
    }
}