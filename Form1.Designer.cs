namespace CourseWorkLibrary
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            addCourseButton = new Button();
            editWorkButton = new Button();
            sortByABCRadioButton = new RadioButton();
            sortByCourseRadioButton = new RadioButton();
            allWorksRadioButton = new RadioButton();
            uniqYearComboBox = new ComboBox();
            uniqSurnameComboBox = new ComboBox();
            groupBox1 = new GroupBox();
            findWorkByYearButton = new Button();
            findByStudentButton = new Button();
            deleteWorkButton = new Button();
            groupBox2 = new GroupBox();
            findBySupervisorButton = new Button();
            uniqSupervisorComboBox = new ComboBox();
            dataGridView1 = new DataGridView();
            workContextBindingSource = new BindingSource(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)workContextBindingSource).BeginInit();
            SuspendLayout();
            // 
            // addCourseButton
            // 
            addCourseButton.Location = new Point(15, 15);
            addCourseButton.Name = "addCourseButton";
            addCourseButton.Size = new Size(120, 25);
            addCourseButton.TabIndex = 0;
            addCourseButton.Text = "додати роботу";
            addCourseButton.UseVisualStyleBackColor = true;
            addCourseButton.Click += addCourseButton_Click;
            // 
            // editWorkButton
            // 
            editWorkButton.Location = new Point(150, 15);
            editWorkButton.Name = "editWorkButton";
            editWorkButton.Size = new Size(120, 25);
            editWorkButton.TabIndex = 2;
            editWorkButton.Text = "редагувати роботу";
            editWorkButton.UseVisualStyleBackColor = true;
            editWorkButton.Click += editWorkButton_Click;
            // 
            // sortByABCRadioButton
            // 
            sortByABCRadioButton.AutoSize = true;
            sortByABCRadioButton.Location = new Point(10, 20);
            sortByABCRadioButton.Name = "sortByABCRadioButton";
            sortByABCRadioButton.Size = new Size(162, 19);
            sortByABCRadioButton.TabIndex = 4;
            sortByABCRadioButton.TabStop = true;
            sortByABCRadioButton.Text = "перегляд тем за абеткою";
            sortByABCRadioButton.UseVisualStyleBackColor = true;
            sortByABCRadioButton.CheckedChanged += sortByABCRadioButton_CheckedChanged;
            // 
            // sortByCourseRadioButton
            // 
            sortByCourseRadioButton.AutoSize = true;
            sortByCourseRadioButton.Location = new Point(10, 45);
            sortByCourseRadioButton.Name = "sortByCourseRadioButton";
            sortByCourseRadioButton.Size = new Size(146, 19);
            sortByCourseRadioButton.TabIndex = 5;
            sortByCourseRadioButton.TabStop = true;
            sortByCourseRadioButton.Text = "тільки курсові роботи";
            sortByCourseRadioButton.UseVisualStyleBackColor = true;
            sortByCourseRadioButton.CheckedChanged += sortByCourseRadioButton_CheckedChanged;
            // 
            // allWorksRadioButton
            // 
            allWorksRadioButton.AutoSize = true;
            allWorksRadioButton.Location = new Point(10, 70);
            allWorksRadioButton.Name = "allWorksRadioButton";
            allWorksRadioButton.Size = new Size(83, 19);
            allWorksRadioButton.TabIndex = 6;
            allWorksRadioButton.TabStop = true;
            allWorksRadioButton.Text = "всі роботи";
            allWorksRadioButton.UseVisualStyleBackColor = true;
            allWorksRadioButton.CheckedChanged += allWorksRadioButton_CheckedChanged;
            // 
            // uniqYearComboBox
            // 
            uniqYearComboBox.FormattingEnabled = true;
            uniqYearComboBox.Location = new Point(10, 20);
            uniqYearComboBox.Name = "uniqYearComboBox";
            uniqYearComboBox.Size = new Size(100, 23);
            uniqYearComboBox.TabIndex = 8;
            // 
            // uniqSurnameComboBox
            // 
            uniqSurnameComboBox.FormattingEnabled = true;
            uniqSurnameComboBox.Location = new Point(10, 50);
            uniqSurnameComboBox.Name = "uniqSurnameComboBox";
            uniqSurnameComboBox.Size = new Size(100, 23);
            uniqSurnameComboBox.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(allWorksRadioButton);
            groupBox1.Controls.Add(sortByABCRadioButton);
            groupBox1.Controls.Add(sortByCourseRadioButton);
            groupBox1.Location = new Point(15, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(175, 100);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Сортування";
            // 
            // findWorkByYearButton
            // 
            findWorkByYearButton.Location = new Point(120, 20);
            findWorkByYearButton.Name = "findWorkByYearButton";
            findWorkByYearButton.Size = new Size(145, 23);
            findWorkByYearButton.TabIndex = 10;
            findWorkByYearButton.Text = "За роком захисту";
            findWorkByYearButton.UseVisualStyleBackColor = true;
            findWorkByYearButton.Click += findWorkByYear_Click;
            // 
            // findByStudentButton
            // 
            findByStudentButton.Location = new Point(120, 50);
            findByStudentButton.Name = "findByStudentButton";
            findByStudentButton.Size = new Size(145, 23);
            findByStudentButton.TabIndex = 11;
            findByStudentButton.Text = "За студентом";
            findByStudentButton.UseVisualStyleBackColor = true;
            findByStudentButton.Click += findByStudent_Click;
            // 
            // deleteWorkButton
            // 
            deleteWorkButton.Location = new Point(15, 290);
            deleteWorkButton.Name = "deleteWorkButton";
            deleteWorkButton.Size = new Size(120, 23);
            deleteWorkButton.TabIndex = 11;
            deleteWorkButton.Text = "видалити роботу";
            deleteWorkButton.UseVisualStyleBackColor = true;
            deleteWorkButton.Click += deleteWorkButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(findBySupervisorButton);
            groupBox2.Controls.Add(uniqSupervisorComboBox);
            groupBox2.Controls.Add(findByStudentButton);
            groupBox2.Controls.Add(uniqYearComboBox);
            groupBox2.Controls.Add(uniqSurnameComboBox);
            groupBox2.Controls.Add(findWorkByYearButton);
            groupBox2.Location = new Point(15, 160);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(270, 115);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Пошук";
            // 
            // findBySupervisorButton
            // 
            findBySupervisorButton.Location = new Point(120, 80);
            findBySupervisorButton.Name = "findBySupervisorButton";
            findBySupervisorButton.Size = new Size(145, 23);
            findBySupervisorButton.TabIndex = 13;
            findBySupervisorButton.Text = "За керівником";
            findBySupervisorButton.UseVisualStyleBackColor = true;
            findBySupervisorButton.Click += findBySupervisorButton_Click;
            // 
            // uniqSupervisorComboBox
            // 
            uniqSupervisorComboBox.FormattingEnabled = true;
            uniqSupervisorComboBox.Location = new Point(10, 80);
            uniqSupervisorComboBox.Name = "uniqSupervisorComboBox";
            uniqSupervisorComboBox.Size = new Size(100, 23);
            uniqSupervisorComboBox.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(290, 15);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(490, 300);
            dataGridView1.TabIndex = 13;
            // 
            // workContextBindingSource
            // 
            workContextBindingSource.DataSource = typeof(Repo.WorkContext);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 341);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(deleteWorkButton);
            Controls.Add(groupBox1);
            Controls.Add(editWorkButton);
            Controls.Add(addCourseButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Course Work";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)workContextBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button addCourseButton;
        private Button editWorkButton;
        private RadioButton sortByABCRadioButton;
        private RadioButton sortByCourseRadioButton;
        private RadioButton allWorksRadioButton;
        private ComboBox uniqYearComboBox;
        private ComboBox uniqSurnameComboBox;
        private GroupBox groupBox1;
        private Button findByStudentButton;
        private Button findWorkByYearButton;
        private Button deleteWorkButton;
        private GroupBox groupBox2;
        private Button findBySupervisorButton;
        private ComboBox uniqSupervisorComboBox;
        private BindingSource workContextBindingSource;
        private DataGridView dataGridView1;
    }
}
