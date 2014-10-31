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
         string _ressource;
         bool _inhabited;
         string _inhabitantsName;

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
            GenerateClimate( t );
        }

        void GenerateClimate( int t )
        {
            if( t == 3 || t == 6 || t == 9 )
            {
                _climate = 1;
            }
            else if( t == 4 || t == 7 || t == 8 )
            {
                _climate = -1;
            }
            else
            {
                _climate = rand.Next( -1, 2 );
            }
        }
        void GenerateSurface( int t )
        {

        }
        public string Name
        {
            get { return _name; }
        }
        public string Type
        {
            get { return _type; }
        }
    }
}
