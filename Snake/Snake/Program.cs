﻿using System;
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
            Console.SetBufferSize(120, 30);
            HorizontalLine upLine = new HorizontalLine(0,78,0,'+');
            HorizontalLine downLine = new HorizontalLine(0,78,24,'+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.DrawHorizontalLine();
            downLine.DrawHorizontalLine();
            leftLine.DrawVerticalLine();
            rightLine.DrawVerticalLine();

            Point p = new Point(4, 5, '*');
            p.Draw();

            Console.ReadLine();
        }
    }
}
