﻿using System;
using System.Collections.Generic;


namespace gv
{
    public class Universe
    {
        static readonly List<Planet> _planets = new List<Planet>();
        public static readonly List<Chunk> _chunks = new List<Chunk>();
        public static Random rand = new Random();
        
        public Universe()
        {
            Player p = new Player();
            CreateEarth();
            for( int i = -1; i < 1; i++ )
            {
                for( int j = -1; j < 1; j++ )
                {
                    Chunk c = new Chunk( new Point( i * 10, j * 10 ) );
                    _chunks.Add( c );
                }
            }   
            
        }       
        public static Planet AddPlanet()

        {
            return new Planet();
        }
        public static Planet AddPlanet(Position position)
        {
            return new Planet(position);
        }
        public Planet CreateEarth()
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
    }
}
