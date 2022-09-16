using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PAR_P_Studio.ProjectClasses;
using System.Collections;
using PAR_P_Studio.Dialogs;
//Форма отображает журнал событий в программе, которые могут быть полезны в отслеживании изменений данных
//©PAR-P Corp.

namespace PAR_P_Studio.ProjectForms
{
    public partial class EventLog : Form
    {
        public EventLog()
        {
            InitializeComponent();

            EventsHelp.Visible = !StaticParams.CurrentUser.UserSettings.HideTips;
            EventList.Columns.Clear();
            EventList.Columns.Add(new ColHeader("Дата", 120, HorizontalAlignment.Left, true));
            EventList.Columns.Add(new ColHeader("Пользователь", 115, HorizontalAlignment.Left, true));
            EventList.Columns.Add(new ColHeader("Действие", 450, HorizontalAlignment.Left, true));
            EventList.Columns.Add(new ColHeader("Объект", 200, HorizontalAlignment.Left, true));
            EventList.Columns.Add(new ColHeader("Набор данных", 80, HorizontalAlignment.Left, true));
        }

        void SetColors()
        {
            this.BackColor = StaticParams.CurrentUser.UserSettings.WinColor;
            this.ForeColor = StaticParams.CurrentUser.UserSettings.LabelColor;
        }
        void EventsRefresh()
        {
            EventList.Items.Clear();
            EventList.BeginUpdate();
            foreach (Event item in StaticParams.Events)
            {
                ListViewItem newItem = new ListViewItem(item.Time.ToString());
                newItem.SubItems.Add(item.User);
                newItem.SubItems.Add(item.EventType);
                newItem.SubItems.Add(item.Element);
                newItem.SubItems.Add(item.Dataset);
                EventList.Items.Add(newItem);
            }
            EventList.EndUpdate();
        }

        private void EventLog_Shown(object sender, EventArgs e)
        {
            SetColors();
            if (StaticParams.CurrentUser.Guestmode)
            {
                Login.Text = "Гостевой режим";
                Login.ForeColor = Color.Tomato;
            }
            else
            {
                Login.Text = StaticParams.CurrentUser.Login;
                Login.ForeColor = Color.Blue;
            }
            EventsRefresh();
        }

        private void EventList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            EventList.Sorting = SortOrder.None;
            // Create an instance of the ColHeader class.
            ColHeader clickedCol = (ColHeader)this.EventList.Columns[e.Column];

            // Set the ascending property to sort in the opposite order.
            clickedCol.ascending = !clickedCol.ascending;

            // Get the number of items in the list.
            int numItems = this.EventList.Items.Count;

            // Turn off display while data is repoplulated.
            this.EventList.BeginUpdate();

            // Populate an ArrayList with a SortWrapper of each list item.
            ArrayList SortArray = new ArrayList();
            for (int i = 0; i < numItems; i++)
            {
                SortArray.Add(new SortWrapper(this.EventList.Items[i], e.Column));
            }

            // Sort the elements in the ArrayList using a new instance of the SortComparer
            // class. The parameters are the starting index, the length of the range to sort,
            // and the IComparer implementation to use for comparing elements. Note that
            // the IComparer implementation (SortComparer) requires the sort
            // direction for its constructor; true if ascending, othwise false.
            SortArray.Sort(0, SortArray.Count, new SortWrapper.SortComparer(clickedCol.ascending));

            // Clear the list, and repopulate with the sorted items.
            this.EventList.Items.Clear();
            for (int i = 0; i < numItems; i++)
                this.EventList.Items.Add(((SortWrapper)SortArray[i]).sortItem);

            // Turn display back on.
            this.EventList.EndUpdate();
        }

        private void ClearLogButton_Click(object sender, EventArgs e)
        {
            List<Event> NewEvents = new List<Event>();
            foreach (Event item in StaticParams.Events)
            {
                if (item.Time >= ((DateTime)DateTime.Now).AddMonths(-1))
                    NewEvents.Add(item);           
            }
            StaticParams.Events = new List<Event>(NewEvents);
            StaticParams.Events.Add(new Event("Очистка списка событий", "Список событий"));
            EventList.Sorting = SortOrder.Descending;
            EventsRefresh();
            CancelClearing.Visible = true;
        }

        private void CancelClearing_Click(object sender, EventArgs e)
        {
            Files.EventLogLoad();
            EventsRefresh();
            EventList.Sorting = SortOrder.Descending;
        }
        #region Подсказки
        private void EventsHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageForm MF = new MessageForm(((LinkLabel)sender).Name);
            MF.StartPosition = FormStartPosition.CenterParent;
            MF.ShowDialog();
        }

        private void EventsHelp_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Показать подробную подсказку";
            EventsHelp.Text = "Что это?";
        }

        private void EventsHelp_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
            EventsHelp.Text = "?";
        }

        private void ClearLogButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Удаляет все записи старше 1 месяца. Факт удаления фиксируется в журнале";
        }

        private void ClearLogButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void CancelClearing_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Отменяет действия, сделанные после показа этого окна";
        }

        private void CancelClearing_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }

        private void EventList_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTip.Text = "Список событий. Работает сортировка по столбцу";
        }

        private void EventList_MouseLeave(object sender, EventArgs e)
        {
            toolStripTip.Text = "";
        }
        #endregion

    }
}
