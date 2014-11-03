using System;
using System.Collections.Generic;


namespace gv
{
    public class Universe
    {
        
        public Universe()
        {
            CreateEarth();
        }       
        public Planet AddPlanet()
        {
            return new Planet();
        }
        public Planet CreateEarth()
        {
            return new Planet( false );
        }
        public Planet CreateEldorado()
        {
            return new Planet( true );
        }
    }
}
