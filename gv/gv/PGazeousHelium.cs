using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace gv
{
    class PGazeousHelium : Planet
    {
        bool _inhabited;
        string _surface;
        string _climate;
        int _img;

        internal PGazeousHelium( Universe u )
            : base( u, "" )
        {
            _inhabited = (u.Rand.Next( 0, 2 ) > 0) ? true : false;
            _surface = "Iced Atmosphere";
            _climate = "Cold";
            _img = 11;
        }
        internal PGazeousHelium( Universe u, XElement attributes )
            : base( u, attributes )
        {

        }

        public override string Type
        {
            get { return "Gazeous Helium"; }
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
            get { return "Helium"; }
        }
        public override int Img
        {
            get { return _img; }
            internal set { _img = value; }
        }
    }
}
