using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using hello_behind.model;

namespace hello_behind;

public partial class MainWindow : Window
{
    private Sample _sample = new Sample();

    public MainWindow()
    {
        InitializeComponent();

        // DataContext를 코드에서 직접 설정
        this.DataContext = _sample;
        _sample.TextValue = "Hello, World!";
    }

    private void OnButtonClick(object sender, RoutedEventArgs e)
    {
        // 버튼 클릭 시 TextValue를 변경
        _sample.TextValue = "Text has been changed!";
    }

    //private void Sample_PropertyChanged(object sender, PropertyChangedEventArgs e)
    //{
    //    Console.WriteLine($"{e.PropertyName} has changed!");
    //}

}