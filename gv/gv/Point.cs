using System;
using System.Collections.Generic;

namespace gv
{
    /// <summary>
    /// Two dimensional immutable point.
    /// Coordinates are in cells.
    /// </summary>
    public struct Position
    {
        public readonly int X;
        public readonly int Y;

        public Position( int x, int y )
        {
            X = x;
            Y = y;
        }

        public Position Move( Position destination )
        {
            return new Position( destination.X , destination.Y );
        }
    }
}
