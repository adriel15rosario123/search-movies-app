using SearchMoviesApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SearchMoviesApp.Services
{
    public interface IMovieApiService
    {

        Task<GetMoviesResponse> GetMoviesByNameAsync(string movieName);

    }
}
