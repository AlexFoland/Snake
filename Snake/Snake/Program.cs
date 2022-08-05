using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizontalLine line = new HorizontalLine(5,10,8,'+');
            VerticalLine lineV = new VerticalLine(0, 10, 14, '+');
            line.DrawHorizontalLine();
            lineV.DrawVerticalLine();

            Point p = new Point(4, 5, '$');
            Console.ReadLine();
        }
    }
}
