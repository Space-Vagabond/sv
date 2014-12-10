using System;
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
        readonly Dictionary<Position,Chunk> _chunks = new Dictionary<Position,Chunk>();
        Dictionary<int,Chunk> _shownChunks = new Dictionary<int,Chunk>();
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
            int k = 1;
            for( int i = -1; i < 1; i++ )
            {
                for( int j = -1; j < 1; j++ )
                {
                    Chunk c = new Chunk( new Position( i * 10, j * 10 ), this );
                    _chunks.Add(c.Position, c );
                    _shownChunks.Add(k,c);
                    k++;
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
                        from C in _chunks.Values
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
            //EnsureChunk();
        }
       /* public void EnsureChunk()
        {

            int maxX = _shownChunks.Values.Max( Chunk => Chunk.Position.X );
            int maxY = _shownChunks.Values.Max( Chunk => Chunk.Position.Y );
            int minX = _shownChunks.Values.Min( Chunk => Chunk.Position.X );
            int minY = _shownChunks.Values.Min( Chunk => Chunk.Position.Y );
            int maxiX = maxX + 9;
            int maxiY = maxY + 9;
            int miniX = minY;
            int miniY = minY;
            if( _player.Position.X >= maxiX - 2 && _player.Position.Y >= maxiY - 2 )
            {
                //need chunks
            }
            else if(_player.Position.X >= maxiX - 2 && _player.Position.Y <= miniY + 2)
            {
                //
            }
            else if( _player.Position.X <= miniX + 2 && _player.Position.Y >= maxiY - 2 )
            {
                //
            }
            else if( _player.Position.X <= miniX + 2 && _player.Position.Y <= miniY + 2 )
            {
                //
            }
            else if( _player.Position.X >= maxiX - 2 )
            {
                _shownChunks.Clear();
                _shownChunks.Add( _chunks[new Position( maxX, minY )] );
                _shownChunks.Add( _chunks[new Position( maxX, maxY )] );

                if( _chunks.ContainsKey( new Position( maxX + 10, minY ) ) )
                {
                    _shownChunks.Add( _chunks[new Position( maxX + 10, minY )] );
                }
                else
                {
                    Chunk c = new Chunk( new Position( maxX + 10, minY ), this );
                    _shownChunks.Add( c );
                }
                if( _chunks.ContainsKey( new Position( maxX + 10, maxY) ) )
                {
                    _shownChunks.Add( _chunks[new Position( maxX + 10, maxY )] );
                }
                else
                {
                    Chunk c = new Chunk(new Position(maxX+10,maxY), this);
                    _shownChunks.Add( c );
                }
                
            }
            else if( _player.Position.X <= miniX + 2 )
            {
                //
            }
            else if( _player.Position.Y >= maxiY - 2 )
            {
                //
            }
            else if( _player.Position.Y <= miniY + 2 )
            {
                //
            }
            else
            {
                //
            }
        }*/
        public Dictionary<string,Planet> Planets
        {
            get { return _planets; }
        }
        public Dictionary<Position,Chunk> Chunks
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
        public Dictionary<int,Chunk> ShownChunks
        {
            get { return _shownChunks; }
        }      
    }
}
