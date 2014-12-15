using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace gv
{
    public class EventGenerator
    {
        Universe _u;
        Dictionary<int,List<string>> _eventsOccured = new Dictionary<int,List<string>>();
        List<string> _allEvents;

        public EventGenerator(Universe universe)
        {
            _u = universe;
            
        }

        /// <summary>
        /// Chooses if planet is affected by a universe event 
        /// </summary>
        public void EventOccurs(int turn )
        {
           List<string> turnEvents = new List<string>();
           foreach (Planet pl in _u.Planets.Values) 
           {
              int caseEvent = _u.Rand.Next( 0, 12 );
              switch(caseEvent)
              {
                  case 0: MeteorStrikesPlanet(turnEvents, pl );
                  break;
                  case 1: RevolutionOnPlanet(turnEvents, pl );
                  break;
                  case 2: ElectricStorm(turnEvents, pl );
                  break;

              }
              
              
           }
           _eventsOccured.Add( turn, turnEvents );
           _allEvents = EventsTolist();
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
            //pl.IsBlocked = 2;
            turnEvents.Add( String.Format( "Electric storm on {0}, planet inaccessible for two turns.", pl.Name.ToUpper() ) );
   
        }

        /// <summary>
        /// Building list from dict, for display purposes.
        /// </summary>
        /// <returns></returns>
        List<string> EventsTolist()
        {
            var items = _eventsOccured.SelectMany (d => d.Value).ToList();
            List<string>allevents = items;
            return allevents;
        }

        public Universe Universe
        {
            get { return _u; }
        }
        
        public IReadOnlyDictionary<int,List<string>> EventsOccured
        {
            get { return _eventsOccured; }
        }

        public IReadOnlyList<string> AllEvents
        {
            get { return _allEvents; }
        }
    }
}
