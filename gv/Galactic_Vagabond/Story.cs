using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galactic_Vagabond
{
    public partial class Story : Form
    {
        public Story()
        {
            InitializeComponent();
            label1.Width = this.Width;

            label1.Text = "2035 A.D, the earth has run out of resources."+Environment.NewLine
            +"You recently heard about a legend of old about a promised land far beyond the solar system."+Environment.NewLine
            + "As your only and last chance for survival, you decide to try and find it." + Environment.NewLine
            +"Explore the endless universe in a 2D turn-based game, meet alien civilizations,"+Environment.NewLine
            +"harvest resources to pursue your dream and who knows, maybe you’ll find your promised land…";
        }

        private void button1_Click( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
