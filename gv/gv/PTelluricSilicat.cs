using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gv
{
    class PTelluricSilicat : Planet
    {
        bool _inhabited;
        string _climate;
        string _surface;

        internal PTelluricSilicat( Universe u )
            : base( u )
        {
            _surface = PlanetAttributes.PlanetSurface( u.Rand.Next( 5, 9 ) );
            _climate = PlanetAttributes.PlanetClimate( u.Rand.Next( 0, 3 ) );
            _inhabited = (u.Rand.Next( 0, 2 ) > 0) ? true : false;
        }

        public override string Type
        {
            get { return "Telluric Silicat"; }
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
            get { return "Sillicium"; }
        }
    }
}
