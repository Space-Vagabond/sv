﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace gv
{
    class PTelluricIce : Planet
    {
        string _surface;
        string _climate;
        bool _inhabited;
        int _img;

        internal PTelluricIce( Universe u )
            : base( u, "" )
        {
            _surface = "Ice";
            _climate = "Cold";
            _img = 17;
        }
        internal PTelluricIce( Universe u, XElement attributes )
            : base( u, attributes )
        {

        }

        public override string Type
        {
            get { return "Telluric Ice"; }
           
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
            get { return "none"; }
        }
        public override int Img
        {
            get { return _img; }
            internal set { _img = value; }

        }
    }
}
