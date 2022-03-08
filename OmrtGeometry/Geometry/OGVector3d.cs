using System;

namespace OmrtGeometry.Geometry
{
    public class OGVector3d
    {
        // Properties

        /// <summary>
        /// Gets a value indicating whether or not this is a unit vector. A unit vector has length 1.
        /// </summary>
        public bool IsUnitVector => Math.Abs(GetLengthHelper(X, Y, Z) - 1.0) <= 1E-10;
        
        /// <summary>
        /// Gets a value indicating whether this vector is valid.A valid vector must be formed of valid component values for x, y and z.
        /// </summary>
        public bool IsValid => OGMath.IsValidDouble(X) && OGMath.IsValidDouble(Y) && OGMath.IsValidDouble(Z);

        /// <summary>
        /// Gets a value indicating whether the X, Y, and Z values are all equal to 0.0.
        /// </summary>
        public bool IsZero => Object.Equals(X, 0.0) && Object.Equals(Y, 0.0) && Object.Equals(Z, 0.0);
       
        /// <summary>
        /// Gets or sets a vector component at the given index.
        /// </summary>
        public double this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return X;
                    case 1:
                        return Y;
                    case 2:
                        return Z;
                    default:
                        throw new IndexOutOfRangeException();
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
        /// Computes the length (or magnitude, or size) of this vector. This is an application of Pythagoras' theorem. If this vector is invalid, its length is considered 0.
        /// </summary>
        public double Length => GetLengthHelper(X, Y, Z);

        /// <summary>
        /// Gets the largest (both positive and negative) component value in this vector.
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
        /// Gets the smallest (both positive and negative) coordinate value in this vector.
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
        /// Computes the squared length (or magnitude, or size) of this vector. This is an application of Pythagoras' theorem. While the Length property checks for input validity,
        /// this property does not. You should check validity in advance, if this vector can be invalid.
        /// </summary>
        public double SquareLength => X * X + Y * Y + Z * Z;

        /// <summary>
        /// Gets the value of the vector with each component set to RhinoMath.UnsetValue.
        /// </summary>
        public static OGVector3d Unset => new OGVector3d(OGMath.UnsetValue, OGMath.UnsetValue, OGMath.UnsetValue);

        /// <summary>
        /// Gets or sets the X (first) coordinate of this point.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Gets the value of the vector with components 1,0,0.
        /// </summary>
        public static OGVector3d XAxis => new OGVector3d(1.0, 0.0, 0.0);

        /// <summary>
        /// Gets or sets the Y (second) coordinate of this point.
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Gets the value of the vector with components 0,1,0.
        /// </summary>
        public static OGVector3d YAxis => new OGVector3d(0.0, 1.0, 0.0);
        /// <summary>
        /// Gets or sets the Z (third) coordinate of this point.
        /// </summary>
        public double Z { get; set; }

        /// <summary>
        /// Gets the value of the vector with components 0,0,1.
        /// </summary>
        public static OGVector3d ZAxis => new OGVector3d(0.0, 0.0, 1.0);

        /// <summary>
        /// Gets the value of the vector with components 0,0,0.
        /// </summary>
        public static OGVector3d Zero => new OGVector3d(0, 0, 0);

        // Constructors

        /// <summary>
        /// Initializes a new vector by copying coordinates from a point.
        /// </summary>
        /// <param name="point">A point.</param>
        public OGVector3d(OGPoint3d point) : this(point.X, point.Y, point.Z)
        {}

        /// <summary>
        /// Initializes a new vector by copying coordinates from another vector.
        /// </summary>
        /// <param name="vector">A point.</param>
        public OGVector3d(OGVector3d vector) : this(vector.X, vector.Y, vector.Z)
        { }

        /// <summary>
        /// Initializes a new vector by defining the X, Y and Z coordinates.
        /// </summary>
        /// <param name="x">The value of the X (first) coordinate.</param>
        /// <param name="y">The value of the Y (second) coordinate.</param>
        /// <param name="z">The value of the Z (third) coordinate.</param>
        public OGVector3d(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <param name="dx"></param>
        /// <param name="dy"></param>
        /// <param name="dz"></param>
        /// <returns></returns>
        internal static double GetLengthHelper(double dx, double dy, double dz)
        {
            if (!OGMath.IsValidDouble(dx) || !OGMath.IsValidDouble(dy) || !OGMath.IsValidDouble(dz))
            {
                return 0.0;
            }

            double num = Math.Abs(dx);
            double num2 = Math.Abs(dy);
            double num3 = Math.Abs(dz);
            if (num2 >= num && num2 >= num3)
            {
                double num4 = num;
                num = num2;
                num2 = num4;
            }
            else if (num3 >= num && num3 >= num2)
            {
                double num4 = num;
                num = num3;
                num3 = num4;
            }

            if (num > 2.2250738585072014E-308)
            {
                double num4 = 1.0 / num;
                num2 *= num4;
                num3 *= num4;
                return num * Math.Sqrt(1.0 + num2 * num2 + num3 * num3);
            }

            if (num > 0.0 && OGMath.IsValidDouble(num))
            {
                return num;
            }

            return 0.0;
        }

        public int CompareTo(OGVector3d other)
        {
            if (X == other.X && Y == other.Y && Z == other.Z)
            {
                return 0;
            }

            if (X != other.X)
            {
                return OGMath.ComparingValues(X, other.X);
            }

            if (Y != other.Y)
            {
                return OGMath.ComparingValues(Y, other.Y);
            }

            return OGMath.ComparingValues(Z, other.Z);
        }
    }
}
