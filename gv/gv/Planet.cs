using System;
using System.Collections.Generic;
using ET.FakeText;



namespace gv
{
    public class Planet
    {
        public string _name;
        public static int planetNumber;
        Random rand = new Random();
        public Planet()
        {
            TextGenerator NameGen = new TextGenerator(WordTypes.Name);
            int n =  rand.Next( 6, 9 ); 
            
            _name = NameGen.GenerateWord( n );
            _name = _name + "us";

        }
    }
}
