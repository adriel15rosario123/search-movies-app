using System;
using System.Collections.Generic;
using System.Text;

namespace SearchMoviesApp.Services
{
    public interface IJsonSerializer
    {
        string Serialize(object payload);
        T Deserialize<T>(string payload);
    }
}
