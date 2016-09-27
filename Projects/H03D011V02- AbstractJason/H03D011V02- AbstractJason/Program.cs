using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using JsonReader;
namespace H03D011V02__AbstractJason
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var client = new WebClient())
            //{

            //var json = client.DownloadString("http://apis.is/company?name=" + ask);

            //JsonReader jr = new JsonReader(@"C:\Employees\Doe, John.json");
            //JsonReader jr = new JsonMockReade("{\"FirstName\":\"John\",\"LastName\":\"Doe\"}");
            JsonReader<Employee> jr = new JsonFileReader<Employee>(@"C:\Temp\John, Doe.txt");
            //JsonReader jr = new WebReader("http://ntv.is/api/employee/doe/john");

           
            Console.WriteLine(jr.GetObject().ToString());
            Console.ReadKey();

        }
    }
}
