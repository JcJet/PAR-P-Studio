namespace PAR_P_Studio.Dialogs
{
    partial class CardCountRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardCountRequest));
            this.CardCoundRequestLabel = new System.Windows.Forms.Label();
            this.CardCountBox = new System.Windows.Forms.NumericUpDown();
            this.OKbtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CardCountBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CardCoundRequestLabel
            // 
            this.CardCoundRequestLabel.AutoSize = true;
            this.CardCoundRequestLabel.Location = new System.Drawing.Point(3, 9);
            this.CardCoundRequestLabel.Name = "CardCoundRequestLabel";
            this.CardCoundRequestLabel.Size = new System.Drawing.Size(132, 13);
            this.CardCoundRequestLabel.TabIndex = 0;
            this.CardCoundRequestLabel.Text = "Сколько карт добавить?";
            // 
            // CardCountBox
            // 
            this.CardCountBox.Location = new System.Drawing.Point(141, 7);
            this.CardCountBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CardCountBox.Name = "CardCountBox";
            this.CardCountBox.Size = new System.Drawing.Size(120, 20);
            this.CardCountBox.TabIndex = 1;
            this.CardCountBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CardCountBox_KeyDown);
            // 
            // OKbtn
            // 
            this.OKbtn.Location = new System.Drawing.Point(6, 31);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(75, 23);
            this.OKbtn.TabIndex = 2;
            this.OKbtn.Text = "Ок";
            this.OKbtn.UseVisualStyleBackColor = true;
            this.OKbtn.Click += new System.EventHandler(this.OKbtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(87, 31);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // CardCountRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 66);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKbtn);
            this.Controls.Add(this.CardCountBox);
            this.Controls.Add(this.CardCoundRequestLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CardCountRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CardCountRequest";
            this.Shown += new System.EventHandler(this.CardCountRequest_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.CardCountBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CardCoundRequestLabel;
        private System.Windows.Forms.NumericUpDown CardCountBox;
        private System.Windows.Forms.Button OKbtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}