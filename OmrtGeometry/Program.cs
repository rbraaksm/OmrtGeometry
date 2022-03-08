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
            OGPoint3d min = new OGPoint3d(2,0,0);
            OGPoint3d max = new OGPoint3d(10,10,10);

            OGBoundingBox bb = new OGBoundingBox(min, max);

            Point3d test = new Point3d(0, 0, 0);
            Console.WriteLine(bb.Area);
        }
    }
}
