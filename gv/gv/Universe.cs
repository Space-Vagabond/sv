using System;
using System.Collections.Generic;


namespace gv
{
    public class Universe
    {
        public readonly List<string> _planetTypes = new List<string>();
        public Universe()
        {
            InitPlanetTypes();
        }
        void InitPlanetTypes()
        {
            _planetTypes.Add( "Telluric Silicat" );
            _planetTypes.Add( "Telluric Carbon" );
            _planetTypes.Add( "Telluric Metal" );
            _planetTypes.Add( "Telluric Lava" );
            _planetTypes.Add( "Telluric Ice" );
            _planetTypes.Add( "Telluric Desert" );
            _planetTypes.Add( "Coreless" );
            _planetTypes.Add( "Gazeous Hydrogen" );
            _planetTypes.Add( "Gazeous Helium" );
            _planetTypes.Add( "Chthonian" );
        }
        public Planet AddPlanet()
        {
            return new Planet( _planetTypes );
        }
    }
}
