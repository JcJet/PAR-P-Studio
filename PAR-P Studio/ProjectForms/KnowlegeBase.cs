using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PAR_P_Studio.ProjectForms
{
    public partial class KnowlegeBase : Form
    {
        string Article = "";
        public KnowlegeBase(string article = "")
        {
            InitializeComponent();
            Article = article;
        }
        void SetColors()
        {
            this.BackColor = StaticParams.CurrentUser.UserSettings.WinColor;
            this.ForeColor = StaticParams.CurrentUser.UserSettings.LabelColor;
        }
        void RefreshInfo()
        {
            ArticleList.SuspendLayout();
            ArticleList.Items.Clear();
            try
            {
                string ProgramPath = StaticParams.GetProgramDir();
                string[] directories = Directory.GetDirectories(ProgramPath + "Data\\Knowlege Base\\");
                foreach (string dir in directories)
                {
                    char[] DirChars = dir.ToCharArray();
                    string DirName = "";
                    foreach (char currChar in DirChars)
                    {
                        DirName += currChar;
                        if (currChar == '\\')
                            DirName = "";
                    }
                    ArticleList.Groups.Add(dir, DirName);
                    string[] files = Directory.GetFiles(dir);
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
                        if (filename.IndexOf(".rtf") == filename.Length - 4)
                        {
                            filename = filename.Remove(filename.Length - 4);
                            ListViewItem newItem = new ListViewItem(filename, ArticleList.Groups[ArticleList.Groups.Count - 1]);
                            newItem.SubItems.Add(file);
                            ArticleList.Items.Add(newItem);
                        }

                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка открытия документации!", "Ошибка");
            }
            ArticleList.ResumeLayout();
        }
        private void KnowlegeBase_Shown(object sender, EventArgs e)
        {
            SetColors();
            RefreshInfo();
            if (Article != "")
                DispRtf.LoadFile(Article);
        }

        private void ArticleList_SizeChanged(object sender, EventArgs e)
        {
            ArticleList.Columns[0].Width = ArticleList.Width - 1;
        }

        private void ArticleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ArticleList.SelectedItems.Count == 1)
            DispRtf.LoadFile(ArticleList.SelectedItems[0].SubItems[1].Text); 
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DispRtf.Copy();
        }


        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DispRtf.SelectAll();
        }

    }
}
