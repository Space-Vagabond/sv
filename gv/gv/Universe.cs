using System;
using System.Collections.Generic;
using System.Linq;
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
        int _turn; 
        readonly List<Tech> _techs = new List<Tech>();

        public Universe()
        {
            _events = new EventGenerator( this );
            _player = new Player(this);
           
            _techs.Add (new Tech( "Gaz Extractor", "Allows you to extract Helium and Hydrogen", 50, 50, 0, 0, 0, 0 ));
            _techs.Add (new Tech( "Gems Extractor", "Allows you to extract Gems", 100, 100, 100, 100, 0, 0, _techs[0] ));
            _techs.Add (new Tech( "Plutonium Extractor", "Allows you to extract Plutonium", 200, 200, 0, 100, 0, 0, _techs[1] ));
            _techs.Add (new Tech( "Hydrogen Engine", "Increases your max speed to 10", 70, 0, 70, 0, 0, 0, _techs[0] ));
            _techs.Add (new Tech( "Helium Engine", "Increases your max speed to 15", 70, 0, 70, 70, 0, 0, _techs[3] ));
            _techs.Add (new Tech( "Plutonium Engine", "Increases your max speed to 20", 0, 0, 200, 200, 0, 100, _techs[2], _techs[4] ));
            _techs.Add (new Tech( "Factory Upgrade", "Multiplies your income by 1.5", 250, 250, 250, 250, 250, 250, _techs[5] ));
            _techs.Add (new Tech( "Bio Dome", "Allows you to settle down on a planet ", 500, 500, 500, 500, 500, 500, _techs[6] ));
            _techs.Add (new Tech( "Radar", "Allows you to know where are planets in Overview", 120, 0, 0, 0, 120, 0 ));
            _techs.Add (new Tech( "Diplomacy", "Aliens are now your friends they help for you, adds 20% income ", 120, 0, 120, 120, 0, 0 ));
            _techs.Add (new Tech( "Workers", "Aliens are now your workers they work for you, adds 30% income ", 200, 0, 0, 0, 200, 0, _techs[9] ));
            _techs.Add (new Tech( "Galactic Firm", "You're now THE BOSS! Adds 50% income", 0, 0, 0, 0, 400, 400, _techs[10] ));
            
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
            Planet p;
            do
            {
                p = Planet.CreatePlanet( this );
            } while( _planets.ContainsKey(p.Name )); 
           
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
        public bool ShouldSpawnEldorado()
        {
            if( !_planets.ContainsKey( "Eldorado" ) )
            {
                int n = _turn * _chunks.Count();
                if( n > 100 )
                {
                    int k = (int)(100 - Math.Exp( ((n - 100) / 50) ));


                    if( k <= 0 || rand.Next( 1, k ) == 1 )
                    {
                        CreateEldorado();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }     
            }
            else
            {
                return false;
            }       
        }
        /// <summary>
        /// to sav the whole universe as XML
        /// </summary>
        public void ToXML()
        {
            XDocument save = new XDocument(
                new XElement( "Game",
                    new XElement(_player .ToXML()),
                    new XElement("Turn", _turn),
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
                            new XElement("Built", p.Value.Factory),
                            new XElement("Blocked", p.Value.Blocked),
                            new XElement("Discovered", p.Value.IsDiscovered),
                            new XElement("ImgId", p.Value.Img)
                        )
                    ),
                    new XElement("Chunks",
                        from C in _chunks.Values
                        select new XElement("Chunk", 
                            new XElement("X", C.Position.X),
                            new XElement("Y", C.Position.Y)
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
                    )
                )
            );
            save.Save( @".\..\..\..\Saves/save"+_player.Name+".xml" );
        }
        public void EndTurn()
        {
            _turn += 1;
            _player.EndTurn();
        }
        public bool BuyTech( int idBought )
        {
            if( _techs[idBought].IsDiscovered ) return false;
            else
            {
                return (_techs[idBought].IsDiscovered = _player.UnlockTech( idBought ));          
            }
        }
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
        public int Turn
        {
            get { return _turn; }
        }
        public Dictionary<int,Chunk> ShownChunks
        {
            get { return _shownChunks; }
        }
        public List<Tech> Techs
        {
            get { return _techs; }
        }
    }
}
