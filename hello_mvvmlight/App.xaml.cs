using System.Configuration;
using System.Data;
using System.Windows;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;



namespace hello_mvvmlight;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    // ViewModel 설정
    ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
    SimpleIoc.Default.Register<PersonViewModel>();

    // MainWindow 설정
    var mainWindow = new MainWindow
    {
        DataContext = ServiceLocator.Current.GetInstance<PersonViewModel>()
    };
    mainWindow.Show();    
}

