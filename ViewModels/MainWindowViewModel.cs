using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;
using TimeySnap.Models;
using TimeySnap.Services;

namespace TimeySnap.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{

    [ObservableProperty]
    private string greeting = "0";

    public ICommand TakeSS { get; }

    public MainWindowViewModel()
    {
        //Start All Validation and processes
        TakeSS = new RelayCommand(SS);
    }

    private void SS()
    {
        //Declare Models and Services
        var model = new Model();
        var service = new Service();

        //Declare path, FileName and FolderName
        string Date = service.CurrentDate().ToString("yyy-MM-dd"); //get tdy's date
        string FolderName = model.Validation(service.CurrentTime(), service.Day()); //get FolderName
        string path = service.FolderCreate(Date, FolderName); //Create folder and get the Dir of the folder
        string FileName = service.FileName(); //get the screenshot's name

        Greeting = FolderName; //test output for path to show on UI
        //service.TakeScreenShot(path + "/" + FileName + ".png"); //Create SS

    }
}
