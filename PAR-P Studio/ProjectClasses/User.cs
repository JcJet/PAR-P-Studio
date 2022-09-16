using System;
using System.Drawing;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

//Структура данных пользователя
//© Владимир Андреев, PAR-P Corp.

namespace PAR_P_Studio
{
    [Serializable]
    public class User : IComparable
    {
        public enum LayoutMode { Auto, Manual }

        public bool Guestmode { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MidName { get; set; }
        public DateTime BirthDay { get; set; }
        public bool GenderMale { get; set; }
        public Image Signature { get; set; }
        public Image Avatar { get; set; }
        public Settings UserSettings { get; set; }
        public Statistics UserStatistics { get; set; }


        public User()
        {
            Guestmode = true;
            Login = "Гость";
            UserSettings = new Settings();
        }
        public User(bool guestmode, string login)
    {
        Guestmode = guestmode;
        Login = login;
        UserSettings = new Settings();
        UserStatistics = new Statistics();
    }

        public User(bool guestmode, string login, string password, string firstname, string lastname, string midname, 
            DateTime birthday,bool gender, Image signature, Image avatar)
        {
            Guestmode = guestmode;
            Login = login;
            Password = password;
            FirstName = firstname;
            LastName = lastname;
            MidName = midname;
            BirthDay = birthday;
            GenderMale = gender;
            Signature = signature;
            Avatar = avatar;
            UserSettings = new Settings();
            UserStatistics = new Statistics();
        }

        public User(User UserObj)
        {
            Guestmode = UserObj.Guestmode;
            Login = UserObj.Login;
            Password = UserObj.Password;
            FirstName = UserObj.FirstName;
            LastName = UserObj.LastName;
            MidName = UserObj.MidName;
            BirthDay = UserObj.BirthDay;
            GenderMale = UserObj.GenderMale;
            Signature = UserObj.Signature;
            Avatar = UserObj.Avatar;
            UserSettings = new Settings(UserObj.UserSettings);
            UserStatistics = new Statistics(UserObj.UserStatistics);

        }
        [Serializable]
        public class Settings
        {
            public bool SameCards { get; set; }
            public bool ShowCards { get; set; }
            public bool MaximizeLayout { get; set; }
            public bool AskQuestion { get; set; }
            public bool GetUserSeed { get; set; }
            public bool HideTips { get; set; }
            public bool DidYouKnow { get; set; }
            public bool HiddenLayout { get; set; }
            public int ShakeSpeed { get; set; }
            public LayoutMode ShakeMode { get; set; }
            public int UDChance { get; set; }
            public Color BGColor { get; set; }
            public Color WinColor { get; set; }
            public Color LabelColor { get; set; }
            public string OverrideDeck { get; set; }
            public Settings()
            {
                SameCards = false;
                ShowCards = false;
                MaximizeLayout = true;
                AskQuestion = false;
                GetUserSeed = false;
                HideTips = false;
                DidYouKnow = true;
                HiddenLayout = true;
                ShakeSpeed = 100;
                ShakeMode = LayoutMode.Auto;
                UDChance = 5;
                BGColor = Color.LightGray;
                WinColor = SystemColors.Control;
                LabelColor = SystemColors.ControlText;
                OverrideDeck = "";
            }
            public Settings(Settings SettingsObj)
            {
                SameCards = SettingsObj.SameCards;
                ShowCards = SettingsObj.ShowCards;
                MaximizeLayout = SettingsObj.MaximizeLayout;           
                GetUserSeed = SettingsObj.GetUserSeed;
                AskQuestion = SettingsObj.AskQuestion;
                HideTips = SettingsObj.HideTips;
                DidYouKnow = SettingsObj.DidYouKnow;
                HiddenLayout = SettingsObj.HiddenLayout;
                ShakeSpeed = SettingsObj.ShakeSpeed;
                ShakeMode = SettingsObj.ShakeMode;
                UDChance = SettingsObj.UDChance;
                BGColor = SettingsObj.BGColor;
                WinColor = SettingsObj.WinColor;
                LabelColor = SettingsObj.LabelColor;
                OverrideDeck = SettingsObj.OverrideDeck;
            }
        }
        [Serializable]
        public class Statistics
        {
            public DateTime LastVisit { get; set; }
            public List<LayoutDetails> LayoutStats { get; set; }
            public TimeSpan LogonTime { get; set; }
            public int LayoutCount { get; set; }
            public int DrawnCards { get; set; }
            public int LogonCount { get; set; }
            public Statistics()
            {
                LastVisit = new DateTime();
                LastVisit = DateTime.Now;
                LayoutStats = new List<LayoutDetails>();
                LogonTime = new TimeSpan();
                LogonTime = TimeSpan.Zero;
                LayoutCount = 0;
                DrawnCards = 0;
                LogonCount = 0;
            }
            public Statistics(Statistics StatisticsObj)
            {
                LastVisit = StatisticsObj.LastVisit;
                LayoutStats = new List<LayoutDetails>();
                foreach (LayoutDetails item in StatisticsObj.LayoutStats)
                    LayoutStats.Add(item);
                LogonTime = new TimeSpan();
                LogonTime = StatisticsObj.LogonTime;
                LayoutCount = StatisticsObj.LayoutCount;
                DrawnCards = StatisticsObj.DrawnCards;
                LogonCount = StatisticsObj.LogonCount;
            }

            [Serializable]
            public class LayoutDetails
            {
                public List<Deck.card> LayoutResult;
                public DateTime LayoutDate;
                public string Question;
                public string LType;
                public string LDeck;
                public string Comment;

                public LayoutDetails()
                {
                    LayoutResult = new List<Deck.card>();
                    LayoutDate = new DateTime();
                    Question = "";
                    LType = "";
                    LDeck = "";
                    Comment = "";
                }

                public LayoutDetails(List<Deck.card> layoutresult, DateTime date, string question, string layoutname, string deckname, string comment)
                {
                    LayoutResult = new List<Deck.card>();
                    foreach (Deck.card item in layoutresult)
                        LayoutResult.Add(item);
                    LayoutDate = new DateTime();
                    LayoutDate = (DateTime)date;
                    Question = question;
                    LType = layoutname;
                    LDeck = deckname;
                    Comment = comment;
                }

                public LayoutDetails(LayoutDetails LayoutDetailsObj)
                {
                    LayoutResult = new List<Deck.card>();
                    foreach (Deck.card item in LayoutDetailsObj.LayoutResult)
                        LayoutResult.Add(item);
                    LayoutDate = new DateTime();
                    LayoutDate = (DateTime)LayoutDetailsObj.LayoutDate;
                    Question = LayoutDetailsObj.Question;
                    LType = LayoutDetailsObj.LType;
                    LDeck = LayoutDetailsObj.LDeck;
                    Comment = LayoutDetailsObj.Comment;
                }
            }

        }


        public string GetUserZodiac()
        {
            if 
               (
                ((BirthDay.Month == 3) && (BirthDay.Day >= 21)) || 
                 ((BirthDay.Month == 4) && (BirthDay.Day <=20))
               ) return "Овен";
            if
               (
                 ((BirthDay.Month == 4) && (BirthDay.Day >= 21)) ||
                ((BirthDay.Month == 5) && (BirthDay.Day <= 20))
               ) return "Телец";
            if
                (
                 ((BirthDay.Month == 5) && (BirthDay.Day >= 21)) ||
                ((BirthDay.Month == 6) && (BirthDay.Day <= 21))
                ) return "Близнецы";
            if
                (
                 ((BirthDay.Month == 6) && (BirthDay.Day >= 22)) ||
                ((BirthDay.Month == 7) && (BirthDay.Day <= 22))
                ) return "Рак";
            if
                (
                 ((BirthDay.Month == 7) && (BirthDay.Day >= 23)) ||
                ((BirthDay.Month == 8) && (BirthDay.Day <= 23))
                ) return "Лев";
            if
                (
                 ((BirthDay.Month == 8) && (BirthDay.Day >= 24)) ||
                ((BirthDay.Month == 9) && (BirthDay.Day <= 23))
                ) return "Дева";
            if
                (
                 ((BirthDay.Month == 9) && (BirthDay.Day >= 24)) ||
                ((BirthDay.Month == 10) && (BirthDay.Day <= 22))
                ) return "Весы";
            if
                (
                 ((BirthDay.Month == 10) && (BirthDay.Day >= 23)) ||
                ((BirthDay.Month == 11) && (BirthDay.Day <= 22))
                ) return "Скорпион";
            if
                (
                 ((BirthDay.Month == 11) && (BirthDay.Day >= 23)) ||
                ((BirthDay.Month == 12) && (BirthDay.Day <= 21))
                ) return "Стрелец";
            if
                (
                ((BirthDay.Month == 12) && (BirthDay.Day >= 22)) ||
                ((BirthDay.Month == 1) && (BirthDay.Day <= 20))
                ) return "Козерог";
            if
                (
                ((BirthDay.Month == 1) && (BirthDay.Day >= 21)) ||
                ((BirthDay.Month == 2) && (BirthDay.Day <= 19))
                ) return "Водолей";
            if
                (
                ((BirthDay.Month == 2) && (BirthDay.Day >= 20)) ||
                ((BirthDay.Month == 3) && (BirthDay.Day <= 20))
                ) return "Рыбы";
            return "Error!";

               
        }
        //public void SaveUser(User UserObj)
        //{
        //    if (!Directory.Exists("Data//Users//"))
        //    {
        //        Directory.CreateDirectory("Data//Users//");
        //    }
        //    string filename = "Data//Users//" + UserObj + ".usr";
        //    FileStream UserFile = new FileStream(filename, FileMode.Create, FileAccess.Write);
        //    BinaryFormatter CurrentUserFormatter = new BinaryFormatter();
        //    CurrentUserFormatter.Serialize(UserFile, UserObj);
        //    UserFile.Close();
        //}
        public void SaveUser()
        {
            string filename = "Data\\Users\\" + Login + ".usr";
            FileStream UserFile = new FileStream(filename, FileMode.Create, FileAccess.Write);
            BinaryFormatter CurrentUserFormatter = new BinaryFormatter();
            this.UserStatistics.LogonTime += DateTime.Now - StaticParams.ProgramEnter;
            CurrentUserFormatter.Serialize(UserFile, this);
            UserFile.Close();
        }
        int IComparable.CompareTo(object obj)
        {
                User temp = obj as User;
                if (temp != null)
                    return string.Compare(this.Login, temp.Login);
                else
                    throw new ArgumentException("Parameter is not a User!");
        }

    }
}
