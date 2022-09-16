namespace PAR_P_Studio
{
    partial class Notebook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notebook));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сменаПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменаПользователяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripLoginLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripTip = new System.Windows.Forms.ToolStripStatusLabel();
            this.TextRtf = new System.Windows.Forms.RichTextBox();
            this.NotebookContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strikeoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextSizeBox = new System.Windows.Forms.NumericUpDown();
            this.DescrBoldButton = new System.Windows.Forms.ToolStripButton();
            this.DescrItalicButton = new System.Windows.Forms.ToolStripButton();
            this.DescrUnderlineButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AlignLeftButton = new System.Windows.Forms.ToolStripButton();
            this.AlignCenterButton = new System.Windows.Forms.ToolStripButton();
            this.AlignRightButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TextColorButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.DescrStrikeoutButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.DefaultFontButton = new System.Windows.Forms.ToolStripButton();
            this.FontButton = new System.Windows.Forms.ToolStripButton();
            this.SizeLabel = new System.Windows.Forms.ToolStripLabel();
            this.TextColorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.FormStatusStrip.SuspendLayout();
            this.NotebookContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextSizeBox)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменаПользователяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(610, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сменаПользователяToolStripMenuItem
            // 
            this.сменаПользователяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменаПользователяToolStripMenuItem1,
            this.закрытьToolStripMenuItem});
            this.сменаПользователяToolStripMenuItem.Name = "сменаПользователяToolStripMenuItem";
            this.сменаПользователяToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.сменаПользователяToolStripMenuItem.Text = "Система";
            // 
            // сменаПользователяToolStripMenuItem1
            // 
            this.сменаПользователяToolStripMenuItem1.Name = "сменаПользователяToolStripMenuItem1";
            this.сменаПользователяToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.сменаПользователяToolStripMenuItem1.Text = "Смена пользователя";
            this.сменаПользователяToolStripMenuItem1.Click += new System.EventHandler(this.сменаПользователяToolStripMenuItem1_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // FormStatusStrip
            // 
            this.FormStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLoginLabel,
            this.toolStripTip});
            this.FormStatusStrip.Location = new System.Drawing.Point(0, 372);
            this.FormStatusStrip.Name = "FormStatusStrip";
            this.FormStatusStrip.Size = new System.Drawing.Size(610, 22);
            this.FormStatusStrip.TabIndex = 2;
            this.FormStatusStrip.Text = "statusStrip1";
            // 
            // toolStripLoginLabel
            // 
            this.toolStripLoginLabel.Name = "toolStripLoginLabel";
            this.toolStripLoginLabel.Size = new System.Drawing.Size(41, 17);
            this.toolStripLoginLabel.Text = "Логин";
            this.toolStripLoginLabel.MouseLeave += new System.EventHandler(this.toolStripLoginLabel_MouseLeave);
            this.toolStripLoginLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripLoginLabel_MouseMove);
            // 
            // toolStripTip
            // 
            this.toolStripTip.Name = "toolStripTip";
            this.toolStripTip.Size = new System.Drawing.Size(69, 17);
            this.toolStripTip.Text = "toolStripTip";
            this.toolStripTip.MouseLeave += new System.EventHandler(this.toolStripTip_MouseLeave);
            this.toolStripTip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripTip_MouseMove);
            // 
            // TextRtf
            // 
            this.TextRtf.ContextMenuStrip = this.NotebookContextMenu;
            this.TextRtf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextRtf.Location = new System.Drawing.Point(0, 49);
            this.TextRtf.Name = "TextRtf";
            this.TextRtf.Size = new System.Drawing.Size(610, 323);
            this.TextRtf.TabIndex = 3;
            this.TextRtf.Text = "";
            this.TextRtf.SelectionChanged += new System.EventHandler(this.TextRtf_SelectionChanged);
            // 
            // NotebookContextMenu
            // 
            this.NotebookContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Copy,
            this.Paste,
            this.SelectAll,
            this.boldToolStripMenuItem,
            this.italicToolStripMenuItem,
            this.underlineToolStripMenuItem,
            this.strikeoutToolStripMenuItem});
            this.NotebookContextMenu.Name = "DescriptionTextContextMenu";
            this.NotebookContextMenu.Size = new System.Drawing.Size(168, 158);
            // 
            // Copy
            // 
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(167, 22);
            this.Copy.Text = "Копировать";
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Paste
            // 
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(167, 22);
            this.Paste.Text = "Вставить";
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // SelectAll
            // 
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.Size = new System.Drawing.Size(167, 22);
            this.SelectAll.Text = "Выделить все";
            this.SelectAll.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.boldToolStripMenuItem.Text = "Bold";
            this.boldToolStripMenuItem.Visible = false;
            this.boldToolStripMenuItem.Click += new System.EventHandler(this.boldToolStripMenuItem_Click);
            // 
            // italicToolStripMenuItem
            // 
            this.italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            this.italicToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.italicToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.italicToolStripMenuItem.Text = "Italic";
            this.italicToolStripMenuItem.Visible = false;
            this.italicToolStripMenuItem.Click += new System.EventHandler(this.italicToolStripMenuItem_Click);
            // 
            // underlineToolStripMenuItem
            // 
            this.underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            this.underlineToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.underlineToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.underlineToolStripMenuItem.Text = "Underline";
            this.underlineToolStripMenuItem.Visible = false;
            this.underlineToolStripMenuItem.Click += new System.EventHandler(this.underlineToolStripMenuItem_Click);
            // 
            // strikeoutToolStripMenuItem
            // 
            this.strikeoutToolStripMenuItem.Name = "strikeoutToolStripMenuItem";
            this.strikeoutToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.strikeoutToolStripMenuItem.Text = "Strikeout";
            this.strikeoutToolStripMenuItem.Visible = false;
            this.strikeoutToolStripMenuItem.Click += new System.EventHandler(this.strikeoutToolStripMenuItem_Click);
            // 
            // TextSizeBox
            // 
            this.TextSizeBox.Location = new System.Drawing.Point(361, 27);
            this.TextSizeBox.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.TextSizeBox.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.TextSizeBox.Name = "TextSizeBox";
            this.TextSizeBox.Size = new System.Drawing.Size(35, 20);
            this.TextSizeBox.TabIndex = 26;
            this.TextSizeBox.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.TextSizeBox.ValueChanged += new System.EventHandler(this.TextSizeBox_ValueChanged);
            this.TextSizeBox.Enter += new System.EventHandler(this.TextSizeBox_Enter);
            this.TextSizeBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextSizeBox_KeyDown);
            this.TextSizeBox.Leave += new System.EventHandler(this.TextSizeBox_Leave);
            // 
            // DescrBoldButton
            // 
            this.DescrBoldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DescrBoldButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.DescrBoldButton.Image = ((System.Drawing.Image)(resources.GetObject("DescrBoldButton.Image")));
            this.DescrBoldButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DescrBoldButton.Name = "DescrBoldButton";
            this.DescrBoldButton.Size = new System.Drawing.Size(23, 22);
            this.DescrBoldButton.Text = "B";
            this.DescrBoldButton.Click += new System.EventHandler(this.DescrBoldButton_Click);
            this.DescrBoldButton.MouseLeave += new System.EventHandler(this.DescrBoldButton_MouseLeave);
            this.DescrBoldButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DescrBoldButton_MouseMove);
            // 
            // DescrItalicButton
            // 
            this.DescrItalicButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DescrItalicButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.DescrItalicButton.Image = ((System.Drawing.Image)(resources.GetObject("DescrItalicButton.Image")));
            this.DescrItalicButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DescrItalicButton.Name = "DescrItalicButton";
            this.DescrItalicButton.Size = new System.Drawing.Size(23, 22);
            this.DescrItalicButton.Text = "I";
            this.DescrItalicButton.Click += new System.EventHandler(this.DescrItalicButton_Click);
            this.DescrItalicButton.MouseLeave += new System.EventHandler(this.DescrItalicButton_MouseLeave);
            this.DescrItalicButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DescrItalicButton_MouseMove);
            // 
            // DescrUnderlineButton
            // 
            this.DescrUnderlineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DescrUnderlineButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.DescrUnderlineButton.Image = ((System.Drawing.Image)(resources.GetObject("DescrUnderlineButton.Image")));
            this.DescrUnderlineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DescrUnderlineButton.Name = "DescrUnderlineButton";
            this.DescrUnderlineButton.Size = new System.Drawing.Size(23, 22);
            this.DescrUnderlineButton.Text = "U";
            this.DescrUnderlineButton.Click += new System.EventHandler(this.DescrUnderlineButton_Click);
            this.DescrUnderlineButton.MouseLeave += new System.EventHandler(this.DescrUnderlineButton_MouseLeave);
            this.DescrUnderlineButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DescrUnderlineButton_MouseMove);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // AlignLeftButton
            // 
            this.AlignLeftButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AlignLeftButton.Image = ((System.Drawing.Image)(resources.GetObject("AlignLeftButton.Image")));
            this.AlignLeftButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AlignLeftButton.Name = "AlignLeftButton";
            this.AlignLeftButton.Size = new System.Drawing.Size(23, 22);
            this.AlignLeftButton.Text = "L";
            this.AlignLeftButton.Click += new System.EventHandler(this.AlignLeftButton_Click);
            this.AlignLeftButton.MouseLeave += new System.EventHandler(this.AlignLeftButton_MouseLeave);
            this.AlignLeftButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AlignLeftButton_MouseMove);
            // 
            // AlignCenterButton
            // 
            this.AlignCenterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AlignCenterButton.Image = ((System.Drawing.Image)(resources.GetObject("AlignCenterButton.Image")));
            this.AlignCenterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AlignCenterButton.Name = "AlignCenterButton";
            this.AlignCenterButton.Size = new System.Drawing.Size(23, 22);
            this.AlignCenterButton.Text = "C";
            this.AlignCenterButton.Click += new System.EventHandler(this.AlignCenterButton_Click);
            this.AlignCenterButton.MouseLeave += new System.EventHandler(this.AlignCenterButton_MouseLeave);
            this.AlignCenterButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AlignCenterButton_MouseMove);
            // 
            // AlignRightButton
            // 
            this.AlignRightButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AlignRightButton.Image = ((System.Drawing.Image)(resources.GetObject("AlignRightButton.Image")));
            this.AlignRightButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AlignRightButton.Name = "AlignRightButton";
            this.AlignRightButton.Size = new System.Drawing.Size(23, 22);
            this.AlignRightButton.Text = "R";
            this.AlignRightButton.Click += new System.EventHandler(this.AlignRightButton_Click);
            this.AlignRightButton.MouseLeave += new System.EventHandler(this.AlignRightButton_MouseLeave);
            this.AlignRightButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AlignRightButton_MouseMove);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // TextColorButton
            // 
            this.TextColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TextColorButton.Image = ((System.Drawing.Image)(resources.GetObject("TextColorButton.Image")));
            this.TextColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TextColorButton.Name = "TextColorButton";
            this.TextColorButton.Size = new System.Drawing.Size(23, 22);
            this.TextColorButton.Text = "A";
            this.TextColorButton.Click += new System.EventHandler(this.TextColorButton_Click);
            this.TextColorButton.MouseLeave += new System.EventHandler(this.TextColorButton_MouseLeave);
            this.TextColorButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TextColorButton_MouseMove);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DescrBoldButton,
            this.DescrItalicButton,
            this.DescrUnderlineButton,
            this.DescrStrikeoutButton,
            this.toolStripSeparator1,
            this.AlignLeftButton,
            this.AlignCenterButton,
            this.AlignRightButton,
            this.toolStripSeparator2,
            this.TextColorButton,
            this.toolStripSeparator3,
            this.DefaultFontButton,
            this.FontButton,
            this.SizeLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(610, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // DescrStrikeoutButton
            // 
            this.DescrStrikeoutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DescrStrikeoutButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Strikeout);
            this.DescrStrikeoutButton.Image = ((System.Drawing.Image)(resources.GetObject("DescrStrikeoutButton.Image")));
            this.DescrStrikeoutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DescrStrikeoutButton.Name = "DescrStrikeoutButton";
            this.DescrStrikeoutButton.Size = new System.Drawing.Size(23, 22);
            this.DescrStrikeoutButton.Text = "S";
            this.DescrStrikeoutButton.Click += new System.EventHandler(this.DescrStrikeoutButton_Click);
            this.DescrStrikeoutButton.MouseLeave += new System.EventHandler(this.DescrStrikeoutButton_MouseLeave);
            this.DescrStrikeoutButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DescrStrikeoutButton_MouseMove);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // DefaultFontButton
            // 
            this.DefaultFontButton.Image = ((System.Drawing.Image)(resources.GetObject("DefaultFontButton.Image")));
            this.DefaultFontButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DefaultFontButton.Name = "DefaultFontButton";
            this.DefaultFontButton.Size = new System.Drawing.Size(110, 22);
            this.DefaultFontButton.Text = "Сброс шрифта";
            this.DefaultFontButton.Click += new System.EventHandler(this.DefaultFontButton_Click);
            this.DefaultFontButton.MouseLeave += new System.EventHandler(this.DefaultFontButton_MouseLeave);
            this.DefaultFontButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DefaultFontButton_MouseMove);
            // 
            // FontButton
            // 
            this.FontButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FontButton.Image = ((System.Drawing.Image)(resources.GetObject("FontButton.Image")));
            this.FontButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FontButton.Name = "FontButton";
            this.FontButton.Size = new System.Drawing.Size(23, 22);
            this.FontButton.Text = "F";
            this.FontButton.Click += new System.EventHandler(this.FontButton_Click);
            this.FontButton.MouseLeave += new System.EventHandler(this.FontButton_MouseLeave);
            this.FontButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FontButton_MouseMove);
            // 
            // SizeLabel
            // 
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(13, 22);
            this.SizeLabel.Text = "0";
            this.SizeLabel.MouseLeave += new System.EventHandler(this.SizeLabel_MouseLeave);
            this.SizeLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SizeLabel_MouseMove);
            // 
            // Notebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 394);
            this.Controls.Add(this.TextSizeBox);
            this.Controls.Add(this.TextRtf);
            this.Controls.Add(this.FormStatusStrip);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Notebook";
            this.ShowInTaskbar = false;
            this.Text = "Notebook";
            this.Shown += new System.EventHandler(this.Notebook_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.FormStatusStrip.ResumeLayout(false);
            this.FormStatusStrip.PerformLayout();
            this.NotebookContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TextSizeBox)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip FormStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem сменаПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменаПользователяToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        public System.Windows.Forms.RichTextBox TextRtf;
        private System.Windows.Forms.ContextMenuStrip NotebookContextMenu;
        private System.Windows.Forms.ToolStripMenuItem Copy;
        private System.Windows.Forms.ToolStripMenuItem Paste;
        private System.Windows.Forms.ToolStripMenuItem SelectAll;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strikeoutToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown TextSizeBox;
        private System.Windows.Forms.ToolStripButton DescrBoldButton;
        private System.Windows.Forms.ToolStripButton DescrItalicButton;
        private System.Windows.Forms.ToolStripButton DescrUnderlineButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton AlignLeftButton;
        private System.Windows.Forms.ToolStripButton AlignCenterButton;
        private System.Windows.Forms.ToolStripButton AlignRightButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TextColorButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton DescrStrikeoutButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel SizeLabel;
        private System.Windows.Forms.ColorDialog TextColorDialog;
        private System.Windows.Forms.ToolStripButton FontButton;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ToolStripButton DefaultFontButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLoginLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripTip;
    }
}