using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonReader

{
    public class JsonMockReader<T> : JsonReader<T>
    {

        public JsonMockReader(string _Path): base(_Path) 
        {
            JsonString = _Path;
        }


    }
}
