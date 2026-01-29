using System;
using System.Diagnostics;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace TimeySnap.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{

    int num = 0;
    [ObservableProperty]
    private string greeting = "0";

    public ICommand TakeSS { get; }

    public MainWindowViewModel()
    {
        TakeSS = new RelayCommand(SS);
        Greeting = num.ToString();
    }

    private void SS()
    {
        num = num + 1;
        Greeting = num.ToString();
        var grim = new Process();
        var startInfo = new ProcessStartInfo();
        startInfo.FileName = "grim";
        startInfo.Arguments = "/home/dadadi/Desktop/test.png";
        startInfo.UseShellExecute = false;

        grim.StartInfo = startInfo;
        grim.Start();

    }
}
