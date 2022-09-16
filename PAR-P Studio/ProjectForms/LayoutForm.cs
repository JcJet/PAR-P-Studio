using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using PAR_P_Studio.ProjectForms;
using PAR_P_Studio.ProjectClasses;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using PAR_P_Studio.Dialogs;

//Окно, в котором происходит перемешивание и вытягивание карт для расклада.
//© Владимир Андреев, PAR-P Corp.

namespace PAR_P_Studio
{
    public partial class LayoutForm : Form
    {
        int step = 0;
        int LastCardIndex = StaticParams.CurrentDeck.Cards.Count;
        Random rnd = new Random();
        


        string ShufflePath = "Data\\Shuffles\\" + StaticParams.CurrentUser.Login + "\\" + StaticParams.CurrentDeck.Name + ".sfl";
        public LayoutForm()
        {
            InitializeComponent();

            if (StaticParams.CurrentUser.UserSettings.GetUserSeed)
            {
                GetUserSeed gus = new GetUserSeed();
                gus.ShowDialog();
                rnd = new Random(StaticParams.UserSeed);
            }
        }
        void SetColors()
        {
            this.BackColor = StaticParams.CurrentUser.UserSettings.WinColor;
            this.ForeColor = StaticParams.CurrentUser.UserSettings.LabelColor;
        }
        void AutoShuffle()
        {

            int rndInd, tempX, tempY;
            
            for (int i = 0; i < StaticParams.CurrentDeck.Cards.Count; i++)
            {
                
                if (rnd.Next(10) > StaticParams.CurrentUser.UserSettings.UDChance)
                    ((Deck.card)StaticParams.CurrentDeck.Cards[i]).Place.UpsideDown = true;

                do
                {
                    rndInd = rnd.Next(StaticParams.CurrentDeck.Cards.Count);
                } while (rndInd == i);

                tempX = ((Deck.card)StaticParams.CurrentDeck.Cards[i]).Place.X;
                tempY = ((Deck.card)StaticParams.CurrentDeck.Cards[i]).Place.Y;

                ((Deck.card)StaticParams.CurrentDeck.Cards[i]).Place.X =
                    ((Deck.card)StaticParams.CurrentDeck.Cards[rndInd]).Place.X;
                ((Deck.card)StaticParams.CurrentDeck.Cards[rndInd]).Place.X = tempX;

                ((Deck.card)StaticParams.CurrentDeck.Cards[i]).Place.Y =
                     ((Deck.card)StaticParams.CurrentDeck.Cards[rndInd]).Place.Y;
                ((Deck.card)StaticParams.CurrentDeck.Cards[rndInd]).Place.Y = tempY;

                tempX = ((Deck.card)StaticParams.CurrentDeck.Cards[i]).CardId;
                ((Deck.card)StaticParams.CurrentDeck.Cards[i]).CardId = ((Deck.card)StaticParams.CurrentDeck.Cards[rndInd]).CardId;
                ((Deck.card)StaticParams.CurrentDeck.Cards[rndInd]).CardId = tempX;

            }

        }

        Deck.card GetItemAt(int x, int y)
        {
            for (int i = StaticParams.CurrentDeck.Cards.Count - 1; i >= 0; i--)
            {
                Deck.card.ForDrawing currCard = ((Deck.card)StaticParams.CurrentDeck.Cards[i]).Place;
                if (
                    currCard.X < x &&
                    currCard.X + 20 > x &&
                    currCard.Y < y &&
                    currCard.Y + currCard.Height > y
                    )
                    return (Deck.card)StaticParams.CurrentDeck.Cards[i];
            }
            return null;
        }

        private void LayoutForm_Shown(object sender, EventArgs e)
        {
            SetColors();
            if (StaticParams.CurrentUser.UserSettings.AskQuestion)
            {
                AskQuestionForm aqf = new AskQuestionForm();
                aqf.ShowDialog();
            }

            int offset = 10;
            int tempY = 10;
            for (int i = 0; i < StaticParams.CurrentDeck.Cards.Count; i++)
            {
                ((Deck.card)StaticParams.CurrentDeck.Cards[i]).Place = new Deck.card.ForDrawing(offset, tempY);
                //offset += ((Deck.card)StaticParams.CurrentDeck.Cards[i]).Place.Width + 3;
                offset += 20;
                if ((offset + ((Deck.card)StaticParams.CurrentDeck.Cards[i]).Place.Width) > DrawingPanel.Width)
                {
                    offset = 10;
                    tempY += ((Deck.card)StaticParams.CurrentDeck.Cards[i]).Place.Height + 3;
                }
            }



            step = 1;
            DrawingPanel.Invalidate();
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {

            if (step == 1)
            {
                toolStripTextBox.Text = "Отображение карт. Нажмите, чтобы начать.";
                ShakeTimer.Interval = StaticParams.CurrentUser.UserSettings.ShakeSpeed;

                for (int i = 0; i < StaticParams.CurrentDeck.Cards.Count; i++)
                {
                    Image CurrentImage = ((Deck.card)StaticParams.CurrentDeck.Cards[i]).CardPicture;
                    e.Graphics.DrawImage
                        (
                        CurrentImage,
                        ((Deck.card)StaticParams.CurrentDeck.Cards[i]).Place.X,
                        ((Deck.card)StaticParams.CurrentDeck.Cards[i]).Place.Y,
                        ((Deck.card)StaticParams.CurrentDeck.Cards[i]).Place.Width,
                        ((Deck.card)StaticParams.CurrentDeck.Cards[i]).Place.Height
                        );
                }
            }
                if (step >= 2)
                {

                    for (int i = 0; i < LastCardIndex; i++)
                    {
                        Image CurrentImage;
                        if (StaticParams.CurrentUser.UserSettings.ShowCards && step == 2)
                            CurrentImage = ((Deck.card)StaticParams.CurrentDeck.Cards[i]).CardPicture;
                        else
                            CurrentImage = StaticParams.CurrentDeck.Back;
                        for (int j = 0; j < StaticParams.CurrentDeck.Cards.Count; j++)
                        {
                            if (((Deck.card)StaticParams.CurrentDeck.Cards[j]).CardId == i)
                            {
                                if (((Deck.card)StaticParams.CurrentDeck.Cards[j]).Place.UpsideDown && StaticParams.CurrentDeck.AllowUpsideDown)
                                    ((Deck.card)StaticParams.CurrentDeck.Cards[j]).CardPicture.RotateFlip(RotateFlipType.Rotate180FlipNone);
                                if (StaticParams.CurrentUser.UserSettings.ShowCards && step == 2)
                                    CurrentImage = ((Deck.card)StaticParams.CurrentDeck.Cards[j]).CardPicture;
                                else
                                    CurrentImage = StaticParams.CurrentDeck.Back;

                                e.Graphics.DrawImage
                                (
                                CurrentImage,
                                ((Deck.card)StaticParams.CurrentDeck.Cards[j]).Place.X,
                                ((Deck.card)StaticParams.CurrentDeck.Cards[j]).Place.Y,
                                ((Deck.card)StaticParams.CurrentDeck.Cards[j]).Place.Width,
                                ((Deck.card)StaticParams.CurrentDeck.Cards[j]).Place.Height
                                );
                            }

                        }
                    }


                    for (int i = 0; i < StaticParams.LayoutResult.Count; i++)
                    {
                        Image CurrentImage;
                        if (StaticParams.CurrentUser.UserSettings.HiddenLayout)
                            CurrentImage = StaticParams.CurrentDeck.Back;
                        else
                            CurrentImage = ((Deck.card)StaticParams.LayoutResult[i]).CardPicture;

                        e.Graphics.DrawImage
                            (
                            CurrentImage,
                            ((Deck.card)StaticParams.LayoutResult[i]).Place.X,
                            ((Deck.card)StaticParams.LayoutResult[i]).Place.Y,
                            ((Deck.card)StaticParams.LayoutResult[i]).Place.Width,
                            ((Deck.card)StaticParams.LayoutResult[i]).Place.Height
                            );
                    }
                }

        }


        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (step > 2)
            {
                toolStripTextBox.Text = "Вытягивайте карты. Еще " +
                    (StaticParams.CurrentLayoutType.CardPositions.Count - StaticParams.LayoutResult.Count) + ".";

                Deck.card item = GetItemAt(e.X, e.Y);
                if (item != null)
                {
                        StaticParams.CurrentUser.UserStatistics.DrawnCards++;
                        StaticParams.LayoutResult.Add(new Deck.card(item));
                        toolStripTextBox.Text = "Вытягивайте карты. Еще " +
                            (StaticParams.CurrentLayoutType.CardPositions.Count - StaticParams.LayoutResult.Count) + ".";
                        #region формула для ряда в правом нижнем углу формы
                        if (StaticParams.CurrentLayoutType.CardPositions.Count <= 5)
                        {
                            ((Deck.card)StaticParams.LayoutResult[StaticParams.LayoutResult.Count - 1]).Place = new Deck.card.ForDrawing(10, 10);
                            ((Deck.card)StaticParams.LayoutResult[StaticParams.LayoutResult.Count - 1]).Place.X =
                              DrawingPanel.Width -
                                (
                                    10 + (((Deck.card)StaticParams.LayoutResult[StaticParams.LayoutResult.Count - 1]).Place.Width) *
                                       (StaticParams.LayoutResult.Count)
                                );
                            ((Deck.card)StaticParams.LayoutResult[StaticParams.LayoutResult.Count - 1]).Place.Y =
                                DrawingPanel.Height -
                                (
                                  10 + (((Deck.card)StaticParams.LayoutResult[StaticParams.LayoutResult.Count - 1]).Place.Height)
                                );
                        }
                        else if (StaticParams.CurrentLayoutType.CardPositions.Count > 5)
                        {
                            ((Deck.card)StaticParams.LayoutResult[StaticParams.LayoutResult.Count - 1]).Place = new Deck.card.ForDrawing(10, 10);
                            ((Deck.card)StaticParams.LayoutResult[StaticParams.LayoutResult.Count - 1]).Place.X =
                              DrawingPanel.Width -
                                (
                                    (((Deck.card)StaticParams.LayoutResult[StaticParams.LayoutResult.Count - 1]).Place.Width) + 20 *
                                       (StaticParams.LayoutResult.Count)
                                );
                            ((Deck.card)StaticParams.LayoutResult[StaticParams.LayoutResult.Count - 1]).Place.Y =
                                DrawingPanel.Height -
                                (
                                  10 + (((Deck.card)StaticParams.LayoutResult[StaticParams.LayoutResult.Count - 1]).Place.Height)
                                );

                        }
                        #endregion
                        if (!StaticParams.CurrentUser.UserSettings.SameCards)
                            foreach (Deck.card currCard in StaticParams.CurrentDeck.Cards)
                            {
                                if (currCard.CardName == ((Deck.card)StaticParams.LayoutResult[StaticParams.LayoutResult.Count - 1]).CardName)
                                {
                                    StaticParams.CurrentDeck.Cards.Remove(currCard);
                                    
                                    break;
                                }
                            }
                        //когда все позиции заполнены - вывод результата
                    if (StaticParams.LayoutResult.Count == StaticParams.CurrentLayoutType.CardPositions.Count) 
                    {
                        toolStripTextBox.Text = "Готово";
                        Close();
                        step = 0;
                        LayoutResult lr = new LayoutResult();
                        lr.StartPosition = FormStartPosition.CenterScreen;
                        if (StaticParams.CurrentUser.UserSettings.MaximizeLayout)
                            lr.WindowState = FormWindowState.Maximized;
                        lr.ShowDialog();

                    }

                }
            }

        }

        private void DrawingPanel_Click(object sender, EventArgs e)
        {
            step++;
            if (step > 2)
                ShakeTimer.Enabled = false;
            if (step == 2)
            {
                if (StaticParams.CurrentUser.UserSettings.ShakeMode == User.LayoutMode.Auto)
                {
                    toolStripTextBox.Text = "Перемешивание карт. Нажмите, чтобы остановить";
                    ShakeTimer.Enabled = true;
                }
                else if (StaticParams.CurrentUser.UserSettings.ShakeMode == User.LayoutMode.Manual)
                {
                    if (File.Exists(ShufflePath))
                    {
                        FileStream SflFile = new FileStream(ShufflePath, FileMode.Open, FileAccess.Read);
                        BinaryFormatter SflFormatter = new BinaryFormatter();
                        StaticParams.CurrentShuffle = new Shuffle((Shuffle)SflFormatter.Deserialize(SflFile));
                        SflFile.Close();

                        int offset = 10;
                        int tempY = 10;
                        for (int i = 0; i < StaticParams.CurrentDeck.Cards.Count; i++)
                        {
                            int index = -1;
                            for (int j = 0; j < StaticParams.CurrentShuffle.Cards.Count; j++)
                            {
                                if (((Shuffle.CardPosition)StaticParams.CurrentShuffle.Cards[i]).CardPos == i)
                                {
                                    index = ((Shuffle.CardPosition)StaticParams.CurrentShuffle.Cards[i]).CardNumber;
                                }
                                 
                            }
                            ((Deck.card)StaticParams.CurrentDeck.Cards[index]).Place = new Deck.card.ForDrawing(offset, tempY);
                            offset += 20;
                            if ((offset + ((Deck.card)StaticParams.CurrentDeck.Cards[i]).Place.Width) > DrawingPanel.Width)
                            {
                                offset = 10;
                                tempY += ((Deck.card)StaticParams.CurrentDeck.Cards[i]).Place.Height + 3;
                            }
                        }

                    }

                    else
                    {
                        switch (MessageBox.Show("Вы еще не перемешивали эту колоду. Сменить настройки на авто?", "Вопрос", MessageBoxButtons.YesNo))
                        {
                            case DialogResult.Yes:
                                {
                                    StaticParams.CurrentUser.UserSettings.ShakeMode = User.LayoutMode.Auto;
                                    toolStripTextBox.Text = "Перемешивание карт. Нажмите, чтобы остановить";
                                    ShakeTimer.Enabled = true;
                                    break;
                                }
                            case DialogResult.No:
                                {
                                    Close();
                                    break;
                                }
                        }

                    }
                }
            }
            if (step == 3)
            {
                toolStripTextBox.Text = "Вытягивайте карты. Для расклада требуется " +
                            (StaticParams.CurrentLayoutType.CardPositions.Count - StaticParams.LayoutResult.Count) + ".";
                ShakeTimer.Enabled = false;
            }


            DrawingPanel.Invalidate();
        }

        private void ShakeTimer_Tick(object sender, EventArgs e)
        {
            if (step == 2)
            {
                AutoShuffle();
                if (StaticParams.CurrentUser.UserSettings.ShowCards)
                    DrawingPanel.Invalidate();
            }
        }

        private void LayoutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShakeTimer.Enabled = false;
        }







    }
}
