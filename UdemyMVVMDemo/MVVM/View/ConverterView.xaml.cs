using UdemyMVVMDemo.MVVM.ViewModel;

namespace UdemyMVVMDemo.MVVM.View;

public partial class ConverterView : ContentPage
{
	public ConverterView()
	{
		InitializeComponent();
		BindingContext = new ConvertersViewModel();
	}
}