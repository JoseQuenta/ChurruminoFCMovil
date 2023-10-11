using ChurruminoFCMovil.VIEWS;
using Xamarin.Forms;

namespace ChurruminoFCMovil
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Inspecciones();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
