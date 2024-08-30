using UdemyMVVMDemo.MVVM.Model;
using UdemyMVVMDemo.MVVM.ViewModel;

namespace UdemyMVVMDemo.MVVM.View;

public partial class PersonView : ContentPage
{
	public PersonView()
	{
		InitializeComponent();
		
		BindingContext = new PersonViewModel();
	}
}