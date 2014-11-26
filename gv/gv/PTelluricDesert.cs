using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gv
{
    class PTelluricDesert : Planet
    {
        bool _inhabited;
        internal PTelluricDesert( Universe u )
            : base( u )
        {
            _inhabited = (u.Rand.Next( 0, 2 ) > 0) ? true : false;
        }

        public override string Type
        {
            get { return "Telluric Desert"; }
        }
        public override string Surface
        {
            get { return "Sand Desert"; }
        }
        public override string Climate
        {
            get { return "Hot"; }
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
