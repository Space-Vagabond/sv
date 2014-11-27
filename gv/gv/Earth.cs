using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gv
{
    class Earth : Planet
    {
        internal Earth( Universe u )
            :base(u, "Earth")
        {
        }
        public override string Type
        {
            get { return "Destroyed"; }
        }
        public override string Surface
        {
            get { return "Ravaged"; }
        }
        public override string Climate
        {
            get { return "Temperate"; }
        }
        public override bool IsInhabited
        {
            get { return false; }
        }
        public override string Ressources
        {
            get { return "none"; }
        }
    }
}