using System.Collections.Generic;

namespace Snake
{
    class HorizontalLine
    {
        private List<Point> pList;

        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x < xRight; x++)
            {
                var p = new Point(x,y,sym);
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
