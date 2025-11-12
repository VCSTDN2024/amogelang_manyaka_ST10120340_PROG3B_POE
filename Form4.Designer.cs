namespace PROG3B_Task1
{
    partial class Form4
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
            btnAdd = new Button();
            txtId = new TextBox();
            txtTitle = new TextBox();
            cmbStatus = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSearchId = new TextBox();
            label4 = new Label();
            dgvRequest = new DataGridView();
            btnSearch = new Button();
            Priority = new Label();
            cmbPriority = new ComboBox();
            btnNextPriority = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRequest).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(602, 103);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Request";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(134, 38);
            txtId.Name = "txtId";
            txtId.Size = new Size(124, 23);
            txtId.TabIndex = 1;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(403, 38);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(120, 23);
            txtTitle.TabIndex = 2;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(134, 103);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(124, 23);
            cmbStatus.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 38);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 4;
            label1.Text = "Request ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(329, 38);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 5;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 106);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 6;
            label3.Text = "Status";
            // 
            // txtSearchId
            // 
            txtSearchId.Location = new Point(137, 188);
            txtSearchId.Name = "txtSearchId";
            txtSearchId.Size = new Size(386, 23);
            txtSearchId.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 195);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 8;
            label4.Text = "Search by ID";
            // 
            // dgvRequest
            // 
            dgvRequest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequest.Location = new Point(138, 231);
            dgvRequest.Name = "dgvRequest";
            dgvRequest.Size = new Size(584, 207);
            dgvRequest.TabIndex = 9;
            dgvRequest.RowPrePaint += dgvRequest_RowRePaint;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(602, 191);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 23);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Priority
            // 
            Priority.AutoSize = true;
            Priority.Location = new Point(329, 107);
            Priority.Name = "Priority";
            Priority.Size = new Size(45, 15);
            Priority.TabIndex = 12;
            Priority.Text = "Priority";
            // 
            // cmbPriority
            // 
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(403, 103);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(124, 23);
            cmbPriority.TabIndex = 11;
            // 
            // btnNextPriority
            // 
            btnNextPriority.Location = new Point(602, 147);
            btnNextPriority.Name = "btnNextPriority";
            btnNextPriority.Size = new Size(120, 23);
            btnNextPriority.TabIndex = 13;
            btnNextPriority.Text = "Next Priority";
            btnNextPriority.UseVisualStyleBackColor = true;
            btnNextPriority.Click += btnNextPriority_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNextPriority);
            Controls.Add(Priority);
            Controls.Add(cmbPriority);
            Controls.Add(btnSearch);
            Controls.Add(dgvRequest);
            Controls.Add(label4);
            Controls.Add(txtSearchId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbStatus);
            Controls.Add(txtTitle);
            Controls.Add(txtId);
            Controls.Add(btnAdd);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRequest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox txtId;
        private TextBox txtTitle;
        private ComboBox cmbStatus;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSearchId;
        private Label label4;
        private DataGridView dgvRequest;
        private Button btnSearch;
        private Label Priority;
        private ComboBox cmbPriority;
        private Button btnNextPriority;
    }
}