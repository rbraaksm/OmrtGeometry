using System;
using System.Collections.Generic;
using Xunit;

using OGPolyline = OG.Polyline;
using OGPoint3d = OG.Point3d;
using OGPoint3dList = OG.Point3dList;

using Point3d = Rhino.Geometry.Point3d;
using Point3dList = Rhino.Collections.Point3dList;
using Polyline = Rhino.Geometry.Polyline;

namespace OGTests
{
    public class PolylineConstructorsAndProperties
    {
        Data data = new Data();
        Random rand = new Random();

        [Fact]
        public bool ConstructorBasic()
        {
            OGPolyline OG = new OGPolyline();
            Polyline rhino = new Polyline();

            
            data.compareBoundingBoxProperties(OG.BoundingBox, rhino.BoundingBox);
            Assert.Equal(OG.Capacity, rhino.Capacity);
            Assert.Equal(OG.Count, rhino.Count);
            return true;
        }

        [Fact]
        public bool ConstructorInt32()
        {
            var number = rand.Next(1, int.MaxValue);
            OGPolyline OG = new OGPolyline(number);
            Polyline rhino = new Polyline(number);

            data.compareBoundingBoxProperties(OG.BoundingBox, rhino.BoundingBox);
            Assert.Equal(OG.Capacity, rhino.Capacity);
            Assert.Equal(OG.Count, rhino.Count);
            return true;
        }

        [Fact]
        public bool ConstructorPoint3dList()
        {
            int total = rand.Next(5, 100);

            List<OGPoint3d> OG_list = new List<OGPoint3d>();
            List<Point3d> RH_list = new List<Point3d>();
            for (int i = 0; i < total; ++i)
            {
                double x = rand.NextDouble() * 50;
                double y = rand.NextDouble() * 50;
                double z = rand.NextDouble() * 50;

                OG_list.Add(new OGPoint3d(x, y, z));
                RH_list.Add(new Point3d(x, y, z));
            }

            OGPolyline OG = new OGPolyline(OG_list);
            Polyline rhino = new Polyline(RH_list);

            return data.comparePoint3dList(OG, rhino);
        }

        [Fact]
        public bool ConstructorPoint3dArray()
        {
            int total = rand.Next(5, 100);

            OGPoint3d[] OG_list = new OGPoint3d[total];
            Point3d[] RH_list = new Point3d[total];
            for (int i = 0; i < total; ++i)
            {
                double x = rand.NextDouble() * 50;
                double y = rand.NextDouble() * 50;
                double z = rand.NextDouble() * 50;

                OG_list[i] = new OGPoint3d(x, y, z);
                RH_list[i] = new Point3d(x, y, z);
            }

            OGPolyline OG = new OGPolyline(OG_list);
            Polyline rhino = new Polyline(RH_list);

            return data.comparePoint3dList(OG, rhino);
        }
    }
}
