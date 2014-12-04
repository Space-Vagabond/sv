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
        List<string> _eventsOccured = new List<string>();

        public EventGenerator(Universe universe)
        {
            _u = universe;
            
        }

        /// <summary>
        /// Is a planet affected by a universe event ?
        /// </summary>
        public void EventOccurs()
        {
           foreach (Planet pl in _u.Planets) 
           {
              int hasEvent = _u.Rand.Next( 0, 4 );

              if (hasEvent == 0) 
              {
                  MeteorStrikesPlanet( pl );
              }
              else if (hasEvent == 1) 
              {
                  RevolutionOnPlanet( pl );
              }
              else if( hasEvent == 2 )
              {
                  ElectricStorm( pl );
              }
              else if( hasEvent == 3 )
              {

              }
              
           }
        }

        /// <summary>
        /// Changing surface and inhabitants 
        /// </summary>
        /// <param name="pl"></param>
        void MeteorStrikesPlanet( Planet pl )
        {
            pl.Surface = "Destroyed by asteroid";
            pl.IsInhabited = false;
            _eventsOccured.Add( String.Format("{0} was struck by an asteroid, surface destroyed, inhabitants killed",pl.Name ));
        }

        void RevolutionOnPlanet(Planet pl)
        {
            _eventsOccured.Add( String.Format("A revolution occured on {0}, hope the new power is nice to foreigners",pl.Name ));
        }

        void ElectricStorm( Planet pl )
        {
            //pl.IsBlocked = 2;
            _eventsOccured.Add( String.Format( "Electric storm on {0}, will last for two turns.", pl.Name ) );
        }

        public Universe Universe
        {
            get { return _u; }
        }
        
        public IReadOnlyList<string> EventsOccured
        {
            get { return _eventsOccured; }
        }
    }
}
