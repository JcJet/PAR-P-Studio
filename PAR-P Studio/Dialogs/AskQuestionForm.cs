using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// Окно для ввода вопроса для расклада карт. Появляется при включенной опции "Задавать вопрос для рсклада"
//© Владимир Андреев, PAR-P Corp.

namespace PAR_P_Studio
{
    public partial class AskQuestionForm : Form
    {
        public AskQuestionForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            StaticParams.Question = textQuestion.Text;
            Close();
        }

        private void NoQuestionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы можете отключить этот запрос в настройках");
            Close();
        }

        private void textQuestion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                OKButton.PerformClick();
        }



    }
}
