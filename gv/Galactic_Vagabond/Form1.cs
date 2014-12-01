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
using System.Diagnostics;

namespace Galactic_Vagabond
{
    public partial class Form_GV_01 : Form
    {
        static Universe _universe;
        public Form_GV_01()
        {
            InitializeComponent();
            _universe = new Universe();
            this.map.Universe = _universe;
            ShowCurrentPlanet();
        }



        public void ShowCurrentPlanet()
        {
            List<object> caracs = new List<object>();

            var pos = _universe.Cells.Where( c => c.Position.X == _universe.User.Position.X && c.Position.Y == _universe.User.Position.Y ).Single();
            if( pos.ContainsPlanet )
            {
                
                caracs.Add( "Name: " + pos.ContainedPlanet.Name );
                caracs.Add( "Type: " + pos.ContainedPlanet.Type );
                caracs.Add( "Climate: " + pos.ContainedPlanet.Climate );
                caracs.Add( "Surface: " + pos.ContainedPlanet.Surface );
                caracs.Add( "Resources: " + pos.ContainedPlanet.Ressources );
                caracs.Add( "Inhabitants: " + pos.ContainedPlanet.InhabitantsName );

            }
            else
            {
                caracs.Add( "No planet to interact with" );
            }

            CurrentPlanet.DataSource = caracs;
            CurrentPlanet.Update();
        }

        private void KeyMove( object sender, KeyEventArgs e )
        {
            if( this.map.Visible )
            {
                if( e.KeyCode == Keys.Up )
                {
                    _universe.User.Y = _universe.User.Y - 1;
                }
                else if( e.KeyCode == Keys.Down )
                {
                    _universe.User.Y = _universe.User.Y + 1;
                }
                else if( e.KeyCode == Keys.Left )
                {
                    _universe.User.X = _universe.User.X - 1;
                }
                else if( e.KeyCode == Keys.Right )
                {
                    _universe.User.X = _universe.User.X + 1;
                }
                map.Refresh();
                ShowCurrentPlanet();
            }
        }




    }
}
