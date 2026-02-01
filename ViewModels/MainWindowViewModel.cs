using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;
using TimeySnap.Models;
using TimeySnap.Services;

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
        var model = new Model();
        var service = new Service();


        string smth = model.Validation(service.CurrentTime(), service.CurrentDate());
        Greeting = "/home/dadadi/Desktop/" + smth + ".png";
        string path = service.FileCreate(smth);
        service.TakeScreenShot(path + "/test.png");

    }
}
