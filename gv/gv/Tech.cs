using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gv
{
    public class Tech
    {
        static readonly Dictionary<string,string> Techs = new Dictionary<string, string>()
       {
            {"Gaz Extractor","Allows you to extract Helium and Hydrogen"},
            {"Gems Extractor","Allows you to extract Gems"},
            {"Plutonium Extractor","Allows you to extract Plutonium"},
            {"Hydrogen Engine","Increases your max speed to 10"},
            {"Helium Engine","Increases your max speed to 15"},
            {"Plutonium Engine","Increases your max speed to 20"},
            {"Factory Upgrade", "Multiplies your income by 1.5"},
            {"Radar","Allows you to know where are planets in Overview"},
            {"Diplomacy","Aliens are now your friends they help for you, adds 10% income for inhabited planets"},
            {"Workers","Aliens are now your workers they work for you, adds 20% income for inhabited planets"},
            {"Slavery", "Aliens are now your slaves, you force them to work for you, adds 50% income for inhabited planets"}
        };
    }
}
