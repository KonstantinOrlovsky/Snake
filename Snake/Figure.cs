using System.Collections.Generic;

namespace Snake
{
    class Figure
    {
        public List<Point> pList;

        public void Draw()
        {
            foreach (var i in pList)
            {
                i.Draw();
            }
        }
    }
}
