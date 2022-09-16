namespace PAR_P_Studio.Dialogs
{
    partial class ThemeNameRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemeNameRequest));
            this.InputLabel = new System.Windows.Forms.Label();
            this.ThemeNameTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(12, 9);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(194, 13);
            this.InputLabel.TabIndex = 0;
            this.InputLabel.Text = "Введите имя новой цветовой схемы:";
            // 
            // ThemeNameTextBox
            // 
            this.ThemeNameTextBox.Location = new System.Drawing.Point(12, 25);
            this.ThemeNameTextBox.Name = "ThemeNameTextBox";
            this.ThemeNameTextBox.Size = new System.Drawing.Size(318, 20);
            this.ThemeNameTextBox.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(15, 51);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(96, 51);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Отмена";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ThemeNameRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 84);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ThemeNameTextBox);
            this.Controls.Add(this.InputLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ThemeNameRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Сохранение";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.TextBox ThemeNameTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CloseButton;
    }
}