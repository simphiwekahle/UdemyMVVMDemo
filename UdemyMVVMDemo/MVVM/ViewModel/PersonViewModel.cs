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
            Age = 27,
            Married = false,
            BirthDate = new DateTime(1997, 07, 05),
            Weight = 70,
            LunchTime = new TimeSpan(10, 0, 0)
        };
    }
}
