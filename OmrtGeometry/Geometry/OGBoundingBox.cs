using System;

namespace OG
{
    public class BoundingBox
    {
        // PROPERTIES

        /// <summary>
        /// Gets the area of this bounding box
        /// </summary>
        public double Area
        {
            get
            {
                if (IsValid)
                {
                    return (2 * ((Max.X - Min.X) * (Max.Z - Min.Z))) + (2 * ((Max.Y - Min.Y) * (Max.Z - Min.Z)) + (2 * (Max.X - Min.X) * (Max.Y - Min.Y)));
                }
                return 0;
            }
        }

        /// <summary>
        /// Gets the point in the center of the bounding box
        /// </summary>
        public Point3d Center => new Point3d((Min[0] + Max[0]) / 2, (Min[1] + Max[1]) / 2, (Min[2] + Max[2]) / 2);
        
        /// <summary>
        /// Gets the diagonal vector of this bounding box. The diagonal connects the Min and Max points
        /// </summary>
        public Vector3d Diagonal => new Vector3d(Max[0] - Min[0], Max[1] - Min[1], Max[2] - Min[2]);

        /// <summary>
        /// Gets a value that indicates whether or not this bounding box is valid. Empty boxes are not valid, and neither are boxes with unset points
        /// </summary>
        public bool IsValid => Min.IsValid && Max.IsValid && Min[0] <= Max[0] && Min[1] <= Max[1] && Min[2] <= Max[2];
        /// <summary>
        /// Gets or sets the point in the minimal corner
        /// </summary>
        public Point3d Min { get; set; }

        /// <summary>
        /// Gets or sets the point in the maximal corner
        /// </summary>
        public Point3d Max { get; set; }

        /// <summary>
        /// Gets a bounding box that has Unset coordinates for Min and Max
        /// </summary>
        public static BoundingBox Unset => new BoundingBox(Point3d.Unset, Point3d.Unset);

        /// <summary>
        /// Gets the volume of this BoundingBox
        /// </summary>
        public double Volume
        {
            get
            {
                if (IsValid)
                {
                    return (Max.X - Min.X) * (Max.Y - Min.Y) * (Max.Z - Min.Z);
                }
                return 0;
            }
        }

        // CONSTRUCTORS

        /// <summary>
        /// Constructs a new bounding box from two corner points
        /// </summary>
        public BoundingBox(Point3d min, Point3d max)
        {
            Min = min;
            Max = max;
        }

        /// <summary>
        /// Constructs a new bounding box from numeric extremes
        /// </summary>
        public BoundingBox(double minX, double minY, double minZ, double maxX, double maxY, double maxZ) : this(new Point3d(minX, minY, minZ), new Point3d(maxX, maxY, maxZ))
        { }
    }
}
