using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SearchMoviesApp.Services
{
    public class JsonSerializer : IJsonSerializer
    {
        public T Deserialize<T>(string payload) => JsonConvert.DeserializeObject<T>(payload);

        public string Serialize(object payload) => JsonConvert.SerializeObject(payload);
       
    }
}
