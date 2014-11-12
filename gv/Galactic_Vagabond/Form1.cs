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

        private void button1_Click( object sender, EventArgs e)
        {
            
            Graphics g = this.map.CreateGraphics();
            int cellsNb = 20;
            int cellSize = 30; 
            Font drawFont = new Font( "Verdana", 12 );
            SolidBrush drawBrush = new SolidBrush( Color.Cyan );
            
            
            foreach( Planet pl in Universe.Planets )
            {
                if( pl.Type == "Destroyed" )
                {
                    Point drawPoint = new Point( (pl.Position.X*30)+5, (pl.Position.Y*30)+5 );
                    g.DrawString( "E", drawFont, drawBrush, drawPoint );
                }
                else if( pl.Type == "Telluric Silicat" )
                {
                    Point drawPoint = new Point( (pl.Position.X * 30) + 5, (pl.Position.Y * 30) + 5 );
                    g.DrawString( "S", drawFont, drawBrush, drawPoint );
                }
                else if( pl.Type == "Coreless" )
                {
                    Point drawPoint = new Point( (pl.Position.X * 30) + 5, (pl.Position.Y * 30) + 5 );
                    g.DrawString( "C", drawFont, drawBrush, drawPoint );
                }
                else if( pl.Type == "Telluric Carbon" )
                {
                    Point drawPoint = new Point( (pl.Position.X * 30) + 5, (pl.Position.Y * 30) + 5 );
                    g.DrawString( "Ca", drawFont, drawBrush, drawPoint );
                }
                else if( pl.Type == "Telluric Metal" )
                {
                    Point drawPoint = new Point( (pl.Position.X * 30) + 5, (pl.Position.Y * 30) + 5 );
                    g.DrawString( "M", drawFont, drawBrush, drawPoint );
                }
                else if( pl.Type == "Telluric Lava" )
                {
                    Point drawPoint = new Point( (pl.Position.X * 30) + 5, (pl.Position.Y * 30) + 5 );
                    g.DrawString( "L", drawFont, drawBrush, drawPoint );
                }
                else if( pl.Type == "Telluric Ice" )
                {
                    Point drawPoint = new Point( (pl.Position.X * 30) + 5, (pl.Position.Y * 30) + 5 );
                    g.DrawString( "I", drawFont, drawBrush, drawPoint );
                }
                else if( pl.Type == "Telluric Desert" )
                {
                    Point drawPoint = new Point( (pl.Position.X * 30) + 5, (pl.Position.Y * 30) + 5 );
                    g.DrawString( "D", drawFont, drawBrush, drawPoint );
                }
                else if( pl.Type == "Gazeous Hydrogen" )
                {
                    Point drawPoint = new Point( (pl.Position.X * 30) + 5, (pl.Position.Y * 30) + 5 );
                    g.DrawString( "Hy", drawFont, drawBrush, drawPoint );
                }
                else if( pl.Type == "Gazeous Helium" )
                {
                    Point drawPoint = new Point( (pl.Position.X*30)+5, (pl.Position.Y*30)+5 );
                    g.DrawString( "He", drawFont, drawBrush, drawPoint );
                }
                else if( pl.Type == "Chthonian" )
                {
                    Point drawPoint = new Point( (pl.Position.X * 30) + 5, (pl.Position.Y * 30) + 5 );
                    g.DrawString( "Ch", drawFont, drawBrush, drawPoint );
                }
            }

            Pen p = new Pen( Color.LimeGreen );
            Pen p1 = new Pen( Color.Magenta );

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
                if( j == cellsNb/2 )
                {
                    g.DrawLine( p1, j * cellSize, 0, j * cellSize, cellsNb * cellSize );
                }
            }

            
            
            
        }  


            

          

           

           

            
        
    }
}
