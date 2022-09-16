using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.Win32;
using System.Data.OleDb;
using PAR_P_Studio.ProjectForms;
using PAR_P_Studio.ProjectClasses;
using PAR_P_Studio.Dialogs;

//Экран входа в программу. Позволяет выбрать или создать нового пользователя, и выполнить некоторые глобальные операци с данными
//© Владимир Андреев, PAR-P Corp.

namespace PAR_P_Studio
{
    public partial class LoginScreen : Form
    {
        Image Signature=null, Avatar=null;
        User tmpUser = new User();
        public LoginScreen()
        {
            InitializeComponent();
            LoginTabs.SelectedTab = Login;
        }
        void SetAccess()
        {
            if (radioSeparateFiles.Checked)
                StaticParams.Access = StaticParams.AccessType.Separate;
            if (radioOneFile.Checked)
                StaticParams.Access = StaticParams.AccessType.One;
            if (radioDataBase.Checked)
                StaticParams.Access = StaticParams.AccessType.Database;
            try
            {
                //запись последнего выбраного варианта в реестр, не критично.
                RegistryKey registryKeyOptions = Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("PAR-P");
                registryKeyOptions.SetValue("Access", StaticParams.Access, RegistryValueKind.String);
                registryKeyOptions.Close();
            }
            catch { }
        }
        void SetTips(bool show)
        {
            ConvertHelp.Visible = show;
            ExportHelp.Visible = show;
            StorageHelp.Visible = show;
            ImportHelp.Visible = show;
        }
        void RefreshUsers()
        {
            LoginSelect.Items.Clear();
            if (StaticParams.Access == StaticParams.AccessType.One)
            {
                foreach (User item in StaticParams.Users)
                    LoginSelect.Items.Add(item.Login);
            }
            if (StaticParams.Access == StaticParams.AccessType.Separate)
            {
                User tempUser = new User();
                string ProgramPath = StaticParams.GetProgramDir();
                string[] files = Directory.GetFiles(ProgramPath +"Data\\Users");
                foreach (string item in files)
                {
                    try
                    {

                        FileStream UserFile = new FileStream(item,
                            FileMode.Open, FileAccess.Read);
                        BinaryFormatter UserFormatter = new BinaryFormatter();
                        tempUser = new User((User)UserFormatter.Deserialize(UserFile));
                        LoginSelect.Items.Add(tempUser.Login);
                        UserFile.Close();
                    }
                    catch { }
                }
            }
        }
        void ClearInfoBox()
        {
            dispName.Text = "";
            dispLastName.Text = "";
            dispMidName.Text = "";
            dispBirthDay.Text = "";
            dispZodiac.Text = "";
            UserAvatar.Image = null;
        }

        private void NewUserButton_Click(object sender, EventArgs e)
        {
            LoginTabs.SelectedTab = NewUser;
        }

        private void GuestLogin_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void ToLoginButton_Click(object sender, EventArgs e)
        {
            LoginTabs.SelectedTab = Login;
            textLogin.Text = "";
            textPassword.Text = "";
            textFirstname.Text = "";
            textLastname.Text = "";
            textMidname.Text = "";
            BirthDayPicker.Value = DateTime.Now;
        }

        private void NewUserCreateButton_Click(object sender, EventArgs e)
        {

            //Приводим строки в надлежащий вид
            textLogin.Text = Drawing.CleanString(textLogin.Text);
            textFirstname.Text = Drawing.CleanString(textFirstname.Text);
            textFirstname.Text = Drawing.FirstCapital(textFirstname.Text);
            textLastname.Text = Drawing.CleanString(textLastname.Text);
            textLastname.Text = Drawing.FirstCapital(textLastname.Text);
            textMidname.Text = Drawing.CleanString(textMidname.Text);
            textMidname.Text = Drawing.FirstCapital(textMidname.Text);
            if
                (
                    textLogin.Text != "" && textFirstname.Text != "" && textLastname.Text != ""
                    && BirthDayPicker.Value != null && (MaleRadio.Checked || FemaleRadio.Checked)
                )
            {
                if (textPassword.Text == textPasswordRepeat.Text)
                {
                    bool AlreadyExists = false;
                    if (StaticParams.Access == StaticParams.AccessType.One)
                    {
                        foreach (User currUser in StaticParams.Users)
                        {
                            if (currUser.Login.ToUpper() == textLogin.Text.ToUpper())
                            {
                                AlreadyExists = true;
                                break;
                            }
                        }
                    }
                    else if (StaticParams.Access == StaticParams.AccessType.Separate)
                    {
                        if (File.Exists(StaticParams.GetProgramDir() + "Data\\Users\\" + textLogin.Text + ".usr"))
                            AlreadyExists = true;
                    }
                    if (!AlreadyExists)
                    {
                        StaticParams.CurrentUser = new User
                            (
                            false,
                            textLogin.Text,
                            textPassword.Text,
                            textFirstname.Text,
                            textLastname.Text,
                            textMidname.Text,
                            BirthDayPicker.Value,
                            MaleRadio.Checked,
                            Signature,
                            Avatar
                            );
                        StaticParams.Events.Add(new Event("Создание нового пользователя", textLogin.Text));
                        StaticParams.CurrentUser.UserStatistics.LogonTime = TimeSpan.Zero;
                        if (StaticParams.Access == StaticParams.AccessType.One)
                            StaticParams.Users.Add(new User(StaticParams.CurrentUser));
                        else if (StaticParams.Access == StaticParams.AccessType.Separate)
                            StaticParams.CurrentUser.SaveUser();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Пользователь с таким логином уже существует!");
                        NewLoginLabel.ForeColor = Color.Red;
                    }
                }
                else MessageBox.Show("Введенные пароли не совпадают.");
            }
            else
            {
                MessageBox.Show("Данные заполнены не полностью");
            }
            if (textLogin.Text == "")
                NewLoginLabel.ForeColor = Color.Red;
            else 
                NewLoginLabel.ForeColor = Color.Black;

            if (textFirstname.Text == "")
                NewNameLabel.ForeColor = Color.Red;
            else 
                NewNameLabel.ForeColor = Color.Black;

            if (textLastname.Text == "")
                NewLastnameLabel.ForeColor = Color.Red;
            else 
                NewLastnameLabel.ForeColor = Color.Black;

            if (BirthDayPicker.Value == null)
                NewBirthdayLabel.ForeColor = Color.Red;
            else NewBirthdayLabel.ForeColor = Color.Black;

            if (!MaleRadio.Checked && !FemaleRadio.Checked)
                NewGenderLabel.ForeColor = Color.Red;
            else NewGenderLabel.ForeColor = Color.Black;
        }

        private void SignatureInputButton_Click(object sender, EventArgs e)
        {
            Files.OpenImage(ref Signature);        
        }

        private void AvatarInputButton_Click(object sender, EventArgs e)
        {
            Files.OpenImage(ref Avatar);
        }

        private void LoginScreen_Shown(object sender, EventArgs e)
        {
            RefreshUsers();
            ClearInfoBox();

            try
            {
                RegistryKey registryKeyOptions = Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("PAR-P");
                string access = (string)registryKeyOptions.GetValue("Access", "Separate");
                string LastUser = (string)registryKeyOptions.GetValue("LastUser", "");
                if (LastUser != "")
                {
                    for (int i = 0; i < LoginSelect.Items.Count; i++)
                    {
                        if (LoginSelect.Items[i].ToString() == LastUser)
                        {
                            LoginSelect.SelectedIndex = i;
                            break;
                        }
                    }
                }
                string SavePassword = (string)registryKeyOptions.GetValue("SavePassword", "False");
                if (SavePassword == "True")
                {
                    SavePasswordBox.Checked = true;
                    string password = (string)registryKeyOptions.GetValue("Password", "");
                    PasswordField.Text = password;
                }
                else
                {
                    SavePasswordBox.Checked = false;
                    registryKeyOptions.SetValue("Password", "", RegistryValueKind.String);
                }
                registryKeyOptions.Close();
           

            switch (access)
            {
                case "One":
                    {
                        StaticParams.Access = StaticParams.AccessType.One;
                        radioOneFile.Checked=true;
                        break;
                    }
                case "Separate":
                    {
                        StaticParams.Access = StaticParams.AccessType.Separate;
                        radioSeparateFiles.Checked = true;
                        break;
                    }
                case "Database":
                        {
                            StaticParams.Access = StaticParams.AccessType.Database;
                            radioDataBase.Checked = true;
                            break;
                        }
            }

            }
            catch { }

            StaticParams.CurrentUser = new User(true, "Гость");
        }

        private void LoginSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StaticParams.Access == StaticParams.AccessType.One)
            {
                dispName.Text = ((User)StaticParams.Users[LoginSelect.SelectedIndex]).FirstName;
                dispLastName.Text = ((User)StaticParams.Users[LoginSelect.SelectedIndex]).LastName;
                dispMidName.Text = ((User)StaticParams.Users[LoginSelect.SelectedIndex]).MidName;
                dispBirthDay.Text = ((User)StaticParams.Users[LoginSelect.SelectedIndex]).BirthDay.ToString();
                dispZodiac.Text = ((User)StaticParams.Users[LoginSelect.SelectedIndex]).GetUserZodiac();
                if (((User)StaticParams.Users[LoginSelect.SelectedIndex]).GenderMale)
                    dispGender.Text = "М";
                else dispGender.Text = "Ж";
                UserAvatar.Image = ((User)StaticParams.Users[LoginSelect.SelectedIndex]).Avatar;
                dispLastVisit.Text = ((User)StaticParams.Users[LoginSelect.SelectedIndex]).UserStatistics.LastVisit.ToString();

                //Если у выбраного пользователя включены подсказки, включаем их для этого окна.
                SetTips(!((User)StaticParams.Users[LoginSelect.SelectedIndex]).UserSettings.HideTips);

                //Применяем цветовую схему выбранного пользователя
                this.BackColor = ((User)StaticParams.Users[LoginSelect.SelectedIndex]).UserSettings.WinColor;
                this.ForeColor = ((User)StaticParams.Users[LoginSelect.SelectedIndex]).UserSettings.LabelColor;
                Login.BackColor = ((User)StaticParams.Users[LoginSelect.SelectedIndex]).UserSettings.BGColor;
                NewUser.BackColor = ((User)StaticParams.Users[LoginSelect.SelectedIndex]).UserSettings.BGColor;
                DataTab.BackColor = ((User)StaticParams.Users[LoginSelect.SelectedIndex]).UserSettings.BGColor;
                Output.BackColor = ((User)StaticParams.Users[LoginSelect.SelectedIndex]).UserSettings.BGColor;
            }
            else if (StaticParams.Access == StaticParams.AccessType.Separate)
            {

                    FileStream UserFile = new FileStream(StaticParams.GetProgramDir() + "Data\\Users\\" + LoginSelect.Text + ".usr",
                        FileMode.Open, FileAccess.Read);
                    BinaryFormatter UserFormatter = new BinaryFormatter();
                    tmpUser = new User((User)UserFormatter.Deserialize(UserFile));
                    UserFile.Close();

                    dispName.Text = tmpUser.FirstName;
                    dispLastName.Text = tmpUser.LastName;
                    dispMidName.Text = tmpUser.MidName;
                    dispBirthDay.Text = tmpUser.BirthDay.ToString();
                    dispZodiac.Text = tmpUser.GetUserZodiac();
                    if (tmpUser.GenderMale)
                        dispGender.Text = "М";
                    else
                        dispGender.Text = "Ж";
                    UserAvatar.Image = tmpUser.Avatar;
                    dispLastVisit.Text = tmpUser.UserStatistics.LastVisit.ToString();

                    //Если у выбраного пользователя включены подсказки, включаем их для этого окна.
                    SetTips(!tmpUser.UserSettings.HideTips);

                    //Применяем цветовую схему выбранного пользователя
                    this.BackColor = tmpUser.UserSettings.WinColor;
                    this.ForeColor = tmpUser.UserSettings.LabelColor;
                    Login.BackColor = tmpUser.UserSettings.BGColor;
                    NewUser.BackColor = tmpUser.UserSettings.BGColor;
                    DataTab.BackColor = tmpUser.UserSettings.BGColor;
                    Output.BackColor = tmpUser.UserSettings.BGColor;
                
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (LoginSelect.SelectedIndex != -1)
            {
                if (StaticParams.Access == StaticParams.AccessType.One)
                {
                    if
                        (
                        ((User)StaticParams.Users[LoginSelect.SelectedIndex]).Password == PasswordField.Text ||
                        ((User)StaticParams.Users[LoginSelect.SelectedIndex]).Password == ""
                        )
                    {
                        StaticParams.CurrentUser = new User((User)StaticParams.Users[LoginSelect.SelectedIndex]);
                        StaticParams.ProgramEnter = new DateTime();
                        StaticParams.ProgramEnter = DateTime.Now;
                        StaticParams.CurrentUser.UserStatistics.LogonCount++;
                        StaticParams.Events.Add(new Event("Вход в программу","Программа"));
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль!");
                        StaticParams.Events.Add(new Event("Попытка входа (неверный пароль)",((User)StaticParams.Users[LoginSelect.SelectedIndex]).Login));
                        PasswordField.Text = "";
                    }
                }



                else if (StaticParams.Access == StaticParams.AccessType.Separate)
                {
                    if (tmpUser.Password == PasswordField.Text || tmpUser.Password == "")
                    {
                        StaticParams.CurrentUser = new User(tmpUser);
                        StaticParams.ProgramEnter = new DateTime();
                        StaticParams.ProgramEnter = DateTime.Now;
                        StaticParams.CurrentUser.UserStatistics.LogonCount++;
                        StaticParams.Events.Add(new Event("Вход в программу","Программа"));
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль!");
                        StaticParams.Events.Add(new Event("Попытка входа (неверный пароль)",tmpUser.Login));
                        PasswordField.Text = "";
                    }

 
                }
            }
            else
                MessageBox.Show("Логин не указан!");
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            if (LoginSelect.SelectedIndex != -1)
            {
                if (StaticParams.Access == StaticParams.AccessType.One)
                {
                    if
                         (
                         ((User)StaticParams.Users[LoginSelect.SelectedIndex]).Password == PasswordField.Text ||
                         ((User)StaticParams.Users[LoginSelect.SelectedIndex]).Password == ""
                         )
                    {
                        if (MessageBox.Show("Удалить выбранного пользователя?", "Удаление пользователя", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                        == DialogResult.Yes)
                        {
                            StaticParams.Events.Add(new Event("Удаление пользователя", ((User)StaticParams.Users[LoginSelect.SelectedIndex]).Login));
                            StaticParams.Users.RemoveAt(LoginSelect.SelectedIndex);
                            RefreshUsers();
                            ClearInfoBox();
                            PasswordField.Text = "";
                            LoginSelect.SelectedIndex = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль!");
                        StaticParams.Events.Add(new Event("Попытка удаления пользователя (неверный пароль)",
                            ((User)StaticParams.Users[LoginSelect.SelectedIndex]).Login));
                        PasswordField.Text = "";
                    }
                }


                else if (StaticParams.Access == StaticParams.AccessType.Separate)
                {
                    if (tmpUser.Password == PasswordField.Text || tmpUser.Password == "")
                    {
                        if (MessageBox.Show("Удалить выбранного пользователя?", "Удаление пользователя", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                        == DialogResult.Yes)
                        {
                            StaticParams.Events.Add(new Event("Удаление пользователя", tmpUser.Login));
                            File.Delete(StaticParams.GetProgramDir() + "Data\\Users\\" + LoginSelect.Text + ".usr");
                            RefreshUsers();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль!");
                        StaticParams.Events.Add(new Event("Попытка удаления пользователя (неверный пароль)", tmpUser.Login));
                        PasswordField.Text = "";
                    }

                }
            }
            else
                MessageBox.Show("Логин не указан!");

        }

        private void PasswordField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
                LoginButton_Click(null, null);
        }

        private void radioSeparateFiles_CheckedChanged(object sender, EventArgs e)
        {
            SetAccess();
            RefreshUsers();
            if (radioSeparateFiles.Checked)
            {
                Files.ClearMemory();
                groupDB.Visible = false;
            }

            
            
        }

        private void radioOneFile_CheckedChanged(object sender, EventArgs e)
        {
            SetAccess();
            if (radioOneFile.Checked)
            {
                Files.LoadBigFiles();
                groupDB.Visible = false;
            }
            RefreshUsers();
        }

        private void radioDataBase_CheckedChanged(object sender, EventArgs e)
        {
            SetAccess();
            RefreshUsers();
            if (radioDataBase.Checked)
                groupDB.Visible = true;
        }

        private void DBCheckConnectionButton_Click(object sender, EventArgs e)
        {
            //Работа с базой данных пока не была реализована. 
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = @"Provider=SQLOLEDB.1;Password=" + DBPasswordBox.Text +
                    @";Persist Security Info=True;User ID=" + DBLoginBox.Text + @";Initial Catalog=" +
                    DBNameBox.Text + @";Data Source=" + DBServerSelectBox.Text;
                try
                {
                    connection.Open();
                    MessageBox.Show("Соединение прошло удачно.");
                    connection.Close();
                    
                }
                catch
                {
                    MessageBox.Show("Ошибка соединения с базой данных!");
                    
                }

        }

        private void ManyToOneButton_Click(object sender, EventArgs e)
        {
            Files.LoadBigFiles();
            StaticParams.Events.Add(new Event("Объединение данных", ManyToOneButton.Text));

            {
                string[] files = Directory.GetFiles(StaticParams.GetProgramDir() + "Data\\Decks");
                foreach (string item in files)
                {
                    try
                    {

                        FileStream file = new FileStream(item,
                            FileMode.Open, FileAccess.Read);
                        BinaryFormatter formatter = new BinaryFormatter();
                        Deck TempDeck = new Deck((Deck)formatter.Deserialize(file));
                        bool AlreadyExists = false;
                        foreach (Deck dck in StaticParams.Decks)
                            if (dck.Name == TempDeck.Name)
                            {
                                AlreadyExists = true;
                                break;
                            }
                                
                        if (!AlreadyExists)
                            StaticParams.Decks.Add(TempDeck);
                        file.Close();
                    }
                    catch { }
                }
            }

            {
                string[] files = Directory.GetFiles(StaticParams.GetProgramDir() + "Data\\Users");
                foreach (string item in files)
                {
                    try
                    {

                        FileStream file = new FileStream(item,
                            FileMode.Open, FileAccess.Read);
                        BinaryFormatter formatter = new BinaryFormatter();
                        User TempUser = new User((User)formatter.Deserialize(file));
                        bool AlreadyExists = false;
                        foreach (User usr in StaticParams.Users)
                            if (usr.Login == TempUser.Login)
                            {
                                AlreadyExists = true;
                                break;
                            }
                        if (!AlreadyExists)
                            StaticParams.Users.Add(TempUser);
                        file.Close();
                    }
                    catch { }
                }
            }

            {
                string[] files = Directory.GetFiles(StaticParams.GetProgramDir() + "Data\\Layouts");
                foreach (string item in files)
                {
                    try
                    {

                        FileStream file = new FileStream(item,
                            FileMode.Open, FileAccess.Read);
                        BinaryFormatter formatter = new BinaryFormatter();
                        LayoutType TempLayout = new LayoutType((LayoutType)formatter.Deserialize(file));
                        bool AlreadyExists = false;
                        foreach(LayoutType lyt in StaticParams.Layouts)
                            if (lyt.Name == TempLayout.Name)
                            {
                                AlreadyExists = true;
                                break;
                            }
                        if (!AlreadyExists)
                            StaticParams.Layouts.Add(TempLayout);
                        file.Close();
                    }
                    catch { }
                }

            }


            try
            {
                Files.SaveBigFiles();
                MessageBox.Show("Готово.");
            }
            catch { }
            if (StaticParams.Access != StaticParams.AccessType.One)
                Files.ClearMemory();

        }

        private void OneToManyButton_Click(object sender, EventArgs e)
        {
            Files.LoadBigFiles();
            StaticParams.Events.Add(new Event("Объединение данных", OneToManyButton.Text));
            foreach (User item in StaticParams.Users)
                if (!File.Exists(StaticParams.GetProgramDir() + "Data\\Users\\" + item.Login+ ".usr"))
                    item.SaveUser();
            foreach (Deck item in StaticParams.Decks)
                if (!File.Exists(StaticParams.GetProgramDir() + "Data\\Decks\\" + item.Name + ".dck"))
                    item.SaveDeck();
            foreach (LayoutType item in StaticParams.Layouts)
                if (!File.Exists(StaticParams.GetProgramDir() + "Data\\Layouts\\" + item.Name + ".lyt"))
                    item.SaveLayout();
            if (StaticParams.Access != StaticParams.AccessType.One)
                Files.ClearMemory();
        }

        private void ExtractDecks_Click(object sender, EventArgs e)
        {
            ExportDialog exd = new ExportDialog();
            exd.StartPosition = FormStartPosition.CenterParent;
            exd.ShowDialog();
        }

        private void ConvertHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageForm MF = new MessageForm(((LinkLabel)sender).Name);
            MF.StartPosition = FormStartPosition.CenterParent;
            MF.ShowDialog();
        }

        private void ExportHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageForm MF = new MessageForm(((LinkLabel)sender).Name);
            MF.StartPosition = FormStartPosition.CenterParent;
            MF.ShowDialog();

        }

        private void StorageHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageForm MF = new MessageForm(((LinkLabel)sender).Name);
            MF.StartPosition = FormStartPosition.CenterParent;
            MF.ShowDialog();
        }

        private void SavePasswordBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                RegistryKey registryKeyOptions = Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("PAR-P");
                registryKeyOptions.SetValue("SavePassword", SavePasswordBox.Checked, RegistryValueKind.String);
                registryKeyOptions.Close();
            }
            catch { }
        }

        private void ImportHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageForm MF = new MessageForm(((LinkLabel)sender).Name);
            MF.StartPosition = FormStartPosition.CenterParent;
            MF.ShowDialog();
        }
        #region Кнопки импорта
        private void ImportDeckButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openDialog = new System.Windows.Forms.OpenFileDialog();
            openDialog.Filter = "Deck file|*.dck";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    FileStream DeckFile = new FileStream(openDialog.FileName, FileMode.Open, FileAccess.Read);
                    BinaryFormatter DeckFormatter = new BinaryFormatter();
                    Deck tmpDeck = new Deck((Deck)DeckFormatter.Deserialize(DeckFile));
                    DeckFile.Close();

                    if (StaticParams.Access == StaticParams.AccessType.One)
                    {
                        Files.LoadBigFiles();
                        StaticParams.Decks.Add(new Deck(tmpDeck));
                        Files.SaveBigFiles();
                        Files.ClearMemory();
                    }
                    if (StaticParams.Access == StaticParams.AccessType.Separate)
                    {
                        tmpDeck.SaveDeck();
                    }
                    StaticParams.Events.Add(new Event("Новая колода из файла", tmpDeck.Name));

                }
                catch (OutOfMemoryException)
                {
                    MessageBox.Show("Ошибка чтения файла");
                }
            }

        }

        private void ImportUserButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openDialog = new System.Windows.Forms.OpenFileDialog();
            openDialog.Filter = "User file|*.usr";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    FileStream UserFile = new FileStream(openDialog.FileName, FileMode.Open, FileAccess.Read);
                    BinaryFormatter UserFormatter = new BinaryFormatter();
                    User tmpUser = new User((User)UserFormatter.Deserialize(UserFile));
                    UserFile.Close();

                    if (StaticParams.Access == StaticParams.AccessType.One)
                    {
                        Files.LoadBigFiles();
                        StaticParams.Users.Add(new User(tmpUser));
                        Files.SaveBigFiles();
                        Files.ClearMemory();
                    }
                    if (StaticParams.Access == StaticParams.AccessType.Separate)
                    {
                        tmpUser.SaveUser();
                    }
                    StaticParams.Events.Add(new Event("Новый пользователь из файла", tmpUser.Login));

                }
                catch (OutOfMemoryException)
                {
                    MessageBox.Show("Ошибка чтения файла");
                }
            }
        }

        private void ImportLayoutButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openDialog = new System.Windows.Forms.OpenFileDialog();
            openDialog.Filter = "Layout file|*.lyt";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    FileStream LayoutFile = new FileStream(openDialog.FileName, FileMode.Open, FileAccess.Read);
                    BinaryFormatter LayoutFormatter = new BinaryFormatter();
                    LayoutType tmpLayout = new LayoutType((LayoutType)LayoutFormatter.Deserialize(LayoutFile));
                    LayoutFile.Close();

                    if (StaticParams.Access == StaticParams.AccessType.One)
                    {
                        Files.LoadBigFiles();
                        StaticParams.Layouts.Add(new LayoutType(tmpLayout));
                        Files.SaveBigFiles();
                        Files.ClearMemory();
                    }
                    if (StaticParams.Access == StaticParams.AccessType.Separate)
                    {
                        tmpLayout.SaveLayout();
                    }
                    StaticParams.Events.Add(new Event("Новый расклад из файла", tmpLayout.Name));
                }
                catch (OutOfMemoryException)
                {
                    MessageBox.Show("Ошибка чтения файла");
                }
            }
        }
        #endregion

        private void StorageHelp_MouseMove(object sender, MouseEventArgs e)
        {
            StorageHelp.Text = "Что это?";
        }

        private void StorageHelp_MouseLeave(object sender, EventArgs e)
        {
            StorageHelp.Text = "?";
        }

        private void ConvertHelp_MouseMove(object sender, MouseEventArgs e)
        {
            ConvertHelp.Text = "Что это?";
        }

        private void ConvertHelp_MouseLeave(object sender, EventArgs e)
        {
            ConvertHelp.Text = "?";
        }

        private void ExportHelp_MouseMove(object sender, MouseEventArgs e)
        {
            ExportHelp.Text = "Что это?";
        }

        private void ExportHelp_MouseLeave(object sender, EventArgs e)
        {
            ExportHelp.Text = "?";
        }

        private void ImportHelp_MouseMove(object sender, MouseEventArgs e)
        {
            ImportHelp.Text = "Что это?";
        }

        private void ImportHelp_MouseLeave(object sender, EventArgs e)
        {
            ImportHelp.Text = "?";
        }

        private void HelpContentsButton_Click(object sender, EventArgs e)
        {
            string ProgramPath = StaticParams.GetProgramDir();
            KnowlegeBase KB = new KnowlegeBase(ProgramPath + "Data\\Knowlege Base\\Программа\\Начало работы с программой.rtf");
            KB.Show();
        }

        private void UserAvatar_Click(object sender, EventArgs e)
        {
            if (UserAvatar.Image != null)
            {
                LargeImage LIM = new LargeImage(UserAvatar.Image);
                LIM.Show();
            }
        }



    }
}
