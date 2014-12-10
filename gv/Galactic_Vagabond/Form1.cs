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
using System.IO;
namespace Galactic_Vagabond
{
    public partial class Form_GV_01 : Form
    {
        Universe _universe;
        public Form_GV_01()
        {
            InitializeComponent();
            Directory.CreateDirectory( @"./../../../Saves" );
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

            LoadMap();
            map.Focus();
            ShowCurrentPlanet();
        }

        public void LoadMap()
        {
            for( int i = 0; i < 20; i++ )
            {
                this.map.Columns[i].Width = 35;
            }
            Image square = Image.FromFile( @".\..\..\..\images/square.png" );
            for( int i = 0; i < 20; i++ )
            {
                Image[] s = new Image[] { square, square, square, square, square, square, square, square, square, square, square, square, square, square, square, square, square, square, square, square };
                map.Rows.Add( s );
                this.map.Rows[i].Height = 30;
            }
            foreach( Chunk ch in _universe.ShownChunks )
            {
                foreach( Cell cl in ch.Cells )
                {
                    if( cl.ContainsPlanet )
                    {
                        if( _universe.User.Position.X == cl.Position.X && _universe.User.Position.Y == cl.Position.Y )
                        {
                            this.map.Rows[cl.Position.X + 10].Cells[cl.Position.Y + 10].Style.BackColor = System.Drawing.Color.Yellow;
                        }
                        else
                        {
                            this.map.Rows[cl.Position.X + 10].Cells[cl.Position.Y + 10].Style.BackColor = System.Drawing.Color.Black;
                        }
                        this.map.Rows[cl.Position.X + 10].Cells[cl.Position.Y + 10].Value = Image.FromFile( @".\..\..\..\images/planet1.png" );
                    }
                    else
                    {
                        this.map.Rows[cl.Position.X+10].Cells[cl.Position.Y+10].Value = square;
                    }
                }
            }
        }
        public void ShowCurrentPlanet()
        {
            List<object> caracs = new List<object>();
            CurrentPlanet.Text = string.Empty;
            var pos = _universe.Cells.Where( c => c.Position.X == _universe.User.Position.X && c.Position.Y == _universe.User.Position.Y ).Single();
            if( pos.ContainsPlanet )
            {
                if(pos.ContainedPlanet.Ressources != "none" && pos.ContainedPlanet.Factory == false)
                {
                    Build.Show();
                }
                else
                { 
                    Build.Hide();
                }
                CurrentPlanet.Text+= "Name: " + pos.ContainedPlanet.Name+Environment.NewLine ;
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
                CurrentPlanet.Text+= "No planet to interact with";
            }
        }

       /* protected override bool ProcessCmdKey( ref Message msg, Keys keyData )
        {
            if( this.map.Visible )
            {
                if( keyData == Keys.Up )
                {
                    if( _universe.User.Move( new Position( _universe.User.Position.X, (_universe.User.Position.Y - 1) ) ) )
                    {
                        map.Refresh();
                    }
                }
                else if( keyData == Keys.Down )
                {
                    if( _universe.User.Move( new Position( _universe.User.Position.X, (_universe.User.Position.Y + 1) ) ) )
                    {
                        map.Refresh();
                    }
                }
                else if( keyData == Keys.Left )
                {
                    if( _universe.User.Move( new Position( (_universe.User.Position.X - 1), _universe.User.Position.Y ) ) )
                    {
                        map.Refresh();
                    }
                }
                else if( keyData == Keys.Right )
                {
                    if( _universe.User.Move( new Position( (_universe.User.Position.X + 1), _universe.User.Position.Y ) ) )
                    {
                        map.Refresh();
                    }
                }
                ShowCurrentPlanet();
            }
            return true;
        }*/

        private void EndTurn_Click( object sender, EventArgs e )
        {
            _universe.EndTurn();
           // _universe.ToXML();
        }

        private void Build_Click( object sender, EventArgs e )
        {
             var pos = _universe.Cells.Where( c => c.Position.X == _universe.User.Position.X && c.Position.Y == _universe.User.Position.Y ).Single();
             if( pos.ContainsPlanet && pos.ContainedPlanet.Ressources !="none" )
             {
                 pos.ContainedPlanet.Factory = true;
                 ShowCurrentPlanet();
             }
        }
    }
}
