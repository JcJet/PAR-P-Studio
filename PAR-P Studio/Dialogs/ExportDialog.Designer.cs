namespace PAR_P_Studio.Dialogs
{
    partial class ExportDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportDialog));
            this.QualityLabel = new System.Windows.Forms.Label();
            this.FormatBox = new System.Windows.Forms.ComboBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QualityLabel
            // 
            this.QualityLabel.AutoSize = true;
            this.QualityLabel.Location = new System.Drawing.Point(9, 10);
            this.QualityLabel.Name = "QualityLabel";
            this.QualityLabel.Size = new System.Drawing.Size(120, 13);
            this.QualityLabel.TabIndex = 0;
            this.QualityLabel.Text = "Формат изображений";
            // 
            // FormatBox
            // 
            this.FormatBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormatBox.FormattingEnabled = true;
            this.FormatBox.Items.AddRange(new object[] {
            "JPEG",
            "BMP",
            "GIF",
            "TIFF",
            "PNG"});
            this.FormatBox.Location = new System.Drawing.Point(140, 7);
            this.FormatBox.Name = "FormatBox";
            this.FormatBox.Size = new System.Drawing.Size(121, 21);
            this.FormatBox.TabIndex = 1;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(12, 49);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "ОК";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(87, 49);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ExportDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 83);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.FormatBox);
            this.Controls.Add(this.QualityLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExportDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Экспорт";
            this.Shown += new System.EventHandler(this.ExportDialog_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QualityLabel;
        private System.Windows.Forms.ComboBox FormatBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelBtn;
    }
}