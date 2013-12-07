using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Diagnostics;

namespace Spiral
{
   public delegate void RenderEventHandler(object sender, EventArgs e);
    class SpiralMaker
    {
        Image image=null;
        private double theata = .1, radius;
        private int START_X = 0, START_Y = 0;
        private String typed = "";
        public event RenderEventHandler Rendered;
       private double  rate=1,

            //counter is a variable used to make the spiral spin by offseting theata
            counter=0;
        public SpiralMaker(int h,int l)
        {
            image = new Bitmap(l,h);
        }

        protected virtual void OnRendered(EventArgs e)
        {
            if (Rendered != null)
                Rendered(this, e);
        }



        public void redraw()
        {
            Graphics e = Graphics.FromImage(image);
            theata = .1; radius = 0;
            e.Clear(Color.Black);

            int x, y;
            //the starts are set to the middle of the form
            START_X = image.Width / 2;
            START_Y = image.Height / 2;

            //while the radius within the form draw the next point
            while (radius < image.Width / 2 || radius < image.Height / 2)
            {
                //theata must be incrimented at a decreasing rate so that the spiral points are closer together as the spiral expands
                theata += 1 / theata;
                //radius is incrimented by the rate
                radius += rate;

                //using knolage of the unit circle cosin is the x corrdante of a angle and sine is the y corrdanate so given those
                //points a unit circle is graphed but streched in varable areas based of the 'radius' and then dipalced relitive to
                //the center
                x = (int)(Math.Cos(theata + counter) * radius) + START_X;
                y = (int)(Math.Sin(theata + counter) * radius) + START_Y;

                //once the point has been found a rectangle of either 1x1 or 3x3 depending on the required visablilty
                e.FillRectangle(Brushes.White, x, y, 3, 5);
                //if (SlowRender)
                //    Thread.Sleep(50);

            }

            //any text the user has typed is drawn on the form
            e.DrawString(typed, new Font(new FontFamily("Arial"), 12.0f, FontStyle.Underline), Brushes.Blue, new Point(3, 3));
            //theata and radius are reset so that they can be used the next time the form must be rendered
            theata = .1; radius = 0;
            OnRendered(EventArgs.Empty);
        }

        public Image getImage()
        {
            return image;
        }
    }
}
