using CourseWorkLibrary.Model;
using CourseWorkLibrary.Repo;

namespace CourseWorkLibrary
{
    public partial class AddWorkForm : Form
    {
        private static WorkContext _context = new WorkContext();
        private static WorkRepository _workRepository;
        private Form1 _mainForm;


        public AddWorkForm(Form1 mainForm)
        {
            InitializeComponent();
            _workRepository = new WorkRepository(_context);
            _mainForm = mainForm;
        }

        public AddWorkForm(Form1 mainForm, Work work) : this(mainForm)
        {
            idTextBox.Text = work.Id.ToString();
            typeComboBox.Text = work.Type;
            disciplineTextBox.Text = work.Discipline;
            topicTextBox.Text = work.Topic;
            studentNameTextBox.Text = work.StudentName;
            supervisorNameTextBox.Text = work.SupervisorName;
            groupTextBox.Text = work.Group;
            yearOfDefenseComboBox.Text = work.YearOfDefense.ToString();
            gradeComboBox.Text = work.Grade.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var work = new Work
                {
                    Id = int.Parse(idTextBox.Text),
                    Type = typeComboBox.Text,
                    Discipline = disciplineTextBox.Text,
                    Topic = topicTextBox.Text,
                    StudentName = studentNameTextBox.Text,
                    SupervisorName = supervisorNameTextBox.Text,
                    Group = groupTextBox.Text,
                    YearOfDefense = int.Parse(yearOfDefenseComboBox.Text),
                    Grade = int.Parse(gradeComboBox.Text)
                };

                var existingWork = _workRepository.GetWork(work.Id);
                if (existingWork != null)
                {
                    _workRepository.EditWork(work);
                    MessageBox.Show("Роботу оновлено");
                }
                else
                {
                    _workRepository.AddWork(work);
                    MessageBox.Show("Роботу додано");
                }

                _mainForm.RefreshWorksDataGrid();
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, перевірте правильність введених даних.");
            }
        }

    }
}
