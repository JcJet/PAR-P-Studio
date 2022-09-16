namespace PAR_P_Studio.Investments.invForms
{
    partial class InvestmentsForm
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
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("");
            this.InvestmentsTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.FinishedList = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textMoney = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AlterIndexButton = new System.Windows.Forms.Button();
            this.RemoveIndexButton = new System.Windows.Forms.Button();
            this.CreateIndexButton = new System.Windows.Forms.Button();
            this.OptimizeButton = new System.Windows.Forms.Button();
            this.AddIndexButton = new System.Windows.Forms.Button();
            this.SelectedList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IndexList = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OwnedOnly = new System.Windows.Forms.CheckBox();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InvestmentsTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InvestmentsTabs
            // 
            this.InvestmentsTabs.Controls.Add(this.tabPage1);
            this.InvestmentsTabs.Controls.Add(this.tabPage2);
            this.InvestmentsTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InvestmentsTabs.Location = new System.Drawing.Point(0, 0);
            this.InvestmentsTabs.Name = "InvestmentsTabs";
            this.InvestmentsTabs.SelectedIndex = 0;
            this.InvestmentsTabs.Size = new System.Drawing.Size(1079, 461);
            this.InvestmentsTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.FinishedList);
            this.tabPage1.Controls.Add(this.textMoney);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.AlterIndexButton);
            this.tabPage1.Controls.Add(this.RemoveIndexButton);
            this.tabPage1.Controls.Add(this.CreateIndexButton);
            this.tabPage1.Controls.Add(this.OptimizeButton);
            this.tabPage1.Controls.Add(this.AddIndexButton);
            this.tabPage1.Controls.Add(this.SelectedList);
            this.tabPage1.Controls.Add(this.IndexList);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1071, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Индексы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(662, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Исходя из выбранного:";
            // 
            // FinishedList
            // 
            this.FinishedList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.FinishedList.Location = new System.Drawing.Point(665, 30);
            this.FinishedList.Name = "FinishedList";
            this.FinishedList.Size = new System.Drawing.Size(264, 285);
            this.FinishedList.TabIndex = 12;
            this.FinishedList.UseCompatibleStateImageBehavior = false;
            this.FinishedList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Трейдер";
            this.columnHeader3.Width = 111;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "%";
            this.columnHeader4.Width = 38;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "$";
            this.columnHeader5.Width = 84;
            // 
            // textMoney
            // 
            this.textMoney.Location = new System.Drawing.Point(297, 339);
            this.textMoney.Name = "textMoney";
            this.textMoney.Size = new System.Drawing.Size(122, 20);
            this.textMoney.TabIndex = 11;
            this.textMoney.Text = "10000";
            this.textMoney.TextChanged += new System.EventHandler(this.textMoney_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Размер инвестиций:";
            // 
            // AlterIndexButton
            // 
            this.AlterIndexButton.Location = new System.Drawing.Point(81, 325);
            this.AlterIndexButton.Name = "AlterIndexButton";
            this.AlterIndexButton.Size = new System.Drawing.Size(75, 23);
            this.AlterIndexButton.TabIndex = 9;
            this.AlterIndexButton.Text = "Изменить";
            this.AlterIndexButton.UseVisualStyleBackColor = true;
            this.AlterIndexButton.Click += new System.EventHandler(this.AlterIndexButton_Click);
            // 
            // RemoveIndexButton
            // 
            this.RemoveIndexButton.Location = new System.Drawing.Point(46, 324);
            this.RemoveIndexButton.Name = "RemoveIndexButton";
            this.RemoveIndexButton.Size = new System.Drawing.Size(29, 23);
            this.RemoveIndexButton.TabIndex = 8;
            this.RemoveIndexButton.Text = "-";
            this.RemoveIndexButton.UseVisualStyleBackColor = true;
            this.RemoveIndexButton.Click += new System.EventHandler(this.RemoveIndexButton_Click);
            // 
            // CreateIndexButton
            // 
            this.CreateIndexButton.Location = new System.Drawing.Point(10, 323);
            this.CreateIndexButton.Name = "CreateIndexButton";
            this.CreateIndexButton.Size = new System.Drawing.Size(30, 25);
            this.CreateIndexButton.TabIndex = 7;
            this.CreateIndexButton.Text = "+";
            this.CreateIndexButton.UseVisualStyleBackColor = true;
            this.CreateIndexButton.Click += new System.EventHandler(this.CreateIndexButton_Click);
            // 
            // OptimizeButton
            // 
            this.OptimizeButton.Location = new System.Drawing.Point(448, 319);
            this.OptimizeButton.Name = "OptimizeButton";
            this.OptimizeButton.Size = new System.Drawing.Size(103, 28);
            this.OptimizeButton.TabIndex = 6;
            this.OptimizeButton.Text = "Оптимизировать";
            this.OptimizeButton.UseVisualStyleBackColor = true;
            this.OptimizeButton.Click += new System.EventHandler(this.OptimizeButton_Click);
            // 
            // AddIndexButton
            // 
            this.AddIndexButton.Location = new System.Drawing.Point(258, 146);
            this.AddIndexButton.Name = "AddIndexButton";
            this.AddIndexButton.Size = new System.Drawing.Size(33, 27);
            this.AddIndexButton.TabIndex = 5;
            this.AddIndexButton.Text = ">";
            this.AddIndexButton.UseVisualStyleBackColor = true;
            this.AddIndexButton.Click += new System.EventHandler(this.AddIndexButton_Click);
            // 
            // SelectedList
            // 
            this.SelectedList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader6});
            this.SelectedList.Location = new System.Drawing.Point(297, 30);
            this.SelectedList.Name = "SelectedList";
            this.SelectedList.Size = new System.Drawing.Size(362, 285);
            this.SelectedList.TabIndex = 4;
            this.SelectedList.UseCompatibleStateImageBehavior = false;
            this.SelectedList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Индекс";
            this.columnHeader1.Width = 183;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "%";
            // 
            // IndexList
            // 
            this.IndexList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem16,
            listViewItem17,
            listViewItem18,
            listViewItem19,
            listViewItem20});
            this.IndexList.Location = new System.Drawing.Point(8, 30);
            this.IndexList.Name = "IndexList";
            this.IndexList.Size = new System.Drawing.Size(244, 285);
            this.IndexList.TabIndex = 3;
            this.IndexList.UseCompatibleStateImageBehavior = false;
            this.IndexList.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выбранные индексы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список индексов и портфелей";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(3, 410);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1065, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1071, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Настройки";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OwnedOnly);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // OwnedOnly
            // 
            this.OwnedOnly.AutoSize = true;
            this.OwnedOnly.Checked = true;
            this.OwnedOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OwnedOnly.Location = new System.Drawing.Point(6, 19);
            this.OwnedOnly.Name = "OwnedOnly";
            this.OwnedOnly.Size = new System.Drawing.Size(156, 17);
            this.OwnedOnly.TabIndex = 0;
            this.OwnedOnly.Text = "Скрывать чужие индексы";
            this.OwnedOnly.UseVisualStyleBackColor = true;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "$";
            this.columnHeader6.Width = 71;
            // 
            // InvestmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 461);
            this.Controls.Add(this.InvestmentsTabs);
            this.Name = "InvestmentsForm";
            this.Text = "Управление портфелем";
            this.Shown += new System.EventHandler(this.Investments_Shown);
            this.InvestmentsTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl InvestmentsTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AlterIndexButton;
        private System.Windows.Forms.Button RemoveIndexButton;
        private System.Windows.Forms.Button CreateIndexButton;
        private System.Windows.Forms.Button OptimizeButton;
        private System.Windows.Forms.Button AddIndexButton;
        private System.Windows.Forms.ListView SelectedList;
        private System.Windows.Forms.ListView IndexList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox OwnedOnly;
        private System.Windows.Forms.TextBox textMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView FinishedList;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}