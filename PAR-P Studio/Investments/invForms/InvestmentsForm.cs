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
using System.Runtime.Serialization.Formatters.Binary;

namespace PAR_P_Studio.Investments.invForms
{
    public partial class InvestmentsForm : Form
    {
        public InvestmentsForm()
        {
            InitializeComponent();
            if (!Directory.Exists("Data\\Forex\\"))
            {
                Directory.CreateDirectory("Data\\Forex\\");
            }
            if (!Directory.Exists("Data\\Forex\\Indexes\\"))
            {
                Directory.CreateDirectory("Data\\Forex\\Indexes\\");
            }
            if (!Directory.Exists("Data\\Forex\\Traders\\"))
            {
                Directory.CreateDirectory("Data\\Forex\\Traders\\");
            }
            if (!Directory.Exists("Data\\Forex\\Accounts\\"))
            {
                Directory.CreateDirectory("Data\\Forex\\Accounts\\");
            }
            Statics.currAccount = new Account();
            Statics.currIndex = new Index();
            Statics.currTrader = new Trader();
            money = Convert.ToDouble(textMoney.Text);
        }
        double money;
        void CalcTraders() //расчет доли трейдеров при выборе нескольких индексов.
        {
            FinishedList.Items.Clear();
            for (int i = 0; i < SelectedList.Items.Count; i++)
            {
                Statics.LoadIndex(SelectedList.Items[i].Text);
                double IndexPercent = Convert.ToDouble(SelectedList.Items[i].SubItems[1].Text)/100;
                    for (int j = 0; j < Statics.currIndex.Parts.Count; j++)
                    {
                        double PartPercent = Statics.currIndex.Parts[j].Percentage/100;
                        Statics.LoadAccount(Statics.currIndex.Parts[j].Number);
                        double PartMoney = money * IndexPercent * PartPercent;
                        if (FinishedList.FindItemWithText(Statics.currAccount.Owner) != null)
                        { 
                            PartMoney += Convert.ToDouble(FinishedList.FindItemWithText(Statics.currAccount.Owner).SubItems[2].Text);
                            FinishedList.FindItemWithText(Statics.currAccount.Owner).SubItems[2].Text = Convert.ToString(PartMoney);
                        }
                        else
                        {
                            FinishedList.Items.Add(Statics.currAccount.Owner);
                             FinishedList.Items[FinishedList.Items.Count - 1].SubItems.Add(Convert.ToString(PartMoney));
                             FinishedList.Items[FinishedList.Items.Count - 1].SubItems.Add(Convert.ToString(PartMoney));
                        }
                        FinishedList.FindItemWithText(Statics.currAccount.Owner).SubItems[1].Text = Convert.ToString(PartMoney / (money / 100));

                            
                    }
            }
        }

        void Optimize()
        {
            double step = money / 100; //шаг изменения доли (1%)
            //поиск меньшей и большей доли в конечном списке.
            int min = Convert.ToInt32(money), max = 0, minInd = 0, maxInd = 0;
            for (int i = 0; i < FinishedList.Items.Count - 1; i++)
            {
                int tmp = Convert.ToInt32(FinishedList.Items[i].SubItems[2].Text);
                if (tmp > max)
                {
                    max = tmp;
                    maxInd = i;
                }
                if (tmp < min)
                {
                    min = tmp;
                    minInd = i;
                }
            }
            //поиск долей этих трейдеров в списке выбраных индексов
            int min2 = 100, max2 = 0, min2Ind = 0, max2Ind = 0;
            string min2name, max2name;
            for (int i = 0; i < SelectedList.Items.Count - 1; i++)
            {
                Statics.LoadIndex(SelectedList.Items[i].Text);
                for (int j = 0; j < Statics.currIndex.Parts.Count - 1; j++)
                {
                    Statics.LoadAccount(Statics.currIndex.Parts[j].Number);
                    if ((Statics.currAccount.Owner == FinishedList.Items[minInd].Text) &&
                        (Statics.currIndex.Parts[j].Percentage < min2))
                    {
                        min2 = Convert.ToInt32(Statics.currIndex.Parts[j].Percentage);
                        min2Ind = i;
                        min2name = Statics.currIndex.Name;
                    }
                    if ((Statics.currAccount.Owner == FinishedList.Items[maxInd].Text) &&
                        (Statics.currIndex.Parts[j].Percentage > max2))
                    {
                        max2 = Convert.ToInt32(Statics.currIndex.Parts[j].Percentage);
                        max2Ind = i;
                        max2name = Statics.currIndex.Name;
                    }
                }
        
                }




                int tmp2 = Convert.ToInt32(SelectedList.Items[max2Ind].SubItems[1].Text);
                SelectedList.Items[max2Ind].SubItems[1].Text = Convert.ToString(tmp2 - 1);
                tmp2 = Convert.ToInt32(SelectedList.Items[min2Ind].SubItems[1].Text);
                SelectedList.Items[min2Ind].SubItems[1].Text = Convert.ToString(tmp2 + 1);
            }




        void IndexRefresh()
        {
            IndexList.BeginUpdate();
            IndexList.Items.Clear();
                if (!OwnedOnly.Checked)
                {
                    string[] files = Directory.GetFiles(StaticParams.GetProgramDir() + "Data\\Forex\\Indexes");
                    foreach (string item in files)
                    {
                        if (item.IndexOf(".ind") == item.Length - 4)
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
                            IndexList.Items.Add(file);
                        }
                    }
                }
                else if (OwnedOnly.Checked)
                {
                    Index tempIndex = new Index();
                    string[] files = Directory.GetFiles(StaticParams.GetProgramDir() + "Data\\Forex\\Indexes");
                    foreach (string item in files)
                    {
                        //try
                        {

                            FileStream IndexFile = new FileStream(item,
                                FileMode.Open, FileAccess.Read);
                            BinaryFormatter UserFormatter = new BinaryFormatter();
                            tempIndex = new Index((Index)UserFormatter.Deserialize(IndexFile));
                            if (!OwnedOnly.Checked || tempIndex.Owner == StaticParams.CurrentUser.Login)
                                IndexList.Items.Add(tempIndex.Name);
                            IndexFile.Close();
                        }
                        //catch { }
                    }
                }
            IndexList.EndUpdate();
        }


        private void Investments_Shown(object sender, EventArgs e)
        {
            IndexRefresh();
        }

        private void CreateIndexButton_Click(object sender, EventArgs e)
        {
            IndexEditor indEdit = new IndexEditor(0);
            indEdit.ShowDialog();
        }

        private void AlterIndexButton_Click(object sender, EventArgs e)
        {
            if (IndexList.SelectedIndices.Count == 1)
            {
                Statics.LoadIndex(IndexList.SelectedItems[0].Text);
                IndexEditor IE = new IndexEditor(0);
                IE.ShowDialog();
            }
        }

        private void RemoveIndexButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить выбранный индекс?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
               == DialogResult.Yes)
            {
                File.Delete(StaticParams.GetProgramDir() + "Data\\Forex\\Indexes" + IndexList.SelectedIndices[0].ToString() + ".ind");
                IndexRefresh();
            }
        }

        private void AddIndexButton_Click(object sender, EventArgs e)
        {
            if (IndexList.SelectedIndices.Count > 0)
            {
                foreach (int ind in IndexList.SelectedIndices)
                {
                    SelectedList.Items.Add(IndexList.Items[ind].Text);
                }
                for (int i = 0; i < SelectedList.Items.Count; i++)
                {
                    int perc = 100 / SelectedList.Items.Count;
                    try
                    {
                        SelectedList.Items[i].SubItems[1].Text = (Convert.ToString(perc));
                        SelectedList.Items[i].SubItems[2].Text = (Convert.ToString(perc * money / 100));
                    }
                    catch
                    {
                        SelectedList.Items[i].SubItems.Add(Convert.ToString(perc));
                        SelectedList.Items[i].SubItems.Add(Convert.ToString(perc * money / 100));
                    }
                }
                CalcTraders();
            }
        }

        private void OptimizeButton_Click(object sender, EventArgs e)
        {
            if (SelectedList.Items.Count == 0)
                MessageBox.Show("Ничего не выбрано.");
            else
                //Оптимизация диверсификаци...
            {/////////////////////

                Optimize();
                CalcTraders();

            }//////////////////////////
        }

        private void textMoney_TextChanged(object sender, EventArgs e)
        {
            try
            {
                money = Convert.ToDouble(textMoney.Text);
            }
            catch { };
        }
    }
}
