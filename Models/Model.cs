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


    public string Validation()
    {
        //List Periods
        TimeOnly MathsStart = new TimeOnly(15, 0, 0);
        TimeOnly MathsEnd = new TimeOnly(16, 0, 0);





        //Get Current Date and Time
        DateTime CurrenyDateAndTime = DateTime.Now;
        TimeOnly Time = TimeOnly.FromDateTime(CurrenyDateAndTime);
        DateOnly Date = DateOnly.FromDateTime(CurrenyDateAndTime);

        //Set FileName
        string FileName = CurrenyDateAndTime.ToString();


        if (Time >= MathsStart && Time <= MathsEnd)
        {
            return "Maths";
        }

        else return "None";
    }


    public void CreateFolders()
    {

    }

}
