using System;
using System.Collections.Generic;
using System.Linq;

namespace PROG3B_Task1
{
    public class RecommendationEngine
    {
        private Dictionary<string, int> categoryFrequency = new Dictionary<string, int>();

        // Record user activity
        public void RecordViewedEvent(Event viewedEvent)
        {
            foreach (var category in viewedEvent.Categories)
            {
                if (!categoryFrequency.ContainsKey(category))
                    categoryFrequency[category] = 0;
                categoryFrequency[category]++;
            }
        }

        // Get top user interests
        public IEnumerable<string> GetTopCategories(int count = 3)
        {
            return categoryFrequency.OrderByDescending(c => c.Value)
                                    .Take(count)
                                    .Select(c => c.Key);
        }

        // Recommend events based on top categories
        public IEnumerable<Event> RecommendEvents(EventManager manager)
        {
            var topCats = GetTopCategories().ToList();

            if (!topCats.Any())
            {
                // No events viewed yet → show first 5 upcoming events
                return manager.GetAllEvents()
                              .OrderBy(e => e.Date)
                              .Take(5);
            }

            return manager.GetAllEvents()
                          .Where(e => e.Categories.Any(c => topCats.Contains(c)))
                          .OrderBy(e => e.Date)
                          .Take(5);
        }
    }
}
