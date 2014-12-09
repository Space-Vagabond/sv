using System;
using System.Collections.Generic;

namespace gv
{
    public class Chunk
    {
        Position _position;
        Universe _container;
        public readonly List<Cell>  _cells = new List<Cell>();

        public Chunk( Position Begining, Universe u )
        {
            _container = u;

            _position = Begining;
            for( int i = 0; i < 10; i++ )
            {
                for (int j = 0; j < 10; j++)
			    {
                    Cell c = new Cell( new Position( Begining.X + i, Begining.Y + j ), _container, this );
                    _cells.Add( c );
                    _container.Cells.Add( c );
                }
			}
            InitializeCells();
        }
        void InitializeCells()
        {
            int planetCounter = 0;

            foreach( Cell c in _cells )
            {
                if( c.Position.X == 0 && c.Position.Y == 0 )
                {
                    c.ContainsPlanet = true;
                    c.ContainedPlanet = _container.CreateEarth();

                }
                else if( planetCounter < 8 )
                {
                    c.ContainsPlanet = ((_container.Rand.Next( 0, 9 ) == 0) ? true : false);
                    if( c.ContainsPlanet )
                    {
                        c.AddPlanet();
                        planetCounter++;
                        if( planetCounter > 8 ) { throw new InvalidOperationException( "TAS TROP DE PLANETES RETARD" ); }
                    }
                }
                else
                {
                    c.ContainsPlanet = false;
                }

            }
        }
        public Position Position
        {
            get { return _position; }
        }
        
    }
}
