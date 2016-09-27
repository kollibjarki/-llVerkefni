using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace H03D06V01_Deserialization
{
    class Program
    {
        static void Main(string[] args)
        {

            string strengur;


            FileStream fs = new FileStream(@"C:\Temp\st.dat", FileMode.OpenOrCreate);

            BinaryFormatter bf = new BinaryFormatter();

            strengur = (string)bf.Deserialize(fs);
            Console.WriteLine("strengurinn seigir: '{0}'", strengur);



            fs.Close();

            Console.ReadKey();


        }
    }
}
