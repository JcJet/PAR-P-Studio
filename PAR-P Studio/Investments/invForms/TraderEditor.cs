using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PAR_P_Studio.Investments.invClasses;

namespace PAR_P_Studio.Investments.invForms
{
    public partial class TraderEditor : Form
    {
        public TraderEditor()
        {
            InitializeComponent();
        }

        private void AddAccountButton_Click(object sender, EventArgs e)
        {
            if (textNumber.Text != "")
                AccountsList.Items.Add(textNumber.Text);
            else MessageBox.Show("Данные не заполнены.");
            textNumber.Text = "";
        }

        private void RemoveAccountButton_Click(object sender, EventArgs e)
        {
            try
            {
                AccountsList.Items.RemoveAt(AccountsList.SelectedIndices[0]);
            }
            catch { }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Trader tempTrader = new Trader();
            tempTrader.Name = textName.Text;
            tempTrader.Info = textInfo.Text;
            for (int i = 0; i < AccountsList.Items.Count; i++)
            {
                Account tempAccount = new Account();
                tempAccount.Number = AccountsList.Items[i].Text;
                tempAccount.Owner = tempTrader.Name;
                tempAccount.SaveAccount();
            }
            //foreach (ListView. item in AccountsList.Items)
            //{
            //    Account tempAccount = new Account();
            //    tempAccount.Number = item.ToString();
            //    tempAccount.Owner = tempTrader.Name;
            //    tempAccount.SaveAccount();
            //}
            tempTrader.SaveTrader();
            this.Close();
            
        }
    }
}
