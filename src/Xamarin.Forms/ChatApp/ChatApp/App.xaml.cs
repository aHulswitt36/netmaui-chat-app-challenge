using ChatApp.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.WindowsSpecific;

namespace ChatApp
{
    public partial class App : Xamarin.Forms.Application
    {
        public App()
        {
            Current.On<Windows>().SetImageDirectory("Assets");

            InitializeComponent();

            MainPage = new NavigationPage(new HomeView());
        }

        protected override void OnStart()
        {
            AppCenter.Start("android=8588efb8-ccfa-4e0b-a1d5-e236d9fcbd28;",
                  typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
