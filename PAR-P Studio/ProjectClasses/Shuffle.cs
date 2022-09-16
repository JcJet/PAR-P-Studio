using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Структура сохраненного пользовательского разброса карт. Используется при ручном перемешивании, когда программа не вмешивается в тасование колод
//© Владимир Андреев, PAR-P Corp.

namespace PAR_P_Studio.ProjectClasses
{
    [Serializable]
    public class Shuffle
    {
        public string Owner { get; set; }
        public string DeckName { get; set; }
        public List<CardPosition> Cards { get; set; }

        public void SaveShuffle()
        {
            string filename = "Data\\Shuffles\\" + Owner + "\\" + DeckName + ".sfl";
            if (!Directory.Exists("Data\\Shuffles\\" + Owner + "\\"))
            {
                Directory.CreateDirectory("Data\\Shuffles\\" + Owner + "\\");
            }
            FileStream SflFile = new FileStream(filename, FileMode.Create, FileAccess.Write);
            BinaryFormatter DeckFormatter = new BinaryFormatter();
            DeckFormatter.Serialize(SflFile, this);
            SflFile.Close();
        }


        public Shuffle()
        {
            Owner = StaticParams.CurrentUser.Login;
            DeckName = StaticParams.CurrentDeck.Name;
            Cards = new List<CardPosition>();
        }

        public Shuffle(Shuffle ShuffleObj)
        {
            Owner = ShuffleObj.Owner;
            DeckName = ShuffleObj.DeckName;
            Cards = new List<CardPosition>();
            foreach (CardPosition item in ShuffleObj.Cards)
                Cards.Add(item);
        }
        [Serializable]
        public class CardPosition
        {
            public int CardNumber { get; set; }
            public int CardPos { get; set; }
            public bool UpsideDown { get; set; }

            public CardPosition()
            {
                CardNumber = -1;
                CardPos = -1;
                UpsideDown = false;
            }

            public CardPosition(int CardId, int cardpos, bool upsidedown)
            {
                CardNumber = CardId;
                CardPos = cardpos;
                UpsideDown = upsidedown;
            }

            public CardPosition(CardPosition posObj)
            {
                CardNumber = posObj.CardNumber;
                CardPos = posObj.CardPos;
                UpsideDown = posObj.UpsideDown;
            }
        }
    }
}
