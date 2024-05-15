namespace course_work
{
    partial class AddWorkForm
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
            IdLabel = new Label();
            typeLabel = new Label();
            disciplineLabel = new Label();
            topicLabel = new Label();
            studentNameLabel = new Label();
            SupervisorNameLabel = new Label();
            GroupLabel = new Label();
            yearOfDefenseLabel = new Label();
            gradeLabel = new Label();
            idTextBox = new TextBox();
            typeComboBox = new ComboBox();
            disciplineTextBox = new TextBox();
            topicTextBox = new TextBox();
            studentNameTextBox = new TextBox();
            supervisorNameTextBox = new TextBox();
            groupTextBox = new TextBox();
            saveButton = new Button();
            gradeComboBox = new ComboBox();
            yearOfDefenseComboBox = new ComboBox();
            SuspendLayout();
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(20, 20);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(18, 15);
            IdLabel.TabIndex = 0;
            IdLabel.Text = "ID";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(20, 50);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(31, 15);
            typeLabel.TabIndex = 20;
            typeLabel.Text = "Type";
            // 
            // disciplineLabel
            // 
            disciplineLabel.AutoSize = true;
            disciplineLabel.Location = new Point(20, 80);
            disciplineLabel.Name = "disciplineLabel";
            disciplineLabel.Size = new Size(58, 15);
            disciplineLabel.TabIndex = 2;
            disciplineLabel.Text = "Discipline";
            // 
            // topicLabel
            // 
            topicLabel.AutoSize = true;
            topicLabel.Location = new Point(20, 110);
            topicLabel.Name = "topicLabel";
            topicLabel.Size = new Size(35, 15);
            topicLabel.TabIndex = 3;
            topicLabel.Text = "Topic";
            // 
            // studentNameLabel
            // 
            studentNameLabel.AutoSize = true;
            studentNameLabel.Location = new Point(20, 140);
            studentNameLabel.Name = "studentNameLabel";
            studentNameLabel.Size = new Size(83, 15);
            studentNameLabel.TabIndex = 4;
            studentNameLabel.Text = "Student Name";
            // 
            // SupervisorNameLabel
            // 
            SupervisorNameLabel.AutoSize = true;
            SupervisorNameLabel.Location = new Point(20, 170);
            SupervisorNameLabel.Name = "SupervisorNameLabel";
            SupervisorNameLabel.Size = new Size(97, 15);
            SupervisorNameLabel.TabIndex = 5;
            SupervisorNameLabel.Text = "Supervisor Name";
            // 
            // GroupLabel
            // 
            GroupLabel.AutoSize = true;
            GroupLabel.Location = new Point(20, 200);
            GroupLabel.Name = "GroupLabel";
            GroupLabel.Size = new Size(40, 15);
            GroupLabel.TabIndex = 6;
            GroupLabel.Text = "Group";
            // 
            // yearOfDefenseLabel
            // 
            yearOfDefenseLabel.AutoSize = true;
            yearOfDefenseLabel.Location = new Point(20, 230);
            yearOfDefenseLabel.Name = "yearOfDefenseLabel";
            yearOfDefenseLabel.Size = new Size(90, 15);
            yearOfDefenseLabel.TabIndex = 7;
            yearOfDefenseLabel.Text = "Year Of Defense";
            // 
            // gradeLabel
            // 
            gradeLabel.AutoSize = true;
            gradeLabel.Location = new Point(20, 260);
            gradeLabel.Name = "gradeLabel";
            gradeLabel.Size = new Size(38, 15);
            gradeLabel.TabIndex = 8;
            gradeLabel.Text = "Grade";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(130, 20);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(100, 23);
            idTextBox.TabIndex = 9;
            // 
            // typeComboBox
            // 
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Items.AddRange(new object[] { "CourseWork", "Bachelor", "Master" });
            typeComboBox.Location = new Point(130, 50);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(100, 23);
            typeComboBox.TabIndex = 21;
            typeComboBox.Text = "CourseWork";
            // 
            // disciplineTextBox
            // 
            disciplineTextBox.Location = new Point(130, 80);
            disciplineTextBox.Name = "disciplineTextBox";
            disciplineTextBox.Size = new Size(100, 23);
            disciplineTextBox.TabIndex = 11;
            // 
            // topicTextBox
            // 
            topicTextBox.Location = new Point(130, 110);
            topicTextBox.Name = "topicTextBox";
            topicTextBox.Size = new Size(100, 23);
            topicTextBox.TabIndex = 12;
            // 
            // studentNameTextBox
            // 
            studentNameTextBox.Location = new Point(130, 140);
            studentNameTextBox.Name = "studentNameTextBox";
            studentNameTextBox.Size = new Size(100, 23);
            studentNameTextBox.TabIndex = 13;
            // 
            // supervisorNameTextBox
            // 
            supervisorNameTextBox.Location = new Point(130, 170);
            supervisorNameTextBox.Name = "supervisorNameTextBox";
            supervisorNameTextBox.Size = new Size(100, 23);
            supervisorNameTextBox.TabIndex = 14;
            // 
            // groupTextBox
            // 
            groupTextBox.Location = new Point(130, 200);
            groupTextBox.Name = "groupTextBox";
            groupTextBox.Size = new Size(100, 23);
            groupTextBox.TabIndex = 15;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(90, 300);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 18;
            saveButton.Text = "Зберегти";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // gradeComboBox
            // 
            gradeComboBox.FormattingEnabled = true;
            gradeComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            gradeComboBox.Location = new Point(130, 260);
            gradeComboBox.Name = "gradeComboBox";
            gradeComboBox.Size = new Size(100, 23);
            gradeComboBox.TabIndex = 19;
            gradeComboBox.Text = "1";
            // 
            // yearOfDefenseComboBox
            // 
            yearOfDefenseComboBox.FormattingEnabled = true;
            yearOfDefenseComboBox.Items.AddRange(new object[] { "2020", "2021", "2022", "2023", "2024" });
            yearOfDefenseComboBox.Location = new Point(130, 230);
            yearOfDefenseComboBox.Name = "yearOfDefenseComboBox";
            yearOfDefenseComboBox.Size = new Size(100, 23);
            yearOfDefenseComboBox.TabIndex = 22;
            yearOfDefenseComboBox.Text = "2020";
            // 
            // AddWorkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 341);
            Controls.Add(yearOfDefenseComboBox);
            Controls.Add(typeComboBox);
            Controls.Add(typeLabel);
            Controls.Add(gradeComboBox);
            Controls.Add(saveButton);
            Controls.Add(groupTextBox);
            Controls.Add(supervisorNameTextBox);
            Controls.Add(studentNameTextBox);
            Controls.Add(topicTextBox);
            Controls.Add(disciplineTextBox);
            Controls.Add(idTextBox);
            Controls.Add(gradeLabel);
            Controls.Add(yearOfDefenseLabel);
            Controls.Add(GroupLabel);
            Controls.Add(SupervisorNameLabel);
            Controls.Add(studentNameLabel);
            Controls.Add(topicLabel);
            Controls.Add(disciplineLabel);
            Controls.Add(IdLabel);
            Name = "AddWorkForm";
            Text = "Add Work";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IdLabel;
        private Label disciplineLabel;
        private Label topicLabel;
        private Label studentNameLabel;
        private Label SupervisorNameLabel;
        private Label GroupLabel;
        private Label yearOfDefenseLabel;
        private Label gradeLabel;
        private TextBox idTextBox;
        private TextBox disciplineTextBox;
        private TextBox topicTextBox;
        private TextBox studentNameTextBox;
        private TextBox supervisorNameTextBox;
        private TextBox groupTextBox;
        private Button saveButton;
        private ComboBox gradeComboBox;
        private Label typeLabel;
        private ComboBox typeComboBox;
        private ComboBox yearOfDefenseComboBox;
    }
}