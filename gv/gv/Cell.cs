using System;
using System.Collections.Generic;

namespace gv
{
    class Cell
    {
        Point _position;
        bool _containsPlanet;

        public Cell( Point Pos )
        {
            _position = Pos;
        }
        public bool ContainsPlanet
        {
            get { return _containsPlanet; }
            set { _containsPlanet = value; }
        }
    }
}
