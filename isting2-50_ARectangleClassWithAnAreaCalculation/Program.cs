using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_50_ARectangleClassWithAnAreaCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            var rec = new Rectangle(14, 24);

            Console.WriteLine(rec.Area);
        }

        class Rectangle
        {
            public Rectangle(int width, int height)
            {
                Width = width;
                Height = height;
            }

            public virtual int Height { get; set; }
            public virtual int Width { get; set; }

            public int Area
            {
                get { return Height * Width; }
            }
        }
    }
}
