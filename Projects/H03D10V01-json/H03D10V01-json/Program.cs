using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace H03D10V01_json
{
    class Program
    {
        static void Main(string[] args)
        {
        
                using (var client = new WebClient())
                {



                    Console.WriteLine("What kind of info do you need?? name(A)? or Ssnr(B)? or to see how many active(C)? or the address of the company(D)? Choose whisely: ");

                    string i = Console.ReadLine();



                if (i == "a")
                {



                    Console.WriteLine("Type in Name of Company: ");
                    string ask = Console.ReadLine();


                    var json = client.DownloadString("http://apis.is/company?name=" + ask);


                    CompanyList res = JsonConvert.DeserializeObject<CompanyList>(json);
                    Console.WriteLine(res.results[0]);





                }

                else if (i == "b")
                {
                    Console.WriteLine("Type in SocialSecurityNumber of Company: ");
                    string ask = Console.ReadLine();


                    var json = client.DownloadString("http://apis.is/company?sn=" + ask);


                    CompanyList res = JsonConvert.DeserializeObject<CompanyList>(json);
                    Console.WriteLine(res.results[0]);
                }


                //else if (i == "c")
                //{
                //    Console.WriteLine("Type in How many active Company: ");
                //    string ask = Console.ReadLine();


                //    var json = client.DownloadString("http://apis.is/company?active=" + ask);


                //    CompanyList res = JsonConvert.DeserializeObject<CompanyList>(json);
                //    Console.WriteLine(res.results[0]);
                //}


                else if (i == "c")
                {
                    Console.WriteLine("Type in address of Company: ");
                    string ask = Console.ReadLine();


                    var json = client.DownloadString("http://apis.is/company?address=" + ask);


                    CompanyList res = JsonConvert.DeserializeObject<CompanyList>(json);
                    //Console.WriteLine(res.results[5]);
                    foreach (var hi in res.results)
                    {
                        Console.WriteLine(hi);
                    }


                }




                    Console.ReadKey();
                }
            }
        }
    }
