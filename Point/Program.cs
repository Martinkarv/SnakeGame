using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



namespace Point
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

        public Point(Point _p)
        {
            x = _p.x;
            y = _p.y;
            symbol = _p.symbol;


        }


        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

        public void Clear()
        {
            symbol = " ";
            Draw();
        }

        public void MovePoint(int offset, Direction direction)
        {
            if(direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if(direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if(direction == Direction.UP)
            {
                y = y - offset;
            }
            else if(direction == Direction.DOWN)
            {
                y = y + offset;
            }

        }

        public bool IsHit(Point point)
        {
            return point.x == x && point.y == y;
        }



    }

    class Program
    {
       
            

        static void Main(string[] args)
        {

        /*  Point p1 = new Point(26, 19, "*");
          p1.Draw();
          Point p3 = new Point(25, 19, "*");
          p3.Draw();
          Point p4 = new Point(24, 19, "*");
          p4.Draw();
          Point p5 = new Point(23, 19, "*");
          p5.Draw();
          Point p6 = new Point(22, 19, "*");
          p6.Draw();
                     */
        /*
                    for (int i = 22; i < 5; i++)
                    {
                        Point newPoint = new Point(i, 5, "*");
                        newPoint.Draw();
                    }

                    Point p2 = new Point(29, 19, "<><");
                    p2.Draw();

            */







        Start:

         /*   TimerCallback callback = new TimerCallback(Tick);

            Console.WriteLine("Creating timer: {0}\n",
                             DateTime.Now.ToString("h:mm:ss"));
            Timer stateTimer = new Timer(callback, null, 0, 1000);
            */
            int score = 0;
                int speed = 150;
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.SetWindowSize(100, 50);
                Console.SetBufferSize(100, 50);

                Walls walls = new Walls(80, 25);
                walls.DrawWalls();
                /* HorizontalLine topLine = new HorizontalLine(0, 78, 0, "_");
                 topLine.DrawFigure();
                   HorizontalLine hrLine = new HorizontalLine(0, 78, 24, "_");
                   hrLine.DrawFigure();

                 VerticalLine leftLine = new VerticalLine(1, 24, 0, "|");
                 leftLine.DrawFigure();
                 VerticalLine vrLine = new VerticalLine(1, 24, 78, "|");
                 vrLine.DrawFigure();
                 */

                Point tail = new Point(6, 5, "*");
                Snake snake = new Snake(tail, 4, Direction.RIGHT);
                snake.DrawFigure();


                Toit toit = new Toit(80, 25, "$");
                Point food = toit.CaterFood();
                food.Draw();




                while (true)
                {
                    if (walls.IsHitByFigure(snake))
                    {
                        Console.Beep();
                    
                        break;

                    }
                    if (snake.Eat(food))
                    {
                        food = toit.CaterFood();
                        food.Draw();
                        speed -= 5;
                        score++;


                    }
                    else
                    {
                        snake.MoveSnake();
                    }

                    Thread.Sleep(speed);

                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo key = Console.ReadKey();

                        snake.ReadUserKey(key.Key);

                    }


                }

                WriteGameOver();
                WriteScore(score);
                PlayAgain();
                var info = Console.ReadKey();
                if (info.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    goto Start;
                }
            
            Console.ReadLine();
            

        }

       /* private static void Tick(object state)
        {
            
            Console.WriteLine("Tick: {0}", DateTime.Now.ToString("h:mm:ss"));
        }
    */

        public static void Draw(int x, int y, string symbol)
        {

            Console.SetCursorPosition(x, y);
            Console.Write(symbol);



            
        }
        public static void WriteGameOver()
        {
            Console.Clear();
            int xOffset = 35;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(xOffset, yOffset++);
            ShowMessage("---------", xOffset, yOffset++);
            ShowMessage("GAME OVER", xOffset, yOffset++);
            ShowMessage("---------", xOffset, yOffset++);
        }

        public static void ShowMessage(string text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }
       

       public static void WriteScore(int score)
        {
            int xOffset = 35;
            int yOffset = 12;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine($"Your SCORE:{score}");
        }
            
      public static void PlayAgain()
        {
            int xOffset = 29;
            int yOffset = 14;
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine("To play again press ENTER");
            
        }

       






    }


}
