using UdemyMVVMDemo.MVVM.Model;

namespace UdemyMVVMDemo.MVVM.ViewModel;

public class ConvertersViewModel
{
    public Data Data { get; set; }

    public ConvertersViewModel()
    {
        Data = new Data
        {
            Married = "Yes"
        };
    }
}
