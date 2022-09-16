namespace PAR_P_Studio
{
    partial class TypeDesigner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypeDesigner));
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редакторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяПозицияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SnapToGridBox = new System.Windows.Forms.ToolStripMenuItem();
            this.DragAllBox = new System.Windows.Forms.ToolStripMenuItem();
            this.поворотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RotationPlus = new System.Windows.Forms.ToolStripMenuItem();
            this.RotationMinus = new System.Windows.Forms.ToolStripMenuItem();
            this.NumberPlus = new System.Windows.Forms.ToolStripMenuItem();
            this.NumberMinus = new System.Windows.Forms.ToolStripMenuItem();
            this.NumberPositionPlus = new System.Windows.Forms.ToolStripMenuItem();
            this.DesignerTabs = new System.Windows.Forms.TabControl();
            this.DesignerTab = new System.Windows.Forms.TabPage();
            this.MiscTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.PosDescription = new System.Windows.Forms.TextBox();
            this.PositionSelectBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.RichTextBox();
            this.DescriptionTextContexmMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strikeoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.DescrStrikeoutButton = new System.Windows.Forms.Button();
            this.DescrUnderlineButton = new System.Windows.Forms.Button();
            this.DescrItalicButton = new System.Windows.Forms.Button();
            this.DescrBoldButton = new System.Windows.Forms.Button();
            this.TextSizeBox = new System.Windows.Forms.NumericUpDown();
            this.AlignRightButton = new System.Windows.Forms.Button();
            this.AlignCenterButton = new System.Windows.Forms.Button();
            this.AlignLeftButton = new System.Windows.Forms.Button();
            this.TextColorButton = new System.Windows.Forms.Button();
            this.FontButton = new System.Windows.Forms.Button();
            this.NullOwnerBox = new System.Windows.Forms.CheckBox();
            this.TextColorDialog = new System.Windows.Forms.ColorDialog();
            this.descrFontDialog = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.DesignerTabs.SuspendLayout();
            this.DesignerTab.SuspendLayout();
            this.MiscTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.DescriptionTextContexmMenu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextSizeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawingPanel.Location = new System.Drawing.Point(3, 3);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(438, 327);
            this.DrawingPanel.TabIndex = 0;
            this.DrawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPanel_Paint);
            this.DrawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseDown);
            this.DrawingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseMove);
            this.DrawingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.редакторToolStripMenuItem,
            this.поворотToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(452, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.новыйToolStripMenuItem.Text = "Новый";
            this.новыйToolStripMenuItem.Click += new System.EventHandler(this.новыйToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // редакторToolStripMenuItem
            // 
            this.редакторToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяПозицияToolStripMenuItem,
            this.DelItem,
            this.SnapToGridBox,
            this.DragAllBox});
            this.редакторToolStripMenuItem.Name = "редакторToolStripMenuItem";
            this.редакторToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.редакторToolStripMenuItem.Text = "Редактор";
            // 
            // новаяПозицияToolStripMenuItem
            // 
            this.новаяПозицияToolStripMenuItem.Name = "новаяПозицияToolStripMenuItem";
            this.новаяПозицияToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.новаяПозицияToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.новаяПозицияToolStripMenuItem.Text = "Новая позиция";
            this.новаяПозицияToolStripMenuItem.Click += new System.EventHandler(this.новаяПозицияToolStripMenuItem_Click);
            // 
            // DelItem
            // 
            this.DelItem.Name = "DelItem";
            this.DelItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DelItem.Size = new System.Drawing.Size(204, 22);
            this.DelItem.Text = "Удалить элемент";
            this.DelItem.Click += new System.EventHandler(this.DelItem_Click);
            // 
            // SnapToGridBox
            // 
            this.SnapToGridBox.Checked = true;
            this.SnapToGridBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SnapToGridBox.Name = "SnapToGridBox";
            this.SnapToGridBox.Size = new System.Drawing.Size(204, 22);
            this.SnapToGridBox.Text = "Выравнивание по сетке";
            this.SnapToGridBox.Click += new System.EventHandler(this.SnapToGridBox_Click);
            // 
            // DragAllBox
            // 
            this.DragAllBox.Name = "DragAllBox";
            this.DragAllBox.Size = new System.Drawing.Size(204, 22);
            this.DragAllBox.Text = "Перемещать все";
            this.DragAllBox.Click += new System.EventHandler(this.DragAllBox_Click);
            // 
            // поворотToolStripMenuItem
            // 
            this.поворотToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RotationPlus,
            this.RotationMinus,
            this.NumberPlus,
            this.NumberMinus,
            this.NumberPositionPlus});
            this.поворотToolStripMenuItem.Name = "поворотToolStripMenuItem";
            this.поворотToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.поворотToolStripMenuItem.Text = "Элемент";
            // 
            // RotationPlus
            // 
            this.RotationPlus.Name = "RotationPlus";
            this.RotationPlus.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.RotationPlus.Size = new System.Drawing.Size(275, 22);
            this.RotationPlus.Text = "Поворот по часовой стрелке";
            this.RotationPlus.Click += new System.EventHandler(this.RotationPlus_Click);
            // 
            // RotationMinus
            // 
            this.RotationMinus.Name = "RotationMinus";
            this.RotationMinus.Size = new System.Drawing.Size(275, 22);
            this.RotationMinus.Text = "Поворот против часовой стрелки";
            this.RotationMinus.Click += new System.EventHandler(this.RotationMinus_Click);
            // 
            // NumberPlus
            // 
            this.NumberPlus.Name = "NumberPlus";
            this.NumberPlus.ShortcutKeyDisplayString = "Ctrl+Plus";
            this.NumberPlus.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.NumberPlus.Size = new System.Drawing.Size(275, 22);
            this.NumberPlus.Text = "Увеличить номер";
            this.NumberPlus.Click += new System.EventHandler(this.NumberPlus_Click);
            // 
            // NumberMinus
            // 
            this.NumberMinus.Name = "NumberMinus";
            this.NumberMinus.ShortcutKeyDisplayString = "Ctrl+Minus";
            this.NumberMinus.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.NumberMinus.Size = new System.Drawing.Size(275, 22);
            this.NumberMinus.Text = "Уменьшить номер";
            this.NumberMinus.Click += new System.EventHandler(this.NumberMinus_Click);
            // 
            // NumberPositionPlus
            // 
            this.NumberPositionPlus.Name = "NumberPositionPlus";
            this.NumberPositionPlus.Size = new System.Drawing.Size(275, 22);
            this.NumberPositionPlus.Text = "Позиция номера";
            this.NumberPositionPlus.Click += new System.EventHandler(this.NumberPositionPlus_Click);
            // 
            // DesignerTabs
            // 
            this.DesignerTabs.Controls.Add(this.DesignerTab);
            this.DesignerTabs.Controls.Add(this.MiscTab);
            this.DesignerTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesignerTabs.Location = new System.Drawing.Point(0, 24);
            this.DesignerTabs.Name = "DesignerTabs";
            this.DesignerTabs.SelectedIndex = 0;
            this.DesignerTabs.Size = new System.Drawing.Size(452, 359);
            this.DesignerTabs.TabIndex = 0;
            // 
            // DesignerTab
            // 
            this.DesignerTab.BackColor = System.Drawing.Color.LightGray;
            this.DesignerTab.Controls.Add(this.DrawingPanel);
            this.DesignerTab.Location = new System.Drawing.Point(4, 22);
            this.DesignerTab.Name = "DesignerTab";
            this.DesignerTab.Padding = new System.Windows.Forms.Padding(3);
            this.DesignerTab.Size = new System.Drawing.Size(444, 333);
            this.DesignerTab.TabIndex = 0;
            this.DesignerTab.Text = "Рисование";
            // 
            // MiscTab
            // 
            this.MiscTab.BackColor = System.Drawing.Color.LightGray;
            this.MiscTab.Controls.Add(this.tableLayoutPanel1);
            this.MiscTab.Location = new System.Drawing.Point(4, 22);
            this.MiscTab.Name = "MiscTab";
            this.MiscTab.Padding = new System.Windows.Forms.Padding(3);
            this.MiscTab.Size = new System.Drawing.Size(444, 333);
            this.MiscTab.TabIndex = 1;
            this.MiscTab.Text = "Описание";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.85714F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.14286F));
            this.tableLayoutPanel1.Controls.Add(this.NameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DescriptionLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PosDescription, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.PositionSelectBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textDescription, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.NullOwnerBox, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(438, 327);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(5, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(57, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Название";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(5, 20);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(57, 13);
            this.DescriptionLabel.TabIndex = 1;
            this.DescriptionLabel.Text = "Описание";
            // 
            // textName
            // 
            this.textName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textName.Location = new System.Drawing.Point(68, 3);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(367, 20);
            this.textName.TabIndex = 0;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            this.textName.Leave += new System.EventHandler(this.textName_Leave);
            // 
            // PosDescription
            // 
            this.PosDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PosDescription.Enabled = false;
            this.PosDescription.Location = new System.Drawing.Point(68, 251);
            this.PosDescription.Multiline = true;
            this.PosDescription.Name = "PosDescription";
            this.PosDescription.Size = new System.Drawing.Size(367, 45);
            this.PosDescription.TabIndex = 3;
            this.PosDescription.Click += new System.EventHandler(this.PosDescription_Click);
            this.PosDescription.TextChanged += new System.EventHandler(this.PosDescription_TextChanged);
            this.PosDescription.Leave += new System.EventHandler(this.PosDescription_Leave);
            // 
            // PositionSelectBox
            // 
            this.PositionSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PositionSelectBox.FormattingEnabled = true;
            this.PositionSelectBox.Location = new System.Drawing.Point(68, 222);
            this.PositionSelectBox.Name = "PositionSelectBox";
            this.PositionSelectBox.Size = new System.Drawing.Size(121, 21);
            this.PositionSelectBox.TabIndex = 2;
            this.PositionSelectBox.SelectedIndexChanged += new System.EventHandler(this.PositionSelectBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Значения карт";
            // 
            // textDescription
            // 
            this.textDescription.ContextMenuStrip = this.DescriptionTextContexmMenu;
            this.textDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textDescription.Location = new System.Drawing.Point(68, 23);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(367, 164);
            this.textDescription.TabIndex = 1;
            this.textDescription.Text = "";
            this.textDescription.TextChanged += new System.EventHandler(this.textDescription_TextChanged);
            // 
            // DescriptionTextContexmMenu
            // 
            this.DescriptionTextContexmMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.вставитьToolStripMenuItem,
            this.выделитьВсеToolStripMenuItem,
            this.italicToolStripMenuItem,
            this.boldToolStripMenuItem,
            this.strikeoutToolStripMenuItem,
            this.underlineToolStripMenuItem});
            this.DescriptionTextContexmMenu.Name = "DescriptionTextContexmMenu";
            this.DescriptionTextContexmMenu.Size = new System.Drawing.Size(149, 158);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem1.Text = "Копировать";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // выделитьВсеToolStripMenuItem
            // 
            this.выделитьВсеToolStripMenuItem.Name = "выделитьВсеToolStripMenuItem";
            this.выделитьВсеToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.выделитьВсеToolStripMenuItem.Text = "Выделить все";
            this.выделитьВсеToolStripMenuItem.Click += new System.EventHandler(this.выделитьВсеToolStripMenuItem_Click);
            // 
            // italicToolStripMenuItem
            // 
            this.italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            this.italicToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.italicToolStripMenuItem.Text = "italic";
            this.italicToolStripMenuItem.Visible = false;
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.boldToolStripMenuItem.Text = "bold";
            this.boldToolStripMenuItem.Visible = false;
            // 
            // strikeoutToolStripMenuItem
            // 
            this.strikeoutToolStripMenuItem.Name = "strikeoutToolStripMenuItem";
            this.strikeoutToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.strikeoutToolStripMenuItem.Text = "strikeout";
            this.strikeoutToolStripMenuItem.Visible = false;
            // 
            // underlineToolStripMenuItem
            // 
            this.underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            this.underlineToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.underlineToolStripMenuItem.Text = "underline";
            this.underlineToolStripMenuItem.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.DescrStrikeoutButton);
            this.flowLayoutPanel1.Controls.Add(this.DescrUnderlineButton);
            this.flowLayoutPanel1.Controls.Add(this.DescrItalicButton);
            this.flowLayoutPanel1.Controls.Add(this.DescrBoldButton);
            this.flowLayoutPanel1.Controls.Add(this.TextSizeBox);
            this.flowLayoutPanel1.Controls.Add(this.AlignRightButton);
            this.flowLayoutPanel1.Controls.Add(this.AlignCenterButton);
            this.flowLayoutPanel1.Controls.Add(this.AlignLeftButton);
            this.flowLayoutPanel1.Controls.Add(this.TextColorButton);
            this.flowLayoutPanel1.Controls.Add(this.FontButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(68, 193);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(357, 23);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // DescrStrikeoutButton
            // 
            this.DescrStrikeoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescrStrikeoutButton.Location = new System.Drawing.Point(3, 3);
            this.DescrStrikeoutButton.Name = "DescrStrikeoutButton";
            this.DescrStrikeoutButton.Size = new System.Drawing.Size(26, 22);
            this.DescrStrikeoutButton.TabIndex = 30;
            this.DescrStrikeoutButton.Text = "S";
            this.DescrStrikeoutButton.UseVisualStyleBackColor = true;
            this.DescrStrikeoutButton.Click += new System.EventHandler(this.DescrStrikeoutButton_Click);
            // 
            // DescrUnderlineButton
            // 
            this.DescrUnderlineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescrUnderlineButton.Location = new System.Drawing.Point(35, 3);
            this.DescrUnderlineButton.Name = "DescrUnderlineButton";
            this.DescrUnderlineButton.Size = new System.Drawing.Size(26, 22);
            this.DescrUnderlineButton.TabIndex = 31;
            this.DescrUnderlineButton.Text = "U";
            this.DescrUnderlineButton.UseVisualStyleBackColor = true;
            this.DescrUnderlineButton.Click += new System.EventHandler(this.DescrUnderlineButton_Click);
            // 
            // DescrItalicButton
            // 
            this.DescrItalicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescrItalicButton.Location = new System.Drawing.Point(67, 3);
            this.DescrItalicButton.Name = "DescrItalicButton";
            this.DescrItalicButton.Size = new System.Drawing.Size(26, 22);
            this.DescrItalicButton.TabIndex = 32;
            this.DescrItalicButton.Text = "I";
            this.DescrItalicButton.UseVisualStyleBackColor = true;
            this.DescrItalicButton.Click += new System.EventHandler(this.DescrItalicButton_Click);
            // 
            // DescrBoldButton
            // 
            this.DescrBoldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescrBoldButton.Location = new System.Drawing.Point(99, 3);
            this.DescrBoldButton.Name = "DescrBoldButton";
            this.DescrBoldButton.Size = new System.Drawing.Size(26, 22);
            this.DescrBoldButton.TabIndex = 29;
            this.DescrBoldButton.Text = "B";
            this.DescrBoldButton.UseVisualStyleBackColor = true;
            this.DescrBoldButton.Click += new System.EventHandler(this.DescrBoldButton_Click);
            // 
            // TextSizeBox
            // 
            this.TextSizeBox.Location = new System.Drawing.Point(131, 3);
            this.TextSizeBox.Maximum = new decimal(new int[] {
            71,
            0,
            0,
            0});
            this.TextSizeBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TextSizeBox.Name = "TextSizeBox";
            this.TextSizeBox.Size = new System.Drawing.Size(42, 20);
            this.TextSizeBox.TabIndex = 28;
            this.TextSizeBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TextSizeBox.ValueChanged += new System.EventHandler(this.TextSizeBox_ValueChanged);
            // 
            // AlignRightButton
            // 
            this.AlignRightButton.Location = new System.Drawing.Point(179, 3);
            this.AlignRightButton.Name = "AlignRightButton";
            this.AlignRightButton.Size = new System.Drawing.Size(26, 22);
            this.AlignRightButton.TabIndex = 35;
            this.AlignRightButton.Text = "R";
            this.AlignRightButton.UseVisualStyleBackColor = true;
            this.AlignRightButton.Click += new System.EventHandler(this.AlignRightButton_Click);
            // 
            // AlignCenterButton
            // 
            this.AlignCenterButton.Location = new System.Drawing.Point(211, 3);
            this.AlignCenterButton.Name = "AlignCenterButton";
            this.AlignCenterButton.Size = new System.Drawing.Size(26, 22);
            this.AlignCenterButton.TabIndex = 34;
            this.AlignCenterButton.Text = "C";
            this.AlignCenterButton.UseVisualStyleBackColor = true;
            this.AlignCenterButton.Click += new System.EventHandler(this.AlignCenterButton_Click);
            // 
            // AlignLeftButton
            // 
            this.AlignLeftButton.Location = new System.Drawing.Point(243, 3);
            this.AlignLeftButton.Name = "AlignLeftButton";
            this.AlignLeftButton.Size = new System.Drawing.Size(26, 22);
            this.AlignLeftButton.TabIndex = 33;
            this.AlignLeftButton.Text = "L";
            this.AlignLeftButton.UseVisualStyleBackColor = true;
            this.AlignLeftButton.Click += new System.EventHandler(this.AlignLeftButton_Click);
            // 
            // TextColorButton
            // 
            this.TextColorButton.Location = new System.Drawing.Point(275, 3);
            this.TextColorButton.Name = "TextColorButton";
            this.TextColorButton.Size = new System.Drawing.Size(25, 23);
            this.TextColorButton.TabIndex = 36;
            this.TextColorButton.Text = "А";
            this.TextColorButton.UseVisualStyleBackColor = true;
            this.TextColorButton.Click += new System.EventHandler(this.TextColorButton_Click);
            // 
            // FontButton
            // 
            this.FontButton.Location = new System.Drawing.Point(306, 3);
            this.FontButton.Name = "FontButton";
            this.FontButton.Size = new System.Drawing.Size(25, 23);
            this.FontButton.TabIndex = 37;
            this.FontButton.Text = "F";
            this.FontButton.UseVisualStyleBackColor = true;
            this.FontButton.Click += new System.EventHandler(this.FontButton_Click);
            // 
            // NullOwnerBox
            // 
            this.NullOwnerBox.AutoSize = true;
            this.NullOwnerBox.Location = new System.Drawing.Point(68, 302);
            this.NullOwnerBox.Name = "NullOwnerBox";
            this.NullOwnerBox.Size = new System.Drawing.Size(211, 17);
            this.NullOwnerBox.TabIndex = 9;
            this.NullOwnerBox.Text = "Доступен для редактирования всем";
            this.NullOwnerBox.UseVisualStyleBackColor = true;
            this.NullOwnerBox.CheckedChanged += new System.EventHandler(this.NullOwnerBox_CheckedChanged);
            // 
            // TypeDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 383);
            this.Controls.Add(this.DesignerTabs);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TypeDesigner";
            this.ShowInTaskbar = false;
            this.Text = "Редактор расклада";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TypeDesigner_FormClosing);
            this.Shown += new System.EventHandler(this.TypeDesigner_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.DesignerTabs.ResumeLayout(false);
            this.DesignerTab.ResumeLayout(false);
            this.MiscTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.DescriptionTextContexmMenu.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TextSizeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редакторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаяПозицияToolStripMenuItem;
        private System.Windows.Forms.TabControl DesignerTabs;
        private System.Windows.Forms.TabPage DesignerTab;
        private System.Windows.Forms.TabPage MiscTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PositionSelectBox;
        private System.Windows.Forms.TextBox PosDescription;
        private System.Windows.Forms.ToolStripMenuItem поворотToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RotationPlus;
        private System.Windows.Forms.ToolStripMenuItem RotationMinus;
        private System.Windows.Forms.RichTextBox textDescription;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button DescrStrikeoutButton;
        private System.Windows.Forms.Button DescrUnderlineButton;
        private System.Windows.Forms.Button DescrItalicButton;
        private System.Windows.Forms.Button DescrBoldButton;
        private System.Windows.Forms.NumericUpDown TextSizeBox;
        private System.Windows.Forms.Button AlignRightButton;
        private System.Windows.Forms.Button AlignCenterButton;
        private System.Windows.Forms.Button AlignLeftButton;
        private System.Windows.Forms.Button TextColorButton;
        private System.Windows.Forms.ColorDialog TextColorDialog;
        private System.Windows.Forms.ToolStripMenuItem SnapToGridBox;
        private System.Windows.Forms.ToolStripMenuItem NumberPlus;
        private System.Windows.Forms.ToolStripMenuItem NumberMinus;
        private System.Windows.Forms.ToolStripMenuItem NumberPositionPlus;
        private System.Windows.Forms.ToolStripMenuItem DelItem;
        private System.Windows.Forms.ToolStripMenuItem DragAllBox;
        private System.Windows.Forms.ContextMenuStrip DescriptionTextContexmMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strikeoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underlineToolStripMenuItem;
        private System.Windows.Forms.CheckBox NullOwnerBox;
        private System.Windows.Forms.Button FontButton;
        private System.Windows.Forms.FontDialog descrFontDialog;
    }
}