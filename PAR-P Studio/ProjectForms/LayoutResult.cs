using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using PAR_P_Studio.ProjectForms;
using PAR_P_Studio.ProjectClasses;
using PAR_P_Studio.Dialogs;
using System.Runtime.Serialization.Formatters.Binary;

//Окно, в котором выводится итог расклада, когда вытянуты все нужные карты
//© Владимир Андреев, PAR-P Corp.

namespace PAR_P_Studio
{
    public partial class LayoutResult : Form
    {
        int CurrentIndex = 0;
        public bool SaveResult = true;
        bool[] Opened;
        Deck Overriding;
        public LayoutResult()
        {
            InitializeComponent();
        }

        void SetColors()
        {
            this.BackColor = StaticParams.CurrentUser.UserSettings.WinColor;
            this.ForeColor = StaticParams.CurrentUser.UserSettings.LabelColor;
        }
        void SetDescription(int index)
        {
            CardImage.Image = ((Deck.card)StaticParams.LayoutResult[index]).CardPicture;
            Description.Rtf = ((Deck.card)StaticParams.LayoutResult[index]).CardDescription;
            PosDescription.Text =
                (
                    ((LayoutType.CardPos)StaticParams.CurrentLayoutType.CardPositions[index]).Number.ToString() + ". " +
                    ((LayoutType.CardPos)StaticParams.CurrentLayoutType.CardPositions[index]).Description.ToString()
                );
            //Проверка: стоит ли в конце точка. Если нет, поставить. Так красивее.
            if (((LayoutType.CardPos)StaticParams.CurrentLayoutType.CardPositions[index]).Description.ToString() != "")
            {
                char[] chars = ((LayoutType.CardPos)StaticParams.CurrentLayoutType.CardPositions[index]).Description.ToString().ToCharArray();
                if (chars[chars.Length - 1] != '.')
                    PosDescription.Text += ".";
            }
        }


        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {


            foreach (LayoutType.CardPos currPos in StaticParams.CurrentLayoutType.CardPositions)
            {
                if (currPos.X + currPos.Width > DrawingPanel.AutoScrollMinSize.Width)
                    DrawingPanel.AutoScrollMinSize = new Size(currPos.X + currPos.Width + 15, DrawingPanel.AutoScrollMinSize.Height);
                if (currPos.Y > DrawingPanel.AutoScrollMinSize.Height)
                    DrawingPanel.AutoScrollMinSize = new Size(DrawingPanel.AutoScrollMinSize.Width, currPos.Y + currPos.Height + 15);


                Bitmap bmp;
                if (StaticParams.CurrentUser.UserSettings.HiddenLayout && !Opened[currPos.Number - 1] && SaveResult)
                    bmp = (Bitmap)StaticParams.CurrentDeck.Back;
                else
                    bmp = (Bitmap)((Deck.card)StaticParams.LayoutResult[currPos.Number - 1]).CardPicture;

                currPos.Draw(e.Graphics, DrawingPanel.AutoScrollPosition.X, DrawingPanel.AutoScrollPosition.Y, bmp);
            }

        }

        private void LayoutResult_Shown(object sender, EventArgs e)
        {
            if (StaticParams.CurrentUser.UserSettings.OverrideDeck != "")
            {
                if (StaticParams.Access == StaticParams.AccessType.One)
                {
                    Overriding = (new Deck((Deck)StaticParams.Decks.Find(
                        delegate(Deck dck)
                        {
                            return dck.Name == StaticParams.CurrentUser.UserSettings.OverrideDeck;
                        })));
                }
                else if (StaticParams.Access == StaticParams.AccessType.Separate)
                {
                    try
                    {
                        FileStream DeckFile = new FileStream(StaticParams.GetProgramDir() + "Data\\Decks\\" +
                            StaticParams.CurrentUser.UserSettings.OverrideDeck
                            + ".dck", FileMode.Open, FileAccess.Read);

                        BinaryFormatter DeckFormatter = new BinaryFormatter();
                        Overriding = new Deck((Deck)DeckFormatter.Deserialize(DeckFile));
                        DeckFile.Close();
                    }
                    catch
                    {
                        Overriding = null;
                    }
                }
                if (Overriding != null)
                {
                    foreach (Deck.card currCard in StaticParams.LayoutResult)
                    {
                        if (currCard.CardOrder < Overriding.Cards.Count - 1)
                            currCard.CardDescription = Overriding.Cards[currCard.CardOrder].CardDescription;
                    }
                }
            }




            if (SaveResult)
                StaticParams.CurrentUser.UserStatistics.LayoutCount++;

            if (!StaticParams.CurrentUser.UserSettings.HiddenLayout)
                SetDescription(0);
            else
            {
                Opened = new bool[StaticParams.LayoutResult.Count];
                for (int i = 0; i < StaticParams.LayoutResult.Count; i++)
                    Opened[i] = false;
            }

            textQuestion.Text = StaticParams.Question;
            LayoutNameLabel.Text = "Расклад " + StaticParams.CurrentLayoutType.Name;
            LayoutDescriptionRtf.Rtf = StaticParams.CurrentLayoutType.Description;
            CommentHelp.Visible = !StaticParams.CurrentUser.UserSettings.HideTips;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (CurrentIndex < StaticParams.LayoutResult.Count - 1)
                CurrentIndex++;
            else CurrentIndex = 0;
            SetDescription(CurrentIndex);
            if (StaticParams.CurrentUser.UserSettings.HiddenLayout && SaveResult)
            {
                Opened[CurrentIndex] = true;
                DrawingPanel.Invalidate();
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (CurrentIndex > 0)
                CurrentIndex--;
            else CurrentIndex = StaticParams.LayoutResult.Count - 1;
            SetDescription(CurrentIndex);
            if (StaticParams.CurrentUser.UserSettings.HiddenLayout && SaveResult)
            {
                Opened[CurrentIndex] = true;
                DrawingPanel.Invalidate();
            }
        }

        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LayoutType.CardPos pos = StaticParams.GetItemAt(e.X - DrawingPanel.AutoScrollPosition.X, e.Y - DrawingPanel.AutoScrollPosition.Y);
            if (pos != null)
            {
                CurrentIndex = pos.Number-1;
                SetDescription(CurrentIndex);
                if (StaticParams.CurrentUser.UserSettings.HiddenLayout && SaveResult)
                {
                    Opened[CurrentIndex] = true;
                    DrawingPanel.Invalidate();
                }
            }
        }

        private void LayoutResult_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (SaveResult)
                StaticParams.CurrentUser.UserStatistics.LayoutStats.Add
                    (new User.Statistics.LayoutDetails(StaticParams.LayoutResult, DateTime.Now, StaticParams.Question, StaticParams.CurrentLayoutType.Name,
                        StaticParams.CurrentDeck.Name, StaticParams.Comment));
            else
                SaveResult = true;

            StaticParams.LayoutResult.Clear();
            StaticParams.Question = "";
        }

        private void DrawingPanel_Scroll(object sender, ScrollEventArgs e)
        {
            DrawingPanel.Invalidate();
        }

        private void CardImage_Click(object sender, EventArgs e)
        {
            if (CardImage.Image != null)
            {
                LargeImage LIM = new LargeImage(CardImage.Image);
                LIM.Show();
            }

        }

        private void CommentButton_Click(object sender, EventArgs e)
        {
            Notebook NB = new Notebook();
            NB.WindowState = FormWindowState.Maximized;
            NB.TextRtf.Rtf = StaticParams.Comment;
            if (!SaveResult)
                NB.TextRtf.ReadOnly = true;
            NB.ShowDialog();
            StaticParams.Comment = NB.TextRtf.Rtf;
        }

        private void CommentHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageForm MF = new MessageForm(((LinkLabel)sender).Name);
            MF.StartPosition = FormStartPosition.CenterParent;
            MF.ShowDialog();
        }

        private void CommentHelp_MouseMove(object sender, MouseEventArgs e)
        {
            CommentHelp.Text = "Что это?";
        }

        private void CommentHelp_MouseLeave(object sender, EventArgs e)
        {
            CommentHelp.Text = "?";
        }


    }
}
