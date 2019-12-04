using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Figure
    {
        protected List<Point> pointList = new List<Point>();



        public void DrawFigure()
        {
            foreach(Point point in pointList)
            {
                point.Draw();
            }

        }

        public bool IsHitByPoint(Point point)
        {
            foreach (Point p in pointList)
            {
                if (p.IsHit(point))
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsHitByFigure(Figure figure)
        {
            foreach (Point point in pointList)
            {
                if (figure.IsHitByPoint(point))
                {
                    return true;
                }
            }
            return false;
        }





    }









}
