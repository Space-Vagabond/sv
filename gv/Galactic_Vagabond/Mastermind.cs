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
    public partial class Mastermind : Form
    {
        string _toDisplay;
        public Mastermind()
        {
            InitializeComponent();
            LettersSequence _l = new LettersSequence();
            string _toDisplay =  _l.GenerateSequence();
            this.SequenceLabel.Text = _toDisplay.ToUpper();  
        }

        private void ValidateButton_Click(object sender, EventArgs e)
        {
            if (this.UserInput.Text.ToLower() == _toDisplay)
            {

            }

        }

    }

    public class LettersSequence
    {
        string _alphabet = "abcdefghijklmnopqrstuvwxyz";
        internal char[] _sequence = new char[8];
        Random _r = new Random();

        internal string GenerateSequence()
        {
            int i;
            for(i = 0; i < 8; i +=1 ) 
            {
                int j = _r.Next(_alphabet.Length);
                _sequence[i] = _alphabet[j];
            }
            string display = new string(_sequence);
            return display;
        }
    }
}
