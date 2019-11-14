using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Snake
{
    enum Direction
    {
        LEFT,
        RIGHT,
        UP,
        DOWN
    }
    class Snake : Figure
    {
        Direction direction;
            
        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pointList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pointList.Add(p);
            }
        }

        public void Move()
        {
            Point tail = pointList.First();
            pointList.Remove(tail);
            Point head = GetNextPoint();
            pointList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pointList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;

        }
    }
}
