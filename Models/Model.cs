using System.Diagnostics;
using System;

namespace TimeySnap.Models;

public class Model
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

    public string GetDateTime()
    {
        return DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
    }

}
