 using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using PAR_P_Studio.ProjectForms;
using PAR_P_Studio.ProjectClasses;

//Статичный класс для хранения переменных, доступных из любого места программы (глобальных переменных)
//© Владимир Андреев, PAR-P Corp.

namespace PAR_P_Studio
    
{
    static class StaticParams
    {
        public enum AccessType {Separate, One, Database};
        public static AccessType Access; //Текущий способ хранения
        //Массивы для способа хранения "One"
        public static List<User> Users;
        public static List<Deck> Decks;
        public static List<LayoutType> Layouts;
        //----//
        public static List<Event> Events; // Журнал событий
        static public User CurrentUser; //хранит информацию о текущем пользователе
        public static bool GuestLogin() //Возвращает True, если пользователь вошел как гость
        {
            return CurrentUser.Guestmode;
        }

        static public Deck CurrentDeck; //Хранит информацию о текущей колоде
        static public LayoutType CurrentLayoutType; //Хранит информацию о текущем типе расклада
        static public List<Deck.card> LayoutResult;
        static public Shuffle CurrentShuffle;
        static public string Question = "";
        static public int UserSeed = 0;
        static public string ProgramDir = "";
        static public string Comment;
        public static string[] CommandLineParams = Environment.GetCommandLineArgs();
        static public DateTime ProgramEnter;


        //метод определяет объект, находящийся в указанных координатах
        //используется для определения, на что нажал пользователь мышью
        public static LayoutType.CardPos GetItemAt(int x, int y)
        {
            for (int i = StaticParams.CurrentLayoutType.CardPositions.Count - 1; i >= 0; i--)
            {
                LayoutType.CardPos currPos = (LayoutType.CardPos)StaticParams.CurrentLayoutType.CardPositions[i];
                if (
                        currPos.X < x &&
                        currPos.X + currPos.Width > x &&
                        currPos.Y < y &&
                        currPos.Y + currPos.Height > y
                    )
                    return currPos;

            }
            return null;
        }
        //метод возвращает папку с программой.
        //от этого отталкиваются операции работы с файлами.
        public static string GetProgramDir()
        {
            if (ProgramDir == "")
            {
                ProgramDir = Environment.GetCommandLineArgs()[0];
                while (true)
                {
                    ProgramDir = ProgramDir.Remove(ProgramDir.Length - 1, 1);
                    if (ProgramDir[ProgramDir.Length - 1] == '\\')
                        break;
                }
                return ProgramDir;
            }
            else
                return ProgramDir;
        }
   
    }

}
