namespace Pocket_Coach
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new Home();
            MainPage = new AppShell();
        }
    }
}
