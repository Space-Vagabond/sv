using System.Drawing;
using System;
namespace gv
{
    class Earth : Planet
    {
        string _surface;
        string _climate;
        bool _inhabited;
        int _img;
        internal Earth( Universe u )
            :base(u, "Earth")
        {
            _surface = "Ravaged";
            _climate = "Temperate";
            _inhabited = false;
            _img = 18;
            base.IsDiscovered = true;
        }
        public override string Type
        {
            get { return "Destroyed"; }
        }
        public override string Surface
        {
            get { return _surface; }
            set { _surface = "Ravaged"; }
            
        }
        public override string Climate
        {
            get { return _climate; }
            set { _climate = "Temperate"; }
        }
        public override bool IsInhabited
        {
            get { return _inhabited; }
            set { _inhabited = false; }
        }
        public override string Ressources
        {
            get { return "none"; }
        }
        public override int Img
        {
            get { return _img; }
        }
    }
}