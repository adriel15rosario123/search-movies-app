using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SearchMoviesApp.Services
{
    public interface IImdbApi
    {

        [Get("/en/API/SearchMovie/API_KEY/{expression}")]
        Task<HttpResponseMessage> GetMoviesByNameAsync(string movieName);
    }
}
