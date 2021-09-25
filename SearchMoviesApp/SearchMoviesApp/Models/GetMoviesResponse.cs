using System;
using System.Collections.Generic;
using System.Text;

namespace SearchMoviesApp.Models
{
    public class GetMoviesResponse
    {
        public string SearchType { get; set; }
        public string Expression { get; set; }

        public List<Movie> Movies { get; set; }

        public string ErrorMessage { get; set; }
    }
}
