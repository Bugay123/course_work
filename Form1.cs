using CourseWorkLibrary.Model;
using CourseWorkLibrary.Repo;

namespace CourseWorkLibrary
{
    public partial class Form1 : Form
    {

        private static WorkContext _context = new WorkContext();
        private static WorkRepository _workRepository;

        public Form1()
        {
            InitializeComponent();
            _workRepository = new WorkRepository(_context);
            using (var context = new WorkContext())
            {
                context.Database.EnsureCreated();
            }
        }

        public void RefreshWorksDataGrid()
        {
            YearFindComboBox();
            SurnameFindComboBox();
            SupervisorFindComboBox();

            var works = _workRepository.GetAllWorks();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = works;
            dataGridView1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshWorksDataGrid();
        }

        //add, delete, edit work
        private void addCourseButton_Click(object sender, EventArgs e)
        {
            var addCourseForm = new AddWorkForm(this);
            addCourseForm.ShowDialog();
        }
        private void deleteWorkButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int workId = (int)selectedRow.Cells["Id"].Value;

                _workRepository.DeleteWork(workId);

                RefreshWorksDataGrid();
            }
            else
            {
                MessageBox.Show("Не вибрано жодного рядка. Виберіть рядок для видалення.");
            }
        }
        private void editWorkButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int workId = (int)selectedRow.Cells["Id"].Value;

                Work work = _workRepository.GetWork(workId);

                var editWorkForm = new AddWorkForm(this, work);
                if (editWorkForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshWorksDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Не вибрано жодного рядка. Виберіть рядок для видалення.");
            }
        }

        //filling comboboxes
        private void YearFindComboBox()
        {
            var years = _workRepository.GetUniqueYearsOfDefense();
            uniqYearComboBox.Items.Clear();
            foreach (var year in years)
            {
                uniqYearComboBox.Items.Add(year);
            }
        }
        private void SurnameFindComboBox()
        {
            var surnames = _workRepository.GetUniqueSurname();
            uniqSurnameComboBox.Items.Clear();
            foreach (var surname in surnames)
            {
                uniqSurnameComboBox.Items.Add(surname);
            }
        }
        private void SupervisorFindComboBox()
        {
            var supervisors = _workRepository.GetUniqueSupervisor();
            uniqSupervisorComboBox.Items.Clear();
            foreach (var supervisor in supervisors)
            {
                uniqSupervisorComboBox.Items.Add(supervisor);
            }
        }

        //find by year, student, supervisor
        private void findWorkByYear_Click(object sender, EventArgs e)
        {
            if (uniqYearComboBox.SelectedItem != null)
            {
                int year = (int)uniqYearComboBox.SelectedItem;
                dataGridView1.DataSource = _workRepository.GetWorksByYear(year);
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Не вибрано жодного року. Виберіть рік для пошуку.");
            }
        }
        private void findByStudent_Click(object sender, EventArgs e)
        {
            string lastName = uniqSurnameComboBox.Text;
            if (!string.IsNullOrEmpty(lastName))
            {
                dataGridView1.DataSource = _workRepository.GetWorksByStudentLastName(lastName);
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Не введено прізвище студента. Введіть прізвище для пошуку.");
            }
        }
        private void findBySupervisorButton_Click(object sender, EventArgs e)
        {
            string supervisor = uniqSupervisorComboBox.Text;
            if (!string.IsNullOrEmpty(supervisor))
            {
                dataGridView1.DataSource = _workRepository.GetWorksBySupervisor(supervisor);
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Не введено прізвище викладача. Введіть прізвище для пошуку.");
            }
        }

        //sotring
        private void sortByABCRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sortByABCRadioButton.Checked)
            {
                var works = _workRepository.GetAllWorks().OrderBy(w => w.Topic).ToList();
                dataGridView1.DataSource = works;
                dataGridView1.Refresh();
            }
        }
        private void sortByCourseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sortByCourseRadioButton.Checked)
            {
                var works = _workRepository.GetAllWorks().Where(w => w.Type == "CourseWork").ToList();
                dataGridView1.DataSource = works;
                dataGridView1.Refresh();
            }
        }
        private void allWorksRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (allWorksRadioButton.Checked)
            {
                RefreshWorksDataGrid();
            }
        }

    }
}
