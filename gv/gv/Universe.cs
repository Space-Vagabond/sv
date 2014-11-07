using System;
using System.Collections.Generic;


namespace gv
{
    public class Universe
    {
        public static readonly List<Planet> _planets = new List<Planet>();

        public Universe()
        {
            Planet earth = CreateEarth();    
        }       
        public Planet AddPlanet()
        {
            Planet p = new Planet();
            _planets.Add( p );
            return p;
        }
        public Planet CreateEarth()
        {
            Planet earth  =  new Planet( false );
            _planets.Add( earth );
            return earth;
        }
        public Planet CreateEldorado()
        {
           Planet eldorado =  new Planet( true );
           _planets.Add( eldorado );
           return eldorado;
        }

        public static List<Planet> Planets
        {
            get { return _planets; }
        }
    }
}
