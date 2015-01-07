using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gv
{
    class PGazeousHydrogen : Planet
    {
        bool _inhabited;
        string _surface;
        string _climate;
        int _img;

        internal PGazeousHydrogen( Universe u )
            : base( u, null )
        {
            _inhabited = (u.Rand.Next( 0, 2 ) > 0) ? true : false;
            _climate = "Cold";
            _surface = "Iced";
            _img = 8;
        }

        public override string Type
        {
            get { return "Gazeous Hydrogen"; }
        }
        public override string Surface
        {
            get { return _surface; }
            set { _surface = value;  }
            
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
            get { return "Hydrogen"; }
        }
        public override int Img
        {
            get { return _img; }
        }
    }
}
