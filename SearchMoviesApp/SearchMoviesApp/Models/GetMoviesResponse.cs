using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SearchMoviesApp.Models
{
    public class GetMoviesResponse
    {
        [JsonProperty("searchType")]
        public string SearchType { get; set; }

        [JsonProperty("expression")]
        public string Expression { get; set; }

        [JsonProperty("results")]
        public List<Movie> Movies { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }
    }
}
