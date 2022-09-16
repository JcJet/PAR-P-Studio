namespace PAR_P_Studio.Investments.invForms
{
    partial class IndexEditor
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
            this.PropertiesBox = new System.Windows.Forms.GroupBox();
            this.DescriptionText = new System.Windows.Forms.RichTextBox();
            this.PrivateIndex = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddAccountButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.TraderTree = new System.Windows.Forms.TreeView();
            this.ItemList = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.PercentageBox = new System.Windows.Forms.NumericUpDown();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PercentageStatus = new System.Windows.Forms.Label();
            this.ChangePercent = new System.Windows.Forms.Button();
            this.PropertiesBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PercentageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PropertiesBox
            // 
            this.PropertiesBox.Controls.Add(this.DescriptionText);
            this.PropertiesBox.Controls.Add(this.PrivateIndex);
            this.PropertiesBox.Controls.Add(this.label3);
            this.PropertiesBox.Controls.Add(this.label2);
            this.PropertiesBox.Controls.Add(this.textName);
            this.PropertiesBox.Controls.Add(this.label1);
            this.PropertiesBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PropertiesBox.Location = new System.Drawing.Point(0, 0);
            this.PropertiesBox.Name = "PropertiesBox";
            this.PropertiesBox.Size = new System.Drawing.Size(683, 229);
            this.PropertiesBox.TabIndex = 0;
            this.PropertiesBox.TabStop = false;
            this.PropertiesBox.Text = "Свойства индекса";
            // 
            // DescriptionText
            // 
            this.DescriptionText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DescriptionText.Location = new System.Drawing.Point(3, 96);
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.DescriptionText.Size = new System.Drawing.Size(677, 130);
            this.DescriptionText.TabIndex = 26;
            this.DescriptionText.Text = "";
            // 
            // PrivateIndex
            // 
            this.PrivateIndex.AutoSize = true;
            this.PrivateIndex.Location = new System.Drawing.Point(12, 51);
            this.PrivateIndex.Name = "PrivateIndex";
            this.PrivateIndex.Size = new System.Drawing.Size(65, 17);
            this.PrivateIndex.TabIndex = 4;
            this.PrivateIndex.Text = "Личный";
            this.PrivateIndex.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Описание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // textName
            // 
            this.textName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textName.Location = new System.Drawing.Point(72, 25);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(605, 20);
            this.textName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChangePercent);
            this.groupBox1.Controls.Add(this.PercentageBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.AddAccountButton);
            this.groupBox1.Controls.Add(this.RemoveItemButton);
            this.groupBox1.Controls.Add(this.AddItemButton);
            this.groupBox1.Controls.Add(this.TraderTree);
            this.groupBox1.Controls.Add(this.ItemList);
            this.groupBox1.Location = new System.Drawing.Point(3, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 238);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Элементы";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(587, 209);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddAccountButton
            // 
            this.AddAccountButton.Location = new System.Drawing.Point(633, 19);
            this.AddAccountButton.Name = "AddAccountButton";
            this.AddAccountButton.Size = new System.Drawing.Size(29, 23);
            this.AddAccountButton.TabIndex = 4;
            this.AddAccountButton.Text = "+";
            this.AddAccountButton.UseVisualStyleBackColor = true;
            this.AddAccountButton.Click += new System.EventHandler(this.AddAccountButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Location = new System.Drawing.Point(334, 114);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(24, 23);
            this.RemoveItemButton.TabIndex = 3;
            this.RemoveItemButton.Text = ">";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(388, 114);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(24, 23);
            this.AddItemButton.TabIndex = 2;
            this.AddItemButton.Text = "<";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // TraderTree
            // 
            this.TraderTree.Location = new System.Drawing.Point(418, 19);
            this.TraderTree.Name = "TraderTree";
            this.TraderTree.Size = new System.Drawing.Size(163, 213);
            this.TraderTree.TabIndex = 1;
            this.TraderTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TraderTree_AfterSelect);
            this.TraderTree.Click += new System.EventHandler(this.TraderTree_Click);
            // 
            // ItemList
            // 
            this.ItemList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ItemList.Location = new System.Drawing.Point(9, 19);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(319, 213);
            this.ItemList.TabIndex = 0;
            this.ItemList.UseCompatibleStateImageBehavior = false;
            this.ItemList.View = System.Windows.Forms.View.Details;
            this.ItemList.SelectedIndexChanged += new System.EventHandler(this.ItemList_SelectedIndexChanged);
            this.ItemList.Click += new System.EventHandler(this.ItemList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "% от индекса";
            // 
            // PercentageBox
            // 
            this.PercentageBox.Location = new System.Drawing.Point(359, 209);
            this.PercentageBox.Name = "PercentageBox";
            this.PercentageBox.Size = new System.Drawing.Size(53, 20);
            this.PercentageBox.TabIndex = 7;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "№ Счета";
            this.columnHeader1.Width = 111;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Трейдер";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Доля";
            // 
            // PercentageStatus
            // 
            this.PercentageStatus.AutoSize = true;
            this.PercentageStatus.Location = new System.Drawing.Point(12, 476);
            this.PercentageStatus.Name = "PercentageStatus";
            this.PercentageStatus.Size = new System.Drawing.Size(99, 13);
            this.PercentageStatus.TabIndex = 2;
            this.PercentageStatus.Text = "Не распределено:";
            // 
            // ChangePercent
            // 
            this.ChangePercent.Location = new System.Drawing.Point(329, 209);
            this.ChangePercent.Name = "ChangePercent";
            this.ChangePercent.Size = new System.Drawing.Size(24, 23);
            this.ChangePercent.TabIndex = 8;
            this.ChangePercent.Text = "<";
            this.ChangePercent.UseVisualStyleBackColor = true;
            this.ChangePercent.Visible = false;
            this.ChangePercent.Click += new System.EventHandler(this.ChangePercent_Click);
            // 
            // IndexEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 528);
            this.Controls.Add(this.PercentageStatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PropertiesBox);
            this.Name = "IndexEditor";
            this.Text = "Редактор индекса";
            this.Activated += new System.EventHandler(this.IndexEditor_Activated);
            this.Shown += new System.EventHandler(this.IndexEditor_Shown);
            this.PropertiesBox.ResumeLayout(false);
            this.PropertiesBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PercentageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox PropertiesBox;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox PrivateIndex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.RichTextBox DescriptionText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddAccountButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.TreeView TraderTree;
        private System.Windows.Forms.ListView ItemList;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.NumericUpDown PercentageBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label PercentageStatus;
        private System.Windows.Forms.Button ChangePercent;
    }
}