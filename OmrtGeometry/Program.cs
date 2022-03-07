using System;
using OmrtGeometry.Geometry;

namespace OmrtGeometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3d extra = new Vector3d(0, 0, 0);

            Console.WriteLine(extra.X + "  " + extra.Y + "  " + extra.Z);

            Console.WriteLine(extra.IsUnitVector);
            Console.WriteLine(extra.IsValid);
            Console.WriteLine(extra.IsZero);


        }
    }
}
