using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            plist = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x,y,sym);
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
