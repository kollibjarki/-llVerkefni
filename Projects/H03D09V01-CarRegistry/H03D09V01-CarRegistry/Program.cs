using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.Script.Serialization;
//using Newtonsoft.Json;
using JsonReader;

namespace H03D09V01_CarRegistry
{
    class Program
    {
        static void Main(string[] args)
        {





            // biðjði notandan um bílnúmer

            Console.WriteLine("enter license number");
            string ln = Console.ReadLine();

            string Path = "http://apis.is/car?number=" + ln;

            JsonReader<CarsList> car = new JsonWebReader<CarsList>(Path);



            //using (var client = new WebClient())
            //{

            //    Console.WriteLine("Choose Information to get: ");
            //    string ask = Console.ReadLine();
                

            //    var json = client.DownloadString("http://apis.is/car?number="+ask);


            //    CarsList res = JsonConvert.DeserializeObject<CarsList>(json);
                Console.WriteLine(car.GetObject().results[0]);

               


                Console.ReadKey();
            }
        }
    }

