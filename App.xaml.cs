namespace Pinzar_Adriana_Lab7
{
    public partial class App : Application
    {
        internal static object Database;

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}