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
            _inhabited = false;
            _climate = "Temperate";
            _surface = "Golden";
        }
        public override string Type
        {
            get { return "Promised Land"; }
        }
        public override string Surface
        {
            get { return _surface; ; }
            set { _surface = "Golden"; }
        }
        public override string Climate
        {
            get { return _climate; }
            set { _climate = "Temperate"; }
        }
        public override bool IsInhabited
        {
            get { return _inhabited; }
            set { _inhabited = false; }
        }
        public override string Ressources
        {
            get { return "none"; }
        }
    }
}      
