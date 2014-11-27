﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gv
{
    class PCoreless : Planet
    {
        string _surface;
        string _climate;
        internal PCoreless( Universe u )
            : base( u, null )
        {
            _surface = PlanetAttributes.PlanetSurface( u.Rand.Next( 5, 9 ) );
            _climate = PlanetAttributes.PlanetClimate( u.Rand.Next( 0, 3 ) );
        }

        public override string Type
        {
            get { return "Coreless"; }
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
            get { return true; }
        }
        public override string Ressources
        {
            get { return "none"; }
        }
    }
}