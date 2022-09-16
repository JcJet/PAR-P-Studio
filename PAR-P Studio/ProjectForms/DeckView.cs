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
using PAR_P_Studio.ProjectForms;
using PAR_P_Studio.ProjectClasses;

//Окно для более удобного просмотра колод, или для демонстрации
//© Владимир Андреев, PAR-P Corp.

namespace PAR_P_Studio
{
    public partial class DeckView : Form
    {

        public DeckView()
        {
            InitializeComponent();
        }
        void SetColors()
        {
            this.BackColor = StaticParams.CurrentUser.UserSettings.WinColor;
            this.ForeColor = StaticParams.CurrentUser.UserSettings.LabelColor;
            CardImage.BackColor = StaticParams.CurrentUser.UserSettings.WinColor;
        }
        int CurrentCardIndex = -1;
        int RandomCardsCounter = 0;
        public bool ShowCurrentDeck = false;

        void ShowInfo()
        {
            if (CurrentCardIndex >= 0 && CurrentCardIndex < StaticParams.CurrentDeck.Cards.Count)
            {
                DescriptionBox.Rtf = ((Deck.card)StaticParams.CurrentDeck.Cards[CurrentCardIndex]).CardDescription;
                CardImage.Image = ((Deck.card)StaticParams.CurrentDeck.Cards[CurrentCardIndex]).CardPicture;
                CardNameLabel.Text = ((Deck.card)StaticParams.CurrentDeck.Cards[CurrentCardIndex]).CardName;
                CardCounterLabel.Text = String.Format("{0}/{1}", CurrentCardIndex + 1, StaticParams.CurrentDeck.Cards.Count);
            }
        }

        void SetAnotherDeck()
        {
            if (StaticParams.Access == StaticParams.AccessType.One)
                StaticParams.CurrentDeck = (new Deck((Deck)StaticParams.Decks[DeckSelectionBox.SelectedIndex]));
            else if (StaticParams.Access == StaticParams.AccessType.Separate)
            {
                string name = DeckSelectionBox.Text;
                FileStream DeckFile = new FileStream(StaticParams.GetProgramDir() + "Data\\Decks\\" + name
                    + ".dck", FileMode.Open, FileAccess.Read);
                BinaryFormatter DeckFormatter = new BinaryFormatter();
                StaticParams.CurrentDeck = new Deck((Deck)DeckFormatter.Deserialize(DeckFile));
                DeckFile.Close();

            }
            ShowDeckDescriptionButton.PerformClick();
            RandomCardsCounter = 0;


        }

        void FillDeckList()
        {
            DeckSelectionBox.Items.Clear();
            DeckSelectionBox.BeginUpdate();
            if (StaticParams.Access == StaticParams.AccessType.One)
                foreach (Deck item in StaticParams.Decks)
                    DeckSelectionBox.Items.Add(item.Name);

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
                        DeckSelectionBox.Items.Add(tempDeck.Name);

                        DeckFile.Close();
                    }
                    catch { }
                }

            }
            DeckSelectionBox.EndUpdate();

        }

        private void DeckView_Shown(object sender, EventArgs e)
        {
            SetColors();
            FillDeckList();
            if (ShowCurrentDeck)
                ShowDeckDescriptionButton.PerformClick();
            else
            {
                if (DeckSelectionBox.Items.Count != 0)
                    DeckSelectionBox.SelectedIndex = 0;
                else
                {
                    MessageBox.Show("У вас пока нет ни одной колоды. Вызов этого окна не имеет смысла.");
                    Close();
                }
            }
        }

        private void ShowDeckDescriptionButton_Click(object sender, EventArgs e)
        {
            DescriptionBox.Rtf = StaticParams.CurrentDeck.Description;
            CardImage.Image = StaticParams.CurrentDeck.Logo;
            CurrentCardIndex = -1;
            CardNameLabel.Text = StaticParams.CurrentDeck.Name;
            CardCounterLabel.Text = "";
        }

        private void NextCardButton_Click(object sender, EventArgs e)
        {
            if (CurrentCardIndex < StaticParams.CurrentDeck.Cards.Count - 1)
                CurrentCardIndex++;
            else
                CurrentCardIndex = 0;

            ShowInfo();
        }

        private void PreviousCardButton_Click(object sender, EventArgs e)
        {
            if (CurrentCardIndex > 0)
                CurrentCardIndex--;
            else
                CurrentCardIndex = StaticParams.CurrentDeck.Cards.Count - 1;

            ShowInfo();
        }

        private void DeckSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeckSelectionBox.SelectedIndex != -1)
            {
                SetAnotherDeck();
                ShowDeckDescriptionButton.PerformClick();
            }
        }

        private void DemoCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ShowTimer.Enabled = DemoCheckbox.Checked;
            DemoCheckboxDeck.Visible = DemoCheckbox.Checked;
            SpeedBar.Visible = DemoCheckbox.Checked;
            SpeedLabel.Visible = DemoCheckbox.Checked;
            ShuffleBox.Visible = DemoCheckbox.Checked;
        }

        private void ShowTimer_Tick(object sender, EventArgs e)
        {

            if (!ShuffleBox.Checked)
            {
                if (DemoCheckboxDeck.Checked && CurrentCardIndex == StaticParams.CurrentDeck.Cards.Count - 1)
                {
                    if (DeckSelectionBox.SelectedIndex < DeckSelectionBox.Items.Count - 1)
                        DeckSelectionBox.SelectedIndex++;
                    else DeckSelectionBox.SelectedIndex = 0;
                }
                NextCardButton.PerformClick();
            }

            else if (ShuffleBox.Checked)
            {
                Random rnd = new Random();
                CurrentCardIndex = rnd.Next(StaticParams.CurrentDeck.Cards.Count - 1);
                ShowInfo();
                if (DemoCheckboxDeck.Checked)
                {
                    RandomCardsCounter++;
                    if (RandomCardsCounter >= StaticParams.CurrentDeck.Cards.Count)
                    {
                        if (DeckSelectionBox.SelectedIndex < DeckSelectionBox.Items.Count - 1)
                            DeckSelectionBox.SelectedIndex++;
                        else DeckSelectionBox.SelectedIndex = 0;
                    }
                }
                else
                    RandomCardsCounter = 0;
            }
        }

        private void SpeedBar_ValueChanged(object sender, EventArgs e)
        {
            switch (SpeedBar.Value)
            {
                case 1:
                    {
                        ShowTimer.Interval = 50000;
                        break;
                    }
                case 2:
                    {
                        ShowTimer.Interval = 10000;
                        break;
                    }
                case 3:
                    {
                        ShowTimer.Interval = 7000;
                        break;
                    }
                case 4:
                    {
                        ShowTimer.Interval = 5000;
                        break;
                    }
                case 5:
                    {
                        ShowTimer.Interval = 3000;
                        break;
                    }
                case 6:
                    {
                        ShowTimer.Interval = 2000;
                        break;
                    }
                case 7:
                    {
                        ShowTimer.Interval = 1000;
                        break;
                    }
                case 8:
                    {
                        ShowTimer.Interval = 700;
                        break;
                    }
                case 9:
                    {
                        ShowTimer.Interval = 500;
                        break;
                    }

            }

        }

        private void CardImage_Click(object sender, EventArgs e)
        {
            if (CardImage.Image != null)
            {
                LargeImage LIM = new LargeImage(CardImage.Image);
                LIM.Show();
            }

        }



    }
}
