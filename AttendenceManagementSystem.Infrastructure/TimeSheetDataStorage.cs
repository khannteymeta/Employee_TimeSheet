/*using System.Text.Json;
using AttendenceManagementSystem.Application;
namespace AttendenceManagementSystem.Infrastructure;
public class TimeSheetDataStorage
{
    public static void SaveTimeSheetToStorage(FileTimeSheet AttenList)
    {
        var JsonString = JsonSerializer.Serialize<FileTimeSheet>(AttenList);
        File.WriteAllText("timesheet.json", JsonString);

    }
    public static FileTimeSheet LoadTimeSheetFromStorage()
    {
        //open for read...
        using FileStream stream = File.Open("timesheet.json", FileMode.OpenOrCreate);
        if (stream.Length > 0)
        {
            var loadList = JsonSerializer.Deserialize<FileTimeSheet>(stream);
            return loadList!;
        }
        return new FileTimeSheet();
    }
}

*/

using System.Text.Json;
using AttendenceManagementSystem.Application;

namespace AttendenceManagementSystem.Infrastructure
{
    public class TimeSheetDataStorage
    {
        public static void SaveTimeSheetToString(FileTimeSheet AttenList)
        {
            var jsonString = JsonSerializer.Serialize<FileTimeSheet>(AttenList);
            File.WriteAllText("timesheet.json", jsonString);
        }
        public static FileTimeSheet LoadTimeSheetFromStorage()
        {
            //Open for read data, if not exist create timsheet.json file
            using FileStream stream = File.Open("timesheet.json", FileMode.OpenOrCreate);
            if (stream.Length > 0)
            {
                var loadlist = JsonSerializer.Deserialize<FileTimeSheet>(stream);
                return loadlist!;
            }
            return new FileTimeSheet();
        }
    }
}

