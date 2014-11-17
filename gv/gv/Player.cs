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


       public Player()
        {
            _position = new Position( 0, 0 );
            _speed = 4;
            _canMove = true;
            _remainingSteps = _speed;
        }
        public void MovePlayer( Position destination )
        {
            int _movedX;
            int _movedY;
            int _movedOf;

            _movedX = Math.Max( _position.X, destination.X ) - Math.Min( _position.X, destination.X );
            _movedY = Math.Max( _position.Y, destination.Y ) - Math.Min( _position.Y, destination.Y );
            _movedOf = _movedX + _movedY;

            if( _movedOf <= _remainingSteps && _canMove == true )
            {
                _position = _position.Move( destination );
                _remainingSteps -= _movedOf;
            }
            else
            {
                //write poopup error function
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
    }
}
