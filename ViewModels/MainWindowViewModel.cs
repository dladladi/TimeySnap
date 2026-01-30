using System;
using System.Diagnostics;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;
using TimeySnap.Models;

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
        //num = num + 1;
        var SS = new Model();
        string smth = SS.GetDateTime();
        Greeting = "/home/dadadi/Desktop/" + smth + ".png";
        SS.TakeScreenShot("/home/dadadi/Desktop/" + smth + ".png");

    }
}
