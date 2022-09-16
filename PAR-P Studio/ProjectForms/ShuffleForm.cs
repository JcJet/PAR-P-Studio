using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PAR_P_Studio.ProjectForms;
using PAR_P_Studio.ProjectClasses;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Форма, позволяющая вручную перемешивать колоды
//© Владимир Андреев, PAR-P Corp.

namespace PAR_P_Studio.ProjectForms
{
    public partial class ShuffleForm : Form
    {
        public ShuffleForm()
        {
            InitializeComponent();

            CardList.ListViewItemSorter = new ListViewIndexComparer();
            CardList.InsertionMark.Color = Color.Green;

          
        }

        void SetColors()
        {
            this.BackColor = StaticParams.CurrentUser.UserSettings.WinColor;
            this.ForeColor = StaticParams.CurrentUser.UserSettings.LabelColor;
        }

        void CardsRefresh()
        {
            CardList.Items.Clear();
            CardImageList.Images.Clear();
            CardImageListClosed.Images.Clear();
            CardList.BeginUpdate();

            foreach (Deck.card item in StaticParams.CurrentDeck.Cards)
            {
                CardImageList.Images.Add(item.CardPicture);
                CardImageListClosed.Images.Add(Properties.Resources.CardIcon);
                CardList.Items.Add(item.CardName, CardImageList.Images.Count - 1);
            }
            CardList.EndUpdate();
        }
        void ApplyShuffle()
        {
            string ShufflePath = "Data\\Shuffles\\" + StaticParams.CurrentUser.Login + "\\" + StaticParams.CurrentDeck.Name + ".sfl";
            if (File.Exists(ShufflePath))
            {
                CardList.Items.Clear();
                CardList.BeginUpdate();
                FileStream SflFile = new FileStream(ShufflePath, FileMode.Open, FileAccess.Read);
                BinaryFormatter SflFormatter = new BinaryFormatter();
                StaticParams.CurrentShuffle = new Shuffle((Shuffle)SflFormatter.Deserialize(SflFile));
                SflFile.Close();

                CardList.Items.Clear();
                for (int i = 0; i < StaticParams.CurrentDeck.Cards.Count; i++)
                {
                    int index = -1;
                    for (int j = 0; j < StaticParams.CurrentShuffle.Cards.Count; j++)
                    {
                        if (((Shuffle.CardPosition)StaticParams.CurrentShuffle.Cards[j]).CardPos == i)
                        {
                            index = ((Shuffle.CardPosition)StaticParams.CurrentShuffle.Cards[j]).CardNumber;
                        }

                    }
                    CardList.Items.Add(((Deck.card)StaticParams.CurrentDeck.Cards[index]).CardName, index);
                }
                CardList.EndUpdate();
 
            }

        }

        private void ShuffleForm_Shown(object sender, EventArgs e)
        {
            CardsRefresh();
            StaticParams.CurrentShuffle = new Shuffle();
            for (int i = 0; i < CardList.Items.Count; i++)
                StaticParams.CurrentShuffle.Cards.Add(new Shuffle.CardPosition());
            ApplyShuffle();

        }

        private void ShowCardsBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowCardsBox.Checked)
                CardList.LargeImageList = CardImageList;
            else
                CardList.LargeImageList = CardImageListClosed;

        }

        private void ShowNamesBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowNamesBox.Checked)
            {
                for (int i = 0; i < CardList.Items.Count; i++)
                    CardList.Items[i].Text = ((Deck.card)StaticParams.CurrentDeck.Cards[CardList.Items[i].ImageIndex]).CardName;
            }
            else
                for (int i = 0; i < CardList.Items.Count; i++ )
                    CardList.Items[i].Text = "";
        }

        //
        // Код Drag and Drop'а, за основу был взят пример из MSDN
        //http://msdn.microsoft.com/ru-ru/library/system.windows.forms.listviewinsertionmark.aspx
        //

        // Starts the drag-and-drop operation when an item is dragged.
        private void CardList_ItemDrag(object sender, ItemDragEventArgs e)
        {
            CardList.DoDragDrop(e.Item, DragDropEffects.Move);
        }
        // Sets the target drop effect.
        private void CardList_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }
        // Moves the insertion mark as the item is dragged.
        private void CardList_DragOver(object sender, DragEventArgs e)
        {
            // Retrieve the client coordinates of the mouse pointer.
            Point targetPoint =
                CardList.PointToClient(new Point(e.X, e.Y));

            // Retrieve the index of the item closest to the mouse pointer.
            int targetIndex = CardList.InsertionMark.NearestIndex(targetPoint);

            // Confirm that the mouse pointer is not over the dragged item.
            if (targetIndex > -1)
            {
                // Determine whether the mouse pointer is to the left or
                // the right of the midpoint of the closest item and set
                // the InsertionMark.AppearsAfterItem property accordingly.
                Rectangle itemBounds = CardList.GetItemRect(targetIndex);
                if (targetPoint.X > itemBounds.Left + (itemBounds.Width / 2))
                {
                    CardList.InsertionMark.AppearsAfterItem = true;
                }
                else
                {
                    CardList.InsertionMark.AppearsAfterItem = false;
                }
            }

            // Set the location of the insertion mark. If the mouse is
            // over the dragged item, the targetIndex value is -1 and
            // the insertion mark disappears.
            CardList.InsertionMark.Index = targetIndex;
        }
        // Removes the insertion mark when the mouse leaves the control.
        private void CardList_DragLeave(object sender, EventArgs e)
        {
            CardList.InsertionMark.Index = -1;
        }

        private void CardList_DragDrop(object sender, DragEventArgs e)
        {
            // Retrieve the index of the insertion mark;
            int targetIndex = CardList.InsertionMark.Index;

            // If the insertion mark is not visible, exit the method.
            if (targetIndex == -1)
            {
                return;
            }

            // If the insertion mark is to the right of the item with
            // the corresponding index, increment the target index.
            if (CardList.InsertionMark.AppearsAfterItem)
            {
                targetIndex++;
            }

            // Retrieve the dragged item.
            ListViewItem draggedItem =
                (ListViewItem)e.Data.GetData(typeof(ListViewItem));

            // Insert a copy of the dragged item at the target index.
            // A copy must be inserted before the original item is removed
            // to preserve item index values. 
            CardList.Items.Insert(
                targetIndex, (ListViewItem)draggedItem.Clone());

            // Remove the original copy of the dragged item.
            CardList.Items.Remove(draggedItem);

        }

        // Sorts ListViewItem objects by index.
        private class ListViewIndexComparer : System.Collections.IComparer
        {
            public int Compare(object x, object y)
            {
                return ((ListViewItem)x).Index - ((ListViewItem)y).Index;
            }
        }

        

        private void CardList_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < CardList.Items.Count; i++)
            {
                int CardId = CardList.Items[i].ImageIndex;
                ((Shuffle.CardPosition)StaticParams.CurrentShuffle.Cards[i]).CardNumber = CardId;
                ((Shuffle.CardPosition)StaticParams.CurrentShuffle.Cards[i]).CardPos = i;
            }
            StaticParams.CurrentShuffle.SaveShuffle();
            Close();
        }

        private void CardList_ItemActivate(object sender, EventArgs e)
        {
            if (StaticParams.CurrentDeck.AllowUpsideDown)
            {
                if (((Shuffle.CardPosition)StaticParams.CurrentShuffle.Cards[CardList.SelectedIndices[0]]).UpsideDown == false)
                {
                    ((Shuffle.CardPosition)StaticParams.CurrentShuffle.Cards[CardList.SelectedIndices[0]]).UpsideDown = true;
                    CardList.Items[CardList.SelectedIndices[0]].Text = "(Перевернута)" + CardList.Items[CardList.SelectedIndices[0]].Text;
                }
                else
                {
                    ((Shuffle.CardPosition)StaticParams.CurrentShuffle.Cards[CardList.SelectedIndices[0]]).UpsideDown = false;
                    if (ShowNamesBox.Checked)
                        CardList.Items[CardList.SelectedIndices[0]].Text = ((Deck.card)StaticParams.CurrentDeck.Cards[CardList.SelectedIndices[0]]).CardName;
                    else
                        CardList.Items[CardList.SelectedIndices[0]].Text = "";
                }
            }
        }

    }
}
