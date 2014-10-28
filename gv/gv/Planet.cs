using System;
using System.Collections.Generic;
using ET.FakeText;

namespace gv
{
    public class Planet
    {
        public string _name;
        public static int planetNumber = 0;
        public string _type;
        Random rand = new Random();

        internal Planet( List<string> planetTypes )
        {
            TextGenerator NameGen = new TextGenerator(WordTypes.Name);
            int n =  rand.Next( 6, 9 ); 
            
            _name = NameGen.GenerateWord( n );
            _name = _name + "us";

            int t = rand.Next( 0, 10 );
            _type = planetTypes[t];
        }
    }
}
