using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Форма позволяет добавить сразу несколько новых карт в текущую колоду. Вызывается из редактора Таро.
//© Владимир Андреев, PAR-P Corp.
namespace PAR_P_Studio.Dialogs
{
    public partial class CardCountRequest : Form
    {
        public CardCountRequest()
        {
            InitializeComponent();
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            if (CardCountBox.Value == 10000)
                MessageBox.Show("O_O");
            Image img = Properties.Resources.vopros;
            for (int i = 0; i < CardCountBox.Value; i++)
            StaticParams.CurrentDeck.Cards.Add(new Deck.card("New Card#" + StaticParams.CurrentDeck.Cards.Count, null,
                    img, StaticParams.CurrentDeck.Cards.Count));
            DialogResult = DialogResult.OK;

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.Cancel;
        }

        private void CardCountBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                OKbtn.PerformClick();
        }

        private void CardCountRequest_Shown(object sender, EventArgs e)
        {
            CardCountBox.Select(0, 10);
        }
    }
}
