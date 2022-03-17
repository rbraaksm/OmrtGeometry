using System;
using Xunit;

using OGPoint3d = OG.Point3d;
using OGVector3d = OG.Vector3d;
using OGBoundingBox = OG.BoundingBox;
using OGPoint3dList = OG.Point3dList;


using Point3d = Rhino.Geometry.Point3d;
using Vector3d = Rhino.Geometry.Vector3d;
using BoundingBox = Rhino.Geometry.BoundingBox;
using Point3dList = Rhino.Collections.Point3dList;
using System.Collections.Generic;

namespace OGTests
{
    internal class Data
    {
        Random random = new Random();

        public bool comparePoint3dList(OGPoint3dList OG, Point3dList rhino)
        {
            compareBoundingBoxProperties(OG.BoundingBox, rhino.BoundingBox);
            Assert.Equal(OG.Capacity, rhino.Capacity);
            Assert.Equal(OG.Count, rhino.Count);

            comparePointProperties(OG.First, rhino.First);
            comparePointProperties(OG.Last, rhino.Last);
            return true;
        }

        public bool comparePointProperties(OGPoint3d OG, Point3d rhino)
        {
            Assert.Equal(OG.X, rhino.X);
            Assert.Equal(OG.Y, rhino.Y);
            Assert.Equal(OG.Z, rhino.Z);

            Assert.Equal(OG.IsValid, rhino.IsValid);
            Assert.Equal(OG.MaximumCoordinate, rhino.MaximumCoordinate);
            Assert.Equal(OG.MinimunCoordinate, rhino.MinimumCoordinate);
            return true;
        }

        public bool compareVectorProperties(OGVector3d OG, Vector3d rhino)
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
            return true;
        }

        public bool compareBoundingBoxProperties(OGBoundingBox OG, BoundingBox rhino)
        {
            Assert.Equal(OG.Min.X, rhino.Min.X);
            Assert.Equal(OG.Min.Y, rhino.Min.Y);
            Assert.Equal(OG.Min.Z, rhino.Min.Z);

            Assert.Equal(OG.Max.X, rhino.Max.X);
            Assert.Equal(OG.Max.Y, rhino.Max.Y);
            Assert.Equal(OG.Max.Z, rhino.Max.Z);

            Assert.Equal(OG.Area, rhino.Area);

            comparePointProperties(OG.Center, rhino.Center);
            compareVectorProperties(OG.Diagonal, rhino.Diagonal);

            Assert.Equal(OG.IsValid, rhino.IsValid);
            Assert.Equal(OG.Volume, rhino.Volume);
            return true;
        }

        public double[] nbPos()
        {
            double[] ret = new double[12];
            ret[0] = random.NextDouble() * 50;
            ret[1] = random.NextDouble() * 50;
            ret[2] = random.NextDouble() * 50;
            ret[3] = random.NextDouble() * 50;
            ret[4] = random.NextDouble() * 50;
            ret[5] = random.NextDouble() * 50;
            ret[6] = random.NextDouble() * 100;
            ret[7] = random.NextDouble() * 100;
            ret[8] = random.NextDouble() * 100;
            ret[9] = random.NextDouble() * 100;
            ret[10] = random.NextDouble() * 100;
            ret[11] = random.NextDouble() * 100;

            return ret;
        }

        public double[] nbNeg()
        {
            double[] ret = new double[12];
            ret[0] = random.NextDouble() * -50;
            ret[1] = random.NextDouble() * -50;
            ret[2] = random.NextDouble() * -50;
            ret[3] = random.NextDouble() * -50;
            ret[4] = random.NextDouble() * -50;
            ret[5] = random.NextDouble() * -50;
            ret[6] = random.NextDouble() * -100;
            ret[7] = random.NextDouble() * -100;
            ret[8] = random.NextDouble() * -100;
            ret[9] = random.NextDouble() * -100;
            ret[10] = random.NextDouble() * -100;
            ret[11] = random.NextDouble() * -100;

            return ret;
        }

        public double[] nbMix()
        {
            double[] ret = new double[12];
            ret[0] = random.NextDouble() * 50;
            ret[1] = random.NextDouble() * -50;
            ret[2] = random.NextDouble() * 50;
            ret[3] = random.NextDouble() * -50;
            ret[4] = random.NextDouble() * 50;
            ret[5] = random.NextDouble() * -50;
            ret[6] = random.NextDouble() * 100;
            ret[7] = random.NextDouble() * -100;
            ret[8] = random.NextDouble() * 100;
            ret[9] = random.NextDouble() * -100;
            ret[10] = random.NextDouble() * 100;
            ret[11] = random.NextDouble() * -100;

            return ret;
        }

        public double[] getNBPos(int start, int end)
        {
            double[] nb = nbPos();
            double[] ret = new double[3];

            ret[0] = nb[random.Next(start, end)];
            ret[1] = nb[random.Next(start, end)];
            ret[2] = nb[random.Next(start, end)];

            return ret;
        }

        public double[] getNBNeg(int start, int end)
        {
            double[] nb = nbPos();
            double[] ret = new double[3];

            ret[0] = nb[random.Next(start, end)];
            ret[1] = nb[random.Next(start, end)];
            ret[2] = nb[random.Next(start, end)];

            return ret;
        }

        public double[] getNBMix(int start, int end)
        {
            double[] nb = nbMix();
            double[] ret = new double[3];

            ret[0] = nb[random.Next(start, end)];
            ret[1] = nb[random.Next(start, end)];
            ret[2] = nb[random.Next(start, end)];

            return ret;
        }
    }
}
