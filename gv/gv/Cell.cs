using System;
using System.Collections.Generic;

namespace gv
{
    public class Cell
    {
        Position _position;
        bool _containsPlanet;
        Planet _planet;

        public Cell( Position Pos )
        {
            _position = Pos;
        }
        public void AddPlanet()
        {
            _planet = Universe.AddPlanet();
        }

        public bool ContainsPlanet
        {
            get { return _containsPlanet; }
            set { _containsPlanet = value; }
        }
        public Position Position
        {
            get { return _position; }
            set { _position = value; }
        }
        public Planet ContainedPlanet
        {
            get { return _planet; }
            set { _planet = value; }
        }
    }
}
