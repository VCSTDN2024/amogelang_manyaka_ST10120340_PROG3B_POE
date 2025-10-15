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
    public partial class Eventcard : UserControl
    {
        public Eventcard(Event ev)
        {
            InitializeComponent();

            lblTitle.Text = ev.Title;
            lblDescription.Text = ev.Description;
            lblCategories.Text = string.Join(", ", ev.Categories);
            lblDate.Text = ev.Date.ToString("dd MMM yyyy"); 

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
