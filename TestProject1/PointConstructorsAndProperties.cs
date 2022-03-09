using System;
using Xunit;

using OGVector3d = OG.Vector3d;
using OGPoint3d = OG.Point3d;

using Vector3d = Rhino.Geometry.Vector3d;
using Point3d = Rhino.Geometry.Point3d;


namespace OGTests
{
    public class PointConstructorsAndProperties
    {
        Random rand = new Random();
        Data data = new Data();

        public static void comparePointProperties(OGPoint3d OG, Point3d rhino)
        {
            Assert.Equal(OG.X, rhino.X);
            Assert.Equal(OG.Y, rhino.Y);
            Assert.Equal(OG.Z, rhino.Z);

            Assert.Equal(OG.IsValid, rhino.IsValid);
            Assert.Equal(OG.MaximumCoordinate, rhino.MaximumCoordinate);
            Assert.Equal(OG.MinimunCoordinate, rhino.MinimumCoordinate);
        }

        [Fact]
        public void ConstructorDoubleDoubleDoublePositive()
        {
            double[] values = data.getNBPos(0, 12);

            OGPoint3d OGpoint = new OGPoint3d(values[0], values[1], values[0]);
            Point3d point = new Point3d(values[0], values[1], values[0]);

            comparePointProperties(OGpoint, point);
        }

        [Fact]
        public void ConstructorDoubleDoubleDoubleNegative()
        {
            double[] values = data.getNBNeg(0, 12);

            OGPoint3d OGpoint = new OGPoint3d(values[0], values[1], values[0]);
            Point3d point = new Point3d(values[0], values[1], values[0]);

            comparePointProperties(OGpoint, point);
        }

        [Fact]
        public void ConstructorDoubleDoubleDoubleMiX()
        {
            double[] values = data.getNBMix(0, 12);

            OGPoint3d OGpoint = new OGPoint3d(values[0], values[1], values[0]);
            Point3d point = new Point3d(values[0], values[1], values[0]);

            comparePointProperties(OGpoint, point);
        }

        [Fact]
        public void ConstructorPointPositive()
        {
            double[] values = data.getNBPos(0, 12);

            OGPoint3d OGpoint = new OGPoint3d(values[0], values[1], values[0]);
            Point3d point = new Point3d(values[0], values[1], values[0]);

            comparePointProperties(new OGPoint3d(OGpoint), new Point3d(point));
        }

        [Fact]
        public void ConstructorPointNegative()
        {
            double[] values = data.getNBNeg(0, 12);

            OGPoint3d OGpoint = new OGPoint3d(values[0], values[1], values[0]);
            Point3d point = new Point3d(values[0], values[1], values[0]);

            comparePointProperties(new OGPoint3d(OGpoint), new Point3d(point));
        }

        [Fact]
        public void ConstructorPointMix()
        {
            double[] values = data.getNBMix(0, 12);

            OGPoint3d OGpoint = new OGPoint3d(values[0], values[1], values[0]);
            Point3d point = new Point3d(values[0], values[1], values[0]);

            comparePointProperties(new OGPoint3d(OGpoint), new Point3d(point));
        }

        [Fact]
        public void ConstructorVectorPositive()
        {
            double[] values = data.getNBPos(0, 12);

            OGVector3d OGvec = new OGVector3d(values[0], values[1], values[0]);
            Vector3d vec = new Vector3d(values[0], values[1], values[0]);

            comparePointProperties(new OGPoint3d(OGvec), new Point3d(vec));
        }

        [Fact]
        public void ConstructorVectorNegative()
        {
            double[] values = data.getNBNeg(0, 12);

            OGVector3d OGvec = new OGVector3d(values[0], values[1], values[0]);
            Vector3d vec = new Vector3d(values[0], values[1], values[0]);

            comparePointProperties(new OGPoint3d(OGvec), new Point3d(vec));
        }

        [Fact]
        public void ConstructorVectorMix()
        {
            double[] values = data.getNBMix(0, 12);

            OGVector3d OGvec = new OGVector3d(values[0], values[1], values[0]);
            Vector3d vec = new Vector3d(values[0], values[1], values[0]);

            comparePointProperties(new OGPoint3d(OGvec), new Point3d(vec));
        }
    }
}
