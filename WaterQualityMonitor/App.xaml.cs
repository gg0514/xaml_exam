using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using CommunityToolkit.Mvvm.DependencyInjection;
using WaterQualityMonitor.Services;
using WaterQualityMonitor.ViewModels;
using WaterQualityMonitor.Views;

namespace WaterQualityMonitor;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{

    public App()
    {
        Ioc.Default.ConfigureServices(
            new ServiceCollection()
                .AddSingleton<ISensorService, SensorService>()
                .AddSingleton<IFileService, FileService>()
                .AddSingleton<IMonitoringService, MonitoringService>()
                .AddSingleton<MainWindowViewModel>()
                .AddSingleton<MainWindow>() 
                .BuildServiceProvider()
        );
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        // MainWindow를 DI 컨테이너에서 가져와서 표시
        var mainWindow = Ioc.Default.GetService<MainWindow>();
        mainWindow.Show();
    }

}

