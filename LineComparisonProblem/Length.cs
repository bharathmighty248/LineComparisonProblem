using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisonProblem
{
    class Length
    {
        public int pointx1, pointx2, pointy1, pointy2;
        public Length(int pointx1, int pointy1, int pointx2, int pointy2)
        {
            this.pointx1 = pointx1;
            this.pointx2 = pointx2;
            this.pointy1 = pointy1;
            this.pointy2 = pointy2;
        }

        public double CalculateLength()
        {
            double length= Math.Sqrt(Math.Pow((pointx2 - pointx1), 2) + Math.Pow((pointy2 - pointy1), 2));
            return length;
        }
    }
}
