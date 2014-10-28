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
        internal string _climate;
        internal string _surface;
        internal string _ressource;
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
            switch (t)
             {
                 case 0:
                     
                     break;
                 case 1:
                     
                     break;
                 case 2:
                     
                     break;
                 case 3:
                     
                     break;
                 case 4:
                     break;
                 case 5:
                     break;
                 case 6:
                     break;
                 case 7:
                     break;
                 case 8:
                     break;
                 case 9:
                     break;
                 default:
                     break;
             };
        }
    }
}
