using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using AForge.Video.FFMPEG;
using System.Drawing.Imaging;

namespace Spiral
{
    public partial class Form1 : Form
    {

        private double 
            //Theata is the angle that is currently being graphed
            theata = .095, 
            //Radius is the radius of the circle for the point
            radius,
            //rate is the speed at which the radius increases lower rate means tighter spiral
            rate=.001,
            //counter is a variable used to make the spiral spin by offseting theata
            counter=0,
            
            currentCachLoc=0
            ;
            
            int randomSeed=0;


        private bool SlowRender=false, cached = true, updateCacheNeeded=true,save=false;
        private int 
            //Starts are where the spiral starts and are later set to the middle of the form
            START_X = 0, START_Y = 0;
        //typed is a string of typed chars that the user has typed on the form
        private String typed = "";
       // image is currently a work in progress to move the rendering of the spiral to a different thread
        private Image image =null;
        private BackgroundWorker worker = null;
       private List<Color> colors = new List<Color>();
       private List<Image> cache = new List<Image>(360);
      

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            image = new Bitmap(Height, Width);
            START_X = image.Width / 2;
            START_Y = image.Height / 2;

            foreach (var colorValue in Enum.GetValues(typeof(KnownColor)))
                colors.Add(Color.FromKnownColor((KnownColor)colorValue));
            worker = new BackgroundWorker();
            worker.DoWork += worker_DoWork;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            worker.RunWorkerAsync();
            timer2.Start();
           // save("1");
            rate = .01;
            //save("10");
            rate = .05;
         //   save("50");
            //rate = .0005;
            //save("WOW");
          
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Refresh();
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            redraw();
        }

        public void redraw()
        {
            try
            {
                Graphics g = Graphics.FromImage(image);
                theata = .1; radius = 0;
                g.Clear(Color.Black);

                int x, y;
                //the starts are set to the middle of the form

                //while the radius within the form draw the next point
                while (radius < Math.Sqrt(START_X * START_X + START_Y * START_Y) )
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
                    g.FillRectangle(new SolidBrush(getRandomColors()), x, y,1, 1);
                    if (SlowRender)
                    {
                        Invalidate();
                        Thread.Sleep(50);
                    }

                }

                //any text the user has typed is drawn on the form
                g.DrawString(typed, new Font(new FontFamily("Arial"), 12.0f, FontStyle.Underline), Brushes.Blue, new Point(3, 3));
                //theata and radius are reset so that they can be used the next time the form must be rendered

                theata = .1; radius = 0;
            }
            catch { }
        }


        private void genCache()
        {
            cache.Clear();
            for (int i = 0; i < 360; i++)
            {
                Image temp = new Bitmap(Height, Width,System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                Console.WriteLine(i+"  "+rate);
                try
                {
                    Graphics g = Graphics.FromImage(temp);
                    theata = .1; radius = 0;
                    g.Clear(Color.Black);

                    int x, y;
                    //the starts are set to the middle of the form

                    //while the radius within the form draw the next point
                    while (radius < Math.Sqrt(START_X * START_X + START_Y * START_Y))
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
                        g.FillRectangle(new SolidBrush(getRandomColors()), x, y, 1, 1);
                        if (SlowRender)
                        {
                            Invalidate();
                            Thread.Sleep(50);
                        }

                    }

                    //any text the user has typed is drawn on the form
                    g.DrawString(typed, new Font(new FontFamily("Arial"), 12.0f, FontStyle.Underline), Brushes.Blue, new Point(3, 3));
                    //theata and radius are reset so that they can be used the next time the form must be rendered

                    theata = .1; radius = 0;
                }
                catch { }
                counter++;
                cache.Add(temp);
            }
            updateCacheNeeded = false;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //counter is incermented by the rate then made a factor of 360 which causes the spiral to spin
            //then the form is repainted 
            if (cached) 
            {
                if (updateCacheNeeded)
                {
                    
                        genCache();
                        image = cache[(int)(currentCachLoc % 360)];
                        currentCachLoc++;
                        Refresh();
                    
                }
                else
                {
                    image = cache[(int)(currentCachLoc % 360)];
                    currentCachLoc++;
                    Refresh();
                    if(save)
                    image.Save(currentCachLoc + ".png", ImageFormat.Png);
                }
            }
            else
            {
                if (!worker.IsBusy)
                {
                    counter += rate;
                    counter = counter % 360;
                    if(save)
                    image.Save(counter + ".png", ImageFormat.Png);
                    worker.RunWorkerAsync();

                }
                else
                    Refresh();
            }
        }
        

        private void Form1_Resize(object sender, EventArgs e)
        {
            image = new Bitmap(Width,Height );
            START_X = image.Width / 2;
            START_Y = image.Height / 2;
            //when the form is resized it is repainted
            this.Refresh();
            if (cached)
                updateCacheNeeded = true;
            else
            {
                worker.RunWorkerAsync();
            }
        }

       

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.Equals(Keys.Control)){
                
                if (this.FormBorderStyle.Equals(FormBorderStyle.None))
                    this.FormBorderStyle = FormBorderStyle.Sizable;
                else
                    FormBorderStyle = FormBorderStyle.None;
                Debug.WriteLine("f!! was pressed");
            }
            if (e.KeyChar.Equals((char)8)&&typed.Length>0)
            {
                typed = typed.Substring(0, typed.Length - 1);
            }
            else
            {
                //when the user types a char it is stored then the form is repainted
                typed += e.KeyChar;
            }
            Refresh();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Left))
            {
                //when the mouse is clicked on the form the timer's state is inverted starting or stoping the spin of the spiral
                if (timer1.Enabled)
                {
                    timer1.Stop();
                    Cursor.Show();
                    
                }
                else
                {
                    timer1.Start();
                   // Cursor.Hide();
                }
                //if (shouldContinue)
                //    shouldContinue = false;
                //else if (!shouldContinue)
                //    shouldContinue = true;
            }
            else
            {
                // timer1.Interval -= 10;

                contextMenuStrip1.Show(Cursor.Position);
            }
        }


        public Color getRandomColors()
        {
            randomSeed++;
           

            return colors[new Random(randomSeed).Next(colors.Count)];
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(image, new Point(0, 0));
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            //if (timer1.Interval > 11) ;
            //timer1.Interval -= 10;
        }

        private void msToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }

        private void msToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
        }

        private void msToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 50;
        }

        private void msToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            timer1.Interval = 28;
        }

        private void msToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            timer1.Interval = 10;
        }

        private void msToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            timer1.Interval = 5;
        }

        private void msToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
        }

        private void yesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SlowRender = true;
        }

        private void noToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SlowRender = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cached)
                updateCacheNeeded = true;
            else
            {
                START_X = image.Width / 2;
                START_Y = image.Height / 2;
                worker.RunWorkerAsync();
            }
        }

        private void fullscreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormBorderStyle != FormBorderStyle.None)
            {
                FormBorderStyle = FormBorderStyle.None;
                

            }
            else
                FormBorderStyle = FormBorderStyle.Sizable;

            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void tightenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double acceration = rate / 10;
            rate -= acceration;
        }

        private void losenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double acceration = rate / 10;
            rate += acceration;
        }

        private void rediculoseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rate = .00005;
            cached = false;
            cacheToolStripMenuItem.Checked = false;
        }

        private void saveToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            save  = saveToolStripMenuItem.Checked;
        }

        private void cacheToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            cached = cacheToolStripMenuItem.Checked;
        }

        //public void save(string name)
        //{
        //    int width = 1920;
        //    int height = 1080;
        //    VideoFileWriter writer = new VideoFileWriter();
        //    writer.Open(name+".avi", width, height, 30, VideoCodec.Raw);
        //    // write 1000 video frames
        //    for (int i = 0; i < 5000; i++)
        //    {
        //        Bitmap temp = new Bitmap(width, height);
        //        Console.WriteLine(i + "  " + rate);
        //        try
        //        {
        //            Graphics g = Graphics.FromImage(temp);
        //            theata = .1; radius = 0;
        //            g.Clear(Color.Black);

        //            int x, y;
        //            //the starts are set to the middle of the form

        //            //while the radius within the form draw the next point
        //            while (radius < Math.Sqrt((height / 2) * (height / 2) + (width / 2) * (width / 2)))
        //            {
        //                //theata must be incrimented at a decreasing rate so that the spiral points are closer together as the spiral expands
        //                theata += 1 / theata;
        //                //radius is incrimented by the rate
        //                radius += rate;

        //                //using knolage of the unit circle cosin is the x corrdante of a angle and sine is the y corrdanate so given those
        //                //points a unit circle is graphed but streched in varable areas based of the 'radius' and then dipalced relitive to
        //                //the center
        //                x = (int)(Math.Cos(theata + counter) * radius) + (width / 2);
        //                y = (int)(Math.Sin(theata + counter) * radius) + (height / 2);

        //                //once the point has been found a rectangle of either 1x1 or 3x3 depending on the required visablilty
        //                g.FillRectangle(new SolidBrush(getRandomColors()), x, y, 1, 1);
                       

        //            }

        //            //theata and radius are reset so that they can be used the next time the form must be rendered

        //            theata = .1; radius = 0;
        //            GC.Collect();
        //        }
        //        catch { }
        //        counter++;
        //        writer.WriteVideoFrame(temp);
        //    }
        //    writer.Close();
        //}


    }


}
