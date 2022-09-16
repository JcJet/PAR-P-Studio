using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

//Класс для хранения цветовой схемы
//© Владимир Андреев, PAR-P Corp.

namespace PAR_P_Studio.ProjectClasses
{
    [Serializable]
    public class ColorTheme
    {
        Color BGColor { get; set; }
        Color WinColor { get; set; }
        Color LabelColor { get; set; }

        public ColorTheme()
        {
            BGColor = Color.LightGray;
            WinColor = SystemColors.Control;
            LabelColor = SystemColors.ControlText;
        }

        public ColorTheme(Color bgcolor, Color wincolor, Color labelcolor)
        {
            BGColor = bgcolor;
            WinColor = wincolor;
            LabelColor = labelcolor;
        }

        public ColorTheme(ColorTheme ColorThemeObj)
        {
            BGColor = ColorThemeObj.BGColor;
            WinColor = ColorThemeObj.WinColor;
            LabelColor = ColorThemeObj.LabelColor;
        }

        public void SetTheme()
        {
            StaticParams.CurrentUser.UserSettings.BGColor = BGColor;
            StaticParams.CurrentUser.UserSettings.WinColor = WinColor;
            StaticParams.CurrentUser.UserSettings.LabelColor = LabelColor;
        }


        public void SaveTheme(string file)
        {
            try
            {
                string filename = "Data\\Themes\\" + file + ".thm";
                FileStream ThemeFile = new FileStream(filename, FileMode.Create, FileAccess.Write);
                BinaryFormatter ThemeFormatter = new BinaryFormatter();
                ThemeFormatter.Serialize(ThemeFile, this);
                ThemeFile.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения цветовой схемы!", "Ошибка");
            }
        }

        public void LoadTheme(string file)
        {
            try
            {
                FileStream ThemeFile = new FileStream(StaticParams.GetProgramDir() + "Data\\Themes\\" + file + ".thm",
                    FileMode.Open, FileAccess.Read);
                BinaryFormatter ThemeFormatter = new BinaryFormatter();
                ColorTheme Theme = new ColorTheme((ColorTheme)ThemeFormatter.Deserialize(ThemeFile));
                ThemeFile.Close();
                StaticParams.CurrentUser.UserSettings.LabelColor = Theme.LabelColor;
                StaticParams.CurrentUser.UserSettings.BGColor = Theme.BGColor;
                StaticParams.CurrentUser.UserSettings.WinColor = Theme.WinColor;
            }
            catch
            {
                MessageBox.Show("Ошибка загрузки цветовой схемы!", "Ошибка");
            }
        }
    }
}
