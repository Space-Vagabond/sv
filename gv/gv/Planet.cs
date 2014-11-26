using System;
using System.Collections.Generic;
using ET.FakeText;

namespace gv
{
    public abstract class Planet
    {
         string _name;
         string _inhabitantsName;

        internal protected Planet(Universe u)
        {
            TextGenerator NameGen = new TextGenerator(WordTypes.Name);
            int n =  u.Rand.Next( 6, 9 ); 
            
            _name = NameGen.GenerateWord( n );
            _inhabitantsName = _name + "ians";
            _name = _name + "us";           
        }
        
        internal static Planet CreatePlanet( Universe u )
        {
            int iType = u.Rand.Next( 10 );
            switch( iType )
            {
                case 0: return new PChthonian( u );
                default: return new PTelluricMetal( u );
            }
        }
        
        public string Name
        {
            get { return _name; }
        }
        public abstract string Type { get; }

        public override string Climate { get; }
        public override string Surface { get; }
        public override string Ressource { get;  }
        public override bool Inhabited { get; }
        public string InhabitantsName
        {
            get
            {
                if( this.Inhabited )
                {
                    return _inhabitantsName;
                }
                else
                {
                    return "Inhabited planet";
                }
            }
        }
        
    }
}
