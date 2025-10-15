using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG3B_Task1
{
    public partial class Form2 : Form
    {

        private List<Report> reports = new List<Report>();

        private string selectedFilePath = string.Empty;


        public Form2()
        {
            InitializeComponent();


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.ShowDialog();

            this.Hide();
        }


        private void UpdateProgress()
        {
            int completed = 0;
            int total = 4;


            if (!string.IsNullOrWhiteSpace(locationTextBox.Text))
                completed++;

            if (categoryListBox.SelectedItem != null)
                completed++;

            if (!string.IsNullOrWhiteSpace(longDescriptionTextBox.Text))
                completed++;

            if (!string.IsNullOrWhiteSpace(selectedFilePath))
                completed++;

            progressBarReport.Minimum = 0;
            progressBarReport.Maximum = total;
            progressBarReport.Value = completed;


        }
        // Event handlers to track changes

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {

                ofd.Title = "Select Image or PDF";
                ofd.Filter = "Images and Documents|*.jpg;*.jpeg;*.png;*.bmp;*.pdf;*.doc;*.docx;*.txt";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePath = ofd.FileName;
                    UpdateProgress();
                    string extension = Path.GetExtension(selectedFilePath).ToLower();

                    MessageBox.Show($"Attached: {Path.GetFileName(selectedFilePath)}");

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(locationTextBox.Text))
            {

                MessageBox.Show("Please enter a location.");
                return;

            }

            if (categoryListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a category. ");
                return;
            }

            if (string.IsNullOrWhiteSpace(longDescriptionTextBox.Text))
            {
                MessageBox.Show("Please enter a description");
                return;
            }

            if (string.IsNullOrWhiteSpace(selectedFilePath))
            {
                MessageBox.Show("Please attach an image or document.");
                return;
            }

            Report report = new Report
            {
                Location = locationTextBox.Text,
                Category = categoryListBox.SelectedItem.ToString(),
                Description = longDescriptionTextBox.Text,
                FilePath = selectedFilePath,
                FileType = Path.GetExtension(selectedFilePath).ToLower()
            };

            reports.Add(report);

            MessageBox.Show($"Submitted entry for {report.Location} in {report.Category}");

            if (progressBarReport.Value < progressBarReport.Maximum)
            {
                progressBarReport.Value = reports.Count;
            }

            //reset form

            locationTextBox.Clear();
            categoryListBox.ClearSelected();
            longDescriptionTextBox.Clear();
            selectedFilePath = string.Empty;

        }

        private void locationTextBox_TextChanged(object sender, EventArgs e) => UpdateProgress();

        private void categoryListBox_SelectedIndexChanged(object sender, EventArgs e) => UpdateProgress();


        private void longDescriptionTextBox_TextChanged(object sender, EventArgs e) => UpdateProgress();

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
