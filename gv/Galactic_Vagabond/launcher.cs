using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Galactic_Vagabond
{
    public partial class launcher : Form
    {
        public launcher()
        {
            InitializeComponent();
        }

        private void NewGame_Click( object sender, EventArgs e )
        {
            this.NewGame.Enabled = false;
            this.playerName.Visible = true;
            this.StartGame.Visible = true;          
        }
        private void button1_Click( object sender, EventArgs e )
        {            
            this.Hide();
            using( GameLoader loader = new GameLoader() )
            {
                var result = loader.ShowDialog();
                if( result == DialogResult.No )
                {
                    this.Show();
                }
                else
                {
                    this.Doc = loader.Doc;
                    DialogResult = System.Windows.Forms.DialogResult.No;
                    this.Close();
                }
            }            
        }
        public XDocument Doc { get; set; }
        public string PName { get; set; }

        private void StartGame_Click( object sender, EventArgs e )
        {
            
            PName = playerName.Text.ToString();
            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.Close();
        }
    }
}
