namespace PAR_P_Studio.ProjectForms
{
    partial class ShuffleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShuffleForm));
            this.CardList = new System.Windows.Forms.ListView();
            this.CardImageList = new System.Windows.Forms.ImageList(this.components);
            this.ShowCardsBox = new System.Windows.Forms.CheckBox();
            this.ShowNamesBox = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CardImageListClosed = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // CardList
            // 
            this.CardList.AllowDrop = true;
            this.CardList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CardList.LargeImageList = this.CardImageList;
            this.CardList.Location = new System.Drawing.Point(0, 0);
            this.CardList.MultiSelect = false;
            this.CardList.Name = "CardList";
            this.CardList.Size = new System.Drawing.Size(532, 388);
            this.CardList.TabIndex = 0;
            this.CardList.UseCompatibleStateImageBehavior = false;
            this.CardList.ItemActivate += new System.EventHandler(this.CardList_ItemActivate);
            this.CardList.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.CardList_ItemDrag);
            this.CardList.DragDrop += new System.Windows.Forms.DragEventHandler(this.CardList_DragDrop);
            this.CardList.DragEnter += new System.Windows.Forms.DragEventHandler(this.CardList_DragEnter);
            this.CardList.DragOver += new System.Windows.Forms.DragEventHandler(this.CardList_DragOver);
            this.CardList.DragLeave += new System.EventHandler(this.CardList_DragLeave);
            this.CardList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CardList_MouseClick);
            // 
            // CardImageList
            // 
            this.CardImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.CardImageList.ImageSize = new System.Drawing.Size(33, 46);
            this.CardImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ShowCardsBox
            // 
            this.ShowCardsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowCardsBox.AutoSize = true;
            this.ShowCardsBox.Checked = true;
            this.ShowCardsBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowCardsBox.Location = new System.Drawing.Point(538, 12);
            this.ShowCardsBox.Name = "ShowCardsBox";
            this.ShowCardsBox.Size = new System.Drawing.Size(109, 17);
            this.ShowCardsBox.TabIndex = 1;
            this.ShowCardsBox.Text = "Показать карты";
            this.ShowCardsBox.UseVisualStyleBackColor = true;
            this.ShowCardsBox.CheckedChanged += new System.EventHandler(this.ShowCardsBox_CheckedChanged);
            // 
            // ShowNamesBox
            // 
            this.ShowNamesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowNamesBox.AutoSize = true;
            this.ShowNamesBox.Checked = true;
            this.ShowNamesBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowNamesBox.Location = new System.Drawing.Point(538, 35);
            this.ShowNamesBox.Name = "ShowNamesBox";
            this.ShowNamesBox.Size = new System.Drawing.Size(126, 17);
            this.ShowNamesBox.TabIndex = 2;
            this.ShowNamesBox.Text = "Показать названия";
            this.ShowNamesBox.UseVisualStyleBackColor = true;
            this.ShowNamesBox.CheckedChanged += new System.EventHandler(this.ShowNamesBox_CheckedChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(538, 325);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(111, 43);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CardImageListClosed
            // 
            this.CardImageListClosed.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.CardImageListClosed.ImageSize = new System.Drawing.Size(33, 46);
            this.CardImageListClosed.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ShuffleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 391);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ShowNamesBox);
            this.Controls.Add(this.ShowCardsBox);
            this.Controls.Add(this.CardList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShuffleForm";
            this.ShowInTaskbar = false;
            this.Text = "Перемешивание карт";
            this.Shown += new System.EventHandler(this.ShuffleForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView CardList;
        private System.Windows.Forms.ImageList CardImageList;
        private System.Windows.Forms.CheckBox ShowCardsBox;
        private System.Windows.Forms.CheckBox ShowNamesBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ImageList CardImageListClosed;
    }
}