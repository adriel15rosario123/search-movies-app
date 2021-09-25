using SearchMoviesApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SearchMoviesApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SearchMoviePage();
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
