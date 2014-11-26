using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gv
{
    class PTelluricIce : Planet
    {

        internal PTelluricIce( Universe u )
            : base( u )
        {
        }

        public override string Type
        {
            get { return "Telluric Ice"; }
        }
        public override string Surface
        {
            get { return "Ice Desert"; }
        }
        public override string Climate
        {
            get { return "Cold"; }
        }
        public override bool IsInhabited
        {
            get { return true; }
        }
        public override string Ressources
        {
            get { return "none"; }
        }
    }
}
