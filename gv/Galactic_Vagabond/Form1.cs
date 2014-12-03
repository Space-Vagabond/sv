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
        Universe _universe;
        public Form_GV_01()
        {
            InitializeComponent();
            this.Hide();
            launcher form2 = new launcher();
            var result = form2.ShowDialog();
            if( result == DialogResult.Yes )
            {
                form2.Dispose();
                this.Show();
                _universe = new Universe();
            }
            else
            {
                //loadGame
            }
            this.map.Universe = _universe;
            ShowCurrentPlanet();
        }



        public void ShowCurrentPlanet()
        {
            List<object> caracs = new List<object>();
            CurrentPlanet.Text = string.Empty;
            var pos = _universe.Cells.Where( c => c.Position.X == _universe.User.Position.X && c.Position.Y == _universe.User.Position.Y ).Single();
            if( pos.ContainsPlanet )
            {
                
                CurrentPlanet.Text+= "Name: " + pos.ContainedPlanet.Name+Environment.NewLine ;
                CurrentPlanet.Text += "Type: " + pos.ContainedPlanet.Type + Environment.NewLine;
                CurrentPlanet.Text += "Climate: " + pos.ContainedPlanet.Climate + Environment.NewLine;
                CurrentPlanet.Text += "Surface: " + pos.ContainedPlanet.Surface + Environment.NewLine;
                CurrentPlanet.Text += "Resources: " + pos.ContainedPlanet.Ressources + Environment.NewLine;
                CurrentPlanet.Text += "Inhabitants: " + pos.ContainedPlanet.InhabitantsName + Environment.NewLine;
            }
            else
            {
                CurrentPlanet.Text+= "No planet to interact with";
            }
        }

        protected override bool ProcessCmdKey( ref Message msg, Keys keyData )
        {
            if( this.map.Visible )
            {
                if( keyData == Keys.Up )
                {
                    if( _universe.User.Move( new Position( _universe.User.X, (_universe.User.Y - 1) ) ) )
                    {
                        map.Refresh();
                    }
                }
                else if( keyData == Keys.Down )
                {
                    if( _universe.User.Move( new Position( _universe.User.X, (_universe.User.Y + 1) ) ) )
                    {
                        map.Refresh();
                    }
                }
                else if( keyData == Keys.Left )
                {
                    if( _universe.User.Move( new Position( (_universe.User.X - 1), _universe.User.Y ) ) )
                    {
                        map.Refresh();
                    }
                }
                else if( keyData == Keys.Right )
                {
                    if( _universe.User.Move( new Position( (_universe.User.X + 1), _universe.User.Y ) ) )
                    {
                        map.Refresh();
                    }
                }
                ShowCurrentPlanet();
            }
            return true;
        }

        private void EndTurn_Click( object sender, EventArgs e )
        {
            _universe.EndTurn();
        }
    }
}
