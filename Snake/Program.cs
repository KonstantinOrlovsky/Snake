using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(1,3,'*');
            p1.Draw();

            var p2 = new Point(4,5,'#');
            p2.Draw();

            var pointList = new List<Point>();
            pointList.Add(p1);
            pointList.Add(p2);

            var symbolList = new List<char>();
            symbolList.Add('*');
            symbolList.Add('@');

            Console.ReadLine();
        }
    }
}
