using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PROG3B_Task1
{
    public partial class Form3 : Form
    {
        private EventManager eventManager = new EventManager();
        private RecommendationEngine recommender = new RecommendationEngine();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadSampleEvents();

            // Add categories to combo box
            cmbCategories.Items.AddRange(eventManager.Categories.ToArray());

            DisplayEvents(eventManager.GetAllEvents());
            DisplayRecommendations();
        }

      

        private void LoadSampleEvents()
        {
            var event1 = new Event
            {
                Title = "Music Concert",
                Description = "A live music concert featuring popular bands.",
                Categories = new HashSet<string> { "Music", "Entertainment" },
                Date = DateTime.Now.AddDays(10),
            };

            var event2 = new Event
            {
                Title = "Community Gathering",
                Description = "Meet with councillors and neighbors to discuss local matters.",
                Categories = new HashSet<string> { "Community", "Political" },
                Date = DateTime.Now.AddDays(5),
            };

            var event3 = new Event
            {
                Title = "Neighborhood Clean-Up",
                Description = "Beautify the park and help clean community spaces.",
                Categories = new HashSet<string> { "Volunteer", "Community" },
                Date = DateTime.Now.AddDays(7),
            };

            var event4 = new Event
            {
                Title = "Public Safety Workshop",
                Description = "Learn about emergency preparedness and community safety.",
                Categories = new HashSet<string> { "Education", "Safety" },
                Date = DateTime.Now.AddDays(12),
            };

            eventManager.AddEvent(event1);
            eventManager.AddEvent(event2);
            eventManager.AddEvent(event3);
            eventManager.AddEvent(event4);
        }

        private void DisplayEvents(IEnumerable<Event> events)
        {
            eventFlowLayout.Controls.Clear();
            foreach (var ev in events)
            {
                var card = new Eventcard(ev);
                card.Click += (s, e) => OnEventViewed(ev);
                // Forward clicks from inner controls
                foreach (Control c in card.Controls)
                    c.Click += (s, e) => OnEventViewed(ev);
                eventFlowLayout.Controls.Add(card);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string selectedCategory = cmbCategories.SelectedItem?.ToString();
            DateTime? selectedDate = chkUseDateFilter.Checked ? dtpDateFilter.Value.Date : (DateTime?)null;

            var filtered = eventManager.FilterEvents(selectedCategory, selectedDate);
            DisplayEvents(filtered);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbCategories.SelectedIndex = -1;
            chkUseDateFilter.Checked = false;
            DisplayEvents(eventManager.GetAllEvents());
            DisplayRecommendations();
        }

        private void OnEventViewed(Event ev)
        {
            recommender.RecordViewedEvent(ev);
            DisplayRecommendations();
        }

        private void DisplayRecommendations()
        {
            recommendationFlowLayout.Controls.Clear();

            Label lblTitle = new Label
            {
                Text = "Recommended for You",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.MediumSlateBlue,
                AutoSize = true
            };
            recommendationFlowLayout.Controls.Add(lblTitle);

            var recommended = recommender.RecommendEvents(eventManager);

            foreach (var ev in recommended)
            {
                var card = new Eventcard(ev);
                recommendationFlowLayout.Controls.Add(card);
            }
        }
    }
}
