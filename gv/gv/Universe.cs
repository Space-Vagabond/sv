using System;
using System.Collections.Generic;


namespace gv
{
    public class Universe
    {
        readonly List<Planet> _planets = new List<Planet>();
        readonly List<Chunk> _chunks = new List<Chunk>();
        readonly List<Cell> _cells = new List<Cell>();
        Random rand = new Random();
        Player _player;

        public Universe()
        {
            _player = new Player( this );

            for( int i = -1; i < 1; i++ )
            {
                for( int j = -1; j < 1; j++ )
                {
                    Chunk c = new Chunk( new Position( i * 10, j * 10 ), this );
                    _chunks.Add( c );
                }
            }   
            
        }       
        public Planet AddPlanet()
        {
            Planet p = Planet.CreatePlanet(this);
            _planets.Add(p);
            return p;
        }
        public Planet CreateEarth()
        {
            Planet earth = new Earth( this );
            _planets.Add( earth );
            return earth;
        }
        public Planet CreateEldorado()
        {
            Planet eldorado =  new Eldorado( this );
            _planets.Add( eldorado );
            return eldorado;
        }
        public void EndTurn()
        {
            _player.EndTurn();
        }
        public List<Planet> Planets
        {
            get { return _planets; }
        }
        public List<Chunk> Chunks
        {
           get { return _chunks;}
        }
        public List<Cell> Cells
        {
            get { return _cells; }
        }
        public Player User
        {
            get { return _player; }
        }
        public Random Rand
        {
            get { return rand ; }
        }
        
    }
}
