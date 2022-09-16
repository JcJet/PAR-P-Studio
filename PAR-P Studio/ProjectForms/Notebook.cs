using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PAR_P_Studio.ProjectForms;
using PAR_P_Studio.ProjectClasses;

//Встроенный текстовый редактор. Используется для ввода данных, когда требуется большое окно.
//© Владимир Андреев, PAR-P Corp.

namespace PAR_P_Studio
{
    public partial class Notebook : Form
    {

        public Notebook()
        {
            InitializeComponent();
            if (StaticParams.GuestLogin())
            {
                toolStripLoginLabel.Text = "Гостевой режим";
                toolStripLoginLabel.ForeColor = Color.Tomato;
            }
            else
            {
                toolStripLoginLabel.Text = StaticParams.CurrentUser.Login;
                toolStripLoginLabel.ForeColor = Color.Blue;
            }


        }
        void SetColors()
        {
            this.BackColor = StaticParams.CurrentUser.UserSettings.WinColor;
            this.ForeColor = StaticParams.CurrentUser.UserSettings.LabelColor;
        }



        #region RTF редактор
                private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DescrBoldButton.PerformClick();
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DescrItalicButton.PerformClick();
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DescrUnderlineButton.PerformClick();
        }

        private void strikeoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DescrStrikeoutButton.PerformClick();
        }


        private void Paste_Click(object sender, EventArgs e)
        {
            TextRtf.Paste();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            TextRtf.Copy();
        }

        private void SelectAll_Click(object sender, EventArgs e)
        {
            TextRtf.SelectAll();
        }
        private void DescrBoldButton_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;

            oldFont = this.TextRtf.SelectionFont;
            if (oldFont.Bold == true)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);
            else newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);

            this.TextRtf.SelectionFont = newFont;
            this.TextRtf.Focus();
        }

        private void DescrItalicButton_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;

            oldFont = this.TextRtf.SelectionFont;
            if (oldFont.Italic == true)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic);
            else newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);

            this.TextRtf.SelectionFont = newFont;
            this.TextRtf.Focus();

        }

        private void DescrUnderlineButton_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;

            oldFont = this.TextRtf.SelectionFont;
            if (oldFont.Underline == true)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
            else newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);

            this.TextRtf.SelectionFont = newFont;
            this.TextRtf.Focus();

        }

        private void DescrStrikeoutButton_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;

            oldFont = this.TextRtf.SelectionFont;
            if (oldFont.Strikeout == true)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Strikeout);
            else newFont = new Font(oldFont, oldFont.Style | FontStyle.Strikeout);

            this.TextRtf.SelectionFont = newFont;
            this.TextRtf.Focus();

        }
        private void ApplyTextSize(string text)
        {
            float newSize = Convert.ToSingle(text);
            FontFamily currentFontFamily;
            Font newFont;

            currentFontFamily = this.TextRtf.SelectionFont.FontFamily;
            newFont = new Font(currentFontFamily, newSize);

            this.TextRtf.SelectionFont = newFont;
        }

        private void TextSizeBox_ValueChanged(object sender, EventArgs e)
        {


                ApplyTextSize(TextSizeBox.Value.ToString());
                this.TextRtf.Focus();
                TextRtf_SelectionChanged(null, null);


        }

        private void AlignCenterButton_Click(object sender, EventArgs e)
        {
            if (this.TextRtf.SelectionAlignment == HorizontalAlignment.Center)
                this.TextRtf.SelectionAlignment = HorizontalAlignment.Left;
            else this.TextRtf.SelectionAlignment = HorizontalAlignment.Center;
            this.TextRtf.Focus();

        }

        private void AlignLeftButton_Click(object sender, EventArgs e)
        {
            this.TextRtf.SelectionAlignment = HorizontalAlignment.Left;
            this.TextRtf.Focus();

        }

        private void AlignRightButton_Click(object sender, EventArgs e)
        {
            if (this.TextRtf.SelectionAlignment == HorizontalAlignment.Right)
                this.TextRtf.SelectionAlignment = HorizontalAlignment.Left;
            else this.TextRtf.SelectionAlignment = HorizontalAlignment.Right;
            this.TextRtf.Focus();

        }


        private void TextColorButton_Click(object sender, EventArgs e)
        {
            if (TextColorDialog.ShowDialog() == DialogResult.OK)
                TextRtf.SelectionColor = TextColorDialog.Color;
        }
        private void TextSizeBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ApplyTextSize(TextSizeBox.Text);
                TextRtf.Focus();
                TextRtf_SelectionChanged(null, null);
            }
        }

        private void TextRtf_SelectionChanged(object sender, EventArgs e)
        {
            if (TextRtf.SelectionFont != null)
                SizeLabel.Text = Convert.ToInt32(TextRtf.SelectionFont.Size).ToString();
        }

        private void FontButton_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
                TextRtf.SelectionFont = fontDialog.Font;


        }

        private void TextSizeBox_ValueChanged_1(object sender, EventArgs e)
        {
            ApplyTextSize(TextSizeBox.Value.ToString());
            this.TextRtf.Focus();
            TextRtf_SelectionChanged(null, null);
        }

        

        private void DefaultFontButton_Click(object sender, EventArgs e)
        {
            TextRtf.SelectionFont = new Font(DefaultFont, FontStyle.Regular);
        }
        #endregion

        #region Подсказки в строке состояния
        private void DescrBoldButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Жирный";
        }

        private void DescrItalicButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Курсив";
        }

        private void DescrUnderlineButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Подчеркнутый";
        }

        private void DescrStrikeoutButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Зачеркнутый";
        }

        private void AlignLeftButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "По левому краю";
        }

        private void AlignCenterButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "По центру";
        }

        private void AlignRightButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "По правому краю";
        }

        private void TextColorButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Цвет текста";
        }

        private void DefaultFontButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Сбросить настройки шрифта на начальные";
        }

        private void FontButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Выбрать шрифт";
        }

        private void SizeLabel_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Текущий размер шрифта";
        }

        private void toolStripLoginLabel_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Имя пользователя, под которым Вы вошли";
        }

        private void toolStripTip_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Здесь отображаются подсказки к элементу под курсором мыши";
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripTip.Text = "Закрыть окно";
        }

        private void сменаПользователяToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripTip.Text = "Вернуться в окно приветствия";
        }

        private void DescrBoldButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void DescrItalicButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void DescrUnderlineButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void DescrStrikeoutButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void AlignLeftButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void AlignCenterButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void AlignRightButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void TextColorButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void DefaultFontButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void FontButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void SizeLabel_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void TextSizeBox_Enter(object sender, EventArgs e)
        {
            toolStripTip.Text = "Задать размер шрифта";
        }

        private void TextSizeBox_Leave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void toolStripLoginLabel_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void toolStripTip_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }
        #endregion

        private void Notebook_Shown(object sender, EventArgs e)
        {
            SetColors();
        }






    }
}
