using esports.Basics.View;
using esports.Controller;
using esports.ViewModel;
using Xamarin.Forms;
using XLabs.Forms.Mvvm;
using XLabs.Platform.Device;

namespace esports.Basics
{
	public class App : Application
	{
		public App()
		{
            //RegisterViews();
            //MainPage = new NavigationPage((Page)ViewFactory.CreatePage<MainViewModel, MainView>());

            MainPage = new Menu();
        }

		private void RegisterViews()
		{
			ViewFactory.Register<MainView, MainViewModel>();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
