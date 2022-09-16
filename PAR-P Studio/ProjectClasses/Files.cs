using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;

//Работа с файлами
//© Владимир Андреев, PAR-P Corp.

namespace PAR_P_Studio.ProjectClasses
{
    public class Files
    {
        public static void LoadBigFiles()//Работа с большими файлами. В случае выбора режима хранения одним файлом
        {
            try
            {
                //BinaryFormatter formatter = new BinaryFormatter();
                if (StaticParams.Access == StaticParams.AccessType.One)
                {
                    FileStream UsersFile = new FileStream("Data\\Users.dat", FileMode.Open, FileAccess.Read);
                    FileStream DecksFile = new FileStream("Data\\Decks.dat", FileMode.Open, FileAccess.Read);
                    FileStream LayoutsFile = new FileStream("Data\\Layouts.dat", FileMode.Open, FileAccess.Read);

                    BinaryFormatter UserFormatter = new BinaryFormatter();
                    BinaryFormatter DeckFormatter = new BinaryFormatter();
                    BinaryFormatter LayoutFormatter = new BinaryFormatter();

                    StaticParams.Users = (List<User>)UserFormatter.Deserialize(UsersFile);
                    StaticParams.Decks = (List<Deck>)DeckFormatter.Deserialize(DecksFile);
                    StaticParams.Layouts = (List<LayoutType>)LayoutFormatter.Deserialize(LayoutsFile);

                    UsersFile.Close();
                    DecksFile.Close();
                    LayoutsFile.Close();
                }


            }
            catch 
            {
                //если файлов не существует, они будут созданы программой позже.
            }
            StaticParams.Users.Sort();
            StaticParams.Decks.Sort();
            StaticParams.Layouts.Sort();


        }
        public static void SaveBigFiles()//Работа с большими файлами. В случае выбора режима хранения одним файлом
        {
            try
            {
                FileStream UsersFile = new FileStream("Data//Users.dat", FileMode.Create, FileAccess.Write);
                FileStream DecksFile = new FileStream("Data//Decks.dat", FileMode.Create, FileAccess.Write);
                FileStream LayoutsFile = new FileStream("Data//Layouts.dat", FileMode.Create, FileAccess.Write);

                BinaryFormatter UserFormatter = new BinaryFormatter();
                BinaryFormatter DeckFormatter = new BinaryFormatter();
                BinaryFormatter LayoutFormatter = new BinaryFormatter();

                UserFormatter.Serialize(UsersFile, StaticParams.Users);
                DeckFormatter.Serialize(DecksFile, StaticParams.Decks);
                LayoutFormatter.Serialize(LayoutsFile, StaticParams.Layouts);

                UsersFile.Close();
                DecksFile.Close();
                LayoutsFile.Close();

            }
            catch
            {
                MessageBox.Show("Ошибка сохранения одиночных файлов с данными!", "Ошибка");
            }
        }
        public static void ClearMemory()//Работа с большими файлами. В случае выбора режима хранения одним файлом
        {
            StaticParams.Users.Clear();
            StaticParams.Decks.Clear();
            StaticParams.Layouts.Clear();
            GC.Collect(2);
            GC.WaitForPendingFinalizers();
        }
        public static void EventLogLoad()
        {
            try
            {
                FileStream EventsFile = new FileStream("Data\\Events.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter EventsFormatter = new BinaryFormatter();
                StaticParams.Events = (List<Event>)EventsFormatter.Deserialize(EventsFile);
                EventsFile.Close();
            }
            catch { };
        }
        public static void EventLogSave()
        {
            try
            {
                FileStream EventsFile = new FileStream("Data\\Events.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter EventsFormatter = new BinaryFormatter();
                EventsFormatter.Serialize(EventsFile, StaticParams.Events);
                EventsFile.Close();
            }
            catch 
            {
                MessageBox.Show("Ошибка сохранения журнала событий!", "Ошибка");
            }
        }
        #region OpenImage
        //диалог открытия картинки
        public static bool OpenImage(ref Image image)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files|*.bmp;*.png;*.jpg";
            if (openDialog.ShowDialog() != DialogResult.OK)
                return false;

            try
            {
                image = Image.FromFile(openDialog.FileName);
                return true;
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("Ошибка чтения картинки");
                return true;
            }

        }
        #endregion
    }
}
