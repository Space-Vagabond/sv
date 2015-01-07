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
        Dictionary<string, int> _ressources = new Dictionary<string,int>();
        
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
                    _ressources.Add( s, 0 );
                }
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
                }
            }

        }
        public XElement ToXML()
        {
            return new XElement( "Player",
                new XElement( "Name", _name ),
                new XElement( "Speed", _speed ),
                new XElement("X", Position.X),
                new XElement("Y", Position.Y),
                new XElement( "RemainingSteps", _remainingSteps ),
                new XElement("Ressources",
                    from p in _ressources
                        select new XElement("Ressource",
                            new XElement(p.Key,p.Value)
                    )
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
    }
}
