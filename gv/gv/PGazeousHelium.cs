using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gv
{
    class PGazeousHelium : Planet
    {
        bool _inhabited;
        internal PGazeousHelium( Universe u )
            : base( u, null )
        {
            _inhabited = (u.Rand.Next( 0, 2 ) > 0) ? true : false;
        }

        public override string Type
        {
            get { return "Gazeous Helium"; }
        }
        public override string Surface
        {
            get { return "Iced Atmosphere"; }
        }
        public override string Climate
        {
            get { return "Cold"; }
        }
        public override bool IsInhabited
        {
            get { return _inhabited; }
        }
        public override string Ressources
        {
            get { return "Helium"; }
        }
    }
}
