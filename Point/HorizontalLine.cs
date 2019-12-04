using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
   
    class HorizontalLine : Figure
    {
        

        public HorizontalLine(int xLeft, int xRight, int y, string symbol)
        {
            pointList = new List<Point>();


            for(int i = xLeft; i <= xRight; i++)
            {
                Point newPoint = new Point(i, y, symbol);
                pointList.Add(newPoint);

            }

        }

        public void DrawHorizontalLine()
        {
            foreach(Point point in pointList)
            {
                point.Draw();
            }
        }

    }
}
