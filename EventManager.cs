using System;
using System.Collections.Generic;
using System.Linq;

namespace PROG3B_Task1
{
    public class EventManager
    {
        // --- Data Structures ---
        private Stack<Event> recentEvents = new Stack<Event>();             // Stack for recently added events (LIFO)
        private Queue<Event> upcomingEvents = new Queue<Event>();           // Queue for upcoming events (FIFO)
        private Dictionary<string, Event> eventDictionary = new Dictionary<string, Event>(); // For fast lookup by title
        private SortedDictionary<DateTime, List<Event>> eventsByDate = new SortedDictionary<DateTime, List<Event>>(); // For chronological organization
        private HashSet<string> categories = new HashSet<string>();         // Unique list of categories

        // --- Public Accessors ---
        public IEnumerable<Event> AllEvents => eventDictionary.Values;
        public IEnumerable<string> Categories => categories;

        // --- Methods ---

        public void AddEvent(Event newEvent)
        {
            // Push to stack (recently added)
            recentEvents.Push(newEvent);

            // Enqueue upcoming
            upcomingEvents.Enqueue(newEvent);

            // Add to dictionary
            eventDictionary[newEvent.Title] = newEvent;

            // Add to sorted dictionary by date
            if (!eventsByDate.ContainsKey(newEvent.Date.Date))
                eventsByDate[newEvent.Date.Date] = new List<Event>();
            eventsByDate[newEvent.Date.Date].Add(newEvent);

            // Track categories
            foreach (var cat in newEvent.Categories)
                categories.Add(cat);
        }

        public IEnumerable<Event> GetAllEvents()
        {
            return eventsByDate.Values.SelectMany(x => x);
        }

        public IEnumerable<Event> GetEventsByCategory(string category)
        {
            return eventDictionary.Values.Where(e => e.Categories.Contains(category));
        }

        public IEnumerable<Event> FilterEvents(string category = null, DateTime? date = null)
        {
            IEnumerable<Event> filtered = eventDictionary.Values;

            if (!string.IsNullOrEmpty(category))
                filtered = filtered.Where(e => e.Categories.Contains(category));

            if (date.HasValue)
                filtered = filtered.Where(e => e.Date.Date == date.Value.Date);

            return filtered.OrderBy(e => e.Date);
        }

        public Event UndoLastAdded()
        {
            if (recentEvents.Count > 0)
            {
                var last = recentEvents.Pop();
                eventDictionary.Remove(last.Title);
                return last;
            }
            return null;
        }

        public IEnumerable<Event> GetUpcomingEvents()
        {
            return upcomingEvents.OrderBy(e => e.Date);
        }
    }
}
