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
        Data data = new Data();

        [Fact]
        public bool ConstructorDoubleDoubleDoublePositive()
        {
            double[] values = data.getNBPos(0, 12);

            OGVector3d OGvec = new OGVector3d(values[0], values[1], values[0]);
            Vector3d vec = new Vector3d(values[0], values[1], values[0]);

            return data.compareVectorProperties(OGvec, vec);
        }

        [Fact]
        public bool ConstructorDoubleDoubleDoubleNegative()
        {
            double[] values = data.getNBNeg(0, 12);

            OGVector3d OGvec = new OGVector3d(values[0], values[1], values[0]);
            Vector3d vec = new Vector3d(values[0], values[1], values[0]);

            return data.compareVectorProperties(OGvec, vec);
        }

        [Fact]
        public bool ConstructorDoubleDoubleDoubleMiX()
        {
            double[] values = data.getNBMix(0, 12);

            OGVector3d OGvec = new OGVector3d(values[0], values[1], values[0]);
            Vector3d vec = new Vector3d(values[0], values[1], values[0]);

            return data.compareVectorProperties(OGvec, vec);
        }

        [Fact]
        public bool ConstructorVectorPositive()
        {
            double[] values = data.getNBPos(0, 12);

            OGVector3d OGvec = new OGVector3d(values[0], values[1], values[0]);
            Vector3d vec = new Vector3d(values[0], values[1], values[0]);

            return data.compareVectorProperties(new OGVector3d(OGvec), new Vector3d(vec));
        }

        [Fact]
        public bool ConstructorVectorNegative()
        {
            double[] values = data.getNBNeg(0, 12);

            OGVector3d OGvec = new OGVector3d(values[0], values[1], values[0]);
            Vector3d vec = new Vector3d(values[0], values[1], values[0]);

            return data.compareVectorProperties(new OGVector3d(OGvec), new Vector3d(vec));
        }

        [Fact]
        public bool ConstructorVectorMix()
        {
            double[] values = data.getNBMix(0, 12);

            OGVector3d OGvec = new OGVector3d(values[0], values[1], values[0]);
            Vector3d vec = new Vector3d(values[0], values[1], values[0]);

            return data.compareVectorProperties(new OGVector3d(OGvec), new Vector3d(vec));
        }

        [Fact]
        public bool ConstructorPointPositive()
        {
            double[] values = data.getNBPos(0, 12);

            OGPoint3d OGpoint = new OGPoint3d(values[0], values[1], values[0]);
            Point3d point = new Point3d(values[0], values[1], values[0]);

            return data.compareVectorProperties(new OGVector3d(OGpoint), new Vector3d(point));
        }

        [Fact]
        public bool ConstructorPointNegative()
        {
            double[] values = data.getNBNeg(0, 12);

            OGPoint3d OGpoint = new OGPoint3d(values[0], values[1], values[0]);
            Point3d point = new Point3d(values[0], values[1], values[0]);

            return data.compareVectorProperties(new OGVector3d(OGpoint), new Vector3d(point));
        }

        [Fact]
        public bool ConstructorPointMix()
        {
            double[] values = data.getNBMix(0, 12);

            OGPoint3d OGpoint = new OGPoint3d(values[0], values[1], values[0]);
            Point3d point = new Point3d(values[0], values[1], values[0]);

            return data.compareVectorProperties(new OGVector3d(OGpoint), new Vector3d(point));
        }
    }
}
