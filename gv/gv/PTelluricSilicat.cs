﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace gv
{
    class PTelluricSilicat : Planet
    {
        bool _inhabited;
        string _climate;
        string _surface;
        int _img;

        internal PTelluricSilicat( Universe u )
            : base( u, "" )
        {
            _surface = PlanetAttributes.PlanetSurface( u.Rand.Next( 5, 9 ) );
            _climate = PlanetAttributes.PlanetClimate( u.Rand.Next( 0, 3 ) );
            _inhabited = (u.Rand.Next( 0, 2 ) > 0) ? true : false;
            _img = 13;
        }
        internal PTelluricSilicat( Universe u, XElement attributes )
            :base(u, attributes)
        {
            
        }

        public override string Type
        {
            get { return "Telluric Silicat"; }
        }
        public override string Surface
        {
            get { return _surface; }
            set { _surface = value; }
        }
        public override string Climate
        {
            get { return _climate; }
            set { _climate = value; }
        }
        public override bool IsInhabited
        {
            get { return _inhabited; }
            set { _inhabited = value; }
        }
        public override string Ressources
        {
            get { return "Silicium"; }
            
        }
        public override int Img
        {
            get { return _img; }
            internal set { _img = value; }
        }
    }
}
