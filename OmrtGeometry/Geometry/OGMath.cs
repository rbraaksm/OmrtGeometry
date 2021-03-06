using System;

namespace OG
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

        /// <summary>
        /// Comparing two values. If value1 < value2 return -1 else 1
        /// </summary>
        public static int ComparingValues(double value1, double value2)
        {
            if (value1 < value2)
            {
                return -1;
            }
            return 1;
        }

        public static decimal Truncate(double value, byte decimals = 6)
        {
            decimal d = (decimal)value;
            decimal r = Math.Round(d, decimals);

            if (d > 0 && r > d)
            {
                return r - new decimal(1, 0, 0, false, decimals);
            }
            if (d < 0 && r < d)
            {
                return r + new decimal(1, 0, 0, false, decimals);
            }

            return r;
        }
    }
}
