using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

public class PersonViewModel : ViewModelBase
{
    private Person _person;

    public Person Person
    {
        get => _person;
        set => Set(ref _person, value);  // Set 메서드를 사용하여 속성 값을 설정하고 PropertyChanged 이벤트를 자동으로 발생시킴
    }

    public RelayCommand ChangeNameCommand { get; private set; }

    public PersonViewModel()
    {
        // Person 객체 생성
        _person = new Person { Name = "John Doe" };

        // Command 초기화
        ChangeNameCommand = new RelayCommand(ChangeName);
    }

    // 이름을 변경하는 메소드
    private void ChangeName()
    {
        Person.Name = "Jane Doe";
    }
}