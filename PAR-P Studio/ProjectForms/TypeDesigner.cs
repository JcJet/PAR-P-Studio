using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using PAR_P_Studio.ProjectForms;
using PAR_P_Studio.ProjectClasses;

//Редактор типов расклада
//© Владимир Андреев, PAR-P Corp.

namespace PAR_P_Studio
{
    public partial class TypeDesigner : Form
    {
            LayoutType.CardPos CurrentCardPos = null;
            Boolean dragging;
            Boolean draggingAll;
            Point startDragPoint;
            LayoutType.CardPos SelectedItem;
            Boolean saved = true;
            public Boolean newLayout = true;

        public TypeDesigner()
        {
            InitializeComponent();
            DesignerTabs.SelectedTab = DesignerTab;
        }

        void SetColors()
        {
            this.BackColor = StaticParams.CurrentUser.UserSettings.WinColor;
            this.ForeColor = StaticParams.CurrentUser.UserSettings.LabelColor;
            DesignerTab.BackColor = StaticParams.CurrentUser.UserSettings.BGColor;
            MiscTab.BackColor = StaticParams.CurrentUser.UserSettings.BGColor;
        }

        void PosRefresh()
        {
            PositionSelectBox.Items.Clear();
            foreach (LayoutType.CardPos item in StaticParams.CurrentLayoutType.CardPositions)
                PositionSelectBox.Items.Add(item.Number);
        }


        void DrawDraggingShape()
        {
            Point point = DrawingPanel.PointToScreen(CurrentCardPos.Location);
            point.X -= startDragPoint.X;
            ControlPaint.DrawReversibleFrame(new Rectangle(point, CurrentCardPos.Size), SystemColors.ButtonFace, FrameStyle.Dashed);
        }
        void DrawDraggingShape(int X, int Y)
        {
            Point point = new Point(X, Y);
            point = DrawingPanel.PointToScreen(point);
            ControlPaint.DrawReversibleFrame(new Rectangle(point, CurrentCardPos.Size), SystemColors.ButtonFace, FrameStyle.Dashed);
        }

        private void TypeDesigner_Shown(object sender, EventArgs e)
        {
            SetColors();
            if (newLayout)
            {
                StaticParams.CurrentLayoutType = new LayoutType("LayoutName", "LayoutDescription");
            }
            else
            {
                textName.Text = StaticParams.CurrentLayoutType.Name;
                textDescription.Rtf = StaticParams.CurrentLayoutType.Description;
                NullOwnerBox.Enabled = (StaticParams.CurrentUser.Login == StaticParams.CurrentLayoutType.Owner);
                NullOwnerBox.Checked = StaticParams.CurrentLayoutType.FreeAccess;

            }
        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Создать новый расклад? Текущий расклад будет очищен.", "Новый расклад", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
               == DialogResult.Yes)
            {
                StaticParams.CurrentLayoutType = new LayoutType("LayoutName", "LayoutDescription");
                PositionSelectBox.Items.Clear();
                PositionSelectBox.Text = "";
                PosDescription.Text = "";
                PosDescription.Enabled = false;
                textDescription.Rtf = null;
                textName.Text = "";
                DrawingPanel.Invalidate();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Выйти без сохранения?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.Yes)
                    Close();
        }

        private void новаяПозицияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutType.CardPos pos = new LayoutType.CardPos(10, 10, StaticParams.CurrentLayoutType.CardPositions.Count + 1, "Нет описания.");
            StaticParams.CurrentLayoutType.CardPositions.Add(pos);
            DrawingPanel.Invalidate();
            PosRefresh();
            saved = false;
        }

        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LayoutType.CardPos pos = StaticParams.GetItemAt(e.X, e.Y);
            SelectedItem = pos;
            if (pos != null && !DragAllBox.Checked)
            {
                CurrentCardPos = pos;
                dragging = true;
                startDragPoint = e.Location;
                DrawDraggingShape();
                saved = false;
            }
            else if (DragAllBox.Checked)
            {
                draggingAll = true;
                startDragPoint = e.Location;
                CurrentCardPos = new LayoutType.CardPos(10, 10, 0, "TempPos");
                foreach (LayoutType.CardPos item in StaticParams.CurrentLayoutType.CardPositions)
                        DrawDraggingShape(item.X,item.Y);
                saved = false;
            }

        }

        private void DrawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                dragging = false;
                DrawDraggingShape();
                if (SnapToGridBox.Checked)
                {
                    if (CurrentCardPos.X % 10 <= 4)
                        CurrentCardPos.X -= CurrentCardPos.X % 10;
                    else
                    {
                        CurrentCardPos.X -= CurrentCardPos.X % 10;
                        CurrentCardPos.X += 10;
                    }

                    if (CurrentCardPos.Y % 10 <= 4)
                        CurrentCardPos.Y -= CurrentCardPos.Y % 10;
                    else
                    {
                        CurrentCardPos.Y -= CurrentCardPos.Y % 10;
                        CurrentCardPos.Y += 10;
                    }

                }
                DrawingPanel.Invalidate();
            }

            if (draggingAll)
            {
                draggingAll = false;

                foreach (LayoutType.CardPos item in StaticParams.CurrentLayoutType.CardPositions)
                {
                    DrawDraggingShape(item.X, item.Y);

                    if (SnapToGridBox.Checked)
                    {
                        if (item.X % 10 <= 4)
                            item.X -= item.X % 10;
                        else
                        {
                            item.X -= item.X % 10;
                            item.X += 10;
                        }

                        if (item.Y % 10 <= 4)
                            item.Y -= item.Y % 10;
                        else
                        {
                            item.Y -= item.Y % 10;
                            item.Y += 10;
                        }

                    }



                }
                DrawingPanel.Invalidate();
            }

        }

        private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                DrawDraggingShape();
                CurrentCardPos.X = CurrentCardPos.Location.X + (e.Location.X - startDragPoint.X);
                CurrentCardPos.Y = CurrentCardPos.Location.Y + (e.Location.Y - startDragPoint.Y);
                DrawDraggingShape();
                startDragPoint = e.Location;
            }

            if (draggingAll)
            {
                foreach (LayoutType.CardPos item in StaticParams.CurrentLayoutType.CardPositions)
                {
                    DrawDraggingShape(item.X, item.Y);
                    item.X = item.X + (e.Location.X - startDragPoint.X);
                    item.Y = item.Y + (e.Location.Y - startDragPoint.Y);
                    DrawDraggingShape(item.X, item.Y);
                    
                }
                startDragPoint = e.Location;
            }

        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            foreach (LayoutType.CardPos currPos in StaticParams.CurrentLayoutType.CardPositions)
                currPos.Draw(e.Graphics);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (StaticParams.CurrentLayoutType.CardPositions.Count != 0 && textDescription.Text != "")
            {
                bool AlreadyExists = false;
                if (StaticParams.Access == StaticParams.AccessType.One)
                {
                    foreach (LayoutType item in StaticParams.Layouts)
                    {
                        if (item.Name.ToUpper() == textName.Text.ToUpper())
                        {
                            AlreadyExists = true;
                            break;
                        }
                    }
                }
                else if (StaticParams.Access == StaticParams.AccessType.Separate)
                {
                    if (File.Exists(StaticParams.GetProgramDir() + "Data\\Layouts\\" + textName.Text + ".lyt"))
                        AlreadyExists = true;
                }
                if (!AlreadyExists)
                {
                    StaticParams.Events.Add(new Event("Создание расклада", StaticParams.CurrentLayoutType.Name));
                    if (StaticParams.Access == StaticParams.AccessType.One)
                        StaticParams.Layouts.Add(new LayoutType(StaticParams.CurrentLayoutType));
                    else if (StaticParams.Access == StaticParams.AccessType.Separate)
                        StaticParams.CurrentLayoutType.SaveLayout();
                    saved = true;

                }
                else
                {
                    if (StaticParams.CurrentLayoutType.Owner != StaticParams.CurrentUser.Login && StaticParams.CurrentLayoutType.FreeAccess != true)
                    {
                        MessageBox.Show("Тип расклада с таким именем уже существует у другого пользователя. (" 
                                            + StaticParams.CurrentLayoutType.Owner+")");
                        DesignerTabs.SelectedTab = MiscTab;
                        textDescription.Focus();

                    }
                    else
                    {
                        if
                            (
                            MessageBox.Show("Тип расклада с таким именем уже существует. Заменить?", "Замена",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
                            )
                        {
                            StaticParams.Events.Add(new Event("Изменение расклада", StaticParams.CurrentLayoutType.Name));
                            if (StaticParams.Access == StaticParams.AccessType.One)
                            {
                                foreach (LayoutType item in StaticParams.Layouts)
                                {
                                    if (item.Name.ToUpper() == textName.Text.ToUpper())
                                    {
                                        StaticParams.Layouts.Remove(item);
                                        break;
                                    }
                                }

                                StaticParams.Layouts.Add(new LayoutType(StaticParams.CurrentLayoutType));
                                saved = true;
                            }
                            else if (StaticParams.Access == StaticParams.AccessType.Separate)
                            {
                                StaticParams.CurrentLayoutType.SaveLayout();
                                saved = true;
                            }
                        }
                    }
                }
            }
            else
            {
                if (StaticParams.CurrentLayoutType.CardPositions.Count == 0)
                {
                    MessageBox.Show("В раскладе должна быть хотя бы одна позиция.");
                    DesignerTabs.SelectedTab = DesignerTab;
                }
                if (textDescription.Text == "")
                {
                    MessageBox.Show("У расклада должно быть описание.");
                    DesignerTabs.SelectedTab = MiscTab;
                    textDescription.Focus();
                }
            }
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {
            StaticParams.CurrentLayoutType.Name = textName.Text;
            saved = false;
        }

        private void textDescription_TextChanged(object sender, EventArgs e)
        {
            StaticParams.CurrentLayoutType.Description = textDescription.Rtf;
            saved = false;
        }

        private void PositionSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PositionSelectBox.SelectedIndex != -1)
                PosDescription.Text = ((LayoutType.CardPos)StaticParams.CurrentLayoutType.CardPositions[PositionSelectBox.SelectedIndex]).Description;
        }

        private void PosDescription_TextChanged(object sender, EventArgs e)
        {
            if (PositionSelectBox.SelectedIndex != -1)
            {
                PosDescription.Enabled = true;
                ((LayoutType.CardPos)StaticParams.CurrentLayoutType.CardPositions[PositionSelectBox.SelectedIndex]).Description = PosDescription.Text;
            }
            saved = false;
        }

        private void RotationPlus_Click(object sender, EventArgs e)
        {
            if (SelectedItem != null)
            {
                SelectedItem.Angle += 45;
                DrawingPanel.Invalidate();
                saved = false;
            }

        }

        private void RotationMinus_Click(object sender, EventArgs e)
        {
            if (SelectedItem != null)
            {
                SelectedItem.Angle += 45;
                DrawingPanel.Invalidate();
                saved = false;
            }
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


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textDescription.Copy();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textDescription.Paste();
        }

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textDescription.SelectAll();
        }
        private void DescrStrikeoutButton_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;

            oldFont = this.textDescription.SelectionFont;
            if (oldFont.Strikeout == true)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Strikeout);
            else newFont = new Font(oldFont, oldFont.Style | FontStyle.Strikeout);

            this.textDescription.SelectionFont = newFont;
            this.textDescription.Focus();

        }

        private void DescrUnderlineButton_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;

            oldFont = this.textDescription.SelectionFont;
            if (oldFont.Underline == true)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
            else newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);

            this.textDescription.SelectionFont = newFont;
            this.textDescription.Focus();

        }

        private void DescrItalicButton_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;

            oldFont = this.textDescription.SelectionFont;
            if (oldFont.Italic == true)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic);
            else newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);

            this.textDescription.SelectionFont = newFont;
            this.textDescription.Focus();

        }

        private void DescrBoldButton_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;

            oldFont = this.textDescription.SelectionFont;
            if (oldFont.Bold == true)
                // если уже жирный то убираем выделение
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);
            else newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold); // выделяем жирным

            this.textDescription.SelectionFont = newFont;
            this.textDescription.Focus();

        }

        private void ApplyTextSize(string text)
        {
            float newSize = Convert.ToSingle(text);
            FontFamily currentFontFamily;
            Font newFont;

            currentFontFamily = this.textDescription.SelectionFont.FontFamily;
            newFont = new Font(currentFontFamily, newSize);

            this.textDescription.SelectionFont = newFont;
        }

        private void TextSizeBox_ValueChanged(object sender, EventArgs e)
        {
            if (TextSizeBox.Value >= 8 && TextSizeBox.Value <= 72)
                ApplyTextSize(TextSizeBox.Value.ToString());
            this.textDescription.Focus();

        }

        private void AlignRightButton_Click(object sender, EventArgs e)
        {
            if (this.textDescription.SelectionAlignment == HorizontalAlignment.Right)
                this.textDescription.SelectionAlignment = HorizontalAlignment.Left;
            else this.textDescription.SelectionAlignment = HorizontalAlignment.Right;
            this.textDescription.Focus();

        }

        private void AlignCenterButton_Click(object sender, EventArgs e)
        {
            if (this.textDescription.SelectionAlignment == HorizontalAlignment.Center)
                this.textDescription.SelectionAlignment = HorizontalAlignment.Left;
            else this.textDescription.SelectionAlignment = HorizontalAlignment.Center;
            this.textDescription.Focus();

        }

        private void AlignLeftButton_Click(object sender, EventArgs e)
        {
            this.textDescription.SelectionAlignment = HorizontalAlignment.Left;
            this.textDescription.Focus();

        }


        private void TextColorButton_Click(object sender, EventArgs e)
        {
            if (TextColorDialog.ShowDialog() == DialogResult.OK)
                textDescription.SelectionColor = TextColorDialog.Color;

        }
        #endregion

        private void SnapToGridBox_Click(object sender, EventArgs e)
        {
            if (!SnapToGridBox.Checked)
            {
                SnapToGridBox.Checked = true;
            }
            else
            {
                SnapToGridBox.Checked = false;
            }
        }

        private void NumberPlus_Click(object sender, EventArgs e)
        {
            if (SelectedItem != null)
            {
                foreach (LayoutType.CardPos item in StaticParams.CurrentLayoutType.CardPositions)
                {
                    if (SelectedItem.Number - item.Number == -1)
                    {
                        int temp = SelectedItem.Number;
                        SelectedItem.Number = item.Number;
                        item.Number = temp;
                        break;
                    }
                }
                DrawingPanel.Invalidate();
                saved = false;
            }

        }

        private void NumberMinus_Click(object sender, EventArgs e)
        {
            if (SelectedItem != null)
            {
                foreach (LayoutType.CardPos item in StaticParams.CurrentLayoutType.CardPositions)
                {
                    if (item.Number - SelectedItem.Number == -1)
                    {
                        int temp = SelectedItem.Number;
                        SelectedItem.Number = item.Number;
                        item.Number = temp;
                        break;
                    }
                }
                DrawingPanel.Invalidate();
                saved = false;
            }

        }

        private void NumberPositionPlus_Click(object sender, EventArgs e)
        {
            if (SelectedItem != null)
            {
                SelectedItem.NumberPos++;
                if (SelectedItem.NumberPos > 7)
                    SelectedItem.NumberPos = 0;
                DrawingPanel.Invalidate();
                saved = false;
            }
        }

        private void DelItem_Click(object sender, EventArgs e)
        {
            foreach (LayoutType.CardPos item in StaticParams.CurrentLayoutType.CardPositions)
            {
                if (item.Number == StaticParams.CurrentLayoutType.CardPositions.Count)
                {
                    StaticParams.CurrentLayoutType.CardPositions.Remove(item);
                    PosRefresh();
                    DrawingPanel.Invalidate();
                    saved = false;
                    break;
                }
            }
        }

        private void DragAllBox_Click(object sender, EventArgs e)
        {
            if (!DragAllBox.Checked)
            {
                DragAllBox.Checked = true;
            }
            else
            {
                DragAllBox.Checked = false;
            }

        }


        private void PosDescription_Click(object sender, EventArgs e)
        {
            if (PosDescription.Text == "Нет описания.")
                PosDescription.SelectAll();
        }

        private void TypeDesigner_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved)
            {
                switch (MessageBox.Show("Сохранить изменения?", "Сохранение",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        {
                            сохранитьToolStripMenuItem.PerformClick();
                            e.Cancel = true;
                            break;
                        }
                    case DialogResult.Cancel:
                        {
                            e.Cancel = true;
                            break;
                        }
                }
                        


            }
        }

        private void NullOwnerBox_CheckedChanged(object sender, EventArgs e)
        {
            StaticParams.CurrentLayoutType.FreeAccess = NullOwnerBox.Checked;
        }

        private void FontButton_Click(object sender, EventArgs e)
        {
            if (descrFontDialog.ShowDialog() == DialogResult.OK)
                textDescription.SelectionFont = descrFontDialog.Font;

        }

        private void textName_Leave(object sender, EventArgs e)
        {
            textName.Text = Drawing.CleanString(textName.Text);
        }

        private void PosDescription_Leave(object sender, EventArgs e)
        {
            PosDescription.Text = Drawing.CleanString(PosDescription.Text);
        }

    }
}
