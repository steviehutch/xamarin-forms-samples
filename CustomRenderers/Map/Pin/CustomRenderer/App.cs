using Xamarin.Forms;
using System.Collections.Generic;

namespace CustomRenderer
{
	public class App : Application
	{
        public static IList<string> MyPins {get; set;}

		public static double ScreenHeight;
		public static double ScreenWidth;

		public App ()
		{
            MyPins = new List<string>();
            MainPage = new MapPage ();
            //MainPage = new NavigationPage(new MainPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

