using System;

namespace OGTests
{
    internal class Data
    {
        Random random = new Random();

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
