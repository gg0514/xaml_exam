using System.Configuration;
using System.Data;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using CommunityToolkit.Mvvm.DependencyInjection;
using hello_community.service;

namespace hello_community;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{

    public App()
    {
        // DI 컨테이너 구성
        Ioc.Default.ConfigureServices(new ServiceCollection()
            .AddSingleton<DataService>()     // DataService 등록
            .AddSingleton<MainViewModel>() 
            .AddSingleton<MainWindow>() 
            .BuildServiceProvider());
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        // MainWindow를 DI 컨테이너에서 가져와서 표시
        var mainWindow = Ioc.Default.GetService<MainWindow>();
        mainWindow.Show();
    }

}

