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
        //Change the api key 
        [Get("/en/API/SearchMovie/k_6xveuhnv/{expression}")]
        Task<HttpResponseMessage> GetMoviesByNameAsync(string expression);
    }
}
