using System;
using System.Collections.Generic;

namespace gv
{
    public class PlanetAttributes
    {
       internal static readonly List<string> _planetTypes = new List<string>()
            {
                "Telluric Silicat" ,
                "Telluric Carbon" ,
                "Telluric Metal" ,
                "Telluric Lava" ,
                "Telluric Ice" ,
                "Telluric Desert" ,
                "Coreless" ,
                "Gazeous Hydrogen" ,
                "Gazeous Helium" ,
                "Chthonian"
                };
        internal static readonly List<string> _planetSurfaces = new List<string>()
        {
            "Lava",
            "Sand Desert",
            "Stone Desert",
            "Ice Desert",
            "Iced Atmosphere",
            "Forest",
            "Planetopolis",
            "Oceanic",
            "Glass"
        };
        internal static readonly List<string> _planetRessources = new List<string>()
        {
            "Silicium",
            "Gems",
            "Metal",
            "Hydrogene",
            "Helium",
            "Plutonium",
            "none"
        };
        internal static string PlanetType(int i)
        {
            return _planetTypes[i] ;
        }
       internal static string PlanetSurface(int i)
        {
            return _planetSurfaces[i] ; 
        }
        public static List<string> PlanetTypes
        {
            get { return _planetTypes; }
        }
        public static List<string> PlanetSurfaces
        {
            get { return _planetSurfaces; }
        }
    }
    
}
