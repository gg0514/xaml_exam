using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows;

namespace hello_community;


public partial class MainViewModel : ObservableObject
{
    // 이름규약: 소문자로 시작하는 private 필드
    [ObservableProperty]
    private Person _person;

    public MainViewModel()
    {
        Person = new Person
        {
            Name = "John Doe",
            Age = 30
        };
    }

    [RelayCommand]
    private void ShowInfo()
    {
        // 소문자 private필드가 대문자 public프로퍼티로 자동 생성됨
        MessageBox.Show($"Name: {Person.Name}\nAge: {Person.Age}", "Person Info");
    }
}