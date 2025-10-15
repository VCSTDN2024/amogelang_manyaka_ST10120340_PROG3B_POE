namespace PROG3B_Task1
{
    partial class Eventcard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblCategories = new Label();
            lblDate = new Label();
            lblDescription = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTitle.Location = new Point(14, 43);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(32, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            lblTitle.Click += label1_Click;
            // 
            // lblCategories
            // 
            lblCategories.AutoSize = true;
            lblCategories.Location = new Point(562, 43);
            lblCategories.Name = "lblCategories";
            lblCategories.Size = new Size(55, 15);
            lblCategories.TabIndex = 1;
            lblCategories.Text = "Category";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(728, 43);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(31, 15);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(153, 43);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description";
            lblDescription.Click += label4_Click;
            // 
            // Eventcard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(192, 255, 255);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblDescription);
            Controls.Add(lblDate);
            Controls.Add(lblCategories);
            Controls.Add(lblTitle);
            Name = "Eventcard";
            Size = new Size(826, 89);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCategories;
        private Label lblDate;
        private Label lblDescription;
    }
}
