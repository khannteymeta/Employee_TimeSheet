using AttendenceManagementSystem.Application;
using AttendenceManagementSystem.Domain.Entity;

namespace AttendanceManagementSystem.Presentation
{
    public partial class EmployeeForm : Form
    {


        private ITimeSheet _timeSheet;
        public EmployeeForm(ITimeSheet timeSheet)
        {
            InitializeComponent();
            _timeSheet = timeSheet;
            LoadToGrid(true);
            updateButton.Enabled = false;
            saveButton.Enabled = false;
            deleteButton.Enabled = false;
        }

        public EmployeeForm() { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void LoadToGrid()
        {
            dataGridView1.DataSource = _timeSheet.GetAllEmployee();
            dataGridView1.Refresh();
        }
        private void LoadToGrid(bool isSimpleVersion)
        {
            dataGridView1.DataSource = _timeSheet.GetAllEmployee(isSimpleVersion);
            dataGridView1.Refresh();
        }

        private void addnewButton_Click(object sender, EventArgs e)
        {
            fullnameTextBox.Clear();
            positionTextBox.Clear();
            cardnoTextBox.Clear();
            fullnameTextBox.Focus();
            saveButton.Enabled = true;
            deleteButton.Enabled = false;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var emp = new Employee(
                    fullnameTextBox.Text.Trim(),
                    positionTextBox.Text.Trim(),
                    cardnoTextBox.Text.Trim()
                    );
                _timeSheet.AddEmployee(emp);
                LoadToGrid();
            }
            catch (ArgumentException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
            finally
            {
                addnewButton.Enabled = true;
                saveButton.Enabled = false;
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                _timeSheet.UpdateEmployee(employeeIDTextBox.Text, fullnameTextBox.Text, positionTextBox.Text);
                LoadToGrid();
            }
            catch (ArgumentException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
            finally
            {
                addnewButton.Enabled = true;
                saveButton.Enabled = false;
                updateButton.Enabled = false;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
            {
                employeeIDTextBox.Text = dataGridView1.SelectedCells[0].Value.ToString();
                fullnameTextBox.Text = dataGridView1.SelectedCells[1].Value.ToString();
                positionTextBox.Text = dataGridView1.SelectedCells[2].Value.ToString();
                cardnoTextBox.Text = dataGridView1.SelectedCells[3].Value.ToString();
                addnewButton.Enabled = false;
                saveButton.Enabled = false;
                updateButton.Enabled = true;
                deleteButton.Enabled = true;
            }
        }


        private void deleteButton_Click1(object sender, EventArgs e)
        {
            try
            {
                _timeSheet.DeleteEmployee(employeeIDTextBox.Text);
                LoadToGrid();
            }
            catch (ArgumentException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
            finally
            {
                addnewButton.Enabled = true;
                saveButton.Enabled = false;
                updateButton.Enabled = false;
                deleteButton.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
            {
                employeeIDTextBox.Text = dataGridView1.SelectedCells[0].Value.ToString();
                fullnameTextBox.Text = dataGridView1.SelectedCells[1].Value.ToString();
                positionTextBox.Text = dataGridView1.SelectedCells[2].Value.ToString();
                cardnoTextBox.Text = dataGridView1.SelectedCells[3].Value.ToString();
                addnewButton.Enabled = false;
                saveButton.Enabled = false;
                updateButton.Enabled = true;
            }
        }

       
    }
}