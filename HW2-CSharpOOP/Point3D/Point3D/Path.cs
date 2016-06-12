using System;
using System.Collections.Generic;

namespace Point
{
    class Path
    {
        List<Point3D> points;

        public Path()
        {
            this.points = new List<Point3D>();
        }

        public void addPoint(Point3D point)
        {
            points.Add(point);
        }

        public int numberOfPoints()
        {
            return points.Count;
        }

        public List<Point3D> Points
        {
            get
            {
                return points;
            }
        }

        public override string ToString()
        {
 	         return String.Join(Environment.NewLine, points);
        }
    }
}
