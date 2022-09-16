using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using PAR_P_Studio.ProjectClasses;

namespace PAR_P_Studio.Dialogs
{
    public partial class ThemeNameRequest : Form
    {
        public ThemeNameRequest()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ColorTheme Theme = new ColorTheme(
                StaticParams.CurrentUser.UserSettings.BGColor,
                StaticParams.CurrentUser.UserSettings.WinColor,
                StaticParams.CurrentUser.UserSettings.LabelColor);

            if (File.Exists("Data\\Themes\\" + ThemeNameTextBox.Text + ".thm"))
                if (
                       MessageBox.Show("Тема с таким именем уже существует. Заменить?", "Замена",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
                     )
                {
                    Theme.SaveTheme(ThemeNameTextBox.Text);
                    StaticParams.Events.Add(new Event("Замена цветовой схемы", ThemeNameTextBox.Text));
                    Close();
                }
                else { ;}
            else
            {
                Theme.SaveTheme(ThemeNameTextBox.Text);
                StaticParams.Events.Add(new Event("Создание новой цветовой схемы", ThemeNameTextBox.Text));
                Close();
            }


        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
