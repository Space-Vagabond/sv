using System;
using System.Collections.Generic;

namespace gv
{
    class Cell
    {
        Position _position;
        bool _containsPlanet;

        public Cell( Position Pos )
        {
            _position = Pos;
        }
        public void AddPlanet()
        {
            Universe.AddPlanet( _position );
        }
        public bool ContainsPlanet
        {
            get { return _containsPlanet; }
            set { _containsPlanet = value; }
        }
        public Point Position
        {
            get { return _position; }
            set { _position = value; }
        }
    }
}
