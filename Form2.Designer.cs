namespace PROG3B_Task1
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            locationTextBox = new TextBox();
            label1 = new Label();
            categoryListBox = new ListBox();
            label2 = new Label();
            longDescriptionTextBox = new RichTextBox();
            label3 = new Label();
            progressBarReport = new ProgressBar();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // locationTextBox
            // 
            locationTextBox.Location = new Point(329, 54);
            locationTextBox.Name = "locationTextBox";
            locationTextBox.Size = new Size(183, 23);
            locationTextBox.TabIndex = 0;
            locationTextBox.TextChanged += locationTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 54);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 1;
            label1.Text = "Location";
            // 
            // categoryListBox
            // 
            categoryListBox.FormattingEnabled = true;
            categoryListBox.ItemHeight = 15;
            categoryListBox.Items.AddRange(new object[] { "Sanitation", "Roads", "Utilities", "Service Delivery" });
            categoryListBox.Location = new Point(329, 107);
            categoryListBox.Name = "categoryListBox";
            categoryListBox.Size = new Size(120, 94);
            categoryListBox.TabIndex = 2;
            categoryListBox.SelectedIndexChanged += categoryListBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 107);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 3;
            label2.Text = "Category";
            // 
            // longDescriptionTextBox
            // 
            longDescriptionTextBox.Location = new Point(329, 229);
            longDescriptionTextBox.Name = "longDescriptionTextBox";
            longDescriptionTextBox.Size = new Size(324, 169);
            longDescriptionTextBox.TabIndex = 4;
            longDescriptionTextBox.Text = "";
            longDescriptionTextBox.TextChanged += longDescriptionTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(208, 229);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 5;
            label3.Text = "Long Description";
            // 
            // progressBarReport
            // 
            progressBarReport.Location = new Point(208, 29);
            progressBarReport.Name = "progressBarReport";
            progressBarReport.Size = new Size(445, 10);
            progressBarReport.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(208, 435);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 7;
            label4.Text = "Add File";
            // 
            // button1
            // 
            button1.Location = new Point(361, 431);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Select File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(578, 514);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(20, 16);
            button3.Name = "button3";
            button3.Size = new Size(124, 23);
            button3.TabIndex = 11;
            button3.Text = "Back to Main Menu";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(210, 9);
            label5.Name = "label5";
            label5.Size = new Size(161, 15);
            label5.TabIndex = 12;
            label5.Text = "Enter the report details below";
            label5.Click += label5_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 549);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(progressBarReport);
            Controls.Add(label3);
            Controls.Add(longDescriptionTextBox);
            Controls.Add(label2);
            Controls.Add(categoryListBox);
            Controls.Add(label1);
            Controls.Add(locationTextBox);
            Name = "Form2";
            Text = "Report Issues";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox locationTextBox;
        private Label label1;
        private ListBox categoryListBox;
        private Label label2;
        private RichTextBox longDescriptionTextBox;
        private Label label3;
        private ProgressBar progressBarReport;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label5;
    }
}