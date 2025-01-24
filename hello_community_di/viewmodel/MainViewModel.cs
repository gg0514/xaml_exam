using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows;

namespace hello_community;


public partial class MainViewModel : ObservableObject
{
    // �̸��Ծ�: �ҹ��ڷ� �����ϴ� private �ʵ�
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
        // �ҹ��� private�ʵ尡 �빮�� public������Ƽ�� �ڵ� ������
        MessageBox.Show($"Name: {Person.Name}\nAge: {Person.Age}", "Person Info");
    }
}