using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;

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
        public Cell( Universe u, XElement attributes )
        {
            _containerU = u;
            _position.X = Convert.ToInt32( attributes.Element( "X" ).Value );
            _position.Y = Convert.ToInt32( attributes.Element( "Y" ).Value );

            _containerC = (from C in u.Chunks.Values
                           where (C.Position.X == Convert.ToInt32( attributes.Element( "containerX" ).Value ) && C.Position.Y == Convert.ToInt32( attributes.Element( "containerY" ).Value ))
                           select C).Single();

            _containsPlanet = Convert.ToBoolean( attributes.Element( "ContainsPlanet" ).Value );
            if( _containsPlanet )
            {
                _planet = (from P in u.Planets.Values
                           where P.Name == attributes.Element( "ContainedPlanet" ).Value.ToString()
                           select P).Single();
            }
            else
            {
                _planet = null;
            }
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
