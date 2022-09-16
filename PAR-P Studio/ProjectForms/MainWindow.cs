using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections;
using System.Xml.Serialization;
using Microsoft.Win32;
using PAR_P_Studio.ProjectForms;
using PAR_P_Studio.ProjectClasses;
using PAR_P_Studio.Dialogs;
using PAR_P_Studio.Investments;

//Основное окно платформы PAR-P позволяет изменять личные данные и переходить между разделами.
//© Владимир Андреев, PAR-P Corp.

namespace PAR_P_Studio
{
               
    public partial class MainWindow : Form
    {
            
        public MainWindow()
        {

            InitializeComponent();
            toolStripTip.Text = "";
            if (!Directory.Exists("Data\\Users\\"))
            {
                Directory.CreateDirectory("Data\\Users\\");
            }
            if (!Directory.Exists("Data\\Decks\\"))
            {
                Directory.CreateDirectory("Data\\Decks\\");
            }
            if (!Directory.Exists("Data\\Layouts\\"))
            {
                Directory.CreateDirectory("Data\\Layouts\\");
            }
            if (!Directory.Exists("Data\\Themes\\"))
            {
                Directory.CreateDirectory("Data\\Themes\\");
            }

            MainMenu.SelectedTab = MainTab;
            if (StaticParams.CommandLineParams.Length == 1)
            {
                LoginScreen dialogBox = new LoginScreen();
                dialogBox.ShowDialog();
            }

            else switch (StaticParams.CommandLineParams[1].ToUpper())
                {
                    case "N":
                        {
                            //параметр коммандной строки "n" - запуск блокнота
                            Notebook Notes = new Notebook();
                            Notes.ShowDialog();
                            break;
                        }
                    case "T":
                        {
                            //параметр коммандной строки "t" - запуск формы таро
                            TarotForm Tarot = new TarotForm();
                            Tarot.ShowDialog();
                            break;
                        }

                }
             
                
        }
        void ThemesRefresh()
        {
            ThemesBox.SuspendLayout();
            ThemesBox.Items.Clear();
            try
            {
                string[] files = Directory.GetFiles("Data\\Themes");
                foreach (string file in files)
                {
                    char[] chars = file.ToCharArray();
                    string filename = "";
                    foreach (char currChar in chars)
                    {
                        filename += currChar;
                        if (currChar == '\\')
                            filename = "";
                    }
                    if (filename.IndexOf(".thm") == filename.Length - 4)
                    {
                        filename = filename.Remove(filename.Length - 4);
                        ThemesBox.Items.Add(filename);
                    }

                }

            }
            catch
            {
                MessageBox.Show("Ошибка получения списка цветовых схем!", "Ошибка");
            }
            ThemesBox.ResumeLayout();
        }
        void SetColors()
        {
            this.BackColor = StaticParams.CurrentUser.UserSettings.WinColor;
            this.ForeColor = StaticParams.CurrentUser.UserSettings.LabelColor;
            MainTab.BackColor = StaticParams.CurrentUser.UserSettings.BGColor;
            SettingsTab.BackColor = StaticParams.CurrentUser.UserSettings.BGColor;
            FormColorPanel.BackColor = StaticParams.CurrentUser.UserSettings.BGColor;
            WinColorPanel.BackColor = StaticParams.CurrentUser.UserSettings.WinColor;
            LabelColorPanel.BackColor = StaticParams.CurrentUser.UserSettings.LabelColor;
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
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


            LoginScreen dialogBox = new LoginScreen();
            dialogBox.ShowDialog();
            MainMenu.SelectedTab = MainTab;
        }


        private void TarotButton_Click(object sender, EventArgs e)
        {
            TarotForm Tarot = new TarotForm();
            Tarot.StartPosition = FormStartPosition.CenterScreen;
            Tarot.Show();
        }

        private void NotesButton_Click(object sender, EventArgs e)
        {
            Notebook Notes = new Notebook();
            Notes.Show();
        }

        private void SettingsTab_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainWindow_Activated(object sender, EventArgs e)
        {
            InformationBox.Visible = !StaticParams.CurrentUser.Guestmode;
            UserInfoButton.Visible = !StaticParams.CurrentUser.Guestmode;
            EventsButton.Visible = !StaticParams.CurrentUser.Guestmode;

            if (StaticParams.CurrentUser.Guestmode)
            {
                LoginLabel.Text = "Гостевой режим";
                LoginLabel.ForeColor = Color.Tomato;
            }
            else
            {
                LoginLabel.Text = StaticParams.CurrentUser.Login;
                LoginLabel.ForeColor = Color.Blue;
            }


            if (StaticParams.CurrentUser.Guestmode == false)
            {
                dispName.Text = StaticParams.CurrentUser.FirstName;
                dispLastName.Text = StaticParams.CurrentUser.LastName;
                dispMidName.Text = StaticParams.CurrentUser.MidName;
                dispBirthDay.Text = StaticParams.CurrentUser.BirthDay.ToString();
                dispZodiac.Text = StaticParams.CurrentUser.GetUserZodiac();
                if (StaticParams.CurrentUser.GenderMale)
                    dispGender.Text = "М";
                else
                    dispGender.Text = "Ж";
                UserAvatar.Image = StaticParams.CurrentUser.Avatar;
                dispLastVisit.Text = StaticParams.CurrentUser.UserStatistics.LastVisit.ToString();
            }



        }


        private void AcceptChangesButton_Click(object sender, EventArgs e)
        {
            if
               (
                  textFirstNameChange.Text != "" && textLastNameChange.Text != ""
               )
            {
                StaticParams.CurrentUser.FirstName = textFirstNameChange.Text;
                StaticParams.CurrentUser.LastName = textLastNameChange.Text;
                StaticParams.CurrentUser.MidName = textMidNameChange.Text;
                StaticParams.CurrentUser.Signature = SignatureChange.Image;
                StaticParams.CurrentUser.Avatar = AvatarChange.Image;

                dispName.Text = StaticParams.CurrentUser.FirstName;
                dispLastName.Text = StaticParams.CurrentUser.LastName;
                dispMidName.Text = StaticParams.CurrentUser.MidName;
                UserAvatar.Image = StaticParams.CurrentUser.Avatar;
                StaticParams.Events.Add(new Event("Изменение личных данных", StaticParams.CurrentUser.Login));
            }
            else
                MessageBox.Show("Данные заполнены не полностью");
            if (textFirstNameChange.Text == "")
                NameChangeLabel.ForeColor = Color.Red;
            else
                NameChangeLabel.ForeColor = Color.Black;

            if (textLastNameChange.Text == "")
                LastNameChangeLabel.ForeColor = Color.Red;
            else
                LastNameChangeLabel.ForeColor = Color.Black;

        }

        private void CancelChangesButton_Click(object sender, EventArgs e)
        {
            textFirstNameChange.Text = StaticParams.CurrentUser.FirstName;
            textLastNameChange.Text = StaticParams.CurrentUser.LastName;
            textMidNameChange.Text = StaticParams.CurrentUser.MidName;
            SignatureChange.Image = StaticParams.CurrentUser.Signature;
            AvatarChange.Image = StaticParams.CurrentUser.Avatar;
            NameChangeLabel.ForeColor = Color.Black;
            LastNameChangeLabel.ForeColor = Color.Black;
        }

        private void AcceptNewPasswordButton_Click(object sender, EventArgs e)
        {
            if (textOldPassword.Text == StaticParams.CurrentUser.Password)
            {
                if (textNewPassword.Text == textNewPasswordRepeat.Text)
                {
                    StaticParams.CurrentUser.Password = textNewPassword.Text;
                    textOldPassword.Text = "";
                    textNewPassword.Text = "";
                    textNewPasswordRepeat.Text = "";
                    StaticParams.Events.Add(new Event("Смена пароля", StaticParams.CurrentUser.Login));
                    MessageBox.Show("Ваш пароль изменен.");
                }
                else
                {
                    StaticParams.Events.Add(new Event("Неудачная попытка смены пароля", StaticParams.CurrentUser.Login));
                    MessageBox.Show("Пароль и повтор пароля не совпадают, пароль не изменен");
                }
                if (textNewLogin.Text != "" && StaticParams.CurrentUser.Login != textNewLogin.Text)
                {
                    StaticParams.Events.Add(new Event("Смена логина на " + LoginLabel.Text, StaticParams.CurrentUser.Login));
                    StaticParams.CurrentUser.Login = textNewLogin.Text;
                    LoginLabel.Text = StaticParams.CurrentUser.Login;
                    MessageBox.Show("Ваш логин изменен.");
                }
                else
                {
                    StaticParams.Events.Add(new Event("Неудачная попытка смены логина", StaticParams.CurrentUser.Login));
                    MessageBox.Show("Новый логин не указан, логин не изменен");
                }
            }
            else
                MessageBox.Show("Неверно указан старый пароль, изменения не применены");
        }

        private void SettingsTab_Enter(object sender, EventArgs e)
        {
            if (StaticParams.CurrentUser.Guestmode == false)
            {
                PersonalDataSettingsBox.Enabled = true;
                LoginAndPassChangeBox.Enabled = true;
                LabelGuestMode.Visible = false;

                textFirstNameChange.Text = StaticParams.CurrentUser.FirstName;
                textLastNameChange.Text = StaticParams.CurrentUser.LastName;
                textMidNameChange.Text = StaticParams.CurrentUser.MidName;
                SignatureChange.Image = StaticParams.CurrentUser.Signature;
                AvatarChange.Image = StaticParams.CurrentUser.Avatar;
                textNewLogin.Text = StaticParams.CurrentUser.Login;
            }
            else
            {
                PersonalDataSettingsBox.Enabled = false;
                LoginAndPassChangeBox.Enabled = false;
                LabelGuestMode.Text = "У гостей нет личных данных...";
                LabelGuestMode.Visible = true;
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            StaticParams.Events.Add(new Event("Закрытие программы", "Программа"));
            Files.EventLogSave();


            StaticParams.CurrentUser.UserStatistics.LastVisit = DateTime.Now;
            if (!StaticParams.CurrentUser.Guestmode && StaticParams.Access == StaticParams.AccessType.One)
            {
                foreach (User item in StaticParams.Users)
                {
                    if (item.Login == StaticParams.CurrentUser.Login)
                    {
                        StaticParams.CurrentUser.UserStatistics.LogonTime +=  DateTime.Now - StaticParams.ProgramEnter;
                        StaticParams.Users[StaticParams.Users.IndexOf(item)] = new User(StaticParams.CurrentUser);
                        break;
                    }

                }
                Files.SaveBigFiles();
            }
//
            //Сохранение пользовательских настроек
            if (!StaticParams.CurrentUser.Guestmode && StaticParams.Access == StaticParams.AccessType.Separate)
            {
                StaticParams.CurrentUser.SaveUser();

                try
                {
                    RegistryKey registryKeyOptions = Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("PAR-P");
                    string SavePassword = (string)registryKeyOptions.GetValue("SavePassword", "False");
                    registryKeyOptions.SetValue("LastUser", StaticParams.CurrentUser.Login, RegistryValueKind.String);

                    if (SavePassword == "True")
                    {
                        registryKeyOptions.SetValue("Password", StaticParams.CurrentUser.Password, RegistryValueKind.String);
                        registryKeyOptions.Close();
                    }
                    else
                    {
                        registryKeyOptions.SetValue("Password", "", RegistryValueKind.String);
                        registryKeyOptions.Close();
                    }
                }
                catch { }
            }

        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutForm AF = new AboutForm();
            AF.ShowDialog();

        }


        private void SignatureChangeButton_Click(object sender, EventArgs e)
        {
            Image image = StaticParams.CurrentUser.Signature;
            Files.OpenImage(ref image);
            if (image != null)
                SignatureChange.Image = image;
        }

        private void AvatarChangeButton_Click(object sender, EventArgs e)
        {
            Image image = StaticParams.CurrentUser.Avatar;
            Files.OpenImage(ref image);
            if (image != null)
                AvatarChange.Image = image;
        }

        #region Подсказки в строке состояния
        private void UserInfoButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Статистика и дополнительная информация для пользователя";
        }

        private void UserInfoButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void EventsButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Журнал событий по всем пользователям";
        }

        private void EventsButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void AboutButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Информация о создателях программы";
        }


        private void AcceptNewPasswordButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Изменить пароль и логин";
        }

        private void CancelChangesButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Сбросить поля";
        }

        private void AcceptChangesButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Сохранить новые личные данные";
        }

        private void выйтиToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Вернуться в окно приветствия";
        }

        private void закрытьToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Закрыть программу";
        }

        private void TarotButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Открыть раздел для работы с картами Таро";
        }

        private void NotesButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Открыть RTF редакор (создан только для использования в связке с другими элементами программы)";
        }

        private void выйтиToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void закрытьToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void TarotButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void NotesButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void AboutButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void AcceptChangesButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void CancelChangesButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void AcceptNewPasswordButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }
        

        private void LoginLabel_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Имя пользователя, под которым Вы вошли";
        }

        private void toolStripTip_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Здесь будут отображаться подсказки к элементу под курсором мыши";
        }

        private void LoginLabel_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void toolStripTip_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }
        #endregion

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            SetColors();
            ThemesRefresh();
            if (StaticParams.CurrentUser.Guestmode)
                StaticParams.Events.Add(new Event("Гостевой вход", "Программа"));
            if (StaticParams.CurrentUser.UserSettings.DidYouKnow != false)
            {
                DidYouKnow DYK = new DidYouKnow();
                DYK.Show();
            }
        }

        private void UserInfoButton_Click(object sender, EventArgs e)
        {
            UserInfo UI = new UserInfo();
            UI.Show();
        }

        private void EventsButton_Click(object sender, EventArgs e)
        {
            Files.EventLogSave();
            EventLog EL = new EventLog();
            EL.ShowDialog();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            KnowlegeBase KB = new KnowlegeBase();
            KB.Show();
        }

        private void HelpContentsButton_Click(object sender, EventArgs e)
        {
            KnowlegeBase KB = new KnowlegeBase();
            KB.Show();
        }

        private void BGColorChangeButton_Click(object sender, EventArgs e)
        {
            if (FormColorDialog.ShowDialog() == DialogResult.OK)
            {
                StaticParams.CurrentUser.UserSettings.BGColor = FormColorDialog.Color;
                StaticParams.Events.Add(new Event("Цвет фона изменен", StaticParams.CurrentUser.Login));
            }
            SetColors();
        }

        private void WinColorChangeButton_Click(object sender, EventArgs e)
        {
            if (WinColorDialog.ShowDialog() == DialogResult.OK)
            {
                StaticParams.CurrentUser.UserSettings.WinColor = WinColorDialog.Color;
                StaticParams.Events.Add(new Event("Цвет окон изменен", StaticParams.CurrentUser.Login));
            }
            SetColors();
        }

        private void LabelColorChangeButton_Click(object sender, EventArgs e)
        {
            if (LabelColorDialog.ShowDialog() == DialogResult.OK)
            {
                StaticParams.CurrentUser.UserSettings.LabelColor = LabelColorDialog.Color;
                StaticParams.Events.Add(new Event("Цвет надписей изменен", StaticParams.CurrentUser.Login));
            }
            SetColors();
        }

        private void DefaultColorsButton_Click(object sender, EventArgs e)
        {
            StaticParams.CurrentUser.UserSettings.BGColor = Color.LightGray;
            StaticParams.CurrentUser.UserSettings.WinColor = SystemColors.Control;
            StaticParams.CurrentUser.UserSettings.LabelColor = SystemColors.ControlText;
            StaticParams.Events.Add(new Event("Восстановление цветовых настроек", StaticParams.CurrentUser.Login));
            SetColors();
        }

        private void ThemesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ThemesBox.SelectedIndex != -1)
            {
                ColorTheme THM = new ColorTheme();
                THM.LoadTheme(ThemesBox.Text);
                SetColors();
                StaticParams.Events.Add(new Event("Смена цветовой схемы", StaticParams.CurrentUser.Login));
            }
        }

        private void SaveTheme_Click(object sender, EventArgs e)
        {
            ThemeNameRequest TNR = new ThemeNameRequest();
            TNR.ShowDialog();
            ThemesRefresh();
        }

        private void UserAvatar_Click(object sender, EventArgs e)
        {
            if (UserAvatar.Image != null)
            {
                LargeImage LIM = new LargeImage(UserAvatar.Image);
                LIM.Show();
            }
        }

        private void AvatarChange_Click(object sender, EventArgs e)
        {
            if (AvatarChange.Image != null)
            {
                LargeImage LIM = new LargeImage(AvatarChange.Image);
                LIM.Show();
            }
        }

        private void SignatureChange_Click(object sender, EventArgs e)
        {
            if (SignatureChange.Image != null)
            {
                LargeImage LIM = new LargeImage(SignatureChange.Image);
                LIM.Show();
            }
        }

        private void InvestButton_Click(object sender, EventArgs e)
        {
            Investments.invForms.InvestmentsForm inForm = new Investments.invForms.InvestmentsForm();
            inForm.Show();
        }




    }
}
