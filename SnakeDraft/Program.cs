using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeDraft
{

    class Point
    {
        public int x;
        public int y;
        public string symbol;

        public Point(int _x, int _y, string _symbol)
        {
            x = _x;
            y = _y;
            symbol = _symbol;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            /*Console.SetWindowSize(25, 25);
            Console.SetBufferSize(25, 25);*/
              Console.BackgroundColor = ConsoleColor.White;
              Console.Clear();
              Console.ForegroundColor = ConsoleColor.Cyan;
            //Declare point coordinates
            /*  int x1 = 26;
              int y1 = 19; 
            string symbol1 = "* *"; */
            Point p1 = new Point(26, 19, "* *");
              p1.Draw();
             /* Console.SetCursorPosition(x1, y1);
              Console.Write(symbol1); */
              int x2 = 29;
              int y2 = 19;
              string symbol2 = "<><";
            // Draw(x2, y2, symbol2);
            Point p2 = new Point(29, 19, "<><");
              p2.Draw();
             /* Console.SetCursorPosition(x2, y2);
              Console.Write(symbol2); */

          /*    int x3 = 23;
              int y3 = 20;
              string symbol3 = "<><";
            Draw(x3, y3, symbol3);
            /*  Console.SetCursorPosition(x3, y3);
              Console.Write(symbol3); */
             /* int x4 = 29;
              int y4 = 21;
              string symbol4 = "<><";
            Draw(x4, y4, symbol4) */
             /* Console.SetCursorPosition(x4, y4);
              Console.Write(symbol4); */
             /* int x5 = 26;
              int y5 = 17;
              string symbol5 = "<><";
            Draw(x5, y5, symbol5)
            /*   Console.SetCursorPosition(x5, y5);
              Console.Write(symbol5); */
           /*   int x6 = 29;
              int y6 = 18;
              string symbol6 = "<><";
             Draw(x6, y6, symbol6)
             /* Console.SetCursorPosition(x6, y6);
              Console.Write(symbol6); */
              


            

            Console.ReadLine();
        }

        public static void Draw(int x, int y,string symbol)
        {
            
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

    }
}
