namespace PAR_P_Studio.ProjectForms
{
    partial class DeckComparer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeckComparer));
            this.LeftDeckBox = new System.Windows.Forms.GroupBox();
            this.LeftSyncBox = new System.Windows.Forms.CheckBox();
            this.LeftBackButton = new System.Windows.Forms.Button();
            this.LeftLogoButton = new System.Windows.Forms.Button();
            this.LeftTabs = new System.Windows.Forms.TabControl();
            this.LeftPictureTab = new System.Windows.Forms.TabPage();
            this.LeftPictureBox = new System.Windows.Forms.PictureBox();
            this.LeftDescriptionTab = new System.Windows.Forms.TabPage();
            this.LeftDescriptionText = new System.Windows.Forms.RichTextBox();
            this.LeftCardName = new System.Windows.Forms.Label();
            this.LeftEqualButton = new System.Windows.Forms.Button();
            this.LeftCardSelector = new System.Windows.Forms.NumericUpDown();
            this.LeftSelectedCardLabel = new System.Windows.Forms.Label();
            this.LeftDeckSelectionBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RightDeckBox = new System.Windows.Forms.GroupBox();
            this.RightSyncBox = new System.Windows.Forms.CheckBox();
            this.RightLogoButton = new System.Windows.Forms.Button();
            this.RightBackButton = new System.Windows.Forms.Button();
            this.RightTabs = new System.Windows.Forms.TabControl();
            this.RightPictureTab = new System.Windows.Forms.TabPage();
            this.RightPictureBox = new System.Windows.Forms.PictureBox();
            this.RightDescriptionTab = new System.Windows.Forms.TabPage();
            this.RightDescriptionText = new System.Windows.Forms.RichTextBox();
            this.RightCardName = new System.Windows.Forms.Label();
            this.RightEqualButton = new System.Windows.Forms.Button();
            this.RightCardSelector = new System.Windows.Forms.NumericUpDown();
            this.RightSelectedCardLabel = new System.Windows.Forms.Label();
            this.RightDeckSelectionBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FormStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripLoginLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripTip = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DeckComparerHelp = new System.Windows.Forms.LinkLabel();
            this.LeftDeckBox.SuspendLayout();
            this.LeftTabs.SuspendLayout();
            this.LeftPictureTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPictureBox)).BeginInit();
            this.LeftDescriptionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftCardSelector)).BeginInit();
            this.RightDeckBox.SuspendLayout();
            this.RightTabs.SuspendLayout();
            this.RightPictureTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightPictureBox)).BeginInit();
            this.RightDescriptionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightCardSelector)).BeginInit();
            this.FormStatusStrip.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftDeckBox
            // 
            this.LeftDeckBox.Controls.Add(this.LeftSyncBox);
            this.LeftDeckBox.Controls.Add(this.LeftBackButton);
            this.LeftDeckBox.Controls.Add(this.LeftLogoButton);
            this.LeftDeckBox.Controls.Add(this.LeftTabs);
            this.LeftDeckBox.Controls.Add(this.LeftCardName);
            this.LeftDeckBox.Controls.Add(this.LeftEqualButton);
            this.LeftDeckBox.Controls.Add(this.LeftCardSelector);
            this.LeftDeckBox.Controls.Add(this.LeftSelectedCardLabel);
            this.LeftDeckBox.Controls.Add(this.LeftDeckSelectionBox);
            this.LeftDeckBox.Controls.Add(this.label1);
            this.LeftDeckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftDeckBox.Location = new System.Drawing.Point(3, 3);
            this.LeftDeckBox.Name = "LeftDeckBox";
            this.LeftDeckBox.Size = new System.Drawing.Size(503, 453);
            this.LeftDeckBox.TabIndex = 0;
            this.LeftDeckBox.TabStop = false;
            this.LeftDeckBox.Text = "Первая колода";
            // 
            // LeftSyncBox
            // 
            this.LeftSyncBox.AutoSize = true;
            this.LeftSyncBox.Location = new System.Drawing.Point(9, 81);
            this.LeftSyncBox.Name = "LeftSyncBox";
            this.LeftSyncBox.Size = new System.Drawing.Size(80, 17);
            this.LeftSyncBox.TabIndex = 9;
            this.LeftSyncBox.Text = "Синхронно";
            this.LeftSyncBox.UseVisualStyleBackColor = true;
            this.LeftSyncBox.CheckedChanged += new System.EventHandler(this.LeftSyncBox_CheckedChanged);
            this.LeftSyncBox.MouseLeave += new System.EventHandler(this.LeftSyncBox_MouseLeave);
            this.LeftSyncBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftSyncBox_MouseMove);
            // 
            // LeftBackButton
            // 
            this.LeftBackButton.Location = new System.Drawing.Point(411, 81);
            this.LeftBackButton.Name = "LeftBackButton";
            this.LeftBackButton.Size = new System.Drawing.Size(75, 23);
            this.LeftBackButton.TabIndex = 8;
            this.LeftBackButton.Text = "Рубашка";
            this.LeftBackButton.UseVisualStyleBackColor = true;
            this.LeftBackButton.Click += new System.EventHandler(this.LeftBackButton_Click);
            this.LeftBackButton.MouseLeave += new System.EventHandler(this.LeftBackButton_MouseLeave);
            this.LeftBackButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftBackButton_MouseMove);
            // 
            // LeftLogoButton
            // 
            this.LeftLogoButton.Location = new System.Drawing.Point(330, 81);
            this.LeftLogoButton.Name = "LeftLogoButton";
            this.LeftLogoButton.Size = new System.Drawing.Size(75, 23);
            this.LeftLogoButton.TabIndex = 7;
            this.LeftLogoButton.Text = "Обложка";
            this.LeftLogoButton.UseVisualStyleBackColor = true;
            this.LeftLogoButton.Click += new System.EventHandler(this.LeftLogoButton_Click);
            this.LeftLogoButton.MouseLeave += new System.EventHandler(this.LeftLogoButton_MouseLeave);
            this.LeftLogoButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftLogoButton_MouseMove);
            // 
            // LeftTabs
            // 
            this.LeftTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftTabs.Controls.Add(this.LeftPictureTab);
            this.LeftTabs.Controls.Add(this.LeftDescriptionTab);
            this.LeftTabs.Location = new System.Drawing.Point(9, 104);
            this.LeftTabs.Name = "LeftTabs";
            this.LeftTabs.SelectedIndex = 0;
            this.LeftTabs.Size = new System.Drawing.Size(494, 346);
            this.LeftTabs.TabIndex = 6;
            // 
            // LeftPictureTab
            // 
            this.LeftPictureTab.BackColor = System.Drawing.Color.LightGray;
            this.LeftPictureTab.Controls.Add(this.LeftPictureBox);
            this.LeftPictureTab.Location = new System.Drawing.Point(4, 22);
            this.LeftPictureTab.Name = "LeftPictureTab";
            this.LeftPictureTab.Padding = new System.Windows.Forms.Padding(3);
            this.LeftPictureTab.Size = new System.Drawing.Size(486, 320);
            this.LeftPictureTab.TabIndex = 0;
            this.LeftPictureTab.Text = "Изображение";
            // 
            // LeftPictureBox
            // 
            this.LeftPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPictureBox.Location = new System.Drawing.Point(3, 3);
            this.LeftPictureBox.Name = "LeftPictureBox";
            this.LeftPictureBox.Size = new System.Drawing.Size(480, 314);
            this.LeftPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LeftPictureBox.TabIndex = 0;
            this.LeftPictureBox.TabStop = false;
            this.LeftPictureBox.Click += new System.EventHandler(this.LeftPictureBox_Click);
            this.LeftPictureBox.MouseLeave += new System.EventHandler(this.LeftPictureBox_MouseLeave);
            this.LeftPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftPictureBox_MouseMove);
            // 
            // LeftDescriptionTab
            // 
            this.LeftDescriptionTab.BackColor = System.Drawing.Color.LightGray;
            this.LeftDescriptionTab.Controls.Add(this.LeftDescriptionText);
            this.LeftDescriptionTab.Location = new System.Drawing.Point(4, 22);
            this.LeftDescriptionTab.Name = "LeftDescriptionTab";
            this.LeftDescriptionTab.Padding = new System.Windows.Forms.Padding(3);
            this.LeftDescriptionTab.Size = new System.Drawing.Size(486, 320);
            this.LeftDescriptionTab.TabIndex = 1;
            this.LeftDescriptionTab.Text = "Описание";
            // 
            // LeftDescriptionText
            // 
            this.LeftDescriptionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftDescriptionText.Location = new System.Drawing.Point(3, 3);
            this.LeftDescriptionText.Name = "LeftDescriptionText";
            this.LeftDescriptionText.ReadOnly = true;
            this.LeftDescriptionText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.LeftDescriptionText.Size = new System.Drawing.Size(480, 314);
            this.LeftDescriptionText.TabIndex = 0;
            this.LeftDescriptionText.Text = "";
            this.LeftDescriptionText.MouseLeave += new System.EventHandler(this.LeftDescriptionText_MouseLeave);
            this.LeftDescriptionText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftDescriptionText_MouseMove);
            // 
            // LeftCardName
            // 
            this.LeftCardName.AutoSize = true;
            this.LeftCardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftCardName.Location = new System.Drawing.Point(176, 59);
            this.LeftCardName.Name = "LeftCardName";
            this.LeftCardName.Size = new System.Drawing.Size(125, 20);
            this.LeftCardName.TabIndex = 5;
            this.LeftCardName.Text = "LeftCardName";
            this.LeftCardName.MouseLeave += new System.EventHandler(this.LeftCardName_MouseLeave);
            this.LeftCardName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftCardName_MouseMove);
            // 
            // LeftEqualButton
            // 
            this.LeftEqualButton.Location = new System.Drawing.Point(108, 58);
            this.LeftEqualButton.Name = "LeftEqualButton";
            this.LeftEqualButton.Size = new System.Drawing.Size(23, 25);
            this.LeftEqualButton.TabIndex = 4;
            this.LeftEqualButton.Text = "=";
            this.LeftEqualButton.UseVisualStyleBackColor = true;
            this.LeftEqualButton.Click += new System.EventHandler(this.LeftEqualButton_Click);
            this.LeftEqualButton.MouseLeave += new System.EventHandler(this.LeftEqualButton_MouseLeave);
            this.LeftEqualButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftEqualButton_MouseMove);
            // 
            // LeftCardSelector
            // 
            this.LeftCardSelector.Location = new System.Drawing.Point(133, 61);
            this.LeftCardSelector.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.LeftCardSelector.Name = "LeftCardSelector";
            this.LeftCardSelector.Size = new System.Drawing.Size(37, 20);
            this.LeftCardSelector.TabIndex = 3;
            this.LeftCardSelector.ValueChanged += new System.EventHandler(this.LeftCardSelector_ValueChanged);
            this.LeftCardSelector.Enter += new System.EventHandler(this.LeftCardSelector_Enter);
            this.LeftCardSelector.Leave += new System.EventHandler(this.LeftCardSelector_Leave);
            // 
            // LeftSelectedCardLabel
            // 
            this.LeftSelectedCardLabel.AutoSize = true;
            this.LeftSelectedCardLabel.Location = new System.Drawing.Point(6, 63);
            this.LeftSelectedCardLabel.Name = "LeftSelectedCardLabel";
            this.LeftSelectedCardLabel.Size = new System.Drawing.Size(96, 13);
            this.LeftSelectedCardLabel.TabIndex = 2;
            this.LeftSelectedCardLabel.Text = "Выбранная карта";
            // 
            // LeftDeckSelectionBox
            // 
            this.LeftDeckSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LeftDeckSelectionBox.FormattingEnabled = true;
            this.LeftDeckSelectionBox.Location = new System.Drawing.Point(115, 24);
            this.LeftDeckSelectionBox.Name = "LeftDeckSelectionBox";
            this.LeftDeckSelectionBox.Size = new System.Drawing.Size(371, 21);
            this.LeftDeckSelectionBox.TabIndex = 1;
            this.LeftDeckSelectionBox.SelectedIndexChanged += new System.EventHandler(this.LeftDeckSelectionBox_SelectedIndexChanged);
            this.LeftDeckSelectionBox.MouseLeave += new System.EventHandler(this.LeftDeckSelectionBox_MouseLeave);
            this.LeftDeckSelectionBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftDeckSelectionBox_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбранная колода";
            // 
            // RightDeckBox
            // 
            this.RightDeckBox.Controls.Add(this.RightSyncBox);
            this.RightDeckBox.Controls.Add(this.RightLogoButton);
            this.RightDeckBox.Controls.Add(this.RightBackButton);
            this.RightDeckBox.Controls.Add(this.RightTabs);
            this.RightDeckBox.Controls.Add(this.RightCardName);
            this.RightDeckBox.Controls.Add(this.RightEqualButton);
            this.RightDeckBox.Controls.Add(this.RightCardSelector);
            this.RightDeckBox.Controls.Add(this.RightSelectedCardLabel);
            this.RightDeckBox.Controls.Add(this.RightDeckSelectionBox);
            this.RightDeckBox.Controls.Add(this.label2);
            this.RightDeckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightDeckBox.Location = new System.Drawing.Point(512, 3);
            this.RightDeckBox.Name = "RightDeckBox";
            this.RightDeckBox.Size = new System.Drawing.Size(503, 453);
            this.RightDeckBox.TabIndex = 1;
            this.RightDeckBox.TabStop = false;
            this.RightDeckBox.Text = "Вторая колода";
            // 
            // RightSyncBox
            // 
            this.RightSyncBox.AutoSize = true;
            this.RightSyncBox.Location = new System.Drawing.Point(16, 81);
            this.RightSyncBox.Name = "RightSyncBox";
            this.RightSyncBox.Size = new System.Drawing.Size(80, 17);
            this.RightSyncBox.TabIndex = 8;
            this.RightSyncBox.Text = "Синхронно";
            this.RightSyncBox.UseVisualStyleBackColor = true;
            this.RightSyncBox.CheckedChanged += new System.EventHandler(this.RightSyncBox_CheckedChanged);
            this.RightSyncBox.MouseLeave += new System.EventHandler(this.RightSyncBox_MouseLeave);
            this.RightSyncBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightSyncBox_MouseMove);
            // 
            // RightLogoButton
            // 
            this.RightLogoButton.Location = new System.Drawing.Point(330, 81);
            this.RightLogoButton.Name = "RightLogoButton";
            this.RightLogoButton.Size = new System.Drawing.Size(75, 23);
            this.RightLogoButton.TabIndex = 1;
            this.RightLogoButton.Text = "Обложка";
            this.RightLogoButton.UseVisualStyleBackColor = true;
            this.RightLogoButton.Click += new System.EventHandler(this.RightLogoButton_Click);
            this.RightLogoButton.MouseLeave += new System.EventHandler(this.RightLogoButton_MouseLeave);
            this.RightLogoButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightLogoButton_MouseMove);
            // 
            // RightBackButton
            // 
            this.RightBackButton.Location = new System.Drawing.Point(411, 81);
            this.RightBackButton.Name = "RightBackButton";
            this.RightBackButton.Size = new System.Drawing.Size(75, 23);
            this.RightBackButton.TabIndex = 7;
            this.RightBackButton.Text = "Рубашка";
            this.RightBackButton.UseVisualStyleBackColor = true;
            this.RightBackButton.Click += new System.EventHandler(this.RightBackButton_Click);
            this.RightBackButton.MouseLeave += new System.EventHandler(this.RightBackButton_MouseLeave);
            this.RightBackButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightBackButton_MouseMove);
            // 
            // RightTabs
            // 
            this.RightTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightTabs.Controls.Add(this.RightPictureTab);
            this.RightTabs.Controls.Add(this.RightDescriptionTab);
            this.RightTabs.Location = new System.Drawing.Point(3, 104);
            this.RightTabs.Name = "RightTabs";
            this.RightTabs.SelectedIndex = 0;
            this.RightTabs.Size = new System.Drawing.Size(498, 346);
            this.RightTabs.TabIndex = 6;
            // 
            // RightPictureTab
            // 
            this.RightPictureTab.BackColor = System.Drawing.Color.LightGray;
            this.RightPictureTab.Controls.Add(this.RightPictureBox);
            this.RightPictureTab.Location = new System.Drawing.Point(4, 22);
            this.RightPictureTab.Name = "RightPictureTab";
            this.RightPictureTab.Padding = new System.Windows.Forms.Padding(3);
            this.RightPictureTab.Size = new System.Drawing.Size(490, 320);
            this.RightPictureTab.TabIndex = 0;
            this.RightPictureTab.Text = "Изображение";
            // 
            // RightPictureBox
            // 
            this.RightPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPictureBox.Location = new System.Drawing.Point(3, 3);
            this.RightPictureBox.Name = "RightPictureBox";
            this.RightPictureBox.Size = new System.Drawing.Size(484, 314);
            this.RightPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RightPictureBox.TabIndex = 0;
            this.RightPictureBox.TabStop = false;
            this.RightPictureBox.Click += new System.EventHandler(this.RightPictureBox_Click);
            this.RightPictureBox.MouseLeave += new System.EventHandler(this.RightPictureBox_MouseLeave);
            this.RightPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightPictureBox_MouseMove);
            // 
            // RightDescriptionTab
            // 
            this.RightDescriptionTab.BackColor = System.Drawing.Color.LightGray;
            this.RightDescriptionTab.Controls.Add(this.RightDescriptionText);
            this.RightDescriptionTab.Location = new System.Drawing.Point(4, 22);
            this.RightDescriptionTab.Name = "RightDescriptionTab";
            this.RightDescriptionTab.Padding = new System.Windows.Forms.Padding(3);
            this.RightDescriptionTab.Size = new System.Drawing.Size(490, 320);
            this.RightDescriptionTab.TabIndex = 1;
            this.RightDescriptionTab.Text = "Описание";
            // 
            // RightDescriptionText
            // 
            this.RightDescriptionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightDescriptionText.Location = new System.Drawing.Point(3, 3);
            this.RightDescriptionText.Name = "RightDescriptionText";
            this.RightDescriptionText.ReadOnly = true;
            this.RightDescriptionText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RightDescriptionText.Size = new System.Drawing.Size(484, 314);
            this.RightDescriptionText.TabIndex = 0;
            this.RightDescriptionText.Text = "";
            this.RightDescriptionText.MouseLeave += new System.EventHandler(this.RightDescriptionText_MouseLeave);
            this.RightDescriptionText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightDescriptionText_MouseMove);
            // 
            // RightCardName
            // 
            this.RightCardName.AutoSize = true;
            this.RightCardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightCardName.Location = new System.Drawing.Point(184, 59);
            this.RightCardName.Name = "RightCardName";
            this.RightCardName.Size = new System.Drawing.Size(136, 20);
            this.RightCardName.TabIndex = 5;
            this.RightCardName.Text = "RightCardName";
            this.RightCardName.MouseLeave += new System.EventHandler(this.RightCardName_MouseLeave);
            this.RightCardName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightCardName_MouseMove);
            // 
            // RightEqualButton
            // 
            this.RightEqualButton.Location = new System.Drawing.Point(115, 58);
            this.RightEqualButton.Name = "RightEqualButton";
            this.RightEqualButton.Size = new System.Drawing.Size(23, 25);
            this.RightEqualButton.TabIndex = 4;
            this.RightEqualButton.Text = "=";
            this.RightEqualButton.UseVisualStyleBackColor = true;
            this.RightEqualButton.Click += new System.EventHandler(this.RightEqualButton_Click);
            this.RightEqualButton.MouseLeave += new System.EventHandler(this.RightEqualButton_MouseLeave);
            this.RightEqualButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightEqualButton_MouseMove);
            // 
            // RightCardSelector
            // 
            this.RightCardSelector.Location = new System.Drawing.Point(141, 61);
            this.RightCardSelector.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.RightCardSelector.Name = "RightCardSelector";
            this.RightCardSelector.Size = new System.Drawing.Size(37, 20);
            this.RightCardSelector.TabIndex = 3;
            this.RightCardSelector.ValueChanged += new System.EventHandler(this.RightCardSelector_ValueChanged);
            this.RightCardSelector.Enter += new System.EventHandler(this.RightCardSelector_Enter);
            this.RightCardSelector.Leave += new System.EventHandler(this.RightCardSelector_Leave);
            // 
            // RightSelectedCardLabel
            // 
            this.RightSelectedCardLabel.AutoSize = true;
            this.RightSelectedCardLabel.Location = new System.Drawing.Point(13, 63);
            this.RightSelectedCardLabel.Name = "RightSelectedCardLabel";
            this.RightSelectedCardLabel.Size = new System.Drawing.Size(96, 13);
            this.RightSelectedCardLabel.TabIndex = 2;
            this.RightSelectedCardLabel.Text = "Выбранная карта";
            // 
            // RightDeckSelectionBox
            // 
            this.RightDeckSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RightDeckSelectionBox.FormattingEnabled = true;
            this.RightDeckSelectionBox.Location = new System.Drawing.Point(115, 24);
            this.RightDeckSelectionBox.Name = "RightDeckSelectionBox";
            this.RightDeckSelectionBox.Size = new System.Drawing.Size(371, 21);
            this.RightDeckSelectionBox.TabIndex = 1;
            this.RightDeckSelectionBox.SelectedIndexChanged += new System.EventHandler(this.RightDeckSelectionBox_SelectedIndexChanged);
            this.RightDeckSelectionBox.MouseLeave += new System.EventHandler(this.RightDeckSelectionBox_MouseLeave);
            this.RightDeckSelectionBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightDeckSelectionBox_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Выбранная колода";
            // 
            // FormStatusStrip
            // 
            this.FormStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLoginLabel,
            this.toolStripTip});
            this.FormStatusStrip.Location = new System.Drawing.Point(0, 459);
            this.FormStatusStrip.Name = "FormStatusStrip";
            this.FormStatusStrip.Size = new System.Drawing.Size(1018, 22);
            this.FormStatusStrip.TabIndex = 2;
            this.FormStatusStrip.Text = "statusStrip1";
            // 
            // toolStripLoginLabel
            // 
            this.toolStripLoginLabel.Name = "toolStripLoginLabel";
            this.toolStripLoginLabel.Size = new System.Drawing.Size(41, 17);
            this.toolStripLoginLabel.Text = "Логин";
            // 
            // toolStripTip
            // 
            this.toolStripTip.Name = "toolStripTip";
            this.toolStripTip.Size = new System.Drawing.Size(69, 17);
            this.toolStripTip.Text = "toolStripTip";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.RightDeckBox, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.LeftDeckBox, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1018, 459);
            this.tableLayoutPanel.TabIndex = 4;
            // 
            // DeckComparerHelp
            // 
            this.DeckComparerHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeckComparerHelp.AutoSize = true;
            this.DeckComparerHelp.Location = new System.Drawing.Point(1000, 462);
            this.DeckComparerHelp.Name = "DeckComparerHelp";
            this.DeckComparerHelp.Size = new System.Drawing.Size(13, 13);
            this.DeckComparerHelp.TabIndex = 5;
            this.DeckComparerHelp.TabStop = true;
            this.DeckComparerHelp.Text = "?";
            this.DeckComparerHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeckComparerHelp_LinkClicked);
            // 
            // DeckComparer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1018, 481);
            this.Controls.Add(this.DeckComparerHelp);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.FormStatusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeckComparer";
            this.Text = "Сравнение колод";
            this.Activated += new System.EventHandler(this.DeckComparer_Activated);
            this.Shown += new System.EventHandler(this.DeckComparer_Shown);
            this.LeftDeckBox.ResumeLayout(false);
            this.LeftDeckBox.PerformLayout();
            this.LeftTabs.ResumeLayout(false);
            this.LeftPictureTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LeftPictureBox)).EndInit();
            this.LeftDescriptionTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LeftCardSelector)).EndInit();
            this.RightDeckBox.ResumeLayout(false);
            this.RightDeckBox.PerformLayout();
            this.RightTabs.ResumeLayout(false);
            this.RightPictureTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RightPictureBox)).EndInit();
            this.RightDescriptionTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RightCardSelector)).EndInit();
            this.FormStatusStrip.ResumeLayout(false);
            this.FormStatusStrip.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox LeftDeckBox;
        public System.Windows.Forms.Label LeftCardName;
        public System.Windows.Forms.Button LeftEqualButton;
        public System.Windows.Forms.NumericUpDown LeftCardSelector;
        public System.Windows.Forms.Label LeftSelectedCardLabel;
        public System.Windows.Forms.ComboBox LeftDeckSelectionBox;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox RightDeckBox;
        public System.Windows.Forms.Label RightCardName;
        public System.Windows.Forms.Button RightEqualButton;
        public System.Windows.Forms.NumericUpDown RightCardSelector;
        public System.Windows.Forms.Label RightSelectedCardLabel;
        public System.Windows.Forms.ComboBox RightDeckSelectionBox;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TabControl LeftTabs;
        public System.Windows.Forms.TabPage LeftPictureTab;
        public System.Windows.Forms.PictureBox LeftPictureBox;
        public System.Windows.Forms.TabPage LeftDescriptionTab;
        public System.Windows.Forms.TabControl RightTabs;
        public System.Windows.Forms.TabPage RightPictureTab;
        public System.Windows.Forms.PictureBox RightPictureBox;
        public System.Windows.Forms.TabPage RightDescriptionTab;
        public System.Windows.Forms.RichTextBox LeftDescriptionText;
        public System.Windows.Forms.RichTextBox RightDescriptionText;
        public System.Windows.Forms.Button LeftBackButton;
        public System.Windows.Forms.Button LeftLogoButton;
        public System.Windows.Forms.Button RightLogoButton;
        public System.Windows.Forms.Button RightBackButton;
        public System.Windows.Forms.CheckBox LeftSyncBox;
        public System.Windows.Forms.CheckBox RightSyncBox;
        public System.Windows.Forms.StatusStrip FormStatusStrip;
        public System.Windows.Forms.ToolStripStatusLabel toolStripLoginLabel;
        public System.Windows.Forms.ToolStripStatusLabel toolStripTip;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        public System.Windows.Forms.LinkLabel DeckComparerHelp;

    }
}