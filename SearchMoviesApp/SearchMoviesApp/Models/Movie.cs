using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SearchMoviesApp.Models
{
    public class Movie
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resultType")]
        public string ResultType { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
