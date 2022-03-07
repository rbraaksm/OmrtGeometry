using System;
using OmrtGeometry.src;

namespace OmrtGeometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3d extra = new Point3d(1, 2, 3);
            Point3d test = extra;

            Console.WriteLine(test.X + "  " + test.Y + "  " + test.Z);
        }
    }
}
