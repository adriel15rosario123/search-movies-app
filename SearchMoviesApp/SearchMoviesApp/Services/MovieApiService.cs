using SearchMoviesApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace SearchMoviesApp.Services
{
    public class MovieApiService : IMovieApiService
    {
        IJsonSerializer serializer = new JsonSerializer();

        IImdbApi _api;

        public MovieApiService()
        {
            _api = RestService.For<IImdbApi>("https://imdb-api.com");
        }

        public async Task<GetMoviesResponse> GetMoviesByNameAsync(string expression)
        {
            var response = await _api.GetMoviesByNameAsync(expression);
            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();

                var moviesResponse = serializer.Deserialize<GetMoviesResponse>(responseString);

                return moviesResponse;
            }
            return null;
        }


    }
    
}
