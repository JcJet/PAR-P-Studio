using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

//Поворот изображения на заданный угол с использованием матрицы
//© Владимир Андреев, PAR-P Corp.

namespace PAR_P_Studio
{
    public class Drawing
    {
        public static Bitmap RotateImg(Bitmap bmp, float angle, Color bkColor) //Поворот картинки на заданный угол
        {
            int w = bmp.Width;
            int h = bmp.Height;
            PixelFormat pf = default(PixelFormat);
            if (bkColor == Color.Transparent)
            {
                pf = PixelFormat.Format32bppArgb;
            }
            else
            {
                pf = bmp.PixelFormat;
            }

            Bitmap tempImg = new Bitmap(w, h, pf);
            Graphics g = Graphics.FromImage(tempImg);
            g.Clear(bkColor);
            g.DrawImageUnscaled(bmp, 1, 1);
            g.Dispose();

            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(new RectangleF(0f, 0f, w, h));
            Matrix mtrx = new Matrix();
            // Использование System.Drawing.Drawing2D.Matrix class 
            mtrx.Rotate(angle);
            RectangleF rct = path.GetBounds(mtrx);
            Bitmap newImg = new Bitmap(Convert.ToInt32(rct.Width), Convert.ToInt32(rct.Height), pf);
            g = Graphics.FromImage(newImg);
            g.Clear(bkColor);
            g.TranslateTransform(-rct.X, -rct.Y);
            g.RotateTransform(angle);
            g.InterpolationMode = InterpolationMode.HighQualityBilinear;
            g.DrawImageUnscaled(tempImg, 0, 0);
            g.Dispose();
            tempImg.Dispose();
            return newImg;
        }
        public static string CleanString(string str)// "Чистит" строку от лишних пробелов.
        {
            if (str.Length == 0) return "";
            char[] chars = str.ToCharArray();
            while (chars[0] == ' ')
            {
                str = "";
                for (int i = 1; i < chars.Length - 1; i++)
                    str += chars[i];
                chars = str.ToCharArray();
            }
            while (chars[chars.Length - 1] == ' ')
            {
                str = "";
                for (int i = 0; i < chars.Length - 2; i++)
                    str += chars[i];
                chars = str.ToCharArray();
            }

            char PrevChar = chars[0];
            str = "";
            foreach (char currChar in chars)
            {
                if (!(PrevChar == ' ' && currChar == ' '))
                    str += currChar;
                PrevChar = currChar;
            }
            return str;
        }
        public static string FirstCapital(string str) // Возвращает слово с большой буквы
        {
            if (str.Length == 0) return "";
            char[] chars = str.ToCharArray();
            str = "";
            str += chars[0];
            str = str.ToUpper();
            chars[0] = str[0];
            str = "";
            foreach (char currChar in chars)
                str += currChar;
            return str;
        }
    }
}
