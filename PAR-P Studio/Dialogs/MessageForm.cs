using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Форма либо распознает короткое послание, либо отображает его в неизменном виде. Вызывается ссылкой на подробную подсказку.
//© Владимир Андреев, PAR-P Corp.

namespace PAR_P_Studio.Dialogs
{
    public partial class MessageForm : Form
    {
        public MessageForm(string message)
        {
            InitializeComponent();
            
            switch (message)
            {
                case "SameCardsHelp":
                    {
                        MessageText.Text = "Разрешает вытягивание одинаковых карт. При выборе этой опции вытянутые карты будут оставаться в колоде. " +
                            "В реальном гадании такого не бывает, но в программе такое возможно. Может пригодиться для особо больших раскладов, или "
                            + "случаев, когда в колоде слишком мало карт";
                        break;
                    }
                case "ShowCardsHelp":
                    {
                        MessageText.Text = "Показ карт при перемешивании. При выборе этой опции карты будут показываться на этапе перемешивания."
                            + "Не рекомендуется включать эту опцию без особой нужды.";
                        break;
                    }
                case "MaximizeHelp":
                    {
                        MessageText.Text = "Большое окно расклада. При выборе этой опции окно расклада всегда будет развернуто на весь экран.";
                        break;
                    }
                case "QuestionHelp":
                    {
                        MessageText.Text = "Задавать вопрос для расклада. Если эта опция активна, то при каждом раскладе будет появляться окно, "
                            + "где гадающий сможет ввести свой вопрос для текущего расклада. Вопрос не влияет на алгоритмы перемешивания, "
                            + "но будет виден в статистике раскладов. Это также может использоваться для облегчения концетрации гадающего перед раскладом.";
                        break;
                    }
                case "UserSeedHelp":
                    {
                        MessageText.Text = "Захват движения пользователя для автоперемешивания. Если активна эта опция, перед каждым раскладом " +
                            "пользователю будет необходимо немного поводить мышью в появившейся области. Характер движения повлияет на разброс карт." +
                            "Не влияет на ручное перемешивание.";
                        break;
                    }
                case "HideTipsHelp":
                    {
                        MessageText.Text = "Скрыть значки подсказок. При выборе этой опции значки для отображения подробных подсказок вроде этой," + 
                            " не будут видны. Включите эту опцию, если вам они не нужны, это уберет лишнее из интерфейса программы. \n" + 
                            "Помимо этого, опция скрывает кнопку \"Знаете ли Вы, что...\".";
                        break;
                    }
                case "ShuffleSpeedHelp":
                    {
                        MessageText.Text = "Скорость перебора. Этот ползунок позволяет изменять скорость перебора карт при автоматическом режиме." +
                            "Все карты в любом случае будут перемешаны, однако понижение скорости может снизить нагрузку при работе с медленными " +
                            "устройствами. Особенно при включенной опции отображения карт. Но в подавляющем большинстве случаев, нет смысла менять " +
                            "эту установку/";
                        break;
                    }
                case "AutoShuffleHelp":
                    {
                        MessageText.Text = "Автоперемешивание карт. При выборе этого способа карты будут перемешиваться программой " +
                            "случайным образом. Это быстро и удобно.";
                        break;
                    }
                case "ManualShuffleHelp":
                    {
                        MessageText.Text = "Ручное перемешивание колоды. При выборе этой опции программа не будет сама мешать карты. " +
                            "Этот способ подходит для тех, кто предпочитает сам перемешивать карты и не доверяет \"искусственному\" перемешиванию" +
                            "Очевидно, потребуется вручную перемешать карты, что делает способ намного менее быстрым и удобным. \n" +
                            "Чтобы вручную перемешать карты, в окне таро выберите колоду, а затем перейдите на вкладку \"Особенности колоды\", " +
                            "Затем нажмите \"Перемешать карты\". Каждую колоду стоит как следует перемешать перемешать хотя бы один раз.";
                        break;
                    }
                case "PublicDeckHelp":
                    {
                        MessageText.Text = "Доступность колоды для редактирования. Если установлен этот флажок, колода будет доступна для изменения " +
                            "любым пользователем. Если флажок снят, колоду может изменить только пользователь, который ее создал. ";
                        break;
                    }
                case "UpsideDownHelp":
                    {
                        MessageText.Text = "Перевернутость карт. В некоторых колодах, в том числе классического типа, значение карты может изменяться, " +
                            "если она выпала перевернутой. В этом случае, установите этот флажок. Если он не установлен, все карты будут вытягиваться " +
                            "в их нормальном положении.";
                        break;
                    }
                case "ConvertHelp":
                    {
                        MessageText.Text = "При изменении способа хранения данных, данные, хранимые раньше другим методом, станут недоступны. " +
                            "Это: пользователи, колоды, и типы раскладов. Для того, чтобы перенести данные, используйте эти кнопки. " +
                            "Процесс может оказаться достаточно долгим при большом количестве данных. ОБРАТИТЕ ВНИМАНИЕ: Обекты с одинаковыми именами" +
                            "не будут обновлены в целевом наборе данных. Если необходимо обновление, сперва удалите соответствующие элементы из " +
                            "целевого набора данных";
                        break;
                    }
                case "ExportHelp":
                    {
                        MessageText.Text = "Программа использует собственный тип файлов для хранения колод. Эти файлы не будут корректно открываться " +
                            "в программах других разработчиков. Извлечение данных в распространенном формате возможно, если нажать кнопку " +
                            "\"Извлечь данные колод\", при этом откроется окно с параметрами экспорта, и, после нажатия кнопки \"ОК\", программа " +
                            "создаст для каждой колоды отдельную папку, в которой будут созданы файлы с изображением карт в выбраном формате, " +
                            "их описания в формате RTF, и HTML файл со всей этой информацией.\n" + 
                            "Процесс может занять некоторое время. По окончании, папка экспорта откроется в проводнике." +
                            " и с файлами можно будет работать. \n Экспортируемые данные зависят от выбранного способа хранения.";
                        break;
                    }
                case "ImportHelp":
                    {
                        MessageText.Text = "Добавить элемент из файла. Может быть полезно для частичного переноса данных. Файлы колод: *.dck, файлы" +
                            " пользователей: *.usr, файлы раскладов: *.lyt.  При использовании способа хранения по умолчанию, файлы можно просто" +
                            " скопировать в соответствующую папку в <программа>\\Data";
                        break;
                    }
                case "UDChanceHelp":
                    {
                        MessageText.Text = "Соотношения карт, выпадающих в прямом положении к перевернутым. Влияет на автоперемешивание, если перевернутые " +
                            "карты разрешены для колоды (вкладка \"Особенности колоды\"). В идеально перемешанной колоде должно быть примерно одинаковое "
                            + "количество перевернутых и нормальных карт (нет видимых причин каким-то из карт выпадать чаще). " + 
                             "Это значение по умолчанию. \n" +
                            "Однако если Вы считаете иначе, эта настройка поможет изменить соотношение карт. \n Но чаще всего рекомендуется " +
                            "установка по умолчанию. \n\n Также эта настройка может использоваться, чтобы отключить выпадение перевернутых" + 
                            "карт для всех колод, вне зависимости от настроек самой колоды.";
                        break;
                    }
                case "DeckComparerHelp":
                    {
                        MessageText.Text = "Перед вами окно для сравнения колод. Выберите одну колоду в левой части, и другую - в правой. " +
                            "\n Незапланированная возможность - использование этого окна как альтернативного просмотрщика колоды: " +
                            "откройте одну и ту же колоду слева и справа, поставьте флажок \"Синхронно\"; в одной части выберите вкладку с изображением" +
                            ", а в другой - с описанием. И листайте карты...";
                        break;
                    }
                case "CommentHelp":
                    {
                        MessageText.Text = "Вы можете написать коментарий для получившегося расклада. Например то, что вы в нем увидели, или то, " +
                            "что осталось не ясно. Позднее, вы можете вернуться к этому результату на вкладке \"Статистика\" главного окна Таро, " +
                            "и посмотреть, прояснилось ли что-нибудь. Или просто для ведения своеобразного дневника гаданий.";
                        break;
                    }
                case "StorageHelp":
                    {
                        MessageText.Text = "Здесь Вы можете выбрать способ хранения данных программы. Это: пользователи, колоды, данные " +
                        "ручного перемешивания и типы раскладов. \n" +
                            "Мы рекомендуем Вам попробовать каждый способ, как он будет работать в вашей системе. При переходе от одного к другому, " +
                            "для объединения данных Вы можете применить соответствующие комманды на вкладке \"Операции\".\n" + 
                            "Отдельный файл для каждого элемента:\n" +
                            "Способ хранения по умолчанию. Создаются 4 каталога в папке <программа>\\Data: Users, Decks, Shuffles и Layouts " +
                            "соответственно. В папках для каждого элемента создается файл с именем этого элемента и соответствующим расширением." +
                            "При использовании любого из них в программе, содержимое файла загружается в оперативную память.\n" +
                            "Все в одном файле:\n" +
                            "Этот способ может оказаться лучше в случае большого набора данных и достаточного объема и скорости оперативной памяти. " + 
                            "НА СОВРЕМЕННЫХ КОМПЬЮТЕРАХ ЭТОТ СПОСОБ МОЖЕТ ПОКАЗАТЬ ОГРОМНЫЙ ПРИРОСТ СКОРОСТИ РАБОТЫ ПРОГРАММЫ, ЦЕНОЙ ДОЛГИХ ЗАГРУЗОК " +
                            "В САМОМ НАЧАЛЕ РАБОТЫ, И НА ЭТАПЕ ВЫХОДА. " +
                            "Создаются 3 файла для данных каждого типа." +
                            "Остальные данные храняться отдельными файлами." +
                            "При использовании данных, весь файл загружается в оперативную память. Из очевидных следствий: при большом наборе данных, " +
                            "загрузка может быть очень медленной. Однако в некоторых случаях этот способ может оказаться предпочтительнее, так как " +
                            "чтение с диска происходит реже.\n" +
                            "Удаленная база данных:\n" +
                            "В данной версии программы эта опция не была реализована. Предполагалась возможность совместного использования данных " +
                            "через интернет.";
                        break;
                    }
                case "HiddenLayoutHelp":
                    {
                        MessageText.Text = "Позволяет раскладывать карты рубашкой вверх, чтобы они были видны не сразу, а при щелчке по ним. " +
                            "Многие гадающие при гадании предпочитают раскладывать все карты рубашкой вверх, а потом раскрывать их, " +
                            "одну за другой. Это делает гадание более волнующим и интересным.";
                        break;
                    }
                case "EventsHelp":
                    {
                        MessageText.Text = "Это окно позволяет просмотреть список событий, которые могут иметь последствия для данных в программе." +
                        " Этот список полезен, когда нужно отследить некоторые действия других пользователей. Например, изменения колод, и т. п. /n" +
                        "Чтобы список не становился слишком большим, можно удалять записи, но только те, которые были сделаны месяц и более назад.";
                        break;
                    }
                case "OverrideHelp":
                    {
                        MessageText.Text = "Иногда возникает ситуация, когда Вы находите колоду с интересными изображениями на картах, " +
                        "но без хорошего описания к ним, или же просто хотите поэкспериментировать. " +
                        "В этом случае Вы можете использовать описания карт из другой колоды, выбрав ее в этом списке. \n" +
                        "БУДЬТЕ ВНИМАТЕЛЬНЫ! Карты в колодах должны идти в одинаковом порядке, иначе описания не будут соответствовать картам. \n" + 
                        "Описания карт изменяются только на этапе завершения расклада, так что это не будет мешать просмотру и редактированию.";
                        break;
                    }
                case "OverrideTip":
                    {
                        MessageText.Text = "Эта надпись напоминает Вам о том, что включена опция замены толкований. (Вкладка \"Настройки\" " +
                            "в окне Таро). \n Замена толкований означает, что все карты на этапе завершения расклада будут иметь описания " +
                            "от карт в выбранной в качестве заменяющей колоды. \n" +
                            "БУДЬТЕ ВНИМАТЕЛЬНЫ! Карты в колодах должны идти в одинаковом порядке, иначе описания не будут соответствовать картам. \n" +
                            "Описания карт изменяются только на этапе завершения расклада, так что это не будет мешать просмотру и редактированию.";
                        break;
                    }

                default:
                    {
                        MessageText.Text = message;
                        break;
                    }
            }
            CloseBtn.Focus();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
