using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Структура типа расклада
//© Владимир Андреев, PAR-P Corp.

namespace PAR_P_Studio
{
    [Serializable]
    public class LayoutType : IComparable
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        public bool FreeAccess { get; set; }
        public List<CardPos> CardPositions { get; set; }

        public void SaveLayout()
        {
            string filename = "Data\\Layouts\\" + Name + ".lyt";
            FileStream LayoutFile = new FileStream(filename, FileMode.Create, FileAccess.Write);
            BinaryFormatter LayoutFormatter = new BinaryFormatter();
            LayoutFormatter.Serialize(LayoutFile, this);
            LayoutFile.Close();
        }
        int IComparable.CompareTo(object obj)
        {
            LayoutType temp = obj as LayoutType;
            if (temp != null)
                return string.Compare(this.Name, temp.Name);
            else
                throw new ArgumentException("Parameter is not a Layout!");
        }


        public LayoutType(string name, string description)
        {
            Name = name;
            Description = description;
            Owner = StaticParams.CurrentUser.Login;
            FreeAccess = false;
            CardPositions = new List<CardPos>();
        }
        public LayoutType()
        {
            Name = "";
            Description = "";
            Owner = StaticParams.CurrentUser.Login;
            FreeAccess = false;
            CardPositions = new List<CardPos>();
        }
        public LayoutType(LayoutType LayoutObj)
        {
            Name = LayoutObj.Name;
            Description = LayoutObj.Description;
            Owner = LayoutObj.Owner;
            FreeAccess = LayoutObj.FreeAccess;
            CardPositions = new List<CardPos>();
            foreach (CardPos item in LayoutObj.CardPositions)
                CardPositions.Add(item);
        }
        [Serializable]
        public class CardPos
        {
            Image CardIcon = Properties.Resources.CardIcon;

            const int DEFAULT_WIDTH = 33;
            const int DEFAULT_HEIGHT = 46;
            const int DEFAULT_ANGLE = 0;
            const int DEFAULT_NUMBER_POS = 0;

            public int X { get; set; }
            public int Y { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
            public int Angle { get; set; }
            public int Number { get; set; }
            public int CardLink { get; set; }
            public string Description { get; set; }
            public int NumberPos { get; set; }

            public CardPos(int x, int y, int number, string description)
            {
                this.X = x;
                this.Y = y;
                this.Height = DEFAULT_HEIGHT;
                this.Width = DEFAULT_WIDTH;
                this.Angle = DEFAULT_ANGLE;
                this.Number = number;
                this.CardLink = -1;
                this.Description = description;
                this.NumberPos = DEFAULT_NUMBER_POS;
            }
            public Size Size
            {
                get { return new Size(Width, Height); }
            }

            public Point Location
            {
                get { return new Point(X, Y); }
            }   

            public void Draw(Graphics g)
            {
                Bitmap img = new Bitmap(CardIcon);
                if (Angle > 315)
                    Angle = 0;
                if (Angle < 0)
                    Angle = 315;
                img = Drawing.RotateImg(img, Angle, Color.Transparent);

                #region switch (Angle)
                switch (Angle)
                {
                    case 0:
                        {
                            Width = DEFAULT_WIDTH;
                            Height = DEFAULT_HEIGHT;
                            break;
                        }
                    case 45:
                        {
                            Height = DEFAULT_HEIGHT + 1;
                            Width = Height;
                            break;
                        }
                    case 90:
                        {
                            Width = DEFAULT_HEIGHT;
                            Height = DEFAULT_WIDTH;
                            break;
                        }
                    case 135:
                        {
                            Height = DEFAULT_HEIGHT + 1;
                            Width = Height;
                            break;
                        }
                    case 180:
                        {
                            Width = DEFAULT_WIDTH;
                            Height = DEFAULT_HEIGHT;
                            break;
                        }
                    case 225:
                        {
                            Height = DEFAULT_HEIGHT + 1;
                            Width = Height;
                            break;
                        }
                    case 270:
                        {
                            Width = DEFAULT_HEIGHT;
                            Height = DEFAULT_WIDTH;
                            break;
                        }
                    case 315:
                        {
                            Width = DEFAULT_HEIGHT + 1;
                            Height = Width;
                            break;
                        }

                }
                #endregion

                g.DrawImage(img, X, Y, Width, Height);
                #region switch (NumberPos)
                switch (NumberPos)
                {
                    case 0:
                        {
                            g.DrawString(Number.ToString(), SystemFonts.DefaultFont, SystemBrushes.WindowText, new Point(X, Y + Height));
                            break;
                        }
                    case 1:
                        {
                            g.DrawString(Number.ToString(), SystemFonts.DefaultFont, SystemBrushes.WindowText, new Point(X-10, Y+Height/2));
                            break;
                        }
                    case 2:
                        {
                            g.DrawString(Number.ToString(), SystemFonts.DefaultFont, SystemBrushes.WindowText, new Point(X, Y - 10));
                            break;
                        }
                    case 3:
                        {
                            g.DrawString(Number.ToString(), SystemFonts.DefaultFont, SystemBrushes.WindowText, new Point(X+Width/2, Y - 10));
                            break;
                        }
                    case 4:
                        {
                            g.DrawString(Number.ToString(), SystemFonts.DefaultFont, SystemBrushes.WindowText, new Point(X+Width, Y));
                            break;
                        }
                    case 5:
                        {
                            g.DrawString(Number.ToString(), SystemFonts.DefaultFont, SystemBrushes.WindowText, new Point(X+Width, Y + Height/2));
                            break;
                        }
                    case 6:
                        {
                            g.DrawString(Number.ToString(), SystemFonts.DefaultFont, SystemBrushes.WindowText, new Point(X+Width, Y + Height));
                            break;
                        }
                    case 7:
                        {
                            g.DrawString(Number.ToString(), SystemFonts.DefaultFont, SystemBrushes.WindowText, new Point(X + Width / 3, Y + Height / 3));
                            break;
                        }
                }
                #endregion




            }
            public void Draw(Graphics g, Image img)
            {
                g.DrawImage(img, X, Y, Width, Height);
                #region switch (NumberPos)
                switch (NumberPos)
                {
                    case 0:
                        {
                            g.DrawString(Number.ToString(), SystemFonts.DefaultFont, SystemBrushes.WindowText, new Point(X, Y + Height));
                            break;
                        }
                    case 1:
                        {
                            g.DrawString(Number.ToString(), SystemFonts.DefaultFont, SystemBrushes.WindowText, new Point(X - 10, Y + Height / 2));
                            break;
                        }
                    case 2:
                        {
                            g.DrawString(Number.ToString(), SystemFonts.DefaultFont, SystemBrushes.WindowText, new Point(X, Y - 10));
                            break;
                        }
                    case 3:
                        {
                            g.DrawString(Number.ToString(), SystemFonts.DefaultFont, SystemBrushes.WindowText, new Point(X + Width / 2, Y - 10));
                            break;
                        }
                    case 4:
                        {
                            g.DrawString(Number.ToString(), SystemFonts.DefaultFont, SystemBrushes.WindowText, new Point(X + Width, Y));
                            break;
                        }
                    case 5:
                        {
                            g.DrawString(Number.ToString(), SystemFonts.DefaultFont, SystemBrushes.WindowText, new Point(X + Width, Y + Height / 2));
                            break;
                        }
                    case 6:
                        {
                            g.DrawString(Number.ToString(), SystemFonts.DefaultFont, SystemBrushes.WindowText, new Point(X + Width, Y + Height));
                            break;
                        }
                }
                #endregion
            }

            public void Draw(Graphics g, int scroll_x, int scroll_y)
            {
                Bitmap img = new Bitmap(CardIcon);
                if (Angle > 315)
                    Angle = 0;
                if (Angle < 0)
                    Angle = 315;
                img = Drawing.RotateImg(img, Angle, Color.Transparent);

                #region switch (Angle)
                switch (Angle)
                {
                    case 0:
                        {
                            Width = DEFAULT_WIDTH;
                            Height = DEFAULT_HEIGHT;
                            break;
                        }
                    case 45:
                        {
                            Height = DEFAULT_HEIGHT + 1;
                            Width = Height;
                            break;
                        }
                    case 90:
                        {
                            Width = DEFAULT_HEIGHT;
                            Height = DEFAULT_WIDTH;
                            break;
                        }
                    case 135:
                        {
                            Height = DEFAULT_HEIGHT + 1;
                            Width = Height;
                            break;
                        }
                    case 180:
                        {
                            Width = DEFAULT_WIDTH;
                            Height = DEFAULT_HEIGHT;
                            break;
                        }
                    case 225:
                        {
                            Height = DEFAULT_HEIGHT + 1;
                            Width = Height;
                            break;
                        }
                    case 270:
                        {
                            Width = DEFAULT_HEIGHT;
                            Height = DEFAULT_WIDTH;
                            break;
                        }
                    case 315:
                        {
                            Width = DEFAULT_HEIGHT + 1;
                            Height = Width;
                            break;
                        }

                }
                #endregion

                g.DrawImage(img, X + scroll_x, Y + scroll_y, Width, Height);

                #region switch (NumberPos)
                switch (NumberPos)
                {
                    case 0:
                        {
                            g.DrawString(Number.ToString(), SystemFonts.DefaultFont, SystemBrushes.WindowText,
                                new Point(X + scroll_x, Y + scroll_y + Height));
                            break;
                        }
                    case 1:
                        {
                            g.DrawString(Number.ToString(), SystemFonts.DefaultFont, SystemBrushes.WindowText, 
                                new Point(X + scroll_x - 10, Y + scroll_y + Height / 2));
                            break;
                        }
                    case 2:
                        {
                            g.DrawString(Number.ToString(), SystemFonts.DefaultFont, SystemBrushes.WindowText, 
                                new Point(X + scroll_x, Y + scroll_y - 10));
                            break;
                        }
                    case 3:
                        {
                            g.DrawString(Number.ToString(), SystemFonts.DefaultFont, SystemBrushes.WindowText, 
                                new Point(X + scroll_x + Width / 2, Y + scroll_y - 10));
                            break;
                        }
                    case 4:
                        {
                            g.DrawString(Number.ToString(), SystemFonts.DefaultFont, SystemBrushes.WindowText, 
                                new Point(X + scroll_x + Width, Y + scroll_y));
                            break;
                        }
                    case 5:
                        {
                            g.DrawString(Number.ToString(), SystemFonts.DefaultFont, SystemBrushes.WindowText, 
                                new Point(X + scroll_x + Width, Y + scroll_y + Height / 2));
                            break;
                        }
                    case 6:
                        {
                            g.DrawString(Number.ToString(), SystemFonts.DefaultFont, SystemBrushes.WindowText, 
                                new Point(X + scroll_x + Width, Y + scroll_y + Height));
                            break;
                        }
                    case 7:
                        {
                            g.DrawString(Number.ToString(), SystemFonts.DefaultFont, SystemBrushes.WindowText,
                                new Point(X + scroll_x + Width / 3, Y + scroll_y + Height / 3));
                            break;
                        }
                }
                #endregion
            }

            public void Draw(Graphics g, int scroll_x, int scroll_y, Bitmap CardImage)
            {
                Bitmap img = new Bitmap(CardImage);
                if (Angle > 315)
                    Angle = 0;
                if (Angle < 0)
                    Angle = 315;
                img = Drawing.RotateImg(img, Angle, Color.Transparent);

                #region switch (Angle)
                switch (Angle)
                {
                    case 0:
                        {
                            Width = DEFAULT_WIDTH;
                            Height = DEFAULT_HEIGHT;
                            break;
                        }
                    case 45:
                        {
                            Height = DEFAULT_HEIGHT + 1;
                            Width = Height;
                            break;
                        }
                    case 90:
                        {
                            Width = DEFAULT_HEIGHT;
                            Height = DEFAULT_WIDTH;
                            break;
                        }
                    case 135:
                        {
                            Height = DEFAULT_HEIGHT + 1;
                            Width = Height;
                            break;
                        }
                    case 180:
                        {
                            Width = DEFAULT_WIDTH;
                            Height = DEFAULT_HEIGHT;
                            break;
                        }
                    case 225:
                        {
                            Height = DEFAULT_HEIGHT + 1;
                            Width = Height;
                            break;
                        }
                    case 270:
                        {
                            Width = DEFAULT_HEIGHT;
                            Height = DEFAULT_WIDTH;
                            break;
                        }
                    case 315:
                        {
                            Width = DEFAULT_HEIGHT + 1;
                            Height = Width;
                            break;
                        }

                }
                #endregion

                g.DrawImage(img, X + scroll_x, Y + scroll_y, Width, Height);

                #region switch (NumberPos)
                switch (NumberPos)
                {
                    case 0:
                        {
                            g.DrawString(Number.ToString(), SystemFonts.DefaultFont, SystemBrushes.WindowText,
                                new Point(X + scroll_x, Y + scroll_y + Height));
                            break;
                        }
                    case 1:
                        {
                            g.DrawString(Number.ToString(), SystemFonts.DefaultFont, SystemBrushes.WindowText,
                                new Point(X + scroll_x - 10, Y + scroll_y + Height / 2));
                            break;
                        }
                    case 2:
                        {
                            g.DrawString(Number.ToString(), SystemFonts.DefaultFont, SystemBrushes.WindowText,
                                new Point(X + scroll_x, Y + scroll_y - 10));
                            break;
                        }
                    case 3:
                        {
                            g.DrawString(Number.ToString(), SystemFonts.DefaultFont, SystemBrushes.WindowText,
                                new Point(X + scroll_x + Width / 2, Y + scroll_y - 10));
                            break;
                        }
                    case 4:
                        {
                            g.DrawString(Number.ToString(), SystemFonts.DefaultFont, SystemBrushes.WindowText,
                                new Point(X + scroll_x + Width, Y + scroll_y));
                            break;
                        }
                    case 5:
                        {
                            g.DrawString(Number.ToString(), SystemFonts.DefaultFont, SystemBrushes.WindowText,
                                new Point(X + scroll_x + Width, Y + scroll_y + Height / 2));
                            break;
                        }
                    case 6:
                        {
                            g.DrawString(Number.ToString(), SystemFonts.DefaultFont, SystemBrushes.WindowText,
                                new Point(X + scroll_x + Width, Y + scroll_y + Height));
                            break;
                        }
                }
                #endregion
            }

            void SwapDimensions()
            {
                int temp;
                temp = this.Width;
                this.Width = this.Height;
                this.Height = temp;
            }

        }
    }
}
