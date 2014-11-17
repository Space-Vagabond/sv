using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gv;
using Galactic_Vagabond;

namespace Galactic_Vagabond
{
    public partial class Form_GV_01 : Form
    {
        public Form_GV_01()
        {
            InitializeComponent();
            Universe universe = new Universe();

        }

        private int ConvertX( int x )
        {

            return (x + 10) * (30) + 5;
        }

        private int ConvertY( int y )
        {
            return (y + 10) * (30) - (25);
        }

        /// <summary>
        /// Displaying planets and player on grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click( object sender, EventArgs e )
        {
            using( Graphics g = this.map.CreateGraphics() )
            {

                int cellsNb = 20;
                int cellSize = 30;
                Font drawFont = new Font( "Verdana", 12 );
                SolidBrush drawBrush = new SolidBrush( Color.Cyan );
                SolidBrush drawPlayer = new SolidBrush( Color.Red );
                ShowCurrentPlanet( this, EventArgs.Empty );
                map.Refresh();

                foreach( Chunk ch in Universe.Chunks )
                {
                    foreach( Cell cl in ch._cells )
                    {
                        if( cl.ContainsPlanet )
                        {
                            if( cl.ContainedPlanet.Type == "Destroyed" )
                            {
                                Point drawPoint = new Point( ConvertX( cl.Position.X ), ConvertY( cl.Position.Y ) );
                                g.DrawString( "E", drawFont, drawBrush, drawPoint );
                            }
                            else if( cl.ContainedPlanet.Type == "Telluric Silicat" )
                            {
                                Point drawPoint = new Point( ConvertX( cl.Position.X ), ConvertY( cl.Position.Y ) );
                                g.DrawString( "S", drawFont, drawBrush, drawPoint );
                            }
                            else if( cl.ContainedPlanet.Type == "Coreless" )
                            {
                                Point drawPoint = new Point( ConvertX( cl.Position.X ), ConvertY( cl.Position.Y ) );
                                g.DrawString( "C", drawFont, drawBrush, drawPoint );
                            }
                            else if( cl.ContainedPlanet.Type == "Telluric Carbon" )
                            {
                                Point drawPoint = new Point( ConvertX( cl.Position.X ), ConvertY( cl.Position.Y ) );
                                g.DrawString( "Ca", drawFont, drawBrush, drawPoint );
                            }
                            else if( cl.ContainedPlanet.Type == "Telluric Metal" )
                            {
                                Point drawPoint = new Point( ConvertX( cl.Position.X ), ConvertY( cl.Position.Y ) ); ;
                                g.DrawString( "M", drawFont, drawBrush, drawPoint );
                            }
                            else if( cl.ContainedPlanet.Type == "Telluric Lava" )
                            {
                                Point drawPoint = new Point( ConvertX( cl.Position.X ), ConvertY( cl.Position.Y ) ); ;
                                g.DrawString( "L", drawFont, drawBrush, drawPoint );
                            }
                            else if( cl.ContainedPlanet.Type == "Telluric Ice" )
                            {
                                Point drawPoint = new Point( ConvertX( cl.Position.X ), ConvertY( cl.Position.Y ) ); ;
                                g.DrawString( "I", drawFont, drawBrush, drawPoint );
                            }
                            else if( cl.ContainedPlanet.Type == "Telluric Desert" )
                            {
                                Point drawPoint = new Point( ConvertX( cl.Position.X ), ConvertY( cl.Position.Y ) ); ;
                                g.DrawString( "D", drawFont, drawBrush, drawPoint );
                            }
                            else if( cl.ContainedPlanet.Type == "Gazeous Hydrogen" )
                            {
                                Point drawPoint = new Point( ConvertX( cl.Position.X ), ConvertY( cl.Position.Y ) ); ;
                                g.DrawString( "Hy", drawFont, drawBrush, drawPoint );
                            }
                            else if( cl.ContainedPlanet.Type == "Gazeous Helium" )
                            {
                                Point drawPoint = new Point( ConvertX( cl.Position.X ), ConvertY( cl.Position.Y ) ); ;
                                g.DrawString( "He", drawFont, drawBrush, drawPoint );
                            }
                            else if( cl.ContainedPlanet.Type == "Chthonian" )
                            {
                                Point drawPoint = new Point( ConvertX( cl.Position.X ), ConvertY( cl.Position.Y ) ); ;
                                g.DrawString( "Ch", drawFont, drawBrush, drawPoint );
                            }

                            if( Universe._p != null )
                            {
                                Point drawPoint = new Point( (Universe._p.X + 10) * 30 + 5, (Universe._p.Y + 10) * 30 - 25 );
                                g.DrawString( "P", drawFont, drawPlayer, drawPoint );
                            }
                        }
                    }



                }

                Pen p = new Pen( Color.LimeGreen );
                Pen p1 = new Pen( Color.White );

                for( int i = 0; i < cellsNb; ++i )
                {
                    g.DrawLine( p, 0, i * cellSize, cellsNb * cellSize, i * cellSize );
                    if( i == cellsNb / 2 )
                    {
                        g.DrawLine( p1, 0, i * cellSize, cellsNb * cellSize, i * cellSize );
                    }
                }

                for( int j = 0; j < cellsNb; ++j )
                {
                    g.DrawLine( p, j * cellSize, 0, j * cellSize, cellsNb * cellSize );
                    if( j == cellsNb / 2 )
                    {
                        g.DrawLine( p1, j * cellSize, 0, j * cellSize, cellsNb * cellSize );
                    }
                }

            }


        }

        // Contrary directions Y because of GUI 0,0 left upper corner
        private void up_Click( object sender, EventArgs e )
        {
            Universe._p.Y = Universe._p.Y - 1;
            button1_Click( this, EventArgs.Empty );
        }

        private void down_Click( object sender, EventArgs e )
        {
            Universe._p.Y = Universe._p.Y + 1;
            button1_Click( this, EventArgs.Empty );
        }

        private void left_Click( object sender, EventArgs e )
        {
            Universe._p.X = Universe._p.X - 1;
            button1_Click( this, EventArgs.Empty );
        }

        private void right_Click( object sender, EventArgs e )
        {
            Universe._p.X = Universe._p.X + 1;
            button1_Click( this, EventArgs.Empty );
        }
        ///
        private void ShowCurrentPlanet( object sender, EventArgs e )
        {
            List<object> caracs = new List<object>();

            IEnumerable<Cell> Req = from c in Universe.Cells
                                    where c.Position.X == Universe._p.Position.X && c.Position.Y == Universe._p.Position.Y
                                    select c;
            foreach( Cell c in Req )
            {
                Cell pos = c;
                if( pos.ContainsPlanet )
                {
                    CurrentPlanet.Refresh();

                    caracs.Add( "Name: " + pos.ContainedPlanet.Name );
                    caracs.Add( "Type: " + pos.ContainedPlanet.Type );
                    caracs.Add( "Climate: " + pos.ContainedPlanet.Climate );
                    caracs.Add( "Surface: " + pos.ContainedPlanet.Surface );
                    caracs.Add( "Resources: " + pos.ContainedPlanet.Ressource );
                    caracs.Add( "Inhabitants: " + pos.ContainedPlanet.InhabitantsName );
                }
                else
                {
                    caracs.Add( "No planet to interact with" );
                }
                CurrentPlanet.DataSource = caracs;
            }

            

            
        }
    }
}
 