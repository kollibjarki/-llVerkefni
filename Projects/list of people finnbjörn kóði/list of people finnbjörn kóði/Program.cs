using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03D05V06_ListOfPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person()
            {
                Nafn = "Jóhanna",
                Kt = "1208889919",
                Simi = "555-6867"
            };

            Person p2 = new Person()
            {
                Nafn = "Karl",
                Kt = "0105803469",
                Simi = "411-1111"
            };

            // 1. Búið til lista (List) sem inniheldur
            //    þessar tvær manneskjur.
            List<Person> personur = new List<Person>();

            personur.Add(p1);
            personur.Add(p2);

            // 5. Notandinn býr til nýjar persónur þangað
            // til hann hefur "Nafn" tómt.
            // Hint: Notið "while" og "break"

            // 3. Bjóðið notandanum að bæta við
            //    nýrri persónu (þá þarf notandinn
            //    að gefa upp þrjú atriði). Bætið
            //    nýju persónunni í listann áður en
            //    þið prentið nafnið á öllum.
            while (true)
            {
                Person p3 = new Person();
                Console.Write("Nafn: ");
                p3.Nafn = Console.ReadLine();
                Console.Write("Kt.: ");
                p3.Kt = Console.ReadLine();
                Console.Write("Sími: ");
                p3.Simi = Console.ReadLine();

                personur.Add(p3);

                if (p3.Nafn=="")
                {
                    break;
                }

                personur.Add(p3);
            }
        
            








            // 2. Prentið nafn hverrar persónu
            //    listanum (hint: foreach)
            foreach (Person persona in personur)
            {
                //Console.WriteLine(persona.Nafn);

                // 4. Auka: Notið innbyggða möguleikann
                //    í Person til að prenta út upp-
                //    lýsingar um viðkomandi persónu
                //    í stað þess að prenta bara nafn.
                persona.BirtaUpplysingar();
            }

            Console.ReadKey();
        }
    }
}