using System.Diagnostics;

namespace TimeySnap.Models;

public class Grim
{
    public void hehe(string path)
    {
        Process.Start("grim", path);
    }
}
