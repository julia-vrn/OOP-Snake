using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class VerticalLine : Figure
    {
        //List<Point> pointList;

        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            pointList = new List<Point>();
            for(int i = yUp; i <= yDown; i++)
            {
                Point p = new Point(x, i, sym);
                pointList.Add(p);
            }
        }

        /*public void DrawVerticalLine()
        {
            foreach (Point point in pointList)
            {
                point.Draw();
            }
        }*/
    }
}
