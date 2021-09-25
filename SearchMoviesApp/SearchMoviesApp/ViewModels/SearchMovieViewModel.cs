using SearchMoviesApp.Models;
using SearchMoviesApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SearchMoviesApp.ViewModels
{
    public class SearchMovieViewModel : BaseViewModel
    {
        public ObservableCollection<Movie> Movies { get; set; } = new ObservableCollection<Movie>();

        IMovieApiService _apiService;

        public ICommand SearchMovieCommand { get; }

        public string Expression { get; set; }

        public SearchMovieViewModel(IMovieApiService apiService)
        {
            _apiService = apiService;
            SearchMovieCommand = new Command(OnSearchMovie);
        }

        private async void OnSearchMovie()
        {
            Movies.Clear();
            await GetMovieList(Expression);
        }

        public async Task GetMovieList(string name)
        {

            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                var response = await _apiService.GetMoviesByNameAsync(name);

                if (response != null)
                {
                    foreach (var movie in response.Movies)
                    {
                        Movies.Add(movie);
                    }
                }
            }
            else
            {
                MainThread.BeginInvokeOnMainThread(async () =>
                {
                    await App.Current.MainPage.DisplayAlert("Alerta", "Conexion Fallida", "OK");
                });
            }
        }
        
    }
}
