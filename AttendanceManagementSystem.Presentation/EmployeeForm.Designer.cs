namespace AttendanceManagementSystem.Presentation
{
    partial class EmployeeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label1 = new Label();
            employeeIDTextBox = new TextBox();
            label2 = new Label();
            fullnameTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            positionTextBox = new TextBox();
            cardnoTextBox = new TextBox();
            addnewButton = new Button();
            saveButton = new Button();
            updateButton = new Button();
            dataGridView1 = new DataGridView();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(54, 60);
            Label1.Name = "Label1";
            Label1.Size = new Size(120, 23);
            Label1.TabIndex = 0;
            Label1.Text = "Employee ID : ";
            // 
            // employeeIDTextBox
            // 
            employeeIDTextBox.Location = new Point(204, 53);
            employeeIDTextBox.Name = "employeeIDTextBox";
            employeeIDTextBox.ReadOnly = true;
            employeeIDTextBox.Size = new Size(262, 30);
            employeeIDTextBox.TabIndex = 1;
            employeeIDTextBox.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 126);
            label2.Name = "label2";
            label2.Size = new Size(101, 23);
            label2.TabIndex = 2;
            label2.Text = "Full Name : ";
            // 
            // fullnameTextBox
            // 
            fullnameTextBox.Location = new Point(204, 123);
            fullnameTextBox.Name = "fullnameTextBox";
            fullnameTextBox.Size = new Size(262, 30);
            fullnameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 214);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 4;
            label3.Text = "Position : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 295);
            label4.Name = "label4";
            label4.Size = new Size(88, 23);
            label4.TabIndex = 5;
            label4.Text = "Card No : ";
            // 
            // positionTextBox
            // 
            positionTextBox.Location = new Point(204, 207);
            positionTextBox.Name = "positionTextBox";
            positionTextBox.Size = new Size(262, 30);
            positionTextBox.TabIndex = 6;
            // 
            // cardnoTextBox
            // 
            cardnoTextBox.Location = new Point(204, 292);
            cardnoTextBox.Name = "cardnoTextBox";
            cardnoTextBox.Size = new Size(262, 30);
            cardnoTextBox.TabIndex = 7;
            // 
            // addnewButton
            // 
            addnewButton.BackColor = SystemColors.ButtonHighlight;
            addnewButton.ForeColor = SystemColors.ActiveCaptionText;
            addnewButton.Location = new Point(37, 401);
            addnewButton.Name = "addnewButton";
            addnewButton.Size = new Size(98, 42);
            addnewButton.TabIndex = 8;
            addnewButton.Text = "Add New";
            addnewButton.UseVisualStyleBackColor = false;
            addnewButton.Click += addnewButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = SystemColors.ButtonHighlight;
            saveButton.Location = new Point(166, 401);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(71, 42);
            saveButton.TabIndex = 9;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(261, 401);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(78, 42);
            updateButton.TabIndex = 10;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(559, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 57;
            dataGridView1.Size = new Size(432, 356);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(368, 402);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(98, 41);
            deleteButton.TabIndex = 12;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click1;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 494);
            Controls.Add(deleteButton);
            Controls.Add(dataGridView1);
            Controls.Add(updateButton);
            Controls.Add(saveButton);
            Controls.Add(addnewButton);
            Controls.Add(cardnoTextBox);
            Controls.Add(positionTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(fullnameTextBox);
            Controls.Add(label2);
            Controls.Add(employeeIDTextBox);
            Controls.Add(Label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label1;
        private TextBox employeeIDTextBox;
        private Label label2;
        private TextBox fullnameTextBox;
        private Label label3;
        private Label label4;
        private TextBox positionTextBox;
        private TextBox cardnoTextBox;
        private Button addnewButton;
        private Button saveButton;
        private Button updateButton;
        private DataGridView dataGridView1;
        private Button deleteButton;
    }
}
