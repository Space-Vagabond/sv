using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gv;

namespace Galactic_Vagabond
{
    public partial class Map : Control
    {
        static readonly Pen _limeGreenPen = new Pen( Color.LimeGreen );
        static readonly Pen _whitePen = new Pen( Color.White );

        Universe _u;

        public Map()
        {
            InitializeComponent();
            this.SetStyle( ControlStyles.Selectable, false );
            this.DoubleBuffered = true;
        }

        private int ConvertX( int x )
        {

            return (x + 10) * (30) + 5;
        }

        private int ConvertY( int y )
        {
            return (y + 10) * (30) - (25);
        }

        protected override void OnPaint( PaintEventArgs pe )
        {
            if( _u == null ) return;

            Graphics g = pe.Graphics;
 
            int cellsNb = 20;
            int cellSize = 30;
            Font drawFont = new Font( "Verdana", 12 );
            SolidBrush drawBrush = new SolidBrush( Color.Cyan );
            SolidBrush drawPlayer = new SolidBrush( Color.Red );

            foreach( Chunk ch in _u.ShownChunks )
            {
                foreach( Cell cl in ch.Cells )
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
                        else if( cl.ContainedPlanet.Type == "Chtonian" )
                        {
                            Point drawPoint = new Point( ConvertX( cl.Position.X ), ConvertY( cl.Position.Y ) ); ;
                            g.DrawString( "Ch", drawFont, drawBrush, drawPoint );
                        }

                        if( _u.User != null )
                        {
                            Point drawPoint = new Point( (_u.User.Position.X + 10) * 30 + 5, (_u.User.Position.Y + 10) * 30 - 25 );
                            g.DrawString( "P", drawFont, drawPlayer, drawPoint );
                        }
                    }
                }
            }



            for( int i = 0; i < cellsNb; ++i )
            {
                g.DrawLine( _limeGreenPen, 0, i * cellSize, cellsNb * cellSize, i * cellSize );
                if( i == cellsNb / 2 )
                {
                    g.DrawLine( _whitePen, 0, i * cellSize, cellsNb * cellSize, i * cellSize );
                }
            }

            for( int j = 0; j < cellsNb; ++j )
            {
                g.DrawLine( _limeGreenPen, j * cellSize, 0, j * cellSize, cellsNb * cellSize );
                if( j == cellsNb / 2 )
                {
                    g.DrawLine( _whitePen, j * cellSize, 0, j * cellSize, cellsNb * cellSize );
                }
            }
        }

        public Universe Universe
        {
            get { return _u; }
            set { _u = value; }
        }
    }
}

