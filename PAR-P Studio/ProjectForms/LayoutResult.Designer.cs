namespace PAR_P_Studio
{
    partial class LayoutResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LayoutResult));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.textQuestion = new System.Windows.Forms.ToolStripTextBox();
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.CardImage = new System.Windows.Forms.PictureBox();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.PosDescription = new System.Windows.Forms.TextBox();
            this.LayoutDescriptionRtf = new System.Windows.Forms.RichTextBox();
            this.LayoutNameLabel = new System.Windows.Forms.Label();
            this.CommentButton = new System.Windows.Forms.Button();
            this.CommentHelp = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textQuestion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1213, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // textQuestion
            // 
            this.textQuestion.Name = "textQuestion";
            this.textQuestion.ReadOnly = true;
            this.textQuestion.Size = new System.Drawing.Size(532, 27);
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.AutoScroll = true;
            this.DrawingPanel.Location = new System.Drawing.Point(0, 33);
            this.DrawingPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(568, 352);
            this.DrawingPanel.TabIndex = 2;
            this.DrawingPanel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DrawingPanel_Scroll);
            this.DrawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPanel_Paint);
            this.DrawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseDown);
            // 
            // CardImage
            // 
            this.CardImage.Location = new System.Drawing.Point(576, 33);
            this.CardImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CardImage.Name = "CardImage";
            this.CardImage.Size = new System.Drawing.Size(281, 352);
            this.CardImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CardImage.TabIndex = 4;
            this.CardImage.TabStop = false;
            this.CardImage.Click += new System.EventHandler(this.CardImage_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(4, 385);
            this.PreviousButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(132, 28);
            this.PreviousButton.TabIndex = 6;
            this.PreviousButton.Text = "< Предыдущая";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(144, 385);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(125, 28);
            this.NextButton.TabIndex = 7;
            this.NextButton.Text = "Следующая >";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // Description
            // 
            this.Description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Description.Location = new System.Drawing.Point(0, 453);
            this.Description.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Size = new System.Drawing.Size(1212, 219);
            this.Description.TabIndex = 8;
            this.Description.Text = "";
            // 
            // PosDescription
            // 
            this.PosDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PosDescription.Location = new System.Drawing.Point(4, 421);
            this.PosDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PosDescription.Name = "PosDescription";
            this.PosDescription.ReadOnly = true;
            this.PosDescription.Size = new System.Drawing.Size(1208, 22);
            this.PosDescription.TabIndex = 9;
            // 
            // LayoutDescriptionRtf
            // 
            this.LayoutDescriptionRtf.AcceptsTab = true;
            this.LayoutDescriptionRtf.Location = new System.Drawing.Point(865, 60);
            this.LayoutDescriptionRtf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LayoutDescriptionRtf.Name = "LayoutDescriptionRtf";
            this.LayoutDescriptionRtf.ReadOnly = true;
            this.LayoutDescriptionRtf.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.LayoutDescriptionRtf.Size = new System.Drawing.Size(331, 324);
            this.LayoutDescriptionRtf.TabIndex = 10;
            this.LayoutDescriptionRtf.Text = "";
            // 
            // LayoutNameLabel
            // 
            this.LayoutNameLabel.AutoSize = true;
            this.LayoutNameLabel.Location = new System.Drawing.Point(865, 41);
            this.LayoutNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LayoutNameLabel.Name = "LayoutNameLabel";
            this.LayoutNameLabel.Size = new System.Drawing.Size(83, 17);
            this.LayoutNameLabel.TabIndex = 11;
            this.LayoutNameLabel.Text = "layoutName";
            // 
            // CommentButton
            // 
            this.CommentButton.Location = new System.Drawing.Point(325, 385);
            this.CommentButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CommentButton.Name = "CommentButton";
            this.CommentButton.Size = new System.Drawing.Size(115, 28);
            this.CommentButton.TabIndex = 12;
            this.CommentButton.Text = "Комментарий";
            this.CommentButton.UseVisualStyleBackColor = true;
            this.CommentButton.Click += new System.EventHandler(this.CommentButton_Click);
            // 
            // CommentHelp
            // 
            this.CommentHelp.AutoSize = true;
            this.CommentHelp.Location = new System.Drawing.Point(448, 391);
            this.CommentHelp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CommentHelp.Name = "CommentHelp";
            this.CommentHelp.Size = new System.Drawing.Size(16, 17);
            this.CommentHelp.TabIndex = 13;
            this.CommentHelp.TabStop = true;
            this.CommentHelp.Text = "?";
            this.CommentHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CommentHelp_LinkClicked);
            this.CommentHelp.MouseLeave += new System.EventHandler(this.CommentHelp_MouseLeave);
            this.CommentHelp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CommentHelp_MouseMove);
            // 
            // LayoutResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1213, 674);
            this.Controls.Add(this.CommentHelp);
            this.Controls.Add(this.CommentButton);
            this.Controls.Add(this.LayoutNameLabel);
            this.Controls.Add(this.LayoutDescriptionRtf);
            this.Controls.Add(this.PosDescription);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.CardImage);
            this.Controls.Add(this.DrawingPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LayoutResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Результат расклада";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LayoutResult_FormClosed);
            this.Shown += new System.EventHandler(this.LayoutResult_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.Panel DrawingPanel;
        public System.Windows.Forms.PictureBox CardImage;
        public System.Windows.Forms.Button PreviousButton;
        public System.Windows.Forms.Button NextButton;
        public System.Windows.Forms.ToolStripTextBox textQuestion;
        public System.Windows.Forms.RichTextBox Description;
        public System.Windows.Forms.TextBox PosDescription;
        public System.Windows.Forms.RichTextBox LayoutDescriptionRtf;
        public System.Windows.Forms.Label LayoutNameLabel;
        public System.Windows.Forms.Button CommentButton;
        public System.Windows.Forms.LinkLabel CommentHelp;

    }
}