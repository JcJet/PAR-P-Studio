using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using PAR_P_Studio.Dialogs;

//Окно сравнения двух колод по содержимому
//© Владимир Андреев, PAR-P Corp.

namespace PAR_P_Studio.ProjectForms
{
    public partial class DeckComparer : Form
    {
        Deck LeftDeck, RightDeck;

        public DeckComparer()
        {
            InitializeComponent();
            //Переменные для левой и правой колод.
            LeftDeck = new Deck();
            RightDeck = new Deck();

            LeftTabs.SelectedTab = LeftPictureTab;
            RightTabs.SelectedTab = RightPictureTab;
        }

        void SetColors()
        {
            //Установка цветов согласно выбранной схеме
            LeftPictureBox.BackColor = StaticParams.CurrentUser.UserSettings.BGColor;
            RightPictureBox.BackColor = StaticParams.CurrentUser.UserSettings.BGColor;
            LeftPictureTab.BackColor = StaticParams.CurrentUser.UserSettings.BGColor;
            RightPictureTab.BackColor = StaticParams.CurrentUser.UserSettings.BGColor;
            LeftDescriptionTab.BackColor = StaticParams.CurrentUser.UserSettings.BGColor;
            RightDescriptionTab.BackColor = StaticParams.CurrentUser.UserSettings.BGColor;
            this.BackColor = StaticParams.CurrentUser.UserSettings.WinColor;
            this.ForeColor = StaticParams.CurrentUser.UserSettings.LabelColor;
        }
        void DeckRefresh()
        {
            //Создание списка существующих колод для левого и правого комбо бокса
            LeftDeckSelectionBox.Items.Clear();
            RightDeckSelectionBox.Items.Clear();
            LeftDeckSelectionBox.BeginUpdate();
            RightDeckSelectionBox.BeginUpdate();
            if (StaticParams.Access == StaticParams.AccessType.One)
                foreach (Deck item in StaticParams.Decks)
                {
                    LeftDeckSelectionBox.Items.Add(item.Name);
                    RightDeckSelectionBox.Items.Add(item.Name);
                }

            else if (StaticParams.Access == StaticParams.AccessType.Separate)
            {
                Deck tempDeck = new Deck();
                string[] files = Directory.GetFiles(StaticParams.GetProgramDir() + "Data\\Decks");
                foreach (string item in files)
                {
                    try
                    {

                        FileStream DeckFile = new FileStream(item,
                            FileMode.Open, FileAccess.Read);
                        BinaryFormatter UserFormatter = new BinaryFormatter();
                        tempDeck = new Deck((Deck)UserFormatter.Deserialize(DeckFile));
                        LeftDeckSelectionBox.Items.Add(tempDeck.Name);
                        RightDeckSelectionBox.Items.Add(tempDeck.Name);
                        DeckFile.Close();
                    }
                    catch { }
                }

            }
            LeftDeckSelectionBox.EndUpdate();
            RightDeckSelectionBox.EndUpdate();
        }

        private void DeckComparer_Shown(object sender, EventArgs e)
        {
            SetColors();

            if (StaticParams.CurrentUser.Guestmode)
            {
                toolStripLoginLabel.Text = "Гостевой режим";
                toolStripLoginLabel.ForeColor = Color.Tomato;
            }
            else
            {
                toolStripLoginLabel.Text = StaticParams.CurrentUser.Login;
                toolStripLoginLabel.ForeColor = Color.Blue;
            }
            DeckRefresh();
        }

        private void LeftDeckSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //загрузка выбранной колоды
            if (StaticParams.Access == StaticParams.AccessType.One)
                StaticParams.CurrentDeck = (new Deck((Deck)StaticParams.Decks[LeftDeckSelectionBox.SelectedIndex]));
            else if (StaticParams.Access == StaticParams.AccessType.Separate)
            {
                string filename = LeftDeckSelectionBox.Text;
                FileStream DeckFile = new FileStream(StaticParams.GetProgramDir() + "Data\\Decks\\" + filename
                    + ".dck", FileMode.Open, FileAccess.Read);
                BinaryFormatter DeckFormatter = new BinaryFormatter();
                LeftDeck = new Deck((Deck)DeckFormatter.Deserialize(DeckFile));
                LeftCardSelector.Maximum = LeftDeck.Cards.Count - 1;
                LeftEqualButton.PerformClick();
                DeckFile.Close();
            }
            LeftCardSelector.Value = 0;
            if (RightDeck.Cards.Count > 0)
            {
                LeftEqualButton.PerformClick();
                LeftCardSelector_ValueChanged(null, null);
            }
            else
                LeftLogoButton.PerformClick();
        }

        private void RightDeckSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StaticParams.Access == StaticParams.AccessType.One)
                StaticParams.CurrentDeck = (new Deck((Deck)StaticParams.Decks[RightDeckSelectionBox.SelectedIndex]));
            else if (StaticParams.Access == StaticParams.AccessType.Separate)
            {
                string filename = RightDeckSelectionBox.Text;
                FileStream DeckFile = new FileStream(StaticParams.GetProgramDir() + "Data\\Decks\\" + filename
                    + ".dck", FileMode.Open, FileAccess.Read);
                BinaryFormatter DeckFormatter = new BinaryFormatter();
                RightDeck = new Deck((Deck)DeckFormatter.Deserialize(DeckFile));
                RightCardSelector.Maximum = RightDeck.Cards.Count - 1;
                RightEqualButton.PerformClick();
                DeckFile.Close();
            }
            RightCardSelector.Value = 0;
            if (LeftDeck.Cards.Count > 0)
            {
                RightEqualButton.PerformClick();
                RightCardSelector_ValueChanged(null, null);
            }
            else
                RightLogoButton.PerformClick();

        }

        private void LeftEqualButton_Click(object sender, EventArgs e)
        {
            if (RightCardSelector.Value <= LeftCardSelector.Maximum)
            {
                LeftCardSelector.Value = RightCardSelector.Value;
            }
            else
                LeftLogoButton.PerformClick();
        }

        private void RightEqualButton_Click(object sender, EventArgs e)
        {
            if (LeftCardSelector.Value <= RightCardSelector.Maximum)
            {
                RightCardSelector.Value = LeftCardSelector.Value;
            }
            else
                RightLogoButton.PerformClick();
        }

        private void LeftCardSelector_ValueChanged(object sender, EventArgs e)
        {
            if (LeftDeck.Cards.Count > 0)
            {
                LeftCardName.Text = ((Deck.card)LeftDeck.Cards[(int)LeftCardSelector.Value]).CardName;
                LeftPictureBox.Image = ((Deck.card)LeftDeck.Cards[(int)LeftCardSelector.Value]).CardPicture;
                LeftDescriptionText.Rtf = ((Deck.card)LeftDeck.Cards[(int)LeftCardSelector.Value]).CardDescription;
                if (LeftSyncBox.Checked)
                    RightEqualButton.PerformClick();
            }
        }

        private void RightCardSelector_ValueChanged(object sender, EventArgs e)
        {
            if (RightDeck.Cards.Count > 0)
            {
                RightCardName.Text = ((Deck.card)RightDeck.Cards[(int)RightCardSelector.Value]).CardName;
                RightPictureBox.Image = ((Deck.card)RightDeck.Cards[(int)RightCardSelector.Value]).CardPicture;
                RightDescriptionText.Rtf = ((Deck.card)RightDeck.Cards[(int)RightCardSelector.Value]).CardDescription;
                if (RightSyncBox.Checked)
                    LeftEqualButton.PerformClick();
            }
        }

        private void LeftLogoButton_Click(object sender, EventArgs e)
        {
            LeftCardName.Text = LeftDeck.Name;
            LeftPictureBox.Image = LeftDeck.Logo;
            LeftDescriptionText.Rtf = LeftDeck.Description;
        }

        private void LeftBackButton_Click(object sender, EventArgs e)
        {
            LeftCardName.Text = LeftDeck.Name;
            LeftPictureBox.Image = LeftDeck.Back;
            LeftDescriptionText.Rtf = LeftDeck.Description;
        }

        private void RightLogoButton_Click(object sender, EventArgs e)
        {
            RightCardName.Text = RightDeck.Name;
            RightPictureBox.Image = RightDeck.Logo;
            RightDescriptionText.Rtf = RightDeck.Description;
        }

        private void RightBackButton_Click(object sender, EventArgs e)
        {
            RightCardName.Text = RightDeck.Name;
            RightPictureBox.Image = RightDeck.Back;
            RightDescriptionText.Rtf = RightDeck.Description;
        }

        private void LeftPictureBox_Click(object sender, EventArgs e)
        {
            if (LeftPictureBox.Image != null)
            {
                LargeImage LIM = new LargeImage(LeftPictureBox.Image);
                LIM.Show();
            }
        }

        private void RightPictureBox_Click(object sender, EventArgs e)
        {
            if (RightPictureBox.Image != null)
            {
                LargeImage LIM = new LargeImage(RightPictureBox.Image);
                LIM.Show();
            }
        }

        private void LeftSyncBox_CheckedChanged(object sender, EventArgs e)
        {
            RightSyncBox.Checked = LeftSyncBox.Checked;
        }

        private void RightSyncBox_CheckedChanged(object sender, EventArgs e)
        {
            LeftSyncBox.Checked = RightSyncBox.Checked;
        }

        #region Подсказки в строке состояния
        private void LeftDeckSelectionBox_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Выбор первой колоды для сравнения";
        }

        private void RightDeckSelectionBox_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Выбор второй колоды для сравнения";
        }

        private void LeftEqualButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Выбор карты с тем же номером, что и в правой колоде";
        }

        private void RightEqualButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Выбор карты с тем же номером, что и в левой колоде";
        }

        private void LeftCardSelector_Enter(object sender, EventArgs e)
        {
            toolStripTip.Text = "Установка номера карты левой колоды, которая будет отображена";
        }

        private void RightCardSelector_Enter(object sender, EventArgs e)
        {
            toolStripTip.Text = "Установка номера карты правой колоды, которая будет отображена";
        }

        private void LeftSyncBox_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Если включено, то при изменении номера карты, они будут меняться в обоих колодах";
        }

        private void RightSyncBox_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Если включено, то при изменении номера карты, они будут меняться в обоих колодах";
        }

        private void LeftCardName_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Название выбранной карты";
        }

        private void RightCardName_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Название выбранной карты";
        }

        private void LeftLogoButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Показывает обложку и описание колоды";
        }

        private void RightLogoButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Показывает обложку и описание колоды";
        }

        private void LeftBackButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Показывает рубашку и описание колоды";
        }

        private void RightBackButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Показывает рубашку и описание колоды";
        }

        private void LeftPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Изображение выбранного элемента левой колоды. Клик - отобразить в полном размере";
        }

        private void RightPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Изображение выбранного элемента правой колоды. Клик - отобразить в полном размере";
        }

        private void LeftDescriptionText_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Описание выбранного элемента левой колоды";
        }

        private void RightDescriptionText_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Описание выбранного элемента правой колоды";
        }

        private void LeftDeckSelectionBox_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void RightDeckSelectionBox_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void LeftEqualButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void RightEqualButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void LeftCardSelector_Leave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void RightCardSelector_Leave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void LeftCardName_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void RightCardName_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void LeftSyncBox_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void RightSyncBox_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void LeftLogoButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void RightLogoButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void LeftBackButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void RightBackButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void LeftPictureBox_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void RightPictureBox_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void LeftDescriptionText_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void RightDescriptionText_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }
        #endregion

        private void DeckComparerHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageForm MF = new MessageForm(((LinkLabel)sender).Name);
            MF.StartPosition = FormStartPosition.CenterParent;
            MF.ShowDialog();
        }

        private void DeckComparer_Activated(object sender, EventArgs e)
        {
            DeckComparerHelp.Visible = !StaticParams.CurrentUser.UserSettings.HideTips;
        }





    }
}
