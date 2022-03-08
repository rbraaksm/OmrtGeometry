using System;
using OmrtGeometry.Geometry;

namespace OmrtGeometry
{
    class Program
    {

        static void Main(string[] args)
        {


            GShark.Geometry.Point3 extra = new GShark.Geometry.Point3(20, 30, 50);

            OGVector3d test1 = new OGVector3d(3, 5, 6);
            OGVector3d test2 = new OGVector3d(4, 5, 6);

            Console.WriteLine(test1.CompareTo(test2));

            //Console.WriteLine(extra.IsUnitVector);
            //Console.WriteLine(extra.IsValid);
            //Console.WriteLine(extra.IsZero);


        }
    }
}
