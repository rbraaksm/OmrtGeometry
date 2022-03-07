using System;

namespace OmrtGeometry.Geometry
{
    public class Point3d
    {
        // Properties

        /// <summary>
        /// Each coordinate of the point must pass the <see cref="OGMath.IsValidDouble"/> test.
        /// </summary>
        public bool IsValid => OGMath.IsValidDouble(X) && OGMath.IsValidDouble(Y) && OGMath.IsValidDouble(Z);

        /// <summary>
        /// Gets or sets an indexed coordinate of this point.
        /// </summary>
        public double this[int index]
        {
            get
            {
                return index switch
                {
                    0 => X,
                    1 => Y,
                    2 => Z,
                    _ => throw new IndexOutOfRangeException()
                };
            }
            set
            {
                if (index < 0 || index > 2)
                    throw new IndexOutOfRangeException();
                switch (index)
                {
                    case 0:
                        X = value;
                        break;
                    case 1:
                        Y = value;
                        break;
                    case 2:
                        Z = value;
                        break;
                }
            }
        }

        /// <summary>
        /// Gets the largest (both positive and negative) valid coordinate in this point, or RhinoMath.UnsetValue if no coordinate is valid.
        /// </summary>
        public double MaximumCoordinate
        {
            get
            {
                if (this.IsValid)
                {
                    return Math.Max(Math.Max(Math.Abs(X), Math.Abs(Y)), Math.Abs(Z));
                }
                return OGMath.UnsetValue;
            }
        }

        /// <summary>
        /// Gets the smallest (both positive and negative) coordinate value in this point.
        /// </summary>
        public double MinimunCoordinate
        {
            get
            {
                if (this.IsValid)
                {
                    return Math.Min(Math.Min(Math.Abs(X), Math.Abs(Y)), Math.Abs(Z));
                }
                return OGMath.UnsetValue;
            }
        }

        /// <summary>
        /// Gets the value of a point at location 0,0,0.
        /// </summary>
        public static Point3d Origin => new Point3d(0, 0, 0);

        /// <summary>
        /// Gets the value of a point at location RhinoMath.UnsetValue,RhinoMath.UnsetValue,RhinoMath.UnsetValue.
        /// </summary>
        public static Point3d Unset => new Point3d(OGMath.UnsetValue, OGMath.UnsetValue, OGMath.UnsetValue);

        /// <summary>
        /// Gets or sets the X (first) coordinate of this point.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Gets or sets the Y (second) coordinate of this point.
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Gets or sets the Z (third) coordinate of this point.
        /// </summary>
        public double Z { get; set; }


        // Constructors
        
        /// <summary>
        /// Initializes a new point by copying coordinates from another point.
        /// </summary>
        /// <param name="point">A point.</param>
        public Point3d(Point3d point) : this(point.X, point.Y, point.Z)
        { }

        /// <summary>
        /// Initializes a new point by defining the X, Y and Z coordinates.
        /// </summary>
        /// <param name="x">The value of the X (first) coordinate.</param>
        /// <param name="y">The value of the Y (second) coordinate.</param>
        /// <param name="z">The value of the Z (third) coordinate.</param>
        public Point3d(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
