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
    // 이름규약: 소문자로 시작하는 private 필드
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

        // 소문자 private필드가 대문자 public프로퍼티로 자동 생성됨
        MessageBox.Show($"Name: {Person.Name}\nAge: {Person.Age}", "Person Info");


        // 이것도 가능하다.
        var mainViewModel = Ioc.Default.GetService<MainViewModel>();
        MessageBox.Show(mainViewModel.Data);
    }
}