﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gv
{
    class PTelluricDesert : Planet
    {
        bool _inhabited;
        string _surface;
        string _climate;

        internal PTelluricDesert( Universe u )
            : base( u, null )
        {
            _inhabited = (u.Rand.Next( 0, 2 ) > 0) ? true : false;
            _surface = "Sand desert";
            _climate = "Hot";
        }

        public override string Type
        {
            get { return "Telluric Desert"; }
        }
        public override string Surface
        {
            get { return _surface; ; }
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
    }
}
