using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gv
{
    class PTelluricMetal : Planet
    {
        string _surface;
        string _climate;
        bool _inhabited;
        internal PTelluricMetal( Universe u )
            : base( u )
        {
            _surface = PlanetAttributes.PlanetSurface( u.Rand.Next( 5, 9 ) );
            _climate = PlanetAttributes.PlanetClimate( u.Rand.Next( 0, 3 ) );
            _inhabited = (u.Rand.Next( 0, 2 ) > 0) ? true : false;

        }

        public override string Type
        {
            get { return "Telluric Metal"; }
        }
        public override string Surface
        {
            get { return _surface; }
        }
        public override string Climate
        {
            get { return _climate; }
        }
        public override bool IsInhabited
        {
            get { return _inhabited; }
        }
        public override string Ressources
        {
            get { return "Metal"; }
        }
    }
}
