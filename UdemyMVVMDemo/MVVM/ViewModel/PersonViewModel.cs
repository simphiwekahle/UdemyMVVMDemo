using UdemyMVVMDemo.MVVM.Model;

namespace UdemyMVVMDemo.MVVM.ViewModel;

public class PersonViewModel
{
    public Person Person { get; set; }
    public PersonViewModel()
    {
        Person = new Person
        {
            Name = "Sphephelo",
            Age = 27
        };
    }
}
