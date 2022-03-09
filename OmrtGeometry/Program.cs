using System;
using OGPoint3d = OG.Point3d;
using OGBoundingBox = OG.BoundingBox;

using Point3d = Rhino.Geometry.Point3d;
using BoundingBox = Rhino.Geometry.BoundingBox;

namespace OmrtGeometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double[] minValues = new double[3];
            minValues[0] = random.NextDouble() * 50;
            minValues[1] = random.NextDouble() * 50;
            minValues[2] = random.NextDouble() * 50;

            double[] maxValues = new double[3];
            maxValues[0] = random.NextDouble() * 50;
            maxValues[1] = random.NextDouble() * 50;
            maxValues[2] = random.NextDouble() * 50;


            OGPoint3d min = new OGPoint3d(minValues[0], minValues[1], minValues[2]);
            OGPoint3d max = new OGPoint3d(maxValues[0], maxValues[1], maxValues[2]);

            Point3d min1 = new Point3d(minValues[0], minValues[1], minValues[2]);
            Point3d max2 = new Point3d(maxValues[0], maxValues[1], maxValues[2]);


            OGBoundingBox bb = new OGBoundingBox(min, max);
            BoundingBox rhino = new BoundingBox(min1, max2);

            Console.WriteLine(bb.IsValid);
            Console.WriteLine(rhino.IsValid);

            Console.WriteLine(bb.Area);
            Console.WriteLine(rhino.Area);
        }
    }
}
