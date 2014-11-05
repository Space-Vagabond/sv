using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gv
{
    /// <summary>
    /// Two dimensional immutable point.
    /// Coordinates are in cells.
    /// </summary>
    public struct Point
    {
        public readonly int X;
        public readonly int Y;

        public Point( int x, int y )
        {
            X = x;
            Y = y;
        }

        public Point Move( Point destination )
        {
            return new Point( destination.X , destination.Y );
        }
    }
}
