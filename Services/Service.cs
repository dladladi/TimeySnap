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
        return CurrentDateAndTime.ToString("yyyy-MM-dd_HH-mm-ss");
    }

    public string FolderCreate(string FolderName, string SubFolder)
    {
        Directory.CreateDirectory("/home/dadadi/Desktop/" + FolderName + "/" + SubFolder);
        return "/home/dadadi/Desktop/" + FolderName + "/" + SubFolder;
    }

    public void TdyFolderCreate(string TdyFolder)
    {
        Directory.CreateDirectory("/home/dadadi/Desktop/" + TdyFolder);
    }
}
