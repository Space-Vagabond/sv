using System;
using System.Collections.Generic;
using ET.FakeText;

namespace gv
{
    public abstract class Planet
    {
         string _name;
         string _inhabitantsName;
         bool _factory;

        internal protected Planet(Universe u, string name)
        {
            _factory = false;
            if( name == null )
            {
                int n =  u.Rand.Next( 6, 9 );

                _name = u.NameGen.GenerateWord( n );
                _inhabitantsName = _name + "ians";
                _name = _name + "us";
            }
            else if( name == "Earth" )
            {
                _name = name;
                _inhabitantsName = "Terrans";
            }
            else
            {
                _name = name;
                _inhabitantsName = "Dorados";
            }
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

        public abstract string Climate { get; set; }
        public abstract string Surface { get; set; }
        public abstract string Ressources { get; }
        public abstract bool IsInhabited { get; set; }
        public string InhabitantsName
        {
            get
            {
                if( this.IsInhabited )
                {
                    return _inhabitantsName;
                }
                else
                {
                    return "Inhabited planet";
                }
            }
        }
        public bool Factory
        {
            get { return _factory; }
            set { _factory = value; }
        }
        
    }
}
