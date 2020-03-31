using System.Collections.Generic;

namespace Snake
{
    class VerticalLine
    {
        private List<Point> pList;

        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yDown; y < yUp; y++)
            {
                var p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Draw()
        {
            foreach (var i in pList)
            {
                i.Draw();
            }
        }
    }
}