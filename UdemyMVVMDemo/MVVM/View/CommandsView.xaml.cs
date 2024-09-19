using UdemyMVVMDemo.MVVM.ViewModel;

namespace UdemyMVVMDemo.MVVM.View;

public partial class CommandsView : ContentPage
{
	public CommandsView()
	{
		InitializeComponent();
		BindingContext = new CommandsViewModel();
	}
	
}