using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using gv;
namespace Galactic_Vagabond
{
    public partial class Form_GV_01 : Form
    {
        Universe _universe;
        Image _square = Image.FromFile( @".\..\..\..\images/square.png" );
        Image _ship = Image.FromFile( @".\..\..\..\images/ship.png" );
        Image[] _planets= new Image[20];
        List<Control> _displayedControls = new List<Control>();
        List<Control> _cockpitControls = new List<Control>();
        List<Control> _overviewControls = new List<Control>();      

        public Form_GV_01()
        {
            InitializeComponent();
            for( int i = 0; i < 18; i++ )
            {
                _planets[i] = Image.FromFile( @".\..\..\..\images/planet" + (i + 1) + ".png" );
            }
            
            //Find or Creates the saves directory
            Directory.CreateDirectory( @"./../../../Saves" );

            //hiding main form and displays launcher
            this.Hide();
            using( launcher form2 = new launcher() )
            {
                var result = form2.ShowDialog();
                if( result == DialogResult.Yes )//new game
                {
                    form2.Dispose();
                    this.Show();
                    _universe = new Universe();
                    _universe.User.Name = form2.PName;
                }
                else//Load game
                {

                    XDocument doc = form2.Doc;
                }
            }
            
            InitMap();
            ShowCurrentPlanet();
            DisplayPlayerDatas();

            _cockpitControls.Add(map);
            _cockpitControls.Add(TurnEvents);
            _cockpitControls.Add(CurrentPlanet);
            _cockpitControls.Add(LastTurnLabel);
            _cockpitControls.Add(Pos);
            _cockpitControls.Add(TurnNumber);
            _cockpitControls.Add(GemsLabel);
            _cockpitControls.Add(SiliciumLabel);
            _cockpitControls.Add(MetalLabel);
            _cockpitControls.Add(HydrogenLabel);
            _cockpitControls.Add(PlutoniumLabel);
            _cockpitControls.Add(HeliumLabel);
            _cockpitControls.Add(PosX);
            _cockpitControls.Add(PosY);
            _cockpitControls.Add(Build);
            _cockpitControls.Add(EndTurn);

            _overviewControls.Add(OverViewList);
            _overviewControls.Add(OverviewDetails);
            _overviewControls.Add(PlanetImg);
        }
        /// <summary>
        /// Initiaizing the map controller
        /// </summary>
        public void InitMap()
        {
            for( int i = 0; i < 20; i++ )
            {
                this.map.Columns[i].Width = 35;
            }
            for( int i = 0; i < 20; i++ )
            {
                Image[] s = new Image[] { _square, _square, _square, _square, _square, _square, _square, _square, _square, _square, _square, _square, _square, _square, _square, _square, _square, _square, _square, _square, _square };
                map.Rows.Add( s );
                this.map.Rows[i].Height = 30;
            }
        }
        /// <summary>
        /// Bindng Datas int the map
        /// </summary>
        public void LoadMap()
        {
            foreach( KeyValuePair<int,Chunk> ch in _universe.ShownChunks )
            {
                foreach( Cell cl in ch.Value.Cells )
                {
                    if( cl.ContainsPlanet )
                    {                        
                        if( _universe.User.Position.X == cl.Position.X && _universe.User.Position.Y == cl.Position.Y )
                        {
                            this.map.Rows[ConvertY( cl.Position.Y, ch.Key )].Cells[ConvertX( cl.Position.X, ch.Key )].Style.BackColor =
                                System.Drawing.Color.Yellow;
                            cl.ContainedPlanet.IsDiscovered = true;//sets the planet to discovered to show its own sprite
                        }
                        else
                        {
                            this.map.Rows[ConvertY( cl.Position.Y, ch.Key )].Cells[ConvertX( cl.Position.X, ch.Key )].Style.BackColor =
                                System.Drawing.Color.Black;
                        }
                        if( cl.ContainedPlanet.IsDiscovered )
                        {
                            this.map.Rows[ConvertY( cl.Position.Y, ch.Key )].Cells[ConvertX( cl.Position.X, ch.Key )].Value = _planets[cl.ContainedPlanet.Img - 1];
                        }
                        else
                        {
                            this.map.Rows[ConvertY( cl.Position.Y, ch.Key )].Cells[ConvertX( cl.Position.X, ch.Key )].Value = _planets[6 - 1];                            
                        }
                    }
                    else
                    {
                        this.map.Rows[ConvertY( cl.Position.Y, ch.Key )].Cells[ConvertX( cl.Position.X, ch.Key )].Style.BackColor =
                            System.Drawing.Color.Black;
                        if( _universe.User.Position.X == cl.Position.X && _universe.User.Position.Y == cl.Position.Y )
                        {
                            this.map.Rows[ConvertY( cl.Position.Y, ch.Key )].Cells[ConvertX( cl.Position.X, ch.Key )].Value = _ship;
                        }
                        else
                        {
                            this.map.Rows[ConvertY( cl.Position.Y, ch.Key )].Cells[ConvertX( cl.Position.X, ch.Key )].Value = _square;
                        }
                    }
                    if( cl.ContainsPlanet && cl.ContainedPlanet.Name == "Eldorado" )
                    {
                        cl.ContainedPlanet.IsDiscovered = true;
                        this.map.Rows[ConvertY( cl.Position.Y, ch.Key )].Cells[ConvertX( cl.Position.X, ch.Key )].Style.BackColor =
                                System.Drawing.Color.LightPink;
                    }
                }
            }
        }
        /// <summary>
        /// Shows Planet's info
        /// </summary>
        public void ShowCurrentPlanet()
        {
            LoadMap();
            List<object> caracs = new List<object>();
            CurrentPlanet.Text = string.Empty;
            var pos = _universe.Cells.Where( c => c.Position.X == _universe.User.Position.X && c.Position.Y == _universe.User.Position.Y ).Single();
            if( pos.ContainsPlanet )
            {
                if( pos.ContainedPlanet.Ressources != "none" && pos.ContainedPlanet.Factory == false )
                {
                    Build.Show();
                }
                else
                {
                    Build.Hide();
                }
                CurrentPlanet.Text += "Name: " + pos.ContainedPlanet.Name + Environment.NewLine;
                CurrentPlanet.Text += "Type: " + pos.ContainedPlanet.Type + Environment.NewLine;
                CurrentPlanet.Text += "Climate: " + pos.ContainedPlanet.Climate + Environment.NewLine;
                CurrentPlanet.Text += "Surface: " + pos.ContainedPlanet.Surface + Environment.NewLine;
                CurrentPlanet.Text += "Resources: " + pos.ContainedPlanet.Ressources + Environment.NewLine;
                CurrentPlanet.Text += "Inhabitants: " + pos.ContainedPlanet.InhabitantsName + Environment.NewLine;
                if( pos.ContainedPlanet.Ressources != "none" )
                {
                    CurrentPlanet.Text += "Constructible: yes" + Environment.NewLine;
                    CurrentPlanet.Text += "Built: " + ((pos.ContainedPlanet.Factory) ? "yes" : "no") + Environment.NewLine;
                }
                else
                {
                    CurrentPlanet.Text += "Constructible: no" + Environment.NewLine;
                }
            }
            else
            {
                Build.Hide();
                CurrentPlanet.Text += "No planet to interact with";
            }
        }
        /// <summary>
        /// Using arrows to move, needs to always input them on the map
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData">The pressed key</param>
        /// <returns></returns>
        protected override bool ProcessCmdKey( ref Message msg, Keys keyData )
        {
            if( this.map.Visible )
            {
                if( keyData == Keys.Up )
                {
                    if( _universe.User.Move( new Position( _universe.User.Position.X, _universe.User.Position.Y + 1 ) ) )
                    {
                        EnsureChunk();
                    }
                }
                else if( keyData == Keys.Down )
                {
                    if( _universe.User.Move( new Position( _universe.User.Position.X, _universe.User.Position.Y - 1 ) ) )
                    {
                        EnsureChunk();
                    }
                }
                else if( keyData == Keys.Left )
                {
                    if( _universe.User.Move( new Position( _universe.User.Position.X - 1, _universe.User.Position.Y ) ) )
                    {
                        EnsureChunk();

                    }
                }
                else if( keyData == Keys.Right )
                {
                    if( _universe.User.Move( new Position( _universe.User.Position.X + 1, _universe.User.Position.Y ) ) )
                    {
                        EnsureChunk();

                    }
                }
                ShowCurrentPlanet();
                DisplayPlayerDatas();
                return true;
            }
            return false;
        }
        /// <summary>
        /// Checks if a chunk exists , if not creates it where needed
        /// </summary>
        void EnsureChunk()
        {
            //max values from chunks origins
            int maxX = _universe.ShownChunks.Values.Max( Chunk => Chunk.Position.X );
            int maxY = _universe.ShownChunks.Values.Max( Chunk => Chunk.Position.Y );
            int minX = _universe.ShownChunks.Values.Min( Chunk => Chunk.Position.X );
            int minY = _universe.ShownChunks.Values.Min( Chunk => Chunk.Position.Y );
            //max values of cells in these chunks
            int maxiX = maxX + 9;
            int maxiY = maxY + 9;
            int miniX = minX;
            int miniY = minY;

            if( _universe.User.Position.X > maxiX )// top of screen
            {
                _universe.ShownChunks.Clear();
                _universe.ShownChunks.Add( 1, _universe.Chunks[new Position( maxX, minY )] );
                _universe.ShownChunks.Add( 2, _universe.Chunks[new Position( maxX, maxY )] );
                if( _universe.Chunks.ContainsKey( new Position( maxX + 10, minY ) ) )
                {
                    _universe.ShownChunks.Add( 3, _universe.Chunks[new Position( maxX + 10, minY )] );
                }
                else
                {
                    Chunk c = new Chunk( new Position( maxX + 10, minY ), _universe );
                    _universe.Chunks.Add( c.Position, c );
                    _universe.ShownChunks.Add( 3, c );
                }
                if( _universe.Chunks.ContainsKey( new Position( maxX + 10, maxY ) ) )
                {
                    _universe.ShownChunks.Add( 4, _universe.Chunks[new Position( maxX + 10, maxY )] );
                }
                else
                {
                    Chunk c = new Chunk( new Position( maxX + 10, maxY ), _universe );
                    _universe.Chunks.Add( c.Position, c );
                    _universe.ShownChunks.Add( 4, c );
                }

            }
            else if( _universe.User.Position.X < miniX )// bot of screen
            {
                _universe.ShownChunks.Clear();
                _universe.ShownChunks.Add( 3, _universe.Chunks[new Position( minX, minY )] );
                _universe.ShownChunks.Add( 4, _universe.Chunks[new Position( minX, maxY )] );
                if( _universe.Chunks.ContainsKey( new Position( minX - 10, minY ) ) )
                {
                    _universe.ShownChunks.Add( 1, _universe.Chunks[new Position( minX - 10, minY )] );
                }
                else
                {
                    Chunk c = new Chunk( new Position( minX - 10, minY ), _universe );
                    _universe.Chunks.Add( c.Position, c );
                    _universe.ShownChunks.Add( 1, c );
                }
                if( _universe.Chunks.ContainsKey( new Position( minX - 10, maxY ) ) )
                {
                    _universe.ShownChunks.Add( 2, _universe.Chunks[new Position( minX - 10, maxY )] );
                }
                else
                {
                    Chunk c = new Chunk( new Position( minX - 10, maxY ), _universe );
                    _universe.Chunks.Add( c.Position, c );
                    _universe.ShownChunks.Add( 2, c );
                }
            }
            else if( _universe.User.Position.Y > maxiY )//right of screen
            {
                _universe.ShownChunks.Clear();
                _universe.ShownChunks.Add( 1, _universe.Chunks[new Position( minX, maxY )] );
                _universe.ShownChunks.Add( 3, _universe.Chunks[new Position( maxX, maxY )] );
                if( _universe.Chunks.ContainsKey( new Position( minX, maxY + 10 ) ) )
                {
                    _universe.ShownChunks.Add( 2, _universe.Chunks[new Position( minX, maxY + 10 )] );
                }
                else
                {
                    Chunk c = new Chunk( new Position( minX, maxY + 10 ), _universe );
                    _universe.Chunks.Add( c.Position, c );
                    _universe.ShownChunks.Add( 2, c );
                }
                if( _universe.Chunks.ContainsKey( new Position( maxX, maxY + 10 ) ) )
                {
                    _universe.ShownChunks.Add( 4, _universe.Chunks[new Position( maxX, maxY + 10 )] );
                }
                else
                {
                    Chunk c = new Chunk( new Position( maxX, maxY + 10 ), _universe );
                    _universe.Chunks.Add( c.Position, c );
                    _universe.ShownChunks.Add( 4, c );
                }
            }
            else if( _universe.User.Position.Y < miniY )//Left of screen
            {
                _universe.ShownChunks.Clear();
                _universe.ShownChunks.Add( 2, _universe.Chunks[new Position( minX, minY )] );
                _universe.ShownChunks.Add( 4, _universe.Chunks[new Position( maxX, minY )] );
                if( _universe.Chunks.ContainsKey( new Position( minX, minY - 10 ) ) )
                {
                    _universe.ShownChunks.Add( 1, _universe.Chunks[new Position( minX, minY - 10 )] );
                }
                else
                {
                    Chunk c = new Chunk( new Position( minX, minY - 10 ), _universe );
                    _universe.Chunks.Add( c.Position, c );
                    _universe.ShownChunks.Add( 1, c );
                }
                if( _universe.Chunks.ContainsKey( new Position( maxX, minY - 10 ) ) )
                {
                    _universe.ShownChunks.Add( 3, _universe.Chunks[new Position( maxX, minY - 10 )] );
                }
                else
                {
                    Chunk c = new Chunk( new Position( maxX, minY - 10 ), _universe );
                    _universe.Chunks.Add( c.Position, c );
                    _universe.ShownChunks.Add( 3, c );
                }
            }
            else
            {
                //
            }
        }
        /// <summary>
        /// Button end Turn click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndTurn_Click( object sender, EventArgs e )
        {
            
            
            _universe.EndTurn();
            _universe.Event.EventOccurs();
            DisplayTurnEvents();
            DisplayPlayerDatas();
        }
        /// <summary>
        /// Button build click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Build_Click( object sender, EventArgs e )
        {
            var pos = _universe.Cells.Where( c => c.Position.X == _universe.User.Position.X && c.Position.Y == _universe.User.Position.Y ).Single();
            if( pos.ContainsPlanet && pos.ContainedPlanet.Ressources != "none" )
            {
                pos.ContainedPlanet.Factory = true;
                ShowCurrentPlanet();
            }
        }        
        /// <summary>
        /// Mathematical modulo (always positive)
        /// </summary>
        /// <param name="nb">the number to divide</param>
        /// <param name="mod">the modulo</param>
        /// <returns>the absolute positive modulo</returns>
        public int ModAbs( int nb, int mod )
        {
            return (((nb % mod) + mod) % mod);
        }
        /// <summary>
        /// the value converting an X value from the universe to a X value for the gridview
        /// </summary>
        /// <param name="value">the X input</param>
        /// <param name="nbChunk">the position of the chunk</param>
        /// <returns>returns a value betwen 0 and 19 to go in the grid</returns>
        int ConvertX( int value, int nbChunk )
        {
            value = ModAbs( value, 10 );
            if( nbChunk == 1 || nbChunk == 2 )
            {
                return value;
            }
            else
            {
                return (value + 10);
            }
        }
        /// <summary>
        /// the value converting an Y value from the universe to a Y value for the gridview
        /// </summary>
        /// <param name="value">the Y input</param>
        /// <param name="nbChunk">the position of the chunk</param>
        /// <returns>returns a value betwen 0 and 19 to go in the grid</returns>
        int ConvertY( int value, int nbChunk )
        {
            value = ModAbs( value, 10 );
            if( nbChunk % 2 == 0 )
            {
                return (9 - value);
            }
            else
            {
                return (19 - value);
            }
        }
        /// <summary>
        /// displays the ressoures of ten player
        /// </summary>
        public void DisplayPlayerDatas()
        {
            this.SiliciumLabel.Text = "Silicium : " + _universe.User.Ressources["Silicium"];
            this.SiliciumLabel.Show();
            this.GemsLabel.Text = "Gems : " + _universe.User.Ressources["Gems"];
            this.GemsLabel.Show();
            this.PlutoniumLabel.Text = "Plutonium : " + _universe.User.Ressources["Plutonium"];
            this.PlutoniumLabel.Show();
            this.MetalLabel.Text = "Metal : " + _universe.User.Ressources["Metal"];
            this.MetalLabel.Show();
            this.HydrogenLabel.Text = "Hydrogen : " + _universe.User.Ressources["Hydrogene"];
            this.HydrogenLabel.Show();
            this.HeliumLabel.Text = "Helium : " + _universe.User.Ressources["Helium"];
            this.HeliumLabel.Show();
            this.PosX.Text = "Position on X : " + _universe.User.Position.X;
            this.PosX.Show();
            this.PosY.Text = "Position on Y : " + _universe.User.Position.Y;
            this.PosY.Show();
            this.TurnNumber.Text = "Turn number: " + _universe.Turn;
            this.TurnNumber.Show();
        }
        /// <summary>
        /// Shows events that happend on this turn
        /// </summary>
        void DisplayTurnEvents()
        {
            this.TurnEvents.DataSource = new List<string>();
            this.TurnEvents.DataSource = _universe.Event.AllEvents[_universe.Turn];
            int visibleItem = this.TurnEvents.ClientSize.Height / this.TurnEvents.ItemHeight;
            this.TurnEvents.TopIndex = Math.Max( this.TurnEvents.Items.Count - visibleItem + 1, 0 );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EventsButton_Click( object sender, EventArgs e )
        {
            EventLog eventLog = new EventLog( _universe );
            eventLog.ShowDialog();
        }

        private void OverviewButton_Click(object sender, EventArgs e)
        {
            List<object> toDisplay = new List<object>();
            
            foreach (Planet pl in _universe.Planets.Values)
            {
                if (pl.IsDiscovered)
                {
                    string name = pl.Name.ToString();
                    toDisplay.Add(name);
                }
            }
            OverViewList.DataSource = toDisplay;
            foreach (Control c in _cockpitControls) 
            {
                c.Hide();
            }
            foreach (Control c in _overviewControls)
            {
                c.Show();

            }

        }

        private void CockpitButton_Click(object sender, EventArgs e)
        {
            foreach(Control c in _cockpitControls)
            {
                c.Show();
            }
            foreach(Control c in _overviewControls)
            {
                c.Hide();
            }
        }

        private void DisplayOverviewDetails(object sender, EventArgs e)
        {
            List<object> details = new List<object>();
            var curSelected = OverViewList.SelectedValue;
            foreach (Planet pl in _universe.Planets.Values)
            {
                if(pl.Name == curSelected.ToString() && pl.IsDiscovered) 
                {
                    details.Add("Name: "+pl.Name);
                    details.Add("Type: " +pl.Type);
                    details.Add("Climate: "+pl.Climate);
                    details.Add("Surface: "+pl.Surface);
                    details.Add("Resources: "+pl.Ressources);
                    details.Add("Inhabitants: "+pl.InhabitantsName);
                    details.Add("Has factory: "+pl.Factory);
                    details.Add("Look: ");
                    PlanetImg.Image = _planets[pl.Img-1];
                    
                    OverviewDetails.DataSource = details;
                }
            }
        }

        
    }
}
