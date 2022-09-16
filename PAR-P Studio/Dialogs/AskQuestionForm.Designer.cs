namespace PAR_P_Studio
{
    partial class AskQuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AskQuestionForm));
            this.AskQuestionLabel = new System.Windows.Forms.Label();
            this.textQuestion = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.NoQuestionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AskQuestionLabel
            // 
            this.AskQuestionLabel.AutoSize = true;
            this.AskQuestionLabel.Location = new System.Drawing.Point(12, 9);
            this.AskQuestionLabel.Name = "AskQuestionLabel";
            this.AskQuestionLabel.Size = new System.Drawing.Size(70, 13);
            this.AskQuestionLabel.TabIndex = 0;
            this.AskQuestionLabel.Text = "Ваш вопрос:";
            // 
            // textQuestion
            // 
            this.textQuestion.Location = new System.Drawing.Point(15, 25);
            this.textQuestion.Name = "textQuestion";
            this.textQuestion.Size = new System.Drawing.Size(300, 20);
            this.textQuestion.TabIndex = 1;
            this.textQuestion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textQuestion_KeyDown);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(12, 51);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(70, 24);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "Принять";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // NoQuestionButton
            // 
            this.NoQuestionButton.Location = new System.Drawing.Point(88, 52);
            this.NoQuestionButton.Name = "NoQuestionButton";
            this.NoQuestionButton.Size = new System.Drawing.Size(84, 23);
            this.NoQuestionButton.TabIndex = 3;
            this.NoQuestionButton.Text = "Не задавать";
            this.NoQuestionButton.UseVisualStyleBackColor = true;
            this.NoQuestionButton.Click += new System.EventHandler(this.NoQuestionButton_Click);
            // 
            // AskQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 84);
            this.Controls.Add(this.NoQuestionButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.textQuestion);
            this.Controls.Add(this.AskQuestionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AskQuestionForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Вопрос для расклада";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AskQuestionLabel;
        private System.Windows.Forms.TextBox textQuestion;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button NoQuestionButton;
    }
}