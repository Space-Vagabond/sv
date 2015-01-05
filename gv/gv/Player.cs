using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        Universe _universe;
        Dictionary<string, int> _ressources = new Dictionary<string,int>();
        bool _gazExtractor;
        bool _gemsExtractor;
        bool _plutoniumExtractor;
        bool _hydrogenEngine;
        bool _heliumEngine;
        bool _plutoniumEngine;
        bool _factoryUpgrade;
        bool _radar;
        bool _diplomacy;
        bool _workers;
        bool _slavery;

        
       public Player(Universe u)
        {
            _universe = u;
            _position = new Position( 0, 0 );
            _speed = 4000;
            _canMove = true;
            _remainingSteps = _speed;

            _gazExtractor = false;
            _gemsExtractor = false;
            _plutoniumExtractor = false;
            _hydrogenEngine = false;
            _heliumEngine = false;
            _plutoniumEngine = false;
            _factoryUpgrade = false;
            _radar = false;
            _diplomacy = false;
            _workers = false;
            _slavery = false;

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
                    _ressources[p.Ressources] += 10;
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
        public bool GazExtractor
        {
            get { return _gazExtractor; }
        }
        public bool GemsExtractor
        {
            get { return _gemsExtractor; }
        }
        public bool PlutoniumExtractor
        {
            get { return _plutoniumExtractor; }
        }
        public bool HydrogenEngine
        {
            get { return _hydrogenEngine; }
        }
        public bool HeliumEngine
        {
            get { return _heliumEngine; }
        }
        public bool PlutoniumEngine
        {
            get { return _plutoniumEngine; }
        }
        public bool FactoryUpgrade
        {
            get { return _factoryUpgrade; }
        }
        public bool Radar
        {
            get { return _radar; }
        }
        public bool Diplomacy
        {
            get { return _diplomacy; }
        }
        public bool Workers
        {
            get { return _workers; }
        }
        public bool Slavery
        {
            get { return _slavery; }
        }
    }
}
