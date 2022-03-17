using System;
using OGPoint3d = OG.Point3d;
using OGBoundingBox = OG.BoundingBox;
using OGPolyline = OG.Polyline;
using OGPoint3dList = OG.Point3dList;

using Polyline = Rhino.Geometry.Polyline;
using Point3d = Rhino.Geometry.Point3d;
using BoundingBox = Rhino.Geometry.BoundingBox;
using Point3dList = Rhino.Collections.Point3dList;
using System.Collections.Generic;
using OG;

namespace OmrtGeometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            var number = rand.Next(1, int.MaxValue - 1);
            OGPoint3dList OG = new OGPoint3dList(number);
            Point3dList rhino = new Point3dList(number);

            Console.WriteLine(OG.Capacity);
            Console.WriteLine(rhino.Capacity);

            Console.WriteLine(OG.Count);
            Console.WriteLine(rhino.Count);
            //data.compareBoundingBoxProperties(OG.BoundingBox, rhino.BoundingBox);
            //Assert.Equal(OG.Capacity, rhino.Capacity);
            //Assert.Equal(OG.Count, rhino.Count);
        }
    }
}