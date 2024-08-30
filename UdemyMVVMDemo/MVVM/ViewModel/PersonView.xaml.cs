using UdemyMVVMDemo.MVVM.Model;

namespace UdemyMVVMDemo.MVVM.ViewModel;

public partial class PersonView : ContentPage
{
	public PersonView()
	{
		InitializeComponent();
		var person = new Person
		{
			Name = "Sphephelo",
			Age = 27
		};

		BindingContext = person;
	}
}