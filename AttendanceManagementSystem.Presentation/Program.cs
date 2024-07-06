using AttendenceManagementSystem.Domain.Entity;
using AttendenceManagementSystem.Application;
using AttendenceManagementSystem.Infrastructure;
namespace AttendanceManagementSystem.Presentation
{
    public static class Program
    { 
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            ApplicationConfiguration.Initialize();

            // create FileTimeSheetc object
            var AppTimeSheet = new FileTimeSheet();

            //load the timeSheet data from timesheet.json
            AppTimeSheet = TimeSheetDataStorage.LoadTimeSheetFromStorage();

            System.Windows.Forms.Application.Run(new MainForm(AppTimeSheet));

            Application.Run(new EmployeeForm());
        }
    }
}