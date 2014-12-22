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
        string _surface;
        string _climate;
        bool _inhabited;
        int _img;

        internal PChthonian(Universe u)
            : base( u, null )
        {
            _ressources = PlanetAttributes.PlanetRessource( u.Rand.Next( 1, 3 ) );
            _img = 5;
        }

        public override string Type
        {
            get { return "Chtonian"; }
        }
        public override string Surface
        {
            get { return "Stone"; }
            set { _surface = value; }
        }
        public override string Climate
        {
            get { return "Hot"; }
            set { _climate = value; }
        }
        public override bool IsInhabited
        {
            get { return _inhabited; }
            set { _inhabited = value; }
           
        }
        public override string Ressources
        {
            get { return _ressources; }
        }
        public override int Img
        {
            get { return _img; }
        }
    }
}
