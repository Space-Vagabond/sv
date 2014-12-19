using System;
using System.Collections.Generic;
using System.Linq;


namespace gv
{
    public class EventGenerator
    {
        Universe _u;
        Dictionary<int,List<string>> _allEvents = new Dictionary<int,List<string>>();

        public EventGenerator(Universe universe)
        {
            _u = universe;            
        }
        /// <summary>
        /// Chooses if planet is affected by a universe event 
        /// </summary>
        public void EventOccurs()
        {
           List<string> turnEvents = new List<string>();
           foreach (Planet pl in _u.Planets.Values) 
           {
               if( pl.Name != "Earth" && pl.Name != "Eldorado" )
               {
                   int caseEvent = _u.Rand.Next( 0, 50);
                   switch( caseEvent )
                   {
                       case 0: MeteorStrikesPlanet( turnEvents, pl );
                           break;
                       case 1: RevolutionOnPlanet( turnEvents, pl );
                           break;
                       case 2: ElectricStorm( turnEvents, pl );
                           break;
                       case 3: SpaceshipNoMove(turnEvents);
                           break;
                       case 4: PlResourcesStolen(turnEvents);
                           break;
                       case 5: GainSpeed(turnEvents);
                           break;
                           
                   }    
               }          
           }
           _allEvents.Add( _u.Turn, turnEvents );
        }
        /// <summary>
        /// Changing surface and inhabitants 
        /// </summary>
        /// <param name="pl"></param>
        void MeteorStrikesPlanet(List<string> turnEvents, Planet pl )
        {
            pl.Surface = "Destroyed by asteroid";
            pl.IsInhabited = false;
            turnEvents.Add( String.Format( "{0} struck by asteroid, surface destroyed, inhabitants killed", pl.Name.ToUpper() ) );  
        }
        /// <summary>
        /// For immersion purposes
        /// </summary>
        /// <param name="pl"></param>
        void RevolutionOnPlanet(List<string> turnEvents, Planet pl) 
        {
            turnEvents.Add(String.Format("Revolution on {0}, hope the new power is nice to foreigners.",pl.Name.ToUpper() ) );   
        }
        /// <summary>
        /// Makes a planet inaccessible for 2 turns.
        /// </summary>
        /// <param name="pl"></param>
        void ElectricStorm(List<string> turnEvents, Planet pl )
        {
            pl.Blocked = 2;
            turnEvents.Add( String.Format( "Electric storm on {0}, planet inaccessible for two turns.", pl.Name.ToUpper() ) ); 
        }

        /// <summary>
        /// Disabling player movement for one turn
        /// </summary>
        /// <param name="turnEvents"></param>
        void SpaceshipNoMove(List<string> turnEvents)
        {
            int luck = _u.Rand.Next(0, 10);
            if (_u.User.RemainingSteps > 0 && luck == 1)
            {
                _u.User.RemainingSteps = 0;
                turnEvents.Add("Your spaceship was damaged, you can't move this turn");
            }
        }

        void PlResourcesStolen(List<string> turnEvents)
        {
            int luck = _u.Rand.Next(0, 10);
            if (luck == 1)
            {
                int amount = _u.Rand.Next(5, 20);
                if (_u.User.Ressources["Metal"] > amount)
                {
                    _u.User.Ressources["Metal"] -= amount;
                    turnEvents.Add(String.Format("Income was stolen by local smugglers, you lost {0} metal", amount));
                }
                if (_u.User.Ressources["Gems"] > amount)
                {
                    _u.User.Ressources["Gems"] -= amount;
                    turnEvents.Add(String.Format("Income was stolen by local smugglers, you lost {0} gems", amount));
                }
            }
        }

        void GainSpeed( List<string> turnEvents)
        {
            _u.User.RemainingSteps += 1;
            turnEvents.Add("Favourable conditions, you gain 1 speed this turn.");
        }

        public Universe Universe
        {
            get { return _u; }
        }      
        public IReadOnlyDictionary<int,List<string>> AllEvents
        {
            get { return _allEvents; }
        }
    }
}
