using CommunityToolkit.Mvvm.ComponentModel;

namespace hello_community;

public partial class Person : ObservableObject
{
    [ObservableProperty]
    private string _name;

    [ObservableProperty]
    private int _age;
}