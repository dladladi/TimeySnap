using System;
using System.Diagnostics;
using System.IO;


namespace TimeySnap.Services;

public class Service
{
    public void TakeScreenShot(string path)
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

    public string BothDateAndTime()
    {
        return CurrentDateAndTime.ToString();
    }

    public TimeOnly CurrentTime()
    {
        TimeOnly Time = TimeOnly.FromDateTime(CurrentDateAndTime);
        return Time;
    }

    public DateOnly CurrentDate()
    {
        DateOnly Date = DateOnly.FromDateTime(CurrentDateAndTime);
        return Date;
    }

    public string FileName()
    {
        return CurrentDateAndTime.ToString();
    }

    public string FileCreate(string FolderName)
    {
        Directory.CreateDirectory("/home/dadadi/Desktop/" + FolderName);
        return "/home/dadadi/Desktop/" + FolderName;
    }
}
