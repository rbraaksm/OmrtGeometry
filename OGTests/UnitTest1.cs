using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using OGVector3d = OG.Vector3d;
using Vector3d = Rhino.Geometry.Vector3d;

namespace OGTests
{

    [TestClass]
    public class TestVector3d
    {
        Random rand = new Random();

        public double[] setNBPos()
        {
            double[] ret = new double[6];
            ret[0] = rand.NextDouble() * 100;
            ret[1] = rand.NextDouble() * 100;
            ret[2] = rand.NextDouble() * 100;
            ret[3] = rand.NextDouble() * 100;
            ret[4] = rand.NextDouble() * 100;
            ret[5] = rand.NextDouble() * 100;

            return ret;
        }

        [TestMethod]
        public void ConstructorDoubleDoubleDouble()
        {
            double[] nbPos = setNBPos();

            Vector3d OGvec = new Vector3d(0, 0, 0);

            Console.WriteLine(nbPos[0]);
            Assert.AreEqual(0, 0);
        }

        [TestMethod]
        public void testing()
        {
            //nbPos = setNBPos();
            //Console.WriteLine(nbPos[0]);
        }
    }
}
