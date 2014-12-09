﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using ET.FakeText;


namespace gv
{
    public class Universe
    {
        readonly Dictionary<string,Planet> _planets = new Dictionary<string,Planet>();
        readonly List<Chunk> _chunks = new List<Chunk>();
        readonly List<Cell> _cells = new List<Cell>();
        Random rand = new Random();
        internal TextGenerator NameGen;

        EventGenerator _events;
        Player _player;

        public Universe()
        {
            _events = new EventGenerator( this );
            _player = new Player( this );
            NameGen = new TextGenerator(WordTypes.Name);

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
            _planets.Add(p.Name, p);
            return p;
        }
        public Planet CreateEarth()
        {
            Planet earth = new Earth( this );
            _planets.Add( earth.Name, earth );
            return earth;
        }
        public Planet CreateEldorado()
        {
            Planet eldorado =  new Eldorado( this );
            _planets.Add( eldorado.Name, eldorado );
            return eldorado;
        }
        public void ToXML()
        {
            XDocument save = new XDocument(
                new XElement( "Game",
                    new XElement(_player .ToXML()),
                    new XElement("Planets",
                        from p in _planets
                        select new XElement("Planet",
                            new XElement("Class",p.GetType().AssemblyQualifiedName),
                            new XElement("Name", p.Value.Name),
                            new XElement("Type", p.Value.Type),
                            new XElement("Climate", p.Value.Climate),
                            new XElement("Surface", p.Value.Surface),
                            new XElement("Ressources", p.Value.Ressources),
                            new XElement("IsInhabited", p.Value.IsInhabited),
                            new XElement("InhabitantsName", p.Value.InhabitantsName),
                            new XElement("Built", p.Value.Factory)
                        )
                    ),
                    new XElement("Cells",
                        from c in _cells
                        select new XElement("Cell",
                            new XElement("containerX", c.ContainerChunck.Position.X),
                            new XElement("containerY", c.ContainerChunck.Position.Y),
                            new XElement("ContainsPlanet", c.ContainsPlanet),
                            new XElement("X", c.Position.X),
                            new XElement("Y", c.Position.Y),
                            new XElement("ContainedPlanet", (c.ContainsPlanet?c.ContainedPlanet.Name : null))
                        )
                    ),
                    new XElement("Chunks",
                        from C in _chunks
                        select new XElement("Chunk", 
                            new XElement("X", C.Position.X),
                            new XElement("Y", C.Position.Y)
                            )
                    )
               )
            );
            save.Save( @".\..\..\..\Saves/saveTest.xml" );
        }
        public void EndTurn()
        {
            _player.EndTurn();
        }
        public Dictionary<string,Planet> Planets
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
        public EventGenerator Event
        {
            get { return _events; }
        }
        
    }
}
