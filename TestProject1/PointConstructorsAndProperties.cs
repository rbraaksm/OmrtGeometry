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
        public static void ConstructorDoubleDoubleDoublePositive()
        {
            Data data = new Data();
            Random rand = new Random();

            double x = data.nbPos[rand.Next(0, 12)];
            double y = data.nbPos[rand.Next(0, 12)];
            double z = data.nbPos[rand.Next(0, 12)];

            OGPoint3d OGvec = new OGPoint3d(x, y, z);
            Point3d vec = new Point3d(x, y, z);

            comparePointProperties(OGvec, vec);
        }

        [Fact]
        public void ConstructorDoubleDoubleDoubleNegative()
        {
            double x = data.nbNeg[rand.Next(0, 12)];
            double y = data.nbNeg[rand.Next(0, 12)];
            double z = data.nbNeg[rand.Next(0, 12)];

            OGPoint3d OGvec = new OGPoint3d(x, y, z);
            Point3d vec = new Point3d(x, y, z);

            comparePointProperties(OGvec, vec);
        }

        [Fact]
        public void ConstructorDoubleDoubleDoubleMiX()
        {
            double x = data.nbMix[rand.Next(0, 12)];
            double y = data.nbMix[rand.Next(0, 12)];
            double z = data.nbMix[rand.Next(0, 12)];

            OGPoint3d OGvec = new OGPoint3d(x, y, z);
            Point3d vec = new Point3d(x, y, z);

            comparePointProperties(OGvec, vec);
        }

        [Fact]
        public void ConstructorPointPositive()
        {
            double x = data.nbPos[rand.Next(0, 12)];
            double y = data.nbPos[rand.Next(0, 12)];
            double z = data.nbPos[rand.Next(0, 12)];

            OGPoint3d OGvec = new OGPoint3d(x, y, z);
            Point3d vec = new Point3d(x, y, z);

            comparePointProperties(new OGPoint3d(OGvec), new Point3d(vec));
        }

        [Fact]
        public void ConstructorPointNegative()
        {
            double x = data.nbNeg[rand.Next(0, 12)];
            double y = data.nbNeg[rand.Next(0, 12)];
            double z = data.nbNeg[rand.Next(0, 12)];

            OGPoint3d OGvec = new OGPoint3d(x, y, z);
            Point3d vec = new Point3d(x, y, z);

            comparePointProperties(new OGPoint3d(OGvec), new Point3d(vec));
        }

        [Fact]
        public void ConstructorPointMix()
        {
            double x = data.nbMix[rand.Next(0, 12)];
            double y = data.nbMix[rand.Next(0, 12)];
            double z = data.nbMix[rand.Next(0, 12)];

            OGPoint3d OGvec = new OGPoint3d(x, y, z);
            Point3d vec = new Point3d(x, y, z);

            comparePointProperties(new OGPoint3d(OGvec), new Point3d(vec));
        }

        [Fact]
        public void ConstructorVectorPositive()
        {
            double x = data.nbPos[rand.Next(0, 12)];
            double y = data.nbPos[rand.Next(0, 12)];
            double z = data.nbPos[rand.Next(0, 12)];

            OGVector3d OGvec = new OGVector3d(x, y, z);
            Vector3d vector = new Vector3d(x, y, z);

            comparePointProperties(new OGPoint3d(OGvec), new Point3d(vector));
        }

        [Fact]
        public void ConstructorVectorNegative()
        {
            double x = data.nbNeg[rand.Next(0, 12)];
            double y = data.nbNeg[rand.Next(0, 12)];
            double z = data.nbNeg[rand.Next(0, 12)];

            OGVector3d OGvec = new OGVector3d(x, y, z);
            Vector3d vector = new Vector3d(x, y, z);

            comparePointProperties(new OGPoint3d(OGvec), new Point3d(vector));
        }

        [Fact]
        public void ConstructorVectorMix()
        {
            double x = data.nbMix[rand.Next(0, 12)];
            double y = data.nbMix[rand.Next(0, 12)];
            double z = data.nbMix[rand.Next(0, 12)];

            OGVector3d OGvec = new OGVector3d(x, y, z);
            Vector3d vector = new Vector3d(x, y, z);

            comparePointProperties(new OGPoint3d(OGvec), new Point3d(vector));
        }
    }
}
