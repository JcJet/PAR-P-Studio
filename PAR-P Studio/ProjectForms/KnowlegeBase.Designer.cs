namespace PAR_P_Studio.ProjectForms
{
    partial class KnowlegeBase
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KnowlegeBase));
            this.SelectionGroup = new System.Windows.Forms.GroupBox();
            this.ArticleList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DisplayGroup = new System.Windows.Forms.GroupBox();
            this.DispRtf = new System.Windows.Forms.RichTextBox();
            this.DispTextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SelectionGroup.SuspendLayout();
            this.DisplayGroup.SuspendLayout();
            this.DispTextMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectionGroup
            // 
            this.SelectionGroup.Controls.Add(this.ArticleList);
            this.SelectionGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectionGroup.Location = new System.Drawing.Point(3, 3);
            this.SelectionGroup.Name = "SelectionGroup";
            this.SelectionGroup.Size = new System.Drawing.Size(199, 319);
            this.SelectionGroup.TabIndex = 0;
            this.SelectionGroup.TabStop = false;
            this.SelectionGroup.Text = "Содержание";
            // 
            // ArticleList
            // 
            this.ArticleList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.ArticleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArticleList.Location = new System.Drawing.Point(3, 16);
            this.ArticleList.Name = "ArticleList";
            this.ArticleList.Size = new System.Drawing.Size(193, 300);
            this.ArticleList.TabIndex = 0;
            this.ArticleList.UseCompatibleStateImageBehavior = false;
            this.ArticleList.View = System.Windows.Forms.View.Details;
            this.ArticleList.SelectedIndexChanged += new System.EventHandler(this.ArticleList_SelectedIndexChanged);
            this.ArticleList.SizeChanged += new System.EventHandler(this.ArticleList_SizeChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = " ";
            this.columnHeader1.Width = 192;
            // 
            // DisplayGroup
            // 
            this.DisplayGroup.Controls.Add(this.DispRtf);
            this.DisplayGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayGroup.Location = new System.Drawing.Point(208, 3);
            this.DisplayGroup.Name = "DisplayGroup";
            this.DisplayGroup.Size = new System.Drawing.Size(475, 319);
            this.DisplayGroup.TabIndex = 1;
            this.DisplayGroup.TabStop = false;
            this.DisplayGroup.Text = "Выбранная статья";
            // 
            // DispRtf
            // 
            this.DispRtf.ContextMenuStrip = this.DispTextMenu;
            this.DispRtf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DispRtf.Location = new System.Drawing.Point(3, 16);
            this.DispRtf.Name = "DispRtf";
            this.DispRtf.ReadOnly = true;
            this.DispRtf.Size = new System.Drawing.Size(469, 300);
            this.DispRtf.TabIndex = 0;
            this.DispRtf.Text = "";
            // 
            // DispTextMenu
            // 
            this.DispTextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.выделитьВсеToolStripMenuItem});
            this.DispTextMenu.Name = "DispTextMenu";
            this.DispTextMenu.Size = new System.Drawing.Size(149, 48);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // выделитьВсеToolStripMenuItem
            // 
            this.выделитьВсеToolStripMenuItem.Name = "выделитьВсеToolStripMenuItem";
            this.выделитьВсеToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.выделитьВсеToolStripMenuItem.Text = "Выделить все";
            this.выделитьВсеToolStripMenuItem.Click += new System.EventHandler(this.выделитьВсеToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.SelectionGroup, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DisplayGroup, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(686, 325);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // KnowlegeBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 325);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KnowlegeBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KnowlegeBase";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.KnowlegeBase_Shown);
            this.SelectionGroup.ResumeLayout(false);
            this.DisplayGroup.ResumeLayout(false);
            this.DispTextMenu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox SelectionGroup;
        public System.Windows.Forms.ListView ArticleList;
        public System.Windows.Forms.GroupBox DisplayGroup;
        public System.Windows.Forms.RichTextBox DispRtf;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ContextMenuStrip DispTextMenu;
        public System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem выделитьВсеToolStripMenuItem;

    }
}