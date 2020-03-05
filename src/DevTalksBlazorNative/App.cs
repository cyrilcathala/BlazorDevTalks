using DevTalksBlazorNative.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.MobileBlazorBindings;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using XF = Xamarin.Forms;

namespace DevTalksBlazorNative
{
    public class App : XF.Application
    {
        public App()
        {
            var host = MobileBlazorBindingsHost.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<IStorageService, StorageService>();
                })
                .Build();

            MainPage = new ContentPage();
            MainPage.On<iOS>().SetUseSafeArea(true);
            host.AddComponent<LoginPage>(parent: MainPage);
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
