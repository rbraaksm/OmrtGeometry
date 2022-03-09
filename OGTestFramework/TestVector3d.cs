using System;
using Xunit;

namespace OGTestFramework
{
    public class TestVector3d
    {
        Random rand = new Random();
        double[] nbPos = new double[6];
        double[] nbNeg = new double[6];

        [Fact]
        public void ConstructorDoubleDoubleDouble()
        {
            nbPos[0] = rand.NextDouble() * 100;
            nbPos[1] = rand.NextDouble() * 100;
            nbPos[2] = rand.NextDouble() * 100;
            nbPos[3] = rand.NextDouble() * 100;
            nbPos[4] = rand.NextDouble() * 100;
            nbPos[5] = rand.NextDouble() * 100;

            Console.WriteLine("test");
            Console.WriteLine(nbPos[0]);
        }
    }
}
