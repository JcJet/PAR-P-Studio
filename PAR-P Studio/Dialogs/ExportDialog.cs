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
using PAR_P_Studio.ProjectClasses;
using System.Diagnostics;
using System.Threading;

//Форма позволяет сохранить все колоды, имеющиеся в программе, в стандартном формате для использования в других программах.
//Вызывается из формы LoginScreen
//© Владимир Андреев, PAR-P Corp.

namespace PAR_P_Studio.Dialogs
{
    public partial class ExportDialog : Form
    {

        public ExportDialog()
        {
            InitializeComponent();
        }

        private void ExportDialog_Shown(object sender, EventArgs e)
        {
            FormatBox.SelectedIndex = 0;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            StaticParams.Events.Add(new Event("Экспорт всех колод", FormatBox.Text));
            string ExportDir = "Export\\Decks\\";
            if (Directory.Exists(ExportDir))
            for (int i = 2; ; i++)
            {
                if (!Directory.Exists("Export\\Decks(" + i + ")"))
                {
                    ExportDir = "Export\\Decks(" + i + ")\\";
                    break;
                }

            }
            if (StaticParams.Access == StaticParams.AccessType.One)
            {
                Files.LoadBigFiles();
                foreach (Deck item in StaticParams.Decks)
                {
                    Directory.CreateDirectory(ExportDir + item.Name);

                    StringBuilder StrBuilder = new StringBuilder();
                    StrBuilder.Append("<!DOCTYPE html>");
                    StrBuilder.Append("<html>");
                    StrBuilder.Append("<head> Экспортировано из PAR-P Studio, колода " + item.Name + "</head>");
                    StrBuilder.Append("<body>");
                    #region switch (FormatBox.SelectedIndex) / Изображение обложки и рубашки
                    switch (FormatBox.SelectedIndex)
                    {
                        case 1:
                            StrBuilder.Append("<center> <img src = Logo.bmp > </center>");
                            StrBuilder.Append("<center> Рубашка колоды: </center>");
                            StrBuilder.Append("<center> <img src = Back.bmp > </center>");
                            break;
                        case 0:
                            StrBuilder.Append("<center> <img src = Logo.jpg > </center>");
                            StrBuilder.Append("<center> Рубашка колоды: </center>");
                            StrBuilder.Append("<center> <img src = Back.jpg > </center>");
                            break;
                        case 2:
                            StrBuilder.Append("<center> <img src = Logo.gif > </center>");
                            StrBuilder.Append("<center> Рубашка колоды: </center>");
                            StrBuilder.Append("<center> <img src = Back.gif > </center>");
                            break;
                        case 3:
                            StrBuilder.Append("<center> Изображения формата .tiff могут не отображаться в HTML. Если это важно, ");
                            StrBuilder.Append("Вы можете извлечь колоды в другом формате. </center>");
                            StrBuilder.Append("<center> <img src = Logo.tiff > </center>");
                            StrBuilder.Append("<center> Рубашка колоды: </center>");
                            StrBuilder.Append("<center> <img src = Back.tiff > </center>");
                            break;
                        case 4:
                            StrBuilder.Append("<center> <img src = Logo.png > </center>");
                            StrBuilder.Append("<center> Рубашка колоды: </center>");
                            StrBuilder.Append("<center> <img src = Back.png > </center>");
                            break;
                        default:
                            break;
                    }
                    #endregion


                    StrBuilder.Append(MarkupConverter.RtfToHtmlConverter.ConvertRtfToHtml(item.Description) + "<br>");
                    StrBuilder.Append("<TABLE BORDER=\"1\" CELLSPACING=\"0\">");
                    StrBuilder.Append("<CAPTION> Описание арканов </CAPTION>");
                    StrBuilder.Append(" <TH> Изображение </TH> <TH> Описание </TH>");

                    foreach (Deck.card crd in item.Cards)
                    {
                        Bitmap bmp = new Bitmap(crd.CardPicture);
                        string filename = ExportDir + item.Name + "\\" + crd.CardId;
                        string extension = "";
                        #region switch (FormatBox.SelectedIndex)
                        switch (FormatBox.SelectedIndex)
                        {
                            case 1:
                                bmp.Save(filename + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                                extension = ".bmp";
                                if (crd.CardId == 0)
                                {
                                    //Экспорт обложки, рубашки, и описания самой колоды
                                    Bitmap logo = new Bitmap(item.Logo);
                                    if (item.Logo == null)
                                        logo = new Bitmap(Properties.Resources.vopros);
                                    logo.Save(ExportDir + item.Name + "\\Logo.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                                    if (item.Back != null)
                                        logo = new Bitmap(item.Back);
                                    else
                                        logo = new Bitmap(Properties.Resources.DefaultTaroBack);
                                    logo.Save(ExportDir + item.Name + "\\Back.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                                    if (item.AuthorImage != null)
                                    {
                                        logo = new Bitmap(item.AuthorImage);
                                        logo.Save(ExportDir + item.Name + "\\Author.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                                    }
                                    logo.Dispose();
                                    StreamWriter DeckDescr = new StreamWriter(ExportDir + item.Name + "\\" + item.Name + ".rtf");
                                    DeckDescr.Write(item.Description);
                                    DeckDescr.Flush();
                                    DeckDescr.Close();
                                    DeckDescr.Dispose();
                                }

                                break;
                            case 0:
                                bmp.Save(filename + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                                extension = ".jpg";
                                if (crd.CardId == 0)
                                {
                                    //Экспорт обложки, рубашки, и описания самой колоды
                                    Bitmap logo = new Bitmap(item.Logo);
                                    if (item.Logo == null)
                                        logo = new Bitmap(Properties.Resources.vopros);
                                    logo.Save(ExportDir + item.Name + "\\Logo.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                                    if (item.Back != null)
                                        logo = new Bitmap(item.Back);
                                    else
                                        logo = new Bitmap(Properties.Resources.DefaultTaroBack);
                                    logo.Save(ExportDir + item.Name + "\\Back.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                                    if (item.AuthorImage != null)
                                    {
                                        logo = new Bitmap(item.AuthorImage);
                                        logo.Save(ExportDir + item.Name + "\\Author.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                                    }
                                    logo.Dispose();
                                    StreamWriter DeckDescr = new StreamWriter(ExportDir + item.Name + "\\" + item.Name + ".rtf");
                                    DeckDescr.Write(item.Description);
                                    DeckDescr.Flush();
                                    DeckDescr.Close();
                                    DeckDescr.Dispose();
                                }

                                break;
                            case 2:
                                bmp.Save(filename + ".gif", System.Drawing.Imaging.ImageFormat.Gif);
                                extension = ".gif";
                                if (crd.CardId == 0)
                                {
                                    //Экспорт обложки, рубашки, и описания самой колоды
                                    Bitmap logo = new Bitmap(item.Logo);
                                    if (item.Logo == null)
                                        logo = new Bitmap(Properties.Resources.vopros);
                                    logo.Save(ExportDir + item.Name + "\\Logo.gif", System.Drawing.Imaging.ImageFormat.Gif);
                                    if (item.Back != null)
                                        logo = new Bitmap(item.Back);
                                    else
                                        logo = new Bitmap(Properties.Resources.DefaultTaroBack);
                                    logo.Save(ExportDir + item.Name + "\\Back.gif", System.Drawing.Imaging.ImageFormat.Gif);
                                    if (item.AuthorImage != null)
                                    {
                                        logo = new Bitmap(item.AuthorImage);
                                        logo.Save(ExportDir + item.Name + "\\Author.gif", System.Drawing.Imaging.ImageFormat.Gif);
                                    }
                                    logo.Dispose();
                                    StreamWriter DeckDescr = new StreamWriter(ExportDir + item.Name + "\\" + item.Name + ".rtf");
                                    DeckDescr.Write(item.Description);
                                    DeckDescr.Flush();
                                    DeckDescr.Close();
                                    DeckDescr.Dispose();
                                }

                                break;
                            case 3:
                                bmp.Save(filename + ".tiff", System.Drawing.Imaging.ImageFormat.Tiff);
                                extension = ".tiff";
                                if (crd.CardId == 0)
                                {
                                    //Экспорт обложки, рубашки, и описания самой колоды
                                    Bitmap logo = new Bitmap(item.Logo);
                                    if (item.Logo == null)
                                        logo = new Bitmap(Properties.Resources.vopros);
                                    logo.Save(ExportDir + item.Name + "\\Logo.tiff", System.Drawing.Imaging.ImageFormat.Tiff);
                                    if (item.Back != null)
                                        logo = new Bitmap(item.Back);
                                    else
                                        logo = new Bitmap(Properties.Resources.DefaultTaroBack);
                                    logo.Save(ExportDir + item.Name + "\\Back.tiff", System.Drawing.Imaging.ImageFormat.Tiff);
                                    if (item.AuthorImage != null)
                                    {
                                        logo = new Bitmap(item.AuthorImage);
                                        logo.Save(ExportDir + item.Name + "\\Author.tiff", System.Drawing.Imaging.ImageFormat.Tiff);
                                    }
                                    logo.Dispose();
                                    StreamWriter DeckDescr = new StreamWriter(ExportDir + item.Name + "\\" + item.Name + ".rtf");
                                    DeckDescr.Write(item.Description);
                                    DeckDescr.Flush();
                                    DeckDescr.Close();
                                    DeckDescr.Dispose();
                                }

                                break;
                            case 4:
                                bmp.Save(filename + ".png", System.Drawing.Imaging.ImageFormat.Png);
                                extension = ".png";
                                if (crd.CardId == 0)
                                {
                                    //Экспорт обложки, рубашки, и описания самой колоды
                                    Bitmap logo = new Bitmap(item.Logo);
                                    if (item.Logo == null)
                                        logo = new Bitmap(Properties.Resources.vopros);
                                    logo.Save(ExportDir + item.Name + "\\Logo.png", System.Drawing.Imaging.ImageFormat.Png);
                                    if (item.Back != null)
                                        logo = new Bitmap(item.Back);
                                    else
                                        logo = new Bitmap(Properties.Resources.DefaultTaroBack);
                                    logo.Save(ExportDir + item.Name + "\\Back.png", System.Drawing.Imaging.ImageFormat.Png);
                                    if (item.AuthorImage != null)
                                    {
                                        logo = new Bitmap(item.AuthorImage);
                                        logo.Save(ExportDir + item.Name + "\\Author.png", System.Drawing.Imaging.ImageFormat.Png);
                                    }
                                    logo.Dispose();
                                    StreamWriter DeckDescr = new StreamWriter(ExportDir + item.Name + "\\" + item.Name + ".rtf");
                                    DeckDescr.Write(item.Description);
                                    DeckDescr.Flush();
                                    DeckDescr.Close();
                                    DeckDescr.Dispose();
                                }

                                break;
                            default:
                                break;
                        }
                        #endregion
                        StreamWriter SW = new StreamWriter(filename + ".rtf"); //надо будет сохранять в DOC...
                        SW.Write(crd.CardDescription);
                        SW.Flush();
                        SW.Close();

                        StrBuilder.Append("<TR>");
                        StrBuilder.Append("<TD> <img src = " + crd.CardId + extension + "> </TD>");
                        StrBuilder.Append("<TD>");
                        StrBuilder.Append(MarkupConverter.RtfToHtmlConverter.ConvertRtfToHtml(crd.CardDescription));
                        StrBuilder.Append("</TD></TR>");

                    }

                    StrBuilder.Append("</TABLE>");
                    StrBuilder.Append("<center> Авторские права и прочая информация </center>");
                    if (item.AuthorImage != null)
                    {
                        #region switch (FormatBox.SelectedIndex) / Изображение автора
                        switch (FormatBox.SelectedIndex)
                        {
                            case 1:
                                StrBuilder.Append("<center> <img src = Author.bmp > </center>");
                                break;
                            case 0:
                                StrBuilder.Append("<center> <img src = Author.jpg > </center>");
                                break;
                            case 2:
                                StrBuilder.Append("<center> <img src = Author.gif > </center>");
                                break;
                            case 3:
                                StrBuilder.Append("<center> <img src = Author.tiff > </center>");
                                break;
                            case 4:
                                StrBuilder.Append("<center> <img src = Author.png > </center>");
                                break;
                            default:
                                break;
                        }
                        #endregion
                    }
                    if (item.Copyright != null)
                        StrBuilder.Append(MarkupConverter.RtfToHtmlConverter.ConvertRtfToHtml(item.Copyright));
                    StrBuilder.Append("</body></html>");

                    Encoding EncWin1251 = Encoding.GetEncoding("Windows-1251");
                    FileStream fs = new FileStream(ExportDir + item.Name + "\\" + item.Name + ".html", FileMode.Create, FileAccess.Write);
                    StreamWriter StrmWriter = new StreamWriter(fs, EncWin1251);
                    StrmWriter.Write(StrBuilder.ToString());
                    StrmWriter.Flush();
                    StrmWriter.Close();
                    fs.Close();
                }
                Files.ClearMemory();
            }
            else if (StaticParams.Access == StaticParams.AccessType.Separate)
            {
                //Получаем список файлов
                string[] files = Directory.GetFiles(StaticParams.GetProgramDir() + "Data\\Decks");
                foreach (string item in files)
                {
                    try
                    {
                        //Открываем очередной файл колоды
                        FileStream file = new FileStream(item,
                            FileMode.Open, FileAccess.Read);
                        BinaryFormatter formatter = new BinaryFormatter();
                        Deck TempDeck = new Deck((Deck)formatter.Deserialize(file));
                        file.Close();

                        //Создаем папку для данных колоды
                        Directory.CreateDirectory(ExportDir + TempDeck.Name);

                        //Начинаем построение HTML файла с использованием полученных данных
                        StringBuilder StrBuilder = new StringBuilder();
                        StrBuilder.Append("<!DOCTYPE html>");
                        StrBuilder.Append("<html>");
                        StrBuilder.Append("<head> Экспортировано из PAR-P Studio, колода " + TempDeck.Name + "</head>");
                        StrBuilder.Append("<body>");
                        #region switch (FormatBox.SelectedIndex) / Изображение обложки и рубашки
                        switch (FormatBox.SelectedIndex)
                        {
                            case 1:
                                StrBuilder.Append("<center> <img src = Logo.bmp > </center>");
                                StrBuilder.Append("<center> Рубашка колоды: </center>");
                                StrBuilder.Append("<center> <img src = Back.bmp > </center>");
                                break;
                            case 0:
                                StrBuilder.Append("<center> <img src = Logo.jpg > </center>");
                                StrBuilder.Append("<center> Рубашка колоды: </center>");
                                StrBuilder.Append("<center> <img src = Back.jpg > </center>");
                                break;
                            case 2:
                                StrBuilder.Append("<center> <img src = Logo.gif > </center>");
                                StrBuilder.Append("<center> Рубашка колоды: </center>");
                                StrBuilder.Append("<center> <img src = Back.gif > </center>");
                                break;
                            case 3:
                                StrBuilder.Append("<center> Изображения формата .tiff могут не отображаться в HTML. Если это важно, ");
                                StrBuilder.Append("Вы можете извлечь колоды в другом формате. </center>");
                                StrBuilder.Append("<center> <img src = Logo.tiff > </center>");
                                StrBuilder.Append("<center> Рубашка колоды: </center>");
                                StrBuilder.Append("<center> <img src = Back.tiff > </center>");
                                break;
                            case 4:
                                StrBuilder.Append("<center> <img src = Logo.png > </center>");
                                StrBuilder.Append("<center> Рубашка колоды: </center>");
                                StrBuilder.Append("<center> <img src = Back.png > </center>");
                                break;
                            default:
                                break;
                        }
                        #endregion

                        //Метод, преобразующий коды RTF в HTML
                        StrBuilder.Append(MarkupConverter.RtfToHtmlConverter.ConvertRtfToHtml(TempDeck.Description) + "<br>");

                        StrBuilder.Append("<TABLE BORDER=\"1\" CELLSPACING=\"0\">");
                        StrBuilder.Append("<CAPTION> Описание арканов </CAPTION>");
                        StrBuilder.Append(" <TH> Изображение </TH> <TH> Описание </TH>");

                        for (int i = 0; i < TempDeck.Cards.Count;i++ )
                        {
                            Bitmap bmp = new Bitmap(((Deck.card)TempDeck.Cards[i]).CardPicture);
                            string filename = ExportDir + TempDeck.Name + "\\" + ((Deck.card)TempDeck.Cards[i]).CardId;
                            string extension = "";
                            #region switch (FormatBox.SelectedIndex)
                            switch (FormatBox.SelectedIndex)
                            {
                                case 1:
                                    bmp.Save(filename + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                                    extension = ".bmp";
                                    if (i == 0)
                                    {
                                        //Экспорт обложки, рубашки, и описания самой колоды
                                        Bitmap logo = new Bitmap(TempDeck.Logo);
                                        if (TempDeck.Logo == null)
                                            logo = new Bitmap(Properties.Resources.vopros);
                                        logo.Save(ExportDir + TempDeck.Name + "\\Logo.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                                        if (TempDeck.Back != null)
                                            logo = new Bitmap(TempDeck.Back);
                                        else
                                            logo = new Bitmap(Properties.Resources.DefaultTaroBack);
                                        logo.Save(ExportDir + TempDeck.Name + "\\Back.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                                        if (TempDeck.AuthorImage != null)
                                        {
                                            logo = new Bitmap(TempDeck.AuthorImage);
                                            logo.Save(ExportDir + TempDeck.Name + "\\Author.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                                        }
                                        logo.Dispose();
                                        StreamWriter DeckDescr = new StreamWriter(ExportDir + TempDeck.Name + "\\" + TempDeck.Name + ".rtf");
                                        DeckDescr.Write(TempDeck.Description);
                                        DeckDescr.Flush();
                                        DeckDescr.Close();
                                        DeckDescr.Dispose();
                                    }
                                    break;
                                case 0:
                                    bmp.Save(filename + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                                    extension = ".jpg";
                                    if (i == 0)
                                    {
                                        //Экспорт обложки, рубашки, и описания самой колоды
                                        Bitmap logo = new Bitmap(TempDeck.Logo);
                                        if (TempDeck.Logo == null)
                                            logo = new Bitmap(Properties.Resources.vopros);
                                        logo.Save(ExportDir + TempDeck.Name + "\\Logo.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                                        if (TempDeck.Back != null)
                                            logo = new Bitmap(TempDeck.Back);
                                        else
                                            logo = new Bitmap(Properties.Resources.DefaultTaroBack);
                                        logo.Save(ExportDir + TempDeck.Name + "\\Back.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                                        if (TempDeck.AuthorImage != null)
                                        {
                                            logo = new Bitmap(TempDeck.AuthorImage);
                                            logo.Save(ExportDir + TempDeck.Name + "\\Author.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                                        }
                                        logo.Dispose();
                                        StreamWriter DeckDescr = new StreamWriter(ExportDir + TempDeck.Name + "\\" + TempDeck.Name + ".rtf");
                                        DeckDescr.Write(TempDeck.Description);
                                        DeckDescr.Flush();
                                        DeckDescr.Close();
                                        DeckDescr.Dispose();
                                    }
                                    break;
                                case 2:
                                    bmp.Save(filename + ".gif", System.Drawing.Imaging.ImageFormat.Gif);
                                    extension = ".gif";
                                    if (i == 0)
                                    {
                                        //Экспорт обложки, рубашки, и описания самой колоды
                                        Bitmap logo = new Bitmap(TempDeck.Logo);
                                        if (TempDeck.Logo == null)
                                            logo = new Bitmap(Properties.Resources.vopros);
                                        logo.Save(ExportDir + TempDeck.Name + "\\Logo.gif", System.Drawing.Imaging.ImageFormat.Gif);
                                        if (TempDeck.Back != null)
                                            logo = new Bitmap(TempDeck.Back);
                                        else
                                            logo = new Bitmap(Properties.Resources.DefaultTaroBack);
                                        logo.Save(ExportDir + TempDeck.Name + "\\Back.gif", System.Drawing.Imaging.ImageFormat.Gif);
                                        if (TempDeck.AuthorImage != null)
                                        {
                                            logo = new Bitmap(TempDeck.AuthorImage);
                                            logo.Save(ExportDir + TempDeck.Name + "\\Author.gif", System.Drawing.Imaging.ImageFormat.Gif);
                                        }
                                        logo.Dispose();
                                        StreamWriter DeckDescr = new StreamWriter(ExportDir + TempDeck.Name + "\\" + TempDeck.Name + ".rtf");
                                        DeckDescr.Write(TempDeck.Description);
                                        DeckDescr.Flush();
                                        DeckDescr.Close();
                                        DeckDescr.Dispose();
                                    }
                                    break;
                                case 3:
                                    bmp.Save(filename + ".tiff", System.Drawing.Imaging.ImageFormat.Tiff);
                                    extension = ".tiff";
                                    if (i == 0)
                                    {
                                        //Экспорт обложки, рубашки, и описания самой колоды
                                        Bitmap logo = new Bitmap(TempDeck.Logo);
                                        if (TempDeck.Logo == null)
                                            logo = new Bitmap(Properties.Resources.vopros);
                                        logo.Save(ExportDir + TempDeck.Name + "\\Logo.tiff", System.Drawing.Imaging.ImageFormat.Tiff);
                                        if (TempDeck.Back != null)
                                            logo = new Bitmap(TempDeck.Back);
                                        else
                                            logo = new Bitmap(Properties.Resources.DefaultTaroBack);
                                        logo.Save(ExportDir + TempDeck.Name + "\\Back.tiff", System.Drawing.Imaging.ImageFormat.Tiff);
                                        if (TempDeck.AuthorImage != null)
                                        {
                                            logo = new Bitmap(TempDeck.AuthorImage);
                                            logo.Save(ExportDir + TempDeck.Name + "\\Author.tiff", System.Drawing.Imaging.ImageFormat.Tiff);
                                        }
                                        logo.Dispose();
                                        StreamWriter DeckDescr = new StreamWriter(ExportDir + TempDeck.Name + "\\" + TempDeck.Name + ".rtf");
                                        DeckDescr.Write(TempDeck.Description);
                                        DeckDescr.Flush();
                                        DeckDescr.Close();
                                        DeckDescr.Dispose();
                                    }
                                    break;
                                case 4:
                                    bmp.Save(filename + ".png", System.Drawing.Imaging.ImageFormat.Png);
                                    extension = ".png";
                                    if (i == 0)
                                    {
                                        //Экспорт обложки, рубашки, и описания самой колоды
                                        Bitmap logo = new Bitmap(TempDeck.Logo);
                                        if (TempDeck.Logo == null)
                                            logo = new Bitmap(Properties.Resources.vopros);
                                        logo.Save(ExportDir + TempDeck.Name + "\\Logo.png", System.Drawing.Imaging.ImageFormat.Png);
                                        if (TempDeck.Back != null)
                                            logo = new Bitmap(TempDeck.Back);
                                        else
                                            logo = new Bitmap(Properties.Resources.DefaultTaroBack);
                                        logo.Save(ExportDir + TempDeck.Name + "\\Back.png", System.Drawing.Imaging.ImageFormat.Png);
                                        if (TempDeck.AuthorImage != null)
                                        {
                                            logo = new Bitmap(TempDeck.AuthorImage);
                                            logo.Save(ExportDir + TempDeck.Name + "\\Author.png", System.Drawing.Imaging.ImageFormat.Png);
                                        }
                                        logo.Dispose();
                                        StreamWriter DeckDescr = new StreamWriter(ExportDir + TempDeck.Name + "\\" + TempDeck.Name + ".rtf");
                                        DeckDescr.Write(TempDeck.Description);
                                        DeckDescr.Flush();
                                        DeckDescr.Close();
                                        DeckDescr.Dispose();
                                    }
                                    break;
                                default:
                                    break;
                            }
                            #endregion
                            StreamWriter SW = new StreamWriter(filename + ".rtf"); //надо будет сохранять в DOC...
                            SW.Write(((Deck.card)TempDeck.Cards[i]).CardDescription);
                            SW.Flush();
                            SW.Close();
                            //добавление картинок
                            StrBuilder.Append("<TR>");
                            StrBuilder.Append("<TD> <img src = " + ((Deck.card)TempDeck.Cards[i]).CardId + extension + "> </TD>");
                            StrBuilder.Append("<TD>");
                            //добавления описаний
                            StrBuilder.Append(MarkupConverter.RtfToHtmlConverter.ConvertRtfToHtml(((Deck.card)TempDeck.Cards[i]).CardDescription));
                            StrBuilder.Append("</TD></TR>");

                        }
                        //Закрытие таблицы и добавление информации об авторах, если она прилагается
                        StrBuilder.Append("</TABLE>");
                        StrBuilder.Append("<center> Авторские права и прочая информация </center>");
                        if (TempDeck.AuthorImage != null)
                        {
                            #region switch (FormatBox.SelectedIndex) / Изображение автора
                            switch (FormatBox.SelectedIndex)
                            {
                                case 1:
                                    StrBuilder.Append("<center> <img src = Author.bmp > </center>");
                                    break;
                                case 0:
                                    StrBuilder.Append("<center> <img src = Author.jpg > </center>");
                                    break;
                                case 2:
                                    StrBuilder.Append("<center> <img src = Author.gif > </center>");
                                    break;
                                case 3:
                                    StrBuilder.Append("<center> <img src = Author.tiff > </center>");
                                    break;
                                case 4:
                                    StrBuilder.Append("<center> <img src = Author.png > </center>");
                                    break;
                                default:
                                    break;
                            }
                            #endregion
                        }
                        if (TempDeck.Copyright != null)
                            StrBuilder.Append(MarkupConverter.RtfToHtmlConverter.ConvertRtfToHtml(TempDeck.Copyright));
                        StrBuilder.Append("</body></html>");
                        //Сохраняем завершенный HTML файл
                        Encoding EncWin1251 = Encoding.GetEncoding("Windows-1251");
                        FileStream fs = new FileStream(ExportDir + TempDeck.Name + "\\" + TempDeck.Name + ".html", FileMode.Create, FileAccess.Write);
                        StreamWriter StrmWriter = new StreamWriter(fs, EncWin1251);
                        StrmWriter.Write(StrBuilder.ToString());
                        StrmWriter.Flush();
                        StrmWriter.Close();
                        fs.Close();


                        
                    }
                    catch { }
                }

            }
            Process.Start(ExportDir);
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
