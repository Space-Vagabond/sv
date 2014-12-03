using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gv
{
    class Earth : Planet
    {
        string _surface;
        string _climate;
        bool _inhabited;

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
            set { _surface = "Ravaged"; }
            
        }
        public override string Climate
        {
            get { return "Temperate"; }
            set { _climate = "Temperate"; }
        }
        public override bool IsInhabited
        {
            get { return false; }
            set { _inhabited = false; }
        }
        public override string Ressources
        {
            get { return "none"; }
        }
    }
}