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

namespace hello_behind;

public partial class MainWindow : Window, INotifyPropertyChanged
{
    private string _textValue;
    public string TextValue
    {
        get => _textValue;
        set
        {
            if (_textValue != value)
            {
                _textValue = value;
                OnPropertyChanged(nameof(TextValue));  // PropertyChanged 이벤트 호출
            }
        }
    }

    public MainWindow()
    {
        InitializeComponent();

        // DataContext를 코드에서 직접 설정
        this.DataContext = this;
    }

    private void OnButtonClick(object sender, RoutedEventArgs e)
    {
        // 버튼 클릭 시 TextValue를 변경
        TextValue = "Text has been changed!";
    }

    // INotifyPropertyChanged 구현
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}