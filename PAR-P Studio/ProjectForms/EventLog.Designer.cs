namespace PAR_P_Studio.ProjectForms
{
    partial class EventLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventLog));
            this.EventList = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EventType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Element = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Access = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClearLogButton = new System.Windows.Forms.Button();
            this.CancelClearing = new System.Windows.Forms.Button();
            this.FormStatusStrip = new System.Windows.Forms.StatusStrip();
            this.Login = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripTip = new System.Windows.Forms.ToolStripStatusLabel();
            this.EventsHelp = new System.Windows.Forms.LinkLabel();
            this.FormStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // EventList
            // 
            this.EventList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.User,
            this.EventType,
            this.Element,
            this.Access});
            this.EventList.Location = new System.Drawing.Point(12, 36);
            this.EventList.Name = "EventList";
            this.EventList.Size = new System.Drawing.Size(982, 294);
            this.EventList.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.EventList.TabIndex = 0;
            this.EventList.UseCompatibleStateImageBehavior = false;
            this.EventList.View = System.Windows.Forms.View.Details;
            this.EventList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.EventList_ColumnClick);
            this.EventList.MouseLeave += new System.EventHandler(this.EventList_MouseLeave);
            this.EventList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EventList_MouseMove);
            // 
            // Date
            // 
            this.Date.Text = "Дата";
            this.Date.Width = 120;
            // 
            // User
            // 
            this.User.Text = "Пользователь";
            this.User.Width = 112;
            // 
            // EventType
            // 
            this.EventType.Text = "Действие";
            this.EventType.Width = 346;
            // 
            // Element
            // 
            this.Element.Text = "Объект";
            this.Element.Width = 297;
            // 
            // Access
            // 
            this.Access.Text = "Набор данных";
            this.Access.Width = 85;
            // 
            // ClearLogButton
            // 
            this.ClearLogButton.Location = new System.Drawing.Point(12, 7);
            this.ClearLogButton.Name = "ClearLogButton";
            this.ClearLogButton.Size = new System.Drawing.Size(201, 23);
            this.ClearLogButton.TabIndex = 1;
            this.ClearLogButton.Text = "Очистить все до последнего месяца";
            this.ClearLogButton.UseVisualStyleBackColor = true;
            this.ClearLogButton.Click += new System.EventHandler(this.ClearLogButton_Click);
            this.ClearLogButton.MouseLeave += new System.EventHandler(this.ClearLogButton_MouseLeave);
            this.ClearLogButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClearLogButton_MouseMove);
            // 
            // CancelClearing
            // 
            this.CancelClearing.Location = new System.Drawing.Point(219, 7);
            this.CancelClearing.Name = "CancelClearing";
            this.CancelClearing.Size = new System.Drawing.Size(120, 23);
            this.CancelClearing.TabIndex = 2;
            this.CancelClearing.Text = "Отменить очищение";
            this.CancelClearing.UseVisualStyleBackColor = true;
            this.CancelClearing.Visible = false;
            this.CancelClearing.Click += new System.EventHandler(this.CancelClearing_Click);
            this.CancelClearing.MouseLeave += new System.EventHandler(this.CancelClearing_MouseLeave);
            this.CancelClearing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CancelClearing_MouseMove);
            // 
            // FormStatusStrip
            // 
            this.FormStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Login,
            this.toolStripTip});
            this.FormStatusStrip.Location = new System.Drawing.Point(0, 336);
            this.FormStatusStrip.Name = "FormStatusStrip";
            this.FormStatusStrip.Size = new System.Drawing.Size(1006, 22);
            this.FormStatusStrip.TabIndex = 3;
            this.FormStatusStrip.Text = "statusStrip1";
            // 
            // Login
            // 
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(41, 17);
            this.Login.Text = "Логин";
            // 
            // toolStripTip
            // 
            this.toolStripTip.Name = "toolStripTip";
            this.toolStripTip.Size = new System.Drawing.Size(69, 17);
            this.toolStripTip.Text = "toolStripTip";
            // 
            // EventsHelp
            // 
            this.EventsHelp.AutoSize = true;
            this.EventsHelp.Location = new System.Drawing.Point(926, 7);
            this.EventsHelp.Name = "EventsHelp";
            this.EventsHelp.Size = new System.Drawing.Size(13, 13);
            this.EventsHelp.TabIndex = 4;
            this.EventsHelp.TabStop = true;
            this.EventsHelp.Text = "?";
            this.EventsHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EventsHelp_LinkClicked);
            this.EventsHelp.MouseLeave += new System.EventHandler(this.EventsHelp_MouseLeave);
            this.EventsHelp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EventsHelp_MouseMove);
            // 
            // EventLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 358);
            this.Controls.Add(this.EventsHelp);
            this.Controls.Add(this.FormStatusStrip);
            this.Controls.Add(this.CancelClearing);
            this.Controls.Add(this.ClearLogButton);
            this.Controls.Add(this.EventList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EventLog";
            this.Text = "EventLog";
            this.Shown += new System.EventHandler(this.EventLog_Shown);
            this.FormStatusStrip.ResumeLayout(false);
            this.FormStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView EventList;
        public System.Windows.Forms.ColumnHeader Date;
        public System.Windows.Forms.ColumnHeader User;
        public System.Windows.Forms.ColumnHeader EventType;
        public System.Windows.Forms.ColumnHeader Element;
        public System.Windows.Forms.ColumnHeader Access;
        public System.Windows.Forms.Button ClearLogButton;
        public System.Windows.Forms.Button CancelClearing;
        public System.Windows.Forms.StatusStrip FormStatusStrip;
        public System.Windows.Forms.ToolStripStatusLabel Login;
        public System.Windows.Forms.ToolStripStatusLabel toolStripTip;
        public System.Windows.Forms.LinkLabel EventsHelp;

    }
}