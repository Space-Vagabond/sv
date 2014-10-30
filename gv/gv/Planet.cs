using System;
using System.Collections.Generic;
using ET.FakeText;

namespace gv
{
    public class Planet
    {
        internal string _name;
        internal static int planetNumber = 0;
        internal string _type;
        internal int _climate;
        internal string _surface;
        internal string _ressource;
        internal bool _inhabited;
        internal string _inhabitantsName;

        Random rand = new Random();

        internal Planet( List<string> planetTypes )
        {
            TextGenerator NameGen = new TextGenerator(WordTypes.Name);
            int n =  rand.Next( 6, 9 ); 
            
            _name = NameGen.GenerateWord( n );
            _name = _name + "us";

            int t = rand.Next( 0, 10 );
            _type = planetTypes[t];

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
    }
}
