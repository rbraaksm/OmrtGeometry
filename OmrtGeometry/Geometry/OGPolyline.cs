using System;
using System.Collections.Generic;

namespace OG
{
    public class Polyline : Point3dList
    {
        // PROPERTIES

        //  CONSTRUCTORS

        /// <summary>
        /// Initializes a new empty polyline.
        /// </summary>
        public Polyline()
        {
            new Point3dList();
        }

        /// <summary>
        /// Initializes a new empty polyline with an initial capacity.
        /// </summary>
        public Polyline(Int32 initialCapacity)
        {
            new Point3dList(initialCapacity);
        }

        /// <summary>
        /// Initializes a new polyline from a collection of points.
        /// </summary>
        public Polyline(IEnumerable<Point3d> collection)
        {
            new Point3dList(collection);
        }

        
    }
}
