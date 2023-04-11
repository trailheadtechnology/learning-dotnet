using System;
using System.Drawing; //windows only currently

namespace session_07
{
    public class GraphicsExamples
    {
        public static void Example()
        {
            using (Bitmap bmp = new Bitmap(600, 400))
            {
                using (Graphics gfx = Graphics.FromImage(bmp))
                {
                    gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                    gfx.Clear(Color.Navy);

                    Random rand = new Random();
                    using (Pen pen = new Pen(Color.White))
                    {
                        for (int i = 0; i < 10000; i++)
                        {
                            pen.Color = Color.FromArgb(rand.Next());
                            Point pt1 = new Point(rand.Next(bmp.Width), rand.Next(bmp.Height));
                            Point pt2 = new Point(rand.Next(bmp.Width), rand.Next(bmp.Height));
                            gfx.DrawLine(pen, pt1, pt2);
                        }
                    }

                    bmp.Save("demo.png");
                }
            }


        }
    }
}
