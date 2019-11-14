using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class HorizontalLine : Figure
    {
        //List of points in one line
        //List<Point> pointList;
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pointList = new List<Point>();

            for(int i = xLeft; i <= xRight; i++)
            {
                Point p = new Point(i, y, sym);
                pointList.Add(p);
            }
            
            /*Point p1 = new Point(0, 0, '*');
            Point p2 = new Point(1, 0, '*');
            Point p3 = new Point(2, 0, '*');

            pointList.Add(p1);
            pointList.Add(p2);
            pointList.Add(p3);*/
        }

       /* public void DrawHrLine()
        {
            foreach(Point point in pointList)
            {
                point.Draw();
            }
        }*/
    }
}
