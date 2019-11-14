using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Figure
    {

        protected List<Point> pointList;


        public void DrawFigure()
        {
            foreach (Point point in pointList)
            {
                point.Draw();
            }
        }


    }
}
