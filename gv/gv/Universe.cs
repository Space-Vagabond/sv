using System;
using System.Collections.Generic;


namespace gv
{
    public class Universe
    {
        static readonly List<Planet> _planets = new List<Planet>();
        public static Random rand = new Random();
        public Universe()
        {
            CreateEarth();
        }       
        public static Planet AddPlanet()

        {
            return new Planet();
        }
        public static Planet AddPlanet(Position position)
        {
            return new Planet(position);
        }
        public Planet CreateEarth()
        {
            Planet earth = new Planet( false );
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
