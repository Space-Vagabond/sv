using System;
using System.Collections.Generic;
using System.Linq;

namespace gv
{
    public class Chunk
    {
        Position _position;
        Universe _container;
        readonly List<Cell>  _cells = new List<Cell>();

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
            if( _container.ShouldSpawnEldorado() )
            {
                Cell pos;
                do
                {
                    int X = _container.Rand.Next( _position.X, _position.X + 10 );
                    int Y = _container.Rand.Next( _position.Y, _position.Y + 10 );
                    pos = _cells.Where( c => c.Position.X == X && c.Position.Y == Y ).Single();
                } while(pos.ContainsPlanet );
                pos.ContainsPlanet = true;
                pos.ContainedPlanet = _container.Planets["Eldorado"];
            }
        }
        public Position Position
        {
            get { return _position; }
        }
        public List<Cell> Cells
        {
            get { return _cells; }
        }
        
    }
}
