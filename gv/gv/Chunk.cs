﻿using System;
using System.Collections.Generic;

namespace gv
{
    public class Chunk
    {
        Position _position;
        public readonly List<Cell>  _cells = new List<Cell>();

        public Chunk( Position Begining )
        {
            _position = Begining;
            for( int i = 0; i < 10; i++ )
            {
                for (int j = 0; j < 10; j++)
			    {
                    Cell c = new Cell( new Position( Begining.X + i, Begining.Y + j ) );
                    _cells.Add( c );
                    Universe.Cells.Add( c );
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
                    c.ContainedPlanet = Universe.CreateEarth();

                }
                else if( planetCounter < 8 )
                {

                    c.ContainsPlanet = ((Universe.rand.Next( 0, 2 ) > 0) ? true : false);
                    if( c.ContainsPlanet )
                    {
                        c.AddPlanet();
                        planetCounter++;
                        
                    }
                }
                else
                {
                    c.ContainsPlanet = false;
                }

            }
        }
        
    }
}
