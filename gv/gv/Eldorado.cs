using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gv
{
    class Eldorado : Planet
    {
        internal Eldorado( Universe u )
        {

        }
        public override string Name 
        {
            get{return "Eldorado";}
        }
        public override string Type
        {
            get { return "Promised Land"; }
        }
        public override string Surface
        {
            get { return "Golden"; }
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
        public override string InhabitantsName 
        {
            get{return "Dorados";}
        }
    }
}      
