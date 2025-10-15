namespace PROG3B_Task1
{
    partial class Form3
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
            label1 = new Label();
            cmbCategories = new ComboBox();
            dtpDateFilter = new DateTimePicker();
            eventFlowLayout = new FlowLayoutPanel();
            btnFilter = new Button();
            chkUseDateFilter = new CheckBox();
            btnReset = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 35);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 0;
            label1.Text = "Filter for a specific event";
            // 
            // cmbCategories
            // 
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(189, 32);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(121, 23);
            cmbCategories.TabIndex = 1;
            // 
            // dtpDateFilter
            // 
            dtpDateFilter.Location = new Point(389, 32);
            dtpDateFilter.Name = "dtpDateFilter";
            dtpDateFilter.Size = new Size(200, 23);
            dtpDateFilter.TabIndex = 2;
            // 
            // eventFlowLayout
            // 
            eventFlowLayout.AutoScroll = true;
            eventFlowLayout.Location = new Point(3, 154);
            eventFlowLayout.Name = "eventFlowLayout";
            eventFlowLayout.Size = new Size(804, 296);
            eventFlowLayout.TabIndex = 3;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(664, 32);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 4;
            btnFilter.Text = "filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // chkUseDateFilter
            // 
            chkUseDateFilter.AutoSize = true;
            chkUseDateFilter.Location = new Point(190, 94);
            chkUseDateFilter.Name = "chkUseDateFilter";
            chkUseDateFilter.Size = new Size(70, 19);
            chkUseDateFilter.TabIndex = 5;
            chkUseDateFilter.Text = "use date";
            chkUseDateFilter.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(664, 109);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 6;
            btnReset.Text = "reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 450);
            Controls.Add(btnReset);
            Controls.Add(chkUseDateFilter);
            Controls.Add(btnFilter);
            Controls.Add(eventFlowLayout);
            Controls.Add(dtpDateFilter);
            Controls.Add(cmbCategories);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbCategories;
        private DateTimePicker dtpDateFilter;
        private FlowLayoutPanel eventFlowLayout;
        private Button btnFilter;
        private CheckBox chkUseDateFilter;
        private Button btnReset;
    }
}