using System;
using System.Collections.Generic;
using System.Text;

namespace SearchMoviesApp.Models
{
    public class Movie
    {
        public string Id { get; set; }
        public string ResultType { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
