using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace gv
{
    public class Player
    {
        string _name;
        Position _position;
        bool _canMove;
        int _speed;
        int _remainingSteps;
        int _resRate;
        Universe _universe;
        Dictionary<string, int> _ressources = new Dictionary<string, int>();
        Dictionary<string, int> _totalRessources = new Dictionary<string, int>();
        
       public Player(Universe u)
        {
            _universe = u;
            _position = new Position( 0, 0 );
            _speed = 4000;
            _canMove = true;
            _remainingSteps = _speed;
            _resRate = 10;

            foreach( string s in PlanetAttributes.PlanetRessources )
            {
                if( s != "none" )
                {
                    _ressources.Add( s, 100000 );
                    _totalRessources.Add( s, 0 );
                }
            }
        }

       public Player( Universe u, XElement Psave )
       {
           _universe = u;
           _name = Psave.Element( "Name" ).Value;
           _speed = Convert.ToInt32(Psave.Element( "Speed" ).Value);
           _canMove = Convert.ToBoolean( Psave.Element( "Move" ).Value );
           _position.X = Convert.ToInt32( Psave.Element( "X" ).Value );
           _position.Y = Convert.ToInt32( Psave.Element( "Y" ).Value );
           _remainingSteps = Convert.ToInt32( Psave.Element( "RemainingSteps" ).Value );
           _resRate = Convert.ToInt32( Psave.Element( "ResRate" ).Value );

           foreach( XElement ressource in Psave.Element( "Ressources" ).Elements() )
           {
               _ressources.Add( ressource.Name.ToString(), Convert.ToInt32( ressource.Value ) );
           }
           foreach( XElement Tressource in Psave.Element( "TotalRessources" ).Elements() )
           {
               _totalRessources.Add( Tressource.Name.ToString(), Convert.ToInt32( Tressource.Value ) );
           }
       }
        public bool Move( Position destination )
        {
            if( _canMove == false )
            {
                return false;
            }
            else
            {
                if( _remainingSteps > 0 )
                {
                    _remainingSteps--;
                    _position = destination;
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        internal void EndTurn()
        {
            _remainingSteps = _speed;
            foreach( Planet p in _universe.Planets.Values )
            {
                if( p.Ressources != "none" && p.Factory == true )
                {
                    _ressources[p.Ressources] += _resRate ;
                    _totalRessources[p.Ressources] += _resRate;
                }
            }

        }
        public XElement ToXML()
        {
            return new XElement( "Player",
                new XElement( "Name", _name ),
                new XElement( "Speed", _speed ),
                new XElement("Move", _canMove),
                new XElement("X", Position.X),
                new XElement("Y", Position.Y),
                new XElement( "RemainingSteps", _remainingSteps ),
                new XElement("ResRate", _resRate),
                new XElement("Ressources",
                    from p in _ressources
                        select new XElement(p.Key,p.Value)                   
                ),
                new XElement("TotalRessources",
                    from p in _totalRessources
                        select new XElement(p.Key,p.Value)                    
                )
            );
        }
        public bool UnlockTech( int idAsked )
        {
            Type type = typeof( Tech );           
            
            foreach( string s in PlanetAttributes.PlanetRessources )
            {
                if( s != "none" )
                {
                    object o = _universe.Techs[idAsked];
                    PropertyInfo property = type.GetProperty( "Cost" + s, typeof( int ) );
                    Debug.Assert( property != null, "Cost"+s+" must be int!" );

                    object value =  property.GetValue( o );

                    if( _ressources[s] < (int)value ) return false;
                }
            }
            foreach( string s in PlanetAttributes.PlanetRessources )
            {
                if( s != "none" )
                {
                    object o = _universe.Techs[idAsked];
                    PropertyInfo property = type.GetProperty( "Cost" + s, typeof( int ) );
                    object value =  property.GetValue( o );

                    _ressources[s] -= (int)value;
                }
            }
            switch( idAsked )
            {
                case 3:
                    _speed = 10;
                    break;
                case 4:
                    _speed = 15;
                    break;
                case 5:
                    _speed = 20;
                    break;
                case 6:
                    _resRate += 5;
                    break;
                case 9:
                    _resRate += 2;
                    break;
                case 10:
                    _resRate += 3;
                    break;
                case 11:
                    _resRate += 5;
                    break;
                default:
                    break;
            }
            return true;
        }
        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }
        public Position Position
        {
            get { return _position; }
            set { _position = value; }
        }
        public int RemainingSteps
        {
            get { return _remainingSteps; }
            set { _remainingSteps = value; }
        }
        public Dictionary<string, int> Ressources
        {
            get { return _ressources; }
            set { _ressources = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Rate
        {
            get { return _resRate; }
        }
        public Dictionary<string, int> TotalRessources
        {
            get { return _totalRessources; }
        }
    }
}
