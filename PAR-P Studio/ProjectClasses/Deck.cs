using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Структура колоды
//© Владимир Андреев, PAR-P Corp.

namespace PAR_P_Studio
{
    [Serializable]
    public class Deck : IComparable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        public string Copyright { get; set; }
        public Image Logo { get; set; }
        public Image Back { get; set; }
        public Image AuthorImage { get; set; }
        public bool FreeAccess { get; set; }
        public bool AllowUpsideDown { get; set; }
        public List<Deck.card> Cards { get; set; }

        public void SaveDeck()
        {
            string filename = "Data//Decks//" + Name + ".dck";
            FileStream DeckFile = new FileStream(filename, FileMode.Create, FileAccess.Write);
            BinaryFormatter DeckFormatter = new BinaryFormatter();
            DeckFormatter.Serialize(DeckFile, this);
            DeckFile.Close();
        }
        public void SaveDeckAs(string FullPath)
        {
            FileStream DeckFile = new FileStream(FullPath, FileMode.Create, FileAccess.Write);
            BinaryFormatter DeckFormatter = new BinaryFormatter();
            DeckFormatter.Serialize(DeckFile, this);
            DeckFile.Close();
        }
        int IComparable.CompareTo(object obj)
        {
            Deck temp = obj as Deck;
            if (temp != null)
                return string.Compare(this.Name, temp.Name);
            else
                throw new ArgumentException("Parameter is not a Deck!");
        }

        public Deck(string name, string description, Image logo, Image back)
        {
            Name = name;
            Description = description;
            Owner = StaticParams.CurrentUser.Login;
            FreeAccess = false;
            AllowUpsideDown = false;
            Copyright = "";
            Logo = logo;
            Back = back;
            AuthorImage = null;
            Cards = new List<Deck.card>();
        }
        public Deck()
        {
            Name = "";
            Cards = new List<Deck.card>();
       }

        public Deck(Deck DeckObj)
        {
            Name = DeckObj.Name;
            Description = DeckObj.Description;
            Owner = DeckObj.Owner;
            FreeAccess = DeckObj.FreeAccess;
            AllowUpsideDown = DeckObj.AllowUpsideDown;
            Copyright = DeckObj.Copyright;
            Logo = DeckObj.Logo;
            Back = DeckObj.Back;
            AuthorImage = DeckObj.AuthorImage;
            Cards = new List<Deck.card>();
            foreach (Deck.card currCard in DeckObj.Cards)
                Cards.Add(new card (currCard));

        }


        [Serializable]
        public class card
        {
            public string CardName {get;set;}
            public string CardDescription {get;set;}
            public Image CardPicture {get;set;}
            public int CardId { get; set; }
            public int CardOrder { get; set; }
            public ForDrawing Place { get; set; }
            public card(string name, string description, Image picture, int id)
            {
                CardName = name;
                CardDescription = description;
                CardPicture = picture;
                CardId=id;
                CardOrder = id;
            }

            public card(card CardObj)
            {
                CardName = CardObj.CardName;
                CardDescription = CardObj.CardDescription;
                CardPicture = CardObj.CardPicture;
                CardId = CardObj.CardId;
                CardOrder = CardObj.CardOrder;
            }

            #region Подкласс объекта, используемого для рисования
            [Serializable]
            public class ForDrawing
            {
                const int DEFAULT_WIDTH = 65;
                const int DEFAULT_HEIGHT = 100;

                public int X { get; set; }
                public int Y { get; set; }
                public int Width { get; set; }
                public int Height { get; set; }
                public bool UpsideDown { get; set; }

                public ForDrawing(int x, int y, bool upsidedown = false)
                {
                    this.X = x;
                    this.Y = y;
                    this.Width = DEFAULT_WIDTH;
                    this.Height = DEFAULT_HEIGHT;
                    this.UpsideDown = upsidedown;
                }


                public Size Size
                {
                    get { return new Size(Width, Height); }
                }

                public Point Location
                {
                    get { return new Point(X, Y); }
                }


            }
            #endregion
        }

    }
}
