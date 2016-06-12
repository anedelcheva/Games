using System;

namespace Point
{
    class MainClass
    {
        public static void Main()
        {
            Point3D p1 = new Point3D(1.1, 2.2, 3.3);
            Point3D p2 = new Point3D(2, 3, 5.5);
            Point3D p3 = new Point3D(2, 6, 4.6);
            Path path = new Path();
            path.addPoint(p1);
            path.addPoint(p2);
            path.addPoint(p3);
            Console.WriteLine(String.Join(Environment.NewLine, path.Points));
            PathStorage.save("..\\..\\test.txt", path);
            Console.WriteLine();
            Path path2 = PathStorage.load("..\\..\\test.txt");
            Console.WriteLine(path2.ToString());
        }
    }
}
