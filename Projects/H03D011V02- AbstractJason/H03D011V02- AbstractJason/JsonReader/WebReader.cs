using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JsonReader

{
    class WebReader<T> : JsonReader<T>
    {
        

        public WebReader(string _Path): base(_Path)
        {
            using (var client = new WebClient())
            {
               JsonString = client.DownloadString(Path);

            }
        }

        //var json = client.DownloadString("http://apis.is/company?name=" + ask);


        //CompanyList res = JsonConvert.DeserializeObject<CompanyList>(json);
        //Console.WriteLine(res.results[0]);

    }
}
