using AttendenceManagementSystem.Application;
using AttendenceManagementSystem.Infrastructure;

namespace AttendanceManagementSystem.Presentation
{
    public partial class MainForm : Form
    {
        private ITimeSheet _timeSheet;

        public MainForm(ITimeSheet timeSheet)
        {
            InitializeComponent();
            _timeSheet = timeSheet;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timeRecordButton_Click(object sender, EventArgs e)
        {

            ClockManagement cfrm = new ClockManagement(_timeSheet);
            cfrm.ShowDialog();
        }

        private void manageEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeForm form = new EmployeeForm(_timeSheet);
            form.ShowDialog();
        }

        private void MainForm_Load(object sender, FormClosingEventArgs e)
        {
            TimeSheetDataStorage.SaveTimeSheetToString((FileTimeSheet)_timeSheet);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TimeSheetDataStorage.SaveTimeSheetToString((FileTimeSheet)_timeSheet);
        }
    }
}
