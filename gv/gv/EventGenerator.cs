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

        public EventGenerator(Universe universe)
        {
            _u = universe;

        }

        void EventOccurs()
        {
           foreach (Planet pl in _u.Planets) 
           {
              int hasEvent = _u.Rand.Next( 0, 4 );

              if( hasEvent == 1 )
              {
                 //doSth
              }
           }
        }

        public Universe U
        {
            get { return _u; }
        }
    }
}
