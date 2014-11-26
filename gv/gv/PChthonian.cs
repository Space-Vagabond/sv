using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gv
{
    class PChthonian : Planet
    {
        string _ressources;
        internal PChthonian(Universe u)
            : base( u )
        {
            _ressources = PlanetAttributes.PlanetRessource( u.Rand.Next( 1, 3 ) );
        }

        public override string Type
        {
            get { return "Chtonian"; }
        }
        public override string Surface
        {
            get { return "Stone Desert"; }
        }
        public override string Climate
        {
            get { return "Hot"; }
        }
        public override bool IsInhabited
        {
            get { return false; }
        }
        public override string Ressources
        {
            get { return _ressources; }
        }
    }
}
