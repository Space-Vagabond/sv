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
        Position _position;
        bool _canMove;
        int _speed;
        int _remainingSteps;
        Universe _universe;


       public Player(Universe u)
        {
            _universe = u;
            _position = new Position( 0, 0 );
            _speed = 4;
            _canMove = true;
            _remainingSteps = _speed;
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
        }
        public XElement ToXML()
        {
            return new XElement( "Player", 
                new XElement( "Speed", _speed ),
                new XElement("X", Position.X),
                new XElement("Y", Position.Y),
                new XElement( "RemainingSteps", _remainingSteps ) 
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
    }
}
