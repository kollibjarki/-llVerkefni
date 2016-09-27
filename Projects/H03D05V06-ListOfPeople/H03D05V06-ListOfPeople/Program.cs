using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace H03D05V06_ListOfPeople
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("núna er komið að þér kæri notandi að búa til persónu veldu nafn");
            string velja = Console.ReadLine();

            Console.WriteLine("Veldu kennitölu handa kallinum eða konunni");
            string ktnotanda = Console.ReadLine();

            Console.WriteLine("Halló hvernig ætlaru að hafa samband við þann sem þú byrð til..!! veldu símanúmer");
            string siminotanda = Console.ReadLine();

            Console.WriteLine(velja);


            person P1 = new person()
            {
                nafn = "Jóhanna",
                kt = "1208889919",
                simi = "5556867"
            };


            person P2 = new person()
            {
                nafn = "Erlendur Karl",
                kt = "1612932889",
                simi = "5812345"
            };

            ArrayList list = new ArrayList();


            list.Add(P1);
            list.Add(P2);

            foreach(person p in list)
            {
                Console.WriteLine(p.nafn);
            }

            foreach (person k in list)
            {
                k.BirtaUpplysingar();
            }

             Console.WriteLine("Nafn: {0} ", velja);
             Console.WriteLine("kennitala: {0} ",ktnotanda);
             Console.WriteLine("símanúmer {0} ", siminotanda);








            Console.ReadKey();
        }
    }
}
