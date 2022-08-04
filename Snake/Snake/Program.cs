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
            Point p1 = new Point(14, 14, '%');  
            p1.Draw();

            List<int> numList = new List<int>();
            numList.Add(12);
            numList.Add(234);
            numList.Add(7);
            List<Point> pointList = new List<Point>();
            pointList.Add(p1);
            pointList.Add(p1);
            pointList.Add(p1);
            foreach(Point alex in pointList)
            {
                Console.WriteLine(alex);
            }
            Console.ReadLine();
        }
    }
}
