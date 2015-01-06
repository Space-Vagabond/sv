using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gv
{
    public class Tech
    {
        string _name;
        string _description;
        int _costMetal;
        int _costSilicium;
        int _costHydrogene;
        int _costHelium;
        int _costGems;
        int _costPlutonium;
        Tech _prev1;
        Tech _prev2;
        bool _discovered;

        internal Tech( string name, string description, int costM, int costS, int costHy, int costHe, int costG, int costP )
            : this( name, description, costM,  costS,  costHy,  costHe,  costG,  costP, null, null ) { }
        internal Tech( string name, string description, int costM, int costS, int costHy, int costHe, int costG, int costP, Tech prev1 )
            : this( name, description, costM, costS, costHy, costHe, costG, costP, prev1, null ) { }
        internal Tech( string name, string description, int costM, int costS, int costHy, int costHe, int costG, int costP, Tech prev1, Tech prev2 )
        {
            _name = name;
            _description = description;
            _costMetal = costM;
            _costSilicium = costS;
            _costHydrogene = costHy;
            _costHelium = costHe;
            _costGems = costG;
            _costPlutonium = costP;
            _prev1 = prev1;
            _prev2 = prev2;
            _discovered = false;
        }
        public string Name
        {
            get{return _name;}
        }
        public string Description
        {
            get { return _description; }
        }
        public int CostMetal
        {
            get { return _costMetal; }
        }
        public int CostSilicium
        {
            get { return _costSilicium; }
        }
        public int CostHydrogene
        {
            get { return _costHydrogene; }
        }
        public int CostHelium
        {
            get { return _costHelium; }
        }
        public int CostGems
        {
            get { return _costGems; }
        }
        public int CostPlutonium
        {
            get { return _costPlutonium; }
        }
        public Tech Prev1
        {
            get { return _prev1; }
        }
        public Tech Prev2
        {
            get { return _prev2; }
        }
        public bool IsDiscovered
        {
            get { return _discovered; }
            set { _discovered = value; }
        }
    }
}
