using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            
            //XSTEP 5 Class Figure
            //STEP 4 Horizontal line
            HorizontalLine topLine = new HorizontalLine(0, 78, 0, '*');
            //topLine.DrawHrLine();
            topLine.DrawFigure();
            HorizontalLine bottomLine = new HorizontalLine(0, 78, 24, '*');
            //bottomLine.DrawHrLine();
            bottomLine.DrawFigure();
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '*');
            //leftLine.DrawVerticalLine();
            leftLine.DrawFigure();
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '*');
            //rightLine.DrawVerticalLine();
            rightLine.DrawFigure();
            //STEP 6 Snake
            Point p1 = new Point(6, 5, '*');
            Snake snake = new Snake(p1, 4, Direction.RIGHT);
            snake.DrawFigure();
            snake.Move();

            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();

            //STEP 5 Vertical line
            /* VerticalLine vLine = new VerticalLine(0, 23, 5, '*');
             vLine.DrawVerticalLine();*/

            //STEP3
            /* Point p1 = new Point(0, 5, '*');
             p1.Draw();*/
            //STEP2
            /*int x1 = 0;
            int y1 = 0;
            char sym1 = '#';

            Draw(x1, y1, sym1);*/

            //STEP1
            /*int x1 = 1;
            int y1 = 3;
            char sym1 = '*';

            Console.SetCursorPosition(x1, y1);
            Console.Write(sym1);

            int x2 = 0;
            int y2 = 0;
            char sym2 = '#';
            Console.SetCursorPosition(x2, y2);
            Console.Write(sym2);*/

            Console.ReadLine();
        }

        //STEP2
        public static void Draw(int x, int y, char sym){
            Console.SetCursorPosition(x, y);
            Console.Write(sym); 
        }
    }
}
