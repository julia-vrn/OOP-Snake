﻿using System;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;
        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
            //https://www.c-sharpcorner.com/article/change-console-foreground-and-background-color-in-c-sharp/
        }

        public void Move(int offset, Direction direction)
        {
            if(direction == Direction.RIGHT)
            {
                x = x + offset;
            } else if(direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if(direction == Direction.UP)
            {
                y = y + offset;
            } else if(direction == Direction.DOWN)
            {
                y = y - offset;
            }
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;

        }
    }
}
