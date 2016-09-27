using JsonReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlugSkráningarKerfiWPF
{
    class Flug
    {



        public string date { get; set; }
        public string Departed { get; set; }
        public string airline { get; set; }
        public string flightNumber { get; set; }
        public string to { get; set; }
        public string from { get; set; }
        public string plannedArrival { get; set; }
        public string realArrival { get; set; }
        public string status { get; set; }
        public string path = "http://apis.is/flight?language=en&type=departures";
        public string path2 = "http://apis.is/flight?language=en&type=arrivals";
        

        public Flug[] departures()
        {
            JsonReader<Fluglist> flugaaetlun = new JsonWebReader<Fluglist>(path);
            Fluglist fluglist = flugaaetlun.GetObject();

            return fluglist.results;
        }

        public Flug[] arrivals()
        {
            JsonReader<Fluglist> flugaaetlunA = new JsonWebReader<Fluglist>(path2);
            Fluglist fluglist = flugaaetlunA.GetObject();

            return fluglist.results;
        }

      
    }
}
