using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using PAR_P_Studio.ProjectClasses;

namespace PAR_P_Studio
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            StaticParams.Users = new List<User>();
            StaticParams.Decks = new List<Deck>();
            StaticParams.Layouts = new List<LayoutType>();
            StaticParams.LayoutResult = new List<Deck.card>();
            StaticParams.CurrentUser = new User(true, "Гость");
            StaticParams.Access = StaticParams.AccessType.Separate;
            StaticParams.Events = new List<Event>();
            Files.EventLogLoad();
            //StaticParams.CurrentUser.UserSettings = new User.Settings();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
