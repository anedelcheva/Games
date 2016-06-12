using System;

namespace Point
{
    struct Point3D
    {
        private double x;
        private double y;
        private double z;

        private static readonly Point3D pointO = new Point3D(0.0, 0.0, 0.0);

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double X {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public double Z
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }

        public Point3D PointO {
            get
            {
                return pointO;
            }
        }

        public override string ToString()
        {
 	        return String.Format("({0}, {1}, {2})", X, Y, Z);
        }
    }
}