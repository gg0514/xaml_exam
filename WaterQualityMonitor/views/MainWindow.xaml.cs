using System.Diagnostics;
using System.Windows;
using WaterQualityMonitor.ViewModels;


namespace WaterQualityMonitor.Views;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow(MainWindowViewModel mainViewModel)
    {
        InitializeComponent();
        DataContext = mainViewModel;
    }
}