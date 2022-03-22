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
            AppCenter.Start("android=8588efb8-ccfa-4e0b-a1d5-e236d9fcbd28;ios=56f270e2-3a12-4410-b68b-a931f36f6cdb;uwp=e6e3ec3d-18a4-4951-ac02-9b2f5c7028d9",
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
