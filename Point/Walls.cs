using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{

    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            HorizontalLine topLine = new HorizontalLine(0, mapWidth - 2, 0, "_");
            HorizontalLine bottomLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, "_");
            VerticalLine leftLine = new VerticalLine(1, mapHeight-1, 0, "|");
            VerticalLine rightLine = new VerticalLine(1, mapHeight-1, mapWidth - 2, "|");
            wallList.Add(topLine);
            wallList.Add(bottomLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);

            //Random rndd = new Random();
           
                
          



        }

        public void DrawWalls()
        {
           foreach(Figure wall in wallList)
            {
            wall.DrawFigure();
            }

        }


        public bool IsHitByFigure(Figure figure)
        {
            foreach(Figure wall in wallList)
            {
                if(wall.IsHitByFigure(figure))
                {
                    return true;
                }
            }
            return false;
        }
        
      /*  public void DrawObstacles()
        {
            foreach(Figure wall in wallList)
            {
                wall.DrawFigure();
            }
        }
        */


   }

}

    











       


           

    
    
         

            

        





