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
    public partial class mastermind : Form
    {
        string _toDisplay;
        Timer _myTimer = new System.Windows.Forms.Timer();

        public mastermind()
        {
            InitializeComponent();
            LettersSequence _l = new LettersSequence();
            _toDisplay = _l.GenerateSequence();
            this.SequenceLabel.Text = _toDisplay.ToUpper();
            _toDisplay = this.SequenceLabel.Text;

            _myTimer.Tick += new EventHandler(TimerEventProcessor);
            _myTimer.Interval = 3500;
            _myTimer.Start();

        }

        private void TimerEventProcessor(Object myObject,
                                            EventArgs myEventArgs)
        {
            _myTimer.Stop();
            _myTimer.Dispose();
            this.SequenceLabel.Text = "********";
        }


        private void ValidateButton_Click(object sender, EventArgs e)
        {
            if (this.UserInput.Text == _toDisplay)
            {
                DialogResult = System.Windows.Forms.DialogResult.Yes;
            }
            else
            {
                DialogResult = System.Windows.Forms.DialogResult.No; 
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
            for (i = 0; i < 8; i += 1)
            {
                int j = _r.Next(_alphabet.Length);
                _sequence[i] = _alphabet[j];
            }
            string display = new string(_sequence);
            return display;
        }
    }
}
