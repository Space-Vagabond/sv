using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galactic_Vagabond
{
    public class TechButton : Button
    {
        bool _enabled;

        public bool TEnabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }
    }
}
