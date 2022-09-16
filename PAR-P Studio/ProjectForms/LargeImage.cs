using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PAR_P_Studio.ProjectForms;
using PAR_P_Studio.ProjectClasses;

//Окно, позволяющее просмотреть изображение элемента в увеличенном виде
//© Владимир Андреев, PAR-P Corp.

namespace PAR_P_Studio
{
    public partial class LargeImage : Form
    {
        Image image;
        int scale = 1;
        public LargeImage(Image img)
        {
            InitializeComponent();
            this.Height = img.Height+50;
            this.Width = img.Width+50;
            image = img;
            DrawingPanel.AutoScroll = true;
            DrawingPanel.AutoScrollMinSize = new Size(img.Size.Width, img.Size.Height);
            DrawingPanel.Invalidate();
        }
        void SetColors()
        {
            this.BackColor = StaticParams.CurrentUser.UserSettings.WinColor;
            DrawingPanel.BackColor = StaticParams.CurrentUser.UserSettings.WinColor;
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawingPanel.AutoScrollMinSize = new Size(image.Size.Width*scale, image.Size.Height*scale);
            e.Graphics.DrawImage(image, DrawingPanel.AutoScrollPosition.X, DrawingPanel.AutoScrollPosition.Y,
                image.Size.Width*scale, image.Size.Height*scale);
        }

        private void DrawingPanel_Scroll(object sender, ScrollEventArgs e)
        {
            DrawingPanel.Invalidate();
        }

        private void DrawingPanel_Resize(object sender, EventArgs e)
        {
            DrawingPanel.Invalidate();
        }

        private void DrawingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                scale++;
            }
            if (e.Button == MouseButtons.Right)
            {
                if (scale > 1)
                    scale--;
            }
            if (e.Button == MouseButtons.Middle)
                scale = 1;
            DrawingPanel.Invalidate();
        }

        private void LargeImage_Shown(object sender, EventArgs e)
        {
            SetColors();
        }
    }
}
