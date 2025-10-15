using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG3B_Task1
{
    public class EventManager
    {
        public Stack<Event> events = new Stack<Event>();
        public Dictionary<string, Event> EventDictionary = new Dictionary<string, Event>();
        public HashSet<string> Categories = new HashSet<string>();

        public void AddEvent(Event newEvent)
        {
         events.Push(newEvent);
            EventDictionary[newEvent.Title] = newEvent;
            foreach (var ev in newEvent.Categories)
       
            Categories.Add(ev);
        }

        public IEnumerable<Event> GetAllEvents()
        {
            return events.Reverse();//so that older ones appear first
        }

        public IEnumerable<Event> GetEventsByCategory(string category)
        {
            return events.Where(e => e.Categories.Contains(category));
        }

        public IEnumerable<Event> FilterEvents(string category = null, DateTime? date = null)
        {
            IEnumerable<Event> filtered = events;

            if (!string.IsNullOrEmpty(category))
                filtered = filtered.Where(e => e.Categories.Contains(category));

            if (date.HasValue)
                filtered = filtered.Where(e => e.Date.Date == date.Value.Date);

            return filtered.Reverse(); // Optional, keeps consistent display order
        }
    }
}
