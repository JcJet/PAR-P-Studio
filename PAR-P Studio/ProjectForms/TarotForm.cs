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
using System.Runtime.Serialization.Formatters.Binary;
using PAR_P_Studio.ProjectForms;
using PAR_P_Studio.ProjectClasses;
using PAR_P_Studio.Dialogs;

//Главное окно для работы с Таро
//© Владимир Андреев, PAR-P Corp.

namespace PAR_P_Studio
{
    public partial class TarotForm : Form
    {
        public TarotForm()
        {
            InitializeComponent();
            TarotTabs.SelectedTab = TarotViewTab;
            SetTips();
            toolStripTip.Text = "";
            StaticParams.CurrentDeck = new Deck();
        }

        void SetColors()
        {
            this.BackColor = StaticParams.CurrentUser.UserSettings.WinColor;
            this.ForeColor = StaticParams.CurrentUser.UserSettings.LabelColor;
            TarotViewTab.BackColor = StaticParams.CurrentUser.UserSettings.BGColor;
            TarotRollTab.BackColor = StaticParams.CurrentUser.UserSettings.BGColor;
            StatisticsTab.BackColor = StaticParams.CurrentUser.UserSettings.BGColor;
            DeckMisc.BackColor = StaticParams.CurrentUser.UserSettings.BGColor;
        }

        void SetParams()
        {
            SameCardsCheckbox.Checked = StaticParams.CurrentUser.UserSettings.SameCards;
            ShowCardsCheckbox.Checked = StaticParams.CurrentUser.UserSettings.ShowCards;
            MaximizedLayoutWindow.Checked = StaticParams.CurrentUser.UserSettings.MaximizeLayout;
            AskQuestionBox.Checked = StaticParams.CurrentUser.UserSettings.AskQuestion;
            GetUserSeedBox.Checked = StaticParams.CurrentUser.UserSettings.GetUserSeed;
            HideTipsBox.Checked = StaticParams.CurrentUser.UserSettings.HideTips;
            HiddenLayoutBox.Checked = StaticParams.CurrentUser.UserSettings.HiddenLayout;
            UpsideDownBar.Value = StaticParams.CurrentUser.UserSettings.UDChance;
            UpsideDownBar_Scroll(null, null);
            switch (StaticParams.CurrentUser.UserSettings.ShakeMode)
            {
                case (User.LayoutMode.Auto):
                    {
                        radioAuto.Checked = true;
                        break;
                    }
                case (User.LayoutMode.Manual):
                    {
                        radioManual.Checked = true;
                        break;
                    }
            }
            #region switch (StaticParams.CurrentUser.UserSettings.ShakeSpeed)
            switch (StaticParams.CurrentUser.UserSettings.ShakeSpeed)
            {
                case 1000:
                    {
                        ShakeSpeedBar.Value = 1;
                        break;
                    }
                case 700:
                    {
                        ShakeSpeedBar.Value = 2;
                        break;
                    }
                case 500:
                    {
                        ShakeSpeedBar.Value = 3;
                        break;
                    }
                case 300:
                    {
                        ShakeSpeedBar.Value = 4;
                        break;
                    }
                case 100:
                    {
                        ShakeSpeedBar.Value = 5;
                        break;
                    }
                case 70:
                    {
                        ShakeSpeedBar.Value = 6;
                        break;
                    }
                case 50:
                    {
                        ShakeSpeedBar.Value = 7;
                        break;
                    }
                case 30:
                    {
                        ShakeSpeedBar.Value = 8;
                        break;
                    }
                case 10:
                    {
                        ShakeSpeedBar.Value = 9;
                        break;
                    }
                case 1:
                    {
                        ShakeSpeedBar.Value = 10;
                        break;
                    }


            }
            #endregion


        }
        void SetTips()
        {
            SameCardsHelp.Visible = !StaticParams.CurrentUser.UserSettings.HideTips;
            ShowCardsHelp.Visible = !StaticParams.CurrentUser.UserSettings.HideTips;
            MaximizeHelp.Visible = !StaticParams.CurrentUser.UserSettings.HideTips;
            QuestionHelp.Visible = !StaticParams.CurrentUser.UserSettings.HideTips;
            UserSeedHelp.Visible = !StaticParams.CurrentUser.UserSettings.HideTips;
            HideTipsHelp.Visible = !StaticParams.CurrentUser.UserSettings.HideTips;
            ShuffleSpeedHelp.Visible = !StaticParams.CurrentUser.UserSettings.HideTips;
            AutoShuffleHelp.Visible = !StaticParams.CurrentUser.UserSettings.HideTips;
            ManualShuffleHelp.Visible = !StaticParams.CurrentUser.UserSettings.HideTips;
            PublicDeckHelp.Visible = !StaticParams.CurrentUser.UserSettings.HideTips;
            UpsideDownHelp.Visible = !StaticParams.CurrentUser.UserSettings.HideTips;
            HiddenLayoutHelp.Visible = !StaticParams.CurrentUser.UserSettings.HideTips;
            UDChanceHelp.Visible = !StaticParams.CurrentUser.UserSettings.HideTips;
            DidYouKnowButton.Visible = !StaticParams.CurrentUser.UserSettings.HideTips;

        }
        void LoadLayout(string name)
        {
            FileStream LayoutFile = new FileStream(StaticParams.GetProgramDir() + "Data\\Layouts\\" + name + ".lyt",
                FileMode.Open, FileAccess.Read);
            BinaryFormatter LayoutFormatter = new BinaryFormatter();
            StaticParams.CurrentLayoutType = new LayoutType((LayoutType)LayoutFormatter.Deserialize(LayoutFile));
            LayoutFile.Close();
        }
        void LoadDeck(string name)
        {
            FileStream DeckFile = new FileStream(StaticParams.GetProgramDir() + "Data\\Decks\\" + name
                + ".dck", FileMode.Open, FileAccess.Read);
            BinaryFormatter DeckFormatter = new BinaryFormatter();
            StaticParams.CurrentDeck = new Deck((Deck)DeckFormatter.Deserialize(DeckFile));
            DeckFile.Close();
            GC.Collect(2);
            GC.WaitForPendingFinalizers();
        }
        void ChooseImage()
        {
            Image image = Properties.Resources.vopros;
            if (CardImage.Image != null)
                image = CardImage.Image;

            Files.OpenImage(ref image);
            if (image != null)
            {
                CardImage.Image = image;

                if (CardList.SelectedItems.Count == 0)
                {
                    if (DeckBackBox.Checked)
                        StaticParams.CurrentDeck.Back = image;
                    else
                        StaticParams.CurrentDeck.Logo = image;
                }
                else
                {
                    ((Deck.card)StaticParams.CurrentDeck.Cards[CardList.SelectedIndices[0]]).CardPicture = image;
                    Bitmap bmp = new Bitmap(image, 33, 46);
                    CardImageList.Images[CardList.SelectedIndices[0]] = bmp;
                }
                CardList.Select();
            }

        }
        void ChooseAuthorImage()
        {
            Image image = Properties.Resources.vopros;
            if (AuthorPictureBox.Image != null)
                image = AuthorPictureBox.Image;

            Files.OpenImage(ref image);
            if (image != null)
                StaticParams.CurrentDeck.AuthorImage = image;
            AuthorPictureBox.Image = image;

        }
        public void TypesRefresh()
        {
            TypesList.Items.Clear();
            TypesList.BeginUpdate();
            if (StaticParams.Access == StaticParams.AccessType.One)
                foreach (LayoutType item in StaticParams.Layouts)
                    TypesList.Items.Add(item.Name);

            else if (StaticParams.Access == StaticParams.AccessType.Separate)
            {
                LayoutType tempLayout = new LayoutType();
                string[] files = Directory.GetFiles(StaticParams.GetProgramDir() + "Data\\Layouts");
                foreach (string item in files)
                {
                    try
                    {

                        FileStream LayoutFile = new FileStream(item,
                            FileMode.Open, FileAccess.Read);
                        BinaryFormatter UserFormatter = new BinaryFormatter();
                        tempLayout = new LayoutType((LayoutType)UserFormatter.Deserialize(LayoutFile));
                        if (!OwnedOnly.Checked || tempLayout.Owner == StaticParams.CurrentUser.Login)
                            TypesList.Items.Add(tempLayout.Name);
                        LayoutFile.Close();
                    }
                    catch { }
                }
            }

            TypesList.EndUpdate();
        }
        void DeckRefresh()
        {
            DeckSelectionBox.BeginUpdate();
            DeckSelectionBox.Items.Clear();
            OverrideBox.BeginUpdate();
            OverrideBox.Items.Clear();
            OverrideBox.Items.Add("[Отключено]");
            if (StaticParams.Access == StaticParams.AccessType.One)
                foreach (Deck item in StaticParams.Decks)
                {
                    DeckSelectionBox.Items.Add(item.Name);
                    OverrideBox.Items.Add(item.Name);
                }

            else if (StaticParams.Access == StaticParams.AccessType.Separate)
            {
                if (!OwnedOnly.Checked)
                {
                    string[] files = Directory.GetFiles(StaticParams.GetProgramDir() + "Data\\Decks");
                    foreach (string item in files)
                    {
                        if (item.IndexOf(".dck") == item.Length - 4)
                        {
                            string file = item;
                            file = file.Remove(file.Length - 4);
                            char[] chars = file.ToCharArray();
                            file = "";
                            foreach (char currChar in chars)
                            {
                                file += currChar;
                                if (currChar == '\\')
                                    file = "";
                            }
                            DeckSelectionBox.Items.Add(file);
                            OverrideBox.Items.Add(file);
                        }
                    }
                }
                else if (OwnedOnly.Checked)
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
                            if (!OwnedOnly.Checked || tempDeck.Owner == StaticParams.CurrentUser.Login)
                                DeckSelectionBox.Items.Add(tempDeck.Name);
                            OverrideBox.Items.Add(tempDeck.Name);
                            DeckFile.Close();
                        }
                        catch { }
                    }
                }
            }
            DeckSelectionBox.EndUpdate();
            OverrideBox.EndUpdate();

            if (StaticParams.CurrentUser.UserSettings.OverrideDeck != "")
            {
                bool found = false;
                for (int i = 0; i < OverrideBox.Items.Count; i++)
                {
                    if (OverrideBox.Items[i].ToString() == StaticParams.CurrentUser.UserSettings.OverrideDeck)
                    {
                        OverrideBox.SelectedIndex = i;
                        found = true;
                        break;
                    }
                }
                if (!found)
                    OverrideBox.SelectedIndex = 0;
            }

        }
        void CardsRefresh()
        {
            CardList.Items.Clear();
            CardImageList.Images.Clear();
            CardList.BeginUpdate();

            foreach (Deck.card item in StaticParams.CurrentDeck.Cards)
            {
                CardImageList.Images.Add(item.CardPicture);
                CardList.Items.Add(item.CardName,CardImageList.Images.Count-1); 
            }
            CardImage.Image = Properties.Resources.vopros;
            //DescriptionText.Rtf = null;
            CardList.EndUpdate();
        }
        void StatsRefresh()
        {
            StatisticsList.Items.Clear();
            StatisticsList.BeginUpdate();
            foreach (User.Statistics.LayoutDetails item in StaticParams.CurrentUser.UserStatistics.LayoutStats)
            {
                ListViewItem newItem = new ListViewItem(item.LayoutDate.ToString());
                newItem.SubItems.Add(item.LType);
                newItem.SubItems.Add(item.LDeck);
                newItem.SubItems.Add(item.Question);
                newItem.SubItems.Add(item.Comment);
                StatisticsList.Items.Add(newItem);
            }
            StatisticsList.EndUpdate();
                
        }
        void SaveDeckSeparate()
        {
            if (File.Exists(StaticParams.GetProgramDir() + "Data\\Decks\\" + DeckSelectionBox.Text + ".dck"))
            {

                switch (MessageBox.Show("Вы внесли изменения в существующую колоду. Заменить ее? Нажмите \"Нет\" для создания новой",
                 "Выбор", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        {
                            StaticParams.CurrentDeck.Name = DeckSelectionBox.Text;
                            Deck tempDeck = new Deck();
                            FileStream DeckFile = new FileStream(StaticParams.GetProgramDir() + "Data\\Decks\\" + DeckSelectionBox.Text + ".dck",
                                FileMode.Open, FileAccess.Read);
                            BinaryFormatter UserFormatter = new BinaryFormatter();
                            tempDeck = new Deck((Deck)UserFormatter.Deserialize(DeckFile));
                            DeckFile.Close();
                            if (tempDeck.Owner == StaticParams.CurrentUser.Login || tempDeck.FreeAccess)
                            {
                                StaticParams.Events.Add(new Event("Изменение колоды", StaticParams.CurrentDeck.Name));
                                StaticParams.CurrentDeck.SaveDeck();
                            }
                            else
                                MessageBox.Show("Эта колода создана не вами, замена невозможна");
                            break;
                        }
                    case DialogResult.No:
                        {
                            StaticParams.Events.Add(new Event("Создание новой колоды на основе существующей", StaticParams.CurrentDeck.Name));
                            for (int i = 2; ; i++)
                            {
                                string filename = StaticParams.GetProgramDir() + "Data\\Decks\\" + DeckSelectionBox.Text
                                    + "(" + i.ToString() + ")" + ".dck";
                                if (File.Exists(filename))
                                    continue;
                                else
                                {
                                    StaticParams.CurrentDeck.Name += "(" + i + ")";
                                    StaticParams.CurrentDeck.SaveDeckAs(filename);
                                    break;
                                }

                            }
                            break;
                        }
                }


            }
            else
            {
                StaticParams.Events.Add(new Event("Создание новой колоды", StaticParams.CurrentDeck.Name));
                StaticParams.CurrentDeck.SaveDeck();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void сменаПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticParams.CurrentUser.UserStatistics.LastVisit = DateTime.Now;
            StaticParams.Events.Add(new Event("Выход из программы", "Программа"));
            if (!StaticParams.CurrentUser.Guestmode && StaticParams.Access == StaticParams.AccessType.Separate)
                StaticParams.CurrentUser.SaveUser();

            if (!StaticParams.CurrentUser.Guestmode && StaticParams.Access == StaticParams.AccessType.One)
            {
                foreach (User item in StaticParams.Users)
                {
                    if (item.Login == StaticParams.CurrentUser.Login)
                    {
                        StaticParams.CurrentUser.UserStatistics.LogonTime = DateTime.Now - StaticParams.ProgramEnter;
                        StaticParams.Users[StaticParams.Users.IndexOf(item)] = new User(StaticParams.CurrentUser);
                        break;
                    }

                }
                Files.SaveBigFiles();
            }


            Close();
            LoginScreen dialogBox = new LoginScreen();
            dialogBox.ShowDialog();

        }

        private void toolStripEditButton_CheckStateChanged(object sender, EventArgs e)
        {

            UpDownBox.Enabled = toolStripEditButton.Checked;
            CopyrightRtf.ReadOnly = !toolStripEditButton.Checked;
            AdvancedEdit.Visible = toolStripEditButton.Checked;
            MaximizeText.Enabled = toolStripEditButton.Checked;
            NullOwnerBox.Enabled = toolStripEditButton.Checked;
            descrToolBox.Visible = toolStripEditButton.Checked;
            ModifyLayoutButton.Visible = toolStripEditButton.Checked;
            textCardname.Visible = toolStripEditButton.Checked;
            AddDeckButton.Enabled = toolStripEditButton.Checked;
            AddDeckButton.Visible = toolStripEditButton.Checked;
            RemoveDeckButton.Visible = toolStripEditButton.Checked;
            MultipleAddCardButton.Visible = toolStripEditButton.Checked;
            AddCardButton.Visible = toolStripEditButton.Checked;
            RemoveCardButton.Visible = toolStripEditButton.Checked;
            ChooseImageButton.Visible = toolStripEditButton.Checked;
            RemoveImageButton.Visible = toolStripEditButton.Checked;
            AddTypeButton.Visible = toolStripEditButton.Checked;
            RemoveTypeButton.Visible = toolStripEditButton.Checked;
            ChooseAutorImageButton.Visible = toolStripEditButton.Checked;
            RemoveAuthorImageButton.Visible = toolStripEditButton.Checked;
            MultipleAddCardButton.Enabled = false;
            AddCardButton.Enabled = false;
            AddDeckButton.Enabled = true;
            RemoveImageButton.Enabled = false;
            ChooseImageButton.Enabled = false;
            DescriptionText.ReadOnly = true;
            if (!toolStripEditButton.Checked)
            {
                DeckSelectionBox.DropDownStyle = ComboBoxStyle.DropDownList;
                toolStripSaveButton.Enabled = false;
            }
            if (toolStripEditButton.Checked)
                AddDeckButton.PerformClick();
        }

        private void AddDeckButton_Click(object sender, EventArgs e)
        {
            DeckOwnerLabel.Text = "Колода еще не была создана.";
            DeckBackBox.Enabled = true;
            AddDeckButton.Enabled = false;
            StaticParams.CurrentDeck = new Deck(DeckSelectionBox.Text, DescriptionText.Rtf, null, Properties.Resources.DefaultTaroBack);
            MultipleAddCardButton.Enabled = true;
            AddCardButton.Enabled = true;
            RemoveImageButton.Enabled = true;
            ChooseImageButton.Enabled = true;
            DescriptionText.ReadOnly = false;
            DeckSelectionBox.DropDownStyle = ComboBoxStyle.DropDown;
            DeckSelectionBox.Text = "Новая колода";
            CardsRefresh();
            DescriptionText.Rtf = null;
            CopyrightRtf.Rtf = null;
            AuthorPictureBox.Image = null;
            UpDownBox.Checked = false;
            NullOwnerBox.Checked = false;
            toolStripSaveButton.Enabled = true;
        }
        


        private void AddCardButton_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.vopros;
            CardImage.Image = img;
            //DescriptionText.Text = "DefaultDescription#" + CardList.Items.Count;
            StaticParams.CurrentDeck.Cards.Add(new Deck.card("New Card#" + CardList.Items.Count, DescriptionText.Rtf,
                    img, CardList.Items.Count));
                CardsRefresh();
            
        }

        private void ChooseImageButton_Click(object sender, EventArgs e)
        {
            ChooseImage();
        }

        private void CardList_Leave(object sender, EventArgs e)
        {
            if (CardList.SelectedItems.Count > 0 && toolStripEditButton.Checked)
            {
                foreach (ListViewItem value in CardList.Items)
                {
                    ((Deck.card)StaticParams.CurrentDeck.Cards[value.Index]).CardName = CardList.Items[value.Index].Text;
                }
            }

        }

        private void DescriptionText_TextChanged(object sender, EventArgs e)
        {
            if (CardList.SelectedItems.Count <= 1)
            {
                if (CardList.SelectedItems.Count == 1)
                    ((Deck.card)StaticParams.CurrentDeck.Cards[CardList.SelectedIndices[0]]).CardDescription = DescriptionText.Rtf;
                else
                    StaticParams.CurrentDeck.Description = DescriptionText.Rtf;
            }
        }

        private void RemoveImageButton_Click(object sender, EventArgs e)
        {
            string question = "";
            if (CardList.SelectedItems.Count == 0)
                question = "Удалить обложку выбранной колоды?";
            if (CardList.SelectedItems.Count == 1)
            {
                string cardname = ((Deck.card)StaticParams.CurrentDeck.Cards[CardList.SelectedIndices[0]]).CardName;
                question = "Удалить изображение карты \"" + cardname + "\"?";
            }
            if (CardList.SelectedItems.Count > 1)
                question = "Удалить изображения выбранных карт?";

            if (MessageBox.Show(question, "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                if (CardList.SelectedItems.Count == 0)
                    StaticParams.CurrentDeck.Logo = Properties.Resources.vopros;
                if (CardList.SelectedItems.Count == 1)
                    ((Deck.card)StaticParams.CurrentDeck.Cards[CardList.SelectedIndices[0]]).CardPicture = Properties.Resources.vopros;
                if (CardList.SelectedItems.Count > 1)
                    for (int i = CardList.SelectedIndices.Count - 1; i >= 0; i--)
                        ((Deck.card)StaticParams.CurrentDeck.Cards[CardList.SelectedIndices[i]]).CardPicture = Properties.Resources.vopros;

                CardImage.Image = Properties.Resources.vopros;
            }
        }

        private void RemoveDeckButton_Click(object sender, EventArgs e)
        {
            if (DeckSelectionBox.SelectedIndex != -1)
            {
                if (StaticParams.CurrentDeck.Owner != StaticParams.CurrentUser.Login && StaticParams.CurrentDeck.Owner != null)
                    MessageBox.Show("Можно удалить только свои колоды. Эта создана пользователем \"" + StaticParams.CurrentDeck.Owner + "\".");
                else
                {
                    if (MessageBox.Show("Удалить выбранную колоду?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {
                        StaticParams.Events.Add(new Event("Удаление колоды", DeckSelectionBox.Text));
                        if (StaticParams.Access == StaticParams.AccessType.One)
                            StaticParams.Decks.RemoveAt(DeckSelectionBox.SelectedIndex);
                        else if (StaticParams.Access == StaticParams.AccessType.Separate)
                            File.Delete(StaticParams.GetProgramDir() + "Data\\Decks\\" + DeckSelectionBox.Text + ".dck");

                        StaticParams.CurrentDeck = new Deck("", "", null, null);
                        CardImage.Image = Properties.Resources.vopros;
                        DeckRefresh();
                        CardsRefresh();
                        //DescriptionText.Rtf = null;

                    }
                }
            }
            else
                MessageBox.Show("Не выбрана колода!");
        }

        private void RemoveCardButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить выбранные карты?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                for (int i = CardList.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    StaticParams.CurrentDeck.Cards.RemoveAt(CardList.SelectedIndices[i]);
                    CardList.Items.RemoveAt(CardList.SelectedIndices[i]);
                    
                }
            }
        }

        private void CardList_SelectedIndexChanged(object sender, EventArgs e)
        {
                ChooseImageButton.Enabled = (CardList.SelectedItems.Count <= 1);
                DescriptionTextContextMenu.Items[7].Enabled = (CardList.SelectedItems.Count <= 1);
                RemoveCardButton.Enabled = (CardList.SelectedItems.Count > 0);
                DescriptionText.ReadOnly = !(CardList.SelectedItems.Count <= 1 && toolStripEditButton.Checked);
                DescriptionText.Select(0, 0);
                DeckBackBox.Enabled = (CardList.SelectedItems.Count == 0);
                textCardname.Enabled = (CardList.SelectedItems.Count == 1);
                if (!textCardname.Enabled)
                    textCardname.Text = "";

                if (CardList.SelectedItems.Count > 1)
                {
                    string str = "";
                    #region большой switch()
                    switch (CardList.SelectedItems.Count % 10)
                    {
                        case 1:
                            {
                                str = " карта.";
                                break;
                            }
                        case 2:
                            {
                                str = " карты.";
                                break;
                            }
                        case 3:
                            {
                                str = " карты.";
                                break;
                            }
                        case 4:
                            {
                                str = " карты.";
                                break;
                            }
                        default:
                            {
                                str = " карт.";
                                break;
                            }
                    }
                    if (CardList.SelectedItems.Count >= 11 && CardList.SelectedItems.Count <= 14)
                        str = " карт.";
                    #endregion
                    CardImage.Image = null;
                    //DescriptionText.Rtf = null;
                    dispSelectedCard.Text = "Выбрано " + CardList.SelectedItems.Count + str;
                }
                else if (CardList.SelectedItems.Count == 0)
                {
                    DescriptionText.Rtf = StaticParams.CurrentDeck.Description;
                    if (DeckBackBox.Checked)
                    {
                        CardImage.Image = StaticParams.CurrentDeck.Back;
                        dispSelectedCard.Text = "Выбрана рубашка колоды";
                    }
                    else
                    {
                        CardImage.Image = StaticParams.CurrentDeck.Logo;
                        dispSelectedCard.Text = "Выбрана обложка колоды";
                    }
                }
                else
                {
                    CardImage.Image = ((Deck.card)StaticParams.CurrentDeck.Cards[CardList.SelectedIndices[0]]).CardPicture;
                    DescriptionText.Rtf = ((Deck.card)StaticParams.CurrentDeck.Cards[CardList.SelectedIndices[0]]).CardDescription;
                    dispSelectedCard.Text = "Выбрана карта \"" + ((Deck.card)StaticParams.CurrentDeck.Cards[CardList.SelectedIndices[0]])
                        .CardName + "\".";
                    textCardname.Text = ((Deck.card)StaticParams.CurrentDeck.Cards[CardList.SelectedIndices[0]]).CardName;
                }
        }



        private void AddTypeButton_Click(object sender, EventArgs e)
        {
            TypeDesigner td = new TypeDesigner();
            td.ShowDialog();
            TypesRefresh();
        }

        private void BeginButton_Click(object sender, EventArgs e)
        {
            TypesList.Focus();
            if (DeckSelectionBox.SelectedIndex != -1 && CardList.Items.Count != 0 && TypesList.SelectedItems.Count == 1)
            {
                if (((StaticParams.CurrentDeck.Cards.Count >= StaticParams.CurrentLayoutType.CardPositions.Count ||
                    StaticParams.CurrentUser.UserSettings.SameCards)) &&
                (TypesList.SelectedItems.Count == 1))
                {
                    LayoutForm lf = new LayoutForm();
                    lf.StartPosition = FormStartPosition.CenterScreen;
                    if (StaticParams.CurrentUser.UserSettings.MaximizeLayout)
                        lf.WindowState = FormWindowState.Maximized;
                    lf.ShowDialog();
                    Close();
                }
                else MessageBox.Show("В выбранной колоде не достаточно карт для этого расклада! (Расклад возможен при включенной опции одинаковых карт)");
            }
            else
            {
                if (DeckSelectionBox.SelectedIndex == -1)
                    MessageBox.Show("Колода не выбрана.");
                else if (CardList.Items.Count == 0)
                    MessageBox.Show("В колоде нет карт.");
                else if (TypesList.SelectedItems.Count != 1)
                    MessageBox.Show("Тип расклада не выбран.");
            }
        }

        private void TypesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypesList.SelectedItems.Count == 1)
            {
                if (StaticParams.Access == StaticParams.AccessType.One)
                    StaticParams.CurrentLayoutType = new LayoutType((LayoutType)StaticParams.Layouts[TypesList.SelectedIndices[0]]);
                else if (StaticParams.Access == StaticParams.AccessType.Separate)
                    LoadLayout(TypesList.SelectedItem.ToString());


                LayoutDescriptionRtf.Rtf = StaticParams.CurrentLayoutType.Description;
                LayoutMiscRtf.Text = "Значения карт:\n";
                foreach (LayoutType.CardPos item in StaticParams.CurrentLayoutType.CardPositions)
                    LayoutMiscRtf.Text += item.Number + ". " + item.Description + "\n";
                DrawingPanel.Invalidate();
            }
        }


        private void DeckSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShuffleButton.Enabled = (DeckSelectionBox.SelectedIndex != -1);

            if (toolStripEditButton.Checked)
                try
                {
                    if (StaticParams.CurrentDeck.Owner != StaticParams.CurrentUser.Login && StaticParams.CurrentDeck.FreeAccess != true &&
                        DeckSelectionBox.SelectedIndex != -1)
                    {
                        MessageBox.Show("Можно изменять только свои колоды. Эта создана пользователем \"" + StaticParams.CurrentDeck.Owner + "\".");
                        AddDeckButton.PerformClick();
                    }
                }
                catch { };

            if (DeckSelectionBox.SelectedIndex != -1)
            {
                if (StaticParams.Access == StaticParams.AccessType.One)
                    StaticParams.CurrentDeck = (new Deck((Deck)StaticParams.Decks[DeckSelectionBox.SelectedIndex]));
                else if (StaticParams.Access == StaticParams.AccessType.Separate)
                    LoadDeck(DeckSelectionBox.Text);

                NullOwnerBox.Checked = StaticParams.CurrentDeck.FreeAccess;
                UpDownBox.Checked = StaticParams.CurrentDeck.AllowUpsideDown;


                CardsRefresh();

                if (DeckBackBox.Checked)
                    CardImage.Image = StaticParams.CurrentDeck.Back;
                else
                    CardImage.Image = StaticParams.CurrentDeck.Logo;
                DescriptionText.Rtf = StaticParams.CurrentDeck.Description;
                CopyrightRtf.Rtf = StaticParams.CurrentDeck.Copyright;
                DeckOwnerLabel.Text = "Колода была добавлена пользователем " + StaticParams.CurrentDeck.Owner;
                AuthorPictureBox.Image = StaticParams.CurrentDeck.AuthorImage;
                NullOwnerBox.Enabled = (StaticParams.CurrentUser.Login == StaticParams.CurrentDeck.Owner && toolStripEditButton.Checked);

                if (toolStripEditButton.Checked && DeckSelectionBox.SelectedIndex != -1)
                {
                    if (StaticParams.CurrentDeck.Owner != StaticParams.CurrentUser.Login && StaticParams.CurrentDeck.FreeAccess != true)
                    {
                        MessageBox.Show("Можно изменять только свои колоды. Эта создана пользователем \"" + StaticParams.CurrentDeck.Owner + "\".");
                        AddDeckButton.PerformClick();
                    }
                }
            }

            if (DeckSelectionBox.SelectedIndex != -1 && toolStripEditButton.Checked)
            {
                //DeckBackBox.Enabled = true;
                //AddDeckButton.Enabled = false;
                MultipleAddCardButton.Enabled = true;
                AddCardButton.Enabled = true;
                RemoveImageButton.Enabled = true;
                ChooseImageButton.Enabled = true;
                DescriptionText.ReadOnly = false;
                toolStripSaveButton.Enabled = true;



            }
        }

        private void DeckSelectionBox_TextChanged(object sender, EventArgs e)
        {
            //if (DeckSelectionBox.SelectedIndex == -1)
            //StaticParams.CurrentDeck.Name = DeckSelectionBox.Text;
        }



        private void TarotForm_Shown(object sender, EventArgs e)
        {
            SetColors();
            if (StaticParams.GuestLogin())
            {
                LoginLabel.Text = "Гостевой режим";
                LoginLabel.ForeColor = Color.Tomato;
            }
            else
            {
                LoginLabel.Text = StaticParams.CurrentUser.Login;
                LoginLabel.ForeColor = Color.Blue;
            }

            TypesRefresh();
            StatsRefresh();
            DeckRefresh();
            if (StaticParams.CurrentUser.UserSettings.OverrideDeck != "")
            {
                OverrideTip.Text = "Описания карт заменены (" + StaticParams.CurrentUser.UserSettings.OverrideDeck + ")";
                OverrideTip.Visible = true;
            }
            else
                OverrideTip.Visible = false;
            dispSelectedCard.Text = "";
            StaticParams.LayoutResult.Clear();
            StaticParams.Question = "";
        }


        private void toolStripSaveButton_Click(object sender, EventArgs e)
        {
            if (DeckSelectionBox.Text != "Новая колода")
            {
                StaticParams.CurrentDeck.Name = DeckSelectionBox.Text;
                AddDeckButton.Enabled = true;
                if (DeckSelectionBox.SelectedIndex == -1)
                {
                    if (StaticParams.Access == StaticParams.AccessType.One)
                    {
                        StaticParams.Decks.Add(new Deck(StaticParams.CurrentDeck));
                        StaticParams.Events.Add(new Event("Создание новой колоды", StaticParams.CurrentDeck.Name));
                    }
                    else if (StaticParams.Access == StaticParams.AccessType.Separate)
                        SaveDeckSeparate();

                }
                else
                {
                    if (StaticParams.CurrentDeck.Owner != StaticParams.CurrentUser.Login && StaticParams.CurrentDeck.FreeAccess != true)
                        MessageBox.Show("Можно изменять только свои колоды. Эта создана пользователем \"" + StaticParams.CurrentDeck.Owner + "\".");
                    else
                    {
                        if (StaticParams.Access == StaticParams.AccessType.One)
                        {
                            switch (MessageBox.Show("Вы внесли изменения в существующую колоду. Заменить ее? Нажмите \"Нет\" для создания новой",
                                "Выбор", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                            {
                                case DialogResult.Yes:
                                    {
                                        StaticParams.CurrentDeck.Name = DeckSelectionBox.Text;
                                        StaticParams.Decks[DeckSelectionBox.SelectedIndex] = new Deck(StaticParams.CurrentDeck);
                                        StaticParams.Events.Add(new Event("Изменение колоды", StaticParams.CurrentDeck.Name));
                                        break;
                                    }
                                case DialogResult.No:
                                    {
                                        StaticParams.Decks.Add(new Deck(StaticParams.CurrentDeck));
                                        StaticParams.Events.Add(new Event("Создание новой колоды на основе существующей", StaticParams.CurrentDeck.Name));
                                        break;
                                    }
                            }
                        }
                        else if (StaticParams.Access == StaticParams.AccessType.Separate)
                        {
                            SaveDeckSeparate();
                        }
                    }

                    
                }
                toolStripEditButton.Checked = false;
                DeckRefresh();
            }
            else
            {
                MessageBox.Show("Измените название колоды!");
                DeckSelectionBox.Focus();
                DeckSelectionBox.SelectAll();
            }
        }

        private void SameCardsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            StaticParams.CurrentUser.UserSettings.SameCards = SameCardsCheckbox.Checked;
        }

        private void ShowCardsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            StaticParams.CurrentUser.UserSettings.ShowCards = ShowCardsCheckbox.Checked;
        }
        private void AskQuestionBox_CheckedChanged(object sender, EventArgs e)
        {
            StaticParams.CurrentUser.UserSettings.AskQuestion = AskQuestionBox.Checked;
        }
        private void DefaultSpeedButton_Click(object sender, EventArgs e)
        {
            ShakeSpeedBar.Value = 5;
        }

        private void ShakeSpeedBar_ValueChanged(object sender, EventArgs e)
        {
            #region switch (ShakeSpeedBar.Value)
            switch (ShakeSpeedBar.Value)
            {
                case 1:
                    {
                        StaticParams.CurrentUser.UserSettings.ShakeSpeed = 1000;
                        break;
                    }
                case 2:
                    {
                        StaticParams.CurrentUser.UserSettings.ShakeSpeed = 700;
                        break;
                    }
                case 3:
                    {
                        StaticParams.CurrentUser.UserSettings.ShakeSpeed = 500;
                        break;
                    }
                case 4:
                    {
                        StaticParams.CurrentUser.UserSettings.ShakeSpeed = 300;
                        break;
                    }
                case 5:
                    {
                        StaticParams.CurrentUser.UserSettings.ShakeSpeed = 100;
                        break;
                    }
                case 6:
                    {
                        StaticParams.CurrentUser.UserSettings.ShakeSpeed = 70;
                        break;
                    }
                case 7:
                    {
                        StaticParams.CurrentUser.UserSettings.ShakeSpeed = 50;
                        break;
                    }
                case 8:
                    {
                        StaticParams.CurrentUser.UserSettings.ShakeSpeed = 30;
                        break;
                    }
                case 9:
                    {
                        StaticParams.CurrentUser.UserSettings.ShakeSpeed = 10;
                        break;
                    }
                case 10:
                    {
                        StaticParams.CurrentUser.UserSettings.ShakeSpeed = 1;
                        break;
                    }

            }
            #endregion
        }


        private void MaximizedLayoutWindow_CheckedChanged(object sender, EventArgs e)
        {
            StaticParams.CurrentUser.UserSettings.MaximizeLayout = MaximizedLayoutWindow.Checked;
        }


        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            if (TypesList.SelectedIndex != -1)
                foreach (LayoutType.CardPos currPos in StaticParams.CurrentLayoutType.CardPositions)
                {
                    if (currPos.X + currPos.Width> DrawingPanel.AutoScrollMinSize.Width)
                        DrawingPanel.AutoScrollMinSize = new Size(currPos.X + currPos.Width + 15, DrawingPanel.AutoScrollMinSize.Height);
                    if (currPos.Y > DrawingPanel.AutoScrollMinSize.Height)
                        DrawingPanel.AutoScrollMinSize = new Size(DrawingPanel.AutoScrollMinSize.Width, currPos.Y+currPos.Height + 15);

                    currPos.Draw(e.Graphics, DrawingPanel.AutoScrollPosition.X, DrawingPanel.AutoScrollPosition.Y);
                }

        }

        private void DrawingPanel_Scroll(object sender, ScrollEventArgs e)
        {
            DrawingPanel.Invalidate();
        }

        private void StatisticsList_ItemActivate(object sender, EventArgs e)
        {
            int error = 0;
            if (StaticParams.Access == StaticParams.AccessType.One)
            {
                foreach (LayoutType item in StaticParams.Layouts)
                {
                    if (item.Name == StatisticsList.SelectedItems[0].SubItems[1].Text)
                    {
                        StaticParams.CurrentLayoutType = new LayoutType(item);
                        error = 0;
                        break;
                    }
                    error = 1;
                }
                foreach (Deck item in StaticParams.Decks)
                {
                    if (item.Name == StatisticsList.SelectedItems[0].SubItems[2].Text)
                    {
                        StaticParams.CurrentDeck = new Deck(item);
                        error = 0;
                        break;
                    }
                    error = 2;
                }
            }
            else if (StaticParams.Access == StaticParams.AccessType.Separate)
            {
                if (File.Exists(StaticParams.GetProgramDir() + "Data\\Layouts\\" + StatisticsList.SelectedItems[0].SubItems[1].Text + ".lyt"))
                    LoadLayout(StatisticsList.SelectedItems[0].SubItems[1].Text);
                else
                    error = 1;
                if (File.Exists(StaticParams.GetProgramDir() + "Data\\Decks\\" + StatisticsList.SelectedItems[0].SubItems[2].Text + ".dck"))
                    LoadDeck(StatisticsList.SelectedItems[0].SubItems[2].Text);
                else
                    error = 2;
            }
            if (error == 0)
            {
                StaticParams.Question = StatisticsList.SelectedItems[0].SubItems[3].Text;
                StaticParams.Comment = StatisticsList.SelectedItems[0].SubItems[4].Text;
                StaticParams.LayoutResult = new List<Deck.card>();
                foreach (Deck.card item in ((User.Statistics.LayoutDetails)
                    StaticParams.CurrentUser.UserStatistics.LayoutStats[StatisticsList.SelectedIndices[0]]).LayoutResult)
                    StaticParams.LayoutResult.Add(item);
                LayoutResult lr = new LayoutResult();
                lr.SaveResult = false;
                if (StaticParams.CurrentUser.UserSettings.MaximizeLayout)
                    lr.WindowState = FormWindowState.Maximized;
                lr.ShowDialog();
            }
            else
            {
                switch (error)
                {
                    case 1:
                        {
                            MessageBox.Show("Использованный тип расклада не найден, воспроизведение невозможно.");
                            break;
                        }
                    case 2:
                        {
                            MessageBox.Show("Использованная колода не найдена, воспроизведение невозможно.");
                            break;
                        }
                }
            }
        }

        private void ClearStatisticsButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистить всю статистику пользователя", "Очистка", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                 == DialogResult.Yes)
            {
                StaticParams.CurrentUser.UserStatistics = new User.Statistics();
                StaticParams.Events.Add(new Event("Очистка истории раскладов", "История раскладов пользователя"));
                StatsRefresh();
            }
        }

        private void DeckBackBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DeckBackBox.Checked)
            {
                if (StaticParams.CurrentDeck.Back != null)
                    CardImage.Image = StaticParams.CurrentDeck.Back;
                else
                    CardImage.Image = Properties.Resources.vopros;
            }
            else
            {
                if (StaticParams.CurrentDeck.Logo != null)
                    CardImage.Image = StaticParams.CurrentDeck.Logo;
                else
                    CardImage.Image = Properties.Resources.vopros;
            }
            CardList_SelectedIndexChanged(null, null);
        }

        private void SelectDeckButton_Click(object sender, EventArgs e)
        {
            CardList.SelectedIndices.Clear();
            CardList_SelectedIndexChanged(null, null);
        }


        private void CardList_ItemActivate(object sender, EventArgs e)
        {
            if (toolStripEditButton.Checked)
                ChooseImage();
        }

        private void textCardname_TextChanged(object sender, EventArgs e)
        {

            if (textCardname.Enabled)
            {

            char[] chars = textCardname.Text.ToCharArray();
            string NewText = "";
            char PrevChar = 'a';
            if (chars[0] == ' ')
            {
                for (int i = 1; i < chars.Length - 1; i++)
                    NewText += chars[i];
                chars = NewText.ToCharArray();
                NewText = "";
            }
            foreach (char currChar in chars)
            {
                if (!(PrevChar == ' ' && currChar == ' '))
                    NewText+=currChar;
                PrevChar = currChar;
            }
            if (NewText != textCardname.Text)
            {
                textCardname.Text = NewText;
                textCardname.Select(textCardname.Text.Length, 0);
            }

            if (toolStripEditButton.Checked && CardList.SelectedItems.Count == 1)
            {
                ((Deck.card)StaticParams.CurrentDeck.Cards[CardList.SelectedIndices[0]]).CardName = textCardname.Text;
                CardList.Items[CardList.SelectedIndices[0]].Text = textCardname.Text;
            }
        }
        }
        #region RTF редактор

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DescrBoldButton.PerformClick();
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DescrItalicButton.PerformClick();
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DescrUnderlineButton.PerformClick();
        }

        private void strikeoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DescrStrikeoutButton.PerformClick();
        }


        private void Paste_Click(object sender, EventArgs e)
        {
            DescriptionText.Paste();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            DescriptionText.Copy();
        }

        private void SelectAll_Click(object sender, EventArgs e)
        {
            DescriptionText.SelectAll();
        }
        private void FontButton_Click(object sender, EventArgs e)
        {
            if (descrFontDialog.ShowDialog() == DialogResult.OK)
                DescriptionText.SelectionFont = descrFontDialog.Font;

        }
        private void DescrBoldButton_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;

            oldFont = this.DescriptionText.SelectionFont;
            if (oldFont.Bold == true)
                // если уже жирный то убираем выделение
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);
            else newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold); // выделяем жирным

            this.DescriptionText.SelectionFont = newFont;
            this.DescriptionText.Focus();
        }

        private void DescrItalicButton_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;

            oldFont = this.DescriptionText.SelectionFont;
            if (oldFont.Italic == true)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic);
            else newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);

            this.DescriptionText.SelectionFont = newFont;
            this.DescriptionText.Focus();

        }

        private void DescrUnderlineButton_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;

            oldFont = this.DescriptionText.SelectionFont;
            if (oldFont.Underline == true)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
            else newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);

            this.DescriptionText.SelectionFont = newFont;
            this.DescriptionText.Focus();

        }

        private void DescrStrikeoutButton_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;

            oldFont = this.DescriptionText.SelectionFont;
            if (oldFont.Strikeout == true)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Strikeout);
            else newFont = new Font(oldFont, oldFont.Style | FontStyle.Strikeout);

            this.DescriptionText.SelectionFont = newFont;
            this.DescriptionText.Focus();

        }
        private void ApplyTextSize(string text)
        {
            float newSize = Convert.ToSingle(text);
            FontFamily currentFontFamily;
            Font newFont;

            currentFontFamily = this.DescriptionText.SelectionFont.FontFamily;
            newFont = new Font(currentFontFamily, newSize);

            this.DescriptionText.SelectionFont = newFont;
        }

        private void TextSizeBox_ValueChanged(object sender, EventArgs e)
        {


                ApplyTextSize(TextSizeBox.Value.ToString());
                this.DescriptionText.Focus();
                DescriptionText_SelectionChanged(null, null);


        }

        private void AlignCenterButton_Click(object sender, EventArgs e)
        {
            if (this.DescriptionText.SelectionAlignment == HorizontalAlignment.Center)
                this.DescriptionText.SelectionAlignment = HorizontalAlignment.Left;
            else this.DescriptionText.SelectionAlignment = HorizontalAlignment.Center;
            this.DescriptionText.Focus();

        }

        private void AlignLeftButton_Click(object sender, EventArgs e)
        {
            this.DescriptionText.SelectionAlignment = HorizontalAlignment.Left;
            this.DescriptionText.Focus();

        }

        private void AlignRightButton_Click(object sender, EventArgs e)
        {
            if (this.DescriptionText.SelectionAlignment == HorizontalAlignment.Right)
                this.DescriptionText.SelectionAlignment = HorizontalAlignment.Left;
            else this.DescriptionText.SelectionAlignment = HorizontalAlignment.Right;
            this.DescriptionText.Focus();

        }


        private void TextColorButton_Click(object sender, EventArgs e)
        {
            if (TextColorDialog.ShowDialog() == DialogResult.OK)
                DescriptionText.SelectionColor = TextColorDialog.Color;
        }
        private void TextSizeBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ApplyTextSize(TextSizeBox.Text);
                DescriptionText.Focus();
                DescriptionText_SelectionChanged(null, null);
            }
        }

        private void DescriptionText_SelectionChanged(object sender, EventArgs e)
        {
            if (DescriptionText.SelectionFont != null)
                descrTextSizeLabel.Text = Convert.ToInt32(DescriptionText.SelectionFont.Size).ToString();
        }

        #endregion



        private void AddDeckMenuItem_Click(object sender, EventArgs e)
        {
            if (AddDeckButton.Enabled)
                AddDeckButton.PerformClick();
        }

        private void AddCardMenuItem_Click(object sender, EventArgs e)
        {
            if (AddCardButton.Enabled)
                AddCardButton.PerformClick();
        }

        private void ChooseImageMenuitem_Click(object sender, EventArgs e)
        {
            if (ChooseImageButton.Enabled)
                ChooseImageButton.PerformClick();
        }

        private void CardList_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.F2:
                    {
                        textCardname.Focus();
                        textCardname.SelectAll();
                        break;
                    }
                    //при нажатом Ctrl, перемещение стрелками будет переводиться на новую строку.
                case Keys.Up:
                    {
                        if (e.Control)
                        {
                            int index = CardList.SelectedIndices[0] - 5;
                            if (index > -1)
                            {
                                CardList.Items[CardList.SelectedIndices[0]].Selected = false;
                                CardList.Items[index].Selected = true;
                            }
                        }
                        break;
                    }
                case Keys.Down:
                    {
                        if (e.Control)
                        {
                            int index = CardList.SelectedIndices[0] + 5;
                            if (index < CardList.Items.Count)
                            {
                                CardList.Items[CardList.SelectedIndices[0]].Selected = false;
                                CardList.Items[index].Selected = true;
                            }
                        }

                        break;
                    }
                case Keys.Left:
                    {
                        if (e.Control)
                        {
                            int index = CardList.SelectedIndices[0] - 1;
                            if (index > -1)
                            {
                                CardList.Items[CardList.SelectedIndices[0]].Selected = false;
                                CardList.Items[index].Selected = true;
                            }
                        }
                        break;
                    }
                case Keys.Right:
                    {
                        if (e.Control)
                        {
                            int index = CardList.SelectedIndices[0] + 1;
                            if (index < CardList.Items.Count)
                            {
                                CardList.Items[CardList.SelectedIndices[0]].Selected = false;
                                CardList.Items[index].Selected = true;
                            }
                        }
                        break;

                    }
            }

        }

        private void MultipleAddCardButton_Click(object sender, EventArgs e)
        {
            Dialogs.CardCountRequest CCR = new Dialogs.CardCountRequest();
            CCR.ShowDialog();
            CardsRefresh();
        }

        private void textCardname_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    {
                        CardList.Focus();
                        break;
                    }
                case Keys.Up:
                    {
                        if (e.Control)
                        {
                            int index = CardList.SelectedIndices[0] - 5;
                            if (index > -1)
                            {
                                CardList.Items[CardList.SelectedIndices[0]].Selected = false;
                                CardList.Items[index].Selected = true;
                                textCardname.Focus();
                            }
                        }
                        break;
                    }
                case Keys.Down:
                    {
                        if (e.Control)
                        {
                            int index = CardList.SelectedIndices[0] + 5;
                            if (index < CardList.Items.Count)
                            {
                                CardList.Items[CardList.SelectedIndices[0]].Selected = false;
                                CardList.Items[index].Selected = true;
                                textCardname.Focus();
                            }
                        }

                        break;
                    }
                case Keys.Left:
                    {
                        if (e.Control)
                        {
                            int index = CardList.SelectedIndices[0] - 1;
                            if (index > -1)
                            {
                                CardList.Items[CardList.SelectedIndices[0]].Selected = false;
                                CardList.Items[index].Selected = true;
                                textCardname.Focus();
                            }
                        }
                        break;
                    }
                case Keys.Right:
                    {
                        if (e.Control)
                        {
                            int index = CardList.SelectedIndices[0] + 1;
                            if (index < CardList.Items.Count)
                            {
                                CardList.Items[CardList.SelectedIndices[0]].Selected = false;
                                CardList.Items[index].Selected = true;
                                textCardname.Focus();
                            }
                        }
                        break;

                    }
            }
              
        }


        private void RemoveTypeButton_Click(object sender, EventArgs e)
        {
            if (TypesList.SelectedIndex != -1)
            {
                if (StaticParams.CurrentLayoutType.Owner != StaticParams.CurrentUser.Login && StaticParams.CurrentLayoutType.Owner != null)
                    MessageBox.Show("Можно удалить только свои расклады. Этот создан пользователем \"" + StaticParams.CurrentLayoutType.Owner+ "\".");
                else
                {
                    if (MessageBox.Show("Удалить выбранный тип расклада?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                          == DialogResult.Yes)
                    {
                        StaticParams.Events.Add(new Event("Удаление расклада", TypesList.SelectedItem.ToString()));
                        if (StaticParams.Access == StaticParams.AccessType.One)
                            StaticParams.Layouts.RemoveAt(TypesList.SelectedIndex);
                        else if (StaticParams.Access == StaticParams.AccessType.Separate)
                            File.Delete(StaticParams.GetProgramDir() + "Data\\Layouts\\" + TypesList.SelectedItem.ToString() + ".lyt");
                        TypesRefresh();
                    }
                }
            }
            else
                MessageBox.Show("Ничего не выбрано.");

        }

        private void ModifyLayoutButton_Click(object sender, EventArgs e)
        {
            if (TypesList.SelectedIndex != -1)
            {
                if (StaticParams.CurrentLayoutType.Owner != StaticParams.CurrentUser.Login && StaticParams.CurrentLayoutType.FreeAccess != true)
                    MessageBox.Show("Можно изменять только свои расклады. Этот создан пользователем \"" + StaticParams.CurrentLayoutType.Owner+ "\".");
                else
                {
                    TypeDesigner td = new TypeDesigner();
                    td.StartPosition = FormStartPosition.CenterScreen;
                    td.newLayout = false;
                    td.ShowDialog();
                    TypesRefresh();
                }
            }
            else
                MessageBox.Show("Не выбран тип расклада для изменения");

        }

        private void OwnedOnly_Click(object sender, EventArgs e)
        {
            if (OwnedOnly.Checked)
                OwnedOnly.Checked = false;
            else
            {
                OwnedOnly.Checked = true;
                MessageBox.Show("Включение этой опции может сильно замедлить обновление списка колод!");
            }
            DeckRefresh();
            TypesRefresh();
        }



        private void MaximizeText_Click(object sender, EventArgs e)
        {
            Notebook NB = new Notebook();
            NB.WindowState = FormWindowState.Maximized;
            NB.TextRtf.Rtf = DescriptionText.Rtf;
            if (DescriptionText.ReadOnly)
                NB.TextRtf.ReadOnly = true;
            NB.ShowDialog();
            if (!DescriptionText.ReadOnly)
                DescriptionText.Rtf = NB.TextRtf.Rtf;
        }




        private void NullOwnerBox_CheckedChanged(object sender, EventArgs e)
        {
            StaticParams.CurrentDeck.FreeAccess = NullOwnerBox.Checked;
        }

        private void AddOneCardMenuItem_Click(object sender, EventArgs e)
        {
            if (AddCardButton.Enabled)
                AddCardButton.PerformClick();
        }

        private void AddMultipleCardsMenuItem_Click(object sender, EventArgs e)
        {
            if (MultipleAddCardButton.Enabled)
                MultipleAddCardButton.PerformClick();
        }

        private void DeckViewMenuItem_Click(object sender, EventArgs e)
        {
            toolStripDeckViewButton.PerformClick();
        }

        private void toolStripDeckViewButton_Click(object sender, EventArgs e)
        {
            DeckView DV = new DeckView();
            if (DeckSelectionBox.SelectedIndex != -1)
                DV.ShowCurrentDeck = true;
            else
                DV.ShowCurrentDeck = false;
            DV.ShowDialog();
        }

        private void AdvancedEdit_Click(object sender, EventArgs e)
        {
            MaximizeText.PerformClick();
        }

        private void CardImage_Click(object sender, EventArgs e)
        {
            if (CardImage.Image != null)
            {
                LargeImage LIM = new LargeImage(CardImage.Image);
                LIM.Show();
            }
        }

        private void UpDownBox_CheckedChanged(object sender, EventArgs e)
        {
            StaticParams.CurrentDeck.AllowUpsideDown = UpDownBox.Checked;
        }

        private void CopyrightRtf_TextChanged(object sender, EventArgs e)
        {
            StaticParams.CurrentDeck.Copyright = CopyrightRtf.Rtf;
        }

        private void ShuffleButton_Click(object sender, EventArgs e)
        {
            ShuffleForm SF = new ShuffleForm();
            if (StaticParams.CurrentUser.UserSettings.MaximizeLayout)
                SF.WindowState = FormWindowState.Maximized;
            SF.ShowDialog();
        }

        private void radioAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAuto.Checked)
                StaticParams.CurrentUser.UserSettings.ShakeMode = User.LayoutMode.Auto;
        }

        private void radioManual_CheckedChanged(object sender, EventArgs e)
        {
            if (radioManual.Checked)
                StaticParams.CurrentUser.UserSettings.ShakeMode = User.LayoutMode.Manual;
        }

        private void TarotRollTab_Enter(object sender, EventArgs e)
        {
            SetParams();
        }

        private void GetUserSeedBox_CheckedChanged(object sender, EventArgs e)
        {
            StaticParams.CurrentUser.UserSettings.GetUserSeed = GetUserSeedBox.Checked;
        }

        private void HideTipsBox_CheckedChanged(object sender, EventArgs e)
        {
            StaticParams.CurrentUser.UserSettings.HideTips = HideTipsBox.Checked;
            SetTips();
        }

        #region Подробные подсказки

        private void SameCardsHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageForm MF = new MessageForm(((LinkLabel)sender).Name);
            MF.StartPosition = FormStartPosition.CenterParent;
            MF.ShowDialog();
        }

        private void ShowCardsHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageForm MF = new MessageForm(((LinkLabel)sender).Name);
            MF.StartPosition = FormStartPosition.CenterParent;
            MF.ShowDialog();
        }

        private void MaximizeHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageForm MF = new MessageForm(((LinkLabel)sender).Name);
            MF.StartPosition = FormStartPosition.CenterParent;
            MF.ShowDialog();
        }

        private void QuestionHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageForm MF = new MessageForm(((LinkLabel)sender).Name);
            MF.StartPosition = FormStartPosition.CenterParent;
            MF.ShowDialog();
        }

        private void UserSeedHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageForm MF = new MessageForm(((LinkLabel)sender).Name);
            MF.StartPosition = FormStartPosition.CenterParent;
            MF.ShowDialog();
        }

        private void HideTipsHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageForm MF = new MessageForm(((LinkLabel)sender).Name);
            MF.StartPosition = FormStartPosition.CenterParent;
            MF.ShowDialog();
        }

        private void ShuffleSpeedHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageForm MF = new MessageForm(((LinkLabel)sender).Name);
            MF.StartPosition = FormStartPosition.CenterParent;
            MF.ShowDialog();
        }

        private void AutoShuffleHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageForm MF = new MessageForm(((LinkLabel)sender).Name);
            MF.StartPosition = FormStartPosition.CenterParent;
            MF.ShowDialog();
        }

        private void ManualShuffleHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageForm MF = new MessageForm(((LinkLabel)sender).Name);
            MF.StartPosition = FormStartPosition.CenterParent;
            MF.ShowDialog();
        }

        private void PublicDeckHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageForm MF = new MessageForm(((LinkLabel)sender).Name);
            MF.StartPosition = FormStartPosition.CenterParent;
            MF.ShowDialog();
        }

        private void UpsideDownHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageForm MF = new MessageForm(((LinkLabel)sender).Name);
            MF.StartPosition = FormStartPosition.CenterParent;
            MF.ShowDialog();
        }

        private void UDChanceHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageForm MF = new MessageForm(((LinkLabel)sender).Name);
            MF.StartPosition = FormStartPosition.CenterParent;
            MF.ShowDialog();
        }

        private void HiddenLayoutHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageForm MF = new MessageForm(((LinkLabel)sender).Name);
            MF.StartPosition = FormStartPosition.CenterParent;
            MF.ShowDialog();
        }

        #endregion

        #region Подсказки в строке состояния
        private void AddDeckButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Создать новую колоду";
        }

        private void TarotViewTab_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void DeckSelectionBox_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Список колод";
        }

        private void RemoveDeckButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Удалить выбранную колоду";
        }

        private void MultipleAddCardButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Добавить несколько новых карт";
        }

        private void AddCardButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Добавить новую карту";
        }

        private void RemoveCardButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (CardList.SelectedItems.Count > 1)
                toolStripTip.Text = "Удалить выбранные карты";
            else
                toolStripTip.Text = "Удалить выбранную карту";
        }

        private void CardList_MouseMove(object sender, MouseEventArgs e)
        {
            if (toolStripEditButton.Checked)
                toolStripTip.Text = "Выбор карты. Двойной клик - выбор изображения для карты. F2 - переименовать";
            else
                toolStripTip.Text = "Выбор карты. Ctrl + влево или вправо - выделение с переходом на другие строки";
        }

        private void ChooseImageButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (CardList.SelectedItems.Count == 0)
            {
                if (DeckBackBox.Checked)
                    toolStripTip.Text = "Выбор рубашки для колоды";
                else
                    toolStripTip.Text = "Выбор обложки для колоды";
            }
            else
                toolStripTip.Text = "Выбор изображения для карты";
        }

        private void RemoveImageButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (CardList.SelectedItems.Count == 0)
            {
                if (DeckBackBox.Checked)
                    toolStripTip.Text = "Удаление рубашки колоды";
                else
                    toolStripTip.Text = "Удаление обложки колоды";
            }
            else if (CardList.SelectedItems.Count > 1)
                toolStripTip.Text = "Удаление изображений карт";
            else
                toolStripTip.Text = "Удаление изображения карты";

        }

        private void DeckBackBox_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Показать/изменить рубашку или обложку для колоды";
        }

        private void SelectDeckButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Показать/изменить рубашку или обложку для колоды";
        }

        private void CardImage_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Изображение выбранного элемента. Клик - просмотр в полном размере";
        }

        private void DescriptionText_MouseMove(object sender, MouseEventArgs e)
        {
            if (CardList.SelectedItems.Count == 0)
                toolStripTip.Text = "Описание колоды";
            else
                toolStripTip.Text = "Описание выбранной карты";

        }

        private void DescrBoldButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Жирный";
        }

        private void DescrItalicButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Курсив";
        }

        private void DescrUnderlineButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Подчеркнтый";
        }

        private void DescrStrikeoutButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Зачеркнутый";
        }

        private void AlignLeftButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Выравнивание по левому краю";
        }

        private void AlignCenterButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Выравнивание по центру";
        }

        private void AlignRightButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Выравнивание по правому краю";
        }

        private void TextColorButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Цвет Шрифта";
        }

        private void FontButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Шрифт";
        }

        private void TextSizeBox_MouseDown(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Размер шрифта";
        }

        private void AddTypeButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Создать новый тип расклада";
        }

        private void RemoveTypeButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Удалить выбранный тип расклада";
        }

        private void ModifyLayoutButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Изменить выбранный тип расклада";
        }

        private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Отображение выбранного типа расклада";
        }

        private void LayoutDescriptionRtf_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Описание выбранного типа расклада";
        }

        private void LayoutMiscRtf_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Значения позиций карт в выбранном раскладе";
        }

        private void BeginButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Разложить выбранный расклад картами выбранной колоды";
        }

        private void ClearStatisticsButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Очистить всю статистику для текущего пользователя";
        }

        private void StatisticsList_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Результаты раскладов, которые Вы раскладывали";
        }

        private void CopyrightRtf_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Создатели колоды, авторы описаний, и прочие источники для этой колоды";
        }

        private void ShuffleButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Открыть окно ручного перемешивания (для ручного режима)";
        }

        private void toolStripEditButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Включить/выключить возможности редактирования раскладов и колод";
        }

        private void toolStripSaveButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Сохранить текущую колоду";
        }

        private void toolStripDeckViewButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Открыть удобный просмотрщик колод";
        }

        private void OwnedOnly_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Включает отображение только ваших и общих колод";
        }


        private void выходToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Закрыть программу";
        }

        private void сменаПользователяToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Вернуться на экран входа в систему";
        }

        private void TypesList_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Список доступных типов расклада";
        }

        private void MaximizeText_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Открыть в большом окне";
        }

        private void AddOneCardMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            AddCardButton_MouseMove(sender, e);
        }

        private void AddMultipleCardsMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            MultipleAddCardButton_MouseMove(sender, e);
        }

        private void DeckViewMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripDeckViewButton_MouseMove(sender, e);
        }

        private void toolStripCompareButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Открыть окно для наглядного сравнения колод";
        }

        private void ChooseAutorImageButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Добавить или заменить фото автора";
        }

        private void AuthorPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Фото создателя колоды";
        }

        private void SameCardsHelp_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Показать подробную подсказку";
            SameCardsHelp.Text = "Что это?";
        }

        private void ShowCardsHelp_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Показать подробную подсказку";
            ShowCardsHelp.Text = "Что это?";
        }

        private void MaximizeHelp_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Показать подробную подсказку";
            MaximizeHelp.Text = "Что это?";
        }

        private void QuestionHelp_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Показать подробную подсказку";
            QuestionHelp.Text = "Что это?";
        }

        private void UserSeedHelp_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Показать подробную подсказку";
            UserSeedHelp.Text = "Что это?";
        }

        private void HideTipsHelp_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Показать подробную подсказку";
            HideTipsHelp.Text = "Что это?";
        }

        private void ShuffleSpeedHelp_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Показать подробную подсказку";
            ShuffleSpeedHelp.Text = "Что это?";
        }

        private void AutoShuffleHelp_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Показать подробную подсказку";
            AutoShuffleHelp.Text = "Что это?";
        }

        private void ManualShuffleHelp_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Показать подробную подсказку";
            ManualShuffleHelp.Text = "Что это?";
        }

        private void UDChanceHelp_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Показать подробную подсказку";
            UDChanceHelp.Text = "Что это?";
        }

        private void RemoveAuthorImageButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Удалить фото автора";
        }

        private void RemoveAuthorImageButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void PublicDeckHelp_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Показать подробную подсказку";
            PublicDeckHelp.Text = "Что это?";
        }

        private void UpsideDownHelp_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Показать подробную подсказку";
            UpsideDownHelp.Text = "Что это?";
        }

        private void DeckSelectionBox_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void AddDeckButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void RemoveDeckButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void MultipleAddCardButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void AddCardButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void RemoveCardButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void ChooseImageButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void RemoveImageButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void DeckBackBox_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void DescrBoldButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void DescrItalicButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void DescrUnderlineButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void DescrStrikeoutButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void AlignLeftButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void AlignCenterButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void AlignRightButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void TextColorButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void FontButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void TextSizeBox_Leave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void CardList_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void CardImage_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void DescriptionText_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void AddTypeButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void RemoveTypeButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void ModifyLayoutButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void SelectDeckButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void textCardname_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Название карты";
            if (toolStripEditButton.Checked)
                toolStripTip.Text = "Переименовать карту. Ctrl + стрелки - смена карты. Enter - Возврат курсора к списку карт";
        }

        private void textCardname_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void AdvancedEdit_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Открыть описания в большом окне";
        }

        private void AdvancedEdit_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void TypesList_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }
        private void toolStripDeckViewButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void toolStripSaveButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void toolStripEditButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void toolStripCompareButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void OwnedOnly_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void выходToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void сменаПользователяToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void DrawingPanel_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void LayoutDescriptionRtf_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void LayoutMiscRtf_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void BeginButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void toolStripTip_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Сдесь будут отображаться подсказки для элемента под курсором мыши";
        }

        private void toolStripTip_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void LoginLabel_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Имя пользователя, под которым Вы вошли";
        }

        private void LoginLabel_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void SameCardsHelp_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
            SameCardsHelp.Text = "?";
        }

        private void ShowCardsHelp_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
            ShowCardsHelp.Text = "?";
        }

        private void MaximizeHelp_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
            MaximizeHelp.Text = "?";
        }

        private void QuestionHelp_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
            QuestionHelp.Text = "?";
        }

        private void UserSeedHelp_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
            UserSeedHelp.Text = "?";
        }

        private void HideTipsHelp_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
            HideTipsHelp.Text = "?";
        }

        private void ShuffleSpeedHelp_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
            ShuffleSpeedHelp.Text = "?";
        }

        private void AutoShuffleHelp_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
            AutoShuffleHelp.Text = "?";
        }

        private void ManualShuffleHelp_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
            ManualShuffleHelp.Text = "?";
        }

        private void UDChanceHelp_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
            UDChanceHelp.Text = "?";
        }

        private void StatisticsList_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void ClearStatisticsButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void PublicDeckHelp_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
            PublicDeckHelp.Text = "?";
        }

        private void UpsideDownHelp_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
            UpsideDownHelp.Text = "?";
        }

        private void ShuffleButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void CopyrightRtf_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void AuthorPictureBox_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void ChooseAutorImageButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void HiddenLayoutHelp_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Показать подробную подсказку";
            HiddenLayoutHelp.Text = "Что это?";

        }

        private void HiddenLayoutHelp_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
            HiddenLayoutHelp.Text = "?";
        }
        #endregion

        private void UpsideDownBar_Scroll(object sender, EventArgs e)
        {
            StaticParams.CurrentUser.UserSettings.UDChance = UpsideDownBar.Value;
            switch (UpsideDownBar.Value)
            {
                case 1:
                    {
                        UDLabel.Text = "1 из 10 - в прямом положении";
                        break;
                    }
                case 2:
                    {
                        UDLabel.Text = "1 из 5 - в прямом положении";
                        break;
                    }
                case 3:
                    {
                        UDLabel.Text = "3 из 10 - в прямом положении";
                        break;
                    }
                case 4:
                    {
                        UDLabel.Text = "2 из 5 - в прямом положении";
                        break;
                    }
                case 5:
                    {
                        UDLabel.Text = "1 из 2 - в прямом положении";
                        break;
                    }
                case 6:
                    {
                        UDLabel.Text = "3 из 5 - в прямом положении";
                        break;
                    }
                case 7:
                    {
                        UDLabel.Text = "7 из 10 - в прямом положении";
                        break;
                    }
                case 8:
                    {
                        UDLabel.Text = "4 из 5 - в прямом положении";
                        break;
                    }
                case 9:
                    {
                        UDLabel.Text = "9 из 10 - в прямом положении";
                        break;
                    }
                case 10:
                    {
                        UDLabel.Text = "Без перевернутых";
                        break;
                    }
            }
        }

        private void DefaultUDChanceButton_Click(object sender, EventArgs e)
        {
            UpsideDownBar.Value = 5;
        }


        private void ChooseAutorImageButton_Click(object sender, EventArgs e)
        {
            ChooseAuthorImage();
        }

        private void AuthorPictureBox_Click(object sender, EventArgs e)
        {
            if (AuthorPictureBox.Image != null)
            {
                LargeImage LIM = new LargeImage(AuthorPictureBox.Image);
                LIM.Show();
            }

        }

        private void toolStripCompareButton_Click(object sender, EventArgs e)
        {
            DeckComparer DCPR = new DeckComparer();
            DCPR.StartPosition = FormStartPosition.CenterParent;
            if (StaticParams.CurrentUser.UserSettings.MaximizeLayout)
                DCPR.WindowState = FormWindowState.Maximized;
            DCPR.Show();
        }

        private void descrTextSizeLabel_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Текущий размер шрифта";
        }

        private void descrTextSizeLabel_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void DidYouKnowButton_Click(object sender, EventArgs e)
        {
            DidYouKnow DYK = new DidYouKnow();
            DYK.Show();
        }

        private void HiddenLayoutBox_CheckedChanged(object sender, EventArgs e)
        {
            StaticParams.CurrentUser.UserSettings.HiddenLayout = HiddenLayoutBox.Checked;
        }

        private void RemoveAuthorImageButton_Click(object sender, EventArgs e)
        {
            StaticParams.CurrentDeck.AuthorImage = null;
            AuthorPictureBox.Image = null;
        }

        private void OverrideBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OverrideBox.SelectedIndex == 0)
                StaticParams.CurrentUser.UserSettings.OverrideDeck = "";
            else
                StaticParams.CurrentUser.UserSettings.OverrideDeck = OverrideBox.Text;
            if (StaticParams.CurrentUser.UserSettings.OverrideDeck != "")
            {
                OverrideTip.Text = "Описания карт заменены (" + StaticParams.CurrentUser.UserSettings.OverrideDeck + ")";
                OverrideTip.Visible = true;
            }
            else
                OverrideTip.Visible = false;
        }

        private void OverrideHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageForm MF = new MessageForm(((LinkLabel)sender).Name);
            MF.StartPosition = FormStartPosition.CenterParent;
            MF.ShowDialog();
        }

        private void OverrideTip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageForm MF = new MessageForm(((LinkLabel)sender).Name);
            MF.StartPosition = FormStartPosition.CenterParent;
            MF.ShowDialog();
        }

        private void OverrideHelp_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Показать подробную подсказку";
            OverrideHelp.Text = "Что это?";
        }

        private void OverrideHelp_MouseLeave(object sender, EventArgs e)
        {
            OverrideHelp.Text = "?";
            toolStripTip.Text = "";
        }

        private void OverrideTip_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Показать подробную подсказку";
        }

        private void OverrideTip_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void textCardname_Leave(object sender, EventArgs e)
        {
            char[] chars = textCardname.Text.ToCharArray();
            string NewText = "";
            if (chars[textCardname.Text.Length - 1] == ' ')
            {
                for (int i = 0; i < chars.Length - 2; i++)
                    NewText += chars[i];
                if (NewText != textCardname.Text)
                    textCardname.Text = NewText;
            }
        }

        private void DeckSelectionBox_Leave(object sender, EventArgs e)
        {
            if (toolStripEditButton.Checked && DeckSelectionBox.SelectedIndex == -1)
                DeckSelectionBox.Text = Drawing.CleanString(DeckSelectionBox.Text);
        }

        private void CardList_Layout(object sender, LayoutEventArgs e)
        {
            Language.SetLanguage(this, Language.Languages.Eng);
        }




















    }
}
