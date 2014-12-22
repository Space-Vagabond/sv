using System;
using System.Collections.Generic;

namespace gv
{
    public class Cell
    {
        Position _position;
        bool _containsPlanet;
        Planet _planet;
        Universe _containerU;
        Chunk _containerC;

        public Cell( Position Pos, Universe u, Chunk c )
        {
            _containerU = u;
            _containerC = c;
            _position = Pos;
        }
        public void AddPlanet()
        {
            _planet = _containerU.AddPlanet();
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
        public Chunk ContainerChunck
        {
            get { return _containerC; }
        }
    }
}
