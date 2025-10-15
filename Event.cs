using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG3B_Task1
{
    public class Event
    {
        public string Title { get; set; }

        public HashSet<string> Categories { get; set; } = new HashSet<string>();
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
