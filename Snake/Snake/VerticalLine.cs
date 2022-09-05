using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
         public VerticalLine(int yTop, int yBottom, int x, char sym)
        {
            plist = new List<Point>();
            for (int y = yTop; y <= yBottom; y++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }
        }
        // override можно использовать если в классе Figure метод с пометкой virtual
        public override void DrawFigure()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            base.DrawFigure();
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
