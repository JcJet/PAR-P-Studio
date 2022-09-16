namespace PAR_P_Studio.Investments.invForms
{
    partial class TraderEditor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textInfo = new System.Windows.Forms.TextBox();
            this.AccountsList = new System.Windows.Forms.ListView();
            this.AddAccountButton = new System.Windows.Forms.Button();
            this.RemoveAccountButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textInfo);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные о трейдере";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textNumber);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.RemoveAccountButton);
            this.groupBox2.Controls.Add(this.AddAccountButton);
            this.groupBox2.Controls.Add(this.AccountsList);
            this.groupBox2.Location = new System.Drawing.Point(12, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список счетов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Информация";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(47, 19);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(229, 20);
            this.textName.TabIndex = 2;
            // 
            // textInfo
            // 
            this.textInfo.Location = new System.Drawing.Point(6, 63);
            this.textInfo.Multiline = true;
            this.textInfo.Name = "textInfo";
            this.textInfo.Size = new System.Drawing.Size(506, 112);
            this.textInfo.TabIndex = 3;
            // 
            // AccountsList
            // 
            this.AccountsList.Location = new System.Drawing.Point(15, 19);
            this.AccountsList.Name = "AccountsList";
            this.AccountsList.Size = new System.Drawing.Size(234, 121);
            this.AccountsList.TabIndex = 0;
            this.AccountsList.UseCompatibleStateImageBehavior = false;
            // 
            // AddAccountButton
            // 
            this.AddAccountButton.Location = new System.Drawing.Point(255, 19);
            this.AddAccountButton.Name = "AddAccountButton";
            this.AddAccountButton.Size = new System.Drawing.Size(33, 23);
            this.AddAccountButton.TabIndex = 1;
            this.AddAccountButton.Text = "+";
            this.AddAccountButton.UseVisualStyleBackColor = true;
            this.AddAccountButton.Click += new System.EventHandler(this.AddAccountButton_Click);
            // 
            // RemoveAccountButton
            // 
            this.RemoveAccountButton.Location = new System.Drawing.Point(255, 48);
            this.RemoveAccountButton.Name = "RemoveAccountButton";
            this.RemoveAccountButton.Size = new System.Drawing.Size(33, 23);
            this.RemoveAccountButton.TabIndex = 2;
            this.RemoveAccountButton.Text = "-";
            this.RemoveAccountButton.UseVisualStyleBackColor = true;
            this.RemoveAccountButton.Click += new System.EventHandler(this.RemoveAccountButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Номер счета";
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(304, 33);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(202, 20);
            this.textNumber.TabIndex = 4;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(23, 367);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(87, 32);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TraderEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 411);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TraderEditor";
            this.Text = "TraderEditor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textInfo;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView AccountsList;
        private System.Windows.Forms.Button RemoveAccountButton;
        private System.Windows.Forms.Button AddAccountButton;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveButton;
    }
}