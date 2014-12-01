using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            _speed = 400;
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
        public int X
        {
            get { return _position.X; }
            set { _position.X = value; }
        }

        public int Y
        {
            get { return _position.Y; }
            set { _position.Y = value; }
        }
        public Universe Univ
        {
            get { return _universe; }
         }
    }
}
