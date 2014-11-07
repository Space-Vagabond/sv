using System;
using System.Collections.Generic;


namespace gv
{
    public class Universe
    {
        public static readonly List<Planet> _planets = new List<Planet>();
        public static Random rand = new Random();
        public Universe()
        {
            CreateEarth();
        }       
        public static Planet AddPlanet()

        {
            return new Planet();
        }
        public static Planet AddPlanet(Point position)
        {
            return new Planet(position);
        }
        public Planet CreateEarth()
        {
            return new Planet( false );
        }
        public Planet CreateEldorado()
        {
            return new Planet( true );
        }
        public static List<Planet> Planets
        {
            get { return _planets; }
        }
    }
}
