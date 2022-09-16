namespace PAR_P_Studio
{
    partial class DeckView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeckView));
            this.CardImage = new System.Windows.Forms.PictureBox();
            this.NextCardButton = new System.Windows.Forms.Button();
            this.PreviousCardButton = new System.Windows.Forms.Button();
            this.CardCounterLabel = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.ShowDeckDescriptionButton = new System.Windows.Forms.Button();
            this.DeckSelectionBox = new System.Windows.Forms.ComboBox();
            this.ShowOtherDeckLabel = new System.Windows.Forms.Label();
            this.CardNameLabel = new System.Windows.Forms.Label();
            this.DemoCheckbox = new System.Windows.Forms.CheckBox();
            this.ShowTimer = new System.Windows.Forms.Timer(this.components);
            this.DemoCheckboxDeck = new System.Windows.Forms.CheckBox();
            this.SpeedBar = new System.Windows.Forms.TrackBar();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.ShuffleBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.CardImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBar)).BeginInit();
            this.SuspendLayout();
            // 
            // CardImage
            // 
            this.CardImage.Location = new System.Drawing.Point(12, 31);
            this.CardImage.Name = "CardImage";
            this.CardImage.Size = new System.Drawing.Size(211, 286);
            this.CardImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CardImage.TabIndex = 4;
            this.CardImage.TabStop = false;
            this.CardImage.Click += new System.EventHandler(this.CardImage_Click);
            // 
            // NextCardButton
            // 
            this.NextCardButton.Location = new System.Drawing.Point(122, 323);
            this.NextCardButton.Name = "NextCardButton";
            this.NextCardButton.Size = new System.Drawing.Size(101, 23);
            this.NextCardButton.TabIndex = 5;
            this.NextCardButton.Text = ">>>";
            this.NextCardButton.UseVisualStyleBackColor = true;
            this.NextCardButton.Click += new System.EventHandler(this.NextCardButton_Click);
            // 
            // PreviousCardButton
            // 
            this.PreviousCardButton.Location = new System.Drawing.Point(12, 323);
            this.PreviousCardButton.Name = "PreviousCardButton";
            this.PreviousCardButton.Size = new System.Drawing.Size(101, 23);
            this.PreviousCardButton.TabIndex = 6;
            this.PreviousCardButton.Text = "<<<";
            this.PreviousCardButton.UseVisualStyleBackColor = true;
            this.PreviousCardButton.Click += new System.EventHandler(this.PreviousCardButton_Click);
            // 
            // CardCounterLabel
            // 
            this.CardCounterLabel.AutoSize = true;
            this.CardCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardCounterLabel.Location = new System.Drawing.Point(12, 349);
            this.CardCounterLabel.Name = "CardCounterLabel";
            this.CardCounterLabel.Size = new System.Drawing.Size(95, 20);
            this.CardCounterLabel.TabIndex = 7;
            this.CardCounterLabel.Text = "CardCount";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionBox.BackColor = System.Drawing.Color.White;
            this.DescriptionBox.Location = new System.Drawing.Point(229, 12);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.ReadOnly = true;
            this.DescriptionBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.DescriptionBox.Size = new System.Drawing.Size(794, 578);
            this.DescriptionBox.TabIndex = 8;
            this.DescriptionBox.Text = "";
            // 
            // ShowDeckDescriptionButton
            // 
            this.ShowDeckDescriptionButton.Location = new System.Drawing.Point(12, 376);
            this.ShowDeckDescriptionButton.Name = "ShowDeckDescriptionButton";
            this.ShowDeckDescriptionButton.Size = new System.Drawing.Size(211, 23);
            this.ShowDeckDescriptionButton.TabIndex = 9;
            this.ShowDeckDescriptionButton.Text = "Показать описание колоды";
            this.ShowDeckDescriptionButton.UseVisualStyleBackColor = true;
            this.ShowDeckDescriptionButton.Click += new System.EventHandler(this.ShowDeckDescriptionButton_Click);
            // 
            // DeckSelectionBox
            // 
            this.DeckSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeckSelectionBox.FormattingEnabled = true;
            this.DeckSelectionBox.Location = new System.Drawing.Point(12, 422);
            this.DeckSelectionBox.Name = "DeckSelectionBox";
            this.DeckSelectionBox.Size = new System.Drawing.Size(211, 21);
            this.DeckSelectionBox.TabIndex = 10;
            this.DeckSelectionBox.SelectedIndexChanged += new System.EventHandler(this.DeckSelectionBox_SelectedIndexChanged);
            // 
            // ShowOtherDeckLabel
            // 
            this.ShowOtherDeckLabel.AutoSize = true;
            this.ShowOtherDeckLabel.Location = new System.Drawing.Point(12, 402);
            this.ShowOtherDeckLabel.Name = "ShowOtherDeckLabel";
            this.ShowOtherDeckLabel.Size = new System.Drawing.Size(150, 13);
            this.ShowOtherDeckLabel.TabIndex = 11;
            this.ShowOtherDeckLabel.Text = "Посмотреть другие колоды:";
            // 
            // CardNameLabel
            // 
            this.CardNameLabel.AutoSize = true;
            this.CardNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardNameLabel.Location = new System.Drawing.Point(18, 8);
            this.CardNameLabel.Name = "CardNameLabel";
            this.CardNameLabel.Size = new System.Drawing.Size(93, 20);
            this.CardNameLabel.TabIndex = 7;
            this.CardNameLabel.Text = "CardName";
            // 
            // DemoCheckbox
            // 
            this.DemoCheckbox.AutoSize = true;
            this.DemoCheckbox.Location = new System.Drawing.Point(12, 460);
            this.DemoCheckbox.Name = "DemoCheckbox";
            this.DemoCheckbox.Size = new System.Drawing.Size(148, 17);
            this.DemoCheckbox.TabIndex = 12;
            this.DemoCheckbox.Text = "Листать автоматически";
            this.DemoCheckbox.UseVisualStyleBackColor = true;
            this.DemoCheckbox.CheckedChanged += new System.EventHandler(this.DemoCheckbox_CheckedChanged);
            // 
            // ShowTimer
            // 
            this.ShowTimer.Interval = 1000;
            this.ShowTimer.Tick += new System.EventHandler(this.ShowTimer_Tick);
            // 
            // DemoCheckboxDeck
            // 
            this.DemoCheckboxDeck.AutoSize = true;
            this.DemoCheckboxDeck.Location = new System.Drawing.Point(22, 506);
            this.DemoCheckboxDeck.Name = "DemoCheckboxDeck";
            this.DemoCheckboxDeck.Size = new System.Drawing.Size(105, 17);
            this.DemoCheckboxDeck.TabIndex = 13;
            this.DemoCheckboxDeck.Text = "Менять колоды";
            this.DemoCheckboxDeck.UseVisualStyleBackColor = true;
            this.DemoCheckboxDeck.Visible = false;
            // 
            // SpeedBar
            // 
            this.SpeedBar.Location = new System.Drawing.Point(3, 523);
            this.SpeedBar.Maximum = 9;
            this.SpeedBar.Minimum = 1;
            this.SpeedBar.Name = "SpeedBar";
            this.SpeedBar.Size = new System.Drawing.Size(220, 45);
            this.SpeedBar.TabIndex = 14;
            this.SpeedBar.Value = 7;
            this.SpeedBar.Visible = false;
            this.SpeedBar.ValueChanged += new System.EventHandler(this.SpeedBar_ValueChanged);
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(134, 507);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(58, 13);
            this.SpeedLabel.TabIndex = 15;
            this.SpeedLabel.Text = "Скорость:";
            this.SpeedLabel.Visible = false;
            // 
            // ShuffleBox
            // 
            this.ShuffleBox.AutoSize = true;
            this.ShuffleBox.Location = new System.Drawing.Point(22, 483);
            this.ShuffleBox.Name = "ShuffleBox";
            this.ShuffleBox.Size = new System.Drawing.Size(75, 17);
            this.ShuffleBox.TabIndex = 16;
            this.ShuffleBox.Text = "Вразброс";
            this.ShuffleBox.UseVisualStyleBackColor = true;
            this.ShuffleBox.Visible = false;
            // 
            // DeckView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 592);
            this.Controls.Add(this.ShuffleBox);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.SpeedBar);
            this.Controls.Add(this.DemoCheckboxDeck);
            this.Controls.Add(this.DemoCheckbox);
            this.Controls.Add(this.ShowOtherDeckLabel);
            this.Controls.Add(this.DeckSelectionBox);
            this.Controls.Add(this.ShowDeckDescriptionButton);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.CardNameLabel);
            this.Controls.Add(this.CardCounterLabel);
            this.Controls.Add(this.PreviousCardButton);
            this.Controls.Add(this.NextCardButton);
            this.Controls.Add(this.CardImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeckView";
            this.ShowInTaskbar = false;
            this.Text = "Просмотр колоды";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.DeckView_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.CardImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox CardImage;
        public System.Windows.Forms.Button NextCardButton;
        public System.Windows.Forms.Button PreviousCardButton;
        public System.Windows.Forms.Label CardCounterLabel;
        public System.Windows.Forms.RichTextBox DescriptionBox;
        public System.Windows.Forms.Button ShowDeckDescriptionButton;
        public System.Windows.Forms.ComboBox DeckSelectionBox;
        public System.Windows.Forms.Label ShowOtherDeckLabel;
        public System.Windows.Forms.Label CardNameLabel;
        public System.Windows.Forms.CheckBox DemoCheckbox;
        public System.Windows.Forms.Timer ShowTimer;
        public System.Windows.Forms.CheckBox DemoCheckboxDeck;
        public System.Windows.Forms.TrackBar SpeedBar;
        public System.Windows.Forms.Label SpeedLabel;
        public System.Windows.Forms.CheckBox ShuffleBox;

    }
}