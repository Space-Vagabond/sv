using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gv
{
    class PTelluricLava : Planet
    {
        internal PTelluricLava( Universe u )
            : base( u )
        {
            
        }

        public override string Type
        {
            get { return "Telluric Lava"; }
        }
        public override string Surface
        {
            get { return "Lava"; }
        }
        public override string Climate
        {
            get { return "Hot"; }
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
