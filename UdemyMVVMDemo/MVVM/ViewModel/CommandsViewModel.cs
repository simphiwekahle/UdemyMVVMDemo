using System.Windows.Input;

namespace UdemyMVVMDemo.MVVM.ViewModel;

public class CommandsViewModel
{
    public ICommand ClickCommand { get; }
    public ICommand SearchCommand { get; }
    public string SearchTerm { get; set; }

    public CommandsViewModel()
    {
        ClickCommand = new Command(() =>
        {
            App.Current.MainPage
            .DisplayAlert("Title", "message", "Ok");
        });

        SearchCommand = new Command(() =>
        {
            var data = SearchTerm;
        });
    }
}
