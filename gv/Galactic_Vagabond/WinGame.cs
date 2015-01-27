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
    public partial class WinGame : Form
    {
        public WinGame()
        {
            InitializeComponent();
            label1.Width = this.Width;

            label1.Text = "You have succesfully settled down on the promised land" + Environment.NewLine
            + "You are full of hopes and expect a bright future in the galaxy.";
        }

        private void button1_Click( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
