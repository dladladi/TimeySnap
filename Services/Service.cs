using System;
using System.Diagnostics;
using System.IO;


namespace TimeySnap.Services;

public class Service
{
    public void TakeScreenShot(string path) // Take SS
    {
        var grim = new Process();
        var startInfo = new ProcessStartInfo();
        startInfo.FileName = "grim";
        startInfo.Arguments = path;
        startInfo.UseShellExecute = false;

        grim.StartInfo = startInfo;
        grim.Start();

    }


    DateTime CurrentDateAndTime = DateTime.Now;

    public TimeOnly CurrentTime() //get only time
    {
        TimeOnly Time = TimeOnly.FromDateTime(CurrentDateAndTime);
        return Time;
    }

    public DateOnly CurrentDate() //get only date
    {
        DateOnly Date = DateOnly.FromDateTime(CurrentDateAndTime);
        return Date;
    }




    //Get Day of the week and set the ss name

    public DayOfWeek Day() // Get Day of the week, Monday, Tuesday etc
    {
        return CurrentDateAndTime.DayOfWeek;
    }

    public string FileName() //Set the screenshot's name
    {
        return CurrentDateAndTime.ToString("yyyy-MM-dd_HH-mm-ss");
    }






    public string FolderCreate(string FolderName, string SubFolder) //Create the SubFolder
    {
        Directory.CreateDirectory("/home/dadadi/Desktop/" + FolderName + "/" + SubFolder);
        return "/home/dadadi/Desktop/" + FolderName + "/" + SubFolder;
    }


    public void TdyFolderCreate(string TdyFolder) // Create the main tdy's folder
    {
        Directory.CreateDirectory("/home/dadadi/Desktop/" + TdyFolder);
    }
}
