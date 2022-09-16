namespace PAR_P_Studio.ProjectForms
{
    partial class UserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfo));
            this.InfoTabs = new System.Windows.Forms.TabControl();
            this.StatisticsTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LogonTimeLabel = new System.Windows.Forms.Label();
            this.LayoutsLabel = new System.Windows.Forms.Label();
            this.CardsLabel = new System.Windows.Forms.Label();
            this.LogonLabel = new System.Windows.Forms.Label();
            this.DeckLabel = new System.Windows.Forms.Label();
            this.LayoutLabel = new System.Windows.Forms.Label();
            this.dispLogonTime = new System.Windows.Forms.Label();
            this.dispLayoutCount = new System.Windows.Forms.Label();
            this.dispDrawnCards = new System.Windows.Forms.Label();
            this.dispLogonCount = new System.Windows.Forms.Label();
            this.dispFavoriteDeck = new System.Windows.Forms.Label();
            this.dispFavoriteLayout = new System.Windows.Forms.Label();
            this.CardsTab = new System.Windows.Forms.TabPage();
            this.CardsInfo = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.PersonCardLabel = new System.Windows.Forms.Label();
            this.SoulCardLabel = new System.Windows.Forms.Label();
            this.YearCardLabel = new System.Windows.Forms.Label();
            this.dispPersonCard = new System.Windows.Forms.Label();
            this.dispSoulCard = new System.Windows.Forms.Label();
            this.dispYearCard = new System.Windows.Forms.Label();
            this.FormStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripTip = new System.Windows.Forms.ToolStripStatusLabel();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.InfoTabs.SuspendLayout();
            this.StatisticsTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.CardsTab.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.FormStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoTabs
            // 
            this.InfoTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoTabs.Controls.Add(this.StatisticsTab);
            this.InfoTabs.Controls.Add(this.CardsTab);
            this.InfoTabs.Location = new System.Drawing.Point(0, 1);
            this.InfoTabs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InfoTabs.Name = "InfoTabs";
            this.InfoTabs.SelectedIndex = 0;
            this.InfoTabs.Size = new System.Drawing.Size(648, 362);
            this.InfoTabs.TabIndex = 0;
            // 
            // StatisticsTab
            // 
            this.StatisticsTab.BackColor = System.Drawing.Color.LightGray;
            this.StatisticsTab.Controls.Add(this.tableLayoutPanel1);
            this.StatisticsTab.Location = new System.Drawing.Point(4, 25);
            this.StatisticsTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StatisticsTab.Name = "StatisticsTab";
            this.StatisticsTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StatisticsTab.Size = new System.Drawing.Size(640, 333);
            this.StatisticsTab.TabIndex = 0;
            this.StatisticsTab.Text = "Статистика";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LogonTimeLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LayoutsLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CardsLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LogonLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.DeckLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.LayoutLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.dispLogonTime, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dispLayoutCount, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dispDrawnCards, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dispLogonCount, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dispFavoriteDeck, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dispFavoriteLayout, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(632, 325);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LogonTimeLabel
            // 
            this.LogonTimeLabel.AutoSize = true;
            this.LogonTimeLabel.Location = new System.Drawing.Point(5, 1);
            this.LogonTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogonTimeLabel.Name = "LogonTimeLabel";
            this.LogonTimeLabel.Size = new System.Drawing.Size(136, 17);
            this.LogonTimeLabel.TabIndex = 0;
            this.LogonTimeLabel.Text = "Время в программе";
            this.LogonTimeLabel.MouseLeave += new System.EventHandler(this.LogonTimeLabel_MouseLeave);
            this.LogonTimeLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LogonTimeLabel_MouseMove);
            // 
            // LayoutsLabel
            // 
            this.LayoutsLabel.AutoSize = true;
            this.LayoutsLabel.Location = new System.Drawing.Point(5, 27);
            this.LayoutsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LayoutsLabel.Name = "LayoutsLabel";
            this.LayoutsLabel.Size = new System.Drawing.Size(168, 17);
            this.LayoutsLabel.TabIndex = 1;
            this.LayoutsLabel.Text = "Раскладов произведено";
            this.LayoutsLabel.MouseLeave += new System.EventHandler(this.LayoutsLabel_MouseLeave);
            this.LayoutsLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LayoutsLabel_MouseMove);
            // 
            // CardsLabel
            // 
            this.CardsLabel.AutoSize = true;
            this.CardsLabel.Location = new System.Drawing.Point(5, 53);
            this.CardsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CardsLabel.Name = "CardsLabel";
            this.CardsLabel.Size = new System.Drawing.Size(106, 17);
            this.CardsLabel.TabIndex = 2;
            this.CardsLabel.Text = "Вытянуто карт";
            this.CardsLabel.MouseLeave += new System.EventHandler(this.CardsLabel_MouseLeave);
            this.CardsLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CardsLabel_MouseMove);
            // 
            // LogonLabel
            // 
            this.LogonLabel.AutoSize = true;
            this.LogonLabel.Location = new System.Drawing.Point(5, 79);
            this.LogonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogonLabel.Name = "LogonLabel";
            this.LogonLabel.Size = new System.Drawing.Size(146, 17);
            this.LogonLabel.TabIndex = 3;
            this.LogonLabel.Text = "Запусков программы";
            this.LogonLabel.MouseLeave += new System.EventHandler(this.LogonLabel_MouseLeave);
            this.LogonLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LogonLabel_MouseMove);
            // 
            // DeckLabel
            // 
            this.DeckLabel.AutoSize = true;
            this.DeckLabel.Location = new System.Drawing.Point(5, 105);
            this.DeckLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeckLabel.Name = "DeckLabel";
            this.DeckLabel.Size = new System.Drawing.Size(173, 17);
            this.DeckLabel.TabIndex = 4;
            this.DeckLabel.Text = "Предпочитаемая колода";
            this.DeckLabel.MouseLeave += new System.EventHandler(this.DeckLabel_MouseLeave);
            this.DeckLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DeckLabel_MouseMove);
            // 
            // LayoutLabel
            // 
            this.LayoutLabel.AutoSize = true;
            this.LayoutLabel.Location = new System.Drawing.Point(5, 131);
            this.LayoutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LayoutLabel.Name = "LayoutLabel";
            this.LayoutLabel.Size = new System.Drawing.Size(182, 17);
            this.LayoutLabel.TabIndex = 5;
            this.LayoutLabel.Text = "Предпочитаемый расклад";
            this.LayoutLabel.MouseLeave += new System.EventHandler(this.LayoutLabel_MouseLeave);
            this.LayoutLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LayoutLabel_MouseMove);
            // 
            // dispLogonTime
            // 
            this.dispLogonTime.AutoSize = true;
            this.dispLogonTime.Location = new System.Drawing.Point(320, 1);
            this.dispLogonTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dispLogonTime.Name = "dispLogonTime";
            this.dispLogonTime.Size = new System.Drawing.Size(105, 17);
            this.dispLogonTime.TabIndex = 6;
            this.dispLogonTime.Text = "dispLogonTime";
            this.dispLogonTime.MouseLeave += new System.EventHandler(this.dispLogonTime_MouseLeave);
            this.dispLogonTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dispLogonTime_MouseMove);
            // 
            // dispLayoutCount
            // 
            this.dispLayoutCount.AutoSize = true;
            this.dispLayoutCount.Location = new System.Drawing.Point(320, 27);
            this.dispLayoutCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dispLayoutCount.Name = "dispLayoutCount";
            this.dispLayoutCount.Size = new System.Drawing.Size(114, 17);
            this.dispLayoutCount.TabIndex = 7;
            this.dispLayoutCount.Text = "dispLayoutCount";
            this.dispLayoutCount.MouseLeave += new System.EventHandler(this.dispLayoutCount_MouseLeave);
            this.dispLayoutCount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dispLayoutCount_MouseMove);
            // 
            // dispDrawnCards
            // 
            this.dispDrawnCards.AutoSize = true;
            this.dispDrawnCards.Location = new System.Drawing.Point(320, 53);
            this.dispDrawnCards.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dispDrawnCards.Name = "dispDrawnCards";
            this.dispDrawnCards.Size = new System.Drawing.Size(111, 17);
            this.dispDrawnCards.TabIndex = 8;
            this.dispDrawnCards.Text = "dispDrawnCards";
            this.dispDrawnCards.MouseLeave += new System.EventHandler(this.dispDrawnCards_MouseLeave);
            this.dispDrawnCards.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dispDrawnCards_MouseMove);
            // 
            // dispLogonCount
            // 
            this.dispLogonCount.AutoSize = true;
            this.dispLogonCount.Location = new System.Drawing.Point(320, 79);
            this.dispLogonCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dispLogonCount.Name = "dispLogonCount";
            this.dispLogonCount.Size = new System.Drawing.Size(111, 17);
            this.dispLogonCount.TabIndex = 9;
            this.dispLogonCount.Text = "dispLogonCount";
            this.dispLogonCount.MouseLeave += new System.EventHandler(this.dispLogonCount_MouseLeave);
            this.dispLogonCount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dispLogonCount_MouseMove);
            // 
            // dispFavoriteDeck
            // 
            this.dispFavoriteDeck.AutoSize = true;
            this.dispFavoriteDeck.Location = new System.Drawing.Point(320, 105);
            this.dispFavoriteDeck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dispFavoriteDeck.Name = "dispFavoriteDeck";
            this.dispFavoriteDeck.Size = new System.Drawing.Size(117, 17);
            this.dispFavoriteDeck.TabIndex = 10;
            this.dispFavoriteDeck.Text = "dispFavoriteDeck";
            this.dispFavoriteDeck.MouseLeave += new System.EventHandler(this.dispFavoriteDeck_MouseLeave);
            this.dispFavoriteDeck.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dispFavoriteDeck_MouseMove);
            // 
            // dispFavoriteLayout
            // 
            this.dispFavoriteLayout.AutoSize = true;
            this.dispFavoriteLayout.Location = new System.Drawing.Point(320, 131);
            this.dispFavoriteLayout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dispFavoriteLayout.Name = "dispFavoriteLayout";
            this.dispFavoriteLayout.Size = new System.Drawing.Size(128, 17);
            this.dispFavoriteLayout.TabIndex = 11;
            this.dispFavoriteLayout.Text = "dispFavoriteLayout";
            this.dispFavoriteLayout.MouseLeave += new System.EventHandler(this.dispFavoriteLayout_MouseLeave);
            this.dispFavoriteLayout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dispFavoriteLayout_MouseMove);
            // 
            // CardsTab
            // 
            this.CardsTab.BackColor = System.Drawing.Color.LightGray;
            this.CardsTab.Controls.Add(this.CardsInfo);
            this.CardsTab.Controls.Add(this.tableLayoutPanel2);
            this.CardsTab.Location = new System.Drawing.Point(4, 25);
            this.CardsTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CardsTab.Name = "CardsTab";
            this.CardsTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CardsTab.Size = new System.Drawing.Size(640, 333);
            this.CardsTab.TabIndex = 1;
            this.CardsTab.Text = "Ваши карты";
            // 
            // CardsInfo
            // 
            this.CardsInfo.AcceptsTab = true;
            this.CardsInfo.Location = new System.Drawing.Point(8, 87);
            this.CardsInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CardsInfo.Name = "CardsInfo";
            this.CardsInfo.ReadOnly = true;
            this.CardsInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.CardsInfo.Size = new System.Drawing.Size(619, 234);
            this.CardsInfo.TabIndex = 1;
            this.CardsInfo.Text = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.PersonCardLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SoulCardLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.YearCardLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.dispPersonCard, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dispSoulCard, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dispYearCard, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(632, 80);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // PersonCardLabel
            // 
            this.PersonCardLabel.AutoSize = true;
            this.PersonCardLabel.Location = new System.Drawing.Point(5, 1);
            this.PersonCardLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PersonCardLabel.Name = "PersonCardLabel";
            this.PersonCardLabel.Size = new System.Drawing.Size(114, 17);
            this.PersonCardLabel.TabIndex = 0;
            this.PersonCardLabel.Text = "Карта личности";
            // 
            // SoulCardLabel
            // 
            this.SoulCardLabel.AutoSize = true;
            this.SoulCardLabel.Location = new System.Drawing.Point(5, 27);
            this.SoulCardLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SoulCardLabel.Name = "SoulCardLabel";
            this.SoulCardLabel.Size = new System.Drawing.Size(86, 17);
            this.SoulCardLabel.TabIndex = 1;
            this.SoulCardLabel.Text = "Карта души";
            // 
            // YearCardLabel
            // 
            this.YearCardLabel.AutoSize = true;
            this.YearCardLabel.Location = new System.Drawing.Point(5, 53);
            this.YearCardLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YearCardLabel.Name = "YearCardLabel";
            this.YearCardLabel.Size = new System.Drawing.Size(81, 17);
            this.YearCardLabel.TabIndex = 2;
            this.YearCardLabel.Text = "Карта года";
            // 
            // dispPersonCard
            // 
            this.dispPersonCard.AutoSize = true;
            this.dispPersonCard.Location = new System.Drawing.Point(320, 1);
            this.dispPersonCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dispPersonCard.Name = "dispPersonCard";
            this.dispPersonCard.Size = new System.Drawing.Size(109, 17);
            this.dispPersonCard.TabIndex = 3;
            this.dispPersonCard.Text = "dispPersonCard";
            // 
            // dispSoulCard
            // 
            this.dispSoulCard.AutoSize = true;
            this.dispSoulCard.Location = new System.Drawing.Point(320, 27);
            this.dispSoulCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dispSoulCard.Name = "dispSoulCard";
            this.dispSoulCard.Size = new System.Drawing.Size(92, 17);
            this.dispSoulCard.TabIndex = 4;
            this.dispSoulCard.Text = "dispSoulCard";
            // 
            // dispYearCard
            // 
            this.dispYearCard.AutoSize = true;
            this.dispYearCard.Location = new System.Drawing.Point(320, 53);
            this.dispYearCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dispYearCard.Name = "dispYearCard";
            this.dispYearCard.Size = new System.Drawing.Size(94, 17);
            this.dispYearCard.TabIndex = 5;
            this.dispYearCard.Text = "dispYearCard";
            // 
            // FormStatusStrip
            // 
            this.FormStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLogin,
            this.ToolStripTip});
            this.FormStatusStrip.Location = new System.Drawing.Point(0, 369);
            this.FormStatusStrip.Name = "FormStatusStrip";
            this.FormStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.FormStatusStrip.Size = new System.Drawing.Size(648, 25);
            this.FormStatusStrip.TabIndex = 1;
            this.FormStatusStrip.Text = "statusStrip1";
            // 
            // toolStripLogin
            // 
            this.toolStripLogin.Name = "toolStripLogin";
            this.toolStripLogin.Size = new System.Drawing.Size(52, 20);
            this.toolStripLogin.Text = "Логин";
            // 
            // ToolStripTip
            // 
            this.ToolStripTip.Name = "ToolStripTip";
            this.ToolStripTip.Size = new System.Drawing.Size(91, 20);
            this.ToolStripTip.Text = "ToolStripTip";
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Interval = 1000;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 394);
            this.Controls.Add(this.FormStatusStrip);
            this.Controls.Add(this.InfoTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserInfo";
            this.Shown += new System.EventHandler(this.UserInfo_Shown);
            this.InfoTabs.ResumeLayout(false);
            this.StatisticsTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.CardsTab.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.FormStatusStrip.ResumeLayout(false);
            this.FormStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl InfoTabs;
        private System.Windows.Forms.TabPage StatisticsTab;
        private System.Windows.Forms.TabPage CardsTab;
        private System.Windows.Forms.StatusStrip FormStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLogin;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripTip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LogonTimeLabel;
        private System.Windows.Forms.Label LayoutsLabel;
        private System.Windows.Forms.Label CardsLabel;
        private System.Windows.Forms.Label LogonLabel;
        private System.Windows.Forms.Label DeckLabel;
        private System.Windows.Forms.Label LayoutLabel;
        private System.Windows.Forms.Label dispLogonTime;
        private System.Windows.Forms.Label dispLayoutCount;
        private System.Windows.Forms.Label dispDrawnCards;
        private System.Windows.Forms.Label dispLogonCount;
        private System.Windows.Forms.Label dispFavoriteDeck;
        private System.Windows.Forms.Label dispFavoriteLayout;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label PersonCardLabel;
        private System.Windows.Forms.Label SoulCardLabel;
        private System.Windows.Forms.Label YearCardLabel;
        private System.Windows.Forms.Label dispPersonCard;
        private System.Windows.Forms.Label dispSoulCard;
        private System.Windows.Forms.Label dispYearCard;
        private System.Windows.Forms.RichTextBox CardsInfo;
    }
}