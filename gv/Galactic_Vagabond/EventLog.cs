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

namespace Galactic_Vagabond
{
    public partial class EventLog : Form
    {
        
        public EventLog()
        {
            InitializeComponent();
            throw new InvalidOperationException( "Dont use this constructor" );
        }

        public EventLog( Universe u )
        {
            InitializeComponent();
            loadEvents( u );
        }

        void loadEvents(Universe u)
        {
            int visibleItem = this.Height / this.Logs.ItemHeight;
            this.Logs.DataSource = u.Event.AllEvents;
            
            this.Logs.TopIndex = Math.Max( this.Logs.Items.Count - visibleItem + 1, 0 );
            this.Logs.SelectedIndex = this.Logs.Items.Count - 1;
        }
    }
}
