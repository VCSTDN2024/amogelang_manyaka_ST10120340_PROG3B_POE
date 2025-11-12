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
    public partial class Form4 : Form
    {
        private ServiceRequestBST bst = new ServiceRequestBST();
        private Minheap minheap = new Minheap();
        public Form4()
        {
            InitializeComponent();

            cmbStatus.Items.AddRange(new string[] { "Pending", "In Progress", "Completed" });
            cmbPriority.Items.AddRange(new string[] { "High", "Medium", "Low" });
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string title = txtTitle.Text;
            string status = cmbStatus.SelectedItem.ToString();
            int priority = cmbPriority.SelectedIndex switch
            {
                0 => 1,
                1 => 2,
                2 => 3,
                _ => 2
            };

            var request = new ServiceRequest(id, title, status, priority);
            bst.Insert(request);
            minheap.Insert(request);

            RefreshGrid();

        }

        private void DisplayRequests()
        {
            dgvRequest.DataSource = null;
            dgvRequest.DataSource = bst.InOrder()
                .Select(x => new
                {
                    x.RequestId,
                    x.Title,
                    x.Status,
                    CreatedAt = x.CreatedAt.ToString("yyyy-MM-dd HH:mm:ss")
                })
                .ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearchId.Text, out int id))
            {
                var req = bst.Search(id);
                if (req != null)
                {
                    MessageBox.Show($"Request Found:\n\nID: {req.RequestId}\nTitle: {req.Title}\nStatus: {req.Status}");
                }
                else
                {
                    MessageBox.Show("No request found with that ID.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Request ID.");
            }
        }

        private void ClearInputs()
        {
            txtId.Clear();
            txtTitle.Clear();
            cmbStatus.SelectedIndex = 0;
        }

        private void btnNextPriority_Click(object sender, EventArgs e)
        {
            var next = minheap.ExtractMin();
            if (next == null)
                MessageBox.Show("No requests remaining.");
            else
                MessageBox.Show($"Next request to handle:\n{next}");
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dgvRequest.DataSource = bst.InOrder()
                .OrderBy(r => r.Priority)
                .Select(r => new
                {
                    r.RequestId,
                    r.Title,
                    r.Status,
                    Priority = r.Priority == 1 ? "High" :
                               r.Priority == 2 ? "Medium" : "Low",
                    r.CreatedAt
                })
                .ToList();
        }

        private void dgvRequest_RowRePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var row = dgvRequest.Rows[e.RowIndex];
            string priority = row.Cells["Priority"].Value?.ToString();

            switch (priority)
            {
                case "High":
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                    row.DefaultCellStyle.ForeColor = Color.White;
                    break;
                case "Medium":
                    row.DefaultCellStyle.BackColor = Color.Khaki;
                    break;
                case "Low":
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                    break;
            }
        }
    }
}

