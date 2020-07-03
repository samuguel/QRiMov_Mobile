using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App13.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace App13
{
	public partial class App : Application
	{
		public static String BancoDados;
		public static String Caminho;
		public App(string Caminho, string BancoDados)
		{
			InitializeComponent();
			App.BancoDados = BancoDados;
			App.Caminho = Caminho;

            MainPage = new NavigationPage(new PagePrincipal());

            NavigationPage.SetHasNavigationBar(this, false);
        }

		public App()
		{
			InitializeComponent();

            MainPage = new NavigationPage(new PagePrincipal());

            NavigationPage.SetHasNavigationBar(this, false);
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
