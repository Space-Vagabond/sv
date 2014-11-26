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
            
            switch( u.Rand.Next( 10 ))
            {
                case 0: return new PTelluricSilicat( u );
                case 1: return new PTelluricCarbon( u );
                case 2: return new PTelluricMetal( u );
                case 3: return new PTelluricLava( u );
                case 4: return new PTelluricIce( u );
                case 5: return new PCoreless( u );
                case 6: return new PTelluricDesert( u );
                case 7: return new PGazeousHydrogene( u );
                case 8: return new PGazeousHelium( u );
                case 9: return new PChthonian( u );
                default: return new PTelluricSilicat( u );
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
