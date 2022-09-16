using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using PAR_P_Studio.ProjectClasses;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Показывает статистику и дополнительную информацию о текущем пользователе
//©PAR-P Corp.

namespace PAR_P_Studio.ProjectForms
{
    public partial class UserInfo : Form
    {
        StringBuilder StrBuilder;
        public UserInfo()
        {
            InitializeComponent();
            InfoTabs.SelectedTab = StatisticsTab;
            StrBuilder = new StringBuilder();
            CardsInfo.Rtf = PAR_P_Studio.Properties.Resources.CardsInfo;
        }

        void SetColors()
        {
            this.BackColor = StaticParams.CurrentUser.UserSettings.WinColor;
            this.ForeColor = StaticParams.CurrentUser.UserSettings.LabelColor;
            StatisticsTab.BackColor = StaticParams.CurrentUser.UserSettings.BGColor;
            CardsTab.BackColor = StaticParams.CurrentUser.UserSettings.BGColor;
        }


        string GetMajorArcana(byte number)
        {
            //Метод возвращает название старшего аркана с указанным номером
            switch (number)
            {
                case 0:
                    return "Шут";
                case 1:
                    return "Маг";
                case 2:
                    return "Верховная Жрица";
                case 3:
                    return "Императрица";
                case 4:
                    return "Император";
                case 5:
                    return "Иерофант";
                case 6:
                    return "Влюбленные";
                case 7:
                    return "Колесница";
                case 8:
                    return "Справедливость";
                case 9:
                    return "Отшельник";
                case 10:
                    return "Колесо Фортуны";
                case 11:
                    return "Сила";
                case 12:
                    return "Повешенный";
                case 13:
                    return "Смерть";
                case 14:
                    return "Умеренность";
                case 15:
                    return "Дьявол";
                case 16:
                    return "Башня";
                case 17:
                    return "Звезда";
                case 18:
                    return "Луна";
                case 19:
                    return "Солнце";
                case 20:
                    return "Суд";
                case 21:
                    return "Мир";
                case 22:
                    return "Шут";
                default:
                    return "Неизвестно";
            }
        }

        private void UserInfo_Shown(object sender, EventArgs e)
        {
            SetColors();
            if (StaticParams.CurrentUser.Guestmode)
            {
                toolStripLogin.Text = "Гостевой режим";
                toolStripLogin.ForeColor = Color.Tomato;
            }
            else
            {
                toolStripLogin.Text = StaticParams.CurrentUser.Login;
                toolStripLogin.ForeColor = Color.Blue;
            }
            #region Определение предпочитаемого расклада и колоды
            //Определение наиболее часто используемого расклада и колоды текущим пользователем
            //На основе статистики раскладов
            Hashtable ht = new Hashtable();
            Hashtable ht2 = new Hashtable();
            foreach (User.Statistics.LayoutDetails item in StaticParams.CurrentUser.UserStatistics.LayoutStats)
            {
                if (!ht.ContainsKey(item.LType))
                    ht.Add(item.LType,(int)0);
                ht[item.LType] = (int)ht[item.LType] + 1;
                if (!ht2.ContainsKey(item.LDeck))
                    ht2.Add(item.LDeck,(int)0);
                ht2[item.LDeck] = (int)ht2[item.LDeck] + 1;
            }
            int max = -1;
            foreach (DictionaryEntry de in ht)
            {
                if ((int)de.Value > max)
                {
                    max = (int)de.Value;
                    dispFavoriteLayout.Text = (string)de.Key;
                }
            }
            max = -1;
            foreach (DictionaryEntry de in ht2)
            {
                if ((int)de.Value > max)
                {
                    max = (int)de.Value;
                    dispFavoriteDeck.Text = (string)de.Key;
                }
            }
            #endregion
            UpdateTimer_Tick(null, null);

            #region Карты личности, души и года
            //Определение личных карт
            //Карта личности:
            int sum = 0;
            sum = StaticParams.CurrentUser.BirthDay.Month + StaticParams.CurrentUser.BirthDay.Day + StaticParams.CurrentUser.BirthDay.Year;
            int tmpsum = 0;
            do
            {
                do
                {
                    tmpsum += sum % 10;
                    sum -= sum % 10;
                    sum /= 10;

                } while (sum != 0);
                sum = tmpsum;
            } while (sum > 22);
            tmpsum = 0;
            dispPersonCard.Text = sum.ToString() + " (" + GetMajorArcana((byte)sum) + ")";
            //Карта души:
            if (sum - (sum % 10) != 0)
            {
                do
                {
                    tmpsum += sum % 10;
                    sum -= sum % 10;
                    sum /= 10;

                } while (sum != 0);
                sum = tmpsum;
            }
            tmpsum = 0;
            dispSoulCard.Text = sum.ToString() + " (" + GetMajorArcana((byte)sum) + ")";
            //Карта года:
            sum = 0;
            sum = StaticParams.CurrentUser.BirthDay.Month + StaticParams.CurrentUser.BirthDay.Day + DateTime.Now.Year;
            do
            {
                do
                {
                    tmpsum += sum % 10;
                    sum -= sum % 10;
                    sum /= 10;

                } while (sum != 0);
                sum = tmpsum;
            } while (sum > 22);

            dispYearCard.Text = sum.ToString() + " (" + GetMajorArcana((byte)sum) + ")";
            #endregion

        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if (((TimeSpan)(DateTime.Now - StaticParams.ProgramEnter + StaticParams.CurrentUser.UserStatistics.LogonTime)).Days > 0)
            {
                StrBuilder.Append(((TimeSpan)(DateTime.Now - StaticParams.ProgramEnter + StaticParams.CurrentUser.UserStatistics.LogonTime)).Days);
                StrBuilder.Append("Д, ");
            }
            if (((TimeSpan)(DateTime.Now - StaticParams.ProgramEnter + StaticParams.CurrentUser.UserStatistics.LogonTime)).Hours > 0)
            {
                StrBuilder.Append(((TimeSpan)(DateTime.Now - StaticParams.ProgramEnter + StaticParams.CurrentUser.UserStatistics.LogonTime)).Hours);
                StrBuilder.Append("Ч, ");
            }
            if (((TimeSpan)(DateTime.Now - StaticParams.ProgramEnter + StaticParams.CurrentUser.UserStatistics.LogonTime)).Minutes > 0)
            {
                StrBuilder.Append(((TimeSpan)(DateTime.Now - StaticParams.ProgramEnter + StaticParams.CurrentUser.UserStatistics.LogonTime)).Minutes);
                StrBuilder.Append("М, ");
            }
            StrBuilder.Append(((TimeSpan)(DateTime.Now - StaticParams.ProgramEnter + StaticParams.CurrentUser.UserStatistics.LogonTime)).Seconds);
            StrBuilder.Append("С.");

            dispLogonTime.Text = StrBuilder.ToString();
            StrBuilder.Clear();

            dispLayoutCount.Text = StaticParams.CurrentUser.UserStatistics.LayoutCount.ToString();
            dispDrawnCards.Text = StaticParams.CurrentUser.UserStatistics.DrawnCards.ToString();
            dispLogonCount.Text = StaticParams.CurrentUser.UserStatistics.LogonCount.ToString();
        }

        #region Подсказки
        private void LogonTimeLabel_MouseMove(object sender, MouseEventArgs e)
        {
            ToolStripTip.Text = "Время, которое Вы провели в программе";
        }

        private void dispLogonTime_MouseMove(object sender, MouseEventArgs e)
        {
            ToolStripTip.Text = "Время, которое Вы провели в программе";
        }

        private void LayoutsLabel_MouseMove(object sender, MouseEventArgs e)
        {
            ToolStripTip.Text = "Счетчик сделанных Вами раскладов";
        }

        private void dispLayoutCount_MouseMove(object sender, MouseEventArgs e)
        {
            ToolStripTip.Text = "Счетчик сделанных Вами раскладов";
        }

        private void CardsLabel_MouseMove(object sender, MouseEventArgs e)
        {
            ToolStripTip.Text = "Счетчик вытянутых Вами карт";
        }

        private void dispDrawnCards_MouseMove(object sender, MouseEventArgs e)
        {
            ToolStripTip.Text = "Счетчик вытянутых Вами карт";
        }

        private void LogonLabel_MouseMove(object sender, MouseEventArgs e)
        {
            ToolStripTip.Text = "Счетчик Ваших входов в программу";
        }

        private void dispLogonCount_MouseMove(object sender, MouseEventArgs e)
        {
            ToolStripTip.Text = "Счетчик Ваших входов в программу";
        }

        private void DeckLabel_MouseMove(object sender, MouseEventArgs e)
        {
            ToolStripTip.Text = "(Исходя из статистики раскладов)";
        }

        private void dispFavoriteDeck_MouseMove(object sender, MouseEventArgs e)
        {
            ToolStripTip.Text = "(Исходя из статистики раскладов)";
        }

        private void LayoutLabel_MouseMove(object sender, MouseEventArgs e)
        {
            ToolStripTip.Text = "(Исходя из статистики раскладов)";
        }

        private void dispFavoriteLayout_MouseMove(object sender, MouseEventArgs e)
        {
            ToolStripTip.Text = "(Исходя из статистики раскладов)";
        }

        private void LogonTimeLabel_MouseLeave(object sender, EventArgs e)
        {
            ToolStripTip.Text = "";
        }

        private void dispLogonTime_MouseLeave(object sender, EventArgs e)
        {
            ToolStripTip.Text = "";
        }

        private void LayoutsLabel_MouseLeave(object sender, EventArgs e)
        {
            ToolStripTip.Text = "";
        }

        private void dispLayoutCount_MouseLeave(object sender, EventArgs e)
        {
            ToolStripTip.Text = "";
        }

        private void CardsLabel_MouseLeave(object sender, EventArgs e)
        {
            ToolStripTip.Text = "";
        }

        private void dispDrawnCards_MouseLeave(object sender, EventArgs e)
        {
            ToolStripTip.Text = "";
        }

        private void LogonLabel_MouseLeave(object sender, EventArgs e)
        {
            ToolStripTip.Text = "";
        }

        private void dispLogonCount_MouseLeave(object sender, EventArgs e)
        {
            ToolStripTip.Text = "";
        }

        private void DeckLabel_MouseLeave(object sender, EventArgs e)
        {
            ToolStripTip.Text = "";
        }

        private void dispFavoriteDeck_MouseLeave(object sender, EventArgs e)
        {
            ToolStripTip.Text = "";
        }

        private void LayoutLabel_MouseLeave(object sender, EventArgs e)
        {
            ToolStripTip.Text = "";
        }

        private void dispFavoriteLayout_MouseLeave(object sender, EventArgs e)
        {
            ToolStripTip.Text = "";
        }
        #endregion



    }
}
