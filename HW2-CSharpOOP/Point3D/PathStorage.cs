using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Point
{
    static class PathStorage
    {
        public static void save(string path, Path storage)
        {
            StreamWriter writer;
            using (writer = new StreamWriter(path))
            {
                writer.WriteLine(storage.ToString());
            }
        }
        
        private static Point3D parsePoint(string point)
        {
            double[] coordinates =
                point
                .Split(new Char[] { ' ', ',', '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            return new Point3D(coordinates[0], coordinates[1], coordinates[2]);
        }

        public static Path load(string path)
        {
            Path storage = new Path();
            StreamReader reader;
            try
            {
                using (reader = new StreamReader(path))
                {
                    string[] points = 
                        reader.ReadToEnd()
                        .Split(Environment.NewLine.ToCharArray(), 
                        StringSplitOptions.RemoveEmptyEntries);
                    foreach (var point in points)
                    {
                        storage.addPoint(parsePoint(point));
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File with path {0} cannot be found", path);
            }
            return storage;
        }
    }
}