using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace H03D06V02_SeralizeClass
{
    class Program
    {
        static void Main(string[] args)
        {

            //Animal a = new Animal();

            //Console.Write("Animal name : ");
            //a.name = Console.ReadLine();

            //Console.Write("Animal Age: ");
            //a.age = Convert.ToInt32(Console.ReadLine());

            //a.ageInDogYears = a.age * 7;
            //Console.WriteLine("the dogs age in dog years is: {0}",a.ageInDogYears);

            //FileStream fs = new FileStream(@"C:\Temp\animal.dat", FileMode.OpenOrCreate);

            //BinaryFormatter bf = new BinaryFormatter();

            //bf.Serialize(fs, a);

            //fs.Close();
            //Console.ReadKey();



            Animal a;

            FileStream s = new FileStream(@"C:\Temp\animal.dat", FileMode.Open);

            BinaryFormatter bf = new BinaryFormatter();

            a = (Animal)bf.Deserialize(s);
            s.Close();


            Console.WriteLine(a.name);
            Console.WriteLine(a.age);
            Console.WriteLine(a.ageInDogYears);
            Console.ReadLine();

            Console.ReadKey();






        }
    }
}
