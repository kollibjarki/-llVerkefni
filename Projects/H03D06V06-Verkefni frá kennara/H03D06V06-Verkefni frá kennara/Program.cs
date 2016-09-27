using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace H03D06V06_Verkefni_frá_kennara
{
   

           class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("Skráðu inn möppu að eigin vali herra minn góður: ");
                string svar = Console.ReadLine();


                string valinskra = (@"C:\Temp\" + svar + ".xml");
                Console.WriteLine(valinskra);

                Console.WriteLine("veldu nuna dýr ur þessari möppu sem tok þig 10 tima að bua til frekja annað hvort bua til eða sækja");
                string val = Console.ReadLine();
            Animal a = new Animal();
            Console.Write("nafn dýrs: {0}", a.name);
            string yo = Console.ReadLine();

            Console.Write("aldur dýrs: ", a.age);
            string yob = Console.ReadLine();






            Console.ReadKey();


            }
    }
}
