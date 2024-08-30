using UdemyMVVMDemo.MVVM.ViewModel;

namespace UdemyMVVMDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PersonView();
        }
    }
}
