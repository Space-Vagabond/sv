using System;
using System.Collections.Generic;


namespace gv
{
    public class Universe
    {
        static readonly List<Planet> _planets = new List<Planet>();
        public static readonly List<Chunk> _chunks = new List<Chunk>();
        public static readonly List<Cell> _cells = new List<Cell>();
        public static Random rand = new Random();
        public static Player _p = new Player();

        public Universe()
        {
            for( int i = -1; i < 1; i++ )
            {
                for( int j = -1; j < 1; j++ )
                {
                    Chunk c = new Chunk( new Position( i * 10, j * 10 ) );
                    _chunks.Add( c );
                }
            }   
            
        }       
        public static Planet AddPlanet()

        {
            Planet p = new Planet();
            _planets.Add(p);
            return p;
        }
        public static Planet CreateEarth()
        {
            Planet earth = new Planet( false );
            _planets.Add( earth );
            return earth;
        }
        public Planet CreateEldorado()
        {
            Planet eldorado =  new Planet( true );
            _planets.Add( eldorado );
            return eldorado;
        }
        public static List<Planet> Planets
        {
            get { return _planets; }
        }
        public static List<Chunk> Chunks
        {
            get { return _chunks;}
        }
        public static List<Cell> Cells
        {
            get { return _cells; }
        }
        
    }
}
