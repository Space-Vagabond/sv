using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gv
{
    class Planet:Earth
    {
        internal Earth(bool type)
        {
            if( type == false )
            {
                _name = "Earth";
                _type = "Destroyed";
                _climate = PlanetAttributes.PlanetClimate(1);
                _surface = "Ravaged";
                _climate = PlanetAttributes.PlanetClimate( 1 );
                _ressource = PlanetAttributes.PlanetRessource( 6 );
                _inhabited = false;
                _inhabitantsName = "Terrians";
            }
            else
            {
                _name = "Eldorado";
                _type = "Promised Land";
                _climate = PlanetAttributes.PlanetClimate(1);
                _surface = "Golden";
                _ressource = PlanetAttributes.PlanetRessource( 6 );
                _inhabited = false;
                _inhabitantsName = "Dorados";
            }
        }

    }
}
