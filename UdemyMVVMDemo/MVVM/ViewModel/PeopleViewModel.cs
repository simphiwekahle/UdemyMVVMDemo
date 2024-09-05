namespace UdemyMVVMDemo.MVVM.ViewModel;

public class PeopleViewModel
{
    public List<string> People { get; set; }

    public PeopleViewModel()
    {
        People = new List<string>
        {
            "Sphephelo",
            "Melusi",
            "Endinako",
            "Siyabonga",
            "Clive"
        };
    }
}
