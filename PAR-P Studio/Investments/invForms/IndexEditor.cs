using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using PAR_P_Studio.Investments.invClasses;

namespace PAR_P_Studio.Investments.invForms
{
    public partial class IndexEditor : Form
    {
        public IndexEditor(int key)
        {
            InitializeComponent();
        }

        void ItemsRefresh()
        {
            ItemList.BeginUpdate();
            ItemList.Items.Clear();
            double percent = 0;
            foreach (Index.Part currPart in Statics.currIndex.Parts)
            {
                Statics.LoadAccount(currPart.Number);
                ItemList.Items.Add(Statics.currAccount.Number);
                ItemList.Items[ItemList.Items.Count - 1].SubItems.Add(Statics.currAccount.Owner);
                ItemList.Items[ItemList.Items.Count - 1].SubItems.Add(currPart.Percentage + "%");
                percent += currPart.Percentage;
            }
            if (percent == 100)
            {
                PercentageStatus.Text = "Все доли распределены.";
                PercentageStatus.ForeColor = Color.Green;
            }
            if (percent < 100)
            {
                PercentageStatus.Text = "Осталось распределить: " + (100-percent) + "%.";
                PercentageStatus.ForeColor = Color.Black;
            }
            if (percent > 100)
            {
                PercentageStatus.Text = "Уменьшите доли, лишних: " + (percent-100) + "%.";
                PercentageStatus.ForeColor = Color.Red;
            }

            ItemList.EndUpdate();
        }
        public void TradersRefresh()
        {
            TraderTree.BeginUpdate();
            TraderTree.Nodes.Clear();
            

                string[] files = Directory.GetFiles(StaticParams.GetProgramDir() + "Data\\Forex\\Traders");
                string[] filesAccounts = Directory.GetFiles(StaticParams.GetProgramDir() + "Data\\Forex\\Accounts");
                foreach (string item in files)
                {
                    if (item.IndexOf(".tdr") == item.Length - 4)
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
                        TraderTree.Nodes.Add(file);
                        foreach (string ActItem in filesAccounts)
                        {
                            if (ActItem.IndexOf(".act") == ActItem.Length - 4)
                                {
                                    string fileAct = ActItem;
                                    fileAct = fileAct.Remove(fileAct.Length - 4);
                                    char[] charsAct = fileAct.ToCharArray();
                                    fileAct = "";
                                    foreach (char currChar in charsAct)
                                    {
                                        fileAct += currChar;
                                        if (currChar == '\\')
                                            fileAct = "";
                                    }
                                    Statics.LoadAccount(fileAct);
                                    if (Statics.currAccount.Owner == file)
                                        TraderTree.Nodes[TraderTree.Nodes.Count - 1].Nodes.Add(fileAct);
                                }
                        }
                    }
                }

            TraderTree.EndUpdate();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            //ItemList.Items.Add(TraderTree.SelectedNode.FullPath);
            Index.Part tmpPart = new Index.Part();
            tmpPart.Number = TraderTree.SelectedNode.Text;
            tmpPart.Percentage = Convert.ToDouble(PercentageBox.Value);
            Statics.currIndex.Parts.Add(new Index.Part(tmpPart));
            ItemsRefresh();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (textName.Text != "")
            {
                ItemsRefresh();
                if (PercentageStatus.ForeColor == Color.Green)
                {
                    Index newIndex = new Index();
                    newIndex.Name = textName.Text;
                    newIndex.Description = DescriptionText.Text;
                    newIndex.Owner = StaticParams.CurrentUser.Login;
                    newIndex.PrivateIndex = PrivateIndex.Checked;
                    for (int i = 0; i < Statics.currIndex.Parts.Count; i++)
                    {
                        Index.Part newPart = new Index.Part();
                        newPart.Number = Statics.currIndex.Parts[i].Number;
                        newPart.Percentage = Statics.currIndex.Parts[i].Percentage;
                        newIndex.Parts.Add(new Index.Part(newPart));
                    }
                    //foreach (string item in ItemList.Items)
                    //{
                    //    Index.Part newPart = new Index.Part();
                    //    newPart.Number = item;
                    //}

                    newIndex.SaveIndex();
                    Statics.currIndex = new Index();
                    this.Close();
                }

                else
                    MessageBox.Show("Название не может быть пустым");
            }
            else
                MessageBox.Show("Доли не корректны.");
        }

        private void AddAccountButton_Click(object sender, EventArgs e)
        {
            TraderEditor TrdEdit = new TraderEditor();
            TrdEdit.ShowDialog();
        }

        private void IndexEditor_Shown(object sender, EventArgs e)
        {
            textName.Text = Statics.currIndex.Name;
            DescriptionText.Text = Statics.currIndex.Description;
            PrivateIndex.Checked = Statics.currIndex.PrivateIndex;
            ItemsRefresh();
            TradersRefresh();
        }

        private void ItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////try
            //{
            //    PercentageBox.Value = Convert.ToDecimal(ItemList.SelectedItems[0].SubItems[2]);
            //    ChangePercent.Visible = true;
            //}
            //    //catch {}
        }

        private void TraderTree_Click(object sender, EventArgs e)
        {
            ChangePercent.Visible = false;
        }

        private void ChangePercent_Click(object sender, EventArgs e)
        {
            try
            {
                Statics.currIndex.Parts[ItemList.SelectedIndices[0]].Percentage = Convert.ToDouble(PercentageBox.Value);
                ItemsRefresh();
            }
            catch { };
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                Statics.currIndex.Parts.RemoveAt(ItemList.SelectedIndices[0]);
            }
            catch {MessageBox.Show("Не удалось удалить запись.");}
        }

        private void TraderTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void IndexEditor_Activated(object sender, EventArgs e)
        {
            TradersRefresh();
        }

        private void ItemList_Click(object sender, EventArgs e)
        {
            //try
            {
                PercentageBox.Value = Convert.ToDecimal(ItemList.SelectedItems[0].SubItems[2]);
                ChangePercent.Visible = true;
            }
            //catch {}
        }



    }
}
