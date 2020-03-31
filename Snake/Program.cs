using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(1,3,'*');
            var p2 = new Point(4,5,'#');

            HorizontalLine line = new HorizontalLine(5,10,8,'#');
            line.Draw();
            var vLine = new VerticalLine(10,5,0, '*');
            vLine.Draw();
            Console.ReadLine();
        }
    }
}
