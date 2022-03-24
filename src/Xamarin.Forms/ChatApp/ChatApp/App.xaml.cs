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
            AppCenter.Start("android=54b84698-ea4e-47cb-8c30-aa1e9abfa331;ios=56f270e2-3a12-4410-b68b-a931f36f6cdb",
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
