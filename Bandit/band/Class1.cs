using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;

namespace band
{
    class Class1
    {

       public void Main(string[] args)
        {
            Random rnd = new Random();
            string[] file = new string[10];
            file[0] = "c:\\1/1.png";
            file[1] = "c:\\1/2.png";
            file[2] = "c:\\1/3.png";
            file[3] = "c:\\1/4.png";
            file[4] = "c:\\1/5.png";
            file[5] = "c:\\1/6.png";
            file[6] = "c:\\1/7.png";
            file[7] = "c:\\1/8.png";
            file[8] = "c:\\1/9.png";
            file[9] = "c:\\1/10.png";
            int y, m, v;
            for (int i = 0; i < 7; i++, Thread.Sleep(50))
            {
                y = rnd.Next(0, 10);
                m = rnd.Next(0, 10);
                v = rnd.Next(0, 10);
                var bmp = new Bitmap(Image.FromFile(file[y]), new Size(100, 100));
                var bmp1 = new Bitmap(Image.FromFile(file[m]), new Size(100, 100));
                var bmp2 = new Bitmap(Image.FromFile(file[v]), new Size(100, 100));
              
                //      System.Threading.Thread.Sleep(50);
            }
        }
    }
}
