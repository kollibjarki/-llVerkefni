using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonReader

{
    public abstract class JsonReader<T>
    {
        protected string Path { get; set; }
        protected string JsonString { get; set; }
        public JsonReader(string _Path)
        {
            Path = _Path;
            //JsonString = "{\"FirstName\":\"John\",\"LastName\":\"Doe\"}";
        }

        public string GetJsonData()
        {
            return JsonString;
        }

        public T GetObject()
        {
           T obj  = JsonConvert.DeserializeObject<T>(GetJsonData());
            return obj;
        }


    }
}
