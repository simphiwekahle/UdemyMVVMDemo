using UdemyMVVMDemo.MVVM.ViewModel;

namespace UdemyMVVMDemo.MVVM.View;

public partial class PeopleView : ContentPage
{
	public PeopleView()
	{
		InitializeComponent();
		BindingContext = new PeopleViewModel();

    }
}