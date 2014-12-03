using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gv
{
    class Eldorado : Planet
    {
        string _surface;
        string _climate;
        bool _inhabited;
        
        internal Eldorado( Universe u )
            :base(u, "Eldorado")
        {

        }
        public override string Type
        {
            get { return "Promised Land"; }
        }
        public override string Surface
        {
            get { return "Golden"; }
            set { _surface = "Golden"; }
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
