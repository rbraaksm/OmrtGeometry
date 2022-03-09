using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGTests
{
    internal class Data
    {
        Random random = new Random();

        public double[] nbPos
        {
            get
            {
                return nbPos;
            }
            set
            {
                nbPos[0] = random.NextDouble() * 50;
                nbPos[1] = random.NextDouble() * 50;
                nbPos[2] = random.NextDouble() * 50;
                nbPos[3] = random.NextDouble() * 50;
                nbPos[4] = random.NextDouble() * 50;
                nbPos[5] = random.NextDouble() * 50;
                nbPos[6] = random.NextDouble() * 100;
                nbPos[7] = random.NextDouble() * 100;
                nbPos[8] = random.NextDouble() * 100;
                nbPos[9] = random.NextDouble() * 100;
                nbPos[10] = random.NextDouble() * 100;
                nbPos[11] = random.NextDouble() * 100;

            }
        }
        public double[] nbNeg
        {
            get
            {
                return nbNeg;
            }
            set
            {
                nbNeg[0] = random.NextDouble() * 50;
                nbNeg[1] = random.NextDouble() * 50;
                nbNeg[2] = random.NextDouble() * 50;
                nbNeg[3] = random.NextDouble() * 50;
                nbNeg[4] = random.NextDouble() * 50;
                nbNeg[5] = random.NextDouble() * 50;
                nbNeg[6] = random.NextDouble() * 100;
                nbNeg[7] = random.NextDouble() * 100;
                nbNeg[8] = random.NextDouble() * 100;
                nbNeg[9] = random.NextDouble() * 100;
                nbNeg[10] = random.NextDouble() * 100;
                nbNeg[11] = random.NextDouble() * 100;
            }
        }
        public double[] nbMix
        {
            get
            {
                return nbMix;
            }
            set
            {
                nbMix[0] = random.NextDouble() * -50;
                nbMix[1] = random.NextDouble() * 50;
                nbMix[2] = random.NextDouble() * -50;
                nbMix[3] = random.NextDouble() * 50;
                nbMix[4] = random.NextDouble() * -50;
                nbMix[5] = random.NextDouble() * 50;
                nbMix[6] = random.NextDouble() * -100;
                nbMix[7] = random.NextDouble() * 100;
                nbMix[8] = random.NextDouble() * -100;
                nbMix[9] = random.NextDouble() * 100;
                nbMix[10] = random.NextDouble() * -100;
                nbMix[11] = random.NextDouble() * 100;
            }
        }

    }
}
