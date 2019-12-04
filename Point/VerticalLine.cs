using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class VerticalLine : Figure
    {
        

        public VerticalLine(int yTop, int yBot, int x, string symbol)
        {
            pointList = new List<Point>();

            for (int i = yTop; i <= yBot; i++)
            {
                Point newPoint = new Point(x, i, symbol);
                pointList.Add(newPoint);

            }
        }
        public void DrawVerticalLine()
        {
            foreach (Point point in pointList)
            {
                point.Draw();
            }

        }
    }
}
