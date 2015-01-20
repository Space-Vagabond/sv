using System;
using System.Collections.Generic;
using System.Xml.Linq;
using ET.FakeText;

namespace gv
{
    public abstract class Planet
    {
         string _name;
         string _inhabitantsName;
         bool _factory;
         bool _discovered;
         int _blocked;

        internal protected Planet(Universe u, string name)
        {
            _factory = false;
            _discovered = false;
            _blocked = 0;
            if( name == "" )
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
        internal protected Planet(Universe u, XElement attributes)
        {
            _name = attributes.Element( "Name" ).Value.ToString();
            _inhabitantsName = attributes.Element( "InhabitantsName" ).Value.ToString();
            _factory = Convert.ToBoolean( attributes.Element( "Built" ).Value );
            _blocked = Convert.ToInt32( attributes.Element( "Blocked" ).Value );
            _discovered = Convert.ToBoolean( attributes.Element( "Discovered" ).Value );
            Climate = attributes.Element( "Climate" ).Value.ToString();
            Surface = attributes.Element( "Surface" ).Value.ToString();
            Img = Convert.ToInt32( attributes.Element( "ImgId" ).Value );

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
                case 7: return new PGazeousHydrogen( u );
                case 8: return new PGazeousHelium( u );
                case 9: return new PChthonian( u );
                default: return new PTelluricSilicat( u );
            }
        }
        internal static Planet CreatePlanet( Universe u, string typeToCreate, XElement attributes )
        {
            switch( typeToCreate )
            {
                case "PTelluricSilicat": return new PTelluricSilicat( u, attributes );
                case "PTelluricCarbon": return new PTelluricCarbon( u, attributes );
                case "PTelluricMetal": return new PTelluricMetal( u, attributes );
                case "PTelluricLava": return new PTelluricLava( u, attributes );
                case "PTelluricIce": return new PTelluricIce( u, attributes );
                case "PCoreless": return new PCoreless( u, attributes );
                case "PTelluricDesert": return new PTelluricDesert( u, attributes );
                case "PGazeousHydrogen": return new PGazeousHydrogen( u, attributes );
                case "PGazeousHelium": return new PGazeousHelium( u, attributes );
                case "PChthonian": return new PChthonian( u, attributes );
                case "PDestroyed": return new Earth( u );
                case "PPromisedLand": return new Eldorado( u );
                default: return new PTelluricSilicat( u, attributes );
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
        public abstract int Img { get;internal set; }
        public bool IsDiscovered
        {
            get { return _discovered; }
            set { _discovered = value; }
        }
        public int Blocked
        {
            get { return _blocked; } 
            set { _blocked = value;}
        }
    }
}
