using System;
using System.Collections.Generic;
using System.Linq;

namespace OG
{
    public class Point3dList
    {
        // PROPERTIES

        private static List<Point3d> Points;

        /// <summary>
        /// Even though this is a property, it is not a "fast" calculation. Every point is evaluated in order to get the bounding box of the list.
        /// </summary>
        public BoundingBox BoundingBox
        {
            get
            {
                if (Points.Count == 0)
                    return BoundingBox.Empty;
                double x_high = OGMath.UnsetValue;
                double y_high = OGMath.UnsetValue;
                double z_high = OGMath.UnsetValue;
                double x_low = OGMath.UnsetValue;
                double y_low = OGMath.UnsetValue;
                double z_low = OGMath.UnsetValue;

                foreach (var point in Points)
                {
                    x_high = setNumber(x_high, point.X, '<');
                    x_low = setNumber(x_low, point.X, '>');
                    y_high = setNumber(y_high, point.Y, '<');
                    y_low = setNumber(y_low, point.Y, '>');
                    z_high = setNumber(z_high, point.Z, '<');
                    z_low = setNumber(z_low, point.Z, '>');
                }
                return new BoundingBox(x_low, y_low, z_low, x_high, y_high, z_high);
            }
        }


        /// <summary>
        /// Gets or sets the total number of elements the internal data structure can hold without resizing.
        /// </summary>
        public int Capacity
        {
            get
            {
                return Points.Capacity;
            }
            set
            {
                Points.Capacity = value;
            }
        }
        /// <summary>
        /// Gets the number of elements actually contained in the List.
        /// </summary>
        public int Count => Points.Count;

        /// <summary>
        /// Gets or sets the first item in the list.THis is synonymous to calling List[0]
        /// </summary>
        public Point3d First
        {
            get
            {
                if (Points.Count == 0)
                    throw new IndexOutOfRangeException();
                return Points[0];
            }
            set
            {
                Points[0] = value;
            }
        }

        /// <summary>
        /// Gets or sets the element at the specified index.
        /// </summary>
        public Point3d this[int index]
        {
            get
            {
                if (index < 0 || index > Points.Count)
                    throw new IndexOutOfRangeException();
                return Points[index];
            }
            set
            {
                Points[index] = value;
            }
        }

        /// <summary>
        /// Gets or sets the last item in the list.THis is synonymous to calling List[Count -1]
        /// </summary>
        public Point3d Last
        {
            get
            {
                return Points[Count - 1];
            }
            set
            {
                Points[Count - 1] = value;
            }
        }

        /// <summary>
        /// Returns an indexer with all X coordinates in this list.
        /// </summary>
        public List<double> X()
        {
            List<double> ret = new List<double>();
            if (Points.Count == 0)
                return ret;
            foreach (var point in Points)
            {
                ret.Add(point.X);
            }
            return ret;
        }

        /// <summary>
        /// Returns an indexer with all Y coordinates in this list.
        /// </summary>
        public List<double> Y()
        {
            List<double> ret = new List<double>();
            if (Points.Count == 0)
                return ret;
            foreach (var point in Points)
            {
                ret.Add(point.Y);
            }
            return ret;
        }

        /// <summary>
        /// Returns an indexer with all Z coordinates in this list.
        /// </summary>
        public List<double> Z()
        {
            List<double> ret = new List<double>();
            if (Points.Count == 0)
                return ret;
            foreach (var point in Points)
            {
                ret.Add(point.Z);
            }
            return ret;
        }



        // CONSTRUCTORS

        /// <summary>
        /// Initializes a new empty list with default capacity
        /// </summary>
        public Point3dList()
        {
            Points = new List<Point3d>();
        }

        /// <summary>
        /// Initializes a new point list with a preallocated initial capacity.
        /// </summary>
        public Point3dList(Int32 capacity)
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException();
            Points = new List<Point3d>(capacity);
        }

        /// <summary>
        /// Constructs a new point list from values in a point array.
        /// </summary>
        public Point3dList(params Point3d[] initialPoints)
        {
            Points = initialPoints.ToList();
        }

        /// <summary>
        /// Constructs a new point list from values in a point array.
        /// </summary>
        public Point3dList(IEnumerable<Point3d> initialPoints)
        {
            Points = initialPoints.ToList();
        }

        // METHODS


        public static double setNumber(double income, double compare, char character)
        {
            if (income == OGMath.UnsetValue)
                return compare;
            if (character == '<')
            {
                if (income < compare)
                    return compare;
                return income;
            }
            if (income > compare)
                return compare;
            return income;
        }

        public void Add(Point3d point)
        {
            Points.Add(point);
        }
    }
}
