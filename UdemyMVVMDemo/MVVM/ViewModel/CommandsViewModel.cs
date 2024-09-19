using System.Windows.Input;

namespace UdemyMVVMDemo.MVVM.ViewModel;

public class CommandsViewModel
{
    public ICommand ClickCommand =>
        new Command(Alert);

    private void Alert()
    {
        App.Current.MainPage
            .DisplayAlert("Title", "message", "Ok");
    }
}
