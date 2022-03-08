using System;

namespace OmrtGeometry.Geometry
{
    public class OGBoundingBox
    {
        // PROPERTIES

        /// <summary>
        /// Gets or sets the point in the minimal corner
        /// </summary>
        public OGPoint3d Min { get; set; }

        /// <summary>
        /// Gets or sets the point in the maximal corner
        /// </summary>
        public OGPoint3d Max { get; set; }

        /// <summary>
        /// Gets a bounding box that has Unset coordinates for Min and Max
        /// </summary>
        public static OGBoundingBox Unset => new OGBoundingBox(OGPoint3d.Unset, OGPoint3d.Unset);

        // CONSTRUCTORS

        /// <summary>
        /// Constructs a new bounding box from two corner points
        /// </summary>
        public OGBoundingBox(OGPoint3d min, OGPoint3d max)
        {
            Min = min;
            Max = max;
        }

        /// <summary>
        /// Constructs a new bounding box from numeric extremes
        /// </summary>
        public OGBoundingBox(double minX, double minY, double minZ, double maxX, double maxY, double maxZ) : this(new OGPoint3d(minX, minY, minZ), new OGPoint3d(maxX, maxY, maxZ))
        { }
    }
}
