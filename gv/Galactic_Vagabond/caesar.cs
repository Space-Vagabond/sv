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
    public partial class caesar : Form
    {
        string _clearMsg;
        string _encryptedMsg;
        public caesar()
        {
            InitializeComponent();
            _clearMsg = "Hello traveler";
            obfuscateMsg(_clearMsg);
            MessageLabel.Text = _encryptedMsg;

        }

        void obfuscateMsg(string _clearMsg)
        {
            for (int iChar = 0; iChar < _clearMsg.Length; iChar += 1)
            {
                _encryptedMsg += (char)(_clearMsg[iChar] + 3);
            }
        }

        private void ValidateButton_Click(object sender, EventArgs e)
        {
            if (UserInput.Text == _clearMsg)
            {
                MessageBox.Show("You are welcome on our planet, noble traveler");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Go back to your planet with your inferior brain");
                this.Dispose();
            }
            
        }
    }
}
