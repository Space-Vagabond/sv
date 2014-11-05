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
            int numOfCells = 20;
            int cellSize = 20;
            Font drawFont = new Font( "Verdana", 14 );
            SolidBrush drawBrush = new SolidBrush( Color.Red );
            foreach( Planet pl in Universe.Planets )
            {
                Point drawPoint = new Point( pl.X, pl.Y );
                g.DrawString( "E", drawFont, drawBrush, drawPoint );
            }
            Pen p = new Pen( Color.Green );

            for( int y = 0; y < numOfCells; ++y )
            {
                g.DrawLine( p, 0, y * cellSize, numOfCells * cellSize, y * cellSize );
            }

            for( int x = 0; x < numOfCells; ++x )
            {
                g.DrawLine( p, x * cellSize, 0, x * cellSize, numOfCells * cellSize );

            }

            
        }  


            

          

           

           

            
        
    }
}
