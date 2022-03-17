using System;
using Xunit;

using OGVector3d = OG.Vector3d;
using OGPoint3d = OG.Point3d;
using OGBoundingBox = OG.BoundingBox;

using Vector3d = Rhino.Geometry.Vector3d;
using Point3d = Rhino.Geometry.Point3d;
using BoundingBox = Rhino.Geometry.BoundingBox;

namespace OGTests
{
    public class BoundingBoxConstructorsAndProperties
    {
        Data data = new Data();

        [Fact]
        public bool ConstructorPointPositive()
        {
            double[] minValues = data.getNBPos(0, 6);
            double[] maxValues = data.getNBPos(6, 12);

            OGPoint3d OGpointMin = new OGPoint3d(minValues[0], minValues[1], minValues[2]);
            Point3d pointMin = new Point3d(minValues[0], minValues[1], minValues[2]);

            OGPoint3d OGpointMax = new OGPoint3d(maxValues[0], maxValues[1], maxValues[2]);
            Point3d pointMax = new Point3d(maxValues[0], maxValues[1], maxValues[2]);

            OGBoundingBox OGbb = new OGBoundingBox(OGpointMin, OGpointMax);
            BoundingBox bb = new BoundingBox(pointMin, pointMax);

            return data.compareBoundingBoxProperties(OGbb, bb);
        }

        [Fact]
        public bool ConstructorPointPointNegative()
        {
            double[] minValues = data.getNBNeg(0, 6);
            double[] maxValues = data.getNBNeg(6, 12);

            OGPoint3d OGpointMin = new OGPoint3d(minValues[0], minValues[1], minValues[2]);
            Point3d pointMin = new Point3d(minValues[0], minValues[1], minValues[2]);

            OGPoint3d OGpointMax = new OGPoint3d(maxValues[0], maxValues[1], maxValues[2]);
            Point3d pointMax = new Point3d(maxValues[0], maxValues[1], maxValues[2]);

            OGBoundingBox OGbb = new OGBoundingBox(OGpointMin, OGpointMax);
            BoundingBox bb = new BoundingBox(pointMin, pointMax);

            return data.compareBoundingBoxProperties(OGbb, bb);
        }

        [Fact]
        public bool ConstructorPointPointMiX()
        {
            double[] minValues = data.getNBMix(0, 6);
            double[] maxValues = data.getNBMix(6, 12);

            OGPoint3d OGpointMin = new OGPoint3d(minValues[0], minValues[1], minValues[2]);
            Point3d pointMin = new Point3d(minValues[0], minValues[1], minValues[2]);

            OGPoint3d OGpointMax = new OGPoint3d(maxValues[0], maxValues[1], maxValues[2]);
            Point3d pointMax = new Point3d(maxValues[0], maxValues[1], maxValues[2]);

            OGBoundingBox OGbb = new OGBoundingBox(OGpointMin, OGpointMax);
            BoundingBox bb = new BoundingBox(pointMin, pointMax);

            return data.compareBoundingBoxProperties(OGbb, bb);
        }

        [Fact]
        public bool ConstructorDoubleDoubleDoublePositive()
        {
            double[] minValues = data.getNBPos(0, 6);
            double[] maxValues = data.getNBPos(6, 12);

            OGBoundingBox OGbb = new OGBoundingBox(minValues[0], minValues[1], minValues[2],
                maxValues[0], maxValues[1], maxValues[2]);

            BoundingBox bb = new BoundingBox(minValues[0], minValues[1], minValues[2],
                maxValues[0], maxValues[1], maxValues[2]);

            return data.compareBoundingBoxProperties(OGbb, bb);
        }

        [Fact]
        public bool ConstructorDoubleDoubleDoubleNegative()
        {
            double[] minValues = data.getNBNeg(0, 6);
            double[] maxValues = data.getNBNeg(6, 12);

            OGBoundingBox OGbb = new OGBoundingBox(minValues[0], minValues[1], minValues[2],
                maxValues[0], maxValues[1], maxValues[2]);

            BoundingBox bb = new BoundingBox(minValues[0], minValues[1], minValues[2],
                maxValues[0], maxValues[1], maxValues[2]);

            return data.compareBoundingBoxProperties(OGbb, bb);
        }

        [Fact]
        public bool ConstructorDoubleDoubleDoubleMix()
        {
            double[] minValues = data.getNBMix(0, 6);
            double[] maxValues = data.getNBMix(6, 12);

            OGBoundingBox OGbb = new OGBoundingBox(minValues[0], minValues[1], minValues[2],
                maxValues[0], maxValues[1], maxValues[2]);

            BoundingBox bb = new BoundingBox(minValues[0], minValues[1], minValues[2],
                maxValues[0], maxValues[1], maxValues[2]);

            return data.compareBoundingBoxProperties(OGbb, bb);
        }
    }
}
