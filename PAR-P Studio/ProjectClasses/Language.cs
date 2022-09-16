using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PAR_P_Studio.ProjectClasses
{
    static class Language
    {
        public enum Languages { Eng, Rus };
        public static void SetLanguage(Object obj, Languages lang)
        {
            switch (lang)
            {
                case Languages.Rus:
                    {
                        if (obj is TarotForm)
                        {
                            (obj as TarotForm).Text = "Таро";
                            (obj as TarotForm).системаToolStripMenuItem.Text = "Система";
                            (obj as TarotForm).сменаПользователяToolStripMenuItem.Text = "Смена пользователя";
                            (obj as TarotForm).выходToolStripMenuItem.Text = "Выход";
                            (obj as TarotForm).редактированиеToolStripMenuItem.Text = "Вид";
                            (obj as TarotForm).OwnedOnly.Text = "Показывать только свои элементы";
                            (obj as TarotForm).toolStripCompareButton.Text = "Сравнение колод";
                            (obj as TarotForm).toolStripDeckViewButton.Text = "Просмотр колоды";
                            (obj as TarotForm).toolStripEditButton.Text = "Редактирование";
                            (obj as TarotForm).toolStripSaveButton.Text = "Сохранить";
                            (obj as TarotForm).TarotViewTab.Text = "Просмотр";
                            (obj as TarotForm).TarotRollTab.Text = "Настройки";
                            (obj as TarotForm).StatisticsTab.Text = "Статистика";
                            (obj as TarotForm).DeckMisc.Text = "Особенности колоды";
                            (obj as TarotForm).CardListLabel.Text = "Список карт";
                            (obj as TarotForm).CardImageLabel.Text = "Изображение";
                            (obj as TarotForm).DeckBackBox.Text = "Рубашка";
                            (obj as TarotForm).CardDescriptionLabel.Text = "Описание";
                            (obj as TarotForm).SelectDeckButton.Text = "Выделить колоду";
                            (obj as TarotForm).AdvancedEdit.Text = "Расширенный редактор";
                            (obj as TarotForm).ModifyLayoutButton.Text = "Изменить";
                            (obj as TarotForm).LayoutDescriptionLabel.Text = "Описание расклада";
                            (obj as TarotForm).BeginButton.Text = "Разложить";
                            (obj as TarotForm).SameCardsCheckbox.Text = "Разрешить вытягивание одинаковых карт в раскладе";
                            (obj as TarotForm).ShowCardsCheckbox.Text = "Показывать карты во время перемешивания";
                            (obj as TarotForm).MaximizedLayoutWindow.Text = "Большое окно расклада";
                            (obj as TarotForm).AskQuestionBox.Text = "Задавать вопрос для расклада";
                            (obj as TarotForm).GetUserSeedBox.Text = "Захват движения пользователя для автоперемешивания";
                            (obj as TarotForm).HideTipsBox.Text = "Скрыть значки подсказок";
                            (obj as TarotForm).HiddenLayoutBox.Text = "Расклад рубашкой вверх";
                            (obj as TarotForm).ShakeSpeedBox.Text = "Скорость перебора";
                            (obj as TarotForm).groupBox1.Text = "Перемешивание карт";
                            (obj as TarotForm).radioAuto.Text = "Программно";
                            (obj as TarotForm).radioManual.Text = "Вручную";
                            (obj as TarotForm).UpsideDownCardsBox.Text = "Перевернутые карты";
                            (obj as TarotForm).DescriptionOverrideLabel.Text = "Заменить толкования всех колод на";
                            (obj as TarotForm).DidYouKnowButton.Text = "Знаете ли Вы, что...";
                            (obj as TarotForm).StatisticsHelpLabel.Text = "Двойной клик откроет результат расклада";
                            (obj as TarotForm).ClearStatisticsButton.Text = "Очистить";
                            (obj as TarotForm).NullOwnerBox.Text = "Доступна для редактирования всем";
                            (obj as TarotForm).UpDownBox.Text = "Карты могут быть перевернутыми";
                            (obj as TarotForm).CopyrightBox.Text = "Авторские права и источники";
                            (obj as TarotForm).AuthorBox.Text = "Автор";
                        }

                        if (obj is ProjectForms.DeckComparer)
                        {
                            (obj as ProjectForms.DeckComparer).Text = "Сравнение колод";

                            (obj as ProjectForms.DeckComparer).LeftDeckBox.Text = "Первая колода";
                            (obj as ProjectForms.DeckComparer).RightDeckBox.Text = "Вторая колода";
                            (obj as ProjectForms.DeckComparer).label1.Text = "Выбранная колода";
                            (obj as ProjectForms.DeckComparer).label2.Text = "Выбранная колода";
                            (obj as ProjectForms.DeckComparer).LeftSyncBox.Text = "Синхронно";
                            (obj as ProjectForms.DeckComparer).RightSyncBox.Text = "Синхронно";
                            (obj as ProjectForms.DeckComparer).LeftLogoButton.Text = "Обложка";
                            (obj as ProjectForms.DeckComparer).RightLogoButton.Text = "Обложка";
                            (obj as ProjectForms.DeckComparer).LeftBackButton.Text = "Рубашка";
                            (obj as ProjectForms.DeckComparer).RightBackButton.Text = "Рубашка";
                            (obj as ProjectForms.DeckComparer).LeftPictureTab.Text = "Изображение";
                            (obj as ProjectForms.DeckComparer).RightPictureTab.Text = "Изображение";
                            (obj as ProjectForms.DeckComparer).LeftDescriptionTab.Text = "Описание";
                            (obj as ProjectForms.DeckComparer).RightDescriptionTab.Text = "Описание";
                        }

                        if (obj is DeckView)
                        {
                            (obj as DeckView).Text = "Просмотр колоды";
                            (obj as DeckView).ShowDeckDescriptionButton.Text = "Показать описание колоды";
                            (obj as DeckView).ShowOtherDeckLabel.Text = "Посмотреть другие колоды:";
                            (obj as DeckView).DemoCheckbox.Text = "Листать автоматически";
                            (obj as DeckView).ShuffleBox.Text = "Вразброс";
                            (obj as DeckView).DemoCheckboxDeck.Text = "Менять колоды";
                            (obj as DeckView).SpeedLabel.Text = "Скорость:";
                        }

                        if (obj is ProjectForms.EventLog)
                        {
                            (obj as ProjectForms.EventLog).Text = "Просмотр событий";
                            (obj as ProjectForms.EventLog).ClearLogButton.Text = "Очистить все до последнего месяца";
                            (obj as ProjectForms.EventLog).CancelClearing.Text = "Отменить очищение";
                        }

                        if (obj is ProjectForms.KnowlegeBase)
                        {
                            (obj as ProjectForms.KnowlegeBase).Text = "База знаний";
                            (obj as ProjectForms.KnowlegeBase).SelectionGroup.Text = "Содержание";
                            (obj as ProjectForms.KnowlegeBase).DisplayGroup.Text = "Выбранная статья";
                        }

                        if (obj is LargeImage)
                        {
                            (obj as LargeImage).Text = "Кнопки мыши - изменить масштаб";
                        }

                        if (obj is LayoutForm)
                        {
                            (obj as LayoutForm).Text = "Расклад";
                        }

                        if (obj is LayoutResult)
                        {
                            (obj as LayoutResult).Text = "Результат расклада";
                            (obj as LayoutResult).PreviousButton.Text = "< Предыдущая";
                            (obj as LayoutResult).NextButton.Text = "Следующая >";
                            (obj as LayoutResult).CommentButton.Text = "Комментарий";
                        }

                        if (obj is MainWindow)
                        {
                        }

                        break;
                    }
                case Languages.Eng:
                    {
                        if (obj is TarotForm)
                        {
                            
                        }

                        break;
                    }

                default:
                    {
                        break;
                    }
            }
        }
    }
}
