using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonReader
{
    class JsonFileReader<T> : JsonReader<T>
    {
        public JsonFileReader(string _Path) : base(_Path)
        {
            string line;
            using (StreamReader sr = new StreamReader(Path, true))
            {
                while (true)
                {

                    line = sr.ReadLine();
                    if (line == null)
                    {
                        break;
                    }

                    JsonString += line;

                    



                }
            }

        }
    }
}