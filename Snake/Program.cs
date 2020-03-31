using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
           // var p2 = new Point(4,5,'#');

            var upLine = new HorizontalLine(0,78,0,'+');
            var downLine = new HorizontalLine(0,78,24,'+');

            var leftLine = new VerticalLine(0,24,0, '+');
            var rightLine = new VerticalLine(0,24,78, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            var p1 = new Point(1, 3, '*');
            p1.Draw();
            Console.ReadLine();
        }
    }
}
