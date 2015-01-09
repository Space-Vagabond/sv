using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Galactic_Vagabond
{
    public partial class GameLoader : Form
    {
        public GameLoader()
        {
            InitializeComponent();
            string folderPath = @Environment.GetFolderPath( Environment.SpecialFolder.ApplicationData ) + "/GVSaves";
            DirectoryInfo dir = new DirectoryInfo( folderPath );
            FileInfo[] files = dir.GetFiles( "save*", SearchOption.TopDirectoryOnly );

            string[] fileNames = files.Select( f => f.Name ).ToArray();

            for( int i = 0; i < files.Length; i++ )
            {
                Games.Items.Add( files[i] );
            }
            if( Games.Items.Count == 0 )
            {
                Games.Items.Add( "No game to load" );
                this.Msg.Hide();
                Games.Enabled = false;
                LoadSelected.Enabled = false;
            }
        }
        private void Back_Click( object sender, EventArgs e )
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
            this.Close();
        }

        private void LoadSelected_Click( object sender, EventArgs e )
        {
            if( Games.SelectedValue != null )
            {
                this.Doc = XDocument.Load( @".\..\..\..\Saves\" + Games.SelectedItem );
                DialogResult = System.Windows.Forms.DialogResult.Yes;
                this.Close();
            }            
        }
        public XDocument Doc {get;set;}

        private void Games_SelectedValueChanged( object sender, EventArgs e )
        {
            this.LoadSelected.Enabled = true;
            this.Msg.Hide();
        }
    }
}
