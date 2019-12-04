using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{



    class Toit
    {
        int MapWidth;
        int MapHeight;
        string Symbol;

        Random rnd = new Random();

        public Toit(int _mapWidth, int _mapHeight, string _symbol)
        {
            MapWidth = _mapWidth;
            MapHeight = _mapHeight;
            Symbol = _symbol;
        }


        public Point CaterFood()
        {
            int x = rnd.Next(2, MapWidth - 4);
            int y = rnd.Next(2, MapHeight - 4);
            return new Point(x, y, Symbol);
        }


    }
}
