using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonComponents
{
    public class EventHelpers
    {
        public static void RaiseEvent(object objectRaisingEvent, EventHandler<AccessTypeEventArgs> eventHandlerRaised, AccessTypeEventArgs accessTypeEventArgs)
        {
            if (eventHandlerRaised != null)
                eventHandlerRaised(objectRaisingEvent, accessTypeEventArgs);
        }

        public static void RaiseEvent(object objectRaisingEvent, EventHandler eventHandlerRaised, EventArgs eventArgs)
        {
            if (eventHandlerRaised != null)
                eventHandlerRaised(objectRaisingEvent, eventArgs);
        }
    }
}