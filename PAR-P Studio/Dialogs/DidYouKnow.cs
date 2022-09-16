using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Форма дает пользователю различные советы по использованию программы. Отключаемо.
//© Владимир Андреев, PAR-P Corp.
namespace PAR_P_Studio.Dialogs
{
    public partial class DidYouKnow : Form
    {
        List<string> Tips;
        int CurrentTip = 0;
        public DidYouKnow()
        {
            InitializeComponent();           
        }

        private void InfoPicture_Click(object sender, EventArgs e)
        {
            LargeImage LIM = new LargeImage(InfoPicture.Image);
            LIM.Show();
        }

        private void DidYouKnow_Load(object sender, EventArgs e)
        {
            Tips = new List<string>();
            Tips.Add("Почти на каждой картинке в программе можно щелкнуть мышью, чтобы посмотреть ее в полном, или увеличенном размере");
            Tips.Add("Окно сравнения колод можно использовать как удобный просмотрщик колод, в дополнение к уже существующему. " + 
                "Просто выберите одну и ту же колоду, установите в одной части показ описания, в другой - изображения, затем включите " + 
                "синхронное листание. И листайте!");
            Tips.Add("Раздел \"Таро\" может быть использован не только для карт Таро. Например, Вы можете создать новую колоду, и вместо карт " +
                "добавить изображения рун для гадания, или гексаграмм из Книги Перемен. Конечно, добавить значение/описание для каждой, " +
                "и создать расклады, которые будут реализовывать гадание. И все! Возможно, Вы найдете новое применение для программы. " +
                "А подумайте о возможностях применения, например, раскладов карт Таро в других системах гадания.");
            Tips.Add("Вы можете просмотреть все Ваши предыдущие расклады в разделе \"Таро\", на вкладке \"Статистика\". На случай, если Вы захотите " +
                "переосмыслить какой-то из не очень понятных раскладов. Или же проанализировать ответ карт после того, как ситуация завершится. " +
                "В этом вам поможет оставленный Вами коментарий к раскладу.");
            Tips.Add("Применение Таро не ограничено гаданием. На самом деле, через образы и символы в картах Таро передавались знания, чтобы те не попали в злые руки руки, или просто не были уничтожены. " + 
                "Гадание же, как и игры с картами таро (и обычными игральными картами, которые произошли от Таро) - это то, что было сделано, чтобы эти карты существовали годы, " +
                 "и знания из образов Таро не были утеряны со временем.");
            Tips.Add("Если Вы заинтересовались картами Таро, то вам может быть интересна книга Рэйчел Поллак \"Таро: полное " +
            "иллюстрированное руководство\". Книга легко читается, и в ней описывается Таро в целом, связь с другими областями, некоторая символика и " +
            "способы применения, не только для гадания.\n Несколько интересных идей для программы появились во время чтения этой книги.");
        }

        private void DidYouKnow_Shown(object sender, EventArgs e)
        {
            Random rnd = new Random();
            TipText.Text = Tips[rnd.Next(Tips.Count)];
            TipNumberLabel.Text = (CurrentTip + 1).ToString() + "/" + Tips.Count;
            ShowAtStartupBox.Checked = StaticParams.CurrentUser.UserSettings.DidYouKnow;
        }

        private void NextTipButton_Click(object sender, EventArgs e)
        {
            CurrentTip++;
            if (CurrentTip >= Tips.Count)
                CurrentTip = 0;
            TipText.Text = Tips[CurrentTip];
            TipNumberLabel.Text = (CurrentTip + 1).ToString() + "/" + Tips.Count;
        }

        private void ShowAtStartupBox_CheckedChanged(object sender, EventArgs e)
        {
            StaticParams.CurrentUser.UserSettings.DidYouKnow = ShowAtStartupBox.Checked;
        }
    }
}
