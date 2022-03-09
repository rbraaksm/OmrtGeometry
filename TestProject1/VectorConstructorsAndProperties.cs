using System;
using Xunit;

using OGVector3d = OG.Vector3d;
using OGPoint3d = OG.Point3d;

using Vector3d = Rhino.Geometry.Vector3d;
using Point3d = Rhino.Geometry.Point3d;


namespace OGTests
{
    public class VectorConstructorsAndProperties
    {
        Random rand = new Random();
        Data data = new Data();

        public static void compareVectorProperties(OGVector3d OGvec, Vector3d vec)
        {
            Assert.Equal(OGvec.X, vec.X);
            Assert.Equal(OGvec.Y, vec.Y);
            Assert.Equal(OGvec.Z, vec.Z);

            Assert.Equal(OGvec.IsUnitVector, vec.IsUnitVector);
            Assert.Equal(OGvec.IsValid, vec.IsValid);
            Assert.Equal(OGvec.IsZero, vec.IsZero);

            Assert.Equal(OGvec.Length, vec.Length);
            Assert.Equal(OGvec.MaximumCoordinate, vec.MaximumCoordinate);
            Assert.Equal(OGvec.MinimunCoordinate, vec.MinimumCoordinate);
            Assert.Equal(OGvec.SquareLength, vec.SquareLength);
        }

        [Fact]
        public void ConstructorDoubleDoubleDoublePositive()
        {
            double x = data.nbPos[rand.Next(0, 12)];
            double y = data.nbPos[rand.Next(0, 12)];
            double z = data.nbPos[rand.Next(0, 12)];

            OGVector3d OGvec = new OGVector3d(x, y, z);
            Vector3d vec = new Vector3d(x, y, z);

            compareVectorProperties(OGvec, vec);
        }

        [Fact]
        public void ConstructorDoubleDoubleDoubleNegative()
        {
            double x = data.nbNeg[rand.Next(0, 12)];
            double y = data.nbNeg[rand.Next(0, 12)];
            double z = data.nbNeg[rand.Next(0, 12)];

            OGVector3d OGvec = new OGVector3d(x, y, z);
            Vector3d vec = new Vector3d(x, y, z);

            compareVectorProperties(OGvec, vec);
        }

        [Fact]
        public void ConstructorDoubleDoubleDoubleMiX()
        {
            double x = data.nbMix[rand.Next(0, 12)];
            double y = data.nbMix[rand.Next(0, 12)];
            double z = data.nbMix[rand.Next(0, 12)];

            OGVector3d OGvec = new OGVector3d(x, y, z);
            Vector3d vec = new Vector3d(x, y, z);

            compareVectorProperties(OGvec, vec);
        }

        [Fact]
        public void ConstructorVectorPositive()
        {
            double x = data.nbPos[rand.Next(0, 12)];
            double y = data.nbPos[rand.Next(0, 12)];
            double z = data.nbPos[rand.Next(0, 12)];

            OGVector3d OGvec = new OGVector3d(x, y, z);
            Vector3d vec = new Vector3d(x, y, z);

            compareVectorProperties(new OGVector3d(OGvec), new Vector3d(vec));
        }

        [Fact]
        public void ConstructorVectorNegative()
        {
            double x = data.nbNeg[rand.Next(0, 12)];
            double y = data.nbNeg[rand.Next(0, 12)];
            double z = data.nbNeg[rand.Next(0, 12)];

            OGVector3d OGvec = new OGVector3d(x, y, z);
            Vector3d vec = new Vector3d(x, y, z);

            compareVectorProperties(new OGVector3d(OGvec), new Vector3d(vec));
        }

        [Fact]
        public void ConstructorVectorMix()
        {
            double x = data.nbMix[rand.Next(0, 12)];
            double y = data.nbMix[rand.Next(0, 12)];
            double z = data.nbMix[rand.Next(0, 12)];

            OGVector3d OGvec = new OGVector3d(x, y, z);
            Vector3d vec = new Vector3d(x, y, z);

            compareVectorProperties(new OGVector3d(OGvec), new Vector3d(vec));
        }

        [Fact]
        public void ConstructorPointPositive()
        {
            double x = data.nbPos[rand.Next(0, 12)];
            double y = data.nbPos[rand.Next(0, 12)];
            double z = data.nbPos[rand.Next(0, 12)];

            OGPoint3d OGpoint = new OGPoint3d(x, y, z);
            Point3d point = new Point3d(x, y, z);

            compareVectorProperties(new OGVector3d(OGpoint), new Vector3d(point));
        }

        [Fact]
        public void ConstructorPointNegative()
        {
            double x = data.nbNeg[rand.Next(0, 12)];
            double y = data.nbNeg[rand.Next(0, 12)];
            double z = data.nbNeg[rand.Next(0, 12)];

            OGPoint3d OGpoint = new OGPoint3d(x, y, z);
            Point3d point = new Point3d(x, y, z);

            compareVectorProperties(new OGVector3d(OGpoint), new Vector3d(point));
        }

        [Fact]
        public void ConstructorPointMix()
        {
            double x = data.nbMix[rand.Next(0, 12)];
            double y = data.nbMix[rand.Next(0, 12)];
            double z = data.nbMix[rand.Next(0, 12)];

            OGPoint3d OGpoint = new OGPoint3d(x, y, z);
            Point3d point = new Point3d(x, y, z);

            compareVectorProperties(new OGVector3d(OGpoint), new Vector3d(point));
        }
    }
}
