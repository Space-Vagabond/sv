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
    public partial class Enigme : Form
    {
        public Enigme()
        {
            InitializeComponent();
            texte.Text = "On this planet, some people always Lie, some always tell the truth" + Environment.NewLine
                + "You took 2 of them a liar and a honnest one." + Environment.NewLine
                + "You can only ask one questionto each to know which one is which." + Environment.NewLine
                + "You decide to ask them \"What would your friend answer if I ask him if he's a liar?\"" + Environment.NewLine
                + "The first one answer \"no\"" + Environment.NewLine
                + "The second one answers\"yes\"" + Environment.NewLine
                + "Which one is the Liar?";

            
        }
    }
}
