using System;
namespace OmrtGeometry.Geometry
{
    public class OGMath
    {
        /// <summary>
        /// The value of an unset object.
        /// </summary>
        public const double UnsetValue = -1.23432101234321E+308;

        public OGMath(){}

        /// <summary>
        /// Returns true if the double value is valid.
        /// </summary>
        /// <param name="x">Double value.</param>
        /// <returns>True if it is valid.</returns>
        public static bool IsValidDouble(double x)
        {
            return Math.Abs(x - UnsetValue) > double.Epsilon && !double.IsInfinity(x) && !double.IsNaN(x);
        }
    }
}
