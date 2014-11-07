using System;
using System.Collections.Generic;

namespace gv
{
    public class Chunk
    {
        Point _position;
        List<Cell>  _cells = new List<Cell>();

        public Chunk( Point Begining )
        {
            Cell c;

            _position = Begining;
            for( int i = 0; i < 5; i++ )
            {
                for (int j = 0; j < 5; j++)
			    {
                    c = new Cell(new Point(Begining.X+i, Begining.Y+j));
                    _cells.Add( c );
                }
			}           
        }
        void InitializeCells()
        {
            int planetCounter = 0;

            foreach( Cell c in _cells )
            {
                if( planetCounter <= 8 )
                {
                    c.ContainsPlanet = ((Universe.rand.Next( 0, 2 ) > 0) ? true : false);
                }
                else
                {
                    c.ContainsPlanet = false;
                }
            }
        }
    }
}
