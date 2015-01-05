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
    public partial class Codex : Form
    {
        public Codex()
        {
            InitializeComponent();
        }

        private void HydrogenButton_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("en.wikipedia.org/wiki/Hydrogen");
            this.webBrowser1.Show();
        }

        private void SiliciumButton_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("en.wikipedia.org/wiki/Silicon");
            this.webBrowser1.Show();
        }

        private void GemsButton_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("en.wikipedia.org/wiki/Gemstone");
            this.webBrowser1.Show();
        }

        private void PlutoniumButton_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("en.wikipedia.org/wiki/Plutonium");
            this.webBrowser1.Show();
        }

        private void MetalButton_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("en.wikipedia.org/wiki/Metal");
            this.webBrowser1.Show();
        }

        private void HeliumButton_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("en.wikipedia.org/wiki/Helium");
            this.webBrowser1.Show();
        }


    }
}
