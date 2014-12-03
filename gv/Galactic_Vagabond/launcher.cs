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
    public partial class launcher : Form
    {
        public launcher()
        {
            InitializeComponent();
        }

        private void NewGame_Click( object sender, EventArgs e )
        {
            DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.Close();          
        }
        private void button1_Click( object sender, EventArgs e )
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
            this.Close(); 
        } 
    }
}
