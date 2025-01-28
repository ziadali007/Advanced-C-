using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C_
{
    internal class Point : IComparable<Point>
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int CompareTo(Point? Other)
        {
            if (Other is not null)
            {
                 if (X < Other.X) return Y.CompareTo(Other.Y);
                 return X.CompareTo(Other.X);
               
            }
            return 1;
        }

        public override string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }
    }
}
