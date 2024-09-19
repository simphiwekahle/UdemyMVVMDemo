using System.Windows.Input;

namespace UdemyMVVMDemo.MVVM.ViewModel;

public class CommandsViewModel
{
    public ICommand ClickCommand { get; }

    public CommandsViewModel()
    {
        ClickCommand = new Command(() =>
        {
            App.Current.MainPage
            .DisplayAlert("Title", "message", "Ok");
        });
    }
}
