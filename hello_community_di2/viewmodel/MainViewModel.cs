using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using hello_community.service;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;

namespace hello_community;


public partial class MainViewModel : ObservableObject
{
    // �̸��Ծ�: �ҹ��ڷ� �����ϴ� private �ʵ�
    [ObservableProperty]
    private Person _person;

    private readonly DataService _dataService;


    public MainViewModel(DataService dataService)
    {
        _dataService= dataService;


        Person = new Person
        {
            Name = "John Doe",
            Age = 30
        };
    }


    [ObservableProperty]
    private string _data;

    public void LoadData()
    {
        Data = _dataService.GetData();
    }


    [RelayCommand]
    private void ShowInfo()
    {
        Person.Name = Data;

        // �ҹ��� private�ʵ尡 �빮�� public������Ƽ�� �ڵ� ������
        MessageBox.Show($"Name: {Person.Name}\nAge: {Person.Age}", "Person Info");


        // �̰͵� �����ϴ�.
        var mainViewModel = Ioc.Default.GetService<MainViewModel>();
        MessageBox.Show(mainViewModel.Data);
    }
}