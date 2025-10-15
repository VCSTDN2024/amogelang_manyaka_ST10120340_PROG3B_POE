using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG3B_Task1
{
    public partial class Form3 : Form
    {
        private EventManager eventManager = new EventManager();

        public Form3()
        {
            InitializeComponent();
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
                Description = "Community members are invited to meet with councillors on this day.",
                Categories = new HashSet<string> { "Community", "Political" },
                Date = DateTime.Now.AddDays(5),
            };

            var event3 = new Event
            {
                Title = "Neighborhood Clean-Up Day",
                Description = "Join your neighbors in beautifying our community parks and streets.",
                Categories = new HashSet<string> { "Community", "Volunteer" },
                Date = DateTime.Now.AddDays(7),
            };

            var event4 = new Event
            {
                Title = "Public Safety Workshop",
                Description = "Learn about emergency preparedness and community safety resources.",
                Categories = new HashSet<string> { "Education", "Safety" },
                Date = DateTime.Now.AddDays(12),
            };

            eventManager.AddEvent(event1);
            eventManager.AddEvent(event2);
            eventManager.AddEvent(event3);
            eventManager.AddEvent(event4);

            cmbCategories.Items.AddRange(eventManager.Categories.ToArray());

        }

        private void DisplayEvents(IEnumerable<Event> events)
        {
            eventFlowLayout.Controls.Clear();
            foreach (var ev in events)
            {
                var eventCard = new Eventcard(ev);
                eventFlowLayout.Controls.Add(eventCard);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string selectedCategory = cmbCategories.SelectedItem?.ToString();
            DateTime? selectedDate = chkUseDateFilter.Checked ? dtpDateFilter.Value.Date : (DateTime?)null;

            // Use the combined filter method
            var filteredEvents = eventManager.FilterEvents(selectedCategory, selectedDate);

            DisplayEvents(filteredEvents);
        }


        private void Form3_Load_1(object sender, EventArgs e)
        {
            LoadSampleEvents();
            DisplayEvents(eventManager.GetAllEvents());
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbCategories.SelectedIndex = -1;
            chkUseDateFilter.Checked = false;
            DisplayEvents(eventManager.GetAllEvents());
        }
    }
}
