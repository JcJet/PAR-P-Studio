using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Форма формирует число, зависящее от движения мыши пользователя. Это число будет использоваться в генераторе псевдослучайных чисел
//© Владимир Андреев, PAR-P Corp.

namespace PAR_P_Studio.Dialogs
{
    public partial class GetUserSeed : Form
    {
        int ResultSeed = 0;
        public GetUserSeed()
        {
            InitializeComponent();
        }
        

        private void MousePanel_MouseMove(object sender, MouseEventArgs e)
        {
            ResultSeed += e.X + e.Y;
            if (ProgressBar.Value < ProgressBar.Maximum)
                ProgressBar.Value++;
            this.Text = ResultSeed.ToString();
        }

        private void MousePanel_Paint(object sender, PaintEventArgs e)
        {
            string message = "Двигайте мышью в этой области до заполнения полоски.";
            e.Graphics.DrawString(message, SystemFonts.DefaultFont, SystemBrushes.WindowText,
                                new Point(MousePanel.Left + 10, MousePanel.Top + 10));
            message = "Когда закончите, щелкните мышью в области.";
            e.Graphics.DrawString(message, SystemFonts.DefaultFont, SystemBrushes.WindowText,
                               new Point(MousePanel.Left + 10, MousePanel.Top + 25));
            message = "Движение после заполнения все еще влияет на результат.";
            e.Graphics.DrawString(message, SystemFonts.DefaultFont, SystemBrushes.WindowText,
                               new Point(MousePanel.Left + 10, MousePanel.Top + 40));
        }

        private void MousePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (ProgressBar.Value == ProgressBar.Maximum)
            {
                StaticParams.UserSeed = ResultSeed;
                Close();
            }
        }
    }
}
