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

        public static void comparePoint3d(OGPoint3d OG, Point3d rhino)
        {
            Assert.Equal(OG.X, rhino.X);
            Assert.Equal(OG.Y, rhino.Y);
            Assert.Equal(OG.Z, rhino.Z);

            Assert.Equal(OG.IsValid, rhino.IsValid);
            Assert.Equal(OG.MaximumCoordinate, rhino.MaximumCoordinate);
            Assert.Equal(OG.MinimunCoordinate, rhino.MinimumCoordinate);
        }

        public static void compareVector3d(OGVector3d OG, Vector3d rhino)
        {
            Assert.Equal(OG.X, rhino.X);
            Assert.Equal(OG.Y, rhino.Y);
            Assert.Equal(OG.Z, rhino.Z);

            Assert.Equal(OG.IsUnitVector, rhino.IsUnitVector);
            Assert.Equal(OG.IsValid, rhino.IsValid);
            Assert.Equal(OG.IsZero, rhino.IsZero);

            Assert.Equal(OG.Length, rhino.Length);
            Assert.Equal(OG.MaximumCoordinate, rhino.MaximumCoordinate);
            Assert.Equal(OG.MinimunCoordinate, rhino.MinimumCoordinate);
            Assert.Equal(OG.SquareLength, rhino.SquareLength);
        }


        public static void compareBoundingBoxProperties(OGBoundingBox OG, BoundingBox rhino)
        {
            Assert.Equal(OG.Min.X, rhino.Min.X);
            Assert.Equal(OG.Min.Y, rhino.Min.Y);
            Assert.Equal(OG.Min.Z, rhino.Min.Z);

            Assert.Equal(OG.Max.X, rhino.Max.X);
            Assert.Equal(OG.Max.Y, rhino.Max.Y);
            Assert.Equal(OG.Max.Z, rhino.Max.Z);

            Assert.Equal(OG.Area, rhino.Area);

            comparePoint3d(OG.Center, rhino.Center);
            compareVector3d(OG.Diagonal, rhino.Diagonal);

            Assert.Equal(OG.IsValid, rhino.IsValid);
            Assert.Equal(OG.Volume, rhino.Volume);
        }

        [Fact]
        public void ConstructorPointPositive()
        {
            double[] minValues = data.getNBPos(0, 6);
            double[] maxValues = data.getNBPos(6, 12);

            OGPoint3d OGpointMin = new OGPoint3d(minValues[0], minValues[1], minValues[2]);
            Point3d pointMin = new Point3d(minValues[0], minValues[1], minValues[2]);

            OGPoint3d OGpointMax = new OGPoint3d(maxValues[0], maxValues[1], maxValues[2]);
            Point3d pointMax = new Point3d(maxValues[0], maxValues[1], maxValues[2]);

            OGBoundingBox OGbb = new OGBoundingBox(OGpointMin, OGpointMax);
            BoundingBox bb = new BoundingBox(pointMin, pointMax);

            compareBoundingBoxProperties(OGbb, bb);
        }

        [Fact]
        public void ConstructorPointPointNegative()
        {
            double[] minValues = data.getNBNeg(0, 6);
            double[] maxValues = data.getNBNeg(6, 12);

            OGPoint3d OGpointMin = new OGPoint3d(minValues[0], minValues[1], minValues[2]);
            Point3d pointMin = new Point3d(minValues[0], minValues[1], minValues[2]);

            OGPoint3d OGpointMax = new OGPoint3d(maxValues[0], maxValues[1], maxValues[2]);
            Point3d pointMax = new Point3d(maxValues[0], maxValues[1], maxValues[2]);

            OGBoundingBox OGbb = new OGBoundingBox(OGpointMin, OGpointMax);
            BoundingBox bb = new BoundingBox(pointMin, pointMax);

            compareBoundingBoxProperties(OGbb, bb);
        }

        [Fact]
        public void ConstructorPointPointMiX()
        {
            double[] minValues = data.getNBMix(0, 6);
            double[] maxValues = data.getNBMix(6, 12);

            OGPoint3d OGpointMin = new OGPoint3d(minValues[0], minValues[1], minValues[2]);
            Point3d pointMin = new Point3d(minValues[0], minValues[1], minValues[2]);

            OGPoint3d OGpointMax = new OGPoint3d(maxValues[0], maxValues[1], maxValues[2]);
            Point3d pointMax = new Point3d(maxValues[0], maxValues[1], maxValues[2]);

            OGBoundingBox OGbb = new OGBoundingBox(OGpointMin, OGpointMax);
            BoundingBox bb = new BoundingBox(pointMin, pointMax);

            compareBoundingBoxProperties(OGbb, bb);
        }

        [Fact]
        public void ConstructorDoubleDoubleDoublePositive()
        {
            double[] minValues = data.getNBPos(0, 6);
            double[] maxValues = data.getNBPos(6, 12);

            OGBoundingBox OGbb = new OGBoundingBox(minValues[0], minValues[1], minValues[2],
                maxValues[0], maxValues[1], maxValues[2]);

            BoundingBox bb = new BoundingBox(minValues[0], minValues[1], minValues[2],
                maxValues[0], maxValues[1], maxValues[2]);

            compareBoundingBoxProperties(OGbb, bb);
        }

        [Fact]
        public void ConstructorDoubleDoubleDoubleNegative()
        {
            double[] minValues = data.getNBNeg(0, 6);
            double[] maxValues = data.getNBNeg(6, 12);

            OGBoundingBox OGbb = new OGBoundingBox(minValues[0], minValues[1], minValues[2],
                maxValues[0], maxValues[1], maxValues[2]);

            BoundingBox bb = new BoundingBox(minValues[0], minValues[1], minValues[2],
                maxValues[0], maxValues[1], maxValues[2]);

            compareBoundingBoxProperties(OGbb, bb);
        }

        [Fact]
        public void ConstructorDoubleDoubleDoubleMix()
        {
            double[] minValues = data.getNBMix(0, 6);
            double[] maxValues = data.getNBMix(6, 12);

            OGBoundingBox OGbb = new OGBoundingBox(minValues[0], minValues[1], minValues[2],
                maxValues[0], maxValues[1], maxValues[2]);

            BoundingBox bb = new BoundingBox(minValues[0], minValues[1], minValues[2],
                maxValues[0], maxValues[1], maxValues[2]);

            compareBoundingBoxProperties(OGbb, bb);
        }
    }
}
