using System;
using System.Collections.Generic;
using ET.FakeText;

namespace gv
{
    public class Planet
    {
         string _name;
         static int planetNumber = 0;
         string _type;
         int _climate;
         string _surface;
         string _ressource; // todo
         bool _inhabited; //todo
         string _inhabitantsName; //todo
         string _prodRatio;

        Random rand = new Random();

        internal Planet()
        {
            TextGenerator NameGen = new TextGenerator(WordTypes.Name);
            int n =  rand.Next( 6, 9 ); 
            
            _name = NameGen.GenerateWord( n );
            _name = _name + "us";

            int t = rand.Next( 0, 10 );
            _type = PlanetAttributes.PlanetType(t);

            GeneratePlanetAttributes( t );
            
        }
        void GeneratePlanetAttributes( int t )
        {
            GenerateSurfaceAndClimate( t );
        }

        void GenerateSurfaceAndClimate( int t )
        {
            if( t == 3 )
            {
                _surface = PlanetAttributes.PlanetSurface( 0 );
                _climate = 1;
            }
            else if( t == 6 )
            {
                _surface = PlanetAttributes.PlanetSurface( 1 );
                _climate = 1;
            }
            else if( t == 9 )
            {
                _surface = PlanetAttributes.PlanetSurface( 2 );
                _climate = 1;
            }
            else if( t == 8 || t == 7 )
            {
                _surface = PlanetAttributes.PlanetSurface( 3 );
                _climate = -1;
            }
            else if( t == 4 )
            {
                _surface = PlanetAttributes.PlanetSurface( 4 );
                _climate = -1;
            }
            else
            {
                int r =  rand.Next( 5, 9 );
                _surface = PlanetAttributes.PlanetSurface( r );
                _climate = rand.Next( -1, 2 );
            }
        }
        public string Name
        {
            get { return _name; }
        }
        public string Type
        {
            get { return _type; }
        }
        public int Climate
        {
            get { return _climate; }
        }
        public string Surface
        {
            get { return _surface; }
        }
    }
}
