using System;
using System.Collections.Generic;
using ET.FakeText;

namespace gv
{
    public class Planet
    {
         string _name;
         static int planetNumber = 0;
         string _type;
         string _climate;
         string _surface;
         string _ressource; 
         bool _inhabited; 
         string _inhabitantsName;


        internal Planet()
        {
            planetNumber++;
            TextGenerator NameGen = new TextGenerator(WordTypes.Name);
            int n =  Universe.rand.Next( 6, 9 ); 
            
            _name = NameGen.GenerateWord( n );
            _inhabitantsName = _name + "ians";
            _name = _name + "us";

            int t = Universe.rand.Next( 0, 10 );
            _type = PlanetAttributes.PlanetType(t);

            GeneratePlanetAttributes( t );
            return;
            
        }
        internal Planet(bool type)
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
        void GeneratePlanetAttributes( int t )
        {
            GenerateSurfaceAndClimate( t );
            GenerateRessourcesAndHabitants( t );
        }

        void GenerateSurfaceAndClimate( int t )
        {
            if( t == 3 )
            {
                _surface = PlanetAttributes.PlanetSurface( 0 );
                _climate = PlanetAttributes.PlanetClimate(2);
            }
            else if( t == 6 )
            {
                _surface = PlanetAttributes.PlanetSurface( 1 );
                _climate = PlanetAttributes.PlanetClimate( 2 );
            }
            else if( t == 9 )
            {
                _surface = PlanetAttributes.PlanetSurface( 2 );
                _climate = PlanetAttributes.PlanetClimate( 2 );
            }
            else if( t == 8 || t == 7 )
            {
                _surface = PlanetAttributes.PlanetSurface( 4 );
                _climate = PlanetAttributes.PlanetClimate( 0 );
            }
            else if( t == 4 )
            {
                _surface = PlanetAttributes.PlanetSurface( 3 );
                _climate = PlanetAttributes.PlanetClimate( 0 );
            }
            else
            {
                _surface = PlanetAttributes.PlanetSurface( Universe.rand.Next( 5, 9 ) );
                _climate = PlanetAttributes.PlanetClimate(Universe.rand.Next( 0, 3 ));
            }
        }
        void GenerateRessourcesAndHabitants( int t )
        {
            if( t == 0 || t == 6 )
            {
                _ressource = PlanetAttributes.PlanetRessource( 0 );
                _inhabited = (Universe.rand.Next(0,2) >0)?true:false ;
            }
            else if( t == 1 )
            {
                _ressource = PlanetAttributes.PlanetRessource( 1 );
                _inhabited = (Universe.rand.Next( 0, 2 ) > 0) ? true : false;
            }
            else if( t == 2 )
            {
                _ressource = PlanetAttributes.PlanetRessource( 3 );
                _inhabited = (Universe.rand.Next( 0, 2 ) > 0) ? true : false;
            }
            else if( t == 7 )
            {
                _ressource = PlanetAttributes.PlanetRessource( 4 );
                _inhabited = (Universe.rand.Next( 0, 2 ) > 0) ? true : false;
            }
            else if( t == 8 )
            {
                _ressource = PlanetAttributes.PlanetRessource( 5 );
                _inhabited = (Universe.rand.Next( 0, 2 ) > 0) ? true : false;
            }
            else if( t == 9 )
            {
                _ressource = PlanetAttributes.PlanetRessource( Universe.rand.Next(1,3));
                _inhabited = false;
            }
            else
            {
                _ressource = PlanetAttributes.PlanetRessource( 6 );
                _inhabited = true;
            }
        }
        public string Name
        {
            get { return _name; }
        }
        public string Type
        {
            get { return _type; }
        }
        public string Climate
        {
            get { return _climate; }
        }
        public string Surface
        {
            get { return _surface; }
        }
        public string Ressource
        {
            get { return _ressource; }
        }
        public bool Inhabited
        {
            get { return _inhabited; }
        }
        public string InhabitantsName
        {
            get
            {
                if( this.Inhabited )
                {
                    return _inhabitantsName;
                }
                else
                {
                    return "Inhabited planet";
                }
            }
        }
        
    }
}
